Imports Administrativo.Modelo
Imports Administrativo.BLL
Imports DevExpress.XtraEditors

Public Class selecionarusuarioXtraForm
    Dim objUsuario As New UsuarioBLL

    Public Sub New()
        InitializeComponent()
        If Not String.IsNullOrEmpty(Environment.UserName) Then
            If Environment.UserName.Length > 10 Then
                usuarioTextEdit.Text = Environment.UserName.Substring(0, 10)
            Else
                usuarioTextEdit.Text = Environment.UserName.ToString
            End If
        End If
    End Sub

    Private Sub cancelarSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles cancelarSimpleButton.Click
        Me.Close()
    End Sub

    Private Sub okSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles okSimpleButton.Click
        Try
            If (String.IsNullOrEmpty(usuarioInfo.usuario)) Then
                usuarioInfo.logado = objUsuario.LoginValido(usuarioTextEdit.Text, senhaTextEdit.Text)
            Else
                If usuarioInfo.usuario = usuarioTextEdit.Text Then
                    Throw New Exception("Usuário já logado.")
                End If
                objUsuario.LoginValido(usuarioTextEdit.Text, senhaTextEdit.Text)
            End If

            If usuarioInfo.logado Then
                Me.Close()
            Else
                XtraMessageBox.Show("Login ou senha incorretos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                senhaTextEdit.SelectAll()
                senhaTextEdit.Focus()
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class