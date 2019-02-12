Imports Administrativo.Modelo
Imports Administrativo.BLL
Imports DevExpress.XtraEditors

Public Class filtroXtraForm
    Dim objRegistro As New RegistroBLL
    Dim objFiltro As New FiltroBLL

    Public Sub New()
        InitializeComponent()
        BuscaFiltroDefault()
    End Sub

    Private Sub filtroRadioGroup_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles filtroRadioGroup.SelectedIndexChanged
        If filtroRadioGroup.Text = "GERADOR" Then
            filtroSplitContainerControl.PanelVisibility = SplitPanelVisibility.Panel1
            competenciaTextEdit.EditValue = administrativoInfo.Competencia
        Else
            filtroSplitContainerControl.PanelVisibility = SplitPanelVisibility.Panel2
            vencimentoRadioGroup.EditValue = "DIAS"
            diasTextEdit.EditValue = 1
        End If
    End Sub

    Private Sub vencimentoRadioGroup_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles vencimentoRadioGroup.SelectedIndexChanged
        If vencimentoRadioGroup.Text = "DIAS" Then
            vencimentoSplitContainerControl.PanelVisibility = SplitPanelVisibility.Panel1
            diasTextEdit.EditValue = 1
        Else
            vencimentoSplitContainerControl.PanelVisibility = SplitPanelVisibility.Panel2
            datainicialDateEdit.EditValue = Now.Date
            datafinalDateEdit.EditValue = Now.Date
        End If
    End Sub

    Private Sub BuscaFiltroDefault()
        Try
            If filtroInfo.Filtrado Then
                filtroRadioGroup.EditValue = filtroInfo.Filtrarpor
                If filtroRadioGroup.Text = "GERADOR" Then
                    filtroSplitContainerControl.PanelVisibility = SplitPanelVisibility.Panel1
                    competenciaTextEdit.EditValue = administrativoInfo.Competencia
                ElseIf filtroRadioGroup.Text = "VENCIMENTO" Then
                    filtroSplitContainerControl.PanelVisibility = SplitPanelVisibility.Panel2
                    vencimentoRadioGroup.EditValue = filtroInfo.TipoVencimento
                    If vencimentoRadioGroup.Text = "DIAS" Then
                        vencimentoSplitContainerControl.PanelVisibility = SplitPanelVisibility.Panel1
                        diasTextEdit.EditValue = filtroInfo.Dias
                    ElseIf vencimentoRadioGroup.Text = "PERIODO" Then
                        vencimentoSplitContainerControl.PanelVisibility = SplitPanelVisibility.Panel2
                        datainicialDateEdit.EditValue = filtroInfo.DataInicial
                        datafinalDateEdit.EditValue = filtroInfo.DataFinal
                    End If
                End If
            Else
                filtroRadioGroup.EditValue = "GERADOR"
                filtroSplitContainerControl.PanelVisibility = SplitPanelVisibility.Panel1
                competenciaTextEdit.EditValue = administrativoInfo.Competencia
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub okSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles okSimpleButton.Click
        Try
            Dim intDias As Int32
            Dim datainicial As Nullable(Of DateTime)
            Dim datafinal As Nullable(Of DateTime)
            If Not String.IsNullOrEmpty(diasTextEdit.Text) Then
                intDias = Convert.ToInt32(diasTextEdit.Text)
            End If
            If Not datainicialDateEdit.EditValue Is Nothing Then
                datainicial = Convert.ToDateTime(datainicialDateEdit.EditValue)
            End If
            If Not datafinalDateEdit.EditValue Is Nothing Then
                datafinal = Convert.ToDateTime(datafinalDateEdit.EditValue)
            End If
            objFiltro.GravaFiltro(filtroRadioGroup.Text, vencimentoRadioGroup.Text, intDias, datainicial, datafinal)
            Me.Close()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub voltarSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles voltarSimpleButton.Click
        Me.Close()
    End Sub
End Class