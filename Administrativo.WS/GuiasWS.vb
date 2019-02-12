Imports Administrativo.Modelo

Public Class GuiasWS
    Dim ws As New portal.guias.Guias

    Public Function Guias(pstrDados As String, infoGuias As manutencaoobrigacoesInfo) As Boolean
        Try
            Dim strMsgErro As String = String.Empty
            Dim blnRetorno As Boolean = False
            If String.IsNullOrEmpty(infoGuias.portalguias(0).usuarioenvio) Then
                infoGuias.portalguias(0).usuarioenvio = usuarioInfo.usuario
            End If
            Dim strRetorno As String = ws.CadastraGuia(portalservidorInfo.cnpjcpf, infoGuias.portalguias(0).usuarioenvio, infoGuias.empresa, infoGuias.obrigacao, infoGuias.competencia, infoGuias.parcela, infoGuias.sequenciaextra, infoGuias.obrigacaoextra, infoGuias.tipopessoainforme, infoGuias.informe, infoGuias.portalguias(0).datavencimento, infoGuias.portalguias(0).mensagem.Replace(vbCrLf, "<br>"), pstrDados)
            blnRetorno = (strRetorno.ToUpper = "OK")
            If Not blnRetorno Then
                strMsgErro = "Empresa: " + infoGuias.empresa.Substring(0, 2) + "." + infoGuias.empresa.Substring(2, 4) + " "
                strMsgErro += "Competência: " + infoGuias.competencia.Substring(0, 2) + "/" + infoGuias.competencia.Substring(2, 4) + " "
                strMsgErro += "Obrigação: " + infoGuias.obrigacao.Substring(0, 1) + "-" + infoGuias.obrigacao.Substring(1, 5) + " "
                If infoGuias.datavencimento.HasValue Then
                    strMsgErro += "Data Vencimento: " + infoGuias.datavencimento.ToString.Substring(0, 10) + " "
                End If
                If Not String.IsNullOrEmpty(infoGuias.funcionario) Then
                    strMsgErro += "Funcionário: " + infoGuias.funcionario + " "
                End If
                If infoGuias.tipopessoainforme > 0 Then
                    strMsgErro += "CNPJ/CPF: "
                    If infoGuias.cnpjcpfinforme.Length = 11 Then
                        strMsgErro += infoGuias.cnpjcpfinforme.Substring(0, 3) + "." +
                                      infoGuias.cnpjcpfinforme.Substring(3, 3) + "." +
                                      infoGuias.cnpjcpfinforme.Substring(6, 3) + "-" +
                                      infoGuias.cnpjcpfinforme.Substring(9, 2) + " "
                    ElseIf infoGuias.cnpjcpfinforme.Length = 14 Then
                        strMsgErro += infoGuias.cnpjcpfinforme.Substring(0, 2) + "." +
                                      infoGuias.cnpjcpfinforme.Substring(2, 3) + "." +
                                      infoGuias.cnpjcpfinforme.Substring(5, 3) + "-" +
                                      infoGuias.cnpjcpfinforme.Substring(8, 4) + "/" +
                                      infoGuias.cnpjcpfinforme.Substring(12, 2) + " "
                    End If
                End If
                strMsgErro = strMsgErro.Substring(0, strMsgErro.Length - 1)
            End If
            If Not blnRetorno Then Throw New Exception(strRetorno + Environment.NewLine +
                                                       "WebService: Envio das Obrigações para as Empresas " + Environment.NewLine +
                                                       "[" + strMsgErro + "]")
            Return blnRetorno
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function LogGuias(ByRef pstrEmails As String, infoGuias As manutencaoobrigacoesInfo) As String
        Try
            Return ws.LogGuia(portalservidorInfo.cnpjcpf, infoGuias.empresa, infoGuias.obrigacao, infoGuias.competencia, infoGuias.parcela, infoGuias.sequenciaextra, infoGuias.obrigacaoextra, infoGuias.tipopessoainforme, infoGuias.informe, pstrEmails)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class