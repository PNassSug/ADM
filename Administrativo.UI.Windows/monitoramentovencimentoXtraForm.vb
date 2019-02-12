Imports Administrativo.Modelo
Imports Administrativo.BLL
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base

Public Class monitoramentovencimentoXtraForm
    Dim objMonitoramentoVencimento As New MonitoramentoVencimentoBLL
    Dim objFiltro As New FiltroBLL
    Dim blnClosing As Boolean = False

    Public Sub New()
        InitializeComponent()
        monitoramentoSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
    End Sub

    Private Sub monitoramentovencimentoXtraForm_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        blnClosing = True
        Me.Dispose()
    End Sub

    Private Sub monitoramentovencimentoXtraForm_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            If detalhadoBarCheckItem.Checked = True Then
                CarregaGrid()
            ElseIf geralBarCheckItem.Checked = True Then
                CarregaGrafico()
            End If
        End If
    End Sub

    Private Sub monitoramentovencimentoXtraForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
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

    Private Sub monitoramentoGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles monitoramentoGridView.KeyDown
        If e.KeyCode = Keys.F5 Then
            If detalhadoBarCheckItem.Checked = True Then
                CarregaGrid()
            End If
        End If
    End Sub

    Private Sub obrigacoesGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles obrigacoesGridView.KeyDown
        If e.KeyCode = Keys.F5 Then
            If detalhadoBarCheckItem.Checked = True Then
                CarregaGrid()
            End If
        End If
    End Sub

    Private Sub empresasGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles empresasGridView.KeyDown
        If e.KeyCode = Keys.F5 Then
            If detalhadoBarCheckItem.Checked = True Then
                CarregaGrid()
            End If
        End If
    End Sub

    Private Sub empresasGridView_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles empresasGridView.CustomColumnDisplayText
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

    Private Sub empresadetalheGridView_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles empresadetalheGridView.CustomColumnDisplayText
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

    Private Sub informeGridView_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles informeGridView.CustomColumnDisplayText
        Dim strValor As String = String.Empty

        If e.Column.FieldName = "cnpjcpfinforme" Then
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

    Private Sub empresasGridView_RowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles empresasGridView.RowStyle
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
            Dim gvDescAux As GridView
            Dim gvEmpresaAux As GridView
            Dim intCountAux As Int32 = 0
            Dim strDescAux As String
            Dim strEmpresa As String

            Dim intLinha As Int32() = detailView.GetSelectedRows()
            Dim intEmpresa As Int32() = gvEmpresa.GetSelectedRows()
            Dim intDescAux As Int32()
            Dim intEmpresaAux As Int32()
            For i As Integer = 0 To intLinha.Length - 1
                If (monitoramentoGridControl.FocusedView.LevelName().ToString = "MonitoramentoObrigacao") Then
                    intCountAux = 0
                    While ("" <> monitoramentoGridControl.Views(intCountAux).LevelName.ToString)
                        intCountAux += 1
                    End While
                    gvDescAux = TryCast(monitoramentoGridControl.Views(intCountAux), GridView)
                    intDescAux = gvDescAux.GetSelectedRows()
                    strDescAux = gvDescAux.GetRowCellValue(intDescAux(intDescAux.Length - 1), gvDescAux.Columns("status")).ToString()

                    If strDescAux = "1" Then
                        strDescAux = gvDescAux.GetRowCellValue(intDescAux(intDescAux.Length - 1), gvDescAux.Columns("quantidade")).ToString()
                        strNavegacao = "Status: Obrigações que vencem hoje: " + strDescAux
                    ElseIf strDescAux = "2" Then
                        strDescAux = gvDescAux.GetRowCellValue(intDescAux(intDescAux.Length - 1), gvDescAux.Columns("quantidade")).ToString()
                        strNavegacao = "Status: Obrigações a vencer: " + strDescAux
                    ElseIf strDescAux = "3" Then
                        strDescAux = gvDescAux.GetRowCellValue(intDescAux(intDescAux.Length - 1), gvDescAux.Columns("quantidade")).ToString()
                        strNavegacao = "Status: Obrigações vencidas: " + strDescAux
                    ElseIf strDescAux = "4" Then
                        strDescAux = gvDescAux.GetRowCellValue(intDescAux(intDescAux.Length - 1), gvDescAux.Columns("quantidade")).ToString()
                        strNavegacao = "Status: Obrigações entregues no prazo: " + strDescAux
                    ElseIf strDescAux = "5" Then
                        strDescAux = gvDescAux.GetRowCellValue(intDescAux(intDescAux.Length - 1), gvDescAux.Columns("quantidade")).ToString()
                        strNavegacao = "Status: Obrigações entregues fora do prazo: " + strDescAux
                    End If

                ElseIf (monitoramentoGridControl.FocusedView.LevelName().ToString = "ObrigacaoEmpresaDetalhe") Then
                    intCountAux = 0
                    While ("" <> monitoramentoGridControl.Views(intCountAux).LevelName.ToString)
                        intCountAux += 1
                    End While
                    gvDescAux = TryCast(monitoramentoGridControl.Views(intCountAux), GridView)
                    intDescAux = gvDescAux.GetSelectedRows()
                    strDescAux = gvDescAux.GetRowCellValue(intDescAux(intDescAux.Length - 1), gvDescAux.Columns("status")).ToString()

                    If strDescAux = "1" Then
                        strDescAux = gvDescAux.GetRowCellValue(intDescAux(intDescAux.Length - 1), gvDescAux.Columns("quantidade")).ToString()
                        strNavegacao = "Status: Obrigações que vencem hoje: " + strDescAux
                    ElseIf strDescAux = "2" Then
                        strDescAux = gvDescAux.GetRowCellValue(intDescAux(intDescAux.Length - 1), gvDescAux.Columns("quantidade")).ToString()
                        strNavegacao = "Status: Obrigações a vencer: " + strDescAux
                    ElseIf strDescAux = "3" Then
                        strDescAux = gvDescAux.GetRowCellValue(intDescAux(intDescAux.Length - 1), gvDescAux.Columns("quantidade")).ToString()
                        strNavegacao = "Status: Obrigações vencidas: " + strDescAux
                    ElseIf strDescAux = "4" Then
                        strDescAux = gvDescAux.GetRowCellValue(intDescAux(intDescAux.Length - 1), gvDescAux.Columns("quantidade")).ToString()
                        strNavegacao = "Status: Obrigações entregues no prazo: " + strDescAux
                    ElseIf strDescAux = "5" Then
                        strDescAux = gvDescAux.GetRowCellValue(intDescAux(intDescAux.Length - 1), gvDescAux.Columns("quantidade")).ToString()
                        strNavegacao = "Status: Obrigações entregues fora do prazo: " + strDescAux
                    End If

                    intCountAux = 0
                    While ("MonitoramentoObrigacao" <> monitoramentoGridControl.Views(intCountAux).LevelName.ToString)
                        intCountAux += 1
                    End While
                    gvDescAux = TryCast(monitoramentoGridControl.Views(intCountAux), GridView)
                    intDescAux = gvDescAux.GetSelectedRows()

                    strDescAux = gvDescAux.GetRowCellValue(intDescAux(intDescAux.Length - 1), gvDescAux.Columns("descricao")).ToString()
                    strNavegacao += " | Obrigação: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("obrigacao")).ToString.Substring(0, 1) + "-" +
                                                       detailView.GetRowCellValue(intLinha(i), detailView.Columns("obrigacao")).ToString.Substring(1, 5) + " - " +
                                                       strDescAux

                ElseIf (monitoramentoGridControl.FocusedView.LevelName().ToString = "ObrigacaoEmpresa") Then
                    intCountAux = 0
                    While ("" <> monitoramentoGridControl.Views(intCountAux).LevelName.ToString)
                        intCountAux += 1
                    End While
                    gvDescAux = TryCast(monitoramentoGridControl.Views(intCountAux), GridView)
                    intDescAux = gvDescAux.GetSelectedRows()
                    strDescAux = gvDescAux.GetRowCellValue(intDescAux(intDescAux.Length - 1), gvDescAux.Columns("status")).ToString()

                    If strDescAux = "1" Then
                        strDescAux = gvDescAux.GetRowCellValue(intDescAux(intDescAux.Length - 1), gvDescAux.Columns("quantidade")).ToString()
                        strNavegacao = "Status: Obrigações que vencem hoje: " + strDescAux
                    ElseIf strDescAux = "2" Then
                        strDescAux = gvDescAux.GetRowCellValue(intDescAux(intDescAux.Length - 1), gvDescAux.Columns("quantidade")).ToString()
                        strNavegacao = "Status: Obrigações a vencer: " + strDescAux
                    ElseIf strDescAux = "3" Then
                        strDescAux = gvDescAux.GetRowCellValue(intDescAux(intDescAux.Length - 1), gvDescAux.Columns("quantidade")).ToString()
                        strNavegacao = "Status: Obrigações vencidas: " + strDescAux
                    ElseIf strDescAux = "4" Then
                        strDescAux = gvDescAux.GetRowCellValue(intDescAux(intDescAux.Length - 1), gvDescAux.Columns("quantidade")).ToString()
                        strNavegacao = "Status: Obrigações entregues no prazo: " + strDescAux
                    ElseIf strDescAux = "5" Then
                        strDescAux = gvDescAux.GetRowCellValue(intDescAux(intDescAux.Length - 1), gvDescAux.Columns("quantidade")).ToString()
                        strNavegacao = "Status: Obrigações entregues fora do prazo: " + strDescAux
                    End If

                    intCountAux = 0
                    While ("MonitoramentoObrigacao" <> monitoramentoGridControl.Views(intCountAux).LevelName.ToString)
                        intCountAux += 1
                    End While
                    gvDescAux = TryCast(monitoramentoGridControl.Views(intCountAux), GridView)
                    intDescAux = gvDescAux.GetSelectedRows()

                    strDescAux = gvDescAux.GetRowCellValue(intDescAux(intDescAux.Length - 1), gvDescAux.Columns("descricao")).ToString()
                    strNavegacao += " | Obrigação: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("obrigacao")).ToString.Substring(0, 1) + "-" +
                                                       detailView.GetRowCellValue(intLinha(i), detailView.Columns("obrigacao")).ToString.Substring(1, 5) + " - " +
                                                       strDescAux

                ElseIf (monitoramentoGridControl.FocusedView.LevelName().ToString = "ObrigacaoEmpresaFuncionario") Then
                    intCountAux = 0
                    While ("" <> monitoramentoGridControl.Views(intCountAux).LevelName.ToString)
                        intCountAux += 1
                    End While
                    gvDescAux = TryCast(monitoramentoGridControl.Views(intCountAux), GridView)
                    intDescAux = gvDescAux.GetSelectedRows()
                    strDescAux = gvDescAux.GetRowCellValue(intDescAux(intDescAux.Length - 1), gvDescAux.Columns("status")).ToString()

                    If strDescAux = "1" Then
                        strDescAux = gvDescAux.GetRowCellValue(intDescAux(intDescAux.Length - 1), gvDescAux.Columns("quantidade")).ToString()
                        strNavegacao = "Status: Obrigações que vencem hoje: " + strDescAux
                    ElseIf strDescAux = "2" Then
                        strDescAux = gvDescAux.GetRowCellValue(intDescAux(intDescAux.Length - 1), gvDescAux.Columns("quantidade")).ToString()
                        strNavegacao = "Status: Obrigações a vencer: " + strDescAux
                    ElseIf strDescAux = "3" Then
                        strDescAux = gvDescAux.GetRowCellValue(intDescAux(intDescAux.Length - 1), gvDescAux.Columns("quantidade")).ToString()
                        strNavegacao = "Status: Obrigações vencidas: " + strDescAux
                    ElseIf strDescAux = "4" Then
                        strDescAux = gvDescAux.GetRowCellValue(intDescAux(intDescAux.Length - 1), gvDescAux.Columns("quantidade")).ToString()
                        strNavegacao = "Status: Obrigações entregues no prazo: " + strDescAux
                    ElseIf strDescAux = "5" Then
                        strDescAux = gvDescAux.GetRowCellValue(intDescAux(intDescAux.Length - 1), gvDescAux.Columns("quantidade")).ToString()
                        strNavegacao = "Status: Obrigações entregues fora do prazo: " + strDescAux
                    End If

                    intCountAux = 0
                    While ("MonitoramentoObrigacao" <> monitoramentoGridControl.Views(intCountAux).LevelName.ToString)
                        intCountAux += 1
                    End While
                    gvDescAux = TryCast(monitoramentoGridControl.Views(intCountAux), GridView)
                    intDescAux = gvDescAux.GetSelectedRows()

                    strDescAux = gvDescAux.GetRowCellValue(intDescAux(intDescAux.Length - 1), gvDescAux.Columns("descricao")).ToString()
                    strNavegacao += " | Obrigação: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("obrigacao")).ToString.Substring(0, 1) + "-" +
                                                       detailView.GetRowCellValue(intLinha(i), detailView.Columns("obrigacao")).ToString.Substring(1, 5) + " - " +
                                                       strDescAux
                    intCountAux = 0
                    While ("ObrigacaoEmpresaDetalhe" <> monitoramentoGridControl.Views(intCountAux).LevelName.ToString)
                        intCountAux += 1
                    End While
                    gvEmpresaAux = TryCast(monitoramentoGridControl.Views(intCountAux), GridView)
                    intEmpresaAux = gvEmpresaAux.GetSelectedRows()
                    strEmpresa = gvEmpresaAux.GetRowCellValue(intEmpresaAux(intEmpresaAux.Length - 1), gvEmpresaAux.Columns("razaosocial")).ToString()

                    strNavegacao += " | Empresa: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("empresa")).ToString.Substring(0, 2) + "." +
                                                       detailView.GetRowCellValue(intLinha(i), detailView.Columns("empresa")).ToString.Substring(2, 4) + " - " +
                                                       strEmpresa

                ElseIf (monitoramentoGridControl.FocusedView.LevelName().ToString = "ObrigacaoEmpresaInforme") Then
                    intCountAux = 0
                    While ("" <> monitoramentoGridControl.Views(intCountAux).LevelName.ToString)
                        intCountAux += 1
                    End While
                    gvDescAux = TryCast(monitoramentoGridControl.Views(intCountAux), GridView)
                    intDescAux = gvDescAux.GetSelectedRows()
                    strDescAux = gvDescAux.GetRowCellValue(intDescAux(intDescAux.Length - 1), gvDescAux.Columns("status")).ToString()

                    If strDescAux = "1" Then
                        strDescAux = gvDescAux.GetRowCellValue(intDescAux(intDescAux.Length - 1), gvDescAux.Columns("quantidade")).ToString()
                        strNavegacao = "Status: Obrigações que vencem hoje: " + strDescAux
                    ElseIf strDescAux = "2" Then
                        strDescAux = gvDescAux.GetRowCellValue(intDescAux(intDescAux.Length - 1), gvDescAux.Columns("quantidade")).ToString()
                        strNavegacao = "Status: Obrigações a vencer: " + strDescAux
                    ElseIf strDescAux = "3" Then
                        strDescAux = gvDescAux.GetRowCellValue(intDescAux(intDescAux.Length - 1), gvDescAux.Columns("quantidade")).ToString()
                        strNavegacao = "Status: Obrigações vencidas: " + strDescAux
                    ElseIf strDescAux = "4" Then
                        strDescAux = gvDescAux.GetRowCellValue(intDescAux(intDescAux.Length - 1), gvDescAux.Columns("quantidade")).ToString()
                        strNavegacao = "Status: Obrigações entregues no prazo: " + strDescAux
                    ElseIf strDescAux = "5" Then
                        strDescAux = gvDescAux.GetRowCellValue(intDescAux(intDescAux.Length - 1), gvDescAux.Columns("quantidade")).ToString()
                        strNavegacao = "Status: Obrigações entregues fora do prazo: " + strDescAux
                    End If

                    intCountAux = 0
                    While ("MonitoramentoObrigacao" <> monitoramentoGridControl.Views(intCountAux).LevelName.ToString)
                        intCountAux += 1
                    End While
                    gvDescAux = TryCast(monitoramentoGridControl.Views(intCountAux), GridView)
                    intDescAux = gvDescAux.GetSelectedRows()

                    strDescAux = gvDescAux.GetRowCellValue(intDescAux(intDescAux.Length - 1), gvDescAux.Columns("descricao")).ToString()
                    strNavegacao += " | Obrigação: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("obrigacao")).ToString.Substring(0, 1) + "-" +
                                                       detailView.GetRowCellValue(intLinha(i), detailView.Columns("obrigacao")).ToString.Substring(1, 5) + " - " +
                                                       strDescAux
                    intCountAux = 0
                    While ("ObrigacaoEmpresaDetalhe" <> monitoramentoGridControl.Views(intCountAux).LevelName.ToString)
                        intCountAux += 1
                    End While
                    gvEmpresaAux = TryCast(monitoramentoGridControl.Views(intCountAux), GridView)
                    intEmpresaAux = gvEmpresaAux.GetSelectedRows()
                    strEmpresa = gvEmpresaAux.GetRowCellValue(intEmpresaAux(intEmpresaAux.Length - 1), gvEmpresaAux.Columns("razaosocial")).ToString()

                    strNavegacao += " | Empresa: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("empresa")).ToString.Substring(0, 2) + "." +
                                                       detailView.GetRowCellValue(intLinha(i), detailView.Columns("empresa")).ToString.Substring(2, 4) + " - " +
                                                       strEmpresa
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
            Dim strQuery() As String = {"", "", "", "", "", ""}
            SplashScreenManager.ShowForm(Me, GetType(aguardeWaitForm), True, True, False)
            strQuery(0) = "select case when sum(aca.quantidade) > 0 then 1 else 0 end as status, sum(aca.quantidade) as quantidade " +
                            "from (" +
                                   "select count(*) as quantidade " +
                                     "from admcontroleadministrativo aca " + strJoinUsuario +
                                    "where coalesce(aca.usuarioencarregado,'') = '' and aca.datahoraencarregado is null and aca.vistoencarregado = 0 and extract(day from aca.datavencimento - current_date) = 0 " +
                                      "and coalesce(aca.tipopessoainforme,0) = 0 " +
                                      "and " + strWhere + " " +
                                   "having count(*) > 0 " +
                                "union all " +
                                   "select count(*) as quantidade " +
                                     "from admcontroleadministrativo aca " + strJoinUsuario +
                                     "join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio " +
                                    "where coalesce(aca.usuarioencarregado,'') = '' and aca.datahoraencarregado is null and aca.vistoencarregado = 0 and extract(day from aca.datavencimento - current_date) = 0 " +
                                      "and " + strWhere + " " +
                                   "having count(*) > 0 " +
                                "union all " +
                                   "select count(*) as quantidade " +
                                     "from admcontroleadministrativo aca " + strJoinUsuario +
                                     "join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio " +
                                    "where coalesce(aca.usuarioencarregado,'') = '' and aca.datahoraencarregado is null and aca.vistoencarregado = 0 and extract(day from aca.datavencimento - current_date) = 0 " +
                                      "and " + strWhere + " " +
                                   "having count(*) > 0 " +
                                  ") aca " +
                          "having coalesce(sum(aca.quantidade),0) > 0 " +
                       "union all " +
                          "select case when sum(aca.quantidade) > 0 then 2 else 0 end as status, sum(aca.quantidade) as quantidade " +
                            "from (" +
                                   "select count(*) as quantidade " +
                                     "from admcontroleadministrativo aca " + strJoinUsuario +
                                    "where coalesce(aca.usuarioencarregado,'') = '' and aca.datahoraencarregado is null and aca.vistoencarregado = 0 and extract(day from aca.datavencimento - current_date) > 0 " +
                                      "and coalesce(aca.tipopessoainforme,0) = 0 " +
                                      "and " + strWhere + " " +
                                   "having count(*) > 0 " +
                                "union all " +
                                   "select count(*) as quantidade " +
                                     "from admcontroleadministrativo aca " + strJoinUsuario +
                                     "join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio " +
                                    "where coalesce(aca.usuarioencarregado,'') = '' and aca.datahoraencarregado is null and aca.vistoencarregado = 0 and extract(day from aca.datavencimento - current_date) > 0 " +
                                      "and " + strWhere + " " +
                                   "having count(*) > 0 " +
                                "union all " +
                                   "select count(*) as quantidade " +
                                     "from admcontroleadministrativo aca " + strJoinUsuario +
                                     "join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio " +
                                    "where coalesce(aca.usuarioencarregado,'') = '' and aca.datahoraencarregado is null and aca.vistoencarregado = 0 and extract(day from aca.datavencimento - current_date) > 0 " +
                                      "and " + strWhere + " " +
                                   "having count(*) > 0 " +
                                  ") aca " +
                          "having coalesce(sum(aca.quantidade),0) > 0 " +
                       "union all " +
                          "select case when sum(aca.quantidade) > 0 then 3 else 0 end as status, sum(aca.quantidade) as quantidade " +
                            "from (" +
                                   "select count(*) as quantidade " +
                                     "from admcontroleadministrativo aca " + strJoinUsuario +
                                    "where coalesce(aca.usuarioencarregado,'') = '' and aca.datahoraencarregado is null and aca.vistoencarregado = 0 and extract(day from aca.datavencimento - current_date) < 0 " +
                                      "and coalesce(aca.tipopessoainforme,0) = 0 " +
                                      "and " + strWhere + " " +
                                   "having count(*) > 0 " +
                                "union all " +
                                   "select count(*) as quantidade " +
                                     "from admcontroleadministrativo aca " + strJoinUsuario +
                                     "join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio " +
                                    "where coalesce(aca.usuarioencarregado,'') = '' and aca.datahoraencarregado is null and aca.vistoencarregado = 0 and extract(day from aca.datavencimento - current_date) < 0 " +
                                      "and " + strWhere + " " +
                                   "having count(*) > 0 " +
                                "union all " +
                                   "select count(*) as quantidade " +
                                     "from admcontroleadministrativo aca " + strJoinUsuario +
                                     "join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio " +
                                    "where coalesce(aca.usuarioencarregado,'') = '' and aca.datahoraencarregado is null and aca.vistoencarregado = 0 and extract(day from aca.datavencimento - current_date) < 0 " +
                                      "and " + strWhere + " " +
                                   "having count(*) > 0 " +
                                  ") aca " +
                          "having coalesce(sum(aca.quantidade),0) > 0 " +
                       "union all " +
                          "select case when sum(aca.quantidade) > 0 then 4 else 0 end as status, sum(aca.quantidade) as quantidade " +
                            "from (" +
                                   "select count(*) as quantidade " +
                                     "from admcontroleadministrativo aca " + strJoinUsuario +
                                    "where coalesce(aca.usuarioencarregado,'') <> '' and not aca.datahoraencarregado is null and aca.vistoencarregado = -1 and extract(day from aca.datavencimento - cast(aca.datahoraencarregado as date)) >= 0 " +
                                      "and coalesce(aca.tipopessoainforme,0) = 0 " +
                                      "and " + strWhere + " " +
                                   "having count(*) > 0 " +
                                "union all " +
                                   "select count(*) as quantidade " +
                                     "from admcontroleadministrativo aca " + strJoinUsuario +
                                     "join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio " +
                                    "where coalesce(aca.usuarioencarregado,'') <> '' and not aca.datahoraencarregado is null and aca.vistoencarregado = -1 and extract(day from aca.datavencimento - cast(aca.datahoraencarregado as date)) >= 0 " +
                                      "and " + strWhere + " " +
                                   "having count(*) > 0 " +
                                "union all " +
                                   "select count(*) as quantidade " +
                                     "from admcontroleadministrativo aca " + strJoinUsuario +
                                     "join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio " +
                                    "where coalesce(aca.usuarioencarregado,'') <> '' and not aca.datahoraencarregado is null and aca.vistoencarregado = -1 and extract(day from aca.datavencimento - cast(aca.datahoraencarregado as date)) >= 0 " +
                                      "and " + strWhere + " " +
                                   "having count(*) > 0 " +
                                  ") aca " +
                          "having coalesce(sum(aca.quantidade),0) > 0 " +
                       "union all " +
                          "select case when sum(aca.quantidade) > 0 then 5 else 0 end as status, sum(aca.quantidade) as quantidade " +
                            "from (" +
                                   "select count(*) as quantidade " +
                                     "from admcontroleadministrativo aca " + strJoinUsuario +
                                    "where coalesce(aca.usuarioencarregado,'') <> '' and not aca.datahoraencarregado is null and aca.vistoencarregado = -1 and extract(day from aca.datavencimento - cast(aca.datahoraencarregado as date)) < 0 " +
                                      "and coalesce(aca.tipopessoainforme,0) = 0 " +
                                      "and " + strWhere + " " +
                                   "having count(*) > 0 " +
                                "union all " +
                                   "select count(*) as quantidade " +
                                     "from admcontroleadministrativo aca " + strJoinUsuario +
                                     "join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio " +
                                    "where coalesce(aca.usuarioencarregado,'') <> '' and not aca.datahoraencarregado is null and aca.vistoencarregado = -1 and extract(day from aca.datavencimento - cast(aca.datahoraencarregado as date)) < 0 " +
                                      "and " + strWhere + " " +
                                   "having count(*) > 0 " +
                                "union all " +
                                   "select count(*) as quantidade " +
                                     "from admcontroleadministrativo aca " + strJoinUsuario +
                                     "join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio " +
                                    "where coalesce(aca.usuarioencarregado,'') <> '' and not aca.datahoraencarregado is null and aca.vistoencarregado = -1 and extract(day from aca.datavencimento - cast(aca.datahoraencarregado as date)) < 0 " +
                                      "and " + strWhere + " " +
                                   "having count(*) > 0 " +
                                  ") aca " +
                          "having coalesce(sum(aca.quantidade),0) > 0 " +
                        "order by 1"

            strQuery(1) = "select case when sum(aca.totalobrigacoes) > 0 then 1 else 0 end as status, aca.obrigacao, max(ao.descricao) as descricao, sum(aca.totalobrigacoes) as totalobrigacoes " +
                            "from (" +
                                   "select aca.obrigacao, count(*) as totalobrigacoes " +
                                     "from admcontroleadministrativo aca " + strJoinUsuario +
                                    "where coalesce(aca.usuarioencarregado,'') = '' and aca.datahoraencarregado is null and aca.vistoencarregado = 0 and extract(day from aca.datavencimento - current_date) = 0 " +
                                      "and coalesce(aca.tipopessoainforme,0) = 0 " +
                                      "and " + strWhere + " " +
                                 "group by aca.obrigacao " +
                                "union all " +
                                   "select aca.obrigacao, count(*) as totalobrigacoes " +
                                     "from admcontroleadministrativo aca " + strJoinUsuario +
                                     "join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio " +
                                    "where coalesce(aca.usuarioencarregado,'') = '' and aca.datahoraencarregado is null and aca.vistoencarregado = 0 and extract(day from aca.datavencimento - current_date) = 0 " +
                                      "and " + strWhere + " " +
                                 "group by aca.obrigacao " +
                                "union all " +
                                   "select aca.obrigacao, count(*) as totalobrigacoes " +
                                     "from admcontroleadministrativo aca " + strJoinUsuario +
                                     "join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio " +
                                    "where coalesce(aca.usuarioencarregado,'') = '' and aca.datahoraencarregado is null and aca.vistoencarregado = 0 and extract(day from aca.datavencimento - current_date) = 0 " +
                                      "and " + strWhere + " " +
                                 "group by aca.obrigacao " +
                                 ") aca " +
                            "join admobrigacoes ao on ao.obrigacao = aca.obrigacao " +
                        "group by aca.obrigacao " +
                          "having coalesce(sum(aca.totalobrigacoes),0) > 0 " +
                       "union all " +
                          "select case when sum(aca.totalobrigacoes) > 0 then 2 else 0 end as status, aca.obrigacao, max(ao.descricao) as descricao, sum(aca.totalobrigacoes) as totalobrigacoes " +
                            "from (" +
                                   "select aca.obrigacao, count(*) as totalobrigacoes " +
                                     "from admcontroleadministrativo aca " + strJoinUsuario +
                                    "where coalesce(aca.usuarioencarregado,'') = '' and aca.datahoraencarregado is null and aca.vistoencarregado = 0 and extract(day from aca.datavencimento - current_date) > 0 " +
                                      "and coalesce(aca.tipopessoainforme,0) = 0 " +
                                      "and " + strWhere + " " +
                                 "group by aca.obrigacao " +
                                "union all " +
                                   "select aca.obrigacao, count(*) as totalobrigacoes " +
                                     "from admcontroleadministrativo aca " + strJoinUsuario +
                                     "join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio " +
                                    "where coalesce(aca.usuarioencarregado,'') = '' and aca.datahoraencarregado is null and aca.vistoencarregado = 0 and extract(day from aca.datavencimento - current_date) > 0 " +
                                      "and " + strWhere + " " +
                                 "group by aca.obrigacao " +
                                "union all " +
                                   "select aca.obrigacao, count(*) as totalobrigacoes " +
                                     "from admcontroleadministrativo aca " + strJoinUsuario +
                                     "join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio " +
                                    "where coalesce(aca.usuarioencarregado,'') = '' and aca.datahoraencarregado is null and aca.vistoencarregado = 0 and extract(day from aca.datavencimento - current_date) > 0 " +
                                      "and " + strWhere + " " +
                                 "group by aca.obrigacao " +
                                 ") aca " +
                            "join admobrigacoes ao on ao.obrigacao = aca.obrigacao " +
                        "group by aca.obrigacao " +
                          "having coalesce(sum(aca.totalobrigacoes),0) > 0 " +
                       "union all " +
                          "select case when sum(aca.totalobrigacoes) > 0 then 3 else 0 end as status, aca.obrigacao, max(ao.descricao) as descricao, sum(aca.totalobrigacoes) as totalobrigacoes " +
                            "from (" +
                                   "select aca.obrigacao, count(*) as totalobrigacoes " +
                                     "from admcontroleadministrativo aca " + strJoinUsuario +
                                    "where coalesce(aca.usuarioencarregado,'') = '' and aca.datahoraencarregado is null and aca.vistoencarregado = 0 and extract(day from aca.datavencimento - current_date) < 0 " +
                                      "and coalesce(aca.tipopessoainforme,0) = 0 " +
                                      "and " + strWhere + " " +
                                 "group by aca.obrigacao " +
                                "union all " +
                                   "select aca.obrigacao, count(*) as totalobrigacoes " +
                                     "from admcontroleadministrativo aca " + strJoinUsuario +
                                     "join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio " +
                                    "where coalesce(aca.usuarioencarregado,'') = '' and aca.datahoraencarregado is null and aca.vistoencarregado = 0 and extract(day from aca.datavencimento - current_date) < 0 " +
                                      "and " + strWhere + " " +
                                 "group by aca.obrigacao " +
                                "union all " +
                                   "select aca.obrigacao, count(*) as totalobrigacoes " +
                                     "from admcontroleadministrativo aca " + strJoinUsuario +
                                     "join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio " +
                                    "where coalesce(aca.usuarioencarregado,'') = '' and aca.datahoraencarregado is null and aca.vistoencarregado = 0 and extract(day from aca.datavencimento - current_date) < 0 " +
                                      "and " + strWhere + " " +
                                 "group by aca.obrigacao " +
                                 ") aca " +
                            "join admobrigacoes ao on ao.obrigacao = aca.obrigacao " +
                        "group by aca.obrigacao " +
                          "having coalesce(sum(aca.totalobrigacoes),0) > 0 " +
                       "union all " +
                          "select case when sum(aca.totalobrigacoes) > 0 then 4 else 0 end as status, aca.obrigacao, max(ao.descricao) as descricao, sum(aca.totalobrigacoes) as totalobrigacoes " +
                            "from (" +
                                   "select aca.obrigacao, count(*) as totalobrigacoes " +
                                     "from admcontroleadministrativo aca " + strJoinUsuario +
                                    "where coalesce(aca.usuarioencarregado,'') <> '' and not aca.datahoraencarregado is null and aca.vistoencarregado = -1 and extract(day from aca.datavencimento - cast(aca.datahoraencarregado as date)) >= 0 " +
                                      "and coalesce(aca.tipopessoainforme,0) = 0 " +
                                      "and " + strWhere + " " +
                                 "group by aca.obrigacao " +
                                "union all " +
                                   "select aca.obrigacao, count(*) as totalobrigacoes " +
                                     "from admcontroleadministrativo aca " + strJoinUsuario +
                                     "join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio " +
                                    "where coalesce(aca.usuarioencarregado,'') <> '' and not aca.datahoraencarregado is null and aca.vistoencarregado = -1 and extract(day from aca.datavencimento - cast(aca.datahoraencarregado as date)) >= 0 " +
                                      "and " + strWhere + " " +
                                 "group by aca.obrigacao " +
                                "union all " +
                                   "select aca.obrigacao, count(*) as totalobrigacoes " +
                                     "from admcontroleadministrativo aca " + strJoinUsuario +
                                     "join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio " +
                                    "where coalesce(aca.usuarioencarregado,'') <> '' and not aca.datahoraencarregado is null and aca.vistoencarregado = -1 and extract(day from aca.datavencimento - cast(aca.datahoraencarregado as date)) >= 0 " +
                                      "and " + strWhere + " " +
                                 "group by aca.obrigacao " +
                                 ") aca " +
                            "join admobrigacoes ao on ao.obrigacao = aca.obrigacao " +
                        "group by aca.obrigacao " +
                          "having coalesce(sum(aca.totalobrigacoes),0) > 0 " +
                       "union all " +
                          "select case when sum(aca.totalobrigacoes) > 0 then 5 else 0 end as status, aca.obrigacao, max(ao.descricao) as descricao, sum(aca.totalobrigacoes) as totalobrigacoes " +
                            "from (" +
                                   "select aca.obrigacao, count(*) as totalobrigacoes " +
                                     "from admcontroleadministrativo aca " + strJoinUsuario +
                                    "where coalesce(aca.usuarioencarregado,'') <> '' and not aca.datahoraencarregado is null and aca.vistoencarregado = -1 and extract(day from aca.datavencimento - cast(aca.datahoraencarregado as date)) < 0 " +
                                      "and coalesce(aca.tipopessoainforme,0) = 0 " +
                                      "and " + strWhere + " " +
                                 "group by aca.obrigacao " +
                                "union all " +
                                   "select aca.obrigacao, count(*) as totalobrigacoes " +
                                     "from admcontroleadministrativo aca " + strJoinUsuario +
                                     "join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio " +
                                    "where coalesce(aca.usuarioencarregado,'') <> '' and not aca.datahoraencarregado is null and aca.vistoencarregado = -1 and extract(day from aca.datavencimento - cast(aca.datahoraencarregado as date)) < 0 " +
                                      "and " + strWhere + " " +
                                 "group by aca.obrigacao " +
                                "union all " +
                                   "select aca.obrigacao, count(*) as totalobrigacoes " +
                                     "from admcontroleadministrativo aca " + strJoinUsuario +
                                     "join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio " +
                                    "where coalesce(aca.usuarioencarregado,'') <> '' and not aca.datahoraencarregado is null and aca.vistoencarregado = -1 and extract(day from aca.datavencimento - cast(aca.datahoraencarregado as date)) < 0 " +
                                      "and " + strWhere + " " +
                                 "group by aca.obrigacao " +
                                 ") aca " +
                            "join admobrigacoes ao on ao.obrigacao = aca.obrigacao " +
                        "group by aca.obrigacao " +
                          "having coalesce(sum(aca.totalobrigacoes),0) > 0 " +
                        "order by 2,1"

            strQuery(2) = "select 1 as status, aca.obrigacao, aca.empresa, e.razaosocial as razaosocial, e.cnpj as cnpj, aca.datavencimento, aca.usuariogeracao, aca.datahorageracao, aca.usuarioentrega,  aca.datahoraentrega, aca.usuarioencarregado, aca.datahoraencarregado, case when coalesce(aca.usuariogeracao,'') = '' and coalesce(aca.vistoentrega,0) = 0 and coalesce(aca.vistoencarregado,0) = 0 then 0 else case when coalesce(aca.usuariogeracao,'') <> '' and coalesce(aca.vistoentrega,0) <> 0 and coalesce(aca.vistoencarregado,0) <> 0 then 2 else 1 end end as statusobrigacao, aca.obrigacaoextra, aca.sequenciaextra, aca.parcela " +
                            "from admcontroleadministrativo aca " + strJoinUsuario +
                            "join admobrigacoes ao on ao.obrigacao = aca.obrigacao " +
                            "join empresas e on e.empresa = aca.empresa and e.exercicio = aca.exercicio " +
                           "where coalesce(aca.usuarioencarregado,'') = '' and aca.datahoraencarregado is null and aca.vistoencarregado = 0 and extract(day from aca.datavencimento - current_date) = 0 " +
                             "and " + strWhere + " " +
                             "and coalesce(aca.funcionario,'') = '' " +
                             "and aca.tipopessoainforme = 0 " +
                       "union all " +
                          "select 2 as status, aca.obrigacao, aca.empresa, e.razaosocial as razaosocial, e.cnpj as cnpj, aca.datavencimento, aca.usuariogeracao, aca.datahorageracao, aca.usuarioentrega,  aca.datahoraentrega, aca.usuarioencarregado, aca.datahoraencarregado, case when coalesce(aca.usuariogeracao,'') = '' and coalesce(aca.vistoentrega,0) = 0 and coalesce(aca.vistoencarregado,0) = 0 then 0 else case when coalesce(aca.usuariogeracao,'') <> '' and coalesce(aca.vistoentrega,0) <> 0 and coalesce(aca.vistoencarregado,0) <> 0 then 2 else 1 end end as statusobrigacao, aca.obrigacaoextra, aca.sequenciaextra, aca.parcela " +
                            "from admcontroleadministrativo aca " + strJoinUsuario +
                            "join admobrigacoes ao on ao.obrigacao = aca.obrigacao " +
                            "join empresas e on e.empresa = aca.empresa and e.exercicio = aca.exercicio " +
                           "where coalesce(aca.usuarioencarregado,'') = '' and aca.datahoraencarregado is null and aca.vistoencarregado = 0 and extract(day from aca.datavencimento - current_date) > 0 " +
                             "and " + strWhere + " " +
                             "and coalesce(aca.funcionario,'') = '' " +
                             "and aca.tipopessoainforme = 0 " +
                       "union all " +
                          "select 3 as status, aca.obrigacao, aca.empresa, e.razaosocial as razaosocial, e.cnpj as cnpj, aca.datavencimento, aca.usuariogeracao, aca.datahorageracao, aca.usuarioentrega,  aca.datahoraentrega, aca.usuarioencarregado, aca.datahoraencarregado, case when coalesce(aca.usuariogeracao,'') = '' and coalesce(aca.vistoentrega,0) = 0 and coalesce(aca.vistoencarregado,0) = 0 then 0 else case when coalesce(aca.usuariogeracao,'') <> '' and coalesce(aca.vistoentrega,0) <> 0 and coalesce(aca.vistoencarregado,0) <> 0 then 2 else 1 end end as statusobrigacao, aca.obrigacaoextra, aca.sequenciaextra, aca.parcela " +
                            "from admcontroleadministrativo aca " + strJoinUsuario +
                            "join admobrigacoes ao on ao.obrigacao = aca.obrigacao " +
                            "join empresas e on e.empresa = aca.empresa and e.exercicio = aca.exercicio " +
                           "where coalesce(aca.usuarioencarregado,'') = '' and aca.datahoraencarregado is null and aca.vistoencarregado = 0 and extract(day from aca.datavencimento - current_date) < 0 " +
                             "and " + strWhere + " " +
                             "and coalesce(aca.funcionario,'') = '' " +
                             "and aca.tipopessoainforme = 0 " +
                       "union all " +
                          "select 4 as status, aca.obrigacao, aca.empresa, e.razaosocial as razaosocial, e.cnpj as cnpj, aca.datavencimento, aca.usuariogeracao, aca.datahorageracao, aca.usuarioentrega,  aca.datahoraentrega, aca.usuarioencarregado, aca.datahoraencarregado, case when coalesce(aca.usuariogeracao,'') = '' and coalesce(aca.vistoentrega,0) = 0 and coalesce(aca.vistoencarregado,0) = 0 then 0 else case when coalesce(aca.usuariogeracao,'') <> '' and coalesce(aca.vistoentrega,0) <> 0 and coalesce(aca.vistoencarregado,0) <> 0 then 2 else 1 end end as statusobrigacao, aca.obrigacaoextra, aca.sequenciaextra, aca.parcela " +
                            "from admcontroleadministrativo aca " + strJoinUsuario +
                            "join admobrigacoes ao on ao.obrigacao = aca.obrigacao " +
                            "join empresas e on e.empresa = aca.empresa and e.exercicio = aca.exercicio " +
                           "where coalesce(aca.usuarioencarregado,'') <> '' and not aca.datahoraencarregado is null and aca.vistoencarregado = -1 and extract(day from aca.datavencimento - cast(aca.datahoraencarregado as date)) >= 0  " +
                             "and " + strWhere + " " +
                             "and coalesce(aca.funcionario,'') = '' " +
                             "and aca.tipopessoainforme = 0 " +
                       "union all " +
                          "select 5 as status, aca.obrigacao, aca.empresa, e.razaosocial as razaosocial, e.cnpj as cnpj, aca.datavencimento, aca.usuariogeracao, aca.datahorageracao, aca.usuarioentrega,  aca.datahoraentrega, aca.usuarioencarregado, aca.datahoraencarregado, case when coalesce(aca.usuariogeracao,'') = '' and coalesce(aca.vistoentrega,0) = 0 and coalesce(aca.vistoencarregado,0) = 0 then 0 else case when coalesce(aca.usuariogeracao,'') <> '' and coalesce(aca.vistoentrega,0) <> 0 and coalesce(aca.vistoencarregado,0) <> 0 then 2 else 1 end end as statusobrigacao, aca.obrigacaoextra, aca.sequenciaextra, aca.parcela " +
                            "from admcontroleadministrativo aca " + strJoinUsuario +
                            "join admobrigacoes ao on ao.obrigacao = aca.obrigacao " +
                            "join empresas e on e.empresa = aca.empresa and e.exercicio = aca.exercicio " +
                           "where coalesce(aca.usuarioencarregado,'') <> '' and not aca.datahoraencarregado is null and aca.vistoencarregado = -1 and extract(day from aca.datavencimento - cast(aca.datahoraencarregado as date)) < 0 " +
                             "and " + strWhere + " " +
                             "and coalesce(aca.funcionario,'') = '' " +
                             "and aca.tipopessoainforme = 0 "

            strQuery(3) = "select 1 as status, aca.obrigacao, aca.empresa, max(e.razaosocial) as razaosocial, max(e.cnpj) as cnpj, count(*) as totalobrigacoes " +
                             "from admcontroleadministrativo aca " + strJoinUsuario +
                             "join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio  " +
                             "join admobrigacoes ao on ao.obrigacao = aca.obrigacao " +
                             "join empresas e on e.empresa = aca.empresa and e.exercicio = aca.exercicio " +
                            "where coalesce(aca.usuarioencarregado,'') = '' and aca.datahoraencarregado is null and aca.vistoencarregado = 0 and extract(day from aca.datavencimento - current_date) = 0 " +
                              "and " + strWhere + " " +
                              "and coalesce(aca.tipopessoainforme,0) = 1 " +
                         "group by aca.obrigacao, aca.empresa " +
                        "union all " +
                           "select 2 as status, aca.obrigacao, aca.empresa, max(e.razaosocial) as razaosocial, max(e.cnpj) as cnpj, count(*) as totalobrigacoes " +
                             "from admcontroleadministrativo aca " + strJoinUsuario +
                             "join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio  " +
                             "join admobrigacoes ao on ao.obrigacao = aca.obrigacao " +
                             "join empresas e on e.empresa = aca.empresa and e.exercicio = aca.exercicio " +
                            "where coalesce(aca.usuarioencarregado,'') = '' and aca.datahoraencarregado is null and aca.vistoencarregado = 0 and extract(day from aca.datavencimento - current_date) > 0 " +
                              "and " + strWhere + " " +
                              "and coalesce(aca.tipopessoainforme,0) = 1 " +
                         "group by aca.obrigacao, aca.empresa " +
                        "union all " +
                           "select 3 as status, aca.obrigacao, aca.empresa, max(e.razaosocial) as razaosocial, max(e.cnpj) as cnpj, count(*) as totalobrigacoes " +
                             "from admcontroleadministrativo aca " + strJoinUsuario +
                             "join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio  " +
                             "join admobrigacoes ao on ao.obrigacao = aca.obrigacao " +
                             "join empresas e on e.empresa = aca.empresa and e.exercicio = aca.exercicio " +
                            "where coalesce(aca.usuarioencarregado,'') = '' and aca.datahoraencarregado is null and aca.vistoencarregado = 0 and extract(day from aca.datavencimento - current_date) < 0 " +
                              "and " + strWhere + " " +
                              "and coalesce(aca.tipopessoainforme,0) = 1 " +
                         "group by aca.obrigacao, aca.empresa " +
                        "union all " +
                           "select 4 as status, aca.obrigacao, aca.empresa, max(e.razaosocial) as razaosocial, max(e.cnpj) as cnpj, count(*) as totalobrigacoes " +
                             "from admcontroleadministrativo aca " + strJoinUsuario +
                             "join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio  " +
                             "join admobrigacoes ao on ao.obrigacao = aca.obrigacao " +
                             "join empresas e on e.empresa = aca.empresa and e.exercicio = aca.exercicio " +
                            "where coalesce(aca.usuarioencarregado,'') <> '' and not aca.datahoraencarregado is null and aca.vistoencarregado = -1 and extract(day from aca.datavencimento - cast(aca.datahoraencarregado as date)) >= 0  " +
                              "and " + strWhere + " " +
                              "and coalesce(aca.tipopessoainforme,0) = 1 " +
                         "group by aca.obrigacao, aca.empresa " +
                        "union all " +
                           "select 5 as status, aca.obrigacao, aca.empresa, max(e.razaosocial) as razaosocial, max(e.cnpj) as cnpj, count(*) as totalobrigacoes " +
                             "from admcontroleadministrativo aca " + strJoinUsuario +
                             "join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio  " +
                             "join admobrigacoes ao on ao.obrigacao = aca.obrigacao " +
                             "join empresas e on e.empresa = aca.empresa and e.exercicio = aca.exercicio " +
                            "where coalesce(aca.usuarioencarregado,'') <> '' and not aca.datahoraencarregado is null and aca.vistoencarregado = -1 and extract(day from aca.datavencimento - cast(aca.datahoraencarregado as date)) < 0 " +
                              "and " + strWhere + " " +
                              "and coalesce(aca.tipopessoainforme,0) = 1 " +
                         "group by aca.obrigacao, aca.empresa "
            strQuery(3) += "union all "
            strQuery(3) += "select 1 as status, aca.obrigacao, aca.empresa, max(e.razaosocial) as razaosocial, max(e.cnpj) as cnpj, count(*) as totalobrigacoes " +
                             "from admcontroleadministrativo aca " + strJoinUsuario +
                             "join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio  " +
                             "join admobrigacoes ao on ao.obrigacao = aca.obrigacao " +
                             "join empresas e on e.empresa = aca.empresa and e.exercicio = aca.exercicio " +
                            "where coalesce(aca.usuarioencarregado,'') = '' and aca.datahoraencarregado is null and aca.vistoencarregado = 0 and extract(day from aca.datavencimento - current_date) = 0 " +
                              "and " + strWhere + " " +
                              "and coalesce(aca.tipopessoainforme,0) = 2 " +
                         "group by aca.obrigacao, aca.empresa " +
                        "union all " +
                           "select 2 as status, aca.obrigacao, aca.empresa, max(e.razaosocial) as razaosocial, max(e.cnpj) as cnpj, count(*) as totalobrigacoes " +
                             "from admcontroleadministrativo aca " + strJoinUsuario +
                             "join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio  " +
                             "join admobrigacoes ao on ao.obrigacao = aca.obrigacao " +
                             "join empresas e on e.empresa = aca.empresa and e.exercicio = aca.exercicio " +
                            "where coalesce(aca.usuarioencarregado,'') = '' and aca.datahoraencarregado is null and aca.vistoencarregado = 0 and extract(day from aca.datavencimento - current_date) > 0 " +
                              "and " + strWhere + " " +
                              "and coalesce(aca.tipopessoainforme,0) = 2 " +
                         "group by aca.obrigacao, aca.empresa " +
                        "union all " +
                           "select 3 as status, aca.obrigacao, aca.empresa, max(e.razaosocial) as razaosocial, max(e.cnpj) as cnpj, count(*) as totalobrigacoes " +
                             "from admcontroleadministrativo aca " + strJoinUsuario +
                             "join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio  " +
                             "join admobrigacoes ao on ao.obrigacao = aca.obrigacao " +
                             "join empresas e on e.empresa = aca.empresa and e.exercicio = aca.exercicio " +
                            "where coalesce(aca.usuarioencarregado,'') = '' and aca.datahoraencarregado is null and aca.vistoencarregado = 0 and extract(day from aca.datavencimento - current_date) < 0 " +
                              "and " + strWhere + " " +
                              "and coalesce(aca.tipopessoainforme,0) = 2 " +
                         "group by aca.obrigacao, aca.empresa " +
                        "union all " +
                           "select 4 as status, aca.obrigacao, aca.empresa, max(e.razaosocial) as razaosocial, max(e.cnpj) as cnpj, count(*) as totalobrigacoes " +
                             "from admcontroleadministrativo aca " + strJoinUsuario +
                             "join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio  " +
                             "join admobrigacoes ao on ao.obrigacao = aca.obrigacao " +
                             "join empresas e on e.empresa = aca.empresa and e.exercicio = aca.exercicio " +
                            "where coalesce(aca.usuarioencarregado,'') <> '' and not aca.datahoraencarregado is null and aca.vistoencarregado = -1 and extract(day from aca.datavencimento - cast(aca.datahoraencarregado as date)) >= 0  " +
                              "and " + strWhere + " " +
                              "and coalesce(aca.tipopessoainforme,0) = 2 " +
                         "group by aca.obrigacao, aca.empresa " +
                        "union all " +
                           "select 5 as status, aca.obrigacao, aca.empresa, max(e.razaosocial) as razaosocial, max(e.cnpj) as cnpj, count(*) as totalobrigacoes " +
                             "from admcontroleadministrativo aca " + strJoinUsuario +
                             "join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio  " +
                             "join admobrigacoes ao on ao.obrigacao = aca.obrigacao " +
                             "join empresas e on e.empresa = aca.empresa and e.exercicio = aca.exercicio " +
                            "where coalesce(aca.usuarioencarregado,'') <> '' and not aca.datahoraencarregado is null and aca.vistoencarregado = -1 and extract(day from aca.datavencimento - cast(aca.datahoraencarregado as date)) < 0 " +
                              "and " + strWhere + " " +
                              "and coalesce(aca.tipopessoainforme,0) = 2 " +
                         "group by aca.obrigacao, aca.empresa "
            strQuery(3) += "union all "
            strQuery(3) += "select 1 as status, aca.obrigacao, aca.empresa, max(e.razaosocial) as razaosocial, max(e.cnpj) as cnpj, count(*) as totalobrigacoes " +
                            "from admcontroleadministrativo aca " + strJoinUsuario +
                            "join funcionarios f on f.empresa = aca.empresa and f.funcionario = aca.funcionario  " +
                            "join admobrigacoes ao on ao.obrigacao = aca.obrigacao " +
                            "join empresas e on e.empresa = aca.empresa and e.exercicio = aca.exercicio " +
                           "where coalesce(aca.usuarioencarregado,'') = '' and aca.datahoraencarregado is null and aca.vistoencarregado = 0 and extract(day from aca.datavencimento - current_date) = 0 " +
                             "and " + strWhere + " " +
                             "and coalesce(aca.funcionario,'') <> '' " +
                        "group by aca.obrigacao, aca.empresa " +
                       "union all " +
                          "select 2 as status, aca.obrigacao, aca.empresa, max(e.razaosocial) as razaosocial, max(e.cnpj) as cnpj, count(*) as totalobrigacoes " +
                            "from admcontroleadministrativo aca " + strJoinUsuario +
                            "join funcionarios f on f.empresa = aca.empresa and f.funcionario = aca.funcionario  " +
                            "join admobrigacoes ao on ao.obrigacao = aca.obrigacao " +
                            "join empresas e on e.empresa = aca.empresa and e.exercicio = aca.exercicio " +
                           "where coalesce(aca.usuarioencarregado,'') = '' and aca.datahoraencarregado is null and aca.vistoencarregado = 0 and extract(day from aca.datavencimento - current_date) > 0 " +
                             "and " + strWhere + " " +
                             "and coalesce(aca.funcionario,'') <> '' " +
                        "group by aca.obrigacao, aca.empresa " +
                       "union all " +
                          "select 3 as status, aca.obrigacao, aca.empresa, max(e.razaosocial) as razaosocial, max(e.cnpj) as cnpj, count(*) as totalobrigacoes " +
                            "from admcontroleadministrativo aca " + strJoinUsuario +
                            "join funcionarios f on f.empresa = aca.empresa and f.funcionario = aca.funcionario  " +
                            "join admobrigacoes ao on ao.obrigacao = aca.obrigacao " +
                            "join empresas e on e.empresa = aca.empresa and e.exercicio = aca.exercicio " +
                           "where coalesce(aca.usuarioencarregado,'') = '' and aca.datahoraencarregado is null and aca.vistoencarregado = 0 and extract(day from aca.datavencimento - current_date) < 0 " +
                             "and " + strWhere + " " +
                             "and coalesce(aca.funcionario,'') <> '' " +
                        "group by aca.obrigacao, aca.empresa " +
                       "union all " +
                          "select 4 as status, aca.obrigacao, aca.empresa, max(e.razaosocial) as razaosocial, max(e.cnpj) as cnpj, count(*) as totalobrigacoes " +
                            "from admcontroleadministrativo aca " + strJoinUsuario +
                            "join funcionarios f on f.empresa = aca.empresa and f.funcionario = aca.funcionario  " +
                            "join admobrigacoes ao on ao.obrigacao = aca.obrigacao " +
                            "join empresas e on e.empresa = aca.empresa and e.exercicio = aca.exercicio " +
                           "where coalesce(aca.usuarioencarregado,'') <> '' and not aca.datahoraencarregado is null and aca.vistoencarregado = -1 and extract(day from aca.datavencimento - cast(aca.datahoraencarregado as date)) >= 0  " +
                             "and " + strWhere + " " +
                             "and coalesce(aca.funcionario,'') <> '' " +
                        "group by aca.obrigacao, aca.empresa " +
                       "union all " +
                          "select 5 as status, aca.obrigacao, aca.empresa, max(e.razaosocial) as razaosocial, max(e.cnpj) as cnpj, count(*) as totalobrigacoes " +
                            "from admcontroleadministrativo aca " + strJoinUsuario +
                            "join funcionarios f on f.empresa = aca.empresa and f.funcionario = aca.funcionario  " +
                            "join admobrigacoes ao on ao.obrigacao = aca.obrigacao " +
                            "join empresas e on e.empresa = aca.empresa and e.exercicio = aca.exercicio " +
                           "where coalesce(aca.usuarioencarregado,'') <> '' and not aca.datahoraencarregado is null and aca.vistoencarregado = -1 and extract(day from aca.datavencimento - cast(aca.datahoraencarregado as date)) < 0 " +
                             "and " + strWhere + " " +
                             "and coalesce(aca.funcionario,'') <> '' " +
                        "group by aca.obrigacao, aca.empresa " +
                        "order by 2,1,4"

            strQuery(4) = "select 1 as status, aca.obrigacao, aca.empresa, aca.cnpjcpfinforme, jur.nome, aca.datavencimento, aca.usuariogeracao, aca.datahorageracao, aca.usuarioentrega,  aca.datahoraentrega, aca.usuarioencarregado, aca.datahoraencarregado, case when coalesce(aca.usuariogeracao,'') = '' and coalesce(aca.vistoentrega,0) = 0 and coalesce(aca.vistoencarregado,0) = 0 then 0 else case when coalesce(aca.usuariogeracao,'') <> '' and coalesce(aca.vistoentrega,0) <> 0 and coalesce(aca.vistoencarregado,0) <> 0 then 2 else 1 end end as statusobrigacao, aca.obrigacaoextra, aca.sequenciaextra, aca.parcela  " +
                            "from admcontroleadministrativo aca  " + strJoinUsuario +
                            "join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio  " +
                            "join admobrigacoes ao on ao.obrigacao = aca.obrigacao  " +
                            "join empresas e on e.empresa = aca.empresa and e.exercicio = aca.exercicio  " +
                           "where coalesce(aca.usuarioencarregado,'') = '' and aca.datahoraencarregado is null and aca.vistoencarregado = 0 and extract(day from aca.datavencimento - current_date) = 0  " +
                             "and " + strWhere + " " +
                             "and coalesce(aca.tipopessoainforme,0) = 1 " +
                       "union all  " +
                          "select 2 as status, aca.obrigacao, aca.empresa, aca.cnpjcpfinforme, jur.nome, aca.datavencimento, aca.usuariogeracao, aca.datahorageracao, aca.usuarioentrega,  aca.datahoraentrega, aca.usuarioencarregado, aca.datahoraencarregado, case when coalesce(aca.usuariogeracao,'') = '' and coalesce(aca.vistoentrega,0) = 0 and coalesce(aca.vistoencarregado,0) = 0 then 0 else case when coalesce(aca.usuariogeracao,'') <> '' and coalesce(aca.vistoentrega,0) <> 0 and coalesce(aca.vistoencarregado,0) <> 0 then 2 else 1 end end as statusobrigacao, aca.obrigacaoextra, aca.sequenciaextra, aca.parcela  " +
                            "from admcontroleadministrativo aca  " + strJoinUsuario +
                            "join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio  " +
                            "join admobrigacoes ao on ao.obrigacao = aca.obrigacao  " +
                            "join empresas e on e.empresa = aca.empresa and e.exercicio = aca.exercicio  " +
                           "where coalesce(aca.usuarioencarregado,'') = '' and aca.datahoraencarregado is null and aca.vistoencarregado = 0 and extract(day from aca.datavencimento - current_date) > 0  " +
                             "and " + strWhere + " " +
                             "and coalesce(aca.tipopessoainforme,0) = 1 " +
                       "union all  " +
                          "select 3 as status, aca.obrigacao, aca.empresa, aca.cnpjcpfinforme, jur.nome, aca.datavencimento, aca.usuariogeracao, aca.datahorageracao, aca.usuarioentrega,  aca.datahoraentrega, aca.usuarioencarregado, aca.datahoraencarregado, case when coalesce(aca.usuariogeracao,'') = '' and coalesce(aca.vistoentrega,0) = 0 and coalesce(aca.vistoencarregado,0) = 0 then 0 else case when coalesce(aca.usuariogeracao,'') <> '' and coalesce(aca.vistoentrega,0) <> 0 and coalesce(aca.vistoencarregado,0) <> 0 then 2 else 1 end end as statusobrigacao, aca.obrigacaoextra, aca.sequenciaextra, aca.parcela  " +
                            "from admcontroleadministrativo aca  " + strJoinUsuario +
                            "join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio  " +
                            "join admobrigacoes ao on ao.obrigacao = aca.obrigacao  " +
                            "join empresas e on e.empresa = aca.empresa and e.exercicio = aca.exercicio  " +
                           "where coalesce(aca.usuarioencarregado,'') = '' and aca.datahoraencarregado is null and aca.vistoencarregado = 0 and extract(day from aca.datavencimento - current_date) < 0  " +
                             "and " + strWhere + " " +
                             "and coalesce(aca.tipopessoainforme,0) = 1 " +
                       "union all " +
                          "select 4 as status, aca.obrigacao, aca.empresa, aca.cnpjcpfinforme, jur.nome, aca.datavencimento, aca.usuariogeracao, aca.datahorageracao, aca.usuarioentrega,  aca.datahoraentrega, aca.usuarioencarregado, aca.datahoraencarregado, case when coalesce(aca.usuariogeracao,'') = '' and coalesce(aca.vistoentrega,0) = 0 and coalesce(aca.vistoencarregado,0) = 0 then 0 else case when coalesce(aca.usuariogeracao,'') <> '' and coalesce(aca.vistoentrega,0) <> 0 and coalesce(aca.vistoencarregado,0) <> 0 then 2 else 1 end end as statusobrigacao, aca.obrigacaoextra, aca.sequenciaextra, aca.parcela  " +
                            "from admcontroleadministrativo aca  " + strJoinUsuario +
                            "join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio  " +
                            "join admobrigacoes ao on ao.obrigacao = aca.obrigacao  " +
                            "join empresas e on e.empresa = aca.empresa and e.exercicio = aca.exercicio  " +
                           "where coalesce(aca.usuarioencarregado,'') <> '' and not aca.datahoraencarregado is null and aca.vistoencarregado = -1 and extract(day from aca.datavencimento - cast(aca.datahoraencarregado as date)) >= 0 " +
                             "and " + strWhere + " " +
                             "and coalesce(aca.tipopessoainforme,0) = 1 " +
                       "union all  " +
                          "select 5 as status, aca.obrigacao, aca.empresa, aca.cnpjcpfinforme, jur.nome, aca.datavencimento, aca.usuariogeracao, aca.datahorageracao, aca.usuarioentrega,  aca.datahoraentrega, aca.usuarioencarregado, aca.datahoraencarregado, case when coalesce(aca.usuariogeracao,'') = '' and coalesce(aca.vistoentrega,0) = 0 and coalesce(aca.vistoencarregado,0) = 0 then 0 else case when coalesce(aca.usuariogeracao,'') <> '' and coalesce(aca.vistoentrega,0) <> 0 and coalesce(aca.vistoencarregado,0) <> 0 then 2 else 1 end end as statusobrigacao, aca.obrigacaoextra, aca.sequenciaextra, aca.parcela  " +
                            "from admcontroleadministrativo aca  " + strJoinUsuario +
                            "join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio  " +
                            "join admobrigacoes ao on ao.obrigacao = aca.obrigacao  " +
                            "join empresas e on e.empresa = aca.empresa and e.exercicio = aca.exercicio  " +
                           "where coalesce(aca.usuarioencarregado,'') <> '' and not aca.datahoraencarregado is null and aca.vistoencarregado = -1 and extract(day from aca.datavencimento - cast(aca.datahoraencarregado as date)) < 0  " +
                             "and " + strWhere + " " +
                             "and coalesce(aca.tipopessoainforme,0) = 1 " +
                       "union all "
            strQuery(4) += "select 1 as status, aca.obrigacao, aca.empresa, aca.cnpjcpfinforme, fis.nome, aca.datavencimento, aca.usuariogeracao, aca.datahorageracao, aca.usuarioentrega,  aca.datahoraentrega, aca.usuarioencarregado, aca.datahoraencarregado, case when coalesce(aca.usuariogeracao,'') = '' and coalesce(aca.vistoentrega,0) = 0 and coalesce(aca.vistoencarregado,0) = 0 then 0 else case when coalesce(aca.usuariogeracao,'') <> '' and coalesce(aca.vistoentrega,0) <> 0 and coalesce(aca.vistoencarregado,0) <> 0 then 2 else 1 end end as statusobrigacao, aca.obrigacaoextra, aca.sequenciaextra, aca.parcela  " +
                             "from admcontroleadministrativo aca  " + strJoinUsuario +
                             "join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio  " +
                             "join admobrigacoes ao on ao.obrigacao = aca.obrigacao  " +
                             "join empresas e on e.empresa = aca.empresa and e.exercicio = aca.exercicio  " +
                            "where coalesce(aca.usuarioencarregado,'') = '' and aca.datahoraencarregado is null and aca.vistoencarregado = 0 and extract(day from aca.datavencimento - current_date) = 0  " +
                              "and " + strWhere + " " +
                              "and coalesce(aca.tipopessoainforme,0) = 2 " +
                        "union all " +
                           "select 2 as status, aca.obrigacao, aca.empresa, aca.cnpjcpfinforme, fis.nome, aca.datavencimento, aca.usuariogeracao, aca.datahorageracao, aca.usuarioentrega,  aca.datahoraentrega, aca.usuarioencarregado, aca.datahoraencarregado, case when coalesce(aca.usuariogeracao,'') = '' and coalesce(aca.vistoentrega,0) = 0 and coalesce(aca.vistoencarregado,0) = 0 then 0 else case when coalesce(aca.usuariogeracao,'') <> '' and coalesce(aca.vistoentrega,0) <> 0 and coalesce(aca.vistoencarregado,0) <> 0 then 2 else 1 end end as statusobrigacao, aca.obrigacaoextra, aca.sequenciaextra, aca.parcela  " +
                             "from admcontroleadministrativo aca  " + strJoinUsuario +
                             "join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio  " +
                             "join admobrigacoes ao on ao.obrigacao = aca.obrigacao  " +
                             "join empresas e on e.empresa = aca.empresa and e.exercicio = aca.exercicio  " +
                            "where coalesce(aca.usuarioencarregado,'') = '' and aca.datahoraencarregado is null and aca.vistoencarregado = 0 and extract(day from aca.datavencimento - current_date) > 0  " +
                              "and " + strWhere + " " +
                              "and coalesce(aca.tipopessoainforme,0) = 2 " +
                        "union all " +
                           "select 3 as status, aca.obrigacao, aca.empresa, aca.cnpjcpfinforme, fis.nome, aca.datavencimento, aca.usuariogeracao, aca.datahorageracao, aca.usuarioentrega,  aca.datahoraentrega, aca.usuarioencarregado, aca.datahoraencarregado, case when coalesce(aca.usuariogeracao,'') = '' and coalesce(aca.vistoentrega,0) = 0 and coalesce(aca.vistoencarregado,0) = 0 then 0 else case when coalesce(aca.usuariogeracao,'') <> '' and coalesce(aca.vistoentrega,0) <> 0 and coalesce(aca.vistoencarregado,0) <> 0 then 2 else 1 end end as statusobrigacao, aca.obrigacaoextra, aca.sequenciaextra, aca.parcela  " +
                             "from admcontroleadministrativo aca  " + strJoinUsuario +
                             "join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio  " +
                             "join admobrigacoes ao on ao.obrigacao = aca.obrigacao  " +
                             "join empresas e on e.empresa = aca.empresa and e.exercicio = aca.exercicio  " +
                            "where coalesce(aca.usuarioencarregado,'') = '' and aca.datahoraencarregado is null and aca.vistoencarregado = 0 and extract(day from aca.datavencimento - current_date) < 0  " +
                              "and " + strWhere + " " +
                              "and coalesce(aca.tipopessoainforme,0) = 2 " +
                        "union all " +
                           "select 4 as status, aca.obrigacao, aca.empresa, aca.cnpjcpfinforme, fis.nome, aca.datavencimento, aca.usuariogeracao, aca.datahorageracao, aca.usuarioentrega,  aca.datahoraentrega, aca.usuarioencarregado, aca.datahoraencarregado, case when coalesce(aca.usuariogeracao,'') = '' and coalesce(aca.vistoentrega,0) = 0 and coalesce(aca.vistoencarregado,0) = 0 then 0 else case when coalesce(aca.usuariogeracao,'') <> '' and coalesce(aca.vistoentrega,0) <> 0 and coalesce(aca.vistoencarregado,0) <> 0 then 2 else 1 end end as statusobrigacao, aca.obrigacaoextra, aca.sequenciaextra, aca.parcela  " +
                             "from admcontroleadministrativo aca  " + strJoinUsuario +
                             "join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio  " +
                             "join admobrigacoes ao on ao.obrigacao = aca.obrigacao  " +
                             "join empresas e on e.empresa = aca.empresa and e.exercicio = aca.exercicio  " +
                            "where coalesce(aca.usuarioencarregado,'') <> '' and not aca.datahoraencarregado is null and aca.vistoencarregado = -1 and extract(day from aca.datavencimento - cast(aca.datahoraencarregado as date)) >= 0   " +
                              "and " + strWhere + " " +
                              "and coalesce(aca.tipopessoainforme,0) = 2 " +
                        "union all " +
                           "select 5 as status, aca.obrigacao, aca.empresa, aca.cnpjcpfinforme, fis.nome, aca.datavencimento, aca.usuariogeracao, aca.datahorageracao, aca.usuarioentrega,  aca.datahoraentrega, aca.usuarioencarregado, aca.datahoraencarregado, case when coalesce(aca.usuariogeracao,'') = '' and coalesce(aca.vistoentrega,0) = 0 and coalesce(aca.vistoencarregado,0) = 0 then 0 else case when coalesce(aca.usuariogeracao,'') <> '' and coalesce(aca.vistoentrega,0) <> 0 and coalesce(aca.vistoencarregado,0) <> 0 then 2 else 1 end end as statusobrigacao, aca.obrigacaoextra, aca.sequenciaextra, aca.parcela  " +
                             "from admcontroleadministrativo aca  " + strJoinUsuario +
                             "join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio  " +
                             "join admobrigacoes ao on ao.obrigacao = aca.obrigacao  " +
                             "join empresas e on e.empresa = aca.empresa and e.exercicio = aca.exercicio  " +
                            "where coalesce(aca.usuarioencarregado,'') <> '' and not aca.datahoraencarregado is null and aca.vistoencarregado = -1 and extract(day from aca.datavencimento - cast(aca.datahoraencarregado as date)) < 0  " +
                              "and " + strWhere + " " +
                              "and coalesce(aca.tipopessoainforme,0) = 2 " +
                         "order by 2,1,3,4 "

            strQuery(5) = "select 1 as status, aca.obrigacao, aca.empresa, aca.funcionario as funcionario, f.nome as nome, aca.datavencimento, aca.usuariogeracao, aca.datahorageracao, aca.usuarioentrega,  aca.datahoraentrega, aca.usuarioencarregado, aca.datahoraencarregado, case when coalesce(aca.usuariogeracao,'') = '' and coalesce(aca.vistoentrega,0) = 0 and coalesce(aca.vistoencarregado,0) = 0 then 0 else case when coalesce(aca.usuariogeracao,'') <> '' and coalesce(aca.vistoentrega,0) <> 0 and coalesce(aca.vistoencarregado,0) <> 0 then 2 else 1 end end as statusobrigacao, aca.obrigacaoextra, aca.sequenciaextra, aca.parcela  " +
                            "from admcontroleadministrativo aca " + strJoinUsuario +
                            "join funcionarios f on f.empresa = aca.empresa and f.funcionario = aca.funcionario  " +
                            "join admobrigacoes ao on ao.obrigacao = aca.obrigacao  " +
                            "join empresas e on e.empresa = aca.empresa and e.exercicio = aca.exercicio  " +
                           "where coalesce(aca.usuarioencarregado,'') = '' and aca.datahoraencarregado is null and aca.vistoencarregado = 0 and extract(day from aca.datavencimento - current_date) = 0  " +
                             "and " + strWhere + "   " +
                             "and coalesce(aca.funcionario,'') <> '' " +
                       "union all  " +
                          "select 2 as status, aca.obrigacao, aca.empresa, aca.funcionario as funcionario, f.nome as nome, aca.datavencimento, aca.usuariogeracao, aca.datahorageracao, aca.usuarioentrega,  aca.datahoraentrega, aca.usuarioencarregado, aca.datahoraencarregado, case when coalesce(aca.usuariogeracao,'') = '' and coalesce(aca.vistoentrega,0) = 0 and coalesce(aca.vistoencarregado,0) = 0 then 0 else case when coalesce(aca.usuariogeracao,'') <> '' and coalesce(aca.vistoentrega,0) <> 0 and coalesce(aca.vistoencarregado,0) <> 0 then 2 else 1 end end as statusobrigacao, aca.obrigacaoextra, aca.sequenciaextra, aca.parcela  " +
                            "from admcontroleadministrativo aca  " + strJoinUsuario +
                            "join funcionarios f on f.empresa = aca.empresa and f.funcionario = aca.funcionario  " +
                            "join admobrigacoes ao on ao.obrigacao = aca.obrigacao  " +
                            "join empresas e on e.empresa = aca.empresa and e.exercicio = aca.exercicio  " +
                           "where coalesce(aca.usuarioencarregado,'') = '' and aca.datahoraencarregado is null and aca.vistoencarregado = 0 and extract(day from aca.datavencimento - current_date) > 0  " +
                             "and " + strWhere + "  " +
                             "and coalesce(aca.funcionario,'') <> '' " +
                       "union all  " +
                          "select 3 as status, aca.obrigacao, aca.empresa, aca.funcionario as funcionario, f.nome as nome, aca.datavencimento, aca.usuariogeracao, aca.datahorageracao, aca.usuarioentrega,  aca.datahoraentrega, aca.usuarioencarregado, aca.datahoraencarregado, case when coalesce(aca.usuariogeracao,'') = '' and coalesce(aca.vistoentrega,0) = 0 and coalesce(aca.vistoencarregado,0) = 0 then 0 else case when coalesce(aca.usuariogeracao,'') <> '' and coalesce(aca.vistoentrega,0) <> 0 and coalesce(aca.vistoencarregado,0) <> 0 then 2 else 1 end end as statusobrigacao, aca.obrigacaoextra, aca.sequenciaextra, aca.parcela  " +
                            "from admcontroleadministrativo aca  " + strJoinUsuario +
                            "join funcionarios f on f.empresa = aca.empresa and f.funcionario = aca.funcionario  " +
                            "join admobrigacoes ao on ao.obrigacao = aca.obrigacao  " +
                            "join empresas e on e.empresa = aca.empresa and e.exercicio = aca.exercicio  " +
                           "where coalesce(aca.usuarioencarregado,'') = '' and aca.datahoraencarregado is null and aca.vistoencarregado = 0 and extract(day from aca.datavencimento - current_date) < 0  " +
                             "and " + strWhere + "  " +
                             "and coalesce(aca.funcionario,'') <> '' " +
                      "union all  " +
                          "select 4 as status, aca.obrigacao, aca.empresa, aca.funcionario as funcionario, f.nome as nome, aca.datavencimento, aca.usuariogeracao, aca.datahorageracao, aca.usuarioentrega,  aca.datahoraentrega, aca.usuarioencarregado, aca.datahoraencarregado, case when coalesce(aca.usuariogeracao,'') = '' and coalesce(aca.vistoentrega,0) = 0 and coalesce(aca.vistoencarregado,0) = 0 then 0 else case when coalesce(aca.usuariogeracao,'') <> '' and coalesce(aca.vistoentrega,0) <> 0 and coalesce(aca.vistoencarregado,0) <> 0 then 2 else 1 end end as statusobrigacao, aca.obrigacaoextra, aca.sequenciaextra, aca.parcela  " +
                            "from admcontroleadministrativo aca  " + strJoinUsuario +
                            "join funcionarios f on f.empresa = aca.empresa and f.funcionario = aca.funcionario  " +
                            "join admobrigacoes ao on ao.obrigacao = aca.obrigacao  " +
                            "join empresas e on e.empresa = aca.empresa and e.exercicio = aca.exercicio  " +
                           "where coalesce(aca.usuarioencarregado,'') <> '' and not aca.datahoraencarregado is null and aca.vistoencarregado = -1 and extract(day from aca.datavencimento - cast(aca.datahoraencarregado as date)) >= 0   " +
                             "and " + strWhere + " " +
                             "and coalesce(aca.funcionario,'') <> '' " +
                       "union all  " +
                          "select 5 as status, aca.obrigacao, aca.empresa, aca.funcionario as funcionario, f.nome as nome, aca.datavencimento, aca.usuariogeracao, aca.datahorageracao, aca.usuarioentrega,  aca.datahoraentrega, aca.usuarioencarregado, aca.datahoraencarregado, case when coalesce(aca.usuariogeracao,'') = '' and coalesce(aca.vistoentrega,0) = 0 and coalesce(aca.vistoencarregado,0) = 0 then 0 else case when coalesce(aca.usuariogeracao,'') <> '' and coalesce(aca.vistoentrega,0) <> 0 and coalesce(aca.vistoencarregado,0) <> 0 then 2 else 1 end end as statusobrigacao, aca.obrigacaoextra, aca.sequenciaextra, aca.parcela  " +
                            "from admcontroleadministrativo aca  " + strJoinUsuario +
                            "join funcionarios f on f.empresa = aca.empresa and f.funcionario = aca.funcionario  " +
                            "join admobrigacoes ao on ao.obrigacao = aca.obrigacao  " +
                            "join empresas e on e.empresa = aca.empresa and e.exercicio = aca.exercicio  " +
                           "where coalesce(aca.usuarioencarregado,'') <> '' and not aca.datahoraencarregado is null and aca.vistoencarregado = -1 and extract(day from aca.datavencimento - cast(aca.datahoraencarregado as date)) < 0  " +
                             "and " + strWhere + " " +
                             "and coalesce(aca.funcionario,'') <> '' " +
                        "order by 2,1,3,4 "

            objMonitoramentoVencimento.Grid(strQuery, monitoramentoGridControl, monitoramentoGridView, obrigacoesGridView, empresasGridView, empresadetalheGridView, informeGridView, funcionarioGridView, statusImageCollection, statusempresaImageCollection)
            SplashScreenManager.CloseForm()
        Catch ex As Exception
            SplashScreenManager.CloseForm()
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CarregaGrafico()
        Try
            SplashScreenManager.ShowForm(Me, GetType(aguardeWaitForm), True, True, False)
            Dim strJoinUsuario As String = String.Empty
            Dim strWhere As String = objFiltro.RetornaWhereFiltro("aca")
            If usuarioInfo.obrigacoes Then
                strJoinUsuario = "join admobrigacoesusuarios aou on aou.obrigacao = aca.obrigacao and aou.usuario = '" + usuarioInfo.usuario + "' "
            End If

            objMonitoramentoVencimento.Grafico(
                          "select case when sum(aca.quantidade) > 0 then 1 else 0 end as status, sum(aca.quantidade) as quantidade " +
                            "from (" +
                                   "select count(*) as quantidade " +
                                     "from admcontroleadministrativo aca " + strJoinUsuario +
                                    "where coalesce(aca.usuarioencarregado,'') = '' and aca.datahoraencarregado is null and aca.vistoencarregado = 0 and extract(day from aca.datavencimento - current_date) = 0 " +
                                      "and coalesce(aca.tipopessoainforme,0) = 0 " +
                                      "and " + strWhere + " " +
                                   "having count(*) > 0 " +
                                "union all " +
                                   "select count(*) as quantidade " +
                                     "from admcontroleadministrativo aca " + strJoinUsuario +
                                     "join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio " +
                                    "where coalesce(aca.usuarioencarregado,'') = '' and aca.datahoraencarregado is null and aca.vistoencarregado = 0 and extract(day from aca.datavencimento - current_date) = 0 " +
                                      "and " + strWhere + " " +
                                   "having count(*) > 0 " +
                                "union all " +
                                   "select count(*) as quantidade " +
                                     "from admcontroleadministrativo aca " + strJoinUsuario +
                                     "join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio " +
                                    "where coalesce(aca.usuarioencarregado,'') = '' and aca.datahoraencarregado is null and aca.vistoencarregado = 0 and extract(day from aca.datavencimento - current_date) = 0 " +
                                      "and " + strWhere + " " +
                                   "having count(*) > 0 " +
                                  ") aca " +
                          "having coalesce(sum(aca.quantidade),0) > 0 " +
                       "union all " +
                          "select case when sum(aca.quantidade) > 0 then 2 else 0 end as status, sum(aca.quantidade) as quantidade " +
                            "from (" +
                                   "select count(*) as quantidade " +
                                     "from admcontroleadministrativo aca " + strJoinUsuario +
                                    "where coalesce(aca.usuarioencarregado,'') = '' and aca.datahoraencarregado is null and aca.vistoencarregado = 0 and extract(day from aca.datavencimento - current_date) > 0 " +
                                      "and coalesce(aca.tipopessoainforme,0) = 0 " +
                                      "and " + strWhere + " " +
                                   "having count(*) > 0 " +
                                "union all " +
                                   "select count(*) as quantidade " +
                                     "from admcontroleadministrativo aca " + strJoinUsuario +
                                     "join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio " +
                                    "where coalesce(aca.usuarioencarregado,'') = '' and aca.datahoraencarregado is null and aca.vistoencarregado = 0 and extract(day from aca.datavencimento - current_date) > 0 " +
                                      "and " + strWhere + " " +
                                   "having count(*) > 0 " +
                                "union all " +
                                   "select count(*) as quantidade " +
                                     "from admcontroleadministrativo aca " + strJoinUsuario +
                                     "join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio " +
                                    "where coalesce(aca.usuarioencarregado,'') = '' and aca.datahoraencarregado is null and aca.vistoencarregado = 0 and extract(day from aca.datavencimento - current_date) > 0 " +
                                      "and " + strWhere + " " +
                                   "having count(*) > 0 " +
                                  ") aca " +
                          "having coalesce(sum(aca.quantidade),0) > 0 " +
                       "union all " +
                          "select case when sum(aca.quantidade) > 0 then 3 else 0 end as status, sum(aca.quantidade) as quantidade " +
                            "from (" +
                                   "select count(*) as quantidade " +
                                     "from admcontroleadministrativo aca " + strJoinUsuario +
                                    "where coalesce(aca.usuarioencarregado,'') = '' and aca.datahoraencarregado is null and aca.vistoencarregado = 0 and extract(day from aca.datavencimento - current_date) < 0 " +
                                      "and coalesce(aca.tipopessoainforme,0) = 0 " +
                                      "and " + strWhere + " " +
                                   "having count(*) > 0 " +
                                "union all " +
                                   "select count(*) as quantidade " +
                                     "from admcontroleadministrativo aca " + strJoinUsuario +
                                     "join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio " +
                                    "where coalesce(aca.usuarioencarregado,'') = '' and aca.datahoraencarregado is null and aca.vistoencarregado = 0 and extract(day from aca.datavencimento - current_date) < 0 " +
                                      "and " + strWhere + " " +
                                   "having count(*) > 0 " +
                                "union all " +
                                   "select count(*) as quantidade " +
                                     "from admcontroleadministrativo aca " + strJoinUsuario +
                                     "join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio " +
                                    "where coalesce(aca.usuarioencarregado,'') = '' and aca.datahoraencarregado is null and aca.vistoencarregado = 0 and extract(day from aca.datavencimento - current_date) < 0 " +
                                      "and " + strWhere + " " +
                                   "having count(*) > 0 " +
                                  ") aca " +
                          "having coalesce(sum(aca.quantidade),0) > 0 " +
                       "union all " +
                          "select case when sum(aca.quantidade) > 0 then 4 else 0 end as status, sum(aca.quantidade) as quantidade " +
                            "from (" +
                                   "select count(*) as quantidade " +
                                     "from admcontroleadministrativo aca " + strJoinUsuario +
                                    "where coalesce(aca.usuarioencarregado,'') <> '' and not aca.datahoraencarregado is null and aca.vistoencarregado = -1 and extract(day from aca.datavencimento - cast(aca.datahoraencarregado as date)) >= 0 " +
                                      "and coalesce(aca.tipopessoainforme,0) = 0 " +
                                      "and " + strWhere + " " +
                                   "having count(*) > 0 " +
                                "union all " +
                                   "select count(*) as quantidade " +
                                     "from admcontroleadministrativo aca " + strJoinUsuario +
                                     "join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio " +
                                    "where coalesce(aca.usuarioencarregado,'') <> '' and not aca.datahoraencarregado is null and aca.vistoencarregado = -1 and extract(day from aca.datavencimento - cast(aca.datahoraencarregado as date)) >= 0 " +
                                      "and " + strWhere + " " +
                                   "having count(*) > 0 " +
                                "union all " +
                                   "select count(*) as quantidade " +
                                     "from admcontroleadministrativo aca " + strJoinUsuario +
                                     "join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio " +
                                    "where coalesce(aca.usuarioencarregado,'') <> '' and not aca.datahoraencarregado is null and aca.vistoencarregado = -1 and extract(day from aca.datavencimento - cast(aca.datahoraencarregado as date)) >= 0 " +
                                      "and " + strWhere + " " +
                                   "having count(*) > 0 " +
                                  ") aca " +
                          "having coalesce(sum(aca.quantidade),0) > 0 " +
                       "union all " +
                          "select case when sum(aca.quantidade) > 0 then 5 else 0 end as status, sum(aca.quantidade) as quantidade " +
                            "from (" +
                                   "select count(*) as quantidade " +
                                     "from admcontroleadministrativo aca " + strJoinUsuario +
                                    "where coalesce(aca.usuarioencarregado,'') <> '' and not aca.datahoraencarregado is null and aca.vistoencarregado = -1 and extract(day from aca.datavencimento - cast(aca.datahoraencarregado as date)) < 0 " +
                                      "and coalesce(aca.tipopessoainforme,0) = 0 " +
                                      "and " + strWhere + " " +
                                   "having count(*) > 0 " +
                                "union all " +
                                   "select count(*) as quantidade " +
                                     "from admcontroleadministrativo aca " + strJoinUsuario +
                                     "join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio " +
                                    "where coalesce(aca.usuarioencarregado,'') <> '' and not aca.datahoraencarregado is null and aca.vistoencarregado = -1 and extract(day from aca.datavencimento - cast(aca.datahoraencarregado as date)) < 0 " +
                                      "and " + strWhere + " " +
                                   "having count(*) > 0 " +
                                "union all " +
                                   "select count(*) as quantidade " +
                                     "from admcontroleadministrativo aca " + strJoinUsuario +
                                     "join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio " +
                                    "where coalesce(aca.usuarioencarregado,'') <> '' and not aca.datahoraencarregado is null and aca.vistoencarregado = -1 and extract(day from aca.datavencimento - cast(aca.datahoraencarregado as date)) < 0 " +
                                      "and " + strWhere + " " +
                                   "having count(*) > 0 " +
                                  ") aca " +
                          "having coalesce(sum(aca.quantidade),0) > 0 " +
                        "order by 1", monitoramentoChartControl)
            SplashScreenManager.CloseForm()
        Catch ex As Exception
            SplashScreenManager.CloseForm()
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AtivaNavegador(pblnAtivaNavegacao As Boolean)
        navegadorPanelControl.Visible = pblnAtivaNavegacao
        If pblnAtivaNavegacao Then
            monitoramentoGridControl.Size = New System.Drawing.Size(1361, 404)
        Else
            monitoramentoGridControl.Size = New System.Drawing.Size(1361, 435)
        End If
    End Sub
End Class