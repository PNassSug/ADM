
Public Interface IPortalServidor
    Sub IUDPortalServidor(ByRef pstrRazaoSocial As String, ByRef pstrCnpjCpf As String, ByRef pstrDDD As String, ByRef pstrTelefone As String, ByRef pstrServidor As String)
    Sub SincronizarPortalServidor(ByRef pblnEmpresas As Boolean, ByRef pblnObrigacoes As Boolean, ByRef pblnUsuariosEmpresas As Boolean, ByRef pblnUsuariosEscritorios As Boolean)
    Sub BuscaConfiguracaoPortalServidor()
End Interface
