Imports Administrativo.Modelo
Imports Administrativo.BLL
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraEditors
Imports System.IO
Imports System.IO.Compression
Imports System.Text

Public Class portalarquivoXtraForm
    Public infoPortalArquivo As manutencaoobrigacoesInfo
    Dim objManutencaoObrigacoes As New ManutencaoObrigacoesBLL
    Dim objComum As New ComumBLL
    Dim objAdministrativo As New AdministrativoBLL
    Dim objMaladireta As New MaladiretaBLL
    Dim strDiretorioInicial As String = String.Empty
    Dim intDiretorioFiltro As Int32 = 1
    Dim blnCarregaTela As Boolean = False
    Dim srtPahtFile As String
    Dim blnReenvio As Boolean = False

    Public Sub New(ByRef pinfoPortalArquivo As manutencaoobrigacoesInfo)
        InitializeComponent()
        infoPortalArquivo = pinfoPortalArquivo
        objComum.Browse("select login, nome from usuarios order by login", usuarioInfoBindingSource)
    End Sub

    Private Sub portalarquivoXtraForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Try

            arquivoPdfViewer.Visible = False
            arquivoRichEditControl.Visible = False
            arquivoSpreadsheetControl.Visible = False
            blnCarregaTela = True
            objAdministrativo.CentralizaForm(Me)
            CarregaTela()
            blnCarregaTela = False
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub voltarSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles voltarSimpleButton.Click
        If (File.Exists(srtPahtFile) And blnReenvio = True) Then
            File.Delete(srtPahtFile)
        End If
        Me.Close()
    End Sub

    Private Sub reenviarSimpleButton_Click(sender As Object, e As System.EventArgs) Handles reenviarSimpleButton.Click
        If XtraMessageBox.Show("Arquivo já enviado para o Portal. Deseja reenviar mesmo assim?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
            enviarCheckButton_CheckedChanged(sender, e)
            reenviarSimpleButton.ImageIndex = 1
            reenviarSimpleButton.Text = "Reenviado"
            reenviarSimpleButton.Enabled = False
            File.Delete(arquivoTextEdit.Text)
        End If
    End Sub

    Private Sub arquivoSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles arquivoSimpleButton.Click
        Using myFileDialog As New OpenFileDialog()
            myFileDialog.Filter = RetornaTipoArquivo()
            myFileDialog.FilterIndex = intDiretorioFiltro
            If String.IsNullOrEmpty(strDiretorioInicial) Then
                strDiretorioInicial = "C:\"
            End If
            If Not Directory.Exists(Path.GetDirectoryName(strDiretorioInicial)) Then
                strDiretorioInicial = "C:\"
            End If
            myFileDialog.InitialDirectory = Path.GetDirectoryName(strDiretorioInicial)
            myFileDialog.Title = "Selecione o arquivo para enviar ao Portal"
            myFileDialog.CheckFileExists = False
            Dim result As DialogResult = myFileDialog.ShowDialog()
            If result = DialogResult.OK Then
                srtPahtFile = myFileDialog.FileName
                VisualizaDocumento(srtPahtFile)
                Dim fiArquivo As FileInfo = New FileInfo(myFileDialog.FileName)
                Dim diDiretorio As DirectoryInfo = New DirectoryInfo(myFileDialog.FileName)
                strDiretorioInicial = diDiretorio.FullName.Replace(fiArquivo.Name, String.Empty)
                intDiretorioFiltro = myFileDialog.FilterIndex
                arquivoTextEdit.Text = diDiretorio.FullName
                Dim objRegistro As New RegistroBLL
                objRegistro.GravaChaveRegistro("Software", Application.ProductName, "portalarquivoXtraForm", arquivoTextEdit.Text.Replace(fiArquivo.Name, String.Empty))
                If Not enviarCheckButton.Enabled Then
                    enviarCheckButton.Enabled = True
                    adicionaarquivoSimpleButton.Enabled = True
                    removearquivoSimpleButton.Enabled = True
                    mensagemMemoExEdit.Properties.ReadOnly = Not enviarCheckButton.Enabled
                End If
            End If
        End Using
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

    Private Sub logSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles logSimpleButton.Click
        Dim form As manutencaoobrigacoeslogXtraForm = New manutencaoobrigacoeslogXtraForm(infoPortalArquivo)
        form.ShowDialog(Me)
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
                    SplashScreenManager.ShowForm(Me, GetType(aguardeWaitForm), True, True, False)
                    infoPortalArquivo.portalarquivos(0).mensagem = String.Empty
                    If mensagemMemoExEdit.EditValue IsNot Nothing Then
                        infoPortalArquivo.portalarquivos(0).mensagem = mensagemMemoExEdit.EditValue.ToString
                    End If
                    infoPortalArquivo.portalarquivos(0).arquivo = arquivoTextEdit.Text
                    Dim datahorainicial As DateTime = Now
                    If objManutencaoObrigacoes.UploadArquivos(UploadDocumento, infoPortalArquivo) Then
                        enviarCheckButton.ImageIndex = 1
                        enviarCheckButton.Text = "Enviado"
                        usuarioenvioSearchLookUpEdit.EditValue = usuarioInfo.usuario
                        datahoraenvioinicioDateEdit.EditValue = datahorainicial
                        datahoraenviofimDateEdit.EditValue = Now
                        infoPortalArquivo.portalarquivos(0).datahoraenvioinicio = Convert.ToDateTime(datahoraenvioinicioDateEdit.EditValue)
                        infoPortalArquivo.portalarquivos(0).datahoraenviofim = Convert.ToDateTime(datahoraenviofimDateEdit.EditValue)
                        enviarCheckButton.Enabled = False
                        adicionaarquivoSimpleButton.Enabled = False
                        removearquivoSimpleButton.Enabled = False
                        SplashScreenManager.CloseForm()
                        XtraMessageBox.Show("Arquivo enviado com sucesso para o Portal", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Dim fiArquivo As FileInfo = New FileInfo(arquivoTextEdit.Text)
                        If VerificaPadraoNome(fiArquivo.Name.ToString) Then
                            If fiArquivo.Exists Then
                                For Each file In New DirectoryInfo(fiArquivo.DirectoryName).GetFiles(fiArquivo.Name.Remove(fiArquivo.Name.Length - 5).ToString + "*.*")
                                    file.Delete()
                                Next
                            End If
                        End If
                    Else
                        SplashScreenManager.CloseForm()
                        XtraMessageBox.Show("Falha no envio do Arquivo para o Portal", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        blnCarregaTela = True
                        enviarCheckButton.Checked = False
                        blnCarregaTela = False
                        enviarCheckButton.Enabled = True
                        adicionaarquivoSimpleButton.Enabled = True
                        removearquivoSimpleButton.Enabled = True
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
                    infoPortalArquivo.portalarquivos(0).datahoraenvioinicio = Nothing
                    infoPortalArquivo.portalarquivos(0).datahoraenviofim = Nothing
                    enviarCheckButton.Enabled = True
                    adicionaarquivoSimpleButton.Enabled = True
                    removearquivoSimpleButton.Enabled = True
                End Try
            Else
                enviarCheckButton.ImageIndex = 0
                enviarCheckButton.Text = "Enviar"
                usuarioenvioSearchLookUpEdit.EditValue = String.Empty
                datahoraenvioinicioDateEdit.EditValue = Nothing
                datahoraenviofimDateEdit.EditValue = Nothing
                mensagemMemoExEdit.EditValue = Nothing
                infoPortalArquivo.portalarquivos(0).mensagem = Nothing
                infoPortalArquivo.portalarquivos(0).datahoraenvioinicio = Nothing
                infoPortalArquivo.portalarquivos(0).datahoraenviofim = Nothing

                empresavisualizouCheckButton.Checked = False
                nomeusuarioempresaTextEdit.Text = String.Empty
                datahoraempresavisualizouDateEdit.EditValue = Nothing
                infoPortalArquivo.portalarquivos(0).empresavisualizou = 0
                infoPortalArquivo.portalarquivos(0).nomeusuarioempresa = String.Empty
                infoPortalArquivo.portalarquivos(0).datahoraempresavisualizou = Nothing
            End If
            infoPortalArquivo.portalarquivos(0).usuarioenvio = usuarioenvioSearchLookUpEdit.EditValue.ToString
            objManutencaoObrigacoes.IUDPortalArquivos("alteracao", infoPortalArquivo)
        Else
            If enviarCheckButton.Checked Then
                enviarCheckButton.ImageIndex = 1
                enviarCheckButton.Text = "Enviado"
                adicionaarquivoSimpleButton.Enabled = False
                removearquivoSimpleButton.Enabled = False
            Else
                enviarCheckButton.ImageIndex = 0
                enviarCheckButton.Text = "Enviar"
                adicionaarquivoSimpleButton.Enabled = True
                removearquivoSimpleButton.Enabled = True
            End If
        End If
        sincronizaSimpleButton.Enabled = enviarCheckButton.Checked
        logSimpleButton.Enabled = empresavisualizouCheckButton.Checked
        arquivoSimpleButton.Enabled = Not enviarCheckButton.Checked
        mensagemMemoExEdit.Properties.ReadOnly = enviarCheckButton.Checked
    End Sub

    Private Sub empresavisualizouCheckButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles empresavisualizouCheckButton.CheckedChanged
        If empresavisualizouCheckButton.Checked Then
            empresavisualizouCheckButton.ImageIndex = 1
        Else
            empresavisualizouCheckButton.ImageIndex = 0
        End If
    End Sub

    Private Sub CarregaTela()
        Dim blnArquivoLocal As Boolean = False

        usuarioenvioSearchLookUpEdit.EditValue = infoPortalArquivo.portalarquivos(0).usuarioenvio.ToString
        datahoraenvioinicioDateEdit.EditValue = infoPortalArquivo.portalarquivos(0).datahoraenvioinicio
        datahoraenviofimDateEdit.EditValue = infoPortalArquivo.portalarquivos(0).datahoraenviofim
        mensagemMemoExEdit.EditValue = infoPortalArquivo.portalarquivos(0).mensagem
        enviarCheckButton.Checked = Not String.IsNullOrEmpty(infoPortalArquivo.portalarquivos(0).usuarioenvio)
        enviarCheckButton.Enabled = Not enviarCheckButton.Checked
        If Not enviarCheckButton.Enabled Then
            reenviarSimpleButton.Visible = usuarioInfo.master
            enviarCheckButton.Visible = Not usuarioInfo.master
        End If
        If String.IsNullOrEmpty(mensagemMemoExEdit.Text) Then
            mensagemMemoExEdit.EditValue = objMaladireta.CarregaMensagem(infoPortalArquivo.obrigacao, infoPortalArquivo.competencia, infoPortalArquivo.empresa, infoPortalArquivo.obrigacaoextra, infoPortalArquivo.sequenciaextra, infoPortalArquivo.parcela, infoPortalArquivo.informe)
        End If
        adicionaarquivoSimpleButton.Enabled = Not enviarCheckButton.Checked
        removearquivoSimpleButton.Enabled = Not enviarCheckButton.Checked
        sincronizaSimpleButton.Enabled = enviarCheckButton.Checked
        empresavisualizouCheckButton.Checked = Convert.ToBoolean(infoPortalArquivo.portalarquivos(0).empresavisualizou)
        nomeusuarioempresaTextEdit.Text = infoPortalArquivo.portalarquivos(0).nomeusuarioempresa.ToString
        datahoraempresavisualizouDateEdit.EditValue = infoPortalArquivo.portalarquivos(0).datahoraempresavisualizou
        arquivoTextEdit.Text = infoPortalArquivo.portalarquivos(0).arquivo.ToString
        If String.IsNullOrEmpty(arquivoTextEdit.Text) Then
            Dim objRegistro As New RegistroBLL
            strDiretorioInicial = objRegistro.LocalizaChaveRegistro("Software", Application.ProductName, "portalarquivoXtraForm")
            arquivoTextEdit.Text = strDiretorioInicial
        Else
            strDiretorioInicial = arquivoTextEdit.Text
        End If
        If Not enviarCheckButton.Enabled Then
            Try
                SplashScreenManager.ShowForm(Me, GetType(aguardeWaitForm), True, True, False)
                srtPahtFile = objManutencaoObrigacoes.DownloadArquivos(My.Application.Info.DirectoryPath, infoPortalArquivo)
                blnArquivoLocal = String.IsNullOrEmpty(srtPahtFile)
                If Not blnArquivoLocal Then
                    VisualizaDocumento(srtPahtFile)
                    blnReenvio = True
                    arquivoTextEdit.Text = srtPahtFile
                    If Not enviarCheckButton.Enabled Then
                        SincronizarLog()
                    End If
                End If
                SplashScreenManager.CloseForm()
            Catch ex As Exception
                SplashScreenManager.CloseForm()
                Throw New Exception(ex.Message)
            End Try
        Else
            blnArquivoLocal = True
        End If
        If blnArquivoLocal Then
            Try
                If InStr(infoPortalArquivo.portalarquivos(0).arquivo.ToString, "*") = 0 Then
                    If File.Exists(infoPortalArquivo.portalarquivos(0).arquivo.ToString) Then
                        VisualizaDocumento(infoPortalArquivo.portalarquivos(0).arquivo.ToString)
                    End If
                Else
                    If administrativoInfo.FrameWork(0).Framework4_5 Then
                        Dim fileinfoArquivos As FileInfo = New FileInfo(infoPortalArquivo.portalarquivos(0).arquivo.ToString.Replace("*", ""))
                        If File.Exists(fileinfoArquivos.Directory.ToString + "\" + fileinfoArquivos.Name.Replace(".pdf", "") + ".zip") Then
                            File.Delete(fileinfoArquivos.Directory.ToString + "\" + fileinfoArquivos.Name.Replace(".pdf", "") + ".zip")
                        End If
                        For Each foundFile As String In My.Computer.FileSystem.GetFiles(fileinfoArquivos.Directory.ToString + "\",
                                                                                        FileIO.SearchOption.SearchTopLevelOnly,
                                                                                        infoPortalArquivo.portalarquivos(0).arquivo.ToString.Replace(fileinfoArquivos.Directory.ToString + "\", ""))
                            CompactaArquivoZip(fileinfoArquivos.Directory.ToString + "\" + fileinfoArquivos.Name.Replace(".pdf", "") + ".zip", foundFile, False)
                        Next
                        srtPahtFile = fileinfoArquivos.Directory.ToString + "\" + fileinfoArquivos.Name.Replace(".pdf", "") + ".zip"
                        arquivoTextEdit.Text = srtPahtFile
                        If File.Exists(srtPahtFile) Then
                            VisualizaDocumento(srtPahtFile)
                        Else
                            LayOutTelaArquivo(False)
                        End If
                    Else
                        Dim fileinfoArquivos As FileInfo = New FileInfo(infoPortalArquivo.portalarquivos(0).arquivo.ToString.Replace("*", ""))
                        Dim intCount As Integer = 0
                        Dim strArquivo As String = ""
                        For Each foundFile As String In My.Computer.FileSystem.GetFiles(fileinfoArquivos.Directory.ToString + "\",
                                                                                        FileIO.SearchOption.SearchTopLevelOnly,
                                                                                        infoPortalArquivo.portalarquivos(0).arquivo.ToString.Replace(fileinfoArquivos.Directory.ToString + "\", ""))
                            intCount += 1
                            If intCount > 1 Then Exit For
                            strArquivo = foundFile
                        Next
                        srtPahtFile = strArquivo
                        arquivoTextEdit.Text = srtPahtFile
                        If intCount = 1 Then
                            VisualizaDocumento(strArquivo)
                        Else
                            LayOutTelaArquivo(False)
                            XtraMessageBox.Show("Não será possível compactar automaticamente os arquivos de envio devido a falta da versão .NET Framework 4.5 ou superior nessa máquina." + Chr(13) + Chr(10) +
                                                "Favor selecionar um arquivo compactado manualmente ou então instalar a versão .NET Framework 4.5 ou superior!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                    End If
                End If
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End If
        logSimpleButton.Enabled = empresavisualizouCheckButton.Checked
    End Sub

    Private Sub VisualizaDocumento(ByRef pstrArquivo As String)
        Try
            Dim fiArquivo As FileInfo = New FileInfo(pstrArquivo)
            Dim stStreamPDF As IO.Stream
            MontaVisualizadoresDocumentos(True)
            If fiArquivo.Extension.ToLower = ".pdf" Then
                stStreamPDF = New IO.FileStream(pstrArquivo, FileMode.Open)
                arquivoPdfViewer.Visible = True
                arquivoPdfViewer.LoadDocument(stStreamPDF)
                arquivoPdfViewer.Refresh()
                stStreamPDF.Close()
            ElseIf fiArquivo.Extension.ToLower.IndexOf(".xl", 0) = 0 Then
                arquivoSpreadsheetControl.Visible = True
                arquivoSpreadsheetControl.LoadDocument(pstrArquivo)
                arquivoSpreadsheetControl.ReadOnly = True
            ElseIf fiArquivo.Extension.ToLower = ".7z" Or fiArquivo.Extension.ToLower = ".rar" Or (Not administrativoInfo.FrameWork(0).Framework4_5 And fiArquivo.Extension = ".zip") Then
                LayOutTelaArquivo(False)
            ElseIf fiArquivo.Extension = ".zip" Then
                VisualizaArquivoZip(pstrArquivo)
            Else
                arquivoRichEditControl.Visible = True
                arquivoRichEditControl.LoadDocument(pstrArquivo)
                arquivoRichEditControl.ReadOnly = True
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub VisualizaZipDocumento(ByRef pstrArquivo As String)
        Try
            Dim fiArquivo As FileInfo = New FileInfo(srtPahtFile)
            Dim fiArquivoCompactado As FileInfo
            Dim strArquivo As String
            Dim strArquivoDestino As String
            Dim stStreamPDF As IO.Stream

            strArquivoDestino = (fiArquivo.DirectoryName.ToString + "\temp").Replace("\\", "\")
            If Not Directory.Exists(strArquivoDestino) Then
                Directory.CreateDirectory(strArquivoDestino)
            End If
            MontaVisualizadoresDocumentos(False)
            Using archive As ZipArchive = ZipFile.OpenRead(fiArquivo.FullName.ToString)
                For Each entry As ZipArchiveEntry In archive.Entries
                    fiArquivoCompactado = New FileInfo(entry.FullName.ToString)
                    strArquivo = SubstituiCaracteres(entry.FullName.ToString)
                    If pstrArquivo.Equals(strArquivo) Then
                        strArquivoDestino = Path.Combine(strArquivoDestino, fiArquivoCompactado.Name)
                        If File.Exists(strArquivoDestino) Then
                            File.Delete(strArquivoDestino)
                        End If
                        entry.ExtractToFile(strArquivoDestino, True)
                        If fiArquivoCompactado.Extension = ".pdf" Then
                            stStreamPDF = New IO.FileStream(strArquivoDestino, FileMode.Open)
                            arquivoPdfViewer.Visible = True
                            arquivoPdfViewer.LoadDocument(stStreamPDF)
                            arquivoPdfViewer.Refresh()
                            stStreamPDF.Close()
                        ElseIf fiArquivoCompactado.Extension.IndexOf(".xl", 0) = 0 Then
                            arquivoSpreadsheetControl.Visible = True
                            arquivoSpreadsheetControl.LoadDocument(strArquivoDestino)
                            arquivoSpreadsheetControl.ReadOnly = True
                        Else
                            arquivoRichEditControl.Visible = True
                            arquivoRichEditControl.LoadDocument(strArquivoDestino)
                            arquivoRichEditControl.ReadOnly = True
                        End If
                        File.Delete(strArquivoDestino)
                    End If
                Next
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Function UploadDocumento() As Byte()
        Dim fiArquivo As New FileInfo(arquivoTextEdit.Text)
        Dim numBytes As Long = fiArquivo.Length
        Dim fsArquivo As New FileStream(arquivoTextEdit.Text, FileMode.Open, FileAccess.Read)
        Dim brArquivo As New BinaryReader(fsArquivo)
        Dim bArquivo As Byte() = brArquivo.ReadBytes(CInt(numBytes))
        brArquivo.Close()
        fsArquivo.Close()
        Return bArquivo
    End Function

    Private Sub SincronizarLog()
        Try
            objManutencaoObrigacoes.LogArquivos(infoPortalArquivo)
            empresavisualizouCheckButton.Checked = False
            nomeusuarioempresaTextEdit.Text = String.Empty
            datahoraempresavisualizouDateEdit.EditValue = Nothing
            If infoPortalArquivo.portallog.Count > 0 Then
                empresavisualizouCheckButton.Checked = True
                For iLista = 0 To infoPortalArquivo.portallog.Count - 1
                    If Not datahoraempresavisualizouDateEdit.EditValue Is Nothing Then
                        If Convert.ToDateTime(datahoraempresavisualizouDateEdit.EditValue) >= infoPortalArquivo.portallog(iLista).datahora Then
                            nomeusuarioempresaTextEdit.Text = infoPortalArquivo.portallog(iLista).nome
                            datahoraempresavisualizouDateEdit.EditValue = infoPortalArquivo.portallog(iLista).datahora
                        End If
                    Else
                        nomeusuarioempresaTextEdit.Text = infoPortalArquivo.portallog(iLista).nome
                        datahoraempresavisualizouDateEdit.EditValue = infoPortalArquivo.portallog(iLista).datahora
                    End If
                Next
            End If
            logSimpleButton.Enabled = empresavisualizouCheckButton.Checked
            If empresavisualizouCheckButton.Checked Then
                infoPortalArquivo.portalarquivos(0).empresavisualizou = -1
            Else
                infoPortalArquivo.portalarquivos(0).empresavisualizou = 0
            End If
            infoPortalArquivo.portalarquivos(0).nomeusuarioempresa = nomeusuarioempresaTextEdit.Text
            If Not datahoraempresavisualizouDateEdit.EditValue Is Nothing Then
                infoPortalArquivo.portalarquivos(0).datahoraempresavisualizou = Convert.ToDateTime(datahoraempresavisualizouDateEdit.EditValue)
            Else
                infoPortalArquivo.portalarquivos(0).datahoraempresavisualizou = Nothing
            End If
            objManutencaoObrigacoes.IUDPortalArquivos("alteracao", infoPortalArquivo)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub arquivocompactadoListBoxControl_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles arquivocompactadoListBoxControl.SelectedIndexChanged
        Try
            VisualizaZipDocumento(arquivocompactadoListBoxControl.Text)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LayOutTelaArquivo(blnVisualizador As Boolean)
        visualizaPanelControl.Visible = blnVisualizador
        If blnVisualizador Then
            envioGroupControl.Location = New Point(8, 422)
            empresavisualizouGroupControl.Location = New Point(8, 533)
            voltarSimpleButton.Location = New Point(726, 610)
            Me.Height = 687
            objAdministrativo.CentralizaForm(Me)
        Else
            envioGroupControl.Location = New Point(8, 44)
            empresavisualizouGroupControl.Location = New Point(8, 155)
            voltarSimpleButton.Location = New Point(726, 232)
            Me.Height = 309
            objAdministrativo.CentralizaForm(Me)
        End If
    End Sub

    Private Sub MontaVisualizadoresDocumentos(pblnFullScreen As Boolean)
        arquivoPdfViewer.Visible = False
        arquivoRichEditControl.Visible = False
        arquivoSpreadsheetControl.Visible = False
        navegacaozipPanelControl.Visible = Not pblnFullScreen
        If pblnFullScreen Then
            LayOutTelaArquivo(True)
            arquivoPdfViewer.Dock = DockStyle.Fill
            arquivoPdfViewer.Location = New Point(2, 2)
            arquivoPdfViewer.Width = 776
            arquivoPdfViewer.Height = 369
            arquivoRichEditControl.Dock = DockStyle.Fill
            arquivoRichEditControl.Location = New Point(2, 2)
            arquivoRichEditControl.Width = 776
            arquivoRichEditControl.Height = 369
            arquivoSpreadsheetControl.Dock = DockStyle.Fill
            arquivoSpreadsheetControl.Location = New Point(2, 2)
            arquivoSpreadsheetControl.Width = 776
            arquivoSpreadsheetControl.Height = 369
        Else
            arquivoPdfViewer.Dock = DockStyle.None
            arquivoPdfViewer.Width = 630
            arquivoPdfViewer.Height = 369
            arquivoPdfViewer.Location = New Point(150, 2)
            arquivoRichEditControl.Dock = DockStyle.None
            arquivoRichEditControl.Width = 630
            arquivoRichEditControl.Height = 369
            arquivoRichEditControl.Location = New Point(150, 2)
            arquivoSpreadsheetControl.Dock = DockStyle.None
            arquivoSpreadsheetControl.Width = 630
            arquivoSpreadsheetControl.Height = 369
            arquivoSpreadsheetControl.Location = New Point(150, 2)
        End If
    End Sub

    Private Sub removearquivoSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles removearquivoSimpleButton.Click
        Try
            If arquivocompactadoListBoxControl.Items.Count > 0 Then
                ExcluiArquivoZip(srtPahtFile, arquivocompactadoListBoxControl.Text)
                VisualizaArquivoZip(srtPahtFile)
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub adicionaarquivoSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles adicionaarquivoSimpleButton.Click
        Try
            Using myFileDialog As New OpenFileDialog()
                myFileDialog.Filter = RetornaTipoArquivo()
                myFileDialog.FilterIndex = intDiretorioFiltro
                If String.IsNullOrEmpty(strDiretorioInicial) Then
                    strDiretorioInicial = "C:\"
                End If
                If Not Directory.Exists(Path.GetDirectoryName(strDiretorioInicial)) Then
                    strDiretorioInicial = "C:\"
                End If
                myFileDialog.InitialDirectory = Path.GetDirectoryName(strDiretorioInicial)
                myFileDialog.Title = "Selecione o arquivo para Compactar"
                myFileDialog.CheckFileExists = False
                Dim result As DialogResult = myFileDialog.ShowDialog()
                If result = DialogResult.OK Then
                    CompactaArquivoZip(srtPahtFile, myFileDialog.FileName, True)
                    strDiretorioInicial = myFileDialog.FileName
                End If
                VisualizaArquivoZip(srtPahtFile)
            End Using
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub VisualizaArquivoZip(pstrArquivo As String)
        Try
            Dim strArquivo As String
            arquivocompactadoListBoxControl.Items.Clear()
            Using archive As ZipArchive = ZipFile.OpenRead(pstrArquivo)

                For Each entry As ZipArchiveEntry In archive.Entries
                    If entry.Length <> 0 Then
                        strArquivo = SubstituiCaracteres(entry.FullName.ToString)
                        arquivocompactadoListBoxControl.Items.Add(strArquivo)
                    End If
                Next
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub CompactaArquivoParaZip(pstrArquivoZip As String, pstrArquivo As String)
        Try
            Dim fileArquivo As New FileInfo(pstrArquivo)
            Using zipToOpen As FileStream = New FileStream(pstrArquivoZip, FileMode.Open)
                Using archive As ZipArchive = New ZipArchive(zipToOpen, ZipArchiveMode.Update)
                    Dim readmeEntry As ZipArchiveEntry = archive.CreateEntry(fileArquivo.Name)
                    Using writer As StreamWriter = New StreamWriter(readmeEntry.Open())
                        writer.Write(fileArquivo.Open(FileMode.Open))
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Function SubstituiCaracteres(pstrTexto As String) As String
        Dim strLowerCaracterA() As String = New String() {"à", "â", "ã", "ä", "å", "ç", "è", "é", "ê", "ë", "í", "î", "ï", "ñ", "ò", "ó", "õ", "ø", "ù", "ú", "û", "ý", "ý", "ÿ"}
        Dim strUpperCaracterA() As String = New String() {"À", "Á", "Â", "Ã", "Ä", "Ç", "È", "Ê", "Ë", "Ì", "Í", "Î", "Ï", "Ñ", "Ò", "Ó", "Ô", "Õ", "Ö", "Ù", "Ú", "Û", "Ý", "Ý", "Y"}
        Dim strLowerCaracterB() As String = New String() {"…", "ƒ", "Æ", "„", "†", "‡", "Š", "‚", "ˆ", "‰", "¡", "Œ", "‹", "¤", "•", "¢", "ä", "›", "—", "£", "–", "ì", "ì", "˜"}
        Dim strUpperCaracterB() As String = New String() {"·", "µ", "¶", "Ç", "Ž", "€", "Ô", "Ò", "Ó", "Þ", "Ö", "×", "Ø", "¥", "ã", "à", "â", "å", "™", "ë", "é", "ê", "í", "í", "Y"}

        For Count As Int32 = 0 To strUpperCaracterB.Length - 1 Step 1
            pstrTexto = Replace(pstrTexto, strUpperCaracterB(Count), strUpperCaracterA(Count))
        Next
        For Count As Int32 = 0 To strLowerCaracterB.Length - 1 Step 1
            pstrTexto = Replace(pstrTexto, strLowerCaracterB(Count), strLowerCaracterA(Count))
        Next

        Return pstrTexto
    End Function

    Private Sub CompactaArquivoZip(pstrArquivoZip As String, pstrArquivo As String, pblnAlerta As Boolean)
        Try
            Dim fileArquivo As FileStream = New FileStream(pstrArquivo, FileMode.Open, FileAccess.Read)
            Dim fileinfoArquivo As New FileInfo(pstrArquivo)
            Dim intChar As Integer
            Dim lngPosicao As Long = 0
            Dim bytArquivo() As Byte
            Dim strCodeArquivo As String
            Dim blnValido As Boolean = True

            If Not File.Exists(pstrArquivoZip) Then
                Using zipToCreate As FileStream = New FileStream(pstrArquivoZip, FileMode.Create)
                End Using
            Else
                Using archive As ZipArchive = ZipFile.OpenRead(pstrArquivoZip)
                    For Each entry As ZipArchiveEntry In archive.Entries
                        If entry.Length <> 0 Then
                            If fileinfoArquivo.Name = SubstituiCaracteres(entry.Name) Then
                                blnValido = False
                                Exit For
                            End If
                        End If
                    Next
                End Using
            End If
            If blnValido Then
                Using zipToOpen As FileStream = New FileStream(pstrArquivoZip, FileMode.Open)
                    Using archive As ZipArchive = New ZipArchive(zipToOpen, ZipArchiveMode.Update)
                        Dim readmeEntry As ZipArchiveEntry = archive.CreateEntry(fileinfoArquivo.Name)
                        Using writer As StreamWriter = New StreamWriter(readmeEntry.Open(), Encoding.Default)
                            ReDim bytArquivo(Convert.ToInt32(fileArquivo.Length))
                            Do While Not intChar = -1
                                intChar = fileArquivo.ReadByte
                                If intChar <> -1 Then bytArquivo(Convert.ToInt32(lngPosicao)) = CByte(intChar)
                                lngPosicao += 1
                            Loop
                            strCodeArquivo = Encoding.Default.GetString(bytArquivo).ToString
                            writer.Write(strCodeArquivo)
                            lngPosicao = 0
                        End Using
                    End Using
                End Using
            Else
                If pblnAlerta Then
                    Throw New Exception("Já existe esse arquivo!")
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub ExcluiArquivoZip(pstrArquivoZip As String, pstrNomeArquivo As String)
        Try
            Using zipToOpen As FileStream = New FileStream(pstrArquivoZip, FileMode.Open)
                Using archive As ZipArchive = New ZipArchive(zipToOpen, ZipArchiveMode.Update)
                    For Each entry As ZipArchiveEntry In archive.Entries
                        If entry.Length <> 0 Then
                            If pstrNomeArquivo = SubstituiCaracteres(entry.Name) Then
                                entry.Delete()
                                Exit Sub
                            End If
                        End If
                    Next
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Function RetornaTipoArquivo() As String
        Return "PDF files (*.pdf)|*.pdf|" +
               "Text files (*.txt, *.doc*)|*.txt;*.doc*|" +
               "Excel files (*.xls*, *.xlt*)|*.xls*;*.xlt*|" +
               "All files (*.*)|*.*"
    End Function

    Private Function VerificaPadraoNome(pstrNomeArquivo As String) As Boolean
        Dim blnVerificaPadraoNome As Boolean = False
        Try
            Dim strInformacoesArray() As String = Split(pstrNomeArquivo, "_")
            If strInformacoesArray.Count = 7 Then
                If strInformacoesArray(0).StartsWith("e=") And strInformacoesArray(1).StartsWith("c=") And strInformacoesArray(2).StartsWith("o=") And
                   strInformacoesArray(3).StartsWith("f=") And strInformacoesArray(4).StartsWith("t=") And strInformacoesArray(5).StartsWith("i=") And
                   strInformacoesArray(6).StartsWith("s=") Then
                    blnVerificaPadraoNome = True
                End If
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return blnVerificaPadraoNome
    End Function

    Private Sub portalarquivoXtraForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        voltarSimpleButton_Click(sender, e)
    End Sub
End Class