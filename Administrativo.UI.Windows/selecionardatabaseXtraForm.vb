Imports Administrativo.Modelo
Imports Administrativo.BLL
Imports DevExpress.XtraEditors

Imports DevExpress.XtraSplashScreen

Public Class selecionardatabaseXtraForm
    Dim objDataBase As New DataBaseBLL

    Private Sub selecionardatabaseXtraForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        BuscaBancoDados()
    End Sub

    Private Sub okSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles okSimpleButton.Click
      Dim objRegistro As New RegistroBLL
      databaseInfo.Tipo = "POSTGRES"
      databaseInfo.Server = servidorPOSTGRESTextEdit.Text
      databaseInfo.Porta = portaPOSTGRESTextEdit.Text
      databaseInfo.Usuario = usuarioPOSTGRESTextEdit.Text
      databaseInfo.Senha = senhaPOSTGRESTextEdit.Text
      databaseInfo.BancoDados = bancodadosPOSTGRESComboBoxEdit.Text
      databaseInfo.Conexao = True
      objRegistro.GravaChaveRegistro("Software", Application.ProductName, "DataBase",
                                    databaseInfo.Conexao.ToString() + "|" + databaseInfo.Tipo + "|" + databaseInfo.Server + "|" +
                                    databaseInfo.Porta + "|" + databaseInfo.Usuario + "|" +
                                    databaseInfo.Senha + "|" + databaseInfo.BancoDados)
      Me.Close()
   End Sub

    Private Sub cancelarSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles cancelarSimpleButton.Click
        Me.Close()
    End Sub

    Private Sub POSTGRESSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles POSTGRESSimpleButton.Click
        Try
            SplashScreenManager.ShowForm(Me, GetType(aguardeWaitForm), True, True, False)
            objDataBase.RefreshDataBase(bancodadosPOSTGRESComboBoxEdit, servidorPOSTGRESTextEdit.Text, usuarioPOSTGRESTextEdit.Text, senhaPOSTGRESTextEdit.Text, portaPOSTGRESTextEdit.Text)
            SplashScreenManager.CloseForm()
            bancodadosPOSTGRESComboBoxEdit.Focus()
            If bancodadosPOSTGRESComboBoxEdit.SelectedIndex < 0 Then
                bancodadosPOSTGRESComboBoxEdit.EditValue = Nothing
            End If
        Catch ex As Exception
            SplashScreenManager.CloseForm()
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

   Private Sub BuscaBancoDados()
      Try
         If databaseInfo.Tipo <> String.Empty Then
            servidorPOSTGRESTextEdit.Text = databaseInfo.Server
            If databaseInfo.Porta <> String.Empty Then
               portaPOSTGRESTextEdit.Text = databaseInfo.Porta
            End If
            usuarioPOSTGRESTextEdit.Text = databaseInfo.Usuario
            senhaPOSTGRESTextEdit.Text = databaseInfo.Senha
            bancodadosPOSTGRESComboBoxEdit.EditValue = databaseInfo.BancoDados

            SplashScreenManager.ShowForm(Me, GetType(aguardeWaitForm), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Banco de Dados")
            SplashScreenManager.Default.SetWaitFormDescription("Buscando configurações")
            objDataBase.RefreshDataBase(bancodadosPOSTGRESComboBoxEdit, databaseInfo.Server, databaseInfo.Usuario, databaseInfo.Senha, databaseInfo.Porta)
            SplashScreenManager.CloseForm()
         End If
      Catch ex As Exception
         SplashScreenManager.CloseForm()
         XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
   End Sub
End Class