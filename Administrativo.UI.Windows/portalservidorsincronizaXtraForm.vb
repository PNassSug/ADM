Imports Administrativo.BLL
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraEditors

Public Class portalservidorsincronizaXtraForm
    Dim objPortalServidor As New PortalServidorBLL

    Private Sub voltarSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles voltarSimpleButton.Click
        Me.Close()
    End Sub

    Private Sub sincronizarSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles sincronizarSimpleButton.Click
        Try
            SplashScreenManager.ShowForm(Me, GetType(aguardeWaitForm), True, True, False)
            objPortalServidor.SincronizarPortalServidor(Convert.ToBoolean(empresasCheckEdit.EditValue),
                                                        Convert.ToBoolean(obrigacoesCheckEdit.EditValue),
                                                        Convert.ToBoolean(usuariosempresasCheckEdit.EditValue),
                                                        Convert.ToBoolean(usuariosescritoriosCheckEdit.EditValue))
            SplashScreenManager.CloseForm()
            XtraMessageBox.Show("Sincronização efetuada com sucesso.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            SplashScreenManager.CloseForm()
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class