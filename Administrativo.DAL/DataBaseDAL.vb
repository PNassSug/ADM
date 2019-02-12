Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports Administrativo.Modelo

''' <summary>
''' Camada de acesso a dados da classe DataBaseBLL.vb
''' </summary>
''' <remarks>
''' Nesta camada de negócio o sistema vai realizar as seguintes buscas:
''' Atualiza Banco de dados (RefreshDataBase)
''' Conectar Com Banco de Dados
''' Executar Query Simples
''' Executar Query Full 
''' Executar Query Visualização
''' Busca de Configuração do Banco de Dados
''' NonQuery
''' Conversor de SQL (ParserSQL)
''' </remarks>

Public Class DataBaseDAL
    Implements IDataBase
    ''' <summary>
    ''' Recarrega o ComboBox informado no parâmetro para receber todos os Bancos
    ''' </summary>
    ''' <param name="pDataBaseComboBoxEdit">ComboBox que será preenchido</param>
    ''' <param name="pstrServer">Endereço do Servidor</param>
    ''' <param name="pstrUsuario">Usuário</param>
    ''' <param name="pstrSenha">Senha</param>
    ''' <remarks>Camada de acesso a dados - Refresh DataBase</remarks>
    Public Sub RefreshDataBase(pDataBaseComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit, pstrServer As String, pstrUsuario As String, pstrSenha As String) Implements IDataBase.RefreshDataBase
        Dim strConexao As String = String.Empty
        Dim strSql As String = String.Empty

        strConexao = "Server=" + pstrServer + ";Database=;User Id=" + pstrUsuario + ";Password=" + pstrSenha + ";"
        strSql = "select name from sys.databases where not name in ('master','tempdb','model','msdb')"

        'Abre Conexão sem utilizar o XPO
        Dim conSqlClient As New SqlClient.SqlConnection(strConexao)
        Dim cmdSqlClient As New SqlClient.SqlCommand("select name from sys.databases where not name in ('master','tempdb','model','msdb') order by name", conSqlClient)
        Dim drSqlClient As SqlClient.SqlDataReader

        Try
            conSqlClient.Open()

            drSqlClient = cmdSqlClient.ExecuteReader
            Do While drSqlClient.Read
                pDataBaseComboBoxEdit.Properties.Items.Add(drSqlClient("name"))
            Loop
            drSqlClient.Close()

        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            conSqlClient.Close()
            conSqlClient.Dispose()
        End Try

    End Sub
    ''' <summary>
    ''' Recarrega o ComboBox informado no parâmetro para receber todos os Bancos
    ''' </summary>
    ''' <param name="pDataBaseComboBoxEdit">ComboBox que será preenchido</param>
    ''' <param name="pstrServer">Endereço do Servidor</param>
    ''' <param name="pstrUsuario">Usuário</param>
    ''' <param name="pstrSenha">Senha</param>
    ''' <param name="pstrPorta">Numero da Porta</param>
    ''' <remarks>Camada de acesso a dados - Refresh DataBase</remarks>
    Public Sub RefreshDataBase(pDataBaseComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit, pstrServer As String, pstrUsuario As String, pstrSenha As String, pstrPorta As String) Implements IDataBase.RefreshDataBase
        Dim strConexao As String = String.Empty
        Dim strSql As String = String.Empty

        strConexao = "Server=" + pstrServer + ";Port=" + pstrPorta + ";Database=template1;User Id=" + pstrUsuario + ";Password=" + pstrSenha + ";"
        strSql = "select datname from pg_database where datistemplate = false"

        'Abre Conexão sem utilizar o XPO
        Dim conNpgsql As New Npgsql.NpgsqlConnection(strConexao)
        Dim cmdNpgsql As New Npgsql.NpgsqlCommand("select datname from pg_database where datistemplate = false order by datname", conNpgsql)
        Dim drNpgsql As Npgsql.NpgsqlDataReader

        Try
            conNpgsql.Open()

            drNpgsql = cmdNpgsql.ExecuteReader
            pDataBaseComboBoxEdit.Properties.Items.Clear()
            Do While drNpgsql.Read
                pDataBaseComboBoxEdit.Properties.Items.Add(drNpgsql("datname"))
            Loop
            drNpgsql.Close()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            conNpgsql.Close()
            conNpgsql.Dispose()
        End Try

    End Sub
    ''' <summary>
    ''' Realiza a conexão com o banco de dados, e informa se a conexão foi positiva ou negativa
    ''' </summary>
    ''' <returns>Retorna um Boolean que Informar se a tentativa de conexão foi positiva ou negativa.</returns>
    ''' <remarks>Camada de acesso a dados - Conectar DataBase</remarks>
    Public Function ConectarDataBase() As Boolean Implements IDataBase.ConectarDataBase
        Try
            XpoDefault.DataLayer = Nothing
            Dim strStringConnection As String = String.Empty
            If databaseInfo.Tipo = "POSTGRES" Then
                strStringConnection = PostgreSqlConnectionProvider.GetConnectionString(databaseInfo.Server, databaseInfo.Porta, databaseInfo.Usuario, databaseInfo.Senha, databaseInfo.BancoDados)
            ElseIf databaseInfo.Tipo = "MSSQL" Then
                strStringConnection = MSSqlConnectionProvider.GetConnectionString(databaseInfo.Server, databaseInfo.Usuario, databaseInfo.Senha, databaseInfo.BancoDados)
            End If

            XpoDefault.DataLayer = XpoDefault.GetDataLayer(strStringConnection, AutoCreateOption.DatabaseAndSchema)

            If XpoDefault.Session.IsConnected Then
                XpoDefault.Session.Disconnect()
            End If
            Return True
        Catch ex As Exception
            databaseInfo.Conexao = False
            Throw New Exception(ex.Message)
        Finally
            If XpoDefault.Session.IsConnected Then
                XpoDefault.Session.Disconnect()
            End If
        End Try
    End Function
    ''' <summary>
    ''' Executa a Query e retorna o resultado. O retorno é somente da primeira Coluna e Linha 
    ''' </summary>
    ''' <param name="pstrQuery">Query</param>
    ''' <returns>Retorna em um objeto a Primeira Coluna e a Primeira Linha de um consulta</returns>
    ''' <remarks>Camada de acesso a dados - Query Simples</remarks>
    Public Function QuerySimples(pstrQuery As String) As Object Implements IDataBase.QuerySimples
        Try
            Dim un As New UnitOfWork
            Return un.ExecuteScalar(ParserSQL(pstrQuery))

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    ''' <summary>
    ''' Executa todos tipos de Querys
    ''' </summary>
    ''' <param name="pstrQuery">Query</param>
    ''' <returns>Retorna o resultado da Query em um objeto</returns>
    ''' <remarks>Camada de acesso a dados - Query Full</remarks>
    Public Function QueryFull(pstrQuery As String) As Object Implements IDataBase.QueryFull
        Try
            Dim un As New UnitOfWork
            Return un.ExecuteQueryWithMetadata(ParserSQL(pstrQuery))
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    ''' <summary>
    ''' Executa um Query e retorna em um XPDataView.
    ''' </summary>
    ''' <param name="pstrQuery">Query(Select)</param>
    ''' <returns>O retorno do resultado da consulta é em um XPDataView.</returns>
    ''' <remarks>Camada de acesso a dados - Query De consulta</remarks>
    Public Function QueryDataView(pstrQuery As String) As DevExpress.Xpo.XPDataView Implements IDataBase.QueryDataView
        Try
            Dim sdData As SelectedData = QueryFull(ParserSQL(pstrQuery))

            Dim dvData As New XPDataView
            For Each row As SelectStatementResultRow In sdData.ResultSet(0).Rows
                dvData.AddProperty(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
            Next
            dvData.LoadData(New SelectedData(sdData.ResultSet(1)))

            Return dvData
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    ''' <summary>
    ''' O Sistema busca todas as informações do banco de dados referente ao Software, Produto e Banco de Dados
    ''' </summary>
    ''' <param name="pstrNomeProduto">Neste parâmetro é informado Software, Produto e Banco de Dados, e é informado com um delimitador "|" entre cada informação</param>
    ''' <remarks>Camada de acesso a dados - Busca Configuração Banco Dados</remarks>
    Public Sub BuscaConfiguracaoBancoDados(pstrNomeProduto As String) Implements IDataBase.BuscaConfiguracaoBancoDados
        Try
            Dim objRegistro As New RegistroDAL
            Dim aRegistro = Split(objRegistro.LocalizaChaveRegistro("Software", pstrNomeProduto, "DataBase"), "|")
            If aRegistro.Length = 7 Then
                For iField As Int32 = 0 To UBound(aRegistro)
                    If iField = 0 Then databaseInfo.Conexao = Convert.ToBoolean(aRegistro(iField)).ToString
                    If iField = 1 Then databaseInfo.Tipo = aRegistro(iField).ToString
                    If iField = 2 Then databaseInfo.Server = aRegistro(iField).ToString
                    If iField = 3 Then databaseInfo.Porta = aRegistro(iField).ToString
                    If iField = 4 Then databaseInfo.Usuario = aRegistro(iField).ToString
                    If iField = 5 Then databaseInfo.Senha = aRegistro(iField).ToString
                    If iField = 6 Then databaseInfo.BancoDados = aRegistro(iField).ToString
                Next
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' Camada de acesso a dados - NonQuery
    ''' </summary>
    ''' <param name="pstrQuery">Query para ser executados no Banco de Dados</param>
    ''' <remarks>Esta função não retorna uma resultado do banco</remarks>
    Public Sub NonQuery(pstrQuery As Object) Implements IDataBase.NonQuery
        Dim un As New UnitOfWork
        un.BeginTransaction()
        Try
            un.ExecuteNonQuery(ParserSQL(pstrQuery))
            un.CommitTransaction()
        Catch ex As Exception
            un.RollbackTransaction()
            Dim strMensagem As String = RetornaErroUsuario(ex.InnerException.ToString)
            Throw New Exception(strMensagem)
        End Try
    End Sub

    Public Sub CriaTemporaria(pstrTabela As String, pstrQuery As String) Implements IDataBase.CriaTemporaria
        Dim un As New UnitOfWork
        un.BeginTransaction()
        Try
            pstrQuery = ParserSQL(pstrQuery)
            If databaseInfo.Tipo = "MSSQL" Then
                pstrQuery = pstrQuery.Replace("<from>", "into """ + pstrTabela + """ from")
            Else
                pstrQuery = pstrQuery.Replace("<from>", "from")
                pstrQuery = "CREATE TEMPORARY TABLE """ + pstrTabela + """ AS " + pstrQuery
            End If
            un.ExecuteNonQuery(pstrQuery)
            un.CommitTransaction()
        Catch ex As Exception
            un.RollbackTransaction()
            Dim strMensagem As String = RetornaErroUsuario(ex.InnerException.ToString)
            Throw New Exception(strMensagem)
        End Try
    End Sub

    Public Sub ApagarTemporaria(pstrTabela As String) Implements IDataBase.ApagarTemporaria
        Dim un As New UnitOfWork
        un.BeginTransaction()
        Try
            un.ExecuteNonQuery("DROP TABLE " + pstrTabela + "")
            un.CommitTransaction()
        Catch ex As Exception
            un.RollbackTransaction()
            Dim strMensagem As String = RetornaErroUsuario(ex.InnerException.ToString)
            Throw New Exception(strMensagem)
        End Try
    End Sub
    ''' <summary>
    ''' Camada de acesso a dados - Conversor SQL(ParserSQL)
    ''' </summary>
    ''' <param name="pstrQuery">Query</param>
    ''' <returns>Query convertida</returns>
    ''' <remarks>Recebe uma Query, e converte a Query para o tipo correto do DataBase.</remarks>
    Private Function ParserSQL(ByRef pstrQuery As String) As String
        Try
            If databaseInfo.Tipo = "MSSQL" Then
                pstrQuery = pstrQuery.Replace("gd_", "dbo.gd_")
                pstrQuery = pstrQuery.Replace("<concat>", "+")
            Else
                pstrQuery = pstrQuery.Replace("<concat>", "||")
            End If
            Return pstrQuery
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    ''' <summary>
    ''' Camada de acesso a dados - 
    ''' </summary>
    ''' <param name="strErrorDb">String de Erro</param>
    ''' <returns>Retorna o Erro que ocorreu na execução da Query</returns>
    ''' <remarks>Essa função reestrutura a mensagem de erro na hora de execução.</remarks>
    Private Function RetornaErroUsuario(strErrorDb As String) As String
        Dim strConstraint As String = String.Empty
        Dim strSeparador As String = String.Empty
        Try
            RetornaErroUsuario = strErrorDb
            strSeparador = Chr(34)

            If strErrorDb.IndexOf(strSeparador) = 0 Then
                strSeparador = "'"
            End If

            If strErrorDb.ToLower.IndexOf("gd_fk") > 0 And strErrorDb.IndexOf(strSeparador) > 0 Then
                strConstraint = strErrorDb.Substring(strErrorDb.ToLower.IndexOf("gd_fk"), strErrorDb.Length - strErrorDb.ToLower.IndexOf("gd_fk"))
                If strErrorDb.IndexOf(strSeparador) > 0 Then
                    strConstraint = strConstraint.Substring(0, strErrorDb.IndexOf(strSeparador) - 4)
                ElseIf strErrorDb.IndexOf(Chr(32)) > 0 Then
                    strConstraint = strConstraint.Substring(0, strErrorDb.IndexOf(Chr(32)) - 4)
                End If
                Dim strField As String = String.Empty

                If strErrorDb.ToLower.IndexOf("delete") > 0 Or strErrorDb.ToLower.IndexOf("exclusão") > 0 Then
                    strField = "msgdelete"
                Else
                    strField = "msgupdate"
                End If

                Dim sdData As SelectedData = QueryFull("select " + strField + " " +
                                                         "from constraints con " +
                                                        "where con.name_ = '" + strConstraint + "'")
                Dim strMensagem As String = String.Empty
                For Each row As SelectStatementResultRow In sdData.ResultSet(1).Rows
                    strMensagem = row.Values(0).ToString
                Next row

                If String.IsNullOrEmpty(strMensagem) Then
                    strMensagem = strErrorDb
                End If
                Return strMensagem
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class


