Imports Administrativo.DAL

Public Class RegistroBLL
    Dim obj As New RegistroDAL

    Public Function LocalizaChaveRegistro(pNomeRegistro As String, pNomeChave As String, pNome As String) As String
        Try
            Return obj.LocalizaChaveRegistro(pNomeRegistro, pNomeChave, pNome)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Sub GravaChaveRegistro(pNomeRegistro As String, pNomeChave As String, pNome As String, pValor As String)
        Try
            obj.GravaChaveRegistro(pNomeRegistro, pNomeChave, pNome, pValor)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

End Class
