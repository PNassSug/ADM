Imports Administrativo.Modelo
Imports Administrativo.WS
Imports DevExpress.Xpo.DB
Imports DevExpress.XtraSplashScreen

Public Class PortalServidorDAL
    Implements IPortalServidor

    Public Sub BuscaConfiguracaoPortalServidor() Implements IPortalServidor.BuscaConfiguracaoPortalServidor
        Try
            If Not administrativoInfo.DesconsideraPortal Then
                Dim objDataBase As New DataBaseDAL
                Dim sdData As SelectedData = objDataBase.QueryFull("select acp.cnpjcpfportal, acp.servidor, razaosocial, ddd, telefone " +
                                                                     "from admconfiguracaoportal acp")

                For Each row As SelectStatementResultRow In sdData.ResultSet(1).Rows
                    portalservidorInfo.cnpjcpf = row.Values(0).ToString
                    portalservidorInfo.servidor = row.Values(1).ToString
                    portalservidorInfo.razaosocial = row.Values(2).ToString
                    portalservidorInfo.ddd = row.Values(3).ToString
                    portalservidorInfo.telefone = row.Values(4).ToString
                Next row
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub IUDPortalServidor(ByRef pstrRazaoSocial As String, ByRef pstrCnpjCpf As String, ByRef pstrDDD As String, ByRef pstrTelefone As String, ByRef pstrServidor As String) Implements IPortalServidor.IUDPortalServidor
        Try
            Dim objDataBase As New DataBaseDAL
            Dim strQuery As String = String.Empty

            Dim intCount As Int32 = objDataBase.QuerySimples("select count(*) " +
                                                               "from admconfiguracaoportal acp")
            If intCount = 0 Then
                strQuery = "insert into admconfiguracaoportal(cnpjcpfportal, servidor, razaosocial, ddd, telefone, incuser, incdata, altuser, altdata) " +
                                                     "values ('" + pstrCnpjCpf.ToString + "', " +
                                                             "'" + pstrServidor.ToString + "', " +
                                                             "'" + pstrRazaoSocial.ToString + "', " +
                                                             "'" + pstrDDD.ToString + "', " +
                                                             "'" + pstrTelefone.ToString + "', " +
                                                             "'" + usuarioInfo.usuario + "', current_timestamp, " +
                                                             "'" + usuarioInfo.usuario + "', current_timestamp);"
            Else
                strQuery = "update admconfiguracaoportal " +
                              "set cnpjcpfportal = '" + pstrCnpjCpf.ToString + "', " +
                                  "servidor = '" + pstrServidor.ToString + "', " +
                                  "razaosocial = '" + pstrRazaoSocial.ToString + "', " +
                                  "ddd = '" + pstrDDD.ToString + "', " +
                                  "telefone = '" + pstrTelefone.ToString + "', "
                strQuery += "altuser = '" + usuarioInfo.usuario + "', " +
                            "altdata = current_timestamp"
            End If

            If Not String.IsNullOrEmpty(pstrCnpjCpf) Then
                If Not administrativoInfo.DesconsideraPortal Then
                    Dim wsConsulta As New SelectWS
                    If wsConsulta.EscritorioExiste(pstrCnpjCpf) Then
                        Dim wsAlteracao As New UpdateWS
                        wsAlteracao.AlterarEscritorios(pstrCnpjCpf, pstrRazaoSocial, pstrDDD, pstrTelefone)
                    Else
                        Dim wsInclusao As New InsertWS
                        If wsInclusao.IncluirEscritorio(pstrCnpjCpf, pstrRazaoSocial, pstrDDD, pstrTelefone) Then
                        End If
                    End If
                End If
                objDataBase.NonQuery(strQuery)
                BuscaConfiguracaoPortalServidor()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub SincronizarPortalServidor(ByRef pblnEmpresas As Boolean, ByRef pblnObrigacoes As Boolean, ByRef pblnUsuariosEmpresas As Boolean, ByRef pblnUsuariosEscritorios As Boolean) Implements IPortalServidor.SincronizarPortalServidor
        Try
            If Not String.IsNullOrEmpty(portalservidorInfo.cnpjcpf) Then
                If pblnEmpresas Then
                    SplashScreenManager.Default.SetWaitFormDescription("Sincronizando as [Empresas] com o portal")
                    SincronizarEmpresas()
                End If
                If pblnObrigacoes Then
                    SplashScreenManager.Default.SetWaitFormDescription("Sincronizando as [Obrigações] com o portal")
                    SincronizarObrigacoes()
                End If
                If pblnUsuariosEscritorios Then
                    SplashScreenManager.Default.SetWaitFormDescription("Sincronizando os [Usuários dos escritórios] com o portal")
                    SincronizarUsuariosEscritorios()
                End If
                If pblnUsuariosEmpresas Then
                    SplashScreenManager.Default.SetWaitFormDescription("Sincronizando os [Usuários das empresas] com o portal")
                    SincronizarUsuariosEmpresas()
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub SincronizarEmpresas()
        Try
            Dim objDataBase As New DataBaseDAL
            Dim strQuery As String = String.Empty
            Dim sdData As SelectedData
            Dim wsConsulta As New SelectWS
            Dim wsInclusao As New InsertWS
            Dim wsAlteracao As New UpdateWS
            Dim wsExclusao As New DeleteWS

            '------------------------------------------------------------------------------
            ' SINCRONIZANDO O CADASTRO DE EMPRESAS COM A WEBSERVICE 
            '------------------------------------------------------------------------------
            ' NESSE PRIMEIRO PROCESSO SOMENTE INCLUI REGISTRO NA WEBSERVICE
            '------------------------------------------------------------------------------
            strQuery = "select aoe.empresa, emp.razaosocial, coalesce(emp.cnpj,'') as cnpjcpf " +
                         "from (select aoe.empresa, max(aoe.exercicio) as exercicio " +
                                 "from admobrigacoesempresas aoe " +
                             "group by aoe.empresa) aoe " +
                         "join empresas emp on emp.empresa = aoe.empresa And emp.exercicio = aoe.exercicio " +
                     "order by 1"

            sdData = objDataBase.QueryFull(strQuery)
            For Each row As SelectStatementResultRow In sdData.ResultSet(1).Rows
                If wsConsulta.EmpresaExiste(row.Values(0).ToString) Then
                    wsAlteracao.AlterarEmpresas(row.Values(0).ToString, row.Values(1).ToString, row.Values(2).ToString)
                Else
                    wsInclusao.IncluirEmpresas(row.Values(0).ToString, row.Values(1).ToString, row.Values(2).ToString)
                End If
            Next row

            '------------------------------------------------------------------------------
            ' SINCRONIZANDO O CADASTRO DE EMPRESAS COM A WEBSERVICE 
            '------------------------------------------------------------------------------
            ' NESSE SEGUNDO PROCESSO EXCLUI OS REGISTROS QUE NÃO EXISTE MAIS LOCALMENTE
            '------------------------------------------------------------------------------
            Dim strDadosEmpresa As String = wsConsulta.EmpresaRetornaDados(String.Empty)
            Dim strQueryEmpresaWS As String = String.Empty
            If Not String.IsNullOrEmpty(strDadosEmpresa) Then
                Dim aLista() As String = strDadosEmpresa.Split("|")
                For iLista = 0 To aLista.Length - 1
                    Dim aCampos() As String = aLista(iLista).Split(",")
                    If Not String.IsNullOrEmpty(strQueryEmpresaWS) Then
                        strQueryEmpresaWS += " union all "
                    End If
                    strQueryEmpresaWS += "select cast('" + aCampos(1).ToString + "' as varchar) as empresa"
                Next
                strQueryEmpresaWS = "select cast('WS' as varchar) as origem, cast(a.empresa as varchar) as empresa from (" + strQueryEmpresaWS + ") a"

                Dim strResultadoEmpresa As String = "select empresa " +
                                                  "from (" +
                                                         "select total.empresa, case when coalesce(local.empresa,'') = '' and coalesce(ws.empresa,'') <> '' then -1 else 0 end as resultado " +
                                                           "from (" + strQueryEmpresaWS.Replace("cast('WS' as varchar) as origem,", String.Empty) + " union " +
                                                                  "select aoe.empresa " +
                                                                    "from (select aoe.empresa, max(aoe.exercicio) as exercicio " +
                                                                            "from admobrigacoesempresas aoe " +
                                                                        "group by aoe.empresa) aoe " +
                                                                    "join empresas emp on emp.empresa = aoe.empresa And emp.exercicio = aoe.exercicio) total " +
                                             "left join (select cast('LOCAL' as varchar) as origem, aoe.empresa " +
                                                          "from (select aoe.empresa, max(aoe.exercicio) as exercicio " +
                                                                  "from admobrigacoesempresas aoe " +
                                                              "group by aoe.empresa) aoe " +
                                                          "join empresas emp on emp.empresa = aoe.empresa And emp.exercicio = aoe.exercicio) local on local.empresa = total.empresa " +
                                             "left join (" + strQueryEmpresaWS + ") ws on ws.empresa = total.empresa) r " +
                                                  "where r.resultado = -1"

                sdData = objDataBase.QueryFull(strResultadoEmpresa)
                For Each row As SelectStatementResultRow In sdData.ResultSet(1).Rows
                    If wsConsulta.EmpresaExiste(row.Values(0).ToString) Then
                        wsExclusao.EmpresaExclui(row.Values(0).ToString)
                    End If
                Next row
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub SincronizarUsuariosEscritorios()
        Try
            Dim objDataBase As New DataBaseDAL
            Dim strQuery As String = String.Empty
            Dim sdData As SelectedData
            Dim wsConsulta As New SelectWS
            Dim wsInclusao As New InsertWS
            Dim wsAlteracao As New UpdateWS
            Dim wsExclusao As New DeleteWS

            '------------------------------------------------------------------------------
            ' SINCRONIZANDO O CADASTRO DE USUÁRIOS DO ESCRITÓRIO
            '------------------------------------------------------------------------------
            ' NESSE PRIMEIRO PROCESSO SOMENTE INCLUI REGISTRO NA WEBSERVICE
            '------------------------------------------------------------------------------
            strQuery = "select u.nome, u.login, u.senha, coalesce(u.email,'') as email " +
                         "from usuarios u " +
                         "join usernivel un on un.login = u.login and un.sistema = 'Administrativo' " +
                     "order by 2"

            sdData = objDataBase.QueryFull(strQuery)
            For Each row As SelectStatementResultRow In sdData.ResultSet(1).Rows
                If wsConsulta.UsuarioEscritorioExiste(row.Values(1).ToString) Then
                    wsAlteracao.AlterarUsuariosEscritorios(row.Values(0).ToString, row.Values(1).ToString, row.Values(2).ToString, row.Values(3).ToString)
                Else
                    wsInclusao.IncluirUsuariosEscritorio(row.Values(0).ToString, row.Values(1).ToString, row.Values(2).ToString, row.Values(3).ToString)
                End If
            Next row

            '------------------------------------------------------------------------------
            ' SINCRONIZANDO O CADASTRO DE USUÁRIOS DO ESCRITÓRIO
            '------------------------------------------------------------------------------
            ' NESSE SEGUNDO PROCESSO EXCLUI OS REGISTROS QUE NÃO EXISTE MAIS LOCALMENTE
            '------------------------------------------------------------------------------
            Dim strDadosUsuarioEscritorio As String = wsConsulta.UsuarioEscritorioRetornaDados(String.Empty)
            Dim strQueryUsuarioEscritorioWS As String = String.Empty
            If Not String.IsNullOrEmpty(strDadosUsuarioEscritorio) Then
                Dim aLista() As String = strDadosUsuarioEscritorio.Split("|")
                For iLista = 0 To aLista.Length - 1
                    Dim aCampos() As String = aLista(iLista).Split(",")
                    If Not String.IsNullOrEmpty(strQueryUsuarioEscritorioWS) Then
                        strQueryUsuarioEscritorioWS += " union all "
                    End If
                    strQueryUsuarioEscritorioWS += "select cast('" + aCampos(2).ToString + "' as varchar) as login"
                Next
                strQueryUsuarioEscritorioWS = "select cast('WS' as varchar) as origem, cast(a.login as varchar) as login from (" + strQueryUsuarioEscritorioWS + ") a"

                Dim strResultadoUsuarioEscritorio As String = "select login " +
                                           "from (" +
                                                  "select total.login, case when coalesce(local.login,'') = '' and coalesce(ws.login,'') <> '' then -1 else 0 end as resultado " +
                                                    "from (" + strQueryUsuarioEscritorioWS.Replace("cast('WS' as varchar) as origem,", String.Empty) + " union " +
                                                           "select u.login " +
                                                             "from usuarios u " +
                                                             "join usernivel un on un.login = u.login and un.sistema = 'Administrativo') total " +
                                      "left join (select cast('LOCAL' as varchar) as origem, u.login " +
                                                   "from (select u.login " +
                                                           "from usuarios u " +
                                                           "join usernivel un on un.login = u.login And un.sistema = 'Administrativo') u) local on local.login = total.login " +
                                      "left join (" + strQueryUsuarioEscritorioWS + ") ws on ws.login = total.login) r " +
                                          "where r.resultado = -1"

                sdData = objDataBase.QueryFull(strResultadoUsuarioEscritorio)
                For Each row As SelectStatementResultRow In sdData.ResultSet(1).Rows
                    If wsConsulta.UsuarioEscritorioExiste(row.Values(0).ToString) Then
                        wsExclusao.UsuarioEscritorioExclui(row.Values(0).ToString)
                    End If
                Next row
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub SincronizarObrigacoes()
        Try
            Dim objDataBase As New DataBaseDAL
            Dim objObrigacao As New ObrigacoesDAL
            Dim strQuery As String = String.Empty
            Dim sdData As SelectedData
            Dim wsConsulta As New SelectWS
            Dim wsInclusao As New InsertWS
            Dim wsAlteracao As New UpdateWS
            Dim wsExclusao As New DeleteWS

            '------------------------------------------------------------------------------
            ' SINCRONIZANDO O CADASTRO DE OBRIGAÇÕES
            '------------------------------------------------------------------------------
            ' NESSE PRIMEIRO PROCESSO SOMENTE INCLUI REGISTRO NA WEBSERVICE
            '------------------------------------------------------------------------------
            strQuery = "select ao.obrigacao, ao.descricao " +
                         "from admobrigacoes ao " +
                     "order by 1"

            sdData = objDataBase.QueryFull(strQuery)
            For Each row As SelectStatementResultRow In sdData.ResultSet(1).Rows
                If wsConsulta.ObrigacaoExiste(row.Values(0).ToString) Then
                    wsAlteracao.AlterarObrigacoes(row.Values(0).ToString, row.Values(1).ToString)
                Else
                    wsInclusao.IncluirObrigacoes(row.Values(0).ToString, row.Values(1).ToString, objObrigacao.RetornaLayoutObrigacao(row.Values(0).ToString))
                End If
            Next row

            '------------------------------------------------------------------------------
            ' SINCRONIZANDO O CADASTRO DE OBRIGAÇÕES
            '------------------------------------------------------------------------------
            ' NESSE SEGUNDO PROCESSO EXCLUI OS REGISTROS QUE NÃO EXISTE MAIS LOCALMENTE
            '------------------------------------------------------------------------------
            Dim strDadosObrigacao As String = wsConsulta.ObrigacaoRetornaDados(String.Empty)
            Dim strQueryObrigacaoWS As String = String.Empty
            If Not String.IsNullOrEmpty(strDadosObrigacao) Then
                Dim aLista() As String = strDadosObrigacao.Split("|")
                For iLista = 0 To aLista.Length - 1
                    Dim aCampos() As String = aLista(iLista).Split(",")
                    If Not String.IsNullOrEmpty(strQueryObrigacaoWS) Then
                        strQueryObrigacaoWS += " union all "
                    End If
                    strQueryObrigacaoWS += "select cast('" + aCampos(1).ToString + "' as varchar) as obrigacao"
                Next
                strQueryObrigacaoWS = "select cast('WS' as varchar) as origem, cast(a.obrigacao as varchar) as obrigacao from (" + strQueryObrigacaoWS + ") a"

                Dim strResultadoObrigacao As String = "select obrigacao " +
                                           "from (" +
                                                  "select total.obrigacao, case when coalesce(local.obrigacao,'') = '' and coalesce(ws.obrigacao,'') <> '' then -1 else 0 end as resultado " +
                                                    "from (" + strQueryObrigacaoWS.Replace("cast('WS' as varchar) as origem,", String.Empty) + " union " +
                                                           "select ao.obrigacao " +
                                                             "from admobrigacoes ao) total " +
                                      "left join (select cast('LOCAL' as varchar) as origem, o.obrigacao " +
                                                   "from (select ao.obrigacao " +
                                                           "from admobrigacoes ao) o) local on local.obrigacao = total.obrigacao " +
                                      "left join (" + strQueryObrigacaoWS + ") ws on ws.obrigacao = total.obrigacao) r " +
                                          "where r.resultado = -1"

                sdData = objDataBase.QueryFull(strResultadoObrigacao)
                For Each row As SelectStatementResultRow In sdData.ResultSet(1).Rows
                    If wsConsulta.ObrigacaoExiste(row.Values(0).ToString) Then
                        wsExclusao.ObrigacaoExclui(row.Values(0).ToString)
                    End If
                Next row
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub SincronizarUsuariosEmpresas()
        Try
            Dim objDataBase As New DataBaseDAL
            Dim strQuery As String = String.Empty
            Dim sdData As SelectedData
            Dim wsConsulta As New SelectWS
            Dim wsInclusao As New InsertWS
            Dim wsAlteracao As New UpdateWS
            Dim wsExclusao As New DeleteWS

            '------------------------------------------------------------------------------
            ' SINCRONIZANDO O CADASTRO DE USUÁRIOS DAS EMPRESAS
            '------------------------------------------------------------------------------
            ' NESSE PRIMEIRO PROCESSO SOMENTE INCLUI REGISTRO NA WEBSERVICE
            '------------------------------------------------------------------------------
            strQuery = "select au.empresa, au.nome, au.email, coalesce(au.ddd,'') as ddd, coalesce(au.telefone,'') as telefone " +
                         "from admusuariosempresassistemasportal au " +
                     "order by 1, 3"

            sdData = objDataBase.QueryFull(strQuery)
            For Each row As SelectStatementResultRow In sdData.ResultSet(1).Rows
                If wsConsulta.UsuarioEmpresaExiste(row.Values(0).ToString, row.Values(2).ToString) Then
                    wsAlteracao.AlterarUsuariosEmpresas(row.Values(0).ToString, row.Values(1).ToString, row.Values(2).ToString, row.Values(3).ToString, row.Values(4).ToString)
                Else
                    wsInclusao.IncluiUsuarioEmpresa(row.Values(0).ToString, row.Values(1).ToString, row.Values(2).ToString, row.Values(3).ToString, row.Values(4).ToString)
                End If
                Dim strSubQuery As String = "select emp.obrigacao " +
                                             "from admusuariosempresassistemasitensportal usu " +
                                             "join (select aoe.empresa, aoe.obrigacao, ao.sistema " +
                                                     "from (select empresa, obrigacao " +
                                                             "from admobrigacoesempresas " +
                                                            "where empresa = '" + row.Values(0).ToString + "' " +
                                                         "group by empresa, obrigacao " +
                                                        "union all " +
                                                           "select empresa, obrigacao " +
                                                             "from admcontroleadministrativo " +
                                                            "where empresa = '" + row.Values(0).ToString + "' " +
                                                              "and obrigacaoextra = -1 " +
                                                         "group by empresa, obrigacao) aoe " +
                                                     "join admobrigacoes ao on ao.obrigacao = aoe.obrigacao " +
                                                 "group by aoe.empresa, aoe.obrigacao, ao.sistema) emp on emp.empresa = usu.empresa And emp.sistema = usu.sistema " +
                                            "where usu.empresa = '" + row.Values(0).ToString + "' " +
                                              "and usu.email = '" + row.Values(2).ToString + "' " +
                                         "order by 1"
                Dim sdSubData As SelectedData = objDataBase.QueryFull(strSubQuery)

                For Each subrow As SelectStatementResultRow In sdSubData.ResultSet(1).Rows
                    If Not wsConsulta.EmpresaUsuarioObrigacaoExiste(row.Values(0).ToString, subrow.Values(0).ToString, row.Values(2).ToString) Then
                        wsInclusao.IncluirEmpresaUsuarioObrigacoes(row.Values(0).ToString, subrow.Values(0).ToString, row.Values(2).ToString)
                    End If
                Next subrow
            Next row

            '------------------------------------------------------------------------------
            ' SINCRONIZANDO O CADASTRO DE USUÁRIOS DAS EMPRESAS
            '------------------------------------------------------------------------------
            ' NESSE SEGUNDO PROCESSO EXCLUI OS REGISTROS QUE NÃO EXISTE MAIS LOCALMENTE
            '------------------------------------------------------------------------------
            Dim strDadosUsuarioEmpresa As String = wsConsulta.UsuarioEmpresaRetornaDados(String.Empty, String.Empty)
            Dim strQueryUsuarioEmpresaWS As String = String.Empty
            If Not String.IsNullOrEmpty(strDadosUsuarioEmpresa) Then
                Dim aLista() As String = strDadosUsuarioEmpresa.Split("|")
                For iLista = 0 To aLista.Length - 1
                    Dim aCampos() As String = aLista(iLista).Split(",")
                    If Not String.IsNullOrEmpty(strQueryUsuarioEmpresaWS) Then
                        strQueryUsuarioEmpresaWS += " union all "
                    End If
                    strQueryUsuarioEmpresaWS += "select cast('" + aCampos(1).ToString + "' as varchar) as empresa, cast('" + aCampos(2).ToString + "' as varchar) as email"
                Next
                strQueryUsuarioEmpresaWS = "select cast('WS' as varchar) as origem, cast(a.empresa as varchar) as empresa, cast(a.email as varchar) as email from (" + strQueryUsuarioEmpresaWS + ") a"

                Dim strResultadoUsuarioEmpresa As String = "select empresa, email " +
                                           "from (" +
                                                  "select total.empresa, total.email, case when (coalesce(local.empresa,'') = '' and coalesce(ws.empresa,'') <> '') and (coalesce(local.email,'') = '' and coalesce(ws.email,'') <> '') then -1 else 0 end as resultado " +
                                                    "from (" + strQueryUsuarioEmpresaWS.Replace("cast('WS' as varchar) as origem,", String.Empty) + " union " +
                                                           "select au.empresa, au.email " +
                                                             "from admusuariosempresassistemasportal au) total " +
                                       "left join (select cast('LOCAL' as varchar) as origem, a.empresa, a.email " +
                                                    "from (select au.empresa, au.email " +
                                                            "from admusuariosempresassistemasportal au) a) local on local.empresa = total.empresa And local.email = total.email " +
                                       "left join (" + strQueryUsuarioEmpresaWS + ") ws on ws.empresa = total.empresa And ws.email = total.email) r " +
                                           "where r.resultado = -1"

                sdData = objDataBase.QueryFull(strResultadoUsuarioEmpresa)
                For Each row As SelectStatementResultRow In sdData.ResultSet(1).Rows
                    If wsConsulta.UsuarioEmpresaExiste(row.Values(0).ToString, row.Values(1).ToString) Then
                        wsExclusao.UsuarioEmpresaExclui(row.Values(0).ToString, row.Values(1).ToString)
                    End If
                Next row
            End If
            '------------------------------------------------------------------------------
            ' SINCRONIZANDO O CADASTRO DE OBRIGAÇÕES DOS USUÁRIOS DAS EMPRESAS
            '------------------------------------------------------------------------------
            ' NESSE SEGUNDO PROCESSO EXCLUI OS REGISTROS QUE NÃO EXISTE MAIS LOCALMENTE
            '------------------------------------------------------------------------------
            Dim strDadosObrigacaoUsuarioEmpresa As String = wsConsulta.EmpresaUsuarioObrigacaoRetornaDados(String.Empty, String.Empty, String.Empty)
            Dim strQueryObrigacaoUsuarioEmpresaWS As String = String.Empty
            If Not String.IsNullOrEmpty(strDadosObrigacaoUsuarioEmpresa) Then
                Dim aLista() As String = strDadosObrigacaoUsuarioEmpresa.Split("|")
                For iLista = 0 To aLista.Length - 1
                    Dim aCampos() As String = aLista(iLista).Split(",")
                    If Not String.IsNullOrEmpty(strQueryObrigacaoUsuarioEmpresaWS) Then
                        strQueryObrigacaoUsuarioEmpresaWS += " union all "
                    End If
                    strQueryObrigacaoUsuarioEmpresaWS += "select cast('" + aCampos(1).ToString + "' as varchar) as empresa, cast('" + aCampos(2).ToString + "' as varchar) as email, cast('" + aCampos(3).ToString + "' as varchar) as obrigacao"
                Next
                strQueryObrigacaoUsuarioEmpresaWS = "select cast('WS' as varchar) as origem, cast(a.empresa as varchar) as empresa, cast(a.email as varchar) as email, cast(a.obrigacao as varchar) as obrigacao from (" + strQueryObrigacaoUsuarioEmpresaWS + ") a"

                Dim strResultadoObrigacaoUsuarioEmpresa As String = "select empresa, email, obrigacao " +
                                           "from (" +
                                                  "select total.empresa, total.email, total.obrigacao, case when (coalesce(local.empresa,'') = '' and coalesce(ws.empresa,'') <> '') and (coalesce(local.email,'') = '' and coalesce(ws.email,'') <> '') and (coalesce(local.obrigacao,'') = '' and coalesce(ws.obrigacao,'') <> '') then -1 else 0 end as resultado " +
                                                    "from (" + strQueryObrigacaoUsuarioEmpresaWS.Replace("cast('WS' as varchar) as origem,", String.Empty) + " union " +
                                                           "select usu.empresa, usu.email, emp.obrigacao " +
                                                             "from admusuariosempresassistemasitensportal usu " +
                                                             "join (select aoe.empresa, aoe.obrigacao, ao.sistema " +
                                                                     "from (select empresa, obrigacao " +
                                                                             "from admobrigacoesempresas " +
                                                                         "group by empresa, obrigacao " +
                                                                        "union all " +
                                                                           "select empresa, obrigacao " +
                                                                             "from admcontroleadministrativo " +
                                                                            "where obrigacaoextra = -1 " +
                                                                         "group by empresa, obrigacao) aoe " +
                                                                     "join admobrigacoes ao on ao.obrigacao = aoe.obrigacao " +
                                                                 "group by aoe.empresa, aoe.obrigacao, ao.sistema) emp on emp.empresa = usu.empresa And emp.sistema = usu.sistema) total " +
                                      "left join (select cast('LOCAL' as varchar) as origem, a.empresa, a.email, a.obrigacao " +
                                                   "from (select usu.empresa, usu.email, emp.obrigacao " +
                                                           "from admusuariosempresassistemasitensportal usu " +
                                                           "join (select aoe.empresa, aoe.obrigacao, ao.sistema " +
                                                                   "from (select empresa, obrigacao " +
                                                                           "from admobrigacoesempresas " +
                                                                       "group by empresa, obrigacao " +
                                                                      "union all " +
                                                                         "select empresa, obrigacao " +
                                                                           "from admcontroleadministrativo " +
                                                                          "where obrigacaoextra = -1 " +
                                                                       "group by empresa, obrigacao) aoe " +
                                                                   "join admobrigacoes ao on ao.obrigacao = aoe.obrigacao " +
                                                       "group by aoe.empresa, aoe.obrigacao, ao.sistema) emp on emp.empresa = usu.empresa And emp.sistema = usu.sistema) a) local on local.empresa = total.empresa And local.email = total.email And local.obrigacao = total.obrigacao " +
                                      "left join (" + strQueryObrigacaoUsuarioEmpresaWS + ") ws on ws.empresa = total.empresa And ws.email = total.email And ws.obrigacao = total.obrigacao) r " +
                                           "where r.resultado = -1"

                sdData = objDataBase.QueryFull(strResultadoObrigacaoUsuarioEmpresa)
                For Each row As SelectStatementResultRow In sdData.ResultSet(1).Rows
                    If wsConsulta.EmpresaUsuarioObrigacaoExiste(row.Values(0).ToString, row.Values(2).ToString, row.Values(1).ToString) Then
                        wsExclusao.EmpresaUsuarioObrigacaoExclui(row.Values(0).ToString, row.Values(1).ToString, row.Values(2).ToString)
                    End If
                Next row
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class
