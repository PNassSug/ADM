Imports Administrativo.Modelo
Imports DevExpress.XtraEditors

Public Class selecionarcompetenciaXtraForm

    Private Sub selecionarcompetenciaXtraForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim intCompetenciaFinal As Int32 = 0
        If Now.Year = administrativoInfo.Exercicio Then
            If Now.Month = 12 Then
                intCompetenciaFinal = Now.Month
            Else
                intCompetenciaFinal = Now.AddDays(7).Month
            End If
        Else
            intCompetenciaFinal = 12
        End If
        Try
            For intCompetenciaInicial = 1 To intCompetenciaFinal
                competenciaComboBoxEdit.Properties.Items.Add(MonthName(intCompetenciaInicial))
            Next
        Finally
            If Not String.IsNullOrEmpty(administrativoInfo.Competencia) Then
                competenciaComboBoxEdit.EditValue = MonthName(Convert.ToInt32(administrativoInfo.Competencia.Substring(0, 2))).ToString
            Else
                competenciaComboBoxEdit.EditValue = MonthName(Now.Month).ToString
            End If
        End Try
    End Sub

    Private Sub cancelarSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles cancelarSimpleButton.Click
        Me.Close()
    End Sub

    Private Sub okSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles okSimpleButton.Click
        Try
            If Not String.IsNullOrEmpty(competenciaComboBoxEdit.Text.ToString) Then
                If Convert.ToString(competenciaComboBoxEdit.SelectedIndex + 1).Length = 1 Then
                    administrativoInfo.Competencia = "0" + Convert.ToString(competenciaComboBoxEdit.SelectedIndex + 1)
                Else
                    administrativoInfo.Competencia = Convert.ToString(competenciaComboBoxEdit.SelectedIndex + 1)
                End If
                administrativoInfo.Competencia = administrativoInfo.Competencia + administrativoInfo.Exercicio.ToString
                Me.Close()
            Else
                XtraMessageBox.Show("Exercício inválido", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class