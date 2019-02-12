Imports Administrativo.Modelo
Imports Administrativo.WS
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Mask
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Xpo.DB
Imports DevExpress.XtraSplashScreen

Public Class PortalUsuariosDAL
    Implements IPortalUsuarios

    Private edit As RepositoryItemTextEdit

    Public Sub Grid(ByRef pstrQuery As String, pdgGrid As DevExpress.XtraGrid.GridControl, pgvGrid As DevExpress.XtraGrid.Views.Grid.GridView, ByRef infoSistemas As System.Collections.Generic.List(Of Modelo.portalusuariossistemas)) Implements IPortalUsuarios.Grid
        Try
            Dim objDataBase As New DataBaseDAL
            Dim sdEmpresa As SelectedData = objDataBase.QueryFull(pstrQuery)

            For Each row As SelectStatementResultRow In sdEmpresa.ResultSet(1).Rows
                infoSistemas.Add(New portalusuariossistemas(row.Values(0).ToString))
            Next

            pdgGrid.DataSource = infoSistemas

            pgvGrid.Columns(0).Caption = "Sistema"
            pgvGrid.Columns(0).Width = 100

            pdgGrid.ForceInitialize()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Grid(ByRef pstrQuery() As String, ByRef pstrTituloGrid() As String, pdgGrid As DevExpress.XtraGrid.GridControl, pgvGrid As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridSistema As DevExpress.XtraGrid.Views.Grid.GridView) Implements IPortalUsuarios.Grid
        Try
            Dim objDataBase As New DataBaseDAL
            Dim sdSistemaUsuario As SelectedData = objDataBase.QueryFull(pstrQuery(0).ToString)

            Dim dsSistemaUsuario As New DataSet()
            Dim dtSistemaUsuario As New DataTable("sistemausuario")
            For Each row As SelectStatementResultRow In sdSistemaUsuario.ResultSet(0).Rows
                dtSistemaUsuario.Columns.Add(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
            Next
            dsSistemaUsuario.Tables.Add(dtSistemaUsuario)

            For Each row As SelectStatementResultRow In sdSistemaUsuario.ResultSet(1).Rows
                Dim drSistemasUsuarios As DataRow = dsSistemaUsuario.Tables("sistemausuario").NewRow()
                For index = 0 To row.Values.Length - 1
                    drSistemasUsuarios(index) = row.Values(index)
                Next
                dsSistemaUsuario.Tables("sistemausuario").Rows.Add(drSistemasUsuarios)
            Next

            sdSistemaUsuario = objDataBase.QueryFull(pstrQuery(1).ToString)
            Dim dtSistema As New DataTable("sistema")
            For Each row As SelectStatementResultRow In sdSistemaUsuario.ResultSet(0).Rows
                dtSistema.Columns.Add(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
            Next
            dsSistemaUsuario.Tables.Add(dtSistema)

            For Each row As SelectStatementResultRow In sdSistemaUsuario.ResultSet(1).Rows
                Dim drSistema As DataRow = dsSistemaUsuario.Tables("sistema").NewRow()
                For index = 0 To row.Values.Length - 1
                    drSistema(index) = row.Values(index)
                Next
                dsSistemaUsuario.Tables("sistema").Rows.Add(drSistema)
            Next

            Dim keyColumnEmpresa As DataColumn = dsSistemaUsuario.Tables("sistemausuario").Columns("empresa")
            Dim keyColumnUsuario As DataColumn = dsSistemaUsuario.Tables("sistemausuario").Columns("email")

            Dim foreignKeyColumnEmpresaEmp As DataColumn = dsSistemaUsuario.Tables("sistema").Columns("empresa")
            Dim foreignKeyColumnEmpresaUsu As DataColumn = dsSistemaUsuario.Tables("sistema").Columns("email")

            dsSistemaUsuario.Relations.Add("SistemaUsuario", {keyColumnEmpresa, keyColumnUsuario}, {foreignKeyColumnEmpresaEmp, foreignKeyColumnEmpresaUsu})

            'Bind the grid control to the data source
            pdgGrid.DataSource = dsSistemaUsuario.Tables("sistemausuario")
            pdgGrid.ForceInitialize()
            pgvGrid.ViewCaption = pstrTituloGrid(0).ToString
            pgvGrid.OptionsDetail.SmartDetailExpandButtonMode = DetailExpandButtonMode.CheckAllDetails
            pgvGrid.OptionsView.ColumnAutoWidth = False

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.Simple
            edit.Mask.UseMaskAsDisplayFormat = True
            edit.Mask.EditMask = "00.0000"
            pgvGrid.Columns(0).ColumnEdit = edit
            pgvGrid.Columns(0).Caption = "Empresa"
            pgvGrid.Columns(0).Width = 80

            pgvGrid.Columns(1).Caption = "Razão Social"
            pgvGrid.Columns(1).Width = 250

            pgvGrid.Columns(2).Caption = "E-mail"
            pgvGrid.Columns(2).Width = 250

            pgvGrid.Columns(3).Caption = "Nome"
            pgvGrid.Columns(3).Width = 150

            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.Simple
            edit.Mask.UseMaskAsDisplayFormat = True
            edit.Mask.EditMask = "(0x000)"
            pgvGrid.Columns(4).ColumnEdit = edit
            pgvGrid.Columns(4).Caption = "DDD"
            pgvGrid.Columns(4).Width = 50

            pgvGrid.Columns(5).Caption = "Telefone"
            pgvGrid.Columns(5).Width = 90

            pdgGrid.LevelTree.Nodes(0).RelationName = "SistemaUsuario"
            pdgGrid.LevelTree.Nodes(0).LevelTemplate = pgvGridSistema
            pgvGridSistema.ViewCaption = pstrTituloGrid(1).ToString
            pgvGridSistema.PopulateColumns(dsSistemaUsuario.Tables("sistema"))
            pgvGridSistema.OptionsView.ShowGroupPanel = False
            pgvGridSistema.OptionsBehavior.Editable = False
            pgvGridSistema.OptionsCustomization.AllowQuickHideColumns = False
            pgvGridSistema.OptionsCustomization.AllowColumnResizing = False
            pgvGridSistema.OptionsCustomization.AllowColumnMoving = False
            pgvGridSistema.OptionsCustomization.AllowGroup = False

            pgvGridSistema.Columns(0).Visible = False
            pgvGridSistema.Columns(1).Visible = False

            pgvGridSistema.Columns(2).Caption = "Sistema"
            pgvGridSistema.Columns(2).Width = 100
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub IUDPortalUsuarios(ByRef pstrOperacao As String, ByRef pstrFiltroEmail As String, ByRef infoPortalUsuarios As Modelo.portalusuariosInfo, ByRef originalinfoSistemas As System.Collections.Generic.List(Of Modelo.portalusuariossistemas)) Implements IPortalUsuarios.IUDPortalUsuarios
        Try
            Dim objDataBase As New DataBaseDAL
            Dim strQuery As String = String.Empty
            Dim blnExcluiEmailOriginalPortal As Boolean = False
            Dim strEmailOriginal As String = String.Empty
            If pstrOperacao = "exclusao" Then
                strQuery = "delete " +
                             "from admusuariosempresassistemasportal " +
                            "where empresa = '" + infoPortalUsuarios.empresa + "' " +
                              "and email = '" + infoPortalUsuarios.email + "';"
                strQuery += Chr(13) + Chr(10)
                strQuery += "delete " +
                              "from admusuariosempresassistemasitensportal " +
                             "where empresa = '" + infoPortalUsuarios.empresa + "' " +
                               "and email = '" + infoPortalUsuarios.email + "';"
            End If
            If pstrOperacao <> "exclusao" Then
                If infoPortalUsuarios.sistemas.Count = 0 And originalinfoSistemas.Count > 0 Then
                    strQuery += Chr(13) + Chr(10)
                    strQuery += "delete " +
                                  "from admusuariosempresassistemasitensportal " +
                                 "where empresa = '" + infoPortalUsuarios.empresa + "' " +
                                   "and email = '" + pstrFiltroEmail + "';"
                    blnExcluiEmailOriginalPortal = True
                End If
                For indexoriginal = 0 To originalinfoSistemas.Count - 1
                    Dim blnEncontrouSistemaUsuario As Boolean = False
                    For index = 0 To infoPortalUsuarios.sistemas.Count - 1
                        If originalinfoSistemas(indexoriginal).sistema = infoPortalUsuarios.sistemas(index).sistema Then
                            blnEncontrouSistemaUsuario = True
                            Exit For
                        End If
                    Next
                    If Not blnEncontrouSistemaUsuario Then
                        strQuery += Chr(13) + Chr(10)
                        strQuery += "delete " +
                                      "from admusuariosempresassistemasitensportal " +
                                     "where empresa = '" + infoPortalUsuarios.empresa + "' " +
                                       "and email = '" + pstrFiltroEmail + "' " +
                                       "and sistema = '" + originalinfoSistemas(indexoriginal).sistema + "';"
                    End If
                Next
                If Not String.IsNullOrEmpty(strQuery) Then
                    strQuery += Chr(13) + Chr(10)
                End If

                If pstrOperacao = "inclusao" Then
                    strQuery += "insert into admusuariosempresassistemasportal(empresa, email, nome, ddd, telefone, incuser, incdata, altuser, altdata) " +
                                                                             "values ('" + infoPortalUsuarios.empresa + "', " +
                                                                                     "'" + infoPortalUsuarios.email + "', " +
                                                                                     "'" + infoPortalUsuarios.nome + "', " +
                                                                                     "'" + infoPortalUsuarios.ddd + "', " +
                                                                                     "'" + infoPortalUsuarios.telefone + "', " +
                                                                                     "'" + usuarioInfo.usuario + "', current_timestamp, " +
                                                                                     "'" + usuarioInfo.usuario + "', current_timestamp);"

                ElseIf pstrOperacao = "alteracao" Then
                    strQuery += "update admusuariosempresassistemasportal " +
                                   "set email = '" + infoPortalUsuarios.email + "', " +
                                       "nome = '" + infoPortalUsuarios.nome + "'," +
                                       "ddd = '" + infoPortalUsuarios.ddd + "'," +
                                       "telefone = '" + infoPortalUsuarios.telefone + "', " +
                                       "altuser = '" + usuarioInfo.usuario + "', " +
                                       "altdata = current_timestamp " +
                                 "where empresa = '" + infoPortalUsuarios.empresa + "' " +
                                   "and email = '" + pstrFiltroEmail + "';"
                End If
                For index = 0 To infoPortalUsuarios.sistemas.Count - 1
                    Dim blnEncontrouSistemaUsuario As Boolean = False
                    For indexoriginal = 0 To originalinfoSistemas.Count - 1
                        If infoPortalUsuarios.sistemas(index).sistema = originalinfoSistemas(indexoriginal).sistema Then
                            blnEncontrouSistemaUsuario = True
                            If Not String.IsNullOrEmpty(strQuery) Then
                                strQuery += Chr(13) + Chr(10)
                            End If
                            strQuery += "update admusuariosempresassistemasitensportal " +
                                           "set email = '" + infoPortalUsuarios.email + "', " +
                                               "altuser = '" + usuarioInfo.usuario + "', " +
                                               "altdata = current_timestamp " +
                                         "where empresa = '" + infoPortalUsuarios.empresa + "' " +
                                           "and email = '" + pstrFiltroEmail + "' " +
                                           "and sistema = '" + infoPortalUsuarios.sistemas(index).sistema + "';"

                            Exit For
                        End If
                    Next
                    If Not blnEncontrouSistemaUsuario Then
                        If Not String.IsNullOrEmpty(strQuery) Then
                            strQuery += Chr(13) + Chr(10)
                        End If
                        strQuery += "insert into admusuariosempresassistemasitensportal(empresa, email, sistema, incuser, incdata, altuser, altdata) " +
                                                                                 "values ('" + infoPortalUsuarios.empresa + "', " +
                                                                                         "'" + infoPortalUsuarios.email + "', " +
                                                                                         "'" + infoPortalUsuarios.sistemas(index).sistema + "', " +
                                                                                         "'" + usuarioInfo.usuario + "', current_timestamp, " +
                                                                                         "'" + usuarioInfo.usuario + "', current_timestamp);"
                    End If
                Next
            End If
            objDataBase.NonQuery(strQuery)

            If Not String.IsNullOrEmpty(pstrFiltroEmail) Then
                If pstrFiltroEmail <> infoPortalUsuarios.email Then
                    strEmailOriginal = infoPortalUsuarios.email
                    infoPortalUsuarios.email = pstrFiltroEmail
                    SincronizarPortalUsuarios("exclusao", infoPortalUsuarios)
                    infoPortalUsuarios.email = strEmailOriginal
                End If
            End If
            SincronizarPortalUsuarios(pstrOperacao, infoPortalUsuarios)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub SincronizarPortalUsuarios(ByRef pstrOperacao As String, ByRef infoPortalUsuarios As Modelo.portalusuariosInfo) Implements IPortalUsuarios.SincronizarPortalUsuarios
        Try
            If Not String.IsNullOrEmpty(portalservidorInfo.cnpjcpf) Then
                SplashScreenManager.Default.SetWaitFormDescription("Sincronizando os dados com o portal")
                Dim objDataBase As New DataBaseDAL
                Dim wsInclusao As New InsertWS
                Dim wsConsulta As New SelectWS
                Dim wsAlteracao As New UpdateWS
                Dim wsExclusao As New DeleteWS
                If pstrOperacao <> "exclusao" Then
                    If wsConsulta.UsuarioEmpresaExiste(infoPortalUsuarios.empresa, infoPortalUsuarios.email) Then
                        wsAlteracao.AlterarUsuariosEmpresas(infoPortalUsuarios.empresa, infoPortalUsuarios.nome, infoPortalUsuarios.email, infoPortalUsuarios.ddd, infoPortalUsuarios.telefone)
                    Else
                        wsInclusao.IncluiUsuarioEmpresa(infoPortalUsuarios.empresa, infoPortalUsuarios.nome, infoPortalUsuarios.email, infoPortalUsuarios.ddd, infoPortalUsuarios.telefone)
                    End If
                    For index = 0 To infoPortalUsuarios.sistemas.Count - 1
                        Dim strWSQuery As String = "select emp.obrigacao " +
                                                     "from admusuariosempresassistemasitensportal usu " +
                                                     "join (select aoe.empresa, aoe.obrigacao, ao.sistema " +
                                                             "from (select empresa, obrigacao " +
                                                                     "from admobrigacoesempresas " +
                                                                    "where empresa = '" + infoPortalUsuarios.empresa.ToString + "' " +
                                                                 "group by empresa, obrigacao " +
                                                                "union all " +
                                                                   "select empresa, obrigacao " +
                                                                     "from admcontroleadministrativo " +
                                                                    "where empresa = '" + infoPortalUsuarios.empresa.ToString + "' " +
                                                                      "and obrigacaoextra = -1 " +
                                                                 "group by empresa, obrigacao) aoe " +
                                                             "join admobrigacoes ao on ao.obrigacao = aoe.obrigacao " +
                                                         "group by aoe.empresa, aoe.obrigacao, ao.sistema) emp on emp.empresa = usu.empresa And emp.sistema = usu.sistema " +
                                                    "where usu.empresa = '" + infoPortalUsuarios.empresa.ToString + "' " +
                                                      "and usu.email = '" + infoPortalUsuarios.email + "' " +
                                                      "and usu.sistema = '" + infoPortalUsuarios.sistemas(index).sistema + "'"
                        Dim sdData As SelectedData = objDataBase.QueryFull(strWSQuery)

                        For Each row As SelectStatementResultRow In sdData.ResultSet(1).Rows
                            Dim objObrigacao As New ObrigacoesDAL
                            If Not wsConsulta.EmpresaUsuarioObrigacaoExiste(infoPortalUsuarios.empresa, row.Values(0).ToString, infoPortalUsuarios.email) Then
                                wsInclusao.IncluirEmpresaUsuarioObrigacoes(infoPortalUsuarios.empresa, row.Values(0).ToString, infoPortalUsuarios.email)
                            End If
                        Next row
                    Next
                Else
                    If wsConsulta.UsuarioEmpresaExiste(infoPortalUsuarios.empresa, infoPortalUsuarios.email) Then
                        wsExclusao.UsuarioEmpresaExclui(infoPortalUsuarios.empresa, infoPortalUsuarios.email)
                    End If
                End If
                '------------------------------------------------------------------------------
                ' SINCRONIZANDO O CADASTRO DE OBRIGAÇÕES DOS USUÁRIOS DAS EMPRESAS
                '------------------------------------------------------------------------------
                ' NESSE SEGUNDO PROCESSO EXCLUI OS REGISTROS QUE NÃO EXISTE MAIS LOCALMENTE
                '------------------------------------------------------------------------------
                Dim strDadosObrigacaoUsuarioEmpresa As String = wsConsulta.EmpresaUsuarioObrigacaoRetornaDados(infoPortalUsuarios.empresa, infoPortalUsuarios.email, String.Empty)
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
                                                                                    "where empresa = '" + infoPortalUsuarios.empresa.ToString + "' " +
                                                                                 "group by empresa, obrigacao " +
                                                                                "union all " +
                                                                                   "select empresa, obrigacao " +
                                                                                     "from admcontroleadministrativo " +
                                                                                    "where empresa = '" + infoPortalUsuarios.empresa.ToString + "' " +
                                                                                      "and obrigacaoextra = -1 " +
                                                                                 "group by empresa, obrigacao) aoe " +
                                                                             "join admobrigacoes ao on ao.obrigacao = aoe.obrigacao " +
                                                                         "group by aoe.empresa, aoe.obrigacao, ao.sistema) emp on emp.empresa = usu.empresa And emp.sistema = usu.sistema) total " +
                                              "left join (select cast('LOCAL' as varchar) as origem, a.empresa, a.email, a.obrigacao " +
                                                           "from (select usu.empresa, usu.email, emp.obrigacao " +
                                                                   "from admusuariosempresassistemasitensportal usu " +
                                                                   "join (select aoe.empresa, aoe.obrigacao, ao.sistema " +
                                                                           "from (select empresa, obrigacao " +
                                                                                   "from admobrigacoesempresas " +
                                                                                  "where empresa = '" + infoPortalUsuarios.empresa.ToString + "' " +
                                                                               "group by empresa, obrigacao " +
                                                                              "union all " +
                                                                                 "select empresa, obrigacao " +
                                                                                   "from admcontroleadministrativo " +
                                                                                  "where empresa = '" + infoPortalUsuarios.empresa.ToString + "' " +
                                                                                    "and obrigacaoextra = -1 " +
                                                                               "group by empresa, obrigacao) aoe " +
                                                                           "join admobrigacoes ao on ao.obrigacao = aoe.obrigacao " +
                                                                       "group by aoe.empresa, aoe.obrigacao, ao.sistema) emp on emp.empresa = usu.empresa And emp.sistema = usu.sistema) a) local on local.empresa = total.empresa And local.email = total.email And local.obrigacao = total.obrigacao " +
                                              "left join (" + strQueryObrigacaoUsuarioEmpresaWS + ") ws on ws.empresa = total.empresa And ws.email = total.email And ws.obrigacao = total.obrigacao) r " +
                                                  "where r.resultado = -1"

                    Dim sdDataExclui As SelectedData = objDataBase.QueryFull(strResultadoObrigacaoUsuarioEmpresa)
                    For Each row As SelectStatementResultRow In sdDataExclui.ResultSet(1).Rows
                        If wsConsulta.EmpresaUsuarioObrigacaoExiste(row.Values(0).ToString, row.Values(2).ToString, row.Values(1).ToString) Then
                            wsExclusao.EmpresaUsuarioObrigacaoExclui(row.Values(0).ToString, row.Values(1).ToString, row.Values(2).ToString)
                        End If
                    Next row
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class
