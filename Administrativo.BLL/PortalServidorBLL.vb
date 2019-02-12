Imports Administrativo.DAL

Public Class PortalServidorBLL
    Implements IPortalServidor

    Dim objPortalServidor As New PortalServidorDAL

    Public Sub BuscaConfiguracaoPortalServidor() Implements DAL.IPortalServidor.BuscaConfiguracaoPortalServidor
        Try
            objPortalServidor.BuscaConfiguracaoPortalServidor()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub IUDPortalServidor(ByRef pstrRazaoSocial As String, ByRef pstrCnpjCpf As String, ByRef pstrDDD As String, ByRef pstrTelefone As String, ByRef pstrServidor As String) Implements DAL.IPortalServidor.IUDPortalServidor
        Try
            If String.IsNullOrEmpty(pstrCnpjCpf) Then Throw New Exception("O CNPJ/CPF deve ser preenchido")
            objPortalServidor.IUDPortalServidor(pstrRazaoSocial, pstrCnpjCpf, pstrDDD, pstrTelefone, pstrServidor)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub SincronizarPortalServidor(ByRef pblnEmpresas As Boolean, ByRef pblnObrigacoes As Boolean, ByRef pblnUsuariosEmpresas As Boolean, ByRef pblnUsuariosEscritorios As Boolean) Implements DAL.IPortalServidor.SincronizarPortalServidor
        Try
            If Not pblnEmpresas And Not pblnObrigacoes And Not pblnUsuariosEmpresas And Not pblnUsuariosEscritorios Then Throw New Exception("Deve ser selecionado pelo menos um item para sincronização")
            objPortalServidor.SincronizarPortalServidor(pblnEmpresas, pblnObrigacoes, pblnUsuariosEmpresas, pblnUsuariosEscritorios)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class
