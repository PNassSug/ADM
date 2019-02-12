Imports Administrativo.Modelo
Imports Administrativo.BLL
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base

Public Class monitoramentoXtraForm
    Dim objMonitoramento As New MonitoramentoBLL
    Dim intTotal As Int32
    Dim objFiltro As New FiltroBLL
    Dim blnClosing As Boolean = False

    Public Sub New()
        InitializeComponent()
        monitoramentoSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
    End Sub

    Private Sub monitoramentoXtraForm_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        blnClosing = True
        Me.Dispose()
    End Sub

    Private Sub monitoramentoXtraForm_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            If detalhadoBarCheckItem.Checked = True Then
                CarregaGrid()
            ElseIf geralBarCheckItem.Checked = True Then
                CarregaGrafico()
            End If
        End If
    End Sub

    Private Sub monitoramentoXtraForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Try
            detalhadoBarCheckItem.Checked = True
            objFiltro.IconeOpcaoFiltro(filtroBarButtonItem)
            AtivaNavegador(False)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub localizarBarCheckItem_CheckedChanged(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles localizarBarCheckItem.CheckedChanged
        Try
            monitoramentoGridView.OptionsFind.AlwaysVisible = localizarBarCheckItem.Checked
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub filtroBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles filtroBarButtonItem.ItemClick
        Dim form As filtroXtraForm = New filtroXtraForm()
        form.ShowDialog(Me)
        objFiltro.IconeOpcaoFiltro(filtroBarButtonItem)
        If geralBarCheckItem.Checked = True Then
            CarregaGrafico()
        ElseIf detalhadoBarCheckItem.Checked = True Then
            CarregaGrid()
        End If
    End Sub

    Private Sub atualizarBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles atualizarBarButtonItem.ItemClick
        If detalhadoBarCheckItem.Checked = True Then
            CarregaGrid()
        ElseIf geralBarCheckItem.Checked = True Then
            CarregaGrafico()
        End If
    End Sub

    Private Sub detalhadoBarCheckItem_CheckedChanged(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles detalhadoBarCheckItem.CheckedChanged
        If detalhadoBarCheckItem.Checked = True Then
            CarregaGrid()
            monitoramentoSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
        End If
        geralBarCheckItem.Checked = Not detalhadoBarCheckItem.Checked
        localizarBarCheckItem.Enabled = Not geralBarCheckItem.Checked
    End Sub

    Private Sub geralBarCheckItem_CheckedChanged(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles geralBarCheckItem.CheckedChanged
        If geralBarCheckItem.Checked = True Then
            CarregaGrafico()
            localizarBarCheckItem.Checked = False
            monitoramentoSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
        End If
        detalhadoBarCheckItem.Checked = Not geralBarCheckItem.Checked
        localizarBarCheckItem.Enabled = Not geralBarCheckItem.Checked
    End Sub

    Private Sub monitoramentoChartControl_CustomDrawSeries(sender As Object, e As DevExpress.XtraCharts.CustomDrawSeriesEventArgs)
        If e.Series.ToString = "Não Geradas" Then
            e.SeriesDrawOptions.Color = Color.Red
        ElseIf e.Series.ToString = "Geradas" Then
            e.SeriesDrawOptions.Color = Color.Yellow
        ElseIf e.Series.ToString = "Conferido para Entrega" Then
            e.SeriesDrawOptions.Color = Color.OrangeRed
        Else
            e.SeriesDrawOptions.Color = Color.Green
        End If
        e.LegendDrawOptions.Color = e.SeriesDrawOptions.Color
    End Sub

    Private Sub monitoramentoGridView_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles monitoramentoGridView.CustomColumnDisplayText
        Dim strValor As String = String.Empty

        If e.Column.FieldName = "cnpj" Then
            If monitoramentoGridView.GetRowCellValue(e.ListSourceRowIndex, "cnpj") IsNot Nothing Then
                strValor = monitoramentoGridView.GetRowCellValue(e.ListSourceRowIndex, "cnpj").ToString()
            Else
                strValor = e.Value.ToString
            End If
            If strValor.Length = 14 Then
                '##.###.###/####-##
                e.DisplayText = strValor.Substring(0, 2) + "." + strValor.Substring(2, 3) + "." + strValor.Substring(5, 3) + "/" + strValor.Substring(8, 4) + "-" + strValor.Substring(12, 2)
            ElseIf strValor.Length = 11 Then
                '###.###.###-##
                e.DisplayText = strValor.Substring(0, 3) + "." + strValor.Substring(3, 3) + "." + strValor.Substring(6, 3) + "-" + strValor.Substring(9, 2)
            Else
                e.DisplayText = strValor
            End If
        End If
    End Sub

    Private Sub monitoramentoGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles monitoramentoGridView.KeyDown
        If e.KeyCode = Keys.F5 Then
            If detalhadoBarCheckItem.Checked = True Then
                CarregaGrid()
            End If
        End If
    End Sub

    Private Sub monitoramentoempresaGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles monitoramentoempresaGridView.KeyDown
        If e.KeyCode = Keys.F5 Then
            If detalhadoBarCheckItem.Checked = True Then
                CarregaGrid()
            End If
        End If
    End Sub

    Private Sub monitoramentoempresaGridView_RowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles monitoramentoempresaGridView.RowStyle
        Dim View As GridView = CType(sender, GridView)
        If (e.RowHandle >= 0) Then
            Dim obrigacaoextra As Boolean = Convert.ToInt32(View.GetRowCellDisplayText(e.RowHandle, View.Columns("obrigacaoextra"))) = -1 And
                                          Convert.ToInt32(View.GetRowCellDisplayText(e.RowHandle, View.Columns("sequenciaextra"))) > 0

            If obrigacaoextra Then
                e.Appearance.BackColor = Color.CadetBlue
                e.Appearance.BackColor2 = Color.White
                If Convert.ToInt32(View.GetRowCellDisplayText(e.RowHandle, View.Columns("parcela"))) > 0 Then
                    e.Appearance.BackColor = Color.Goldenrod
                    e.Appearance.BackColor2 = Color.White
                End If
            End If
        End If
    End Sub

    Private Sub informeGridView_RowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles informeGridView.RowStyle
        Dim View As GridView = CType(sender, GridView)
        If (e.RowHandle >= 0) Then
            Dim obrigacaoextra As Boolean = Convert.ToInt32(View.GetRowCellDisplayText(e.RowHandle, View.Columns("obrigacaoextra"))) = -1 And
                                          Convert.ToInt32(View.GetRowCellDisplayText(e.RowHandle, View.Columns("sequenciaextra"))) > 0

            If obrigacaoextra Then
                e.Appearance.BackColor = Color.CadetBlue
                e.Appearance.BackColor2 = Color.White
                If Convert.ToInt32(View.GetRowCellDisplayText(e.RowHandle, View.Columns("parcela"))) > 0 Then
                    e.Appearance.BackColor = Color.Goldenrod
                    e.Appearance.BackColor2 = Color.White
                End If
            End If
        End If
    End Sub

    Private Sub funcionarioGridView_RowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles funcionarioGridView.RowStyle
        Dim View As GridView = CType(sender, GridView)
        If (e.RowHandle >= 0) Then
            Dim obrigacaoextra As Boolean = Convert.ToInt32(View.GetRowCellDisplayText(e.RowHandle, View.Columns("obrigacaoextra"))) = -1 And
                                          Convert.ToInt32(View.GetRowCellDisplayText(e.RowHandle, View.Columns("sequenciaextra"))) > 0

            If obrigacaoextra Then
                e.Appearance.BackColor = Color.CadetBlue
                e.Appearance.BackColor2 = Color.White
                If Convert.ToInt32(View.GetRowCellDisplayText(e.RowHandle, View.Columns("parcela"))) > 0 Then
                    e.Appearance.BackColor = Color.Goldenrod
                    e.Appearance.BackColor2 = Color.White
                End If
            End If
        End If
    End Sub

    Private Sub informeGridView_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles informeGridView.CustomColumnDisplayText
        Dim strValor As String = String.Empty

        If e.Column.FieldName = "cnpj" Then
            If monitoramentoGridView.GetRowCellValue(e.ListSourceRowIndex, "cnpj") IsNot Nothing Then
                strValor = monitoramentoGridView.GetRowCellValue(e.ListSourceRowIndex, "cnpj").ToString()
            Else
                strValor = e.Value.ToString
            End If
            If strValor.Length = 14 Then
                '##.###.###/####-##
                e.DisplayText = strValor.Substring(0, 2) + "." + strValor.Substring(2, 3) + "." + strValor.Substring(5, 3) + "/" + strValor.Substring(8, 4) + "-" + strValor.Substring(12, 2)
            ElseIf strValor.Length = 11 Then
                '###.###.###-##
                e.DisplayText = strValor.Substring(0, 3) + "." + strValor.Substring(3, 3) + "." + strValor.Substring(6, 3) + "-" + strValor.Substring(9, 2)
            Else
                e.DisplayText = strValor
            End If
        End If
    End Sub

    Private Sub monitoramentoGridControl_FocusedViewChanged(sender As System.Object, e As DevExpress.XtraGrid.ViewFocusEventArgs) Handles monitoramentoGridControl.FocusedViewChanged
        Dim strNavegacao As String = String.Empty
        Dim intLinhaGroupMaster As Int32
        If blnClosing Then
            Exit Sub
        End If
        intLinhaGroupMaster = (CType(monitoramentoGridControl.MainView, ColumnView)).FocusedRowHandle

        If monitoramentoGridView.GetMasterRowExpanded(intLinhaGroupMaster) Then
            Dim detailView As GridView = TryCast(monitoramentoGridControl.FocusedView, GridView)
            Dim gvEmpresa As GridView = TryCast(monitoramentoGridControl.Views(0), GridView)
            Dim gvDescricaoAux As GridView
            Dim intCountAux As Int32 = 0
            Dim strDescAux As String

            Dim intLinha As Int32() = detailView.GetSelectedRows()
            Dim intEmpresa As Int32() = gvEmpresa.GetSelectedRows()
            Dim intDescricaoAux As Int32()
            For i As Integer = 0 To intLinha.Length - 1
                If (monitoramentoGridControl.FocusedView.LevelName().ToString = "MonitoramentoEmpresa") Then

                    intCountAux = 0
                    While ("" <> monitoramentoGridControl.Views(intCountAux).LevelName.ToString)
                        intCountAux += 1
                    End While
                    gvDescricaoAux = TryCast(monitoramentoGridControl.Views(intCountAux), GridView)
                    intDescricaoAux = gvDescricaoAux.GetSelectedRows()
                    strDescAux = gvDescricaoAux.GetRowCellValue(intDescricaoAux(intDescricaoAux.Length - 1), gvDescricaoAux.Columns("razaosocial")).ToString()
                    strNavegacao = "Empresa: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("empresa")).ToString.Substring(0, 2) + "." +
                                                 detailView.GetRowCellValue(intLinha(i), detailView.Columns("empresa")).ToString.Substring(2, 4) + " - " +
                                                 strDescAux
                    strNavegacao += " | Competência: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("competencia")).ToString.Substring(0, 2) + "/" +
                                                         detailView.GetRowCellValue(intLinha(i), detailView.Columns("competencia")).ToString.Substring(2, 4)

                ElseIf (monitoramentoGridControl.FocusedView.LevelName().ToString = "MonitoramentoEmpresaDetalhe") Then
                    intCountAux = 0
                    While ("" <> monitoramentoGridControl.Views(intCountAux).LevelName.ToString)
                        intCountAux += 1
                    End While
                    gvDescricaoAux = TryCast(monitoramentoGridControl.Views(intCountAux), GridView)
                    intDescricaoAux = gvDescricaoAux.GetSelectedRows()
                    strDescAux = gvDescricaoAux.GetRowCellValue(intDescricaoAux(intDescricaoAux.Length - 1), gvDescricaoAux.Columns("razaosocial")).ToString()
                    strNavegacao = "Empresa: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("empresa")).ToString.Substring(0, 2) + "." +
                                                 detailView.GetRowCellValue(intLinha(i), detailView.Columns("empresa")).ToString.Substring(2, 4) + " - " +
                                                 strDescAux
                    strNavegacao += " | Competência: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("competencia")).ToString.Substring(0, 2) + "/" +
                                                         detailView.GetRowCellValue(intLinha(i), detailView.Columns("competencia")).ToString.Substring(2, 4)

                ElseIf (monitoramentoGridControl.FocusedView.LevelName().ToString = "MonitoramentoFuncionario") Then

                    intCountAux = 0
                    While ("" <> monitoramentoGridControl.Views(intCountAux).LevelName.ToString)
                        intCountAux += 1
                    End While
                    gvDescricaoAux = TryCast(monitoramentoGridControl.Views(intCountAux), GridView)
                    intDescricaoAux = gvDescricaoAux.GetSelectedRows()
                    strDescAux = gvDescricaoAux.GetRowCellValue(intDescricaoAux(intDescricaoAux.Length - 1), gvDescricaoAux.Columns("razaosocial")).ToString()
                    strNavegacao = "Empresa: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("empresa")).ToString.Substring(0, 2) + "." +
                                                 detailView.GetRowCellValue(intLinha(i), detailView.Columns("empresa")).ToString.Substring(2, 4) + " - " +
                                                 strDescAux
                    strNavegacao += " | Competência: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("competencia")).ToString.Substring(0, 2) + "/" +
                                                         detailView.GetRowCellValue(intLinha(i), detailView.Columns("competencia")).ToString.Substring(2, 4)

                    intCountAux = 0
                    While ("MonitoramentoEmpresaDetalhe" <> monitoramentoGridControl.Views(intCountAux).LevelName.ToString)
                        intCountAux += 1
                    End While
                    gvDescricaoAux = TryCast(monitoramentoGridControl.Views(intCountAux), GridView)
                    intDescricaoAux = gvDescricaoAux.GetSelectedRows()
                    strDescAux = gvDescricaoAux.GetRowCellValue(intDescricaoAux(intDescricaoAux.Length - 1), gvDescricaoAux.Columns("descricao")).ToString()
                    strNavegacao += " | Obrigação: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("obrigacao")).ToString.Substring(0, 1) + "-" +
                                                       detailView.GetRowCellValue(intLinha(i), detailView.Columns("obrigacao")).ToString.Substring(1, 5) + " - " +
                                                       strDescAux

                ElseIf (monitoramentoGridControl.FocusedView.LevelName().ToString = "MonitoramentoInforme") Then

                    intCountAux = 0
                    While ("" <> monitoramentoGridControl.Views(intCountAux).LevelName.ToString)
                        intCountAux += 1
                    End While
                    gvDescricaoAux = TryCast(monitoramentoGridControl.Views(intCountAux), GridView)
                    intDescricaoAux = gvDescricaoAux.GetSelectedRows()
                    strDescAux = gvDescricaoAux.GetRowCellValue(intDescricaoAux(intDescricaoAux.Length - 1), gvDescricaoAux.Columns("razaosocial")).ToString()
                    strNavegacao = "Empresa: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("empresa")).ToString.Substring(0, 2) + "." +
                                                 detailView.GetRowCellValue(intLinha(i), detailView.Columns("empresa")).ToString.Substring(2, 4) + " - " +
                                                 strDescAux
                    strNavegacao += " | Competência: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("competencia")).ToString.Substring(0, 2) + "/" +
                                                         detailView.GetRowCellValue(intLinha(i), detailView.Columns("competencia")).ToString.Substring(2, 4)

                    intCountAux = 0
                    While ("MonitoramentoEmpresaDetalhe" <> monitoramentoGridControl.Views(intCountAux).LevelName.ToString)
                        intCountAux += 1
                    End While
                    gvDescricaoAux = TryCast(monitoramentoGridControl.Views(intCountAux), GridView)
                    intDescricaoAux = gvDescricaoAux.GetSelectedRows()
                    strDescAux = gvDescricaoAux.GetRowCellValue(intDescricaoAux(intDescricaoAux.Length - 1), gvDescricaoAux.Columns("descricao")).ToString()
                    strNavegacao += " | Obrigação: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("obrigacao")).ToString.Substring(0, 1) + "-" +
                                                       detailView.GetRowCellValue(intLinha(i), detailView.Columns("obrigacao")).ToString.Substring(1, 5) + " - " +
                                                       strDescAux
                End If
                navegacaoLabelControl.Text = strNavegacao
                AtivaNavegador(Not String.IsNullOrEmpty(strNavegacao))
            Next
        Else
            AtivaNavegador(False)
        End If
    End Sub

    Private Sub CarregaGrid()
        Try
            Dim strJoinUsuario As String = String.Empty
            Dim strWhere As String = objFiltro.RetornaWhereFiltro("aca")
            If usuarioInfo.obrigacoes Then
                strJoinUsuario = "join admobrigacoesusuarios aou on aou.obrigacao = aca.obrigacao and aou.usuario = '" + usuarioInfo.usuario + "' "
            End If
            Dim strQuery() As String = {"", "", "", "", ""}
            SplashScreenManager.ShowForm(Me, GetType(aguardeWaitForm), True, True, False)
            strQuery(0) = "select aca.empresa, max(e.razaosocial) as razaosocial, max(e.cnpj) as cnpj, aca.competencia, " +
                                 "max(coalesce(ang.naogeradas,0)) as naogeradas, max(coalesce(ag.geradas,0)) as geradas, " +
                                 "max(coalesce(ae.entrega,0)) as entrega, max(coalesce(ac.encarregado,0)) as encarregado, " +
                                 "case when  max(coalesce(ag.geradas,0)) + max(coalesce(ae.entrega,0)) + max(coalesce(ac.encarregado,0)) = 0 then 0 " +
                                 "else case when max(coalesce(ag.geradas,0)) = max(coalesce(ang.naogeradas,0)) and max(coalesce(ae.entrega,0)) = max(coalesce(ang.naogeradas,0)) and max(coalesce(ac.encarregado,0)) = max(coalesce(ang.naogeradas,0)) then 2 else 1 end end as status " +
                            "from admcontroleadministrativo aca " + strJoinUsuario +
                            "join empresas e on e.empresa = aca.empresa and e.exercicio = aca.exercicio " +
                            "join (select aca.empresa, aca.competencia, sum(aca.naogeradas) as naogeradas " +
                                    "from ( " +
                                  "select aca.empresa, aca.competencia, count(*) as naogeradas from admcontroleadministrativo aca " + strJoinUsuario + " where " + strWhere + " and coalesce(aca.tipopessoainforme,0) = 0 group by aca.empresa, aca.competencia " +
                               "union all " +
                                  "select aca.empresa, aca.competencia, count(*) as naogeradas from admcontroleadministrativo aca " + strJoinUsuario + " join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio where " + strWhere + " group by aca.empresa, aca.competencia " +
                               "union all " +
                                  "select aca.empresa, aca.competencia, count(*) as naogeradas from admcontroleadministrativo aca " + strJoinUsuario + " join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio where " + strWhere + " group by aca.empresa, aca.competencia " +
                                         ") aca group by aca.empresa, aca.competencia) ang on ang.empresa = aca.empresa and ang.competencia = aca.competencia " +
                       "left join (select aca.empresa, aca.competencia, sum(aca.geradas) as geradas " +
                                    "from ( " +
                                  "select aca.empresa, aca.competencia, count(*) as geradas from admcontroleadministrativo aca " + strJoinUsuario + " where coalesce(aca.usuariogeracao,'') <> '' and not aca.datahorageracao is null and " + strWhere + " and coalesce(aca.tipopessoainforme,0) = 0 group by aca.empresa, aca.competencia " +
                               "union all " +
                                  "select aca.empresa, aca.competencia, count(*) as geradas from admcontroleadministrativo aca " + strJoinUsuario + " join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio where coalesce(aca.usuariogeracao,'') <> '' and not aca.datahorageracao is null and " + strWhere + "group by aca.empresa, aca.competencia " +
                               "union all " +
                                  "select aca.empresa, aca.competencia, count(*) as geradas from admcontroleadministrativo aca " + strJoinUsuario + " join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio where coalesce(aca.usuariogeracao,'') <> '' and not aca.datahorageracao is null and " + strWhere + "group by aca.empresa, aca.competencia " +
                                         ") aca group by aca.empresa, aca.competencia) ag on ag.empresa = aca.empresa and ag.competencia = aca.competencia " +
                       "left join (select aca.empresa, aca.competencia, sum(aca.entrega) as entrega " +
                                    "from ( " +
                                  "select aca.empresa, aca.competencia, count(*) as entrega from admcontroleadministrativo aca " + strJoinUsuario + " where coalesce(aca.usuarioentrega,'') <> '' and not aca.datahoraentrega is null and aca.vistoentrega = -1 and " + strWhere + " and coalesce(aca.tipopessoainforme,0) = 0 group by aca.empresa, aca.competencia " +
                               "union all " +
                                  "select aca.empresa, aca.competencia, count(*) as entrega from admcontroleadministrativo aca " + strJoinUsuario + " join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio where coalesce(aca.usuarioentrega,'') <> '' and not aca.datahoraentrega is null and aca.vistoentrega = -1 and " + strWhere + "group by aca.empresa, aca.competencia " +
                               "union all " +
                                  "select aca.empresa, aca.competencia, count(*) as entrega from admcontroleadministrativo aca " + strJoinUsuario + " join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio where coalesce(aca.usuarioentrega,'') <> '' and not aca.datahoraentrega is null and aca.vistoentrega = -1 and " + strWhere + "group by aca.empresa, aca.competencia " +
                                         ") aca group by aca.empresa, aca.competencia) ae on ae.empresa = aca.empresa and ae.competencia = aca.competencia " +
                       "left join (select aca.empresa, aca.competencia, sum(aca.encarregado) as encarregado " +
                                    "from ( " +
                                   "select aca.empresa, aca.competencia, count(*) as encarregado from admcontroleadministrativo aca  " + strJoinUsuario + " where coalesce(aca.usuarioencarregado,'') <> '' and not aca.datahoraencarregado is null and aca.vistoencarregado = -1 and " + strWhere + " and coalesce(aca.tipopessoainforme,0) = 0 group by aca.empresa, aca.competencia " +
                                "union all " +
                                   "select aca.empresa, aca.competencia, count(*) as encarregado from admcontroleadministrativo aca  " + strJoinUsuario + " join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio where coalesce(aca.usuarioencarregado,'') <> '' and not aca.datahoraencarregado is null and aca.vistoencarregado = -1 and " + strWhere + "group by aca.empresa, aca.competencia " +
                                "union all " +
                                   "select aca.empresa, aca.competencia, count(*) as encarregado from admcontroleadministrativo aca  " + strJoinUsuario + " join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio where coalesce(aca.usuarioencarregado,'') <> '' and not aca.datahoraencarregado is null and aca.vistoencarregado = -1 and " + strWhere + "group by aca.empresa, aca.competencia " +
                                         ") aca group by aca.empresa, aca.competencia) ac on ac.empresa = aca.empresa and ac.competencia = aca.competencia "
            strQuery(0) += "where " + strWhere +
                        "group by aca.empresa, aca.competencia " +
                        "order by 1"

            strQuery(1) = "select aca.empresa, aca.obrigacao, ao.descricao, aca.datavencimento, " +
                                 "aca.usuariogeracao, aca.datahorageracao, aca.usuarioentrega,  aca.datahoraentrega, aca.usuarioencarregado, aca.datahoraencarregado, " +
                                 "case when coalesce(aca.usuariogeracao,'') = '' and coalesce(aca.vistoentrega,0) = 0 and coalesce(aca.vistoencarregado,0) = 0 then 0 " +
                                 "else case when coalesce(aca.usuariogeracao,'') <> '' and coalesce(aca.vistoentrega,0) <> 0 and coalesce(aca.vistoencarregado,0) <> 0 then 2 else 1 end end as status, aca.sequenciaextra, aca.competencia, aca.obrigacaoextra, aca.parcela " +
                            "from admcontroleadministrativo aca " + strJoinUsuario +
                            "join admobrigacoes ao on ao.obrigacao = aca.obrigacao " +
                           "where " + strWhere +
                             "and coalesce(aca.funcionario,'') = '' " +
                             "and aca.tipopessoainforme = 0 " +
                        "order by aca.empresa, aca.datavencimento, aca.obrigacao, aca.sequenciaextra"

            strQuery(2) = "select aca.empresa, aca.obrigacao, ao.descricao, aca.competencia,  " +
                                  "max(coalesce(ang.naogeradas,0)) as naogeradas, max(coalesce(ag.geradas,0)) as geradas, " +
                                  "max(coalesce(ae.entrega,0)) as entrega, max(coalesce(ac.encarregado,0)) as encarregado, " +
                                  "case when  max(coalesce(ag.geradas,0)) + max(coalesce(ae.entrega,0)) + max(coalesce(ac.encarregado,0)) = 0 then 0 " +
                                  "else case when max(coalesce(ag.geradas,0)) = max(coalesce(ang.naogeradas,0)) and max(coalesce(ae.entrega,0)) = max(coalesce(ang.naogeradas,0)) and max(coalesce(ac.encarregado,0)) = max(coalesce(ang.naogeradas,0)) then 2 else 1 end end as status " +
                            "from admcontroleadministrativo aca  " +
                            "join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio  " +
                            "join admobrigacoes ao on ao.obrigacao = aca.obrigacao  " +
                            "join (select aca.empresa, aca.obrigacao, aca.competencia, count(*) as naogeradas from admcontroleadministrativo aca " + strJoinUsuario + "join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio where " + strWhere + " and coalesce(aca.tipopessoainforme,0) = 1 group by aca.empresa,aca.obrigacao , aca.competencia) ang on ang.empresa = aca.empresa and ang.competencia = aca.competencia and ang.obrigacao = aca.obrigacao " +
                       "left join (select aca.empresa, aca.obrigacao, aca.competencia, count(*) as geradas from admcontroleadministrativo aca " + strJoinUsuario + "join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio where coalesce(aca.usuariogeracao,'') <> '' and not aca.datahorageracao is null and " + strWhere + " and coalesce(aca.tipopessoainforme,0) = 1 group by aca.empresa,aca.obrigacao , aca.competencia) ag on ag.empresa = aca.empresa and ag.competencia = aca.competencia and ag.obrigacao = aca.obrigacao " +
                       "left join (select aca.empresa, aca.obrigacao, aca.competencia, count(*) as entrega from admcontroleadministrativo aca " + strJoinUsuario + "join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio where coalesce(aca.usuarioentrega,'') <> '' and not aca.datahoraentrega is null and aca.vistoentrega = -1 and " + strWhere + " and coalesce(aca.tipopessoainforme,0) = 1 group by aca.empresa,aca.obrigacao , aca.competencia) ae on ae.empresa = aca.empresa and ae.competencia = aca.competencia and ae.obrigacao = aca.obrigacao " +
                       "left join (select aca.empresa, aca.obrigacao, aca.competencia, count(*) as encarregado from admcontroleadministrativo aca " + strJoinUsuario + "join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio where coalesce(aca.usuarioencarregado,'') <> '' and not aca.datahoraencarregado is null and aca.vistoencarregado = -1 and " + strWhere + " and coalesce(aca.tipopessoainforme,0) = 1 group by aca.empresa,aca.obrigacao , aca.competencia) ac on ac.empresa = aca.empresa and ac.competencia = aca.competencia and ac.obrigacao = aca.obrigacao " +
                           "where " + strWhere +
                             "and coalesce(aca.tipopessoainforme,0) = 1 " +
                        "group by aca.empresa, aca.obrigacao, ao.descricao, aca.competencia  " +
                       "union all "
            strQuery(2) += "select aca.empresa, aca.obrigacao, ao.descricao, aca.competencia,  " +
                                   "max(coalesce(ang.naogeradas,0)) as naogeradas, max(coalesce(ag.geradas,0)) as geradas, " +
                                   "max(coalesce(ae.entrega,0)) as entrega, max(coalesce(ac.encarregado,0)) as encarregado, " +
                                   "case when  max(coalesce(ag.geradas,0)) + max(coalesce(ae.entrega,0)) + max(coalesce(ac.encarregado,0)) = 0 then 0 " +
                                   "else case when max(coalesce(ag.geradas,0)) = max(coalesce(ang.naogeradas,0)) and max(coalesce(ae.entrega,0)) = max(coalesce(ang.naogeradas,0)) and max(coalesce(ac.encarregado,0)) = max(coalesce(ang.naogeradas,0)) then 2 else 1 end end as status " +
                             "from admcontroleadministrativo aca  " +
                             "join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio  " +
                             "join admobrigacoes ao on ao.obrigacao = aca.obrigacao  " +
                             "join (select aca.empresa, aca.obrigacao, aca.competencia, count(*) as naogeradas from admcontroleadministrativo aca " + strJoinUsuario + "join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio where " + strWhere + " and coalesce(aca.tipopessoainforme,0) = 2 group by aca.empresa,aca.obrigacao , aca.competencia) ang on ang.empresa = aca.empresa and ang.competencia = aca.competencia and ang.obrigacao = aca.obrigacao " +
                        "left join (select aca.empresa, aca.obrigacao, aca.competencia, count(*) as geradas from admcontroleadministrativo aca " + strJoinUsuario + "join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio where coalesce(aca.usuariogeracao,'') <> '' and not aca.datahorageracao is null and " + strWhere + " and coalesce(aca.tipopessoainforme,0) = 2 group by aca.empresa,aca.obrigacao , aca.competencia) ag on ag.empresa = aca.empresa and ag.competencia = aca.competencia and ag.obrigacao = aca.obrigacao " +
                        "left join (select aca.empresa, aca.obrigacao, aca.competencia, count(*) as entrega from admcontroleadministrativo aca " + strJoinUsuario + "join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio where coalesce(aca.usuarioentrega,'') <> '' and not aca.datahoraentrega is null and aca.vistoentrega = -1 and " + strWhere + " and coalesce(aca.tipopessoainforme,0) = 2 group by aca.empresa,aca.obrigacao , aca.competencia) ae on ae.empresa = aca.empresa and ae.competencia = aca.competencia and ae.obrigacao = aca.obrigacao " +
                        "left join (select aca.empresa, aca.obrigacao, aca.competencia, count(*) as encarregado from admcontroleadministrativo aca " + strJoinUsuario + "join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio where coalesce(aca.usuarioencarregado,'') <> '' and not aca.datahoraencarregado is null and aca.vistoencarregado = -1 and " + strWhere + " and coalesce(aca.tipopessoainforme,0) = 2 group by aca.empresa,aca.obrigacao , aca.competencia) ac on ac.empresa = aca.empresa and ac.competencia = aca.competencia and ac.obrigacao = aca.obrigacao " +
                            "where " + strWhere +
                              "and coalesce(aca.tipopessoainforme,0) = 2 " +
                         "group by aca.empresa, aca.obrigacao, ao.descricao, aca.competencia  " +
                        "union all "
            strQuery(2) += "select aca.empresa, aca.obrigacao, ao.descricao, aca.competencia,  " +
                                   "max(coalesce(ang.naogeradas,0)) as naogeradas, max(coalesce(ag.geradas,0)) as geradas, " +
                                   "max(coalesce(ae.entrega,0)) as entrega, max(coalesce(ac.encarregado,0)) as encarregado, " +
                                   "case when  max(coalesce(ag.geradas,0)) + max(coalesce(ae.entrega,0)) + max(coalesce(ac.encarregado,0)) = 0 then 0 " +
                                   "else case when max(coalesce(ag.geradas,0)) = max(coalesce(ang.naogeradas,0)) and max(coalesce(ae.entrega,0)) = max(coalesce(ang.naogeradas,0)) and max(coalesce(ac.encarregado,0)) = max(coalesce(ang.naogeradas,0)) then 2 else 1 end end as status " +
                             "from admcontroleadministrativo aca  " +
                             "join funcionarios f on f.empresa = aca.empresa and f.funcionario = aca.funcionario   " +
                             "join admobrigacoes ao on ao.obrigacao = aca.obrigacao  " +
                             "join (select aca.empresa, aca.obrigacao, aca.competencia, count(*) as naogeradas from admcontroleadministrativo aca " + strJoinUsuario + "join funcionarios f on f.empresa = aca.empresa and f.funcionario = aca.funcionario where " + strWhere + " and coalesce(aca.funcionario,'') <> '' group by aca.empresa,aca.obrigacao , aca.competencia) ang on ang.empresa = aca.empresa and ang.competencia = aca.competencia and ang.obrigacao = aca.obrigacao " +
                        "left join (select aca.empresa, aca.obrigacao, aca.competencia, count(*) as geradas from admcontroleadministrativo aca " + strJoinUsuario + "join funcionarios f on f.empresa = aca.empresa and f.funcionario = aca.funcionario where coalesce(aca.usuariogeracao,'') <> '' and not aca.datahorageracao is null and " + strWhere + " and coalesce(aca.funcionario,'') <> '' group by aca.empresa,aca.obrigacao , aca.competencia) ag on ag.empresa = aca.empresa and ag.competencia = aca.competencia and ag.obrigacao = aca.obrigacao " +
                        "left join (select aca.empresa, aca.obrigacao, aca.competencia, count(*) as entrega from admcontroleadministrativo aca " + strJoinUsuario + "join funcionarios f on f.empresa = aca.empresa and f.funcionario = aca.funcionario where coalesce(aca.usuarioentrega,'') <> '' and not aca.datahoraentrega is null and aca.vistoentrega = -1 and " + strWhere + " and coalesce(aca.funcionario,'') <> '' group by aca.empresa,aca.obrigacao , aca.competencia) ae on ae.empresa = aca.empresa and ae.competencia = aca.competencia and ae.obrigacao = aca.obrigacao " +
                        "left join (select aca.empresa, aca.obrigacao, aca.competencia, count(*) as encarregado from admcontroleadministrativo aca " + strJoinUsuario + "join funcionarios f on f.empresa = aca.empresa and f.funcionario = aca.funcionario where coalesce(aca.usuarioencarregado,'') <> '' and not aca.datahoraencarregado is null and aca.vistoencarregado = -1 and " + strWhere + " and coalesce(aca.funcionario,'') <> '' group by aca.empresa,aca.obrigacao , aca.competencia) ac on ac.empresa = aca.empresa and ac.competencia = aca.competencia and ac.obrigacao = aca.obrigacao " +
                            "where " + strWhere +
                              "and coalesce(aca.funcionario,'') <> '' " +
                         "group by aca.empresa, aca.obrigacao, ao.descricao, aca.competencia  "

            strQuery(3) = "select aca.empresa, jur.cnpj, jur.nome, aca.datavencimento, aca.usuariogeracao, aca.datahorageracao, aca.usuarioentrega,  aca.datahoraentrega, aca.usuarioencarregado, aca.datahoraencarregado, case when coalesce(aca.usuariogeracao,'') = '' and coalesce(aca.vistoentrega,0) = 0 and coalesce(aca.vistoencarregado,0) = 0 then 0 else case when coalesce(aca.usuariogeracao,'') <> '' and coalesce(aca.vistoentrega,0) <> 0 and coalesce(aca.vistoencarregado,0) <> 0 then 2 else 1 end end as status, aca.sequenciaextra, aca.competencia, aca.obrigacao, aca.obrigacaoextra, aca.parcela " +
                            "from admcontroleadministrativo aca  " + strJoinUsuario +
                            "join admobrigacoes ao on ao.obrigacao = aca.obrigacao  " +
                            "join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio  " +
                           "where " + strWhere +
                             "and coalesce(aca.tipopessoainforme,0) = 1  " +
                           "union all " +
                          "select aca.empresa, fis.cpf, fis.nome, aca.datavencimento, aca.usuariogeracao, aca.datahorageracao, aca.usuarioentrega,  aca.datahoraentrega, aca.usuarioencarregado, aca.datahoraencarregado, case when coalesce(aca.usuariogeracao,'') = '' and coalesce(aca.vistoentrega,0) = 0 and coalesce(aca.vistoencarregado,0) = 0 then 0 else case when coalesce(aca.usuariogeracao,'') <> '' and coalesce(aca.vistoentrega,0) <> 0 and coalesce(aca.vistoencarregado,0) <> 0 then 2 else 1 end end as status, aca.sequenciaextra, aca.competencia, aca.obrigacao, aca.obrigacaoextra, aca.parcela  " +
                            "from admcontroleadministrativo aca  " + strJoinUsuario +
                            "join admobrigacoes ao on ao.obrigacao = aca.obrigacao  " +
                            "join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio  " +
                           "where " + strWhere +
                             "and coalesce(aca.tipopessoainforme,0) = 2  " +
                           "order by 1,2,3 "

            strQuery(4) = "select aca.empresa, f.funcionario, f.nome, aca.datavencimento, aca.usuariogeracao, aca.datahorageracao, aca.usuarioentrega,  aca.datahoraentrega, aca.usuarioencarregado, aca.datahoraencarregado, case when coalesce(aca.usuariogeracao,'') = '' and coalesce(aca.vistoentrega,0) = 0 and coalesce(aca.vistoencarregado,0) = 0 then 0 else case when coalesce(aca.usuariogeracao,'') <> '' and coalesce(aca.vistoentrega,0) <> 0 and coalesce(aca.vistoencarregado,0) <> 0 then 2 else 1 end end as status, aca.sequenciaextra, aca.competencia, aca.obrigacao, aca.obrigacaoextra, aca.parcela " +
                            "from admcontroleadministrativo aca " + strJoinUsuario +
                            "join funcionarios f on f.empresa = aca.empresa and f.funcionario = aca.funcionario " +
                            "join admobrigacoes ao on ao.obrigacao = aca.obrigacao " +
                           "where " + strWhere +
                             "and coalesce(aca.funcionario,'') <> '' " +
                           "order by aca.empresa, aca.datavencimento, aca.obrigacao "

            objMonitoramento.Grid(strQuery, monitoramentoGridControl, monitoramentoGridView, monitoramentoempresaGridView, monitoramentoempresadetalheGridView, informeGridView, funcionarioGridView, statusImageCollection)
            SplashScreenManager.CloseForm()
        Catch ex As Exception
            SplashScreenManager.CloseForm()
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CarregaGrafico()
        Try
            Dim strJoinUsuario As String = String.Empty
            Dim strWhere As String = objFiltro.RetornaWhereFiltro("aca")
            If usuarioInfo.obrigacoes Then
                strJoinUsuario = "join admobrigacoesusuarios aou on aou.obrigacao = aca.obrigacao and aou.usuario = '" + usuarioInfo.usuario + "' "
            End If
            SplashScreenManager.ShowForm(Me, GetType(aguardeWaitForm), True, True, False)

            objMonitoramento.Grafico("select coalesce(sum(coalesce(a.naogeradas,0)),0) - coalesce(sum(coalesce(a.geradas,0)),0) as naogeradas, " +
                                            "coalesce(sum(coalesce(a.geradas,0)),0) - coalesce(sum(coalesce(a.entrega,0)),0) as geradas, " +
                                            "coalesce(sum(coalesce(a.entrega,0)),0) - coalesce(sum(coalesce(a.encarregado,0)),0) as entrega, " +
                                            "coalesce(sum(coalesce(a.encarregado,0)),0) as encarregado " +
                                       "from (select aca.competencia, max(coalesce(ang.naogeradas,0)) as naogeradas, max(coalesce(ag.geradas,0)) as geradas, " +
                                                    "max(coalesce(ae.entrega,0)) as entrega, max(coalesce(ac.encarregado,0)) as encarregado " +
                                               "from admcontroleadministrativo aca " + strJoinUsuario +
                                               "join empresas e on e.empresa = aca.empresa and e.exercicio = aca.exercicio " +
                                               "join ( " +
                                                       "select aca.empresa, aca.competencia, sum(aca.naogeradas) as naogeradas " +
                                                         "from ( " +
                                                                "select aca.empresa, aca.competencia, count(*) as naogeradas from admcontroleadministrativo aca " + strJoinUsuario + " where " + strWhere + " and coalesce(aca.tipopessoainforme,0) = 0 group by aca.empresa, aca.competencia " +
                                                             "union all " +
                                                                "select aca.empresa, aca.competencia, count(*) as naogeradas from admcontroleadministrativo aca " + strJoinUsuario + " join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio where " + strWhere + " group by aca.empresa, aca.competencia " +
                                                             "union all " +
                                                                "select aca.empresa, aca.competencia, count(*) as naogeradas from admcontroleadministrativo aca " + strJoinUsuario + " join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio where " + strWhere + " group by aca.empresa, aca.competencia " +
                                                              ") aca group by aca.empresa, aca.competencia) ang on ang.empresa = aca.empresa and ang.competencia = aca.competencia " +
                                          "left join ( " +
                                                       "select aca.empresa, aca.competencia, sum(aca.geradas) as geradas " +
                                                         "from ( " +
                                                                "select aca.empresa, aca.competencia, count(*) as geradas from admcontroleadministrativo aca " + strJoinUsuario + "where coalesce(aca.usuariogeracao,'') <> '' and not aca.datahorageracao is null and " + strWhere + " and coalesce(aca.tipopessoainforme,0) = 0 group by aca.empresa, aca.competencia " +
                                                             "union all " +
                                                                "select aca.empresa, aca.competencia, count(*) as geradas from admcontroleadministrativo aca " + strJoinUsuario + " join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio where coalesce(aca.usuariogeracao,'') <> '' and not aca.datahorageracao is null and " + strWhere + " group by aca.empresa, aca.competencia " +
                                                             "union all " +
                                                                "select aca.empresa, aca.competencia, count(*) as geradas from admcontroleadministrativo aca " + strJoinUsuario + " join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio where coalesce(aca.usuariogeracao,'') <> '' and not aca.datahorageracao is null and " + strWhere + " group by aca.empresa, aca.competencia " +
                                                              ") aca group by aca.empresa, aca.competencia) ag on ag.empresa = aca.empresa and ag.competencia = aca.competencia " +
                                          "left join ( " +
                                                       "select aca.empresa, aca.competencia, sum(aca.entrega) as entrega " +
                                                         "from ( " +
                                                                "select aca.empresa, aca.competencia, count(*) as entrega from admcontroleadministrativo aca " + strJoinUsuario + "where coalesce(aca.usuarioentrega,'') <> '' and not aca.datahoraentrega is null and aca.vistoentrega = -1 and " + strWhere + " and coalesce(aca.tipopessoainforme,0) = 0 group by aca.empresa, aca.competencia " +
                                                             "union all " +
                                                                "select aca.empresa, aca.competencia, count(*) as entrega from admcontroleadministrativo aca " + strJoinUsuario + " join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio where coalesce(aca.usuarioentrega,'') <> '' and not aca.datahoraentrega is null and aca.vistoentrega = -1 and " + strWhere + " group by aca.empresa, aca.competencia " +
                                                             "union all " +
                                                                "select aca.empresa, aca.competencia, count(*) as entrega from admcontroleadministrativo aca " + strJoinUsuario + " join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio where coalesce(aca.usuarioentrega,'') <> '' and not aca.datahoraentrega is null and aca.vistoentrega = -1 and " + strWhere + " group by aca.empresa, aca.competencia " +
                                                              ") aca group by aca.empresa, aca.competencia) ae on ae.empresa = aca.empresa and ae.competencia = aca.competencia " +
                                          "left join ( " +
                                                       "select aca.empresa, aca.competencia, sum(aca.encarregado) as encarregado " +
                                                         "from ( " +
                                                                "select aca.empresa, aca.competencia, count(*) as encarregado from admcontroleadministrativo aca " + strJoinUsuario + "where coalesce(aca.usuarioencarregado,'') <> '' and not aca.datahoraencarregado is null and aca.vistoencarregado = -1 and " + strWhere + " and coalesce(aca.tipopessoainforme,0) = 0 group by aca.empresa, aca.competencia " +
                                                             "union all " +
                                                                "select aca.empresa, aca.competencia, count(*) as encarregado from admcontroleadministrativo aca " + strJoinUsuario + " join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio where coalesce(aca.usuarioencarregado,'') <> '' and not aca.datahoraencarregado is null and aca.vistoencarregado = -1 and " + strWhere + " group by aca.empresa, aca.competencia " +
                                                             "union all " +
                                                                "select aca.empresa, aca.competencia, count(*) as encarregado from admcontroleadministrativo aca " + strJoinUsuario + " join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio where coalesce(aca.usuarioencarregado,'') <> '' and not aca.datahoraencarregado is null and aca.vistoencarregado = -1 and " + strWhere + " group by aca.empresa, aca.competencia " +
                                                              ") aca group by aca.empresa, aca.competencia) ac on ac.empresa = aca.empresa and ac.competencia = aca.competencia " +
                                              "where " + strWhere + " " +
                                           "group by aca.empresa, aca.competencia) a", monitoramentoChartControl)
            SplashScreenManager.CloseForm()
        Catch ex As Exception
            SplashScreenManager.CloseForm()
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AtivaNavegador(pblnAtivaNavegacao As Boolean)
        navegadorPanelControl.Visible = pblnAtivaNavegacao
        If pblnAtivaNavegacao Then
            monitoramentoGridControl.Size = New System.Drawing.Size(1183, 445)
        Else
            monitoramentoGridControl.Size = New System.Drawing.Size(1183, 476)
        End If
    End Sub
End Class