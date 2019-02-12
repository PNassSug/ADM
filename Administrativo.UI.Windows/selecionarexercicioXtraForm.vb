Imports Administrativo.Modelo
Imports DevExpress.XtraEditors

Public Class selecionarexercicioXtraForm

    Private Sub selecionarexercicioXtraForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim intExercicioFinal As Int32 = Now.AddDays(17).Year
        Try
            For intExercicioInicial = 2013 To intExercicioFinal
                exercicioComboBoxEdit.Properties.Items.Add(intExercicioInicial.ToString)
            Next
        Finally
            If administrativoInfo.Exercicio > 0 Then
                exercicioComboBoxEdit.EditValue = administrativoInfo.Exercicio.ToString
            Else
                exercicioComboBoxEdit.EditValue = Now.Year.ToString
            End If
        End Try
    End Sub

    Private Sub cancelarSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles cancelarSimpleButton.Click
        Me.Close()
    End Sub

    Private Sub okSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles okSimpleButton.Click
        Try
            If Convert.ToInt32(exercicioComboBoxEdit.Text.ToString) > 0 Then
                If administrativoInfo.Exercicio > 0 And administrativoInfo.Exercicio <> Convert.ToInt32(exercicioComboBoxEdit.Text.ToString) Then
                    administrativoInfo.Competencia = String.Empty
                End If
                administrativoInfo.Exercicio = Convert.ToInt32(exercicioComboBoxEdit.Text.ToString)
                Me.Close()
            Else
                XtraMessageBox.Show("Exercício inválido", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class