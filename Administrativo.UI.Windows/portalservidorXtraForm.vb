Imports Administrativo.Modelo
Imports Administrativo.BLL
Imports DevExpress.XtraEditors

Public Class portalservidorXtraForm
    Dim objPortalServidor As New PortalServidorBLL

    Private Sub portalservidorXtraForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Try
            If portalservidorInfo.cnpjcpf.Length = 11 Then
                tipopessoaComboBoxEdit.EditValue = "Física"
            Else
                tipopessoaComboBoxEdit.EditValue = "Jurídica"
            End If
            cnpjcpfTextEdit.EditValue = portalservidorInfo.cnpjcpf
            servidorTextEdit.Text = portalservidorInfo.servidor
            razaosocialTextEdit.Text = portalservidorInfo.razaosocial
            dddTextEdit.EditValue = portalservidorInfo.ddd
            telefoneTextEdit.EditValue = portalservidorInfo.telefone

            cnpjcpfTextEdit.Enabled = String.IsNullOrEmpty(portalservidorInfo.cnpjcpf)
            tipopessoaComboBoxEdit.Enabled = String.IsNullOrEmpty(portalservidorInfo.cnpjcpf)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub okSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles okSimpleButton.Click
        Try
            objPortalServidor.IUDPortalServidor(razaosocialTextEdit.Text, cnpjcpfTextEdit.EditValue.ToString, dddTextEdit.EditValue.ToString, telefoneTextEdit.EditValue.ToString, servidorTextEdit.Text)
            Me.Close()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub voltarSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles voltarSimpleButton.Click
        Me.Close()
    End Sub

    Private Sub tipopessoaComboBoxEdit_EditValueChanged(sender As Object, e As System.EventArgs) Handles tipopessoaComboBoxEdit.EditValueChanged
        If Not String.IsNullOrEmpty(tipopessoaComboBoxEdit.Text) Then
            cnpjcpfTextEdit.EditValue = Nothing
            If tipopessoaComboBoxEdit.Text.Substring(0, 1) = "F" Then
                cnpjcpfTextEdit.Properties.Mask.EditMask = "000.000.000-00"
            Else
                cnpjcpfTextEdit.Properties.Mask.EditMask = "00.000.000/0000-00"
            End If
        End If
    End Sub

    Private Sub telefoneTextEdit_CustomDisplayText(sender As System.Object, e As DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs) Handles telefoneTextEdit.CustomDisplayText
        If Not telefoneTextEdit.EditValue Is Nothing Then
            If telefoneTextEdit.EditValue.ToString.Replace("_", String.Empty).Length = 8 Then
                telefoneTextEdit.Properties.Mask.EditMask = "0000-0000"
            ElseIf telefoneTextEdit.EditValue.ToString.Replace("_", String.Empty).Length = 9 Then
                telefoneTextEdit.Properties.Mask.EditMask = "00000-0000"
            Else
                telefoneTextEdit.Properties.Mask.EditMask = ""
            End If
        End If
    End Sub

    Private Sub sincronizarSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles sincronizarSimpleButton.Click
        Try
            Dim form As portalservidorsincronizaXtraForm = New portalservidorsincronizaXtraForm()
            form.ShowDialog(Me)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class