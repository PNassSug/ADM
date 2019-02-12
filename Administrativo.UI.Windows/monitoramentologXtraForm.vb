Imports Administrativo.Modelo
Imports Administrativo.BLL
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base

Public Class monitoramentologXtraForm

    Dim objMonitoramentoLog As New MonitoramentoLogBLL
    Dim objDataBase As New DataBaseBLL
    Dim objFiltro As New FiltroBLL
    Dim blnCarregaDados As Boolean = False
    Dim blnClosing As Boolean = False
    Dim strObrigacao As String
    Dim strInforme As String
    Dim strFuncionario As String

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub monitoramentologXtraForm_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        blnClosing = True
        Me.Dispose()
    End Sub

    Private Sub monitoramentologXtraForm_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            If e.KeyCode = Keys.F5 Then
                If atualizarBarButtonItem.Enabled Then
                    CarregaGrid()
                End If
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub monitoramentologXtraForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Try
            CarregaGrid()
            objFiltro.IconeOpcaoFiltro(filtroBarButtonItem)
            AtivaNavegador(False)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub monitoramentologGridView_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles monitoramentologGridView.CustomColumnDisplayText
        Dim strValor As String = String.Empty

        If e.Column.FieldName = "cnpj" Then
            If monitoramentologGridView.GetRowCellValue(e.ListSourceRowIndex, "cnpj") IsNot Nothing Then
                strValor = monitoramentologGridView.GetRowCellValue(e.ListSourceRowIndex, "cnpj").ToString()
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

    Private Sub monitoramentologinformeGridView_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles monitoramentologinformeGridView.CustomColumnDisplayText
        Dim strValor As String = String.Empty

        If e.Column.FieldName = "cnpjcpfinforme" Then
            If monitoramentologGridView.GetRowCellValue(e.ListSourceRowIndex, "cnpjcpfinforme") IsNot Nothing Then
                strValor = monitoramentologGridView.GetRowCellValue(e.ListSourceRowIndex, "cnpjcpfinforme").ToString()
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

    Private Sub localizarBarCheckItem_CheckedChanged(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles localizarBarCheckItem.CheckedChanged
        Try
            monitoramentologGridView.OptionsFind.AlwaysVisible = localizarBarCheckItem.Checked
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub atualizarBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles atualizarBarButtonItem.ItemClick
        CarregaGrid()
    End Sub

    Private Sub filtroBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles filtroBarButtonItem.ItemClick
        Dim form As filtroXtraForm = New filtroXtraForm()
        form.ShowDialog(Me)
        objFiltro.IconeOpcaoFiltro(filtroBarButtonItem)
        CarregaGrid()
    End Sub

    Private Sub monitoramentologGridControl_FocusedViewChanged(sender As System.Object, e As DevExpress.XtraGrid.ViewFocusEventArgs) Handles monitoramentologGridControl.FocusedViewChanged
        Dim strNavegacao As String = String.Empty
        Dim intLinhaGroupMaster As Int32
        If blnClosing Then
            Exit Sub
        End If
        intLinhaGroupMaster = (CType(monitoramentologGridControl.MainView, ColumnView)).FocusedRowHandle

        If monitoramentologGridView.GetMasterRowExpanded(intLinhaGroupMaster) Then
            Dim detailView As GridView = TryCast(monitoramentologGridControl.FocusedView, GridView)
            Dim gvEmpresa As GridView = TryCast(monitoramentologGridControl.Views(0), GridView)
            Dim gvObrigacao As GridView
            Dim gvFuncionario As GridView
            Dim gvInforme As GridView
            Dim intCountAux As Int32 = 0

            Dim intLinha As Int32() = detailView.GetSelectedRows()
            Dim intEmpresa As Int32() = gvEmpresa.GetSelectedRows()
            Dim intObrigacao As Int32()
            Dim intFuncionario As Int32()
            Dim intInforme As Int32()
            For i As Integer = 0 To intLinha.Length - 1
                If (monitoramentologGridControl.FocusedView.LevelName().ToString = "monitoramentoObrigacao") Then
                    strNavegacao = "Empresa: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("empresa")).ToString.Substring(0, 2) + "." +
                                                 detailView.GetRowCellValue(intLinha(i), detailView.Columns("empresa")).ToString.Substring(2, 4) + " - " +
                                                 gvEmpresa.GetRowCellValue(intEmpresa(intEmpresa.Length - 1), gvEmpresa.Columns("razaosocial")).ToString
                    strNavegacao += " | Competência: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("competencia")).ToString.Substring(0, 2) + "/" +
                                                         detailView.GetRowCellValue(intLinha(i), detailView.Columns("competencia")).ToString.Substring(2, 4)
                ElseIf (monitoramentologGridControl.FocusedView.LevelName().ToString = "LogEmpresa") Then
                    strNavegacao = "Empresa: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("empresa")).ToString.Substring(0, 2) + "." +
                                                 detailView.GetRowCellValue(intLinha(i), detailView.Columns("empresa")).ToString.Substring(2, 4) + " - " +
                                                 gvEmpresa.GetRowCellValue(intEmpresa(intEmpresa.Length - 1), gvEmpresa.Columns("razaosocial")).ToString
                    strNavegacao += " | Competência: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("competencia")).ToString.Substring(0, 2) + "/" +
                                                         detailView.GetRowCellValue(intLinha(i), detailView.Columns("competencia")).ToString.Substring(2, 4)
                    While ("monitoramentoObrigacao" <> monitoramentologGridControl.Views(intCountAux).LevelName.ToString)
                        intCountAux += 1
                    End While
                    gvObrigacao = TryCast(monitoramentologGridControl.Views(intCountAux), GridView)
                    intObrigacao = gvObrigacao.GetSelectedRows()
                    strObrigacao = gvObrigacao.GetRowCellValue(intObrigacao(intObrigacao.Length - 1), gvObrigacao.Columns("descricao")).ToString()
                    strNavegacao += " | Obrigação: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("obrigacao")).ToString.Substring(0, 1) + "-" +
                                                       detailView.GetRowCellValue(intLinha(i), detailView.Columns("obrigacao")).ToString.Substring(1, 5) + " - " +
                                                       strObrigacao

                ElseIf (monitoramentologGridControl.FocusedView.LevelName().ToString = "PortalEmpresa") Then
                    strNavegacao = "Empresa: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("empresa")).ToString.Substring(0, 2) + "." +
                                                 detailView.GetRowCellValue(intLinha(i), detailView.Columns("empresa")).ToString.Substring(2, 4) + " - " +
                                                 gvEmpresa.GetRowCellValue(intEmpresa(intEmpresa.Length - 1), gvEmpresa.Columns("razaosocial")).ToString
                    strNavegacao += " | Competência: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("competencia")).ToString.Substring(0, 2) + "/" +
                                                         detailView.GetRowCellValue(intLinha(i), detailView.Columns("competencia")).ToString.Substring(2, 4)
                    While ("monitoramentoObrigacao" <> monitoramentologGridControl.Views(intCountAux).LevelName.ToString)
                        intCountAux += 1
                    End While
                    gvObrigacao = TryCast(monitoramentologGridControl.Views(intCountAux), GridView)
                    intObrigacao = gvObrigacao.GetSelectedRows()
                    strNavegacao += " | Obrigação: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("obrigacao")).ToString.Substring(0, 1) + "-" +
                                                       detailView.GetRowCellValue(intLinha(i), detailView.Columns("obrigacao")).ToString.Substring(1, 5) + " - " +
                                                       strObrigacao

                ElseIf (monitoramentologGridControl.FocusedView.LevelName().ToString = "LogPortalEmpresa") Then
                    strNavegacao = "Empresa: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("empresa")).ToString.Substring(0, 2) + "." +
                                                 detailView.GetRowCellValue(intLinha(i), detailView.Columns("empresa")).ToString.Substring(2, 4) + " - " +
                                                 gvEmpresa.GetRowCellValue(intEmpresa(intEmpresa.Length - 1), gvEmpresa.Columns("razaosocial")).ToString
                    strNavegacao += " | Competência: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("competencia")).ToString.Substring(0, 2) + "/" +
                                                         detailView.GetRowCellValue(intLinha(i), detailView.Columns("competencia")).ToString.Substring(2, 4)
                    strNavegacao += " | Obrigação: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("obrigacao")).ToString.Substring(0, 1) + "-" +
                                                       detailView.GetRowCellValue(intLinha(i), detailView.Columns("obrigacao")).ToString.Substring(1, 5) + " - " +
                                                       strObrigacao

                ElseIf (monitoramentologGridControl.FocusedView.LevelName().ToString = "monitoramentoFuncionario") Then
                    strNavegacao = "Empresa: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("empresa")).ToString.Substring(0, 2) + "." +
                                                 detailView.GetRowCellValue(intLinha(i), detailView.Columns("empresa")).ToString.Substring(2, 4) + " - " +
                                                 gvEmpresa.GetRowCellValue(intEmpresa(intEmpresa.Length - 1), gvEmpresa.Columns("razaosocial")).ToString
                    strNavegacao += " | Competência: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("competencia")).ToString.Substring(0, 2) + "/" +
                                                         detailView.GetRowCellValue(intLinha(i), detailView.Columns("competencia")).ToString.Substring(2, 4)

                ElseIf (monitoramentologGridControl.FocusedView.LevelName().ToString = "DetalheFuncionario") Then
                    strNavegacao = "Empresa: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("empresa")).ToString.Substring(0, 2) + "." +
                                                 detailView.GetRowCellValue(intLinha(i), detailView.Columns("empresa")).ToString.Substring(2, 4) + " - " +
                                                 gvEmpresa.GetRowCellValue(intEmpresa(intEmpresa.Length - 1), gvEmpresa.Columns("razaosocial")).ToString
                    strNavegacao += " | Competência: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("competencia")).ToString.Substring(0, 2) + "/" +
                                                         detailView.GetRowCellValue(intLinha(i), detailView.Columns("competencia")).ToString.Substring(2, 4)
                    While ("monitoramentoFuncionario" <> monitoramentologGridControl.Views(intCountAux).LevelName.ToString)
                        intCountAux += 1
                    End While
                    gvFuncionario = TryCast(monitoramentologGridControl.Views(intCountAux), GridView)
                    intFuncionario = gvFuncionario.GetSelectedRows()
                    strFuncionario = gvFuncionario.GetRowCellValue(intFuncionario(intFuncionario.Length - 1), gvFuncionario.Columns("nome")).ToString
                    strNavegacao += " | Funcionário: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("funcionario")).ToString.Substring(0, 2) + "." +
                                                         detailView.GetRowCellValue(intLinha(i), detailView.Columns("funcionario")).ToString.Substring(2, 4) + " - " +
                                                         strFuncionario


                ElseIf (monitoramentologGridControl.FocusedView.LevelName().ToString = "LogFuncionario") Then
                    strNavegacao = "Empresa: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("empresa")).ToString.Substring(0, 2) + "." +
                                                 detailView.GetRowCellValue(intLinha(i), detailView.Columns("empresa")).ToString.Substring(2, 4) + " - " +
                                                 gvEmpresa.GetRowCellValue(intEmpresa(intEmpresa.Length - 1), gvEmpresa.Columns("razaosocial")).ToString
                    strNavegacao += " | Competência: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("competencia")).ToString.Substring(0, 2) + "/" +
                                                         detailView.GetRowCellValue(intLinha(i), detailView.Columns("competencia")).ToString.Substring(2, 4)
                    strNavegacao += " | Funcionário: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("funcionario")).ToString.Substring(0, 2) + "." +
                                                         detailView.GetRowCellValue(intLinha(i), detailView.Columns("funcionario")).ToString.Substring(2, 4) + " - " +
                                                         strFuncionario
                    While ("DetalheFuncionario" <> monitoramentologGridControl.Views(intCountAux).LevelName.ToString)
                        intCountAux += 1
                    End While
                    gvObrigacao = TryCast(monitoramentologGridControl.Views(intCountAux), GridView)
                    intObrigacao = gvObrigacao.GetSelectedRows()
                    strObrigacao = gvObrigacao.GetRowCellValue(intObrigacao(intObrigacao.Length - 1), gvObrigacao.Columns("descricao")).ToString()
                    strNavegacao += " | Obrigação: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("obrigacao")).ToString.Substring(0, 1) + "-" +
                                                       detailView.GetRowCellValue(intLinha(i), detailView.Columns("obrigacao")).ToString.Substring(1, 5) + " - " +
                                                       strObrigacao

                ElseIf (monitoramentologGridControl.FocusedView.LevelName().ToString = "PortalFuncionario") Then
                    strNavegacao = "Empresa: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("empresa")).ToString.Substring(0, 2) + "." +
                                                 detailView.GetRowCellValue(intLinha(i), detailView.Columns("empresa")).ToString.Substring(2, 4) + " - " +
                                                 gvEmpresa.GetRowCellValue(intEmpresa(intEmpresa.Length - 1), gvEmpresa.Columns("razaosocial")).ToString
                    strNavegacao += " | Competência: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("competencia")).ToString.Substring(0, 2) + "/" +
                                                         detailView.GetRowCellValue(intLinha(i), detailView.Columns("competencia")).ToString.Substring(2, 4)
                    strNavegacao += " | Funcionário: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("funcionario")).ToString.Substring(0, 2) + "." +
                                                         detailView.GetRowCellValue(intLinha(i), detailView.Columns("funcionario")).ToString.Substring(2, 4) + " - " +
                                                         strFuncionario
                    While ("DetalheFuncionario" <> monitoramentologGridControl.Views(intCountAux).LevelName.ToString)
                        intCountAux += 1
                    End While
                    gvObrigacao = TryCast(monitoramentologGridControl.Views(intCountAux), GridView)
                    intObrigacao = gvObrigacao.GetSelectedRows()
                    strNavegacao += " | Obrigação: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("obrigacao")).ToString.Substring(0, 1) + "-" +
                                                       detailView.GetRowCellValue(intLinha(i), detailView.Columns("obrigacao")).ToString.Substring(1, 5) + " - " +
                                                       strObrigacao

                ElseIf (monitoramentologGridControl.FocusedView.LevelName().ToString = "LogPortalFuncionario") Then
                    strNavegacao = "Empresa: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("empresa")).ToString.Substring(0, 2) + "." +
                                                 detailView.GetRowCellValue(intLinha(i), detailView.Columns("empresa")).ToString.Substring(2, 4) + " - " +
                                                 gvEmpresa.GetRowCellValue(intEmpresa(intEmpresa.Length - 1), gvEmpresa.Columns("razaosocial")).ToString
                    strNavegacao += " | Competência: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("competencia")).ToString.Substring(0, 2) + "/" +
                                                         detailView.GetRowCellValue(intLinha(i), detailView.Columns("competencia")).ToString.Substring(2, 4)
                    strNavegacao += " | Funcionário: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("funcionario")).ToString.Substring(0, 2) + "." +
                                                         detailView.GetRowCellValue(intLinha(i), detailView.Columns("funcionario")).ToString.Substring(2, 4) + " - " +
                                                         strFuncionario
                    strNavegacao += " | Obrigação: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("obrigacao")).ToString.Substring(0, 1) + "-" +
                                                       detailView.GetRowCellValue(intLinha(i), detailView.Columns("obrigacao")).ToString.Substring(1, 5) + " - " +
                                                       strObrigacao

                ElseIf (monitoramentologGridControl.FocusedView.LevelName().ToString = "monitoramentoInforme") Then
                    strNavegacao = "Empresa: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("empresa")).ToString.Substring(0, 2) + "." +
                                                 detailView.GetRowCellValue(intLinha(i), detailView.Columns("empresa")).ToString.Substring(2, 4) + " - " +
                                                 gvEmpresa.GetRowCellValue(intEmpresa(intEmpresa.Length - 1), gvEmpresa.Columns("razaosocial")).ToString
                    strNavegacao += " | Competência: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("competencia")).ToString.Substring(0, 2) + "/" +
                                                         detailView.GetRowCellValue(intLinha(i), detailView.Columns("competencia")).ToString.Substring(2, 4)

                ElseIf (monitoramentologGridControl.FocusedView.LevelName().ToString = "DetalheInforme") Then
                    strNavegacao = "Empresa: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("empresa")).ToString.Substring(0, 2) + "." +
                                                 detailView.GetRowCellValue(intLinha(i), detailView.Columns("empresa")).ToString.Substring(2, 4) + " - " +
                                                 gvEmpresa.GetRowCellValue(intEmpresa(intEmpresa.Length - 1), gvEmpresa.Columns("razaosocial")).ToString
                    strNavegacao += " | Competência: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("competencia")).ToString.Substring(0, 2) + "/" +
                                                         detailView.GetRowCellValue(intLinha(i), detailView.Columns("competencia")).ToString.Substring(2, 4)
                    If detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString.Length = 14 Then
                        strNavegacao += " | CNPJ/CPF: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString.Substring(0, 2) + "." +
                                                          detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString.Substring(2, 3) + "." +
                                                          detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString.Substring(5, 3) + "/" +
                                                          detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString.Substring(8, 4) + "-" +
                                                          detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString.Substring(12, 2)
                    ElseIf detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString.Length = 11 Then
                        strNavegacao += " | CNPJ/CPF: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString.Substring(0, 3) + "." +
                                                          detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString.Substring(3, 3) + "." +
                                                          detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString.Substring(6, 3) + "-" +
                                                          detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString.Substring(9, 2)
                    Else
                        strNavegacao += " | CNPJ/CPF: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString
                    End If
                    While ("monitoramentoInforme" <> monitoramentologGridControl.Views(intCountAux).LevelName.ToString)
                        intCountAux += 1
                    End While
                    gvInforme = TryCast(monitoramentologGridControl.Views(intCountAux), GridView)
                    intInforme = gvInforme.GetSelectedRows()
                    strInforme = gvInforme.GetRowCellValue(intInforme(intInforme.Length - 1), gvInforme.Columns("nome")).ToString()
                    strNavegacao += " - " + strInforme

                ElseIf (monitoramentologGridControl.FocusedView.LevelName().ToString = "LogInforme") Then
                    strNavegacao = "Empresa: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("empresa")).ToString.Substring(0, 2) + "." +
                                                 detailView.GetRowCellValue(intLinha(i), detailView.Columns("empresa")).ToString.Substring(2, 4) + " - " +
                                                 gvEmpresa.GetRowCellValue(intEmpresa(intEmpresa.Length - 1), gvEmpresa.Columns("razaosocial")).ToString
                    strNavegacao += " | Competência: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("competencia")).ToString.Substring(0, 2) + "/" +
                                                         detailView.GetRowCellValue(intLinha(i), detailView.Columns("competencia")).ToString.Substring(2, 4)
                    If detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString.Length = 14 Then
                        strNavegacao += " | CNPJ/CPF: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString.Substring(0, 2) + "." +
                                                          detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString.Substring(2, 3) + "." +
                                                          detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString.Substring(5, 3) + "/" +
                                                          detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString.Substring(8, 4) + "-" +
                                                          detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString.Substring(12, 2)
                    ElseIf detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString.Length = 11 Then
                        strNavegacao += " | CNPJ/CPF: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString.Substring(0, 3) + "." +
                                                          detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString.Substring(3, 3) + "." +
                                                          detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString.Substring(6, 3) + "-" +
                                                          detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString.Substring(9, 2)
                    Else
                        strNavegacao += " | CNPJ/CPF: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString
                    End If
                    strNavegacao += " - " + strInforme
                    While ("DetalheInforme" <> monitoramentologGridControl.Views(intCountAux).LevelName.ToString)
                        intCountAux += 1
                    End While
                    gvObrigacao = TryCast(monitoramentologGridControl.Views(intCountAux), GridView)
                    intObrigacao = gvObrigacao.GetSelectedRows()
                    strObrigacao = gvObrigacao.GetRowCellValue(intObrigacao(intObrigacao.Length - 1), gvObrigacao.Columns("descricao")).ToString()
                    strNavegacao += " | Obrigação: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("obrigacao")).ToString.Substring(0, 1) + "-" +
                                                      detailView.GetRowCellValue(intLinha(i), detailView.Columns("obrigacao")).ToString.Substring(1, 5) + " - " +
                                                      strObrigacao
                ElseIf (monitoramentologGridControl.FocusedView.LevelName().ToString = "PortalInforme") Then
                    strNavegacao = "Empresa: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("empresa")).ToString.Substring(0, 2) + "." +
                                                 detailView.GetRowCellValue(intLinha(i), detailView.Columns("empresa")).ToString.Substring(2, 4) + " - " +
                                                 gvEmpresa.GetRowCellValue(intEmpresa(intEmpresa.Length - 1), gvEmpresa.Columns("razaosocial")).ToString
                    strNavegacao += " | Competência: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("competencia")).ToString.Substring(0, 2) + "/" +
                                                         detailView.GetRowCellValue(intLinha(i), detailView.Columns("competencia")).ToString.Substring(2, 4)
                    If detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString.Length = 14 Then
                        strNavegacao += " | CNPJ/CPF: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString.Substring(0, 2) + "." +
                                                          detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString.Substring(2, 3) + "." +
                                                          detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString.Substring(5, 3) + "/" +
                                                          detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString.Substring(8, 4) + "-" +
                                                          detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString.Substring(12, 2)
                    ElseIf detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString.Length = 11 Then
                        strNavegacao += " | CNPJ/CPF: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString.Substring(0, 3) + "." +
                                                          detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString.Substring(3, 3) + "." +
                                                          detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString.Substring(6, 3) + "-" +
                                                          detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString.Substring(9, 2)
                    Else
                        strNavegacao += " | CNPJ/CPF: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString
                    End If
                    strNavegacao += " - " + strInforme
                    While ("DetalheInforme" <> monitoramentologGridControl.Views(intCountAux).LevelName.ToString)
                        intCountAux += 1
                    End While
                    gvObrigacao = TryCast(monitoramentologGridControl.Views(intCountAux), GridView)
                    intObrigacao = gvObrigacao.GetSelectedRows()
                    strObrigacao = gvObrigacao.GetRowCellValue(intObrigacao(intObrigacao.Length - 1), gvObrigacao.Columns("descricao")).ToString()
                    strNavegacao += " | Obrigação: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("obrigacao")).ToString.Substring(0, 1) + "-" +
                                                       detailView.GetRowCellValue(intLinha(i), detailView.Columns("obrigacao")).ToString.Substring(1, 5) + " - " +
                                                       strObrigacao

                ElseIf (monitoramentologGridControl.FocusedView.LevelName().ToString = "LogPortalInforme") Then
                    strNavegacao = "Empresa: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("empresa")).ToString.Substring(0, 2) + "." +
                                                 detailView.GetRowCellValue(intLinha(i), detailView.Columns("empresa")).ToString.Substring(2, 4) + " - " +
                                                 gvEmpresa.GetRowCellValue(intEmpresa(intEmpresa.Length - 1), gvEmpresa.Columns("razaosocial")).ToString
                    strNavegacao += " | Competência: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("competencia")).ToString.Substring(0, 2) + "/" +
                                                         detailView.GetRowCellValue(intLinha(i), detailView.Columns("competencia")).ToString.Substring(2, 4)
                    If detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString.Length = 14 Then
                        strNavegacao += " | CNPJ/CPF: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString.Substring(0, 2) + "." +
                                                          detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString.Substring(2, 3) + "." +
                                                          detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString.Substring(5, 3) + "/" +
                                                          detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString.Substring(8, 4) + "-" +
                                                          detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString.Substring(12, 2)
                    ElseIf detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString.Length = 11 Then
                        strNavegacao += " | CNPJ/CPF: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString.Substring(0, 3) + "." +
                                                          detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString.Substring(3, 3) + "." +
                                                          detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString.Substring(6, 3) + "-" +
                                                          detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString.Substring(9, 2)
                    Else
                        strNavegacao += " | CNPJ/CPF: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString
                    End If
                    strNavegacao += " - " + strInforme
                    strNavegacao += " | Obrigação: " + detailView.GetRowCellValue(intLinha(i), detailView.Columns("obrigacao")).ToString.Substring(0, 1) + "-" +
                                                       detailView.GetRowCellValue(intLinha(i), detailView.Columns("obrigacao")).ToString.Substring(1, 5) + " - " +
                                                       strObrigacao

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
            Dim strJoinUsuarios As String = String.Empty
            Dim strWhere As String = objFiltro.RetornaWhereFiltro("aca")
            If usuarioInfo.obrigacoes Then
                strJoinUsuarios = "join admobrigacoesusuarios aou on aou.obrigacao = aca.obrigacao and aou.usuario = '" + usuarioInfo.usuario + "' "
            End If
            Dim strQuery() As String = {"", "", "", "", "", "", "", "", "", "", "", "", "", "", ""}
            Dim strQueryTemp() As String = {"", "", ""}
            SplashScreenManager.ShowForm(Me, GetType(aguardeWaitForm), True, True, False)

            strQuery(0) = "select distinct aca.empresa, max(e.razaosocial) as razaosocial, max(e.cnpj) as cnpj, aca.competencia, " +
                                         "case when  max(coalesce(ag.geradas,0)) + max(coalesce(ae.entrega,0)) + max(coalesce(ac.encarregado,0)) = 0 then 0 " +
                                         "else case when max(coalesce(ag.geradas,0)) = max(coalesce(ang.naogeradas,0)) and max(coalesce(ae.entrega,0)) = max(coalesce(ang.naogeradas,0)) and max(coalesce(ac.encarregado,0)) = max(coalesce(ang.naogeradas,0)) then 2 else 1 end end as status " +
                            "from admcontroleadministrativo aca " + strJoinUsuarios +
                            "join empresas e on e.empresa = aca.empresa and e.exercicio = aca.exercicio " +
                            "join (select aca.empresa, aca.competencia, count(*) as naogeradas from admcontroleadministrativo aca " + strJoinUsuarios + " where " + strWhere + "group by aca.empresa, aca.competencia) ang on ang.empresa = aca.empresa and ang.competencia = aca.competencia " +
                       "left join (select aca.empresa, aca.competencia, count(*) as geradas from admcontroleadministrativo aca " + strJoinUsuarios + " where coalesce(aca.usuariogeracao,'') <> '' and not aca.datahorageracao is null and " + strWhere + "group by aca.empresa, aca.competencia) ag on ag.empresa = aca.empresa and ag.competencia = aca.competencia " +
                       "left join (select aca.empresa, aca.competencia, count(*) as entrega from admcontroleadministrativo aca " + strJoinUsuarios + " where coalesce(aca.usuarioentrega,'') <> '' and not aca.datahoraentrega is null and aca.vistoentrega = -1 and " + strWhere + "group by aca.empresa, aca.competencia) ae on ae.empresa = aca.empresa and ae.competencia = aca.competencia " +
                       "left join (select aca.empresa, aca.competencia, count(*) as encarregado from admcontroleadministrativo aca  " + strJoinUsuarios + " where coalesce(aca.usuarioencarregado,'') <> '' and not aca.datahoraencarregado is null and aca.vistoencarregado = -1 and " + strWhere + "group by aca.empresa, aca.competencia) ac on ac.empresa = aca.empresa and ac.competencia = aca.competencia " +
                       "left join ""#" + usuarioInfo.usuario.ToString + "_empresas_tmp"" emp on emp.empresa = aca.empresa and emp.competencia = aca.competencia and emp.obrigacao = aca.obrigacao and emp.exercicio = aca.exercicio and emp.parcela = aca.parcela and emp.sequenciaextra = aca.sequenciaextra and emp.obrigacaoextra = aca.obrigacaoextra and emp.tipopessoainforme = aca.tipopessoainforme and emp.informe = aca.informe " +
                       "left join ""#" + usuarioInfo.usuario.ToString + "_funcionario_tmp"" fun on fun.empresa = aca.empresa and fun.competencia = aca.competencia and fun.funcionario = aca.funcionario and fun.obrigacao = aca.obrigacao and fun.exercicio = aca.exercicio and fun.parcela = aca.parcela and fun.sequenciaextra = aca.sequenciaextra and fun.obrigacaoextra = aca.obrigacaoextra and fun.tipopessoainforme = aca.tipopessoainforme and fun.informe = aca.informe " +
                       "left join ""#" + usuarioInfo.usuario.ToString + "_informe_tmp"" inf on inf.empresa = aca.empresa and inf.competencia = aca.competencia and inf.obrigacao = aca.obrigacao and inf.exercicio = aca.exercicio and inf.parcela = aca.parcela and inf.sequenciaextra = aca.sequenciaextra and inf.obrigacaoextra = aca.obrigacaoextra and inf.tipopessoainforme = aca.tipopessoainforme " +
                           "where " + strWhere + " " +
                              "and (coalesce(emp.empresa) <> '' " +
                               "or coalesce(fun.empresa) <> '' " +
                               "or coalesce(inf.empresa) <> '' )" +
                        "group by aca.empresa, aca.competencia " +
                        "order by 1"

            strQuery(1) = "select distinct aca.empresa, aca.obrigacao, ao.descricao, aca.datavencimento, " +
                                 "aca.usuariogeracao, aca.datahorageracao, aca.usuarioentrega,  aca.datahoraentrega, aca.usuarioencarregado, aca.datahoraencarregado, " +
                                 "case when coalesce(aca.usuariogeracao,'') = '' and coalesce(aca.vistoentrega,0) = 0 and coalesce(aca.vistoencarregado,0) = 0 then 0 " +
                                      "else case when coalesce(aca.usuariogeracao,'') <> '' and coalesce(aca.vistoentrega,0) <> 0 and coalesce(aca.vistoencarregado,0) <> 0 then 2 else 1 end end as status, " +
                                 "aca.sequenciaextra, aca.obrigacaoextra, aca.parcela, aca.competencia " +
                            "from admcontroleadministrativo aca " + strJoinUsuarios +
                            "join admobrigacoes ao on ao.obrigacao = aca.obrigacao " +
                            "join ""#" + usuarioInfo.usuario.ToString + "_empresas_tmp"" log on log.empresa = aca.empresa and log.competencia = aca.competencia and log.obrigacao = aca.obrigacao and log.exercicio = aca.exercicio and log.parcela = aca.parcela and log.sequenciaextra = aca.sequenciaextra and log.obrigacaoextra = aca.obrigacaoextra and log.tipopessoainforme = aca.tipopessoainforme and log.informe = aca.informe " +
                           "where " + strWhere + " " +
                             "and coalesce(aca.funcionario,'') = '' " +
                             "and coalesce(aca.tipopessoainforme,0) = 0 " +
                        "order by 1, 4, 2, 12"

            strQuery(2) = "select distinct aca.empresa, aca.obrigacao, log.sequencia, log.datavencimento, " +
                                 "log.usuariogeracao, log.datahorageracao, log.usuarioentrega, log.datahoraentrega, log.usuarioencarregado, log.datahoraencarregado, log.usuariolog, log.datahoralog, " +
                                 "case when coalesce(log.usuariogeracao,'') = '' and coalesce(log.vistoentrega,0) = 0 and coalesce(log.vistoencarregado,0) = 0 then 0 " +
                                      "else case when coalesce(log.usuariogeracao,'') <> '' and coalesce(log.vistoentrega,0) <> 0 and coalesce(log.vistoencarregado,0) <> 0 then 2 else 1 end end as status, " +
                                 "aca.sequenciaextra, aca.obrigacaoextra, aca.parcela, aca.competencia " +
                            "from admcontroleadministrativo aca " + strJoinUsuarios +
                            "join admlogcontroleadministrativo log on log.empresa = aca.empresa and log.competencia = aca.competencia and log.obrigacao = aca.obrigacao and log.exercicio = aca.exercicio and log.parcela = aca.parcela and log.sequenciaextra = aca.sequenciaextra and log.obrigacaoextra = aca.obrigacaoextra and log.tipopessoainforme = aca.tipopessoainforme and log.informe = aca.informe " +
                           "where " + strWhere + " " +
                             "and coalesce(aca.funcionario,'') = '' " +
                             "and coalesce(aca.tipopessoainforme,0) = 0 " +
                        "order by 1, 2, 3 desc, 4, 12"

            strQuery(3) = "select distinct aca.empresa, aca.obrigacao, case when coalesce(por.usuarioenvio,'') <> '' then -1 else 0 end as usuarioenviou, por.mensagem, por.usuarioenvio, por.datahoraenvioinicio, por.datahoraenviofim, " +
                                 "por.empresavisualizou, por.nomeusuarioempresa, por.datahoraempresavisualizou, aca.sequenciaextra, aca.obrigacaoextra, aca.parcela, aca.competencia " +
                            "from admcontroleadministrativo aca " + strJoinUsuarios +
                            "join admcontroleadministrativoportalarquivos por on por.empresa = aca.empresa and por.competencia = aca.competencia and por.obrigacao = aca.obrigacao and por.exercicio = aca.exercicio and por.parcela = aca.parcela and por.sequenciaextra = aca.sequenciaextra and por.obrigacaoextra = aca.obrigacaoextra and por.tipopessoainforme = aca.tipopessoainforme and por.informe = aca.informe " +
                            "join ""#" + usuarioInfo.usuario.ToString + "_empresas_tmp"" log on log.empresa = por.empresa and log.competencia = por.competencia and log.obrigacao = por.obrigacao and log.exercicio = por.exercicio and log.parcela = por.parcela and log.sequenciaextra = por.sequenciaextra and log.obrigacaoextra = por.obrigacaoextra and log.tipopessoainforme = por.tipopessoainforme and log.informe = por.informe and log.flag = 4 " +
                           "where " + strWhere + " " +
                             "and coalesce(aca.funcionario,'') = '' " +
                             "and coalesce(aca.tipopessoainforme,0) = 0 "
            strQuery(3) += "union all "
            strQuery(3) += "select distinct aca.empresa, aca.obrigacao, case when coalesce(por.usuarioenvio,'') <> '' then -1 else 0 end as usuarioenviou, por.mensagem, por.usuarioenvio, por.datahoraenvioinicio, por.datahoraenviofim, " +
                                 "por.empresavisualizou, por.nomeusuarioempresa, por.datahoraempresavisualizou, aca.sequenciaextra, aca.obrigacaoextra, aca.parcela, aca.competencia " +
                            "from admcontroleadministrativo aca " + strJoinUsuarios +
                            "join admcontroleadministrativoportalguias por on por.empresa = aca.empresa and por.competencia = aca.competencia and por.obrigacao = aca.obrigacao and por.exercicio = aca.exercicio and por.parcela = aca.parcela and por.sequenciaextra = aca.sequenciaextra and por.obrigacaoextra = aca.obrigacaoextra and por.tipopessoainforme = aca.tipopessoainforme and por.informe = aca.informe " +
                            "join ""#" + usuarioInfo.usuario.ToString + "_empresas_tmp"" log on log.empresa = por.empresa and log.competencia = por.competencia and log.obrigacao = por.obrigacao and log.exercicio = por.exercicio and log.parcela = por.parcela and log.sequenciaextra = por.sequenciaextra and log.obrigacaoextra = por.obrigacaoextra and log.tipopessoainforme = por.tipopessoainforme and log.informe = por.informe and log.flag = 4 " +
                           "where " + strWhere + " " +
                             "and coalesce(aca.funcionario,'') = '' " +
                             "and coalesce(aca.tipopessoainforme,0) = 0 " +
                        "order by 1, 2, 14"

            strQuery(4) = "select distinct aca.empresa, aca.obrigacao, log.sequencia, case when coalesce(log.usuarioenvio,'') <> '' then -1 else 0 end as usuarioenviou, log.mensagem, log.usuarioenvio, log.datahoraenvioinicio, log.datahoraenviofim, " +
                                 "log.empresavisualizou, log.nomeusuarioempresa, log.datahoraempresavisualizou, log.usuariolog, log.datahoralog, aca.sequenciaextra, aca.obrigacaoextra, aca.parcela, aca.competencia " +
                            "from admcontroleadministrativo aca " + strJoinUsuarios +
                            "join admcontroleadministrativoportalarquivos por on por.empresa = aca.empresa and por.competencia = aca.competencia and por.obrigacao = aca.obrigacao and por.exercicio = aca.exercicio and por.parcela = aca.parcela and por.sequenciaextra = aca.sequenciaextra and por.obrigacaoextra = aca.obrigacaoextra and por.tipopessoainforme = aca.tipopessoainforme and por.informe = aca.informe " +
                            "join admlogcontroleadministrativoportalarquivos log on log.empresa = por.empresa and log.competencia = por.competencia and log.obrigacao = por.obrigacao and log.exercicio = por.exercicio and log.parcela = por.parcela and log.sequenciaextra = por.sequenciaextra and log.obrigacaoextra = por.obrigacaoextra and log.tipopessoainforme = por.tipopessoainforme and log.informe = por.informe " +
                           "where " + strWhere + " " +
                             "and coalesce(aca.funcionario,'') = '' " +
                             "and coalesce(aca.tipopessoainforme,0) = 0 "
            strQuery(4) += "union all "
            strQuery(4) += "select distinct aca.empresa, aca.obrigacao, log.sequencia, case when coalesce(log.usuarioenvio,'') <> '' then -1 else 0 end as usuarioenviou, log.mensagem, log.usuarioenvio, log.datahoraenvioinicio, log.datahoraenviofim, " +
                                 "log.empresavisualizou, log.nomeusuarioempresa, log.datahoraempresavisualizou, log.usuariolog, log.datahoralog, aca.sequenciaextra, aca.obrigacaoextra, aca.parcela, aca.competencia " +
                            "from admcontroleadministrativo aca " + strJoinUsuarios +
                            "join admcontroleadministrativoportalguias por on por.empresa = aca.empresa and por.competencia = aca.competencia and por.obrigacao = aca.obrigacao and por.exercicio = aca.exercicio and por.parcela = aca.parcela and por.sequenciaextra = aca.sequenciaextra and por.obrigacaoextra = aca.obrigacaoextra and por.tipopessoainforme = aca.tipopessoainforme and por.informe = aca.informe " +
                            "join admlogcontroleadministrativoportalguias log on log.empresa = por.empresa and log.competencia = por.competencia and log.obrigacao = por.obrigacao and log.exercicio = por.exercicio and log.parcela = por.parcela and log.sequenciaextra = por.sequenciaextra and log.obrigacaoextra = por.obrigacaoextra and log.tipopessoainforme = por.tipopessoainforme and log.informe = por.informe " +
                           "where " + strWhere + " " +
                             "and coalesce(aca.funcionario,'') = '' " +
                             "and coalesce(aca.tipopessoainforme,0) = 0 " +
                        "order by 1, 2, 3 desc, 17"

            strQuery(5) = "select distinct aca.empresa, aca.funcionario, max(f.nome) as nome, aca.competencia " +
                            "from admcontroleadministrativo aca " + strJoinUsuarios +
                            "join funcionarios f on f.empresa = aca.empresa and f.funcionario = aca.funcionario " +
                            "join ""#" + usuarioInfo.usuario.ToString + "_funcionario_tmp"" log on log.empresa = aca.empresa and log.competencia = aca.competencia and log.funcionario = aca.funcionario and log.obrigacao = aca.obrigacao and log.exercicio = aca.exercicio and log.parcela = aca.parcela and log.sequenciaextra = aca.sequenciaextra and log.obrigacaoextra = aca.obrigacaoextra and log.tipopessoainforme = aca.tipopessoainforme and log.informe = aca.informe " +
                           "where " + strWhere + " " +
                             "and coalesce(aca.funcionario,'') <> '' " +
                        "group by aca.empresa, aca.funcionario, aca.competencia " +
                        "order by 1, 2"

            strQuery(6) = "select distinct aca.empresa, aca.obrigacao, ao.descricao, aca.datavencimento, " +
                                 "aca.usuariogeracao, aca.datahorageracao, aca.usuarioentrega,  aca.datahoraentrega, aca.usuarioencarregado, aca.datahoraencarregado, " +
                                 "case when coalesce(aca.usuariogeracao,'') = '' and coalesce(aca.vistoentrega,0) = 0 and coalesce(aca.vistoencarregado,0) = 0 then 0 " +
                                      "else case when coalesce(aca.usuariogeracao,'') <> '' and coalesce(aca.vistoentrega,0) <> 0 and coalesce(aca.vistoencarregado,0) <> 0 then 2 else 1 end end as status, " +
                                      "aca.funcionario, aca.competencia " +
                            "from admcontroleadministrativo aca " + strJoinUsuarios +
                            "join admobrigacoes ao on ao.obrigacao = aca.obrigacao " +
                            "join funcionarios f on f.empresa = aca.empresa and f.funcionario = aca.funcionario " +
                            "join ""#" + usuarioInfo.usuario.ToString + "_funcionario_tmp"" log on log.empresa = aca.empresa and log.competencia = aca.competencia and log.funcionario = aca.funcionario and log.obrigacao = aca.obrigacao and log.exercicio = aca.exercicio and log.parcela = aca.parcela and log.sequenciaextra = aca.sequenciaextra and log.obrigacaoextra = aca.obrigacaoextra and log.tipopessoainforme = aca.tipopessoainforme and log.informe = aca.informe " +
                           "where " + strWhere + " " +
                             "and coalesce(aca.funcionario,'') <> '' " +
                        "order by 1, 4, 2, 13"

            strQuery(7) = "select distinct aca.empresa, aca.obrigacao, log.sequencia, log.datavencimento, " +
                                 "log.usuariogeracao, log.datahorageracao, log.usuarioentrega, log.datahoraentrega, log.usuarioencarregado, log.datahoraencarregado, log.usuariolog, log.datahoralog, " +
                                 "case when coalesce(log.usuariogeracao,'') = '' and coalesce(log.vistoentrega,0) = 0 and coalesce(log.vistoencarregado,0) = 0 then 0 " +
                                 "else case when coalesce(log.usuariogeracao,'') <> '' and coalesce(log.vistoentrega,0) <> 0 and coalesce(log.vistoencarregado,0) <> 0 then 2 else 1 end end as status, " +
                                 "aca.funcionario, aca.competencia " +
                "from admcontroleadministrativo aca " + strJoinUsuarios +
                "join funcionarios f on f.empresa = aca.empresa and f.funcionario = aca.funcionario " +
                "join admlogcontroleadministrativo log on log.empresa = aca.empresa and log.competencia = aca.competencia and log.funcionario = aca.funcionario and log.obrigacao = aca.obrigacao and log.exercicio = aca.exercicio and log.parcela = aca.parcela and log.sequenciaextra = aca.sequenciaextra and log.obrigacaoextra = aca.obrigacaoextra and log.tipopessoainforme = aca.tipopessoainforme and log.informe = aca.informe " +
               "where " + strWhere + " " +
                 "and coalesce(aca.funcionario,'') <> '' " +
            "order by 1, 2, 3 desc, 4, 14"

            strQuery(8) = "select distinct aca.empresa, aca.obrigacao, case when coalesce(por.usuarioenvio,'') <> '' then -1 else 0 end as usuarioenviou, por.mensagem, por.usuarioenvio, por.datahoraenvioinicio, por.datahoraenviofim, " +
                                 "por.empresavisualizou, por.nomeusuarioempresa, por.datahoraempresavisualizou, aca.funcionario, aca.competencia  " +
                            "from admcontroleadministrativo aca " + strJoinUsuarios +
                            "join funcionarios f on f.empresa = aca.empresa and f.funcionario = aca.funcionario " +
                            "join admcontroleadministrativoportalarquivos por on por.empresa = aca.empresa and por.competencia = aca.competencia and por.funcionario = aca.funcionario and por.obrigacao = aca.obrigacao and por.exercicio = aca.exercicio and por.parcela = aca.parcela and por.sequenciaextra = aca.sequenciaextra and por.obrigacaoextra = aca.obrigacaoextra and por.tipopessoainforme = aca.tipopessoainforme and por.informe = aca.informe " +
                            "join ""#" + usuarioInfo.usuario.ToString + "_funcionario_tmp"" log on log.empresa = por.empresa and log.competencia = por.competencia and log.funcionario = por.funcionario and log.obrigacao = por.obrigacao and log.exercicio = por.exercicio and log.parcela = por.parcela and log.sequenciaextra = por.sequenciaextra and log.obrigacaoextra = por.obrigacaoextra and log.tipopessoainforme = por.tipopessoainforme and log.informe = por.informe and log.flag = 9 " +
                           "where " + strWhere + " " +
                             "and coalesce(aca.funcionario,'') <> '' "
            strQuery(8) += "union all "
            strQuery(8) += "select distinct aca.empresa, aca.obrigacao, case when coalesce(por.usuarioenvio,'') <> '' then -1 else 0 end as usuarioenviou, por.mensagem, por.usuarioenvio, por.datahoraenvioinicio, por.datahoraenviofim, " +
                                 "por.empresavisualizou, por.nomeusuarioempresa, por.datahoraempresavisualizou, aca.funcionario, aca.competencia  " +
                            "from admcontroleadministrativo aca " + strJoinUsuarios +
                            "join funcionarios f on f.empresa = aca.empresa and f.funcionario = aca.funcionario " +
                            "join admcontroleadministrativoportalguias por on por.empresa = aca.empresa and por.competencia = aca.competencia and por.funcionario = aca.funcionario and por.obrigacao = aca.obrigacao and por.exercicio = aca.exercicio and por.parcela = aca.parcela and por.sequenciaextra = aca.sequenciaextra and por.obrigacaoextra = aca.obrigacaoextra and por.tipopessoainforme = aca.tipopessoainforme and por.informe = aca.informe " +
                            "join ""#" + usuarioInfo.usuario.ToString + "_funcionario_tmp"" log on log.empresa = por.empresa and log.competencia = por.competencia and log.funcionario = por.funcionario and log.obrigacao = por.obrigacao and log.exercicio = por.exercicio and log.parcela = por.parcela and log.sequenciaextra = por.sequenciaextra and log.obrigacaoextra = por.obrigacaoextra and log.tipopessoainforme = por.tipopessoainforme and log.informe = por.informe and log.flag = 9 " +
                           "where " + strWhere + " " +
                             "and coalesce(aca.funcionario,'') <> '' " +
                        "order by 1, 2, 12, 11"

            strQuery(9) = "select distinct aca.empresa, aca.obrigacao, log.sequencia, case when coalesce(log.usuarioenvio,'') <> '' then -1 else 0 end as usuarioenviou, log.mensagem, log.usuarioenvio, log.datahoraenvioinicio, log.datahoraenviofim, " +
                                 "log.empresavisualizou, log.nomeusuarioempresa, log.datahoraempresavisualizou, log.usuariolog, log.datahoralog, aca.funcionario, aca.competencia  " +
                            "from admcontroleadministrativo aca " + strJoinUsuarios +
                            "join funcionarios f on f.empresa = aca.empresa and f.funcionario = aca.funcionario " +
                            "join admcontroleadministrativoportalarquivos por on por.empresa = aca.empresa and por.competencia = aca.competencia and por.funcionario = aca.funcionario and por.obrigacao = aca.obrigacao and por.exercicio = aca.exercicio and por.parcela = aca.parcela and por.sequenciaextra = aca.sequenciaextra and por.obrigacaoextra = aca.obrigacaoextra and por.tipopessoainforme = aca.tipopessoainforme and por.informe = aca.informe " +
                            "join admlogcontroleadministrativoportalarquivos log on log.empresa = por.empresa and log.competencia = por.competencia and log.funcionario = por.funcionario and log.obrigacao = por.obrigacao and log.exercicio = por.exercicio and log.parcela = por.parcela and log.sequenciaextra = por.sequenciaextra and log.obrigacaoextra = por.obrigacaoextra and log.tipopessoainforme = por.tipopessoainforme and log.informe = por.informe " +
                           "where " + strWhere + " " +
                             "and coalesce(aca.funcionario,'') <> '' "
            strQuery(9) += "union all "
            strQuery(9) += "select distinct aca.empresa, aca.obrigacao, log.sequencia, case when coalesce(log.usuarioenvio,'') <> '' then -1 else 0 end as usuarioenviou, log.mensagem, log.usuarioenvio, log.datahoraenvioinicio, log.datahoraenviofim, " +
                                 "log.empresavisualizou, log.nomeusuarioempresa, log.datahoraempresavisualizou, log.usuariolog, log.datahoralog, aca.funcionario, aca.competencia " +
                            "from admcontroleadministrativo aca " + strJoinUsuarios +
                            "join funcionarios f on f.empresa = aca.empresa and f.funcionario = aca.funcionario " +
                            "join admcontroleadministrativoportalguias por on por.empresa = aca.empresa and por.competencia = aca.competencia and por.funcionario = aca.funcionario and por.obrigacao = aca.obrigacao and por.exercicio = aca.exercicio and por.parcela = aca.parcela and por.sequenciaextra = aca.sequenciaextra and por.obrigacaoextra = aca.obrigacaoextra and por.tipopessoainforme = aca.tipopessoainforme and por.informe = aca.informe " +
                            "join admlogcontroleadministrativoportalguias log on log.empresa = por.empresa and log.competencia = por.competencia and log.funcionario = por.funcionario and log.obrigacao = por.obrigacao and log.exercicio = por.exercicio and log.parcela = por.parcela and log.sequenciaextra = por.sequenciaextra and log.obrigacaoextra = por.obrigacaoextra and log.tipopessoainforme = por.tipopessoainforme and log.informe = por.informe " +
                           "where " + strWhere + " " +
                             "and coalesce(aca.funcionario,'') <> '' " +
                        "order by 1, 2, 3 desc, 15, 14"

            strQuery(10) = "select distinct aca.empresa, aca.cnpjcpfinforme, jur.nome, aca.competencia " +
                            "from admcontroleadministrativo aca " + strJoinUsuarios +
                            "join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio " +
                            "join ""#" + usuarioInfo.usuario.ToString + "_informe_tmp"" log on log.empresa = aca.empresa and log.competencia = aca.competencia and log.obrigacao = aca.obrigacao and log.exercicio = aca.exercicio and log.parcela = aca.parcela and log.sequenciaextra = aca.sequenciaextra and log.obrigacaoextra = aca.obrigacaoextra and log.tipopessoainforme = aca.tipopessoainforme " +
                            "where " + strWhere + " " +
                             "and coalesce(aca.tipopessoainforme,0) = 1 " +
                        "group by aca.empresa, jur.nome, aca.cnpjcpfinforme, aca.competencia "
            strQuery(10) += "union all "
            strQuery(10) += "select distinct aca.empresa, aca.cnpjcpfinforme, fis.nome, aca.competencia " +
                             "from admcontroleadministrativo aca " + strJoinUsuarios +
                             "join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio " +
                             "join ""#" + usuarioInfo.usuario.ToString + "_informe_tmp"" log on log.empresa = aca.empresa and log.competencia = aca.competencia and log.obrigacao = aca.obrigacao and log.exercicio = aca.exercicio and log.parcela = aca.parcela and log.sequenciaextra = aca.sequenciaextra and log.obrigacaoextra = aca.obrigacaoextra and log.tipopessoainforme = aca.tipopessoainforme " +
                            "where " + strWhere + " " +
                              "and coalesce(aca.tipopessoainforme,0) = 2 " +
                         "group by aca.empresa, fis.nome, aca.cnpjcpfinforme, aca.competencia " +
                         "order by 1, 2"

            strQuery(11) = "select distinct aca.empresa, aca.obrigacao, ao.descricao, aca.datavencimento, " +
                                 "aca.usuariogeracao, aca.datahorageracao, aca.usuarioentrega,  aca.datahoraentrega, aca.usuarioencarregado, aca.datahoraencarregado, " +
                                 "case when coalesce(aca.usuariogeracao,'') = '' and coalesce(aca.vistoentrega,0) = 0 and coalesce(aca.vistoencarregado,0) = 0 then 0 " +
                                      "else case when coalesce(aca.usuariogeracao,'') <> '' and coalesce(aca.vistoentrega,0) <> 0 and coalesce(aca.vistoencarregado,0) <> 0 then 2 else 1 end end as status, " +
                                      "aca.cnpjcpfinforme, jur.nome, aca.tipopessoainforme, aca.informe, aca.sequenciaextra, aca.obrigacaoextra, aca.parcela, aca.competencia " +
                            "from admcontroleadministrativo aca " + strJoinUsuarios +
                            "join admobrigacoes ao on ao.obrigacao = aca.obrigacao " +
                            "join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio " +
                            "join ""#" + usuarioInfo.usuario.ToString + "_informe_tmp"" log on log.empresa = aca.empresa and log.competencia = aca.competencia and log.obrigacao = aca.obrigacao and log.exercicio = aca.exercicio and log.parcela = aca.parcela and log.sequenciaextra = aca.sequenciaextra and log.obrigacaoextra = aca.obrigacaoextra and log.tipopessoainforme = aca.tipopessoainforme " +
                            "where " + strWhere + " " +
                             "and coalesce(aca.tipopessoainforme,0) = 1 "
            strQuery(11) += "union all "
            strQuery(11) += "select distinct aca.empresa, aca.obrigacao, ao.descricao, aca.datavencimento, " +
                                  "aca.usuariogeracao, aca.datahorageracao, aca.usuarioentrega,  aca.datahoraentrega, aca.usuarioencarregado, aca.datahoraencarregado, " +
                                  "case when coalesce(aca.usuariogeracao,'') = '' and coalesce(aca.vistoentrega,0) = 0 and coalesce(aca.vistoencarregado,0) = 0 then 0 " +
                                       "else case when coalesce(aca.usuariogeracao,'') <> '' and coalesce(aca.vistoentrega,0) <> 0 and coalesce(aca.vistoencarregado,0) <> 0 then 2 else 1 end end as status, " +
                                       "aca.cnpjcpfinforme, fis.nome, aca.tipopessoainforme, aca.informe, aca.sequenciaextra, aca.obrigacaoextra, aca.parcela, aca.competencia " +
                             "from admcontroleadministrativo aca " + strJoinUsuarios +
                             "join admobrigacoes ao on ao.obrigacao = aca.obrigacao " +
                             "join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio " +
                             "join ""#" + usuarioInfo.usuario.ToString + "_informe_tmp"" log on log.empresa = aca.empresa and log.competencia = aca.competencia and log.obrigacao = aca.obrigacao and log.exercicio = aca.exercicio and log.parcela = aca.parcela and log.sequenciaextra = aca.sequenciaextra and log.obrigacaoextra = aca.obrigacaoextra and log.tipopessoainforme = aca.tipopessoainforme " +
                            "where " + strWhere + " " +
                              "and coalesce(aca.tipopessoainforme,0) = 2 " +
                         "order by 1, 4, 2, 17"

            strQuery(12) = "select distinct aca.empresa, aca.obrigacao, log.sequencia, log.datavencimento, " +
                                  "log.usuariogeracao, log.datahorageracao, log.usuarioentrega, log.datahoraentrega, log.usuarioencarregado, log.datahoraencarregado, log.usuariolog, log.datahoralog, " +
                                  "case when coalesce(log.usuariogeracao,'') = '' and coalesce(log.vistoentrega,0) = 0 and coalesce(log.vistoencarregado,0) = 0 then 0 " +
                                       "else case when coalesce(log.usuariogeracao,'') <> '' and coalesce(log.vistoentrega,0) <> 0 and coalesce(log.vistoencarregado,0) <> 0 then 2 else 1 end end as status, " +
                                  "aca.cnpjcpfinforme, jur.nome, aca.tipopessoainforme, aca.informe, aca.sequenciaextra, aca.obrigacaoextra, aca.parcela, aca.competencia " +
                             "from admcontroleadministrativo aca " + strJoinUsuarios +
                             "join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio " +
                             "join admlogcontroleadministrativo log on log.empresa = aca.empresa and log.competencia = aca.competencia and log.obrigacao = aca.obrigacao and log.exercicio = aca.exercicio and log.parcela = aca.parcela and log.sequenciaextra = aca.sequenciaextra and log.obrigacaoextra = aca.obrigacaoextra and log.tipopessoainforme = aca.tipopessoainforme " +
                            "where " + strWhere + " " +
                              "and coalesce(aca.tipopessoainforme,0) = 1 "
            strQuery(12) += "union all "
            strQuery(12) += "select distinct aca.empresa, aca.obrigacao, log.sequencia, log.datavencimento, " +
                                  "log.usuariogeracao, log.datahorageracao, log.usuarioentrega, log.datahoraentrega, log.usuarioencarregado, log.datahoraencarregado, log.usuariolog, log.datahoralog, " +
                                  "case when coalesce(log.usuariogeracao,'') = '' and coalesce(log.vistoentrega,0) = 0 and coalesce(log.vistoencarregado,0) = 0 then 0 " +
                                       "else case when coalesce(log.usuariogeracao,'') <> '' and coalesce(log.vistoentrega,0) <> 0 and coalesce(log.vistoencarregado,0) <> 0 then 2 else 1 end end as status, " +
                                  "aca.cnpjcpfinforme, fis.nome, aca.tipopessoainforme, aca.informe, aca.sequenciaextra, aca.obrigacaoextra, aca.parcela, aca.competencia " +
                             "from admcontroleadministrativo aca " + strJoinUsuarios +
                             "join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio " +
                             "join admlogcontroleadministrativo log on log.empresa = aca.empresa and log.competencia = aca.competencia and log.obrigacao = aca.obrigacao and log.exercicio = aca.exercicio and log.parcela = aca.parcela and log.sequenciaextra = aca.sequenciaextra and log.obrigacaoextra = aca.obrigacaoextra and log.tipopessoainforme = aca.tipopessoainforme " +
                            "where " + strWhere + " " +
                              "and coalesce(aca.tipopessoainforme,0) = 2 " +
                         "order by 1, 2, 3 desc, 4, 12"

            strQuery(13) = "select distinct aca.empresa, aca.obrigacao, case when coalesce(por.usuarioenvio,'') <> '' then -1 else 0 end as usuarioenviou, por.mensagem, por.usuarioenvio, por.datahoraenvioinicio, por.datahoraenviofim, " +
                                  "por.empresavisualizou, por.nomeusuarioempresa, por.datahoraempresavisualizou, aca.cnpjcpfinforme, jur.nome, aca.tipopessoainforme, aca.informe, aca.sequenciaextra, aca.obrigacaoextra, aca.parcela, aca.competencia  " +
                             "from admcontroleadministrativo aca " + strJoinUsuarios +
                             "join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio " +
                             "join admcontroleadministrativoportalarquivos por on por.empresa = aca.empresa and por.competencia = aca.competencia and por.obrigacao = aca.obrigacao and por.exercicio = aca.exercicio and por.parcela = aca.parcela and por.sequenciaextra = aca.sequenciaextra and por.obrigacaoextra = aca.obrigacaoextra and por.tipopessoainforme = aca.tipopessoainforme and por.informe = aca.informe " +
                             "join ""#" + usuarioInfo.usuario.ToString + "_informe_tmp"" log on log.empresa = por.empresa and log.competencia = por.competencia and log.obrigacao = por.obrigacao and log.exercicio = por.exercicio and log.parcela = por.parcela and log.sequenciaextra = por.sequenciaextra and log.obrigacaoextra = por.obrigacaoextra and log.tipopessoainforme = por.tipopessoainforme and log.flag = 14 " +
                            "where " + strWhere + " " +
                              "and coalesce(aca.tipopessoainforme,0) = 1 "
            strQuery(13) += "union all "
            strQuery(13) += "select distinct aca.empresa, aca.obrigacao, case when coalesce(por.usuarioenvio,'') <> '' then -1 else 0 end as usuarioenviou, por.mensagem, por.usuarioenvio, por.datahoraenvioinicio, por.datahoraenviofim, " +
                                  "por.empresavisualizou, por.nomeusuarioempresa, por.datahoraempresavisualizou, aca.cnpjcpfinforme, fis.nome, aca.tipopessoainforme, aca.informe, aca.sequenciaextra, aca.obrigacaoextra, aca.parcela, aca.competencia  " +
                             "from admcontroleadministrativo aca " + strJoinUsuarios +
                             "join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio " +
                             "join admcontroleadministrativoportalarquivos por on por.empresa = aca.empresa and por.competencia = aca.competencia and por.obrigacao = aca.obrigacao and por.exercicio = aca.exercicio and por.parcela = aca.parcela and por.sequenciaextra = aca.sequenciaextra and por.obrigacaoextra = aca.obrigacaoextra and por.tipopessoainforme = aca.tipopessoainforme and por.informe = aca.informe " +
                             "join ""#" + usuarioInfo.usuario.ToString + "_informe_tmp"" log on log.empresa = por.empresa and log.competencia = por.competencia and log.obrigacao = por.obrigacao and log.exercicio = por.exercicio and log.parcela = por.parcela and log.sequenciaextra = por.sequenciaextra and log.obrigacaoextra = por.obrigacaoextra and log.tipopessoainforme = por.tipopessoainforme and log.flag = 14 " +
                            "where " + strWhere + " " +
                              "and coalesce(aca.tipopessoainforme,0) = 2 "
            strQuery(13) += "union all "
            strQuery(13) += "select distinct aca.empresa, aca.obrigacao, case when coalesce(por.usuarioenvio,'') <> '' then -1 else 0 end as usuarioenviou, por.mensagem, por.usuarioenvio, por.datahoraenvioinicio, por.datahoraenviofim, " +
                                  "por.empresavisualizou, por.nomeusuarioempresa, por.datahoraempresavisualizou, aca.cnpjcpfinforme, jur.nome, aca.tipopessoainforme, aca.informe, aca.sequenciaextra, aca.obrigacaoextra, aca.parcela, aca.competencia  " +
                             "from admcontroleadministrativo aca " + strJoinUsuarios +
                             "join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio " +
                             "join admcontroleadministrativoportalguias por on por.empresa = aca.empresa and por.competencia = aca.competencia and por.obrigacao = aca.obrigacao and por.exercicio = aca.exercicio and por.parcela = aca.parcela and por.sequenciaextra = aca.sequenciaextra and por.obrigacaoextra = aca.obrigacaoextra and por.tipopessoainforme = aca.tipopessoainforme and por.informe = aca.informe " +
                             "join ""#" + usuarioInfo.usuario.ToString + "_informe_tmp"" log on log.empresa = por.empresa and log.competencia = por.competencia and log.obrigacao = por.obrigacao and log.exercicio = por.exercicio and log.parcela = por.parcela and log.sequenciaextra = por.sequenciaextra and log.obrigacaoextra = por.obrigacaoextra and log.tipopessoainforme = por.tipopessoainforme and log.flag = 14 " +
                            "where " + strWhere + " " +
                              "and coalesce(aca.tipopessoainforme,0) = 1 "
            strQuery(13) += "union all "
            strQuery(13) += "select distinct aca.empresa, aca.obrigacao, case when coalesce(por.usuarioenvio,'') <> '' then -1 else 0 end as usuarioenviou, por.mensagem, por.usuarioenvio, por.datahoraenvioinicio, por.datahoraenviofim, " +
                                  "por.empresavisualizou, por.nomeusuarioempresa, por.datahoraempresavisualizou, aca.cnpjcpfinforme, fis.nome, aca.tipopessoainforme, aca.informe, aca.sequenciaextra, aca.obrigacaoextra, aca.parcela, aca.competencia  " +
                             "from admcontroleadministrativo aca " + strJoinUsuarios +
                             "join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio " +
                             "join admcontroleadministrativoportalguias por on por.empresa = aca.empresa and por.competencia = aca.competencia and por.obrigacao = aca.obrigacao and por.exercicio = aca.exercicio and por.parcela = aca.parcela and por.sequenciaextra = aca.sequenciaextra and por.obrigacaoextra = aca.obrigacaoextra and por.tipopessoainforme = aca.tipopessoainforme and por.informe = aca.informe " +
                             "join ""#" + usuarioInfo.usuario.ToString + "_informe_tmp"" log on log.empresa = por.empresa and log.competencia = por.competencia and log.obrigacao = por.obrigacao and log.exercicio = por.exercicio and log.parcela = por.parcela and log.sequenciaextra = por.sequenciaextra and log.obrigacaoextra = por.obrigacaoextra and log.tipopessoainforme = por.tipopessoainforme and log.flag = 14 " +
                            "where " + strWhere + " " +
                              "and coalesce(aca.tipopessoainforme,0) = 2 " +
                         "order by 1, 2, 14"

            strQuery(14) = "select distinct aca.empresa, aca.obrigacao, log.sequencia, case when coalesce(log.usuarioenvio,'') <> '' then -1 else 0 end as usuarioenviou, log.mensagem, log.usuarioenvio, log.datahoraenvioinicio, log.datahoraenviofim, " +
                                  "log.empresavisualizou, log.nomeusuarioempresa, log.datahoraempresavisualizou, log.usuariolog, log.datahoralog, aca.cnpjcpfinforme, jur.nome, aca.tipopessoainforme, aca.informe, aca.sequenciaextra, aca.obrigacaoextra, aca.parcela, aca.competencia " +
                             "from admcontroleadministrativo aca " + strJoinUsuarios +
                             "join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio " +
                             "join admcontroleadministrativoportalarquivos por on por.empresa = aca.empresa and por.competencia = aca.competencia and por.obrigacao = aca.obrigacao and por.exercicio = aca.exercicio and por.parcela = aca.parcela and por.sequenciaextra = aca.sequenciaextra and por.obrigacaoextra = aca.obrigacaoextra and por.tipopessoainforme = aca.tipopessoainforme and por.informe = aca.informe " +
                             "join admlogcontroleadministrativoportalarquivos log on log.empresa = por.empresa and log.competencia = por.competencia and log.obrigacao = por.obrigacao and log.exercicio = por.exercicio and log.parcela = por.parcela and log.sequenciaextra = por.sequenciaextra and log.obrigacaoextra = por.obrigacaoextra and log.tipopessoainforme = por.tipopessoainforme " +
                            "where " + strWhere + " " +
                              "and coalesce(aca.tipopessoainforme,0) = 1 "
            strQuery(14) += "union all "
            strQuery(14) += "select distinct aca.empresa, aca.obrigacao, log.sequencia, case when coalesce(log.usuarioenvio,'') <> '' then -1 else 0 end as usuarioenviou, log.mensagem, log.usuarioenvio, log.datahoraenvioinicio, log.datahoraenviofim, " +
                                  "log.empresavisualizou, log.nomeusuarioempresa, log.datahoraempresavisualizou, log.usuariolog, log.datahoralog, aca.cnpjcpfinforme, fis.nome, aca.tipopessoainforme, aca.informe, aca.sequenciaextra, aca.obrigacaoextra, aca.parcela, aca.competencia " +
                             "from admcontroleadministrativo aca " + strJoinUsuarios +
                             "join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio " +
                             "join admcontroleadministrativoportalarquivos por on por.empresa = aca.empresa and por.competencia = aca.competencia and por.obrigacao = aca.obrigacao and por.exercicio = aca.exercicio and por.parcela = aca.parcela and por.sequenciaextra = aca.sequenciaextra and por.obrigacaoextra = aca.obrigacaoextra and por.tipopessoainforme = aca.tipopessoainforme and por.informe = aca.informe " +
                             "join admlogcontroleadministrativoportalarquivos log on log.empresa = por.empresa and log.competencia = por.competencia and log.obrigacao = por.obrigacao and log.exercicio = por.exercicio and log.parcela = por.parcela and log.sequenciaextra = por.sequenciaextra and log.obrigacaoextra = por.obrigacaoextra and log.tipopessoainforme = por.tipopessoainforme " +
                            "where " + strWhere + " " +
                              "and coalesce(aca.tipopessoainforme,0) = 2 "
            strQuery(14) += "union all "
            strQuery(14) += "select distinct aca.empresa, aca.obrigacao, log.sequencia, case when coalesce(log.usuarioenvio,'') <> '' then -1 else 0 end as usuarioenviou, log.mensagem, log.usuarioenvio, log.datahoraenvioinicio, log.datahoraenviofim, " +
                                  "log.empresavisualizou, log.nomeusuarioempresa, log.datahoraempresavisualizou, log.usuariolog, log.datahoralog, aca.cnpjcpfinforme, jur.nome, aca.tipopessoainforme, aca.informe, aca.sequenciaextra, aca.obrigacaoextra, aca.parcela, aca.competencia " +
                             "from admcontroleadministrativo aca " + strJoinUsuarios +
                             "join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio " +
                             "join admcontroleadministrativoportalguias por on por.empresa = aca.empresa and por.competencia = aca.competencia and por.obrigacao = aca.obrigacao and por.exercicio = aca.exercicio and por.parcela = aca.parcela and por.sequenciaextra = aca.sequenciaextra and por.obrigacaoextra = aca.obrigacaoextra and por.tipopessoainforme = aca.tipopessoainforme and por.informe = aca.informe " +
                             "join admlogcontroleadministrativoportalguias log on log.empresa = por.empresa and log.competencia = por.competencia and log.obrigacao = por.obrigacao and log.exercicio = por.exercicio and log.parcela = por.parcela and log.sequenciaextra = por.sequenciaextra and log.obrigacaoextra = por.obrigacaoextra and log.tipopessoainforme = por.tipopessoainforme " +
                            "where " + strWhere + " " +
                              "and coalesce(aca.tipopessoainforme,0) = 1 "
            strQuery(14) += "union all "
            strQuery(14) += "select distinct aca.empresa, aca.obrigacao, log.sequencia, case when coalesce(log.usuarioenvio,'') <> '' then -1 else 0 end as usuarioenviou, log.mensagem, log.usuarioenvio, log.datahoraenvioinicio, log.datahoraenviofim, " +
                                  "log.empresavisualizou, log.nomeusuarioempresa, log.datahoraempresavisualizou, log.usuariolog, log.datahoralog, aca.cnpjcpfinforme, fis.nome, aca.tipopessoainforme, aca.informe, aca.sequenciaextra, aca.obrigacaoextra, aca.parcela, aca.competencia " +
                             "from admcontroleadministrativo aca " + strJoinUsuarios +
                             "join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio " +
                             "join admcontroleadministrativoportalguias por on por.empresa = aca.empresa and por.competencia = aca.competencia and por.obrigacao = aca.obrigacao and por.exercicio = aca.exercicio and por.parcela = aca.parcela and por.sequenciaextra = aca.sequenciaextra and por.obrigacaoextra = aca.obrigacaoextra and por.tipopessoainforme = aca.tipopessoainforme and por.informe = aca.informe " +
                             "join admlogcontroleadministrativoportalguias log on log.empresa = por.empresa and log.competencia = por.competencia and log.obrigacao = por.obrigacao and log.exercicio = por.exercicio and log.parcela = por.parcela and log.sequenciaextra = por.sequenciaextra and log.obrigacaoextra = por.obrigacaoextra and log.tipopessoainforme = por.tipopessoainforme " +
                            "where " + strWhere + " " +
                              "and coalesce(aca.tipopessoainforme,0) = 2 " +
                         "order by 1, 2, 3 desc, 21"

            strQueryTemp(0) = "select distinct log.empresa , log.competencia , log.obrigacao , log.exercicio , log.parcela ,log.sequenciaextra , log.obrigacaoextra , log.tipopessoainforme , log.informe, 3 as flag " +
                              "<from> admcontroleadministrativo aca " + strJoinUsuarios +
                                "join admlogcontroleadministrativo log on log.empresa = aca.empresa and log.competencia = aca.competencia and log.obrigacao = aca.obrigacao and log.exercicio = aca.exercicio and log.parcela = aca.parcela and log.sequenciaextra = aca.sequenciaextra and log.obrigacaoextra = aca.obrigacaoextra and log.tipopessoainforme = aca.tipopessoainforme and log.informe = aca.informe " +
                               "where " + strWhere + " " +
                                 "and coalesce(aca.funcionario,'') = '' " +
                                 "and coalesce(aca.tipopessoainforme,0) = 0 " +
                               "union all " +
                              "select distinct por.empresa , por.competencia , por.obrigacao , por.exercicio , por.parcela , por.sequenciaextra , por.obrigacaoextra , por.tipopessoainforme , por.informe , 4 as flag " +
                                "from admcontroleadministrativo aca " + strJoinUsuarios +
                                "join admcontroleadministrativoportalguias por on por.empresa = aca.empresa and por.competencia = aca.competencia and por.obrigacao = aca.obrigacao and por.exercicio = aca.exercicio and por.parcela = aca.parcela and por.sequenciaextra = aca.sequenciaextra and por.obrigacaoextra = aca.obrigacaoextra and por.tipopessoainforme = aca.tipopessoainforme and por.informe = aca.informe " +
                                "join admlogcontroleadministrativoportalguias log on log.empresa = por.empresa and log.competencia = por.competencia and log.obrigacao = por.obrigacao and log.exercicio = por.exercicio and log.parcela = por.parcela and log.sequenciaextra = por.sequenciaextra and log.obrigacaoextra = por.obrigacaoextra and log.tipopessoainforme = por.tipopessoainforme and log.informe = por.informe " +
                               "where " + strWhere + " " +
                                 "and coalesce(aca.funcionario,'') = '' " +
                                 "and coalesce(aca.tipopessoainforme,0) = 0 " +
                               "union all " +
                              "select distinct por.empresa , por.competencia , por.obrigacao , por.exercicio , por.parcela , por.sequenciaextra , por.obrigacaoextra , por.tipopessoainforme , por.informe , 4 as flag " +
                                "from admcontroleadministrativo aca " + strJoinUsuarios +
                                "join admcontroleadministrativoportalarquivos por on por.empresa = aca.empresa and por.competencia = aca.competencia and por.obrigacao = aca.obrigacao and por.exercicio = aca.exercicio and por.parcela = aca.parcela and por.sequenciaextra = aca.sequenciaextra and por.obrigacaoextra = aca.obrigacaoextra and por.tipopessoainforme = aca.tipopessoainforme and por.informe = aca.informe " +
                                "join admlogcontroleadministrativoportalarquivos log on log.empresa = por.empresa and log.competencia = por.competencia and log.obrigacao = por.obrigacao and log.exercicio = por.exercicio and log.parcela = por.parcela and log.sequenciaextra = por.sequenciaextra and log.obrigacaoextra = por.obrigacaoextra and log.tipopessoainforme = por.tipopessoainforme and log.informe = por.informe " +
                               "where " + strWhere + " " +
                                 "and coalesce(aca.funcionario,'') = '' " +
                                 "and coalesce(aca.tipopessoainforme,0) = 0 "

            strQueryTemp(1) = "select distinct log.empresa , log.competencia , log.funcionario , log.obrigacao , log.exercicio , log.parcela , log.sequenciaextra , log.obrigacaoextra , log.tipopessoainforme , log.informe , 7 as flag " +
                              "<from> admcontroleadministrativo aca " + strJoinUsuarios +
                                "join funcionarios f on f.empresa = aca.empresa and f.funcionario = aca.funcionario " +
                                "join admlogcontroleadministrativo log on log.empresa = aca.empresa and log.competencia = aca.competencia and log.funcionario = aca.funcionario and log.obrigacao = aca.obrigacao and log.exercicio = aca.exercicio and log.parcela = aca.parcela and log.sequenciaextra = aca.sequenciaextra and log.obrigacaoextra = aca.obrigacaoextra and log.tipopessoainforme = aca.tipopessoainforme and log.informe = aca.informe " +
                               "where " + strWhere + " " +
                                 "and coalesce(aca.funcionario,'') <> '' " +
                               "union all " +
                              "select distinct log.empresa , log.competencia , log.funcionario , log.obrigacao , log.exercicio , log.parcela , log.sequenciaextra , log.obrigacaoextra , log.tipopessoainforme , log.informe , 9 as flag " +
                                "from admcontroleadministrativo aca " + strJoinUsuarios +
                                "join funcionarios f on f.empresa = aca.empresa and f.funcionario = aca.funcionario " +
                                "join admcontroleadministrativoportalarquivos por on por.empresa = aca.empresa and por.competencia = aca.competencia and por.funcionario = aca.funcionario and por.obrigacao = aca.obrigacao and por.exercicio = aca.exercicio and por.parcela = aca.parcela and por.sequenciaextra = aca.sequenciaextra and por.obrigacaoextra = aca.obrigacaoextra and por.tipopessoainforme = aca.tipopessoainforme and por.informe = aca.informe " +
                                "join admlogcontroleadministrativoportalarquivos log on log.empresa = por.empresa and log.competencia = por.competencia and log.funcionario = por.funcionario and log.obrigacao = por.obrigacao and log.exercicio = por.exercicio and log.parcela = por.parcela and log.sequenciaextra = por.sequenciaextra and log.obrigacaoextra = por.obrigacaoextra and log.tipopessoainforme = por.tipopessoainforme and log.informe = por.informe " +
                               "where " + strWhere + " " +
                                 "and coalesce(aca.funcionario,'') <> '' " +
                               "union all " +
                              "select distinct log.empresa , log.competencia , log.funcionario , log.obrigacao , log.exercicio , log.parcela , log.sequenciaextra , log.obrigacaoextra , log.tipopessoainforme , log.informe , 9 as flag " +
                                "from admcontroleadministrativo aca " + strJoinUsuarios +
                                "join funcionarios f on f.empresa = aca.empresa and f.funcionario = aca.funcionario " +
                                "join admcontroleadministrativoportalguias por on por.empresa = aca.empresa and por.competencia = aca.competencia and por.funcionario = aca.funcionario and por.obrigacao = aca.obrigacao and por.exercicio = aca.exercicio and por.parcela = aca.parcela and por.sequenciaextra = aca.sequenciaextra and por.obrigacaoextra = aca.obrigacaoextra and por.tipopessoainforme = aca.tipopessoainforme and por.informe = aca.informe " +
                                "join admlogcontroleadministrativoportalguias log on log.empresa = por.empresa and log.competencia = por.competencia and log.funcionario = por.funcionario and log.obrigacao = por.obrigacao and log.exercicio = por.exercicio and log.parcela = por.parcela and log.sequenciaextra = por.sequenciaextra and log.obrigacaoextra = por.obrigacaoextra and log.tipopessoainforme = por.tipopessoainforme and log.informe = por.informe " +
                               "where " + strWhere + " " +
                                 "and coalesce(aca.funcionario,'') <> '' "

            strQueryTemp(2) = "select distinct log.empresa , log.competencia , log.obrigacao , log.exercicio , log.parcela , log.sequenciaextra , log.obrigacaoextra , log.tipopessoainforme , log.informe , 12 as flag " +
                                "from admcontroleadministrativo aca " + strJoinUsuarios +
                                "join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio " +
                                "join admlogcontroleadministrativo log on log.empresa = aca.empresa and log.competencia = aca.competencia and log.obrigacao = aca.obrigacao and log.exercicio = aca.exercicio and log.parcela = aca.parcela and log.sequenciaextra = aca.sequenciaextra and log.obrigacaoextra = aca.obrigacaoextra and log.tipopessoainforme = aca.tipopessoainforme " +
                               "where " + strWhere + " " +
                                 "and coalesce(aca.tipopessoainforme,0) = 1 " +
                               "union all " +
                              "select distinct log.empresa , log.competencia , log.obrigacao , log.exercicio , log.parcela , log.sequenciaextra , log.obrigacaoextra , log.tipopessoainforme , log.informe , 12 as flag " +
                                "from admcontroleadministrativo aca " + strJoinUsuarios +
                                "join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio " +
                                "join admlogcontroleadministrativo log on log.empresa = aca.empresa and log.competencia = aca.competencia and log.obrigacao = aca.obrigacao and log.exercicio = aca.exercicio and log.parcela = aca.parcela and log.sequenciaextra = aca.sequenciaextra and log.obrigacaoextra = aca.obrigacaoextra and log.tipopessoainforme = aca.tipopessoainforme " +
                               "where " + strWhere + " " +
                                 "and coalesce(aca.tipopessoainforme,0) = 2 " +
                                 "union all " +
                              "select distinct log.empresa , log.competencia , log.obrigacao , log.exercicio , log.parcela , log.sequenciaextra , log.obrigacaoextra , log.tipopessoainforme , log.informe , 14 as flag " +
                              "<from> admcontroleadministrativo aca " + strJoinUsuarios +
                                "join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio " +
                                "join admcontroleadministrativoportalguias por on por.empresa = aca.empresa and por.competencia = aca.competencia and por.obrigacao = aca.obrigacao and por.exercicio = aca.exercicio and por.parcela = aca.parcela and por.sequenciaextra = aca.sequenciaextra and por.obrigacaoextra = aca.obrigacaoextra and por.tipopessoainforme = aca.tipopessoainforme and por.informe = aca.informe " +
                                "join admlogcontroleadministrativoportalguias log on log.empresa = por.empresa and log.competencia = por.competencia and log.obrigacao = por.obrigacao and log.exercicio = por.exercicio and log.parcela = por.parcela and log.sequenciaextra = por.sequenciaextra and log.obrigacaoextra = por.obrigacaoextra and log.tipopessoainforme = por.tipopessoainforme " +
                               "where " + strWhere + " " +
                                 "and coalesce(aca.tipopessoainforme,0) = 2 " +
                               "union all " +
                              "select distinct log.empresa , log.competencia , log.obrigacao , log.exercicio , log.parcela , log.sequenciaextra , log.obrigacaoextra , log.tipopessoainforme , log.informe , 14 as flag " +
                                "from admcontroleadministrativo aca " + strJoinUsuarios +
                                "join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio " +
                                "join admcontroleadministrativoportalguias por on por.empresa = aca.empresa and por.competencia = aca.competencia and por.obrigacao = aca.obrigacao and por.exercicio = aca.exercicio and por.parcela = aca.parcela and por.sequenciaextra = aca.sequenciaextra and por.obrigacaoextra = aca.obrigacaoextra and por.tipopessoainforme = aca.tipopessoainforme and por.informe = aca.informe " +
                                "join admlogcontroleadministrativoportalguias log on log.empresa = por.empresa and log.competencia = por.competencia and log.obrigacao = por.obrigacao and log.exercicio = por.exercicio and log.parcela = por.parcela and log.sequenciaextra = por.sequenciaextra and log.obrigacaoextra = por.obrigacaoextra and log.tipopessoainforme = por.tipopessoainforme " +
                               "where " + strWhere + " " +
                                 "and coalesce(aca.tipopessoainforme,0) = 1 " +
                               "union all " +
                              "select distinct log.empresa , log.competencia , log.obrigacao , log.exercicio , log.parcela , log.sequenciaextra , log.obrigacaoextra , log.tipopessoainforme , log.informe , 14 as flag " +
                                "from admcontroleadministrativo aca " + strJoinUsuarios +
                                "join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio " +
                                "join admcontroleadministrativoportalarquivos por on por.empresa = aca.empresa and por.competencia = aca.competencia and por.obrigacao = aca.obrigacao and por.exercicio = aca.exercicio and por.parcela = aca.parcela and por.sequenciaextra = aca.sequenciaextra and por.obrigacaoextra = aca.obrigacaoextra and por.tipopessoainforme = aca.tipopessoainforme and por.informe = aca.informe " +
                                "join admlogcontroleadministrativoportalarquivos log on log.empresa = por.empresa and log.competencia = por.competencia and log.obrigacao = por.obrigacao and log.exercicio = por.exercicio and log.parcela = por.parcela and log.sequenciaextra = por.sequenciaextra and log.obrigacaoextra = por.obrigacaoextra and log.tipopessoainforme = por.tipopessoainforme " +
                               "where " + strWhere + " " +
                                 "and coalesce(aca.tipopessoainforme,0) = 2 " +
                               "union all " +
                              "select distinct log.empresa , log.competencia , log.obrigacao , log.exercicio , log.parcela , log.sequenciaextra , log.obrigacaoextra , log.tipopessoainforme , log.informe , 14 as flag " +
                                "from admcontroleadministrativo aca " + strJoinUsuarios +
                                "join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio " +
                                "join admcontroleadministrativoportalarquivos por on por.empresa = aca.empresa and por.competencia = aca.competencia and por.obrigacao = aca.obrigacao and por.exercicio = aca.exercicio and por.parcela = aca.parcela and por.sequenciaextra = aca.sequenciaextra and por.obrigacaoextra = aca.obrigacaoextra and por.tipopessoainforme = aca.tipopessoainforme and por.informe = aca.informe " +
                                "join admlogcontroleadministrativoportalarquivos log on log.empresa = por.empresa and log.competencia = por.competencia and log.obrigacao = por.obrigacao and log.exercicio = por.exercicio and log.parcela = por.parcela and log.sequenciaextra = por.sequenciaextra and log.obrigacaoextra = por.obrigacaoextra and log.tipopessoainforme = por.tipopessoainforme " +
                               "where " + strWhere + " " +
                                 "and coalesce(aca.tipopessoainforme,0) = 1 "

            objDataBase.CriaTemporaria("#" + usuarioInfo.usuario.ToString + "_empresas_tmp", strQueryTemp(0))
            objDataBase.CriaTemporaria("#" + usuarioInfo.usuario.ToString + "_funcionario_tmp", strQueryTemp(1))
            objDataBase.CriaTemporaria("#" + usuarioInfo.usuario.ToString + "_informe_tmp", strQueryTemp(2))

            objMonitoramentoLog.Grid(strQuery, monitoramentologGridControl, monitoramentologGridView,
                                               monitoramentologempresaGridView, logempresaGridView, portalempresaGridView, logportalempresaGridView,
                                               monitoramentologfuncionarioGridView, detalhefuncionarioGridView, logdetalhefuncionarioGridView, portaldetalhefuncionarioGridView, logportaldetalhefuncionarioGridView,
                                               monitoramentologinformeGridView, detalheinformeGridView, logdetalheinformeGridView, portaldetalheinformeGridView, logportaldetalheinformeGridView,
                                               statusImageCollection, envioImageCollection, empresavisualizouImageCollection)

            objDataBase.ApagarTemporaria("""#" + usuarioInfo.usuario.ToString + "_empresas_tmp""")
            objDataBase.ApagarTemporaria("""#" + usuarioInfo.usuario.ToString + "_funcionario_tmp""")
            objDataBase.ApagarTemporaria("""#" + usuarioInfo.usuario.ToString + "_informe_tmp""")
            SplashScreenManager.CloseForm()
        Catch ex As Exception
            objDataBase.ApagarTemporaria("""#" + usuarioInfo.usuario.ToString + "_empresas_tmp""")
            objDataBase.ApagarTemporaria("""#" + usuarioInfo.usuario.ToString + "_funcionario_tmp""")
            objDataBase.ApagarTemporaria("""#" + usuarioInfo.usuario.ToString + "_informe_tmp""")
            SplashScreenManager.CloseForm()
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AtivaNavegador(pblnAtivaNavegacao As Boolean)
        navegadorPanelControl.Visible = pblnAtivaNavegacao
        If pblnAtivaNavegacao Then
            monitoramentologGridControl.Size = New System.Drawing.Size(1329, 595)
        Else
            monitoramentologGridControl.Size = New System.Drawing.Size(1329, 624)
        End If
    End Sub
End Class