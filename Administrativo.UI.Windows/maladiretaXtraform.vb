Imports Administrativo.Modelo
Imports Administrativo.BLL
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors.Mask

Public Class maladiretaXtraform

    Dim objMaladireta As New MaladiretaBLL
    Dim objComum As New ComumBLL
    Dim blnCancela As Boolean = False
    Dim intLinhaRegistro As Int32 = 0
    Dim intLinhaSubRegistro As Int32 = -1
    Dim infoMaladireta As maladiretaInfo

    Dim infoMaladiretaobrigacoes As List(Of maladiretaobrigacoesInfo)
    Dim originalinfoMaladiretaobrigacoes As List(Of maladiretaobrigacoesInfo)

    Private Enum enuMaladireta
        obrigacao
    End Enum

    Public Sub New()
        InitializeComponent()
        objComum.Browse("select obrigacao, descricao from admobrigacoes order by obrigacao", obrigacoesInfoBindingSource)
        maladiretaSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
        obrigacoesSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub maladiretaXtraForm_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            If e.KeyCode = Keys.F5 Then
                If atualizarBarButtonItem.Enabled Then
                    CarregaGrid()
                End If
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub maladiretaXtraForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Try
            CarregaGrid()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub maladiretaXtraForm_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If blnCancela Then
            e.Cancel = True
            Call voltarSimpleButton_Click(sender, e)
            blnCancela = False
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub okSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles okSimpleButton.Click
        Try
            SetModelo(okSimpleButton.Tag.ToString)
            maladiretaSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub voltarSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles voltarSimpleButton.Click
        Try
            RetornaGridFocu()
            LimpaDados()
            maladiretaSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
            blnCancela = False
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub maladiretaGridView_DoubleClick(sender As Object, e As System.EventArgs) Handles maladiretaGridView.DoubleClick
        Try
            If alterarBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always Then
                okSimpleButton.Tag = "alteracao"
                CarregaDados(maladiretaGridView)
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub maladiretaGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles maladiretaGridView.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If alterarBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always Then
                    okSimpleButton.Tag = "alteracao"
                    CarregaDados(maladiretaGridView)
                End If
            ElseIf e.KeyCode = Keys.F5 Then
                If atualizarBarButtonItem.Enabled Then
                    CarregaGrid()
                End If
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub obrigacoesGridView_DoubleClick(sender As Object, e As System.EventArgs) Handles obrigacoesGridView.DoubleClick
        Try
            If okSimpleButton.Tag.ToString <> "exclusao" Then
                confirmarobrigacoesSimpleButton.Tag = "alteracao"
                Dim strField() As String = {"obrigacao", "descricao"}
                CarregaDados(obrigacoesGridView, strField, obrigacaoSearchLookUpEdit, obrigacaodescricaoTextEdit, obrigacoesSplitContainerControl,
                             incluirobrigacoesSimpleButton, alterarobrigacoesSimpleButton, excluirobrigacoesSimpleButton, confirmarobrigacoesSimpleButton, voltarobrigacoesSimpleButton)
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub incluirBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles incluirBarButtonItem.ItemClick
        Try
            okSimpleButton.Tag = "inclusao"
            HabilitaBotoes(okSimpleButton.Tag.ToString)
            maladiretaSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub alterarBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles alterarBarButtonItem.ItemClick
        Try
            okSimpleButton.Tag = "alteracao"
            CarregaDados(maladiretaGridView)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub excluirBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles excluirBarButtonItem.ItemClick
        Try
            okSimpleButton.Tag = "exclusao"
            CarregaDados(maladiretaGridView)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub localizarBarCheckItem_CheckedChanged(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles localizarBarCheckItem.CheckedChanged
        Try
            maladiretaGridView.OptionsFind.AlwaysVisible = localizarBarCheckItem.Checked
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub atualizarBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles atualizarBarButtonItem.ItemClick
        Try
            CarregaGrid()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub incluirobrigacoesSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles incluirobrigacoesSimpleButton.Click
        Try
            confirmarobrigacoesSimpleButton.Tag = "inclusao"
            HabilitaBotoes(confirmarobrigacoesSimpleButton.Tag.ToString, obrigacoesGridView,
                           incluirobrigacoesSimpleButton, alterarobrigacoesSimpleButton, excluirobrigacoesSimpleButton, confirmarobrigacoesSimpleButton, voltarobrigacoesSimpleButton)
            obrigacoesSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
            obrigacaoSearchLookUpEdit.Focus()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub alterarobrigacoesSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles alterarobrigacoesSimpleButton.Click
        Try
            confirmarobrigacoesSimpleButton.Tag = "alteracao"
            Dim strField() As String = {"obrigacao", "descricao"}
            CarregaDados(obrigacoesGridView, strField, obrigacaoSearchLookUpEdit, obrigacaodescricaoTextEdit, obrigacoesSplitContainerControl,
                         incluirobrigacoesSimpleButton, alterarobrigacoesSimpleButton, excluirobrigacoesSimpleButton, confirmarobrigacoesSimpleButton, voltarobrigacoesSimpleButton)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub excluirobrigacoesSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles excluirobrigacoesSimpleButton.Click
        Try
            confirmarobrigacoesSimpleButton.Tag = "exclusao"
            Dim strField() As String = {"obrigacao", "descricao"}
            CarregaDados(obrigacoesGridView, strField, obrigacaoSearchLookUpEdit, obrigacaodescricaoTextEdit, obrigacoesSplitContainerControl,
                         incluirobrigacoesSimpleButton, alterarobrigacoesSimpleButton, excluirobrigacoesSimpleButton, confirmarobrigacoesSimpleButton, voltarobrigacoesSimpleButton)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub confirmarobrigacoesSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles confirmarobrigacoesSimpleButton.Click
        Try
            VerificaDadosGravacao(enuMaladireta.obrigacao, obrigacaoSearchLookUpEdit, confirmarobrigacoesSimpleButton)
            SetModelo(enuMaladireta.obrigacao, obrigacoesGridControl, confirmarobrigacoesSimpleButton)
            HabilitaBotoes(confirmarobrigacoesSimpleButton.Tag.ToString, obrigacoesGridView,
                           incluirobrigacoesSimpleButton, alterarobrigacoesSimpleButton, excluirobrigacoesSimpleButton, confirmarobrigacoesSimpleButton, voltarobrigacoesSimpleButton)
            obrigacoesSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub voltarobrigacoesSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles voltarobrigacoesSimpleButton.Click
        Try
            LimpaDados(enuMaladireta.obrigacao, confirmarobrigacoesSimpleButton)
            HabilitaBotoes(confirmarobrigacoesSimpleButton.Tag.ToString, obrigacoesGridView,
                           incluirobrigacoesSimpleButton, alterarobrigacoesSimpleButton, excluirobrigacoesSimpleButton, confirmarobrigacoesSimpleButton, voltarobrigacoesSimpleButton)
            obrigacoesSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub obrigacaoSearchLookUpEdit_CustomDisplayText(sender As System.Object, e As DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs) Handles obrigacaoSearchLookUpEdit.CustomDisplayText
        Dim editor As SearchLookUpEdit = TryCast(sender, SearchLookUpEdit)

        If editor.EditValue IsNot Nothing Then
            Dim index As Integer = editor.Properties.GetIndexByKeyValue(editor.EditValue)
            If index >= 0 Then
                obrigacaodescricaoTextEdit.Text = objComum.RetornaDescricao(obrigacoesInfoBindingSource, index, "descricao")
            Else
                obrigacaodescricaoTextEdit.Text = String.Empty
            End If
        Else
            obrigacaodescricaoTextEdit.Text = String.Empty
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub palavrareservadaListBoxControl_DoubleClick(sender As Object, e As System.EventArgs) Handles palavrareservadaListBoxControl.DoubleClick
        If Not palavrareservadaListBoxControl.SelectedItem Is Nothing Then
            Dim intPosition As Integer
            mensagemMemoEdit.Text = mensagemMemoEdit.Text.Insert(mensagemMemoEdit.SelectionStart, " <" + objMaladireta.CarregaPalavraReservada(categoriapalavrareservadaComboBoxEdit.SelectedItem.ToString, palavrareservadaListBoxControl.SelectedItem.ToString) + "> <!!>")
            intPosition = mensagemMemoEdit.Text.IndexOf("<!!>")
            mensagemMemoEdit.Text = mensagemMemoEdit.Text.Replace("<!!>", "")
            mensagemMemoEdit.Focus()
            mensagemMemoEdit.SelectionStart = intPosition
            mensagemMemoEdit.SelectionLength = 0
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub categoriapalavrareservadaComboBoxEdit_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles categoriapalavrareservadaComboBoxEdit.SelectedIndexChanged
        palavrareservadaListBoxControl.Items.Clear()
        If Not categoriapalavrareservadaComboBoxEdit.SelectedItem.ToString = "" Then
            objMaladireta.CarregaListaPalavraReservada(palavrareservadaListBoxControl, categoriapalavrareservadaComboBoxEdit.SelectedItem.ToString)
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CarregaGrid()
        Try
            SplashScreenManager.ShowForm(Me, GetType(aguardeWaitForm), True, True, False)
            infoMaladireta = New maladiretaInfo
            Dim strQuery() As String = {"", "", ""}
            Dim strTitulo() As String = {"Mala Direta", "Obrigações"}
            strQuery(0) = "select am.maladireta, am.descricao, am.mensagem " +
                            "from admmaladireta am " +
                        "order by am.maladireta"
            strQuery(1) = "select amo.maladireta, amo.obrigacao, o.descricao " +
                            "from admmaladiretaobrigacoes amo " +
                            "join admobrigacoes o on o.obrigacao = amo.obrigacao " +
                         "order by amo.maladireta, amo.obrigacao"
            objMaladireta.Grid(strQuery, strTitulo, maladiretaGridControl, maladiretaGridView, maladiretaRibbonControl)
            CarregaOpcao()
            SplashScreenManager.CloseForm()
        Catch ex As Exception
            SplashScreenManager.CloseForm()
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="pgvGrid"></param>
    ''' <remarks></remarks>
    Private Sub CarregaDados(pgvGrid As GridView)
        Dim intLinha As Integer() = pgvGrid.GetSelectedRows()
        For i As Integer = 0 To intLinha.Length - 1
            If intLinha(i) >= 0 Then
                intLinhaRegistro = intLinha(i)
                maladiretaTextEdit.Text = pgvGrid.GetRowCellValue(intLinha(i), "maladireta").ToString()
                descricaoTextEdit.Text = pgvGrid.GetRowCellValue(intLinha(i), "descricao").ToString()
                mensagemMemoEdit.Text = pgvGrid.GetRowCellValue(intLinha(i), "mensagem").ToString()
                HabilitaBotoes(okSimpleButton.Tag.ToString)
                maladiretaSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
                maladiretaTextEdit.Focus()
            End If
        Next
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="pgvGrid"></param>
    ''' <param name="pstrField"></param>
    ''' <param name="pFieldSearchLookUpEdit"></param>
    ''' <param name="pFieldTextEdit"></param>
    ''' <param name="pSplitContainerControl"></param>
    ''' <param name="incluirbutton"></param>
    ''' <param name="alterarbutton"></param>
    ''' <param name="excluirbutton"></param>
    ''' <param name="confirmarbutton"></param>
    ''' <param name="voltarbutton"></param>
    ''' <remarks></remarks>
    Private Sub CarregaDados(pgvGrid As GridView, pstrField() As String,
                             pFieldSearchLookUpEdit As SearchLookUpEdit, pFieldTextEdit As TextEdit, pSplitContainerControl As SplitContainerControl,
                             incluirbutton As SimpleButton, alterarbutton As SimpleButton, excluirbutton As SimpleButton,
                             confirmarbutton As SimpleButton, voltarbutton As SimpleButton)
        Dim intLinha As Integer() = pgvGrid.GetSelectedRows()
        For i As Integer = 0 To intLinha.Length - 1
            If intLinha(i) >= 0 Then
                pFieldSearchLookUpEdit.EditValue = pgvGrid.GetRowCellValue(intLinha(i), pstrField(0)).ToString()
                pFieldTextEdit.Text = pgvGrid.GetRowCellValue(intLinha(i), pstrField(1)).ToString()
                RetornaIndexRegistro(enuMaladireta.obrigacao, pFieldSearchLookUpEdit.EditValue.ToString)
                HabilitaBotoes(confirmarbutton.Tag.ToString, pgvGrid, incluirbutton, alterarbutton, excluirbutton, confirmarbutton, voltarbutton)
                pSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
                pFieldSearchLookUpEdit.Focus()
            End If
        Next
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CarregaOpcao()
        Dim infoGrupoAcesso As New usuariogruposacessoInfo
        Dim objUsuario As New UsuarioBLL
        infoGrupoAcesso = objUsuario.RetornaGrupoAcessoUsuario("cadmal")

        If maladiretaRibbonControl.Items.Count > 0 Then
            For index = 0 To maladiretaRibbonControl.Items.Count - 1
                If maladiretaRibbonControl.Items(index).Tag IsNot Nothing Then
                    If objUsuario.UsuarioTemAcesso(infoGrupoAcesso, maladiretaRibbonControl.Items(index).Tag.ToString) Then
                        maladiretaRibbonControl.Items(index).Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    Else
                        maladiretaRibbonControl.Items(index).Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    End If
                End If
            Next
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="pstrOperacao"></param>
    ''' <remarks></remarks>
    Private Sub HabilitaBotoes(pstrOperacao As String)
        Dim strQuery As String
        incluirBarButtonItem.Enabled = (pstrOperacao = String.Empty)
        localizarBarCheckItem.Enabled = (pstrOperacao = String.Empty)
        atualizarBarButtonItem.Enabled = (pstrOperacao = String.Empty)
        alterarBarButtonItem.Enabled = (pstrOperacao = String.Empty And maladiretaGridView.RowCount > 0)
        excluirBarButtonItem.Enabled = (pstrOperacao = String.Empty And maladiretaGridView.RowCount > 0)
        If okSimpleButton.Tag.ToString = "exclusao" Then
            okSimpleButton.Text = "Excluir"
            okSimpleButton.ImageIndex = 1
            intLinhaRegistro = 0
            obrigacoesPanelControl.Enabled = False
        Else
            okSimpleButton.Text = "OK"
            okSimpleButton.ImageIndex = 0
            obrigacoesPanelControl.Enabled = True
        End If
        If Not String.IsNullOrEmpty(pstrOperacao) Then
            infoMaladireta = New maladiretaInfo
            If okSimpleButton.Tag.ToString <> "inclusao" Then
                infoMaladireta.maladireta = Convert.ToInt32(maladiretaTextEdit.Text)
            End If
            infoMaladireta.mensagem = mensagemMemoEdit.Text.ToString
            strQuery = "select amo.obrigacao, o.descricao " +
                         "from admmaladiretaobrigacoes amo " +
                         "join admobrigacoes o on o.obrigacao = amo.obrigacao " +
                        "where amo.maladireta = " + infoMaladireta.maladireta.ToString + " " +
                     "order by amo.obrigacao"
            infoMaladiretaobrigacoes = New List(Of maladiretaobrigacoesInfo)
            objMaladireta.Grid(strQuery, obrigacoesGridControl, obrigacoesGridView, infoMaladiretaobrigacoes)
            infoMaladireta.obrigacoes = infoMaladiretaobrigacoes
            originalinfoMaladiretaobrigacoes = New List(Of maladiretaobrigacoesInfo)
            objMaladireta.CarregaCombopalavraReservada(categoriapalavrareservadaComboBoxEdit)
            categoriapalavrareservadaComboBoxEdit.Text = String.Empty
            For index = 0 To infoMaladiretaobrigacoes.Count - 1
                Dim obrigacoesinfo As New maladiretaobrigacoesInfo(infoMaladiretaobrigacoes(index).obrigacao.ToString(), infoMaladiretaobrigacoes(index).descricao.ToString())
                originalinfoMaladiretaobrigacoes.Add(obrigacoesinfo)
            Next
            HabilitaBotoes(String.Empty, obrigacoesGridView,
                           incluirobrigacoesSimpleButton, alterarobrigacoesSimpleButton, excluirobrigacoesSimpleButton, confirmarobrigacoesSimpleButton, voltarobrigacoesSimpleButton)
        End If
        If okSimpleButton.Tag.ToString <> String.Empty Then
            Me.AcceptButton = okSimpleButton
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="pstrOperacao"></param>
    ''' <param name="pgvItens"></param>
    ''' <param name="incluirbutton"></param>
    ''' <param name="alterarbutton"></param>
    ''' <param name="excluirbutton"></param>
    ''' <param name="confirmarbutton"></param>
    ''' <param name="voltarbutton"></param>
    ''' <remarks></remarks>
    Private Sub HabilitaBotoes(pstrOperacao As String, pgvItens As GridView,
                               incluirbutton As SimpleButton, alterarbutton As SimpleButton, excluirbutton As SimpleButton,
                               confirmarbutton As SimpleButton, voltarbutton As SimpleButton)
        incluirbutton.Enabled = (pstrOperacao = String.Empty)
        alterarbutton.Enabled = (pstrOperacao = String.Empty And pgvItens.RowCount > 0)
        excluirbutton.Enabled = (pstrOperacao = String.Empty And pgvItens.RowCount > 0)
        confirmarbutton.Enabled = (pstrOperacao <> String.Empty)
        voltarbutton.Enabled = (pstrOperacao <> String.Empty)
        If Not IsNothing(confirmarbutton.Tag) Then
            If confirmarbutton.Tag.ToString = "exclusao" Then
                confirmarbutton.ImageIndex = 3
            Else
                confirmarbutton.ImageIndex = 2
            End If
            okSimpleButton.Enabled = (confirmarbutton.Tag.ToString = String.Empty)
            If confirmarbutton.Tag.ToString = String.Empty Then
                Me.AcceptButton = okSimpleButton
            Else
                Me.AcceptButton = Nothing
            End If
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LimpaDados()
        infoMaladireta = Nothing
        maladiretaTextEdit.Text = String.Empty
        descricaoTextEdit.Text = String.Empty
        mensagemMemoEdit.Text = String.Empty

        obrigacoesGridControl.DataSource = Nothing
        infoMaladiretaobrigacoes = Nothing
        originalinfoMaladiretaobrigacoes = Nothing
        If obrigacoesSplitContainerControl.PanelVisibility = SplitPanelVisibility.Panel1 Then
            LimpaDados(enuMaladireta.obrigacao, confirmarobrigacoesSimpleButton)
            obrigacoesSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
        End If
        okSimpleButton.Tag = String.Empty
        Me.AcceptButton = Nothing
        intLinhaRegistro = 0
        HabilitaBotoes(okSimpleButton.Tag.ToString)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="penuMaladireta"></param>
    ''' <param name="confirmarbutton"></param>
    ''' <remarks></remarks>
    Private Sub LimpaDados(penuMaladireta As enuMaladireta, confirmarbutton As SimpleButton)
        obrigacaoSearchLookUpEdit.EditValue = String.Empty
        obrigacaodescricaoTextEdit.Text = String.Empty
        intLinhaSubRegistro = -1
        confirmarbutton.Tag = String.Empty
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="pstrOperacao"></param>
    ''' <remarks></remarks>
    Private Sub SetModelo(pstrOperacao As String)
        If pstrOperacao = "inclusao" Then
            infoMaladireta.maladireta = objMaladireta.ProximaMaladireta()
        Else
            infoMaladireta.maladireta = Convert.ToInt32(maladiretaTextEdit.Text.ToString)
        End If
        infoMaladireta.mensagem = mensagemMemoEdit.Text.ToString
        infoMaladireta.descricao = descricaoTextEdit.Text
        infoMaladireta.obrigacoes = infoMaladiretaobrigacoes
        objMaladireta.IUDMaladireta(pstrOperacao, infoMaladireta, originalinfoMaladiretaobrigacoes)
        RetornaGridFocu()
        LimpaDados()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="penuMaladireta"></param>
    ''' <param name="pdgGrid"></param>
    ''' <param name="confirmarbutton"></param>
    ''' <remarks></remarks>
    Private Sub SetModelo(penuMaladireta As enuMaladireta, pdgGrid As GridControl, confirmarbutton As SimpleButton)
        If confirmarbutton.Tag.ToString = "inclusao" Then
            Dim obrigacoesinfo As New maladiretaobrigacoesInfo(obrigacaoSearchLookUpEdit.EditValue.ToString, obrigacaodescricaoTextEdit.Text)
            infoMaladiretaobrigacoes.Add(obrigacoesinfo)
        ElseIf confirmarbutton.Tag.ToString = "alteracao" Then
            infoMaladiretaobrigacoes(intLinhaSubRegistro).obrigacao = obrigacaoSearchLookUpEdit.EditValue.ToString
            infoMaladiretaobrigacoes(intLinhaSubRegistro).descricao = obrigacaodescricaoTextEdit.Text
        ElseIf confirmarbutton.Tag.ToString = "exclusao" Then
            infoMaladiretaobrigacoes.Remove(infoMaladiretaobrigacoes(intLinhaSubRegistro))
        End If
        pdgGrid.DataSource = Nothing
        pdgGrid.DataSource = infoMaladiretaobrigacoes
        pdgGrid.ForceInitialize()
        infoMaladireta.obrigacoes = infoMaladiretaobrigacoes
        LimpaDados(penuMaladireta, confirmarbutton)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="penuMaladireta"></param>
    ''' <param name="pCampoChave"></param>
    ''' <param name="confirmarbutton"></param>
    ''' <remarks></remarks>
    Private Sub VerificaDadosGravacao(penuMaladireta As enuMaladireta, pCampoChave As SearchLookUpEdit, confirmarbutton As SimpleButton)
        If confirmarobrigacoesSimpleButton.Tag.ToString <> "exclusao" Then
            Dim strObrigacao As String = String.Empty
            If pCampoChave.EditValue IsNot Nothing Then
                strObrigacao = pCampoChave.EditValue.ToString
            End If
            If String.IsNullOrEmpty(strObrigacao) Then Throw New Exception("O código da obrigação é obrigatório")
            For index = 0 To infoMaladiretaobrigacoes.Count - 1
                If infoMaladiretaobrigacoes(index).obrigacao = pCampoChave.EditValue.ToString Then
                    Throw New Exception("Já existe uma obrigação cadastrada")
                    Exit For
                End If
            Next
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub RetornaGridFocu()
        CarregaGrid()
        If intLinhaRegistro >= 0 And okSimpleButton.Tag.ToString <> "exclusao" Then
            maladiretaGridView.FocusedRowHandle = intLinhaRegistro
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="penuMaladireta"></param>
    ''' <param name="pstrValor"></param>
    ''' <remarks></remarks>
    Private Sub RetornaIndexRegistro(penuMaladireta As enuMaladireta, pstrValor As String)
        For index = 0 To infoMaladiretaobrigacoes.Count - 1
            If infoMaladiretaobrigacoes(index).obrigacao = pstrValor Then
                intLinhaSubRegistro = index
            End If
        Next
    End Sub

    Private Sub obrigacaoSearchLookUpEdit_EditValueChanged(sender As Object, e As EventArgs) Handles obrigacaoSearchLookUpEdit.EditValueChanged
        confirmarobrigacoesSimpleButton.Focus()
    End Sub
End Class