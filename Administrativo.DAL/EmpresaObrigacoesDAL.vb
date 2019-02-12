Imports Administrativo.Modelo
Imports Administrativo.WS
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Mask
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports DevExpress.Utils
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraGrid
Imports System.Windows.Forms
Imports DevExpress.XtraSplashScreen

Public Class EmpresaObrigacoesDAL
    Implements IEmpresaObrigacoes

    Private edit As RepositoryItemTextEdit
    Private empresaobrigacaoRibbonControl As RibbonControl

    Public Sub Grid(ByRef pstrQuery() As String, ByRef pstrTituloGrid() As String, pdgGrid As DevExpress.XtraGrid.GridControl, pgvGrid As DevExpress.XtraGrid.Views.Grid.GridView, ByRef prcRibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl) Implements IEmpresaObrigacoes.Grid
        Try
            Dim objDataBase As New DataBaseDAL
            Dim sdEmpresaObrigacoes As SelectedData = objDataBase.QueryFull(pstrQuery(0).ToString)

            Dim dsEmpresaObrigacoes As New DataSet()
            Dim dtEmpresaObrigacoes As New DataTable("empresaobrigacao")
            For Each row As SelectStatementResultRow In sdEmpresaObrigacoes.ResultSet(0).Rows
                dtEmpresaObrigacoes.Columns.Add(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
            Next
            dsEmpresaObrigacoes.Tables.Add(dtEmpresaObrigacoes)

            For Each row As SelectStatementResultRow In sdEmpresaObrigacoes.ResultSet(1).Rows
                Dim drEmpresaObrigacoes As DataRow = dsEmpresaObrigacoes.Tables("empresaobrigacao").NewRow()
                For index = 0 To row.Values.Length - 1
                    drEmpresaObrigacoes(index) = row.Values(index)
                Next
                dsEmpresaObrigacoes.Tables("empresaobrigacao").Rows.Add(drEmpresaObrigacoes)
            Next

            sdEmpresaObrigacoes = objDataBase.QueryFull(pstrQuery(1).ToString)
            Dim dtObrigacao As New DataTable("obrigacao")
            For Each row As SelectStatementResultRow In sdEmpresaObrigacoes.ResultSet(0).Rows
                dtObrigacao.Columns.Add(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
            Next
            dsEmpresaObrigacoes.Tables.Add(dtObrigacao)

            For Each row As SelectStatementResultRow In sdEmpresaObrigacoes.ResultSet(1).Rows
                Dim drObrigacao As DataRow = dsEmpresaObrigacoes.Tables("obrigacao").NewRow()
                For index = 0 To row.Values.Length - 1
                    drObrigacao(index) = row.Values(index)
                Next
                dsEmpresaObrigacoes.Tables("obrigacao").Rows.Add(drObrigacao)
            Next

            Dim keyColumn As DataColumn = dsEmpresaObrigacoes.Tables("empresaobrigacao").Columns("empresa")
            Dim foreignKeyColumnObr As DataColumn = dsEmpresaObrigacoes.Tables("obrigacao").Columns("empresa")

            dsEmpresaObrigacoes.Relations.Add("EmpresaObrigacao", keyColumn, foreignKeyColumnObr)

            'Bind the grid control to the data source
            pdgGrid.DataSource = dsEmpresaObrigacoes.Tables("empresaobrigacao")
            pdgGrid.ForceInitialize()
            AddHandler pdgGrid.KeyUp, AddressOf pdgGrid_KeyUp

            pgvGrid.ViewCaption = pstrTituloGrid(0).ToString
            pgvGrid.OptionsDetail.SmartDetailExpandButtonMode = DetailExpandButtonMode.CheckAllDetails

            ' Definição de Mascarás no Grid
            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.Simple
            edit.Mask.UseMaskAsDisplayFormat = True
            edit.Mask.EditMask = "00.0000"
            pgvGrid.Columns(0).ColumnEdit = edit
            pgvGrid.Columns(0).Caption = "Empresa"
            pgvGrid.Columns(0).Width = 80

            pgvGrid.Columns(1).Caption = "Razão Social"
            pgvGrid.Columns(1).Width = 550

            pgvGrid.Columns(2).Visible = False
            AddHandler pgvGrid.RowCellClick, AddressOf pgvGrid_RowCellClick

            Dim obrigacaogridview As New GridView(pdgGrid)
            pdgGrid.LevelTree.Nodes.Add("EmpresaObrigacao", obrigacaogridview)
            obrigacaogridview.ViewCaption = pstrTituloGrid(1).ToString
            obrigacaogridview.PopulateColumns(dsEmpresaObrigacoes.Tables("obrigacao"))
            obrigacaogridview.OptionsBehavior.Editable = False
            obrigacaogridview.OptionsCustomization.AllowQuickHideColumns = False
            obrigacaogridview.OptionsCustomization.AllowColumnResizing = False
            obrigacaogridview.OptionsCustomization.AllowColumnMoving = False
            obrigacaogridview.OptionsCustomization.AllowGroup = False

            obrigacaogridview.OptionsView.ShowGroupPanel = False
            obrigacaogridview.OptionsView.ColumnAutoWidth = False
            obrigacaogridview.ScrollStyle = ScrollStyleFlags.LiveHorzScroll
            obrigacaogridview.ColumnPanelRowHeight = 60
            obrigacaogridview.Appearance.HeaderPanel.Options.UseTextOptions = True
            obrigacaogridview.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center
            obrigacaogridview.Appearance.HeaderPanel.TextOptions.WordWrap = WordWrap.Wrap

            obrigacaogridview.Columns(0).Visible = False

            ' Definição de Mascarás no Grid
            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.Simple
            edit.Mask.UseMaskAsDisplayFormat = True
            edit.Mask.EditMask = "0-00000"
            obrigacaogridview.Columns(1).ColumnEdit = edit
            obrigacaogridview.Columns(1).Caption = "Obrigação"
            obrigacaogridview.Columns(1).Width = 70

            obrigacaogridview.Columns(2).Caption = "Descrição"
            obrigacaogridview.Columns(2).Width = 400

            ' Definição de Mascarás no Grid
            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.Simple
            edit.Mask.UseMaskAsDisplayFormat = True
            edit.Mask.EditMask = "00/0000"
            obrigacaogridview.Columns(3).ColumnEdit = edit
            obrigacaogridview.Columns(3).Caption = "Competência" + Environment.NewLine + "Obsoleta"
            obrigacaogridview.Columns(3).Width = 90
            obrigacaogridview.Name = "obrigacaoGridView"
            AddHandler obrigacaogridview.RowCellClick, AddressOf obrigacaogridview_RowCellClick

            empresaobrigacaoRibbonControl = prcRibbonControl
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Private Sub pdgGrid_KeyUp(sender As Object, e As KeyEventArgs)
        Dim gcSender As GridControl = DirectCast(sender, GridControl)
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up Then
            If gcSender.FocusedView.Name = "empresaobrigacoesGridView" Then
                empresaobrigacaoRibbonControl.Manager.Items(4).Enabled = True
            Else
                empresaobrigacaoRibbonControl.Manager.Items(4).Enabled = False
            End If
        End If
    End Sub

    Private Sub pgvGrid_RowCellClick(sender As Object, e As RowCellClickEventArgs)
        HabilitaDesabilitaExcluirBarButton(sender, e)
    End Sub

    Private Sub obrigacaogridview_RowCellClick(sender As Object, e As RowCellClickEventArgs)
        HabilitaDesabilitaExcluirBarButton(sender, e)
    End Sub

    Private Sub HabilitaDesabilitaExcluirBarButton(pobjSender As Object, prccEvent As RowCellClickEventArgs)
        Dim gvSender As GridView = DirectCast(pobjSender, GridView)
        If gvSender.Name = "empresaobrigacoesGridView" Then
            If prccEvent.Clicks = 1 Then
                empresaobrigacaoRibbonControl.Manager.Items(4).Enabled = True
            Else
                empresaobrigacaoRibbonControl.Manager.Items(4).Enabled = False
            End If
        Else
            empresaobrigacaoRibbonControl.Manager.Items(4).Enabled = False
        End If
    End Sub

    Public Sub Grid(ByRef pstrQuery As String, pdgGrid As DevExpress.XtraGrid.GridControl, pgvGrid As DevExpress.XtraGrid.Views.Grid.GridView, ByRef infoEmpresaObrigacoes As System.Collections.Generic.List(Of Modelo.empresaobrigacoes)) Implements IEmpresaObrigacoes.Grid
        Try
            Dim objDataBase As New DataBaseDAL
            Dim sdObrigacao As SelectedData = objDataBase.QueryFull(pstrQuery)

            For Each row As SelectStatementResultRow In sdObrigacao.ResultSet(1).Rows
                infoEmpresaObrigacoes.Add(New empresaobrigacoes(row.Values(0).ToString, row.Values(1).ToString, row.Values(2).ToString))
            Next

            pdgGrid.DataSource = infoEmpresaObrigacoes

            pgvGrid.OptionsView.ShowGroupPanel = False
            pgvGrid.OptionsView.ColumnAutoWidth = False
            pgvGrid.ScrollStyle = ScrollStyleFlags.LiveHorzScroll
            pgvGrid.ColumnPanelRowHeight = 60
            pgvGrid.Appearance.HeaderPanel.Options.UseTextOptions = True
            pgvGrid.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center
            pgvGrid.Appearance.HeaderPanel.TextOptions.WordWrap = WordWrap.Wrap

            ' Definição de Mascarás no Grid
            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.Simple
            edit.Mask.UseMaskAsDisplayFormat = True
            edit.Mask.EditMask = "0-00000"
            pgvGrid.Columns(0).ColumnEdit = edit
            pgvGrid.Columns(0).Caption = "Obrigação"
            pgvGrid.Columns(0).Width = 80

            pgvGrid.Columns(1).Caption = "Descrição"
            pgvGrid.Columns(1).Width = 480

            ' Definição de Mascarás no Grid
            edit = New RepositoryItemTextEdit()
            edit.Mask.MaskType = MaskType.Simple
            edit.Mask.UseMaskAsDisplayFormat = True
            edit.Mask.EditMask = "00/0000"
            pgvGrid.Columns(2).ColumnEdit = edit
            pgvGrid.Columns(2).Caption = "Competência" + Environment.NewLine + "Obsoleta"
            pgvGrid.Columns(2).Width = 90

            pdgGrid.ForceInitialize()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub IUDEmpresaObrigacoes(ByRef pstrOperacao As String, ByRef infoEmpresaObrigacoes As Modelo.empresaobrigacoesInfo, ByRef originalinfoEmpresaObrigacoes As System.Collections.Generic.List(Of Modelo.empresaobrigacoes)) Implements IEmpresaObrigacoes.IUDEmpresaObrigacoes
        Try
            Dim objDataBase As New DataBaseDAL
            Dim strQuery As String = String.Empty

            If pstrOperacao = "exclusao" Then
                strQuery = "delete " +
                             "from admobrigacoesempresas " +
                            "where empresa = '" + infoEmpresaObrigacoes.empresa + "' " +
                              "and exercicio = " + administrativoInfo.Exercicio.ToString + ";"
            End If
            If pstrOperacao <> "exclusao" Then
                If infoEmpresaObrigacoes.obrigacoes.Count = 0 And originalinfoEmpresaObrigacoes.Count > 0 Then
                    strQuery += Chr(13) + Chr(10)
                    strQuery += "delete " +
                                  "from admobrigacoesempresas " +
                                 "where empresa = '" + infoEmpresaObrigacoes.empresa + "' " +
                                   "and exercicio = " + administrativoInfo.Exercicio.ToString + ";"
                End If
                For indexoriginal = 0 To originalinfoEmpresaObrigacoes.Count - 1
                    Dim blnEncontrouEmpresaObrigacao As Boolean = False
                    For index = 0 To infoEmpresaObrigacoes.obrigacoes.Count - 1
                        If originalinfoEmpresaObrigacoes(indexoriginal).obrigacao = infoEmpresaObrigacoes.obrigacoes(index).obrigacao Then
                            blnEncontrouEmpresaObrigacao = True
                            Exit For
                        End If
                    Next
                    If Not blnEncontrouEmpresaObrigacao Then
                        strQuery += Chr(13) + Chr(10)
                        strQuery += "delete " +
                                      "from admobrigacoesempresas " +
                                     "where empresa = '" + infoEmpresaObrigacoes.empresa + "' " +
                                       "and exercicio = " + administrativoInfo.Exercicio.ToString + " " +
                                       "and obrigacao = '" + originalinfoEmpresaObrigacoes(indexoriginal).obrigacao + "';"
                    End If
                Next
                For index = 0 To infoEmpresaObrigacoes.obrigacoes.Count - 1
                    Dim blnEncontrouEmpresaObrigacao As Boolean = False
                    For indexoriginal = 0 To originalinfoEmpresaObrigacoes.Count - 1
                        If infoEmpresaObrigacoes.obrigacoes(index).obrigacao = originalinfoEmpresaObrigacoes(indexoriginal).obrigacao Then
                            blnEncontrouEmpresaObrigacao = True
                            Exit For
                        End If
                    Next
                    If Not blnEncontrouEmpresaObrigacao Then
                        strQuery += Chr(13) + Chr(10)
                        strQuery += "insert into admobrigacoesempresas(exercicio, empresa, obrigacao, competenciaobsoleta, incuser, incdata, altuser, altdata) " +
                                                              "values (" + administrativoInfo.Exercicio.ToString + ", " +
                                                                      "'" + infoEmpresaObrigacoes.empresa + "', " +
                                                                      "'" + infoEmpresaObrigacoes.obrigacoes(index).obrigacao + "', " +
                                                                      "'" + infoEmpresaObrigacoes.obrigacoes(index).competenciaobsoleta + "', " +
                                                                      "'" + usuarioInfo.usuario + "', current_timestamp, " +
                                                                      "'" + usuarioInfo.usuario + "', current_timestamp);"
                    Else
                        strQuery += Chr(13) + Chr(10)
                        strQuery += "update admobrigacoesempresas " +
                                       "set competenciaobsoleta = '" + infoEmpresaObrigacoes.obrigacoes(index).competenciaobsoleta + "' " +
                                     "where exercicio = " + administrativoInfo.Exercicio.ToString + " " +
                                       "and empresa = '" + infoEmpresaObrigacoes.empresa + "' " +
                                       "and obrigacao = '" + infoEmpresaObrigacoes.obrigacoes(index).obrigacao + "';"
                    End If
                Next
            End If
            objDataBase.NonQuery(strQuery)
            SincronizaEmpresaObrigacoes(pstrOperacao, infoEmpresaObrigacoes)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub SincronizaEmpresaObrigacoes(ByRef pstrOperacao As String, ByRef infoEmpresaObrigacoes As Modelo.empresaobrigacoesInfo) Implements IEmpresaObrigacoes.SincronizaEmpresaObrigacoes
        Try
            Dim objDataBase As New DataBaseDAL
            If Not String.IsNullOrEmpty(portalservidorInfo.cnpjcpf) Then
                SplashScreenManager.Default.SetWaitFormDescription("Sincronizando os dados com o portal")
                Dim strEmpresa As String = String.Empty
                Dim strEmail As String = String.Empty
                Dim intIndex As Int16 = 0

                If pstrOperacao <> "exclusao" Then
                    Dim wsConsulta As New SelectWS
                    If wsConsulta.EmpresaExiste(infoEmpresaObrigacoes.empresa) Then
                        Dim wsAlteracao As New UpdateWS
                        wsAlteracao.AlterarEmpresas(infoEmpresaObrigacoes.empresa, infoEmpresaObrigacoes.razaosocial, infoEmpresaObrigacoes.cnpjcpf)
                    Else
                        Dim wsInclusao As New InsertWS
                        wsInclusao.IncluirEmpresas(infoEmpresaObrigacoes.empresa, infoEmpresaObrigacoes.razaosocial, infoEmpresaObrigacoes.cnpjcpf)
                    End If
                    Dim infosistemasusuarios As portalusuariosInfo
                    Dim infosistemas As List(Of portalusuariossistemas)

                    infosistemasusuarios = New portalusuariosInfo
                    infosistemas = New List(Of portalusuariossistemas)

                    Dim sdEmpresaObrigacoes As SelectedData = objDataBase.QueryFull(
                                                             "select aue.empresa, aue.email, aue.nome, aue.ddd, aue.telefone, aui.sistema " +
                                                               "from admusuariosempresassistemasportal aue " +
                                                               "join admusuariosempresassistemasitensportal aui on aui.empresa = aue.empresa and aui.email = aue.email " +
                                                              "where aue.empresa = '" + infoEmpresaObrigacoes.empresa + "' " +
                                                           "order by aue.empresa, aue.email, aui.sistema")

                    For Each row As SelectStatementResultRow In sdEmpresaObrigacoes.ResultSet(1).Rows
                        intIndex += 1
                        If strEmpresa <> row.Values(0).ToString OrElse strEmail <> row.Values(1).ToString Then
                            If intIndex <> sdEmpresaObrigacoes.ResultSet(1).Rows.Length And intIndex > 1 Then
                                SincronizaPortalUsuariosEmpresaObrigacoes(pstrOperacao, infosistemasusuarios)
                            End If

                            infosistemasusuarios = New portalusuariosInfo
                            infosistemas = New List(Of portalusuariossistemas)

                            infosistemasusuarios.empresa = row.Values(0).ToString
                            infosistemasusuarios.email = row.Values(1).ToString
                            infosistemasusuarios.nome = row.Values(2).ToString
                            infosistemasusuarios.ddd = row.Values(3).ToString
                            infosistemasusuarios.telefone = row.Values(4).ToString

                            strEmpresa = infosistemasusuarios.empresa
                            strEmail = infosistemasusuarios.email
                        End If
                        infosistemas.Add(New portalusuariossistemas(row.Values(5).ToString))
                        infosistemasusuarios.sistemas = infosistemas
                        If intIndex = sdEmpresaObrigacoes.ResultSet(1).Rows.Length Then
                            SincronizaPortalUsuariosEmpresaObrigacoes(pstrOperacao, infosistemasusuarios)
                        End If
                    Next
                Else
                    Dim intCount As Int32 = objDataBase.QuerySimples("select count(*) " +
                                                                       "from admobrigacoesempresas aoe " +
                                                                       "where aoe.empresa = '" + infoEmpresaObrigacoes.empresa + "'")

                    If intCount = 0 Then
                        Dim wsConsulta As New SelectWS
                        If wsConsulta.EmpresaExiste(infoEmpresaObrigacoes.empresa) Then
                            Dim wsExclusao As New DeleteWS
                            wsExclusao.EmpresaExclui(infoEmpresaObrigacoes.empresa)
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub SincronizaPortalUsuariosEmpresaObrigacoes(ByRef pstrOperacao As String, ByRef infoPortalUsuarios As portalusuariosInfo)
        Try
            If infoPortalUsuarios IsNot Nothing Then
                If infoPortalUsuarios.sistemas IsNot Nothing Then
                    Dim objPortalUsuarios As New PortalUsuariosDAL
                    objPortalUsuarios.SincronizarPortalUsuarios(pstrOperacao, infoPortalUsuarios)
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Report(ByRef pstrCampoInicialEmpresa As String, ByRef pstrCampoFinalEmpresa As String, ByRef pstrCampoInicialObrigacao As String, ByRef pstrCampoFinalObrigacao As String, ByRef pstrTipoLucro As String, ByRef pstrTipoEmpresa As String, pReport As DevExpress.XtraReports.UI.XtraReport) Implements IEmpresaObrigacoes.Report
        Try
            Dim objDataBase As New DataBaseDAL
            Dim strQuery As String = String.Empty
            Dim strTabelaTipoLucro As String = String.Empty
            Dim strFiltroTipoLucro As String = String.Empty
            Dim strTabelaTipoEmpresa As String = String.Empty
            Dim strFiltroTipoEmpresa As String = String.Empty

            If Not String.IsNullOrEmpty(pstrTipoLucro) Then
                strFiltroTipoLucro = "and ec.tipolucro = 'P'"
            End If
            strTabelaTipoLucro = "join (select ec.empresa, max(ec.tipolucro) as tipolucro, max(tl.descricao) as tipolucrodesc, " + administrativoInfo.Exercicio.ToString + " as exercicio " +
                                 "from empresacompetencias ec " +
                                 "join tabaux tl on tl.tabela = 'TipoLucro' and tl.codigo = ec.tipolucro " +
                                "where right(ec.competencia,4) = '" + administrativoInfo.Exercicio.ToString + "' " + strFiltroTipoLucro + " " +
                             "group by empresa) tl on tl.empresa = ae.empresa and tl.exercicio = ae.exercicio"
            If String.IsNullOrEmpty(pstrTipoLucro) Then
                strTabelaTipoLucro = "left " + strTabelaTipoLucro
            End If

            If Not String.IsNullOrEmpty(pstrTipoEmpresa) Then
                strFiltroTipoEmpresa = "and te.codigo = '1'"
            End If
            strTabelaTipoEmpresa = "join tabaux te on te.tabela = 'TipoEmpresaEscrita' and te.codigo = e.tipoempresaescrita " + strFiltroTipoEmpresa + " "
            If String.IsNullOrEmpty(pstrTipoEmpresa) Then
                strTabelaTipoEmpresa = "left " + strTabelaTipoEmpresa
            End If

            strQuery = "select ae.empresa, e.razaosocial, ae.obrigacao, a.descricao, ae.competenciaobsoleta, tl.tipolucro, tl.tipolucrodesc, e.tipoempresaescrita as tipoempresa, te.descricao as tipoempresadesc " +
                             "from admobrigacoesempresas ae " +
                             "join empresas e on e.empresa = ae.empresa and e.exercicio = ae.exercicio " +
                             "join admobrigacoes a on a.obrigacao = ae.obrigacao " +
                             strTabelaTipoLucro + " " +
                             strTabelaTipoEmpresa + " " +
                            "where ae.empresa >= '" + pstrCampoInicialEmpresa + "' " +
                              "and ae.empresa <= '" + pstrCampoFinalEmpresa + "' " +
                              "and ae.obrigacao >= '" + pstrCampoInicialObrigacao + "' " +
                              "and ae.obrigacao <= '" + pstrCampoFinalObrigacao + "' " +
                              "and ae.exercicio = " + administrativoInfo.Exercicio.ToString
            strQuery += " order by ae.empresa, ae.obrigacao"

            pReport.DataSource = objDataBase.QueryDataView(strQuery)

            Dim dvtable As XPDataView = CType(pReport.DataSource, XPDataView)
            If dvtable.Count = 0 Then Throw New Exception("Não existem informações a serem impressas")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub GeracaoControleObrigacoes(ByRef pstrEmpresa As String, ByRef pstrCompetencia As String, ByRef pintExercicio As Integer, ByRef pstrObrigacao As String, ByRef pblnExcluiControleObrigacao As Boolean) Implements IEmpresaObrigacoes.GeracaoControleObrigacoes
        Try
            Dim strQuery As String = String.Empty
            Dim objDataBase As New DataBaseDAL
            Dim intCountFuncionarioCompetencias As Int32 = objDataBase.QuerySimples("select count(*) " +
                                                                                      "from funcionarioscompetencias fc " +
                                                                                     "where fc.empresa = '" + pstrEmpresa + "' " +
                                                                                       "and fc.competencia = '" + pstrCompetencia + "'")

            Dim intCountEmpresaCompetencias As Int32 = objDataBase.QuerySimples("select count(*) " +
                                                                                  "from empresacompetencias ec " +
                                                                                 "where ec.empresa = '" + pstrEmpresa + "' " +
                                                                                   "and ec.competencia = '" + pstrCompetencia + "'")

            If intCountEmpresaCompetencias = 0 Then Throw New Exception("Não será possível Gerar o Controle de Obrigações dessa empresa, " +
                                                     "porque a Competência [" + String.Format("{0}/{1}", pstrCompetencia.Substring(0, 2), pstrCompetencia.Substring(2, 4)) + "] " +
                                                     "não foi inicializado nos sistemas Buddywin. Favor verificar.")

            If pblnExcluiControleObrigacao Then
                strQuery = "delete " +
                             "from admcontroleadministrativo " +
                            "where empresa = '" + pstrEmpresa + "' " +
                              "and competencia = '" + pstrCompetencia + "' " +
                              "and exercicio = " + pintExercicio.ToString + " " +
                              "and obrigacaoextra = 0"
                If Not String.IsNullOrEmpty(pstrObrigacao) Then
                    strQuery += " " +
                                "and obrigacao = '" + pstrObrigacao + "'"
                End If
                objDataBase.NonQuery(strQuery)
            Else
                strQuery = "select count(*) " +
                             "from admcontroleadministrativo ec " +
                            "where empresa = '" + pstrEmpresa + "' " +
                              "and competencia = '" + pstrCompetencia + "' " +
                              "and exercicio = " + pintExercicio.ToString
                If Not String.IsNullOrEmpty(pstrObrigacao) Then
                    strQuery += " " +
                                "and obrigacao = '" + pstrObrigacao + "'"
                End If
                intCountEmpresaCompetencias = objDataBase.QuerySimples(strQuery)

                If intCountEmpresaCompetencias > 0 Then Throw New Exception("Não será possível Gerar o Controle de Obrigações dessa empresa, " +
                                                         "porque já existe esse controle na Competência [" + String.Format("{0}/{1}", pstrCompetencia.Substring(0, 2), pstrCompetencia.Substring(2, 4)) + "].")

            End If
            objDataBase.NonQuery("select gd_admgeraobrigacoes('" + pstrEmpresa + "','" + pstrCompetencia + "'," + pintExercicio.ToString + ",'" + pstrObrigacao + "')")
            If intCountFuncionarioCompetencias > 0 Then
                objDataBase.NonQuery("select gd_admgeraobrigacoesfuncionarios('" + pstrEmpresa + "','" + pstrCompetencia + "'," + pintExercicio.ToString + ",'" + pstrObrigacao + "','')")
                objDataBase.NonQuery("select gd_admgeraobrigacoesfuncionarios('" + pstrEmpresa + "','" + pstrCompetencia + "'," + pintExercicio.ToString + ",'" + pstrObrigacao + "', fc.funcionario) " +
                                       "from funcionarioscompetencias fc " +
                                      "where fc.empresa = '" + pstrEmpresa + "' " +
                                        "and fc.competencia = '" + pstrCompetencia + "'")
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function SugereObrigacoes(ByRef pstrEmpresa As String, ByRef pstrEmpresaAux As String, ByRef pstrRazaoSocialAux As String) As String Implements IEmpresaObrigacoes.SugereObrigacoes
        Try
            Dim objDataBase As New DataBaseDAL
            Dim strCnae As String = String.Empty

            Dim sdData As SelectedData = objDataBase.QueryFull("select e.empresa, e.tipoempresaescrita, ec.tipolucro, ec.tipoicms, ec.tipoipi, " +
                                                                      "e.temfolha, e.temcontabil, e.temescrita, e.temlalur, ae.secaocnae " +
                                                                 "from empresas e " +
                                                                 "join (select empresa, cast(max(competeinverte) as varchar(6)) as competeinverte " +
                                                                         "from (select empresa, max(competeinverte) as competeinverte " +
                                                                                 "from empresacompetencias " +
                                                                                "where right(competencia,4) = '" + administrativoInfo.Exercicio.ToString + "' " +
                                                                             "group by empresa, tipolucro) a group by empresa) ecu on ecu.empresa = e.empresa " +
                                                                 "join empresacompetencias ec on ec.empresa = ecu.empresa and ec.competeinverte = ecu.competeinverte " +
                                                            "left join (select ae.empresa, gd_retornasecao(ae.secaocnae) as secaocnae " +
                                                                      "from (select empresa, cast(left(cnae,2) as varchar) as secaocnae " +
                                                                              "from empresas " +
                                                                             "where exercicio = " + administrativoInfo.Exercicio.ToString + " " +
                                                                               "and coalesce(cnae,'') <> '' group by empresa, left(cnae,2) " +
                                                                         "union all " +
                                                                            "select empresa, cast(left(atividadeeconomica,2) as varchar) as secaocnae " +
                                                                              "from atividadeeconomicasec " +
                                                                             "where exercicio = " + administrativoInfo.Exercicio.ToString + " " +
                                                                          "group by empresa, left(atividadeeconomica,2)) ae " +
                                                                  "group by ae.empresa, gd_retornasecao(ae.secaocnae)) ae on ae.empresa = e.empresa " +
                                                                "where e.exercicio = " + administrativoInfo.Exercicio.ToString + " " +
                                                                  "and e.empresa = '" + pstrEmpresa + "'")

            Dim infoSugereObrigacoes As New sugereobrigacoeInfo
            Dim infosecao As New List(Of cnaesecao)

            For Each row As SelectStatementResultRow In sdData.ResultSet(1).Rows
                infoSugereObrigacoes.empresa = Convert.ToString(row.Values(0))
                infoSugereObrigacoes.tipoempresaescrita = Convert.ToString(row.Values(1))
                infoSugereObrigacoes.tipolucro = Convert.ToString(row.Values(2))
                infoSugereObrigacoes.tipoicms = Convert.ToString(row.Values(3))
                infoSugereObrigacoes.tipoipi = Convert.ToString(row.Values(4))
                infoSugereObrigacoes.temfolha = row.Values(5)
                infoSugereObrigacoes.temcontabil = row.Values(6)
                infoSugereObrigacoes.temescrita = row.Values(7)
                infoSugereObrigacoes.temlalur = row.Values(8)

                Dim secaoinfo As New cnaesecao(Convert.ToString(row.Values(9)))
                If Not String.IsNullOrEmpty(strCnae) Then
                    strCnae += ", "
                End If
                strCnae += "'" + Convert.ToString(row.Values(9)) + "'"
                infosecao.Add(secaoinfo)
                infoSugereObrigacoes.cnaesecao = infosecao
            Next row

            If sdData.ResultSet(1).Rows.Length = 0 Then
                infoSugereObrigacoes.empresa = pstrEmpresa
                infoSugereObrigacoes.tipoempresaescrita = String.Empty
                infoSugereObrigacoes.tipolucro = String.Empty
                infoSugereObrigacoes.tipoicms = String.Empty
                infoSugereObrigacoes.tipoipi = String.Empty
                infoSugereObrigacoes.temfolha = 0
                infoSugereObrigacoes.temcontabil = 0
                infoSugereObrigacoes.temescrita = 0
                infoSugereObrigacoes.temlalur = 0

                Dim secaoinfo As New cnaesecao(String.Empty)
                strCnae = "''"
                infosecao.Add(secaoinfo)
                infoSugereObrigacoes.cnaesecao = infosecao
            End If

            sdData = objDataBase.QueryFull("select e.empresa, max(e.razaosocial) as razaosocial, " +
                                                  "max(e.temfolha) as temfolha, max(e.temcontabil) as temcontabil, max(e.temescrita) as temescrita, max(e.temlalur) as temlalur, " +
                                                  "count(*) as qtdcnae " +
                                             "from empresas e " +
                                             "join (select empresa, cast(max(competeinverte) as varchar(6)) as competeinverte " +
                                                     "from (select empresa, max(competeinverte) as competeinverte " +
                                                             "from empresacompetencias " +
                                                            "where right(competencia,4) = '" + administrativoInfo.Exercicio.ToString + "' " +
                                                         "group by empresa, tipolucro) a " +
                                                 "group by empresa) ecu on ecu.empresa = e.empresa " +
                                             "join (select empresa " +
                                                     "from admobrigacoesempresas " +
                                                    "where exercicio = " + administrativoInfo.Exercicio.ToString + " " +
                                                 "group by empresa) ademp on ademp.empresa = e.empresa " +
                                             "join empresacompetencias ec on ec.empresa = ecu.empresa and ec.competeinverte = ecu.competeinverte " +
                                        "left join (select ae.empresa, gd_retornasecao(ae.secaocnae) as secaocnae " +
                                                  "from (select empresa, cast(left(cnae,2) as varchar) as secaocnae " +
                                                          "from empresas " +
                                                         "where exercicio = " + administrativoInfo.Exercicio.ToString + " and coalesce(cnae,'') <> '' " +
                                                      "group by empresa, left(cnae,2) " +
                                                     "union all " +
                                                        "select empresa, cast(left(atividadeeconomica,2) as varchar) as secaocnae " +
                                                          "from atividadeeconomicasec " +
                                                         "where exercicio = " + administrativoInfo.Exercicio.ToString + " " +
                                                      "group by empresa, left(atividadeeconomica,2)) ae " +
                                              "group by ae.empresa, gd_retornasecao(ae.secaocnae)) ae on ae.empresa = e.empresa " +
                                            "where e.exercicio = " + administrativoInfo.Exercicio.ToString + " " +
                                              "and e.saidaescritorio is null " +
                                              "and (e.dataencerraestado is null or e.dataencerrareceita is null or e.dataencerraprefeitura is null) " +
                                              "and (e.temfolha = -1 or e.temcontabil = -1 or e.temescrita = -1 or e.temlalur = -1 or e.temcustos = -1 or e.temcxa = -1) " +
                                              "and ec.tipolucro = '" + infoSugereObrigacoes.tipolucro.ToString + "' " +
                                              "and secaocnae in (" + strCnae + ") " +
                                              "and ec.tipoicms = '" + infoSugereObrigacoes.tipoicms.ToString + "' " +
                                              "and ec.tipoipi = '" + infoSugereObrigacoes.tipoipi.ToString + "' " +
                                              "and e.tipoempresaescrita = '" + infoSugereObrigacoes.tipoempresaescrita.ToString + "'" +
                                         "group by e.empresa " +
                                         "order by 7 desc")

            For Each row As SelectStatementResultRow In sdData.ResultSet(1).Rows
                If row.Values(6) <= infoSugereObrigacoes.cnaesecao.Count Then
                    If Convert.ToBoolean(infoSugereObrigacoes.temfolha) = Convert.ToBoolean(row.Values(2)) And
                        Convert.ToBoolean(infoSugereObrigacoes.temcontabil) = Convert.ToBoolean(row.Values(3)) And
                        Convert.ToBoolean(infoSugereObrigacoes.temescrita) = Convert.ToBoolean(row.Values(4)) And
                        Convert.ToBoolean(infoSugereObrigacoes.temlalur) = Convert.ToBoolean(row.Values(5)) Then
                        pstrEmpresaAux = Convert.ToString(row.Values(0))
                        pstrRazaoSocialAux = Convert.ToString(row.Values(1))
                        Exit For
                    Else
                        If Convert.ToBoolean(row.Values(2)) = True And Convert.ToBoolean(row.Values(3)) = True And Convert.ToBoolean(row.Values(4)) = True Then
                            pstrEmpresaAux = Convert.ToString(row.Values(0))
                            pstrRazaoSocialAux = Convert.ToString(row.Values(1))
                            If Convert.ToBoolean(row.Values(5)) = True Then
                                Exit For
                            End If
                        End If
                    End If
                End If
            Next row

            Dim strSistema As String = "'','CAD'"

            If Convert.ToBoolean(infoSugereObrigacoes.temfolha) Then
                strSistema += ",'FOL'"
            End If
            If Convert.ToBoolean(infoSugereObrigacoes.temcontabil) Then
                strSistema += ",'CON'"
            End If
            If Convert.ToBoolean(infoSugereObrigacoes.temescrita) Then
                strSistema += ",'ESC'"
            End If
            If Convert.ToBoolean(infoSugereObrigacoes.temlalur) Then
                strSistema += ",'LAL'"
            End If

            Return "select aoe.obrigacao, ao.descricao, coalesce(aoe.competenciaobsoleta,'') as competenciaobsoleta " +
                     "from admobrigacoesempresas aoe " +
                     "join admobrigacoes ao on ao.obrigacao = aoe.obrigacao and ao.sistema in (" + strSistema + ") " +
                     "join empresas e on e.empresa = aoe.empresa and e.exercicio = aoe.exercicio " +
                    "where aoe.exercicio = " + administrativoInfo.Exercicio.ToString + " " +
                      "and aoe.empresa = '" + pstrEmpresaAux + "' " +
                 "order by aoe.obrigacao"
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
