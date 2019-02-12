Imports Administrativo.DAL

''' <summary>
''' Camada de negócio da classe DataBaseBLL.vb
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
''' </remarks>

Public Class DataBaseBLL
    Implements IDataBase

    Dim objDataBase As New DataBaseDAL
    ''' <summary>
    ''' Recarrega o ComboBox informado no parâmetro para receber todos os Bancos
    ''' </summary>
    ''' <param name="pDataBaseComboBoxEdit">ComboBox que será preenchido</param>
    ''' <param name="pstrServer">Endereço do Servidor</param>
    ''' <param name="pstrUsuario">Usuário</param>
    ''' <param name="pstrSenha">Senha</param>
    ''' <remarks>Camada de negócio - Refresh DataBase</remarks>
    Public Sub RefreshDataBase(pDataBaseComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit, pstrServer As String, pstrUsuario As String, pstrSenha As String) Implements DAL.IDataBase.RefreshDataBase
        If String.IsNullOrEmpty(pstrServer) Then Throw New Exception("O servidor deve ser informado")
        If String.IsNullOrEmpty(pstrUsuario) Then Throw New Exception("O usuário deve ser informado")
        objDataBase.RefreshDataBase(pDataBaseComboBoxEdit, pstrServer, pstrUsuario, pstrSenha)
    End Sub

    ''' <summary>
    ''' Recarrega o ComboBox informado no parâmetro para receber todos os Bancos
    ''' </summary>
    ''' <param name="pDataBaseComboBoxEdit">ComboBox que será preenchido</param>
    ''' <param name="pstrServer">Endereço do Servidor</param>
    ''' <param name="pstrUsuario">Usuário</param>
    ''' <param name="pstrSenha">Senha</param>
    ''' <param name="pstrPorta">Numero da Porta</param>
    ''' <remarks>Camada de negócio - Refresh DataBase</remarks>
    Public Sub RefreshDataBase(pDataBaseComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit, pstrServer As String, pstrUsuario As String, pstrSenha As String, pstrPorta As String) Implements DAL.IDataBase.RefreshDataBase
        If String.IsNullOrEmpty(pstrServer) Then Throw New Exception("O servidor deve ser informado")
        If String.IsNullOrEmpty(pstrPorta) Then Throw New Exception("A porta deve ser informada")
        If String.IsNullOrEmpty(pstrUsuario) Then Throw New Exception("O usuário deve ser informado")
        objDataBase.RefreshDataBase(pDataBaseComboBoxEdit, pstrServer, pstrUsuario, pstrSenha, pstrPorta)
    End Sub

    ''' <summary>
    ''' Realiza a conexão com o banco de dados, e informa se a conexão foi positiva ou negativa
    ''' </summary>
    ''' <returns>Retorna um Boolean que Informar se a tentativa de conexão foi positiva ou negativa.</returns>
    ''' <remarks>Camada de negócio - Conectar DataBase</remarks>
    Public Function ConectarDataBase() As Boolean Implements DAL.IDataBase.ConectarDataBase
        Try
            Return objDataBase.ConectarDataBase()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' Executa a Query e retorna o resultado. O retorno é somente da primeira Coluna e Linha
    ''' </summary>
    ''' <param name="pstrQuery">Query</param>
    ''' <returns>Retorna em um objeto a Primeira Coluna e a Primeira Linha de um consulta</returns>
    ''' <remarks> Camada de negócio - Query Simples</remarks>
    Public Function QuerySimples(pstrQuery As String) As Object Implements DAL.IDataBase.QuerySimples
        Try
            Return objDataBase.QuerySimples(pstrQuery)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' Executa todos tipos de Querys
    ''' </summary>
    ''' <param name="pstrQuery">Query</param>
    ''' <returns>Retorna o resultado da Query em um objeto</returns>
    ''' <remarks>Camada de negócio - Query Full</remarks>
    Public Function QueryFull(pstrQuery As String) As Object Implements DAL.IDataBase.QueryFull
        Try
            Return objDataBase.QueryFull(pstrQuery)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' Executa um Query e retorna em um XPDataView.
    ''' </summary>
    ''' <param name="pstrQuery">Query(Select)</param>
    ''' <returns>O retorno do resultado da consulta é em um XPDataView.</returns>
    ''' <remarks>Camada de negócio - Query De consulta</remarks>
    Public Function QueryDataView(pstrQuery As String) As DevExpress.Xpo.XPDataView Implements DAL.IDataBase.QueryDataView
        Try
            Return objDataBase.QueryDataView(pstrQuery)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' O Sistema busca todas as informações do banco de dados referente ao Software, Produto e Banco de Dados
    ''' </summary>
    ''' <param name="pstrNomeProduto">Neste parâmetro é informado Software, Produto e Banco de Dados, e é informado com um delimitador "|" entre cada informação</param>
    ''' <remarks>Camada de negócio - Busca Configuração Banco Dados</remarks>
    Public Sub BuscaConfiguracaoBancoDados(pstrNomeProduto As String) Implements DAL.IDataBase.BuscaConfiguracaoBancoDados
        Try
            objDataBase.BuscaConfiguracaoBancoDados(pstrNomeProduto)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Esta função não retorna uma resultado do banco
    ''' </summary>
    ''' <param name="pstrQuery">Query para ser executados no Banco de Dados</param>
    ''' <remarks>Camada de Negócio - NonQuery</remarks>
    Public Sub NonQuery(pstrQuery As Object) Implements DAL.IDataBase.NonQuery
        Try
            objDataBase.NonQuery(pstrQuery)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Cria Tabela temporaria. Use a tag no comando from para ter compatibilidade no Postgres e no SqlServer
    ''' </summary>
    ''' <param name="pstrTabela">Nome da tabela e mais "#" no início do nome</param>
    ''' <param name="pstrQuery">comando select para popular a temporaria</param>
    ''' <remarks>Camada de Negócio - CriaTemporaria</remarks>
    Public Sub CriaTemporaria(pstrTabela As String, pstrQuery As String) Implements DAL.IDataBase.CriaTemporaria
        Try
            objDataBase.CriaTemporaria(pstrTabela, pstrQuery)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Apaga a tabela temporaria
    ''' </summary>
    ''' <param name="pstrTabela">Nome da tabela e mais "#" no início do nome</param>
    ''' <remarks>Camada de Negócio - ApagarTemporaria</remarks>
    Public Sub ApagarTemporaria(pstrTabela As String) Implements DAL.IDataBase.ApagarTemporaria
        Try
            objDataBase.ApagarTemporaria(pstrTabela)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class
