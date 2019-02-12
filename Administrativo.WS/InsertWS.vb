Imports Administrativo.Modelo

Public Class InsertWS
    Dim ws As New portal.incluir.Cadastros

    Public Function IncluirEscritorio(ByRef pstrCnpjCpf As String, ByRef pstrRazaoSocial As String, ByRef pstrDdd As String, ByRef pstrTelefone As String) As Boolean
        Try
            Dim strCNPJCPF As String = String.Empty
            Dim blnRetorno As Boolean = False
            Dim strRetorno As String = ws.CadastraEscritorio(pstrCnpjCpf, pstrRazaoSocial, pstrDdd, pstrTelefone)
            blnRetorno = (strRetorno.ToUpper = "OK")
            If Not blnRetorno Then
                If pstrCnpjCpf.Length = 11 Then
                    strCNPJCPF = pstrCnpjCpf.Substring(0, 3) + "." +
                                 pstrCnpjCpf.Substring(3, 3) + "." +
                                 pstrCnpjCpf.Substring(6, 3) + "-" +
                                 pstrCnpjCpf.Substring(9, 2) + " "
                ElseIf pstrCnpjCpf.Length = 14 Then
                    strCNPJCPF = pstrCnpjCpf.Substring(0, 2) + "." +
                                 pstrCnpjCpf.Substring(2, 3) + "." +
                                 pstrCnpjCpf.Substring(5, 3) + "-" +
                                 pstrCnpjCpf.Substring(8, 4) + "/" +
                                 pstrCnpjCpf.Substring(12, 2) + " "
                End If
            End If
            If Not blnRetorno Then Throw New Exception(strRetorno + Environment.NewLine +
                                                       "WebService: Inclusão dos dados do Escritório no Portal " + Environment.NewLine +
                                                       "[CNPJ/CPF: " + strCNPJCPF + " Razão Social: " + pstrRazaoSocial + "]")
            Return blnRetorno
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function IncluirEmpresas(ByRef pstrEmpresa As String, ByRef pstrRazaoSocial As String, ByRef pstrCnpjCpf As String) As Boolean
        Try
            Dim strCNPJCPF As String = String.Empty
            Dim blnRetorno As Boolean = False
            Dim strRetorno As String = ws.CadastraEmpresa(portalservidorInfo.cnpjcpf, pstrEmpresa, pstrRazaoSocial, pstrCnpjCpf)
            blnRetorno = (strRetorno.ToUpper = "OK")
            If Not blnRetorno Then
                If pstrCnpjCpf.Length = 11 Then
                    strCNPJCPF = pstrCnpjCpf.Substring(0, 3) + "." +
                                 pstrCnpjCpf.Substring(3, 3) + "." +
                                 pstrCnpjCpf.Substring(6, 3) + "-" +
                                 pstrCnpjCpf.Substring(9, 2) + " "
                ElseIf pstrCnpjCpf.Length = 14 Then
                    strCNPJCPF = pstrCnpjCpf.Substring(0, 2) + "." +
                                 pstrCnpjCpf.Substring(2, 3) + "." +
                                 pstrCnpjCpf.Substring(5, 3) + "-" +
                                 pstrCnpjCpf.Substring(8, 4) + "/" +
                                 pstrCnpjCpf.Substring(12, 2) + " "
                End If
            End If
            If Not blnRetorno Then Throw New Exception(strRetorno + Environment.NewLine +
                                                       "WebService: Inclusão dos dados do Cadastro de Obrigações das Empresas " + Environment.NewLine +
                                                       "[Empresa: " + pstrEmpresa.Substring(0, 2) + "." + pstrEmpresa.Substring(2, 4) + " Razão Social: " + pstrRazaoSocial + " CNPJ/CPF: " + strCNPJCPF + "]")
            Return blnRetorno
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function IncluirUsuariosEscritorio(ByRef pstrNome As String, ByRef pstrLogin As String, ByRef pstrSenha As String, ByRef pstrEmail As String) As Boolean
        Try
            Dim blnRetorno As Boolean = False
            Dim strRetorno As String = ws.CadastraUsuarioEscritorio(portalservidorInfo.cnpjcpf, pstrNome, pstrLogin, pstrSenha, pstrEmail)
            blnRetorno = (strRetorno.ToUpper = "OK")
            If Not blnRetorno Then Throw New Exception(strRetorno + Environment.NewLine +
                                                       "WebService: Inclusão dos dados do Cadastro de Usuários dos Escritórios " + Environment.NewLine +
                                                       "[Login: " + pstrLogin + " Nome: " + pstrNome + " Email: " + pstrEmail + "]")
            Return blnRetorno
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function IncluirObrigacoes(ByRef pstrObrigacao As String, ByRef pstrDescricao As String, ByRef pintLayout As Int32) As Boolean
        Try
            Dim blnRetorno As Boolean = False
            Dim strRetorno As String = ws.CadastraObrigacao(portalservidorInfo.cnpjcpf, pstrObrigacao, pintLayout, pstrDescricao)
            blnRetorno = (strRetorno.ToUpper = "OK")
            If Not blnRetorno Then Throw New Exception(strRetorno + Environment.NewLine +
                                                       "WebService: Inclusão dos dados do Cadastro de Obrigações " + Environment.NewLine +
                                                       "[Obrigação: " + pstrObrigacao.Substring(0, 1) + "." + pstrObrigacao.Substring(1, 5) + " Descrição: " + pstrDescricao + "]")
            Return blnRetorno
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function IncluiUsuarioEmpresa(ByRef pstrEmpresa As String, ByRef pstrNome As String, ByRef pstrEmail As String, ByRef pstrDdd As String, ByRef pstrTelefone As String) As Boolean
        Try
            Dim blnRetorno As Boolean = False
            Dim strRetorno As String = ws.CadastraUsuarioEmpresa(portalservidorInfo.cnpjcpf, pstrEmpresa, pstrNome, pstrEmail, pstrDdd, pstrTelefone)
            blnRetorno = (strRetorno.ToUpper = "OK")
            If Not blnRetorno Then Throw New Exception(strRetorno + Environment.NewLine +
                                                       "WebService: Inclusão dos dados do Cadastro de Usuários das Empresas " + Environment.NewLine +
                                                       "[Empresa: " + pstrEmpresa.Substring(0, 2) + "." + pstrEmpresa.Substring(2, 4) + " Email: " + pstrEmail + " Nome: " + pstrNome + "]")
            Return blnRetorno
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function IncluirEmpresaUsuarioObrigacoes(ByRef pstrEmpresa As String, ByRef pstrObrigacao As String, ByRef pstrEmail As String) As Boolean
        Try
            Dim blnRetorno As Boolean = False
            Dim strRetorno As String = ws.CadastroEmpresaUsuarioObrigacao(portalservidorInfo.cnpjcpf, pstrEmpresa, pstrEmail, pstrObrigacao)
            blnRetorno = (strRetorno.ToUpper = "OK")
            If Not blnRetorno Then Throw New Exception(strRetorno + Environment.NewLine +
                                                       "WebService: Inclusão dos dados do Cadastro de Obrigações dos Usuários das Empresas " + Environment.NewLine +
                                                       "[Empresa: " + pstrEmpresa.Substring(0, 2) + "." + pstrEmpresa.Substring(2, 4) + " Email: " + pstrEmail + " Obrigação: " + pstrObrigacao.Substring(0, 1) + "." + pstrObrigacao.Substring(1, 5) + "]")
            Return blnRetorno
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
