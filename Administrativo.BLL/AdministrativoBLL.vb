Imports Administrativo.DAL

Public Class AdministrativoBLL
    Implements IAdministrativo

    Dim objAdministrativo As New AdministrativoDAL

    Public Sub CentralizaForm(pForm As System.Windows.Forms.Control) Implements DAL.IAdministrativo.CentralizaForm
        Try
            objAdministrativo.CentralizaForm(pForm)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub VerificaVersao() Implements DAL.IAdministrativo.VerificaVersao
        Try
            objAdministrativo.VerificaVersao()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class
