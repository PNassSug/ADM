Imports Administrativo.Modelo
Imports Administrativo.WS
Imports System.Math
Imports DevExpress.Xpo.DB
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraRichEdit

Public Class UsuarioDAL
    Implements IUsuario

    Public Function LoginValido(pstrUsuario As String, pstrSenha As String) As Boolean Implements IUsuario.LoginValido
        Try
            Dim objDataBase As New DataBaseDAL
            Dim strSenha As String = String.Empty

            Dim sdData As SelectedData = objDataBase.QueryFull("select usu.senha, usu.usuariomaster, niv.nivel, usu.alertarvencimentoobrigacao, usu.diasantesalerta " +
                                                                 "from usuarios usu " +
                                                                 "join usernivel niv on niv.login = usu.login and niv.sistema = 'Administrativo' " +
                                                                "where usu.login = '" + pstrUsuario + "'")

            For Each row As SelectStatementResultRow In sdData.ResultSet(1).Rows
                usuarioInfo.usuario = pstrUsuario
                strSenha = row.Values(0).ToString
                usuarioInfo.master = Convert.ToBoolean(row.Values(1))
                usuarioInfo.nivel = row.Values(2).ToString
                usuarioInfo.alertarvencimento = Convert.ToBoolean(row.Values(3))
                usuarioInfo.diasalerta = Convert.ToInt32(row.Values(4))
            Next row

            If String.IsNullOrEmpty(strSenha) Then Throw New Exception("Usuário inexistente")

            Dim senhaValida As Boolean = strSenha = StrToAsc(EnCrypt(pstrSenha))

            If senhaValida Then
                Dim intCount As Int32 = Convert.ToInt32(objDataBase.QuerySimples("select count(*) " +
                                                                                       "from admobrigacoesusuarios u " +
                                                                                      "where u.usuario = '" + usuarioInfo.usuario + "'"))
                usuarioInfo.obrigacoes = (intCount > 0)
            Else
                If Not usuarioInfo.trocausuario Then
                    usuarioInfo.usuario = String.Empty
                    usuarioInfo.master = False
                    usuarioInfo.nivel = String.Empty
                    usuarioInfo.alertarvencimento = False
                    usuarioInfo.diasalerta = 0
                End If
                Throw New Exception("Senha inválida.")
            End If

            Return senhaValida
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Private Function StrToAsc(cTexto As String) As String
        Dim intCaracter As Integer, strRetorno As String
        strRetorno = String.Empty
        For intCaracter = 1 To cTexto.Trim.Length
            Dim x As String = "000" + Asc(cTexto.Substring(intCaracter - 1, 1)).ToString
            strRetorno += x.Substring(x.Length - 3)
        Next intCaracter
        StrToAsc = strRetorno
    End Function

    Private Function AscToStr(cTexto As String, Optional Bloco As Integer = 3) As String
        Dim intCaracter As Integer, strRetorno As String
        strRetorno = String.Empty
        intCaracter = 1
        Do While True
            If IsNumeric(Mid(Trim(cTexto), intCaracter, Bloco)) Then
                strRetorno = strRetorno + Chr(Mid(Trim(cTexto), intCaracter, Bloco))
            End If
            intCaracter = intCaracter + Bloco
            If intCaracter > (Len(Trim(cTexto)) \ Bloco) * Bloco Then
                Exit Do
            End If
        Loop
        AscToStr = strRetorno
    End Function

    Private Function EnCrypt(cTexto As String) As String
        Dim nAsc As Integer
        EnCrypt = ""
        For ni = 1 To Len(cTexto)
            If IsPair(ni) Then
                nAsc = Asc(Mid(cTexto, ni, 1)) + 50 + ni
            Else
                nAsc = Asc(Mid(cTexto, ni, 1)) + 50 - ni
            End If

            If nAsc > 255 Then
                nAsc = nAsc Mod 255
            ElseIf nAsc < 0 Then
                nAsc = 255 - Sqrt(nAsc ^ 2)
            End If
            EnCrypt = EnCrypt + Chr(nAsc)
        Next
    End Function

    Private Function DeCrypt(cTexto As String) As String
        Dim nAsc As Integer
        DeCrypt = ""
        For ni = 1 To Len(cTexto)
            If IsPair(ni) Then
                nAsc = Asc(Mid(cTexto, ni, 1)) - 50 - ni
            Else
                nAsc = Asc(Mid(cTexto, ni, 1)) - 50 + ni
            End If

            If nAsc > 255 Then
                nAsc = nAsc Mod 255
            ElseIf nAsc < 0 Then
                nAsc = 255 - Sqrt(nAsc ^ 2)
            End If
            DeCrypt = DeCrypt + Chr(nAsc)
        Next
    End Function

    Private Function IsPair(nValor) As Boolean
        IsPair = (nValor Mod 2) - 1
    End Function

    Public Sub Grid(ByRef pstrQuery As String, pdgGrid As DevExpress.XtraGrid.GridControl, pgvGrid As DevExpress.XtraGrid.Views.Grid.GridView) Implements IUsuario.Grid
        Try
            Dim objDataBase As New DataBaseDAL
            pdgGrid.DataSource = objDataBase.QueryDataView(pstrQuery)

            ' Definição de Mascarás no Grid
            pgvGrid.Columns(0).Caption = "Login"
            pgvGrid.Columns(0).Width = 100

            pgvGrid.Columns(1).Caption = "Nome"
            pgvGrid.Columns(1).Width = 300

            pgvGrid.Columns(2).Caption = "Email"
            pgvGrid.Columns(2).Width = 150

            pgvGrid.Columns(3).Caption = "Departamento"
            pgvGrid.Columns(3).Width = 150

            pgvGrid.Columns(4).Caption = "Grupo"
            pgvGrid.Columns(4).Width = 80

            pgvGrid.Columns(5).Caption = "Usuário Master"
            pgvGrid.Columns(5).Width = 80

            pgvGrid.Columns(6).Caption = "Nível"
            pgvGrid.Columns(6).Width = 80

            pgvGrid.Columns(7).Visible = False
            pgvGrid.Columns(8).Visible = False
            pgvGrid.Columns(9).Visible = False

            pdgGrid.ForceInitialize()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub IUDUsuarios(ByRef pstrOperacao As String, ByRef infoUsuarios As Modelo.usuariocadastroInfo) Implements IUsuario.IUDUsuarios
        Try
            Dim objDataBase As New DataBaseDAL
            Dim strQuery As String = String.Empty

            If pstrOperacao = "inclusao" Then
                Dim intCount As Int32 = objDataBase.QuerySimples("select count(*) " +
                                                                   "from usuarios u " +
                                                                   "where u.login = '" + infoUsuarios.login + "'")
                If intCount = 0 Then
                    strQuery = "insert into usuarios(login, senha, email, departamento, nome, usuariomaster, alertarvencimentoobrigacao, diasantesalerta, assinatura, incuser, incdata, altuser, altdata) " +
                                                 "values ('" + infoUsuarios.login + "', " +
                                                         "'" + StrToAsc(EnCrypt(infoUsuarios.senha)) + "', " +
                                                         "'" + infoUsuarios.email + "', " +
                                                         "'" + infoUsuarios.departamento + "', " +
                                                         "'" + infoUsuarios.nome + "', " +
                                                               infoUsuarios.usuariomaster.ToString + ", " +
                                                               infoUsuarios.alertarvencimentoobrigacao.ToString + ", " +
                                                               infoUsuarios.diasantesalerta.ToString + ", " +
                                                         "$$" + infoUsuarios.assinatura + "$$, " +
                                                         "'" + usuarioInfo.usuario + "', current_timestamp, " +
                                                         "'" + usuarioInfo.usuario + "', current_timestamp);"
                Else
                    strQuery = "update usuarios " +
                                  "set email = '" + infoUsuarios.email + "', " +
                                      "departamento = '" + infoUsuarios.departamento + "', " +
                                      "nome = '" + infoUsuarios.nome + "', "
                    If Not String.IsNullOrEmpty(infoUsuarios.senha) Then
                        strQuery += "senha = '" + StrToAsc(EnCrypt(infoUsuarios.senha)) + "', "
                    End If
                    strQuery += "usuariomaster = " + infoUsuarios.usuariomaster.ToString + ", " +
                                "alertarvencimentoobrigacao = " + infoUsuarios.alertarvencimentoobrigacao.ToString + ", " +
                                "diasantesalerta = " + infoUsuarios.diasantesalerta.ToString + ", " +
                                "assinatura = $$" + infoUsuarios.assinatura + "$$, " +
                                "altuser = '" + usuarioInfo.usuario + "', " +
                                "altdata = current_timestamp " +
                          "where login = '" + infoUsuarios.login + "';"
                End If
                strQuery += Chr(13) + Chr(10)
                intCount = objDataBase.QuerySimples("select count(*) " +
                                                      "from usernivel n " +
                                                     "where n.login = '" + infoUsuarios.login + "' " +
                                                       "and n.sistema = 'Administrativo'")

                If intCount = 0 Then
                    strQuery += "insert into usernivel(sistema, login, nivel, grupo, incuser, incdata, altuser, altdata) " +
                                               "values ('Administrativo', " +
                                                       "'" + infoUsuarios.login + "', " +
                                                       "'" + infoUsuarios.nivel + "', " +
                                                       "'" + infoUsuarios.grupo + "', " +
                                                       "'" + usuarioInfo.usuario + "', current_timestamp, " +
                                                       "'" + usuarioInfo.usuario + "', current_timestamp);"
                Else
                    strQuery += "update usernivel " +
                                   "set nivel = '" + infoUsuarios.nivel + "', " +
                                       "grupo = '" + infoUsuarios.grupo + "', " +
                                       "altuser = '" + usuarioInfo.usuario + "', " +
                                       "altdata = current_timestamp " +
                                "where sistema = 'Administrativo' " +
                                  "and login = '" + infoUsuarios.login + "';"
                End If
            ElseIf pstrOperacao = "alteracao" Then
                strQuery = "update usuarios " +
                              "set email = '" + infoUsuarios.email + "', " +
                                  "departamento = '" + infoUsuarios.departamento + "', " +
                                  "nome = '" + infoUsuarios.nome + "', "
                If Not String.IsNullOrEmpty(infoUsuarios.senha) Then
                    strQuery += "senha = '" + StrToAsc(EnCrypt(infoUsuarios.senha)) + "', "
                End If
                strQuery += "usuariomaster = " + infoUsuarios.usuariomaster.ToString + ", " +
                            "alertarvencimentoobrigacao = " + infoUsuarios.alertarvencimentoobrigacao.ToString + ", " +
                            "diasantesalerta = " + infoUsuarios.diasantesalerta.ToString + ", " +
                            "assinatura = $$" + infoUsuarios.assinatura + "$$, " +
                            "altuser = '" + usuarioInfo.usuario + "', " +
                            "altdata = current_timestamp " +
                      "where login = '" + infoUsuarios.login + "';"

                strQuery += Chr(13) + Chr(10)
                strQuery += "update usernivel " +
                              "set nivel = '" + infoUsuarios.nivel + "', " +
                                  "grupo = '" + infoUsuarios.grupo + "', " +
                                  "altuser = '" + usuarioInfo.usuario + "', " +
                                  "altdata = current_timestamp " +
                           "where sistema = 'Administrativo' " +
                             "and login = '" + infoUsuarios.login + "';"

            ElseIf pstrOperacao = "exclusao" Then
                Dim intCount As Int32 = objDataBase.QuerySimples("select count(*) from usernivel where login = '" + infoUsuarios.login + "'")
                If intCount > 1 Then
                    strQuery = "delete " +
                                 "from usernivel " +
                                "where sistema = 'Administrativo' " +
                                  "and login = '" + infoUsuarios.login + "'"
                Else
                    strQuery = "delete " +
                                 "from usuarios " +
                                "where login = '" + infoUsuarios.login + "';"
                    strQuery += Chr(13) + Chr(10)
                    strQuery += "delete " +
                                  "from usernivel " +
                                 "where sistema = 'Administrativo' " +
                                   "and login = '" + infoUsuarios.login + "';"
                End If
            End If
            objDataBase.NonQuery(strQuery)
            If Not String.IsNullOrEmpty(portalservidorInfo.cnpjcpf) Then
                SplashScreenManager.Default.SetWaitFormDescription("Sincronizando os dados com o portal")
                If pstrOperacao <> "exclusao" Then
                    Dim strSenha As String = String.Empty
                    If Not String.IsNullOrEmpty(infoUsuarios.senha) Then
                        strSenha = StrToAsc(EnCrypt(infoUsuarios.senha))
                    Else
                        strSenha = objDataBase.QuerySimples("select senha " +
                                                              "from usuarios u " +
                                                             "where u.login = '" + infoUsuarios.login + "'")
                    End If
                    Dim wsConsulta As New SelectWS
                    If wsConsulta.UsuarioEscritorioExiste(infoUsuarios.login) Then
                        Dim wsAlteracao As New UpdateWS
                        wsAlteracao.AlterarUsuariosEscritorios(infoUsuarios.nome, infoUsuarios.login, strSenha, infoUsuarios.email)
                    Else
                        Dim wsInclusao As New InsertWS
                        wsInclusao.IncluirUsuariosEscritorio(infoUsuarios.nome, infoUsuarios.login, strSenha, infoUsuarios.email)
                    End If
                Else
                    Dim wsConsulta As New SelectWS
                    If wsConsulta.UsuarioEscritorioExiste(infoUsuarios.login) Then
                        Dim wsExclusao As New DeleteWS
                        wsExclusao.UsuarioEscritorioExclui(infoUsuarios.login)
                    End If
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub VisualizaGrupoAcesso(ByRef pstrQuery As String, ByRef pstrCampoPai As String, ByRef pstrCampoFilho As String, ptlGrupoAcesso As DevExpress.XtraTreeList.TreeList) Implements IUsuario.VisualizaGrupoAcesso
        Try
            Dim objDataBase As New DataBaseDAL
            ptlGrupoAcesso.DataSource = objDataBase.QueryDataView(pstrQuery)
            ptlGrupoAcesso.Columns("descricao").Caption = "Grupo de Acesso"
            ptlGrupoAcesso.KeyFieldName = pstrCampoPai
            ptlGrupoAcesso.ParentFieldName = pstrCampoFilho
            ptlGrupoAcesso.ExpandAll()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function RetornaGrupoAcessoUsuario() As Modelo.usuariogruposacessoInfo Implements IUsuario.RetornaGrupoAcessoUsuario
        Try
            Return RetornaGrupoAcesso("select usu.login, niv.grupo, gru.opcao, gru.operacoes " +
                                       "from usuarios usu " +
                                       "join usernivel niv on niv.sistema = 'Administrativo' and niv.login = usu.login " +
                                       "join gruposacesso gru on gru.sistema = 'Administrativo' and gru.grupo = niv.grupo " +
                                      "where usu.login = '" + usuarioInfo.usuario + "'")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function RetornaGrupoAcessoUsuario(pstrOpcao As String) As Modelo.usuariogruposacessoInfo Implements IUsuario.RetornaGrupoAcessoUsuario
        Try
            Return RetornaGrupoAcesso("select usu.login, niv.grupo, gru.opcao, gru.operacoes " +
                                       "from usuarios usu " +
                                       "join usernivel niv on niv.sistema = 'Administrativo' and niv.login = usu.login " +
                                       "join gruposacesso gru on gru.sistema = 'Administrativo' and gru.grupo = niv.grupo and left(gru.opcao,6) = '" + pstrOpcao + "' " +
                                      "where usu.login = '" + usuarioInfo.usuario + "'")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function UsuarioTemAcesso(pInfogrupoacesso As Modelo.usuariogruposacessoInfo, pstrOpcao As String) As Boolean Implements IUsuario.UsuarioTemAcesso
        Try
            If usuarioInfo.nivel = "AD" Then
                If pstrOpcao = "arqtrocom" Or pstrOpcao = "arqtroexe" Then
                    Return False
                End If
            End If
            If pInfogrupoacesso.opcao.Count > 0 Then
                For index = 0 To pInfogrupoacesso.opcao.Count - 1
                    If pInfogrupoacesso.opcao(index).opcao = pstrOpcao Then
                        Return True
                    End If
                Next
            End If
            Return False
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Private Function RetornaGrupoAcesso(pstrQuery As String) As usuariogruposacessoInfo
        Try
            Dim objDataBase As New DataBaseDAL
            Dim infoGrupoAcesso As New usuariogruposacessoInfo
            Dim lstMenu As New List(Of usuariomenuInfo)

            infoGrupoAcesso.login = usuarioInfo.usuario

            Dim strQuery As String = pstrQuery
            Dim sdData As SelectedData = objDataBase.QueryFull(pstrQuery)

            For Each row As SelectStatementResultRow In sdData.ResultSet(1).Rows
                Dim menu As New usuariomenuInfo
                infoGrupoAcesso.grupo = row.Values(1).ToString
                menu.opcao = row.Values(2).ToString
                menu.operacao = Convert.ToInt32(row.Values(3))
                lstMenu.Add(menu)
            Next row
            infoGrupoAcesso.opcao = lstMenu

            Return infoGrupoAcesso

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function BuscaUsuario(ByRef pstrUsuario As String, infoUsuarios As Modelo.usuariocadastroInfo) As Boolean Implements IUsuario.BuscaUsuario
        Try
            Dim objDataBase As New DataBaseDAL
            Dim strSenha As String = String.Empty
            Dim sdData As SelectedData = objDataBase.QueryFull("select usu.nome, coalesce(usu.email,'') as email, usu.departamento, usu.usuariomaster, usu.senha  " +
                                                                 "from usuarios usu " +
                                                                "where usu.login = '" + pstrUsuario + "'")

            For Each row As SelectStatementResultRow In sdData.ResultSet(1).Rows
                infoUsuarios.nome = row.Values(0).ToString
                infoUsuarios.email = row.Values(1).ToString
                infoUsuarios.departamento = row.Values(2).ToString
                infoUsuarios.usuariomaster = Convert.ToInt32(row.Values(3))
                strSenha = row.Values(4).ToString
                If Not String.IsNullOrEmpty(strSenha) Then
                    infoUsuarios.senha = DeCrypt(AscToStr(strSenha))
                End If
            Next row
            Return Not String.IsNullOrEmpty(infoUsuarios.nome)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class