Imports Administrativo.Modelo
Imports Administrativo.BLL
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraEditors

Public Class portalguiaXtraForm
    Public infoPortalGuia As manutencaoobrigacoesInfo
    Dim objManutencaoObrigacoes As New ManutencaoObrigacoesBLL
    Dim objComum As New ComumBLL
    Dim objMaladireta As New MaladiretaBLL
    Dim blnCarregaTela As Boolean = False

    Private Enum enuPortal
        EscritaDarf
        EscritaGare
        ContabilDarf
        FolhaDarf
        FolhaGps
    End Enum

    Public Sub New(ByRef pinfoPortalGuia As manutencaoobrigacoesInfo)
        InitializeComponent()
        infoPortalGuia = pinfoPortalGuia
        objComum.Browse("select login, nome from usuarios order by login", usuarioInfoBindingSource)
    End Sub

    Private Sub portalguiaXtraForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        blnCarregaTela = True
        If infoPortalGuia.obrigacao = "000041" Or infoPortalGuia.obrigacao = "000042" Then
            CarregaTela(enuPortal.EscritaGare)
        ElseIf infoPortalGuia.obrigacao = "000004" Or infoPortalGuia.obrigacao = "000005" Or infoPortalGuia.obrigacao = "000006" Or infoPortalGuia.obrigacao = "000007" Or
               infoPortalGuia.obrigacao = "000008" Or infoPortalGuia.obrigacao = "000009" Or infoPortalGuia.obrigacao = "000010" Or infoPortalGuia.obrigacao = "000011" Or
               infoPortalGuia.obrigacao = "000018" Or infoPortalGuia.obrigacao = "000019" Or infoPortalGuia.obrigacao = "000020" Or infoPortalGuia.obrigacao = "000021" Or
               infoPortalGuia.obrigacao = "000076" Or infoPortalGuia.obrigacao = "000077" Or infoPortalGuia.obrigacao = "000081" Or infoPortalGuia.obrigacao = "000082" Or
               infoPortalGuia.obrigacao = "000083" Or infoPortalGuia.obrigacao = "000084" Then
            CarregaTela(enuPortal.EscritaDarf)
        ElseIf infoPortalGuia.obrigacao = "000012" Or infoPortalGuia.obrigacao = "000013" Or infoPortalGuia.obrigacao = "000016" Or infoPortalGuia.obrigacao = "000022" Or
               infoPortalGuia.obrigacao = "000055" Or infoPortalGuia.obrigacao = "000056" Or infoPortalGuia.obrigacao = "000057" Or infoPortalGuia.obrigacao = "000104" Then
            CarregaTela(enuPortal.ContabilDarf)
        ElseIf infoPortalGuia.obrigacao = "000014" Or infoPortalGuia.obrigacao = "000015" Or infoPortalGuia.obrigacao = "000017" Or infoPortalGuia.obrigacao = "000039" Or
               infoPortalGuia.obrigacao = "000073" Or infoPortalGuia.obrigacao = "000074" Or infoPortalGuia.obrigacao = "000091" Then
            CarregaTela(enuPortal.FolhaDarf)
        ElseIf infoPortalGuia.obrigacao = "000038" Or infoPortalGuia.obrigacao = "000043" Or infoPortalGuia.obrigacao = "000092" Then
            CarregaTela(enuPortal.FolhaGps)
        End If
        blnCarregaTela = False
    End Sub

    Private Sub voltarSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles voltarSimpleButton.Click
        Me.Close()
    End Sub

    Private Sub logSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles logSimpleButton.Click
        Dim form As manutencaoobrigacoeslogXtraForm = New manutencaoobrigacoeslogXtraForm(infoPortalGuia)
        form.ShowDialog(Me)
    End Sub

    Private Sub sincronizaSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles sincronizaSimpleButton.Click
        Try
            SplashScreenManager.ShowForm(Me, GetType(aguardeWaitForm), True, True, False)
            SincronizarLog()
            SplashScreenManager.CloseForm()
        Catch ex As Exception
            SplashScreenManager.CloseForm()
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub reenviarSimpleButton_Click(sender As Object, e As System.EventArgs) Handles reenviarSimpleButton.Click
        If XtraMessageBox.Show("Guia já enviada para o Portal. Deseja reenviar mesmo assim?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
            enviarCheckButton_CheckedChanged(sender, e)
        End If
    End Sub

    Private Sub usuarioenvioSearchLookUpEdit_CustomDisplayText(sender As System.Object, e As DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs) Handles usuarioenvioSearchLookUpEdit.CustomDisplayText
        Try
            Dim editor As SearchLookUpEdit = TryCast(sender, SearchLookUpEdit)

            If editor.EditValue IsNot Nothing Then
                Dim index As Integer = editor.Properties.GetIndexByKeyValue(editor.EditValue)
                If index >= 0 Then
                    nomeenvioTextEdit.Text = objComum.RetornaDescricao(usuarioInfoBindingSource, index, "nome")
                Else
                    nomeenvioTextEdit.Text = String.Empty
                End If
            Else
                nomeenvioTextEdit.Text = String.Empty
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub enviarCheckButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles enviarCheckButton.CheckedChanged
        If Not blnCarregaTela Then
            If enviarCheckButton.Checked Then
                Try
                    infoPortalGuia.portalguias(0).mensagem = String.Empty
                    If mensagemMemoExEdit.EditValue IsNot Nothing Then
                        infoPortalGuia.portalguias(0).mensagem = mensagemMemoExEdit.EditValue.ToString
                    End If
                    Dim datahorainicial As DateTime = Now
                    SplashScreenManager.ShowForm(Me, GetType(aguardeWaitForm), True, True, False)
                    If objManutencaoObrigacoes.UploadGuias(RetornaDadosGuias, infoPortalGuia) Then
                        enviarCheckButton.ImageIndex = 1
                        enviarCheckButton.Text = "Enviado"
                        usuarioenvioSearchLookUpEdit.EditValue = usuarioInfo.usuario
                        datahoraenvioinicioDateEdit.EditValue = datahorainicial
                        datahoraenviofimDateEdit.EditValue = Now
                        infoPortalGuia.portalguias(0).datahoraenvioinicio = Convert.ToDateTime(datahoraenvioinicioDateEdit.EditValue)
                        infoPortalGuia.portalguias(0).datahoraenviofim = Convert.ToDateTime(datahoraenviofimDateEdit.EditValue)
                        enviarCheckButton.Enabled = False
                        SplashScreenManager.CloseForm()
                        XtraMessageBox.Show("Guia enviada com sucesso para o Portal", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        SplashScreenManager.CloseForm()
                        XtraMessageBox.Show("Falha no envio da Guia para o Portal", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        blnCarregaTela = True
                        enviarCheckButton.Checked = False
                        blnCarregaTela = False
                        enviarCheckButton.Enabled = True
                    End If
                Catch ex As Exception
                    SplashScreenManager.CloseForm()
                    XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    blnCarregaTela = True
                    enviarCheckButton.Checked = False
                    blnCarregaTela = False

                    usuarioenvioSearchLookUpEdit.EditValue = String.Empty
                    datahoraenvioinicioDateEdit.EditValue = Nothing
                    datahoraenviofimDateEdit.EditValue = Nothing
                    infoPortalGuia.portalguias(0).datahoraenvioinicio = Nothing
                    infoPortalGuia.portalguias(0).datahoraenviofim = Nothing
                    enviarCheckButton.Enabled = True
                End Try
            Else
                enviarCheckButton.ImageIndex = 0
                enviarCheckButton.Text = "Enviar"
                usuarioenvioSearchLookUpEdit.EditValue = String.Empty
                datahoraenvioinicioDateEdit.EditValue = Nothing
                datahoraenviofimDateEdit.EditValue = Nothing
                mensagemMemoExEdit.EditValue = Nothing
                infoPortalGuia.portalguias(0).mensagem = Nothing
                infoPortalGuia.portalguias(0).datahoraenvioinicio = Nothing
                infoPortalGuia.portalguias(0).datahoraenviofim = Nothing

                empresavisualizouCheckButton.Checked = False
                nomeusuarioempresaTextEdit.Text = String.Empty
                datahoraempresavisualizouDateEdit.EditValue = Nothing
                infoPortalGuia.portalguias(0).empresavisualizou = 0
                infoPortalGuia.portalguias(0).nomeusuarioempresa = String.Empty
                infoPortalGuia.portalguias(0).datahoraempresavisualizou = Nothing
            End If
            infoPortalGuia.portalguias(0).usuarioenvio = usuarioenvioSearchLookUpEdit.EditValue.ToString
            objManutencaoObrigacoes.IUDPortalGuias("alteracao", infoPortalGuia)
        Else
            If enviarCheckButton.Checked Then
                enviarCheckButton.ImageIndex = 1
                enviarCheckButton.Text = "Enviado"
            Else
                enviarCheckButton.ImageIndex = 0
                enviarCheckButton.Text = "Enviar"
            End If
        End If
        sincronizaSimpleButton.Enabled = enviarCheckButton.Checked
        logSimpleButton.Enabled = empresavisualizouCheckButton.Checked
        mensagemMemoExEdit.Properties.ReadOnly = enviarCheckButton.Checked
    End Sub

    Private Sub empresavisualizouCheckButton_CheckedChanged(sender As Object, e As System.EventArgs) Handles empresavisualizouCheckButton.CheckedChanged
        If empresavisualizouCheckButton.Checked Then
            empresavisualizouCheckButton.ImageIndex = 1
        Else
            empresavisualizouCheckButton.ImageIndex = 0
        End If
    End Sub

    Private Sub CarregaTela(penuPortal As enuPortal)
        garePanelControl.Visible = (penuPortal = enuPortal.EscritaGare And infoPortalGuia.portalguias.Count > 0)
        darfPanelControl.Visible = ((penuPortal = enuPortal.EscritaDarf Or penuPortal = enuPortal.ContabilDarf Or penuPortal = enuPortal.FolhaDarf) And infoPortalGuia.portalguias.Count > 0)
        gpsPanelControl.Visible = (penuPortal = enuPortal.FolhaGps And infoPortalGuia.portalguias.Count > 0)
        If darfPanelControl.Visible Then
            infoPortalGuia.portalguias(0).layout = 1
        ElseIf garePanelControl.Visible Then
            infoPortalGuia.portalguias(0).layout = 2
        ElseIf gpsPanelControl.Visible Then
            infoPortalGuia.portalguias(0).layout = 3
        End If
        usuarioenvioSearchLookUpEdit.EditValue = infoPortalGuia.portalguias(0).usuarioenvio.ToString
        datahoraenvioinicioDateEdit.EditValue = infoPortalGuia.portalguias(0).datahoraenvioinicio
        datahoraenviofimDateEdit.EditValue = infoPortalGuia.portalguias(0).datahoraenviofim
        mensagemMemoExEdit.EditValue = infoPortalGuia.portalguias(0).mensagem
        enviarCheckButton.Checked = Not String.IsNullOrEmpty(infoPortalGuia.portalguias(0).usuarioenvio)
        enviarCheckButton.Enabled = Not enviarCheckButton.Checked
        If Not enviarCheckButton.Enabled Then
            reenviarSimpleButton.Visible = usuarioInfo.master
            enviarCheckButton.Visible = Not usuarioInfo.master
        End If
        sincronizaSimpleButton.Enabled = enviarCheckButton.Checked
        If String.IsNullOrEmpty(mensagemMemoExEdit.Text) Then
            mensagemMemoExEdit.EditValue = objMaladireta.CarregaMensagem(infoPortalGuia.obrigacao, infoPortalGuia.competencia, infoPortalGuia.empresa, infoPortalGuia.obrigacaoextra, infoPortalGuia.sequenciaextra, infoPortalGuia.parcela, infoPortalGuia.informe)
        End If
        empresavisualizouCheckButton.Checked = Convert.ToBoolean(infoPortalGuia.portalguias(0).empresavisualizou)
        nomeusuarioempresaTextEdit.Text = infoPortalGuia.portalguias(0).nomeusuarioempresa.ToString
        datahoraempresavisualizouDateEdit.EditValue = infoPortalGuia.portalguias(0).datahoraempresavisualizou
        If Not enviarCheckButton.Enabled Then
            SincronizarLog()
        End If
        logSimpleButton.Enabled = empresavisualizouCheckButton.Checked
        If darfPanelControl.Visible Then
            darfvrelacaomesacumuladoLabelControl.Text = String.Empty
            darfvempresaLabelControl.Text = String.Empty
            darfvnomebeneficiarioLabelControl.Text = String.Empty
            darfvcnpjcpfbeneficiarioLabelControl.Text = String.Empty
            darfvnotafiscalLabelControl.Text = String.Empty
            darfvtexto1LabelControl.Text = String.Empty
            darfvtexto2LabelControl.Text = String.Empty
            If Not String.IsNullOrEmpty(infoPortalGuia.portalguias(0).relacaomesacumulado) Then
                darfvrelacaomesacumuladoLabelControl.Text = "Meses Acumulado: " + infoPortalGuia.portalguias(0).relacaomesacumulado.ToString
            End If
            If Not String.IsNullOrEmpty(infoPortalGuia.portalguias(0).ddd.ToString) Then
                If infoPortalGuia.portalguias(0).ddd.Length = 4 Then
                    darfvtelefoneLabelControl.Text = "(" + String.Format("{0}xx{1}", infoPortalGuia.portalguias(0).ddd.Substring(0, 1), infoPortalGuia.portalguias(0).ddd.Substring(1, 3)) + ")"
                End If
            End If
            If Not String.IsNullOrEmpty(infoPortalGuia.portalguias(0).telefone.ToString) Then
                If infoPortalGuia.portalguias(0).telefone.Length = 9 Then
                    darfvtelefoneLabelControl.Text += " " + String.Format("{0}-{1}", infoPortalGuia.portalguias(0).telefone.Substring(0, 5), infoPortalGuia.portalguias(0).telefone.Substring(5, 4))
                Else
                    darfvtelefoneLabelControl.Text += " " + String.Format("{0}-{1}", infoPortalGuia.portalguias(0).telefone.Substring(0, 4), infoPortalGuia.portalguias(0).telefone.Substring(4, 4))
                End If
            End If
            darfvrazaosocialLabelControl.Text = infoPortalGuia.portalguias(0).razaosocial.ToString
            If Not String.IsNullOrEmpty(infoPortalGuia.empresa) Then
                darfvempresaLabelControl.Text = String.Format("{0}.{1}", infoPortalGuia.empresa.Substring(0, 2), infoPortalGuia.empresa.Substring(2, 4))
            End If
            darfvdescricaoguiaLabelControl.Text = infoPortalGuia.portalguias(0).descricaoguia.ToString
            darfvnomebeneficiarioLabelControl.Text = infoPortalGuia.portalguias(0).nomebeneficiario.ToString
            If infoPortalGuia.portalguias(0).cnpjcpfbeneficiario.Length = 14 Then
                darfvcnpjcpfbeneficiarioLabelControl.Text = String.Format("{0}.{1}.{2}/{3}-{4}", infoPortalGuia.portalguias(0).cnpjcpfbeneficiario.Substring(0, 2),
                                                                                            infoPortalGuia.portalguias(0).cnpjcpfbeneficiario.Substring(2, 3),
                                                                                            infoPortalGuia.portalguias(0).cnpjcpfbeneficiario.Substring(5, 3),
                                                                                            infoPortalGuia.portalguias(0).cnpjcpfbeneficiario.Substring(8, 4),
                                                                                            infoPortalGuia.portalguias(0).cnpjcpfbeneficiario.Substring(12, 2))
            ElseIf infoPortalGuia.portalguias(0).cnpjcpfbeneficiario.Length = 11 Then
                darfvcnpjcpfbeneficiarioLabelControl.Text = String.Format("{0}.{1}.{2}-{3}", infoPortalGuia.portalguias(0).cnpjcpfbeneficiario.Substring(0, 3),
                                                                                        infoPortalGuia.portalguias(0).cnpjcpfbeneficiario.Substring(3, 3),
                                                                                        infoPortalGuia.portalguias(0).cnpjcpfbeneficiario.Substring(6, 3),
                                                                                        infoPortalGuia.portalguias(0).cnpjcpfbeneficiario.Substring(9, 2))
            End If
            If Not String.IsNullOrEmpty(infoPortalGuia.portalguias(0).notafiscal) Then
                darfvnotafiscalLabelControl.Text = "Nota: " + Convert.ToDecimal(infoPortalGuia.portalguias(0).notafiscal).ToString("#,##0")
            End If
            darfvdatapagamentoLabelControl.Visible = infoPortalGuia.portalguias(0).datapagamento.HasValue And
                                                     infoPortalGuia.portalguias(0).datavencimento.HasValue And
                                                     (infoPortalGuia.portalguias(0).valormulta + infoPortalGuia.portalguias(0).valorjuros) > 0
            darftdatapagamentoLabelControl.Visible = darfvdatapagamentoLabelControl.Visible
            If darfvdatapagamentoLabelControl.Visible Then
                If infoPortalGuia.portalguias(0).datapagamento > infoPortalGuia.portalguias(0).datavencimento Then
                    darfvdatapagamentoLabelControl.Text = Convert.ToDateTime(infoPortalGuia.portalguias(0).datapagamento).ToString("dd/MM/yyyy")
                Else
                    darfvdatapagamentoLabelControl.Visible = False
                    darftdatapagamentoLabelControl.Visible = False
                End If
            End If
            darfvtexto1LabelControl.Text = infoPortalGuia.portalguias(0).texto1.ToString
            darfvtexto2LabelControl.Text = infoPortalGuia.portalguias(0).texto2.ToString
            If infoPortalGuia.portalguias(0).periodoapuracao.HasValue Then
                darfvperiodoapuracaoLabelControl.Text = Convert.ToDateTime(infoPortalGuia.portalguias(0).periodoapuracao).ToString("dd/MM/yyyy")
            End If
            If infoPortalGuia.portalguias(0).cnpjcpf.Length = 14 Then
                darfvcnpjcpfLabelControl.Text = String.Format("{0}.{1}.{2}/{3}-{4}", infoPortalGuia.portalguias(0).cnpjcpf.Substring(0, 2),
                                                                                            infoPortalGuia.portalguias(0).cnpjcpf.Substring(2, 3),
                                                                                            infoPortalGuia.portalguias(0).cnpjcpf.Substring(5, 3),
                                                                                            infoPortalGuia.portalguias(0).cnpjcpf.Substring(8, 4),
                                                                                            infoPortalGuia.portalguias(0).cnpjcpf.Substring(12, 2))
            ElseIf infoPortalGuia.portalguias(0).cnpjcpf.Length = 11 Then
                darfvcnpjcpfLabelControl.Text = String.Format("{0}.{1}.{2}-{3}", infoPortalGuia.portalguias(0).cnpjcpf.Substring(0, 3),
                                                                                        infoPortalGuia.portalguias(0).cnpjcpf.Substring(3, 3),
                                                                                        infoPortalGuia.portalguias(0).cnpjcpf.Substring(6, 3),
                                                                                        infoPortalGuia.portalguias(0).cnpjcpf.Substring(9, 2))
            End If
            darfvcodigoreceitaLabelControl.Text = infoPortalGuia.portalguias(0).codigoreceita.ToString
            darfvnroreferenciaLabelControl.Text = infoPortalGuia.portalguias(0).nroreferencia.ToString
            If infoPortalGuia.portalguias(0).datavencimento.HasValue Then
                darfvdatavencimentoLabelControl.Text = Convert.ToDateTime(infoPortalGuia.portalguias(0).datavencimento).ToString("dd/MM/yyyy")
            End If
            darfvvalorprincipalLabelControl.Text = Convert.ToDecimal(infoPortalGuia.portalguias(0).valor).ToString("#,##0.00")
            If Convert.ToDecimal(infoPortalGuia.portalguias(0).valortotal) > 0 Then
                darfvvalormultaLabelControl.Text = Convert.ToDecimal(infoPortalGuia.portalguias(0).valormulta).ToString("#,##0.00")
                darfvvalorjurosLabelControl.Text = Convert.ToDecimal(infoPortalGuia.portalguias(0).valorjuros).ToString("#,##0.00")
                darfvvalortotalLabelControl.Text = Convert.ToDecimal(infoPortalGuia.portalguias(0).valortotal).ToString("#,##0.00")
            Else
                darfvvalormultaLabelControl.Text = String.Empty
                darfvvalorjurosLabelControl.Text = String.Empty
                darfvvalortotalLabelControl.Text = String.Empty
            End If
            darftextofixo6LabelControl.Text = darftextofixo6LabelControl.Text.Replace("?ValorMinimo", Convert.ToDecimal(infoPortalGuia.portalguias(0).valorminimo).ToString("#,##0.00"))
            darftextofixo7LabelControl.Text = darftextofixo7LabelControl.Text.Replace("?ValorMinimo", Convert.ToDecimal(infoPortalGuia.portalguias(0).valorminimo).ToString("#,##0.00"))
            darftextofixo9LabelControl.Visible = (infoPortalGuia.parcela = 3)
        End If
        If garePanelControl.Visible Then
            garevempresaLabelControl.Text = String.Format("{0}.{1}", infoPortalGuia.empresa.Substring(0, 2), infoPortalGuia.empresa.Substring(2, 4))
            garevrazaosocialLabelControl.Text = infoPortalGuia.portalguias(0).razaosocial.ToString
            garevenderecoLabelControl.Text = infoPortalGuia.portalguias(0).endereco.ToString
            garevmunicipioLabelControl.Text = infoPortalGuia.portalguias(0).municipio.ToString
            garevufLabelControl.Text = infoPortalGuia.portalguias(0).uf.ToString
            If Not String.IsNullOrEmpty(infoPortalGuia.empresa) Then
                darfvempresaLabelControl.Text = String.Format("{0}.{1}", infoPortalGuia.empresa.Substring(0, 2), infoPortalGuia.empresa.Substring(2, 4)) + infoPortalGuia.portalguias(0).texto4.ToString
            End If
            If Not String.IsNullOrEmpty(infoPortalGuia.portalguias(0).telefone) Then
                If infoPortalGuia.portalguias(0).telefone.Length = 9 Then
                    garevtelefoneLabelControl.Text = String.Format("{0}-{1}", infoPortalGuia.portalguias(0).telefone.Substring(0, 5), infoPortalGuia.portalguias(0).telefone.Substring(5, 4))
                Else
                    garevtelefoneLabelControl.Text = String.Format("{0}-{1}", infoPortalGuia.portalguias(0).telefone.Substring(0, 4), infoPortalGuia.portalguias(0).telefone.Substring(4, 4))
                End If
            End If
            If Not String.IsNullOrEmpty(infoPortalGuia.portalguias(0).cnae) Then
                garevcnaeLabelControl.Text = String.Format("{0}.{1}-{2}/{3}", infoPortalGuia.portalguias(0).cnae.Substring(0, 2), infoPortalGuia.portalguias(0).cnae.Substring(2, 2), infoPortalGuia.portalguias(0).cnae.Substring(4, 1), infoPortalGuia.portalguias(0).cnae.Substring(5, 2))
            End If
            garevvalororiginalLabelControl.Text = Convert.ToDecimal(infoPortalGuia.portalguias(0).valor).ToString("#,##0.00")
            garevtexto1LabelControl.Text = infoPortalGuia.portalguias(0).texto1.ToString
            garevtexto2LabelControl.Text = infoPortalGuia.portalguias(0).texto2.ToString
            garevtexto3LabelControl.Text = infoPortalGuia.portalguias(0).texto3.ToString
            garetdatapagamentoLabelControl.Visible = infoPortalGuia.portalguias(0).datapagamento.HasValue And
                                                     infoPortalGuia.portalguias(0).datavencimento.HasValue And
                                                     (infoPortalGuia.portalguias(0).valormulta + infoPortalGuia.portalguias(0).valorjuros) > 0
            garevdatapagamentoLabelControl.Visible = garetdatapagamentoLabelControl.Visible
            If garevdatapagamentoLabelControl.Visible Then
                If infoPortalGuia.portalguias(0).datapagamento > infoPortalGuia.portalguias(0).datavencimento Then
                    garevdatapagamentoLabelControl.Text = Convert.ToDateTime(infoPortalGuia.portalguias(0).datapagamento).ToString("dd/MM/yyyy")
                Else
                    garetdatapagamentoLabelControl.Visible = False
                    garevdatapagamentoLabelControl.Visible = False
                End If
            End If
            If infoPortalGuia.portalguias(0).datavencimento.HasValue Then
                garevdatavencimentoLabelControl.Text = Convert.ToDateTime(infoPortalGuia.portalguias(0).datavencimento).ToString("dd/MM/yyyy")
            End If
            If Not String.IsNullOrEmpty(infoPortalGuia.portalguias(0).codigoreceita) Then
                garevcodigoreceitaLabelControl.Text = String.Format("{0}-{1}", infoPortalGuia.portalguias(0).codigoreceita.Substring(0, 3), infoPortalGuia.portalguias(0).codigoreceita.Substring(3, 1))
            End If
            If Not String.IsNullOrEmpty(infoPortalGuia.portalguias(0).inscricaoestadual) Then
                If infoPortalGuia.portalguias(0).inscricaoestadual.Length = 12 Then
                    garevinscricaoestadualLabelControl.Text = String.Format("{0}.{1}.{2}.{3}", infoPortalGuia.portalguias(0).inscricaoestadual.Substring(0, 3),
                                                                                               infoPortalGuia.portalguias(0).inscricaoestadual.Substring(3, 3),
                                                                                               infoPortalGuia.portalguias(0).inscricaoestadual.Substring(6, 3),
                                                                                               infoPortalGuia.portalguias(0).inscricaoestadual.Substring(9, 3))
                Else
                    garevinscricaoestadualLabelControl.Text = infoPortalGuia.portalguias(0).inscricaoestadual.ToString
                End If
            End If
            If infoPortalGuia.portalguias(0).cnpjcpf.Length = 14 Then
                garevcnpjcpfLabelControl.Text = String.Format("{0}.{1}.{2}/{3}-{4}", infoPortalGuia.portalguias(0).cnpjcpf.Substring(0, 2),
                                                                                            infoPortalGuia.portalguias(0).cnpjcpf.Substring(2, 3),
                                                                                            infoPortalGuia.portalguias(0).cnpjcpf.Substring(5, 3),
                                                                                            infoPortalGuia.portalguias(0).cnpjcpf.Substring(8, 4),
                                                                                            infoPortalGuia.portalguias(0).cnpjcpf.Substring(12, 2))
            ElseIf infoPortalGuia.portalguias(0).cnpjcpf.Length = 11 Then
                garevcnpjcpfLabelControl.Text = String.Format("{0}.{1}.{2}-{3}", infoPortalGuia.portalguias(0).cnpjcpf.Substring(0, 3),
                                                                                        infoPortalGuia.portalguias(0).cnpjcpf.Substring(3, 3),
                                                                                        infoPortalGuia.portalguias(0).cnpjcpf.Substring(6, 3),
                                                                                        infoPortalGuia.portalguias(0).cnpjcpf.Substring(9, 2))
            End If
            If Not String.IsNullOrEmpty(infoPortalGuia.competencia) Then
                garevreferenciaLabelControl.Text = String.Format("{0}/{1}", infoPortalGuia.competencia.Substring(0, 2), infoPortalGuia.competencia.Substring(2, 4))
            End If
            garevvalorLabelControl.Text = Convert.ToDecimal(infoPortalGuia.portalguias(0).valor).ToString("#,##0.00")
            If Convert.ToDecimal(infoPortalGuia.portalguias(0).valortotal) > 0 Then
                garevvalorjurosLabelControl.Text = Convert.ToDecimal(infoPortalGuia.portalguias(0).valorjuros).ToString("#,##0.00")
                garevvalormultaLabelControl.Text = Convert.ToDecimal(infoPortalGuia.portalguias(0).valormulta).ToString("#,##0.00")
                garevvalortotalLabelControl.Text = Convert.ToDecimal(infoPortalGuia.portalguias(0).valortotal).ToString("#,##0.00")
            Else
                garevvalorjurosLabelControl.Text = String.Empty
                garevvalormultaLabelControl.Text = String.Empty
                garevvalortotalLabelControl.Text = String.Empty
            End If
        End If
        If gpsPanelControl.Visible Then
            gpsvempresaLabelControl.Text = String.Format("{0}.{1}", infoPortalGuia.empresa.Substring(0, 2), infoPortalGuia.empresa.Substring(2, 4))
            gpsvrazaosocialLabelControl.Text = infoPortalGuia.portalguias(0).razaosocial.ToString
            gpsvenderecoLabelControl.Text = infoPortalGuia.portalguias(0).endereco.ToString
            gpsvbairroLabelControl.Text = infoPortalGuia.portalguias(0).bairro.ToString
            If Not String.IsNullOrEmpty(infoPortalGuia.portalguias(0).cep) Then
                gpsvcepLabelControl.Text = String.Format("{0}-{1}", infoPortalGuia.portalguias(0).cep.Substring(0, 5), infoPortalGuia.portalguias(0).cep.Substring(5, 3))
            End If
            gpsvmunicipioLabelControl.Text = infoPortalGuia.portalguias(0).municipio.ToString
            gpsvufLabelControl.Text = infoPortalGuia.portalguias(0).uf.ToString
            If Not String.IsNullOrEmpty(infoPortalGuia.portalguias(0).ddd.ToString) Then
                If infoPortalGuia.portalguias(0).ddd.Length = 4 Then
                    gpsvtelefoneLabelControl.Text = "(" + String.Format("{0}xx{1}", infoPortalGuia.portalguias(0).ddd.Substring(0, 1), infoPortalGuia.portalguias(0).ddd.Substring(1, 3)) + ")"
                End If
            End If
            If Not String.IsNullOrEmpty(gpsvtelefoneLabelControl.Text) Then
                If infoPortalGuia.portalguias(0).telefone.Length = 9 Then
                    gpsvtelefoneLabelControl.Text += " " + String.Format("{0}-{1}", infoPortalGuia.portalguias(0).telefone.Substring(0, 5), infoPortalGuia.portalguias(0).telefone.Substring(5, 4))
                Else
                    gpsvtelefoneLabelControl.Text += " " + String.Format("{0}-{1}", infoPortalGuia.portalguias(0).telefone.Substring(0, 4), infoPortalGuia.portalguias(0).telefone.Substring(4, 4))
                End If
            End If
            gpsvtexto1LabelControl.Text = infoPortalGuia.portalguias(0).texto1.ToString
            gpsvtexto2LabelControl.Text = infoPortalGuia.portalguias(0).texto2.ToString
            gpsvtexto3LabelControl.Text = infoPortalGuia.portalguias(0).texto3.ToString
            gpsvcodigoreceitaLabelControl.Text = infoPortalGuia.portalguias(0).codigoreceita.ToString

            If Not String.IsNullOrEmpty(infoPortalGuia.competencia) Then
                Dim strCompetencia As String = infoPortalGuia.competencia
                If infoPortalGuia.obrigacao = "000038" Then
                    strCompetencia = "13" + infoPortalGuia.competencia.Substring(2, 4)
                End If
                gpsvcompetenciaLabelControl.Text = String.Format("{0}/{1}", strCompetencia.Substring(0, 2), strCompetencia.Substring(2, 4))
            End If

            If infoPortalGuia.portalguias(0).cnpjcpf.Length = 14 Then
                gpsvcnpjcpfLabelControl.Text = String.Format("{0}.{1}.{2}/{3}-{4}", infoPortalGuia.portalguias(0).cnpjcpf.Substring(0, 2),
                                                                                    infoPortalGuia.portalguias(0).cnpjcpf.Substring(2, 3),
                                                                                    infoPortalGuia.portalguias(0).cnpjcpf.Substring(5, 3),
                                                                                    infoPortalGuia.portalguias(0).cnpjcpf.Substring(8, 4),
                                                                                    infoPortalGuia.portalguias(0).cnpjcpf.Substring(12, 2))
            ElseIf infoPortalGuia.portalguias(0).cnpjcpf.Length = 11 Then
                gpsvcnpjcpfLabelControl.Text = String.Format("{0}.{1}.{2}-{3}", infoPortalGuia.portalguias(0).cnpjcpf.Substring(0, 3),
                                                                                infoPortalGuia.portalguias(0).cnpjcpf.Substring(3, 3),
                                                                                infoPortalGuia.portalguias(0).cnpjcpf.Substring(6, 3),
                                                                                infoPortalGuia.portalguias(0).cnpjcpf.Substring(9, 2))
            End If
            gpsvvalorinssLabelControl.Text = Convert.ToDecimal(infoPortalGuia.portalguias(0).valor).ToString("#,##0.00")
            gpsvvaloroutrosLabelControl.Text = Convert.ToDecimal(infoPortalGuia.portalguias(0).valoroutros).ToString("#,##0.00")
            If Convert.ToDecimal(infoPortalGuia.portalguias(0).valortotal) > 0 Then
                gpsvvalormultajurosLabelControl.Text = Convert.ToDecimal(infoPortalGuia.portalguias(0).valormulta).ToString("#,##0.00")
                gpsvvalortotalLabelControl.Text = Convert.ToDecimal(infoPortalGuia.portalguias(0).valortotal).ToString("#,##0.00")
            Else
                gpsvvalormultajurosLabelControl.Text = String.Empty
                gpsvvalortotalLabelControl.Text = String.Empty
            End If
        End If
    End Sub

    Private Function RetornaDadosGuias() As String
        Dim strDados As String = String.Empty
        If darfPanelControl.Visible Then
            strDados = darfvperiodoapuracaoLabelControl.Text + "|" +
                       darfvcnpjcpfLabelControl.Text + "|" +
                       darfvcodigoreceitaLabelControl.Text + "|" +
                       darfvnroreferenciaLabelControl.Text + "|" +
                       darfvdatavencimentoLabelControl.Text + "|" +
                       darfvvalorprincipalLabelControl.Text + "|" +
                       darfvvalormultaLabelControl.Text + "|" +
                       darfvvalorjurosLabelControl.Text + "|" +
                       darfvvalortotalLabelControl.Text + "|" +
                       darfvtelefoneLabelControl.Text + "|" +
                       darfvrazaosocialLabelControl.Text + "|" +
                       darfvempresaLabelControl.Text + "|" +
                       darfvcnpjcpfbeneficiarioLabelControl.Text + "|" +
                       darfvnotafiscalLabelControl.Text + "|" +
                       darfvdatapagamentoLabelControl.Text + "|" +
                       darfvrelacaomesacumuladoLabelControl.Text + "|" +
                       darfvdescricaoguiaLabelControl.Text + "|" +
                       darfvnomebeneficiarioLabelControl.Text + "|" +
                       Convert.ToDecimal(infoPortalGuia.portalguias(0).valorminimo).ToString("#,##0.00") + "|" +
                       darfvtexto1LabelControl.Text + "|" +
                       darfvtexto2LabelControl.Text + "|"
            If darftdatapagamentoLabelControl.Visible Then
                strDados += darftdatapagamentoLabelControl.Text
            End If
            strDados += "|"
            If darftextofixo9LabelControl.Visible Then
                strDados += darftextofixo9LabelControl.Text
            End If
        End If
        If garePanelControl.Visible Then
            strDados = garevdatavencimentoLabelControl.Text + "|" +
                       garevcodigoreceitaLabelControl.Text + "|" +
                       garevinscricaoestadualLabelControl.Text + "|" +
                       garevcnpjcpfLabelControl.Text + "|" +
                       garevinscricaodividaLabelControl.Text + "|" +
                       garevreferenciaLabelControl.Text + "|" +
                       garevnroparcelamentoLabelControl.Text + "|" +
                       garevvalorLabelControl.Text + "|" +
                       garevvalorjurosLabelControl.Text + "|" +
                       garevvalormultaLabelControl.Text + "|" +
                       garevvaloracrescimoLabelControl.Text + "|" +
                       garevvalorhonorarioLabelControl.Text + "|" +
                       garevvalortotalLabelControl.Text + "|" +
                       garevrazaosocialLabelControl.Text + "|" +
                       garevenderecoLabelControl.Text + "|" +
                       garevmunicipioLabelControl.Text + "|" +
                       garevufLabelControl.Text + "|" +
                       garevtelefoneLabelControl.Text + "|" +
                       garevcnaeLabelControl.Text + "|" +
                       garevvalororiginalLabelControl.Text + "|" +
                       garevdatapagamentoLabelControl.Text + "|" +
                       garevtexto1LabelControl.Text + "|" +
                       garevtexto2LabelControl.Text + "|" +
                       garevtexto3LabelControl.Text + "|" +
                       garevempresaLabelControl.Text
        End If
        If gpsPanelControl.Visible Then
            strDados = gpsvcodigoreceitaLabelControl.Text + "|" +
                       gpsvcompetenciaLabelControl.Text + "|" +
                       gpsvcnpjcpfLabelControl.Text + "|" +
                       gpsvvalorinssLabelControl.Text + "|" +
                       gpsvtextofixo1LabelControl.Text + "|" +
                       gpsvtextofixo2LabelControl.Text + "|" +
                       gpsvvaloroutrosLabelControl.Text + "|" +
                       gpsvvalormultajurosLabelControl.Text + "|" +
                       gpsvvalortotalLabelControl.Text + "|" +
                       gpsvrazaosocialLabelControl.Text + "|" +
                       gpsvenderecoLabelControl.Text + "|" +
                       gpsvbairroLabelControl.Text + "|" +
                       gpsvcepLabelControl.Text + "|" +
                       gpsvtexto1LabelControl.Text + "|" +
                       gpsvtexto2LabelControl.Text + "|" +
                       gpsvtexto3LabelControl.Text + "|" +
                       gpsvempresaLabelControl.Text + "|" +
                       gpsvmunicipioLabelControl.Text + "|" +
                       gpsvufLabelControl.Text + "|" +
                       gpsvtelefoneLabelControl.Text
        End If
        Return strDados
    End Function

    Private Sub SincronizarLog()
        Try
            objManutencaoObrigacoes.LogGuias(infoPortalGuia)
            empresavisualizouCheckButton.Checked = False
            nomeusuarioempresaTextEdit.Text = String.Empty
            datahoraempresavisualizouDateEdit.EditValue = Nothing
            logSimpleButton.Enabled = infoPortalGuia.portallog.Count > 0
            If infoPortalGuia.portallog.Count > 0 Then
                empresavisualizouCheckButton.Checked = True
                For iLista = 0 To infoPortalGuia.portallog.Count - 1
                    If Not datahoraempresavisualizouDateEdit.EditValue Is Nothing Then
                        If Convert.ToDateTime(datahoraempresavisualizouDateEdit.EditValue) >= infoPortalGuia.portallog(iLista).datahora Then
                            nomeusuarioempresaTextEdit.Text = infoPortalGuia.portallog(iLista).nome
                            datahoraempresavisualizouDateEdit.EditValue = infoPortalGuia.portallog(iLista).datahora
                        End If
                    Else
                        nomeusuarioempresaTextEdit.Text = infoPortalGuia.portallog(iLista).nome
                        datahoraempresavisualizouDateEdit.EditValue = infoPortalGuia.portallog(iLista).datahora
                    End If
                Next
            End If
            logSimpleButton.Enabled = empresavisualizouCheckButton.Checked
            If empresavisualizouCheckButton.Checked Then
                infoPortalGuia.portalguias(0).empresavisualizou = -1
            Else
                infoPortalGuia.portalguias(0).empresavisualizou = 0
            End If
            infoPortalGuia.portalguias(0).nomeusuarioempresa = nomeusuarioempresaTextEdit.Text
            If Not datahoraempresavisualizouDateEdit.EditValue Is Nothing Then
                infoPortalGuia.portalguias(0).datahoraempresavisualizou = Convert.ToDateTime(datahoraempresavisualizouDateEdit.EditValue)
            Else
                infoPortalGuia.portalguias(0).datahoraempresavisualizou = Nothing
            End If
            objManutencaoObrigacoes.IUDPortalGuias("alteracao", infoPortalGuia)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
