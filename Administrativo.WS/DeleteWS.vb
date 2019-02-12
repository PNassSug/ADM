Imports Administrativo.Modelo

Public Class DeleteWS
    Dim ws As New portal.excluir.Exclui
    Dim objConsulta As New SelectWS

    Public Function EscritorioExclui(ByRef pstrCnpjCpf As String) As Boolean
        Try
            Dim blnRetorno As Boolean = False
            Dim strCNPJCPF As String = String.Empty
            Dim strRetorno As String = "Escritório inexistente"
            If objConsulta.EscritorioExiste(pstrCnpjCpf) Then
                strRetorno = ws.ExcluiEscritorios(pstrCnpjCpf)
                blnRetorno = (strRetorno.ToUpper = "OK")
            End If

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
                                                       "WebService: Exclusão dos dados do Escritório no Portal " + Environment.NewLine +
                                                       "[CNPJ/CPF: " + strCNPJCPF + "]")
            Return blnRetorno
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function EmpresaExclui(ByRef pstrEmpresa As String) As Boolean
        Try
            Dim blnRetorno As Boolean = False
            Dim strRetorno As String = "Empresa inexistente"
            If objConsulta.EmpresaExiste(pstrEmpresa) Then
                strRetorno = ws.ExcluiEmpresas(portalservidorInfo.cnpjcpf, pstrEmpresa)
                blnRetorno = (strRetorno.ToUpper = "OK")
            End If
            If Not blnRetorno Then Throw New Exception(strRetorno + Environment.NewLine +
                                                       "WebService: Exclusão dos dados do Cadastro de Obrigações das Empresas " + Environment.NewLine +
                                                       "[Empresa: " + pstrEmpresa.Substring(0, 2) + "." + pstrEmpresa.Substring(2, 4) + "]")
            Return blnRetorno
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ObrigacaoExclui(ByRef pstrObrigacao As String) As Boolean
        Try
            Dim blnRetorno As Boolean = False
            Dim strRetorno As String = "Obrigação inexistente"
            If objConsulta.ObrigacaoExiste(pstrObrigacao) Then
                strRetorno = ws.ExcluiObrigacoes(portalservidorInfo.cnpjcpf, pstrObrigacao)
                blnRetorno = (strRetorno.ToUpper = "OK")
            End If
            If Not blnRetorno Then Throw New Exception(strRetorno + Environment.NewLine +
                                                       "WebService: Exclusão dos dados do Cadastro de Obrigações " + Environment.NewLine +
                                                       "[Obrigação: " + pstrObrigacao.Substring(0, 1) + "." + pstrObrigacao.Substring(1, 5) + "]")
            Return blnRetorno
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function UsuarioEmpresaExclui(ByRef pstrEmpresa As String, ByRef pstrEmail As String) As Boolean
        Try
            Dim blnRetorno As Boolean = False
            Dim strRetorno As String = "Usuário da Empresa inexistente"
            If objConsulta.UsuarioEmpresaExiste(pstrEmpresa, pstrEmail) Then
                strRetorno = ws.ExcluiUsuarioEmpresa(portalservidorInfo.cnpjcpf, pstrEmpresa, pstrEmail)
                blnRetorno = (strRetorno.ToUpper = "OK")
            End If
            If Not blnRetorno Then Throw New Exception(strRetorno + Environment.NewLine +
                                                       "WebService: Exclusão dos dados do Cadastro de Usuários das Empresas " + Environment.NewLine +
                                                       "[Empresa: " + pstrEmpresa.Substring(0, 2) + "." + pstrEmpresa.Substring(2, 4) + " Email: " + pstrEmail + "]")
            Return blnRetorno
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function UsuarioEscritorioExclui(ByRef pstrLogin As String) As Boolean
        Try
            Dim blnRetorno As Boolean = False
            Dim strRetorno As String = "Usuário do Escritório inexistente"
            If objConsulta.UsuarioEscritorioExiste(pstrLogin) Then
                strRetorno = ws.ExcluiUsuarioEscritorio(portalservidorInfo.cnpjcpf, pstrLogin)
                blnRetorno = (strRetorno.ToUpper = "OK")
            End If
            If Not blnRetorno Then Throw New Exception(strRetorno + Environment.NewLine +
                                                       "WebService: Exclusão dos dados do Cadastro de Usuários dos Escritórios " + Environment.NewLine +
                                                       "[Login: " + pstrLogin + "]")
            Return blnRetorno
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function EmpresaUsuarioObrigacaoExclui(ByRef pstrEmpresa As String, ByRef pstrEmail As String, ByRef pstrObrigacao As String) As Boolean
        Try
            Dim blnRetorno As Boolean = False
            Dim strRetorno As String = "Obrigação do Usuário da Empresa inexistente"
            If objConsulta.EmpresaUsuarioObrigacaoExiste(pstrEmpresa, pstrObrigacao, pstrEmail) Then
                strRetorno = ws.ExcluiEmpresaUsuarioObrigacao(portalservidorInfo.cnpjcpf, pstrEmpresa, pstrEmail, pstrObrigacao)
                blnRetorno = (strRetorno.ToUpper = "OK")
            End If
            If Not blnRetorno Then Throw New Exception(strRetorno + Environment.NewLine +
                                                       "WebService: Exclusão dos dados do Cadastro de Obrigações dos Usuários das Empresas " + Environment.NewLine +
                                                       "[Empresa: " + pstrEmpresa.Substring(0, 2) + "." + pstrEmpresa.Substring(2, 4) + " Email: " + pstrEmail + " Obrigação: " + pstrObrigacao.Substring(0, 1) + "." + pstrObrigacao.Substring(1, 5) + "]")
            Return blnRetorno
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
