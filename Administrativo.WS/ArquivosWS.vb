Imports Administrativo.Modelo
Imports System.IO

Public Class ArquivosWS
    Dim ws As New portal.arquivos.Arquivos

    Public Function Arquivos(ByRef pbArquivo As Byte(), ByRef infoArquivos As manutencaoobrigacoesInfo) As Boolean
        Try
            Dim strMsgErro As String = String.Empty
            Dim fiArquivo As FileInfo = New FileInfo(infoArquivos.portalarquivos(0).arquivo)
            Dim blnRetorno As Boolean = False
            If String.IsNullOrEmpty(infoArquivos.portalarquivos(0).usuarioenvio) Then
                infoArquivos.portalarquivos(0).usuarioenvio = usuarioInfo.usuario
            End If
            Dim strRetorno As String = ws.CadastraArquivo(portalservidorInfo.cnpjcpf, infoArquivos.portalarquivos(0).usuarioenvio, infoArquivos.empresa, infoArquivos.obrigacao, infoArquivos.competencia, infoArquivos.parcela, infoArquivos.sequenciaextra, infoArquivos.obrigacaoextra, infoArquivos.tipopessoainforme, infoArquivos.informe, infoArquivos.datavencimento, infoArquivos.portalarquivos(0).mensagem.Replace(vbCrLf, "<br>"), pbArquivo, fiArquivo.Extension)
            blnRetorno = (strRetorno.ToUpper = "OK")
            If Not blnRetorno Then
                strMsgErro = "Empresa: " + infoArquivos.empresa.Substring(0, 2) + "." + infoArquivos.empresa.Substring(2, 4) + " "
                strMsgErro += "Competência: " + infoArquivos.competencia.Substring(0, 2) + "/" + infoArquivos.competencia.Substring(2, 4) + " "
                strMsgErro += "Obrigação: " + infoArquivos.obrigacao.Substring(0, 1) + "-" + infoArquivos.obrigacao.Substring(1, 5) + " "
                If infoArquivos.datavencimento.HasValue Then
                    strMsgErro += "Data Vencimento: " + infoArquivos.datavencimento.ToString.Substring(0, 10) + " "
                End If
                If Not String.IsNullOrEmpty(infoArquivos.funcionario) Then
                    strMsgErro += "Funcionário: " + infoArquivos.funcionario + " "
                End If
                If infoArquivos.tipopessoainforme > 0 Then
                    strMsgErro += "CNPJ/CPF: "
                    If infoArquivos.cnpjcpfinforme.Length = 11 Then
                        strMsgErro += infoArquivos.cnpjcpfinforme.Substring(0, 3) + "." +
                                      infoArquivos.cnpjcpfinforme.Substring(3, 3) + "." +
                                      infoArquivos.cnpjcpfinforme.Substring(6, 3) + "-" +
                                      infoArquivos.cnpjcpfinforme.Substring(9, 2) + " "
                    ElseIf infoArquivos.cnpjcpfinforme.Length = 14 Then
                        strMsgErro += infoArquivos.cnpjcpfinforme.Substring(0, 2) + "." +
                                      infoArquivos.cnpjcpfinforme.Substring(2, 3) + "." +
                                      infoArquivos.cnpjcpfinforme.Substring(5, 3) + "-" +
                                      infoArquivos.cnpjcpfinforme.Substring(8, 4) + "/" +
                                      infoArquivos.cnpjcpfinforme.Substring(12, 2) + " "
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

    Public Function LogArquivos(ByRef pstrEmails As String, ByRef infoArquivos As manutencaoobrigacoesInfo) As String
        Try
            Return ws.LogArquivo(portalservidorInfo.cnpjcpf, infoArquivos.empresa, infoArquivos.obrigacao, infoArquivos.competencia, infoArquivos.parcela, infoArquivos.sequenciaextra, infoArquivos.obrigacaoextra, infoArquivos.tipopessoainforme, infoArquivos.informe, pstrEmails)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function DownloadArquivos(ByRef pstrCaminhoDownload As String, ByRef infoArquivos As manutencaoobrigacoesInfo) As String
        Try
            Dim strRetorno As String = String.Empty
            Dim strExtensaoArquivo As String = ws.RetornaExtensao(portalservidorInfo.cnpjcpf, infoArquivos.empresa, infoArquivos.obrigacao, infoArquivos.competencia, infoArquivos.parcela, infoArquivos.sequenciaextra, infoArquivos.obrigacaoextra, infoArquivos.tipopessoainforme, infoArquivos.informe)
            If Not String.IsNullOrEmpty(strExtensaoArquivo) Then
                strExtensaoArquivo = "." + strExtensaoArquivo
                Dim strCaminho As String = pstrCaminhoDownload.Replace("\", "/") + "/" + usuarioInfo.usuario
                Dim strNomeArquivo As String = portalservidorInfo.cnpjcpf + "-" + infoArquivos.empresa + "-" + infoArquivos.obrigacao + "-" + infoArquivos.competencia + "-" + infoArquivos.parcela.ToString + "-" + infoArquivos.sequenciaextra.ToString + "-" + infoArquivos.obrigacaoextra.ToString + "-" + infoArquivos.tipopessoainforme.ToString + "-" + infoArquivos.informe.ToString

                Dim biArquivo As Byte() = ws.RetornaArquivo(portalservidorInfo.cnpjcpf, infoArquivos.empresa, infoArquivos.obrigacao, infoArquivos.competencia, infoArquivos.parcela, infoArquivos.sequenciaextra, infoArquivos.obrigacaoextra, infoArquivos.tipopessoainforme, infoArquivos.informe)

                If Not biArquivo Is Nothing Then
                    If (Not System.IO.Directory.Exists(strCaminho)) Then
                        System.IO.Directory.CreateDirectory(strCaminho)
                    End If
                End If
                If (Not IO.File.Exists(strCaminho + "/" + strNomeArquivo + strExtensaoArquivo)) Then
                    IO.File.Create(strCaminho + "/" + strNomeArquivo + strExtensaoArquivo).Dispose()
                End If
                Using fs As New IO.FileStream(strCaminho + "/" + strNomeArquivo + strExtensaoArquivo, IO.FileMode.Open, IO.FileAccess.ReadWrite, IO.FileShare.Read)
                    fs.Write(biArquivo, 0, biArquivo.Length)
                End Using
                strRetorno = strCaminho + "/" + strNomeArquivo + strExtensaoArquivo
            End If
            Return strRetorno
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
