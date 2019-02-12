Imports Administrativo.Modelo
Imports Administrativo.BLL
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors.Mask

Public Class regrasXtraForm
    Dim objRegras As New RegrasBLL
    Dim objComum As New ComumBLL
    Dim blnCancela As Boolean = False
    Dim intLinhaRegistro As Int32 = 0
    Dim intLinhaSubRegistro As Int32 = -1
    Dim inforegras As regrasinfo

    Dim inforegrasempresas As List(Of regrasempresasinfo)
    Dim inforegrasobrigacoes As List(Of regrasobrigacoesinfo)
    Dim originalinforegrasempresas As List(Of regrasempresasinfo)
    Dim originalinforegrasobrigacoes As List(Of regrasobrigacoesinfo)

    Private Enum enuRegra
        empresa
        obrigacao
    End Enum

    Public Sub New()
        InitializeComponent()
        objComum.Browse("select empresa, razaosocial " +
                          "from empresas " +
                         "where exercicio = " + administrativoInfo.Exercicio.ToString + " order by empresa", empresasInfoBindingSource)
        objComum.Browse("select obrigacao, descricao from admobrigacoes order by obrigacao", obrigacoesInfoBindingSource)
        regrasSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
        empresasSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
        obrigacoesSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
    End Sub

    Private Sub regrasXtraForm_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
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

    Private Sub regrasXtraForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Try
            CarregaGrid()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub regrasXtraForm_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If blnCancela Then
            e.Cancel = True
            Call voltarSimpleButton_Click(sender, e)
            blnCancela = False
        End If
    End Sub

    Private Sub okSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles okSimpleButton.Click
        Try
            SetModelo(okSimpleButton.Tag.ToString)
            regrasSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub voltarSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles voltarSimpleButton.Click
        Try
            RetornaGridFocu()
            LimpaDados()
            regrasSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
            blnCancela = False
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub regrasGridView_DoubleClick(sender As Object, e As System.EventArgs) Handles regrasGridView.DoubleClick
        Try
            If alterarBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always Then
                okSimpleButton.Tag = "alteracao"
                CarregaDados(regrasGridView)
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub regrasGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles regrasGridView.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If alterarBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always Then
                    okSimpleButton.Tag = "alteracao"
                    CarregaDados(regrasGridView)
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

    Private Sub obrigacoesGridView_DoubleClick(sender As Object, e As System.EventArgs) Handles obrigacoesGridView.DoubleClick
        Try
            If okSimpleButton.Tag.ToString <> "exclusao" Then
                confirmarobrigacoesSimpleButton.Tag = "alteracao"
                Dim strField() As String = {"obrigacao", "descricao"}
                CarregaDados(obrigacoesGridView, strField, obrigacaoSearchLookUpEdit, obrigacaodescricaoTextEdit, obrigacoesSplitContainerControl,
                             incluirobrigacoesSimpleButton, alterarobrigacoesSimpleButton, excluirobrigacoesSimpleButton, confirmarobrigacoesSimpleButton, voltarobrigacoesSimpleButton)
                empresaSearchLookUpEdit.Properties.Mask.MaskType = MaskType.Simple
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub empresasGridView_DoubleClick(sender As Object, e As System.EventArgs) Handles empresasGridView.DoubleClick
        Try
            If okSimpleButton.Tag.ToString <> "exclusao" Then
                confirmarempresasSimpleButton.Tag = "alteracao"
                Dim strField() As String = {"empresa", "razaosocial"}
                CarregaDados(empresasGridView, strField, empresaSearchLookUpEdit, razaosocialTextEdit, empresasSplitContainerControl,
                             incluirempresasSimpleButton, alterarempresasSimpleButton, excluirempresasSimpleButton, confirmarempresasSimpleButton, voltarempresasSimpleButton)
                empresaSearchLookUpEdit.Properties.Mask.MaskType = MaskType.Simple
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub incluirBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles incluirBarButtonItem.ItemClick
        Try
            okSimpleButton.Tag = "inclusao"
            HabilitaBotoes(okSimpleButton.Tag.ToString)
            regrasSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
            empresaSearchLookUpEdit.Focus()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub alterarBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles alterarBarButtonItem.ItemClick
        Try
            okSimpleButton.Tag = "alteracao"
            CarregaDados(regrasGridView)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub excluirBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles excluirBarButtonItem.ItemClick
        Try
            okSimpleButton.Tag = "exclusao"
            CarregaDados(regrasGridView)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub localizarBarCheckItem_CheckedChanged(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles localizarBarCheckItem.CheckedChanged
        Try
            regrasGridView.OptionsFind.AlwaysVisible = localizarBarCheckItem.Checked
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub atualizarBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles atualizarBarButtonItem.ItemClick
        Try
            CarregaGrid()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

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

    Private Sub confirmarobrigacoesSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles confirmarobrigacoesSimpleButton.Click
        Try
            VerificaDadosGravacao(enuRegra.obrigacao, obrigacaoSearchLookUpEdit, confirmarobrigacoesSimpleButton)
            SetModelo(enuRegra.obrigacao, obrigacoesGridControl, confirmarobrigacoesSimpleButton)
            HabilitaBotoes(confirmarobrigacoesSimpleButton.Tag.ToString, obrigacoesGridView,
                           incluirobrigacoesSimpleButton, alterarobrigacoesSimpleButton, excluirobrigacoesSimpleButton, confirmarobrigacoesSimpleButton, voltarobrigacoesSimpleButton)
            obrigacoesSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub voltarobrigacoesSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles voltarobrigacoesSimpleButton.Click
        Try
            LimpaDados(enuRegra.obrigacao, confirmarobrigacoesSimpleButton)
            HabilitaBotoes(confirmarobrigacoesSimpleButton.Tag.ToString, obrigacoesGridView,
                           incluirobrigacoesSimpleButton, alterarobrigacoesSimpleButton, excluirobrigacoesSimpleButton, confirmarobrigacoesSimpleButton, voltarobrigacoesSimpleButton)
            obrigacoesSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub incluirempresasSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles incluirempresasSimpleButton.Click
        Try
            confirmarempresasSimpleButton.Tag = "inclusao"
            HabilitaBotoes(confirmarempresasSimpleButton.Tag.ToString, empresasGridView, incluirempresasSimpleButton, alterarempresasSimpleButton, excluirempresasSimpleButton, confirmarempresasSimpleButton, voltarempresasSimpleButton)
            empresasSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
            empresaSearchLookUpEdit.Focus()
            empresaSearchLookUpEdit.Properties.Mask.MaskType = MaskType.Simple
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub alterarempresasSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles alterarempresasSimpleButton.Click
        Try
            confirmarempresasSimpleButton.Tag = "alteracao"
            Dim strField() As String = {"empresa", "razaosocial"}
            CarregaDados(empresasGridView, strField, empresaSearchLookUpEdit, razaosocialTextEdit, empresasSplitContainerControl,
                         incluirempresasSimpleButton, alterarempresasSimpleButton, excluirempresasSimpleButton, confirmarempresasSimpleButton, voltarempresasSimpleButton)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub excluirempresasSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles excluirempresasSimpleButton.Click
        Try
            confirmarempresasSimpleButton.Tag = "exclusao"
            Dim strField() As String = {"empresa", "razaosocial"}
            CarregaDados(empresasGridView, strField, empresaSearchLookUpEdit, razaosocialTextEdit, empresasSplitContainerControl,
                         incluirempresasSimpleButton, alterarempresasSimpleButton, excluirempresasSimpleButton, confirmarempresasSimpleButton, voltarempresasSimpleButton)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub confirmarempresasSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles confirmarempresasSimpleButton.Click
        Try
            VerificaDadosGravacao(enuRegra.empresa, empresaSearchLookUpEdit, confirmarempresasSimpleButton)
            SetModelo(enuRegra.empresa, empresasGridControl, confirmarempresasSimpleButton)
            HabilitaBotoes(confirmarempresasSimpleButton.Tag.ToString, empresasGridView,
                           incluirempresasSimpleButton, alterarempresasSimpleButton, excluirempresasSimpleButton, confirmarempresasSimpleButton, voltarempresasSimpleButton)
            empresasSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub voltarempresasSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles voltarempresasSimpleButton.Click
        Try
            LimpaDados(enuRegra.empresa, confirmarempresasSimpleButton)
            HabilitaBotoes(confirmarempresasSimpleButton.Tag.ToString, empresasGridView,
                           incluirempresasSimpleButton, alterarempresasSimpleButton, excluirempresasSimpleButton, confirmarempresasSimpleButton, voltarempresasSimpleButton)
            empresasSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub empresaSearchLookUpEdit_CustomDisplayText(sender As System.Object, e As DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs) Handles empresaSearchLookUpEdit.CustomDisplayText
        Dim editor As SearchLookUpEdit = TryCast(sender, SearchLookUpEdit)
        If editor.EditValue IsNot Nothing Then
            Dim index As Integer = editor.Properties.GetIndexByKeyValue(editor.EditValue)
            If index >= 0 Then
                razaosocialTextEdit.Text = objComum.RetornaDescricao(empresasInfoBindingSource, index, "razaosocial")
                confirmarempresasSimpleButton.Focus()
            Else
                razaosocialTextEdit.Text = String.Empty
            End If
        Else
            razaosocialTextEdit.Text = String.Empty
        End If
    End Sub

    Private Sub obrigacaoSearchLookUpEdit_CustomDisplayText(sender As System.Object, e As DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs) Handles obrigacaoSearchLookUpEdit.CustomDisplayText
        Dim editor As SearchLookUpEdit = TryCast(sender, SearchLookUpEdit)
        obrigacaoSearchLookUpEdit.Properties.Mask.MaskType = MaskType.Numeric
        If editor.EditValue IsNot Nothing Then
            Dim index As Integer = editor.Properties.GetIndexByKeyValue(editor.EditValue)
            If index >= 0 Then
                obrigacaodescricaoTextEdit.Text = objComum.RetornaDescricao(obrigacoesInfoBindingSource, index, "descricao")
                confirmarobrigacoesSimpleButton.Focus()
            Else
                obrigacaodescricaoTextEdit.Text = String.Empty
            End If
        Else
            obrigacaodescricaoTextEdit.Text = String.Empty
        End If
    End Sub

    Private Sub CarregaGrid()
        Try
            SplashScreenManager.ShowForm(Me, GetType(aguardeWaitForm), True, True, False)
            inforegras = New regrasinfo
            Dim strQuery() As String = {"", "", ""}
            Dim strTitulo() As String = {"Regras", "Obrigações", "Empresas"}
            strQuery(0) = "select ar.regra, ar.descricao " +
                            "from admregras ar " +
                           "where ar.exercicio = " + administrativoInfo.Exercicio.ToString() + " " +
                        "order by ar.regra"
            strQuery(1) = "select aro.regra, aro.obrigacao, o.descricao " +
                            "from admregrasobrigacoes aro " +
                            "join admobrigacoes o on o.obrigacao = aro.obrigacao " +
                            "where aro.exercicio = " + administrativoInfo.Exercicio.ToString() + " " +
                         "order by aro.regra, aro.obrigacao"
            strQuery(2) = "select are.regra, are.empresa, e.razaosocial " +
                            "from admregrasempresas are " +
                            "join empresas e on e.empresa = are.empresa and e.exercicio = are.exercicio " +
                           "where are.exercicio = " + administrativoInfo.Exercicio.ToString() + " " +
                        "order by are.regra, are.empresa"
            objRegras.Grid(strQuery, strTitulo, regrasGridControl, regrasGridView, regrasRibbonControl)
            CarregaOpcao()
            SplashScreenManager.CloseForm()
        Catch ex As Exception
            SplashScreenManager.CloseForm()
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CarregaDados(pgvGrid As GridView)
        Dim intLinha As Integer() = pgvGrid.GetSelectedRows()
        For i As Integer = 0 To intLinha.Length - 1
            If intLinha(i) >= 0 Then
                intLinhaRegistro = intLinha(i)
                regraTextEdit.Text = pgvGrid.GetRowCellValue(intLinha(i), "regra").ToString()
                descricaoTextEdit.Text = pgvGrid.GetRowCellValue(intLinha(i), "descricao").ToString()
                HabilitaBotoes(okSimpleButton.Tag.ToString)
                regrasSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
                regraTextEdit.Focus()
            End If
        Next
    End Sub

    Private Sub CarregaDados(pgvGrid As GridView, pstrField() As String,
                             pFieldSearchLookUpEdit As SearchLookUpEdit, pFieldTextEdit As TextEdit, pSplitContainerControl As SplitContainerControl,
                             incluirbutton As SimpleButton, alterarbutton As SimpleButton, excluirbutton As SimpleButton,
                             confirmarbutton As SimpleButton, voltarbutton As SimpleButton)
        Dim intLinha As Integer() = pgvGrid.GetSelectedRows()
        For i As Integer = 0 To intLinha.Length - 1
            If intLinha(i) >= 0 Then
                pFieldSearchLookUpEdit.EditValue = pgvGrid.GetRowCellValue(intLinha(i), pstrField(0)).ToString()
                pFieldTextEdit.Text = pgvGrid.GetRowCellValue(intLinha(i), pstrField(1)).ToString()
                If pstrField(0).ToString = "empresa" Then
                    RetornaIndexRegistro(enuRegra.empresa, pFieldSearchLookUpEdit.EditValue.ToString)
                ElseIf pstrField(0).ToString = "obrigacao" Then
                    RetornaIndexRegistro(enuRegra.obrigacao, pFieldSearchLookUpEdit.EditValue.ToString)
                End If
                HabilitaBotoes(confirmarbutton.Tag.ToString, pgvGrid, incluirbutton, alterarbutton, excluirbutton, confirmarbutton, voltarbutton)
                pSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
                pFieldSearchLookUpEdit.Focus()
            End If
        Next
    End Sub

    Private Sub CarregaOpcao()
        Dim infoGrupoAcesso As New usuariogruposacessoInfo
        Dim objUsuario As New UsuarioBLL
        infoGrupoAcesso = objUsuario.RetornaGrupoAcessoUsuario("cadreg")

        If regrasRibbonControl.Items.Count > 0 Then
            For index = 0 To regrasRibbonControl.Items.Count - 1
                If regrasRibbonControl.Items(index).Tag IsNot Nothing Then
                    If objUsuario.UsuarioTemAcesso(infoGrupoAcesso, regrasRibbonControl.Items(index).Tag.ToString) Then
                        regrasRibbonControl.Items(index).Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    Else
                        regrasRibbonControl.Items(index).Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub HabilitaBotoes(pstrOperacao As String)
        incluirBarButtonItem.Enabled = (pstrOperacao = String.Empty)
        localizarBarCheckItem.Enabled = (pstrOperacao = String.Empty)
        atualizarBarButtonItem.Enabled = (pstrOperacao = String.Empty)
        alterarBarButtonItem.Enabled = (pstrOperacao = String.Empty And regrasGridView.RowCount > 0)
        excluirBarButtonItem.Enabled = (pstrOperacao = String.Empty And regrasGridView.RowCount > 0)
        If okSimpleButton.Tag.ToString = "exclusao" Then
            okSimpleButton.Text = "Excluir"
            okSimpleButton.ImageIndex = 1
            intLinhaRegistro = 0
            obrigacoesPanelControl.Enabled = False
            empresasPanelControl.Enabled = False
        Else
            okSimpleButton.Text = "OK"
            okSimpleButton.ImageIndex = 0
            obrigacoesPanelControl.Enabled = True
            empresasPanelControl.Enabled = True
        End If
        If Not String.IsNullOrEmpty(pstrOperacao) Then
            inforegras = New regrasinfo
            If okSimpleButton.Tag.ToString <> "inclusao" Then
                inforegras.regra = Convert.ToInt32(regraTextEdit.Text)
            End If
            inforegras.descricao = descricaoTextEdit.Text.ToString
            Dim strQuery As String = "select are.empresa, e.razaosocial " +
                                       "from admregrasempresas are " +
                                       "join empresas e on e.empresa = are.empresa and e.exercicio = are.exercicio " +
                                      "where are.regra = " + inforegras.regra.ToString + " " +
                                        "and are.exercicio = " + administrativoInfo.Exercicio.ToString() + " " +
                                   "order by are.empresa"
            inforegrasempresas = New List(Of regrasempresasinfo)
            objRegras.Grid(strQuery, empresasGridControl, empresasGridView, inforegrasempresas)
            inforegras.empresas = inforegrasempresas
            originalinforegrasempresas = New List(Of regrasempresasinfo)
            For index = 0 To inforegrasempresas.Count - 1
                Dim empresasinfo As New regrasempresasinfo(inforegrasempresas(index).empresa.ToString(), inforegrasempresas(index).razaosocial.ToString())
                originalinforegrasempresas.Add(empresasinfo)
            Next
            HabilitaBotoes(String.Empty, empresasGridView,
                           incluirempresasSimpleButton, alterarempresasSimpleButton, excluirempresasSimpleButton, confirmarempresasSimpleButton, voltarempresasSimpleButton)

            strQuery = "select aro.obrigacao, o.descricao " +
                         "from admregrasobrigacoes aro " +
                         "join admobrigacoes o on o.obrigacao = aro.obrigacao " +
                        "where aro.regra = " + inforegras.regra.ToString + " " +
                          "and aro.exercicio = " + administrativoInfo.Exercicio.ToString() + " " +
                     "order by aro.obrigacao"
            inforegrasobrigacoes = New List(Of regrasobrigacoesinfo)
            objRegras.Grid(strQuery, obrigacoesGridControl, obrigacoesGridView, inforegrasobrigacoes)
            inforegras.obrigacoes = inforegrasobrigacoes
            originalinforegrasobrigacoes = New List(Of regrasobrigacoesinfo)
            For index = 0 To inforegrasobrigacoes.Count - 1
                Dim obrigacoesinfo As New regrasobrigacoesinfo(inforegrasobrigacoes(index).obrigacao.ToString(), inforegrasobrigacoes(index).descricao.ToString())
                originalinforegrasobrigacoes.Add(obrigacoesinfo)
            Next
            HabilitaBotoes(String.Empty, obrigacoesGridView,
                           incluirobrigacoesSimpleButton, alterarobrigacoesSimpleButton, excluirobrigacoesSimpleButton, confirmarobrigacoesSimpleButton, voltarobrigacoesSimpleButton)
        End If
        If okSimpleButton.Tag.ToString <> String.Empty Then
            Me.AcceptButton = okSimpleButton
        End If
    End Sub

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

    Private Sub LimpaDados()
        inforegras = Nothing
        regraTextEdit.Text = String.Empty
        descricaoTextEdit.Text = String.Empty

        obrigacoesGridControl.DataSource = Nothing
        inforegrasobrigacoes = Nothing
        originalinforegrasobrigacoes = Nothing
        If obrigacoesSplitContainerControl.PanelVisibility = SplitPanelVisibility.Panel1 Then
            LimpaDados(enuRegra.obrigacao, confirmarobrigacoesSimpleButton)
            obrigacoesSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
        End If

        empresasGridControl.DataSource = Nothing
        inforegrasempresas = Nothing
        originalinforegrasempresas = Nothing
        If empresasSplitContainerControl.PanelVisibility = SplitPanelVisibility.Panel1 Then
            LimpaDados(enuRegra.empresa, confirmarempresasSimpleButton)
            empresasSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
        End If

        okSimpleButton.Tag = String.Empty
        Me.AcceptButton = Nothing
        intLinhaRegistro = 0
        HabilitaBotoes(okSimpleButton.Tag.ToString)
    End Sub

    Private Sub LimpaDados(penuRegra As enuRegra, confirmarbutton As SimpleButton)
        If penuRegra = enuRegra.obrigacao Then
            obrigacaoSearchLookUpEdit.EditValue = String.Empty
            obrigacaodescricaoTextEdit.Text = String.Empty
        ElseIf penuRegra = enuRegra.empresa Then
            empresaSearchLookUpEdit.EditValue = String.Empty
            razaosocialTextEdit.Text = String.Empty
        End If
        intLinhaSubRegistro = -1
        confirmarbutton.Tag = String.Empty
    End Sub

    Private Sub SetModelo(pstrOperacao As String)
        If pstrOperacao = "inclusao" Then
            inforegras.regra = objRegras.ProximaRegra()
        Else
            inforegras.regra = Convert.ToInt32(regraTextEdit.Text.ToString)
        End If
        inforegras.descricao = descricaoTextEdit.Text.ToString
        inforegras.empresas = inforegrasempresas
        inforegras.obrigacoes = inforegrasobrigacoes
        objRegras.IUDRegras(pstrOperacao, inforegras, originalinforegrasempresas, originalinforegrasobrigacoes)
        RetornaGridFocu()
        LimpaDados()
    End Sub

    Private Sub SetModelo(penuRegra As enuRegra, pdgGrid As GridControl, confirmarbutton As SimpleButton)
        If penuRegra = enuRegra.empresa Then
            If confirmarbutton.Tag.ToString = "inclusao" Then
                Dim empresasinfo As New regrasempresasinfo(empresaSearchLookUpEdit.EditValue.ToString, razaosocialTextEdit.Text)
                inforegrasempresas.Add(empresasinfo)
            ElseIf confirmarbutton.Tag.ToString = "alteracao" Then
                inforegrasempresas(intLinhaSubRegistro).empresa = empresaSearchLookUpEdit.EditValue.ToString
                inforegrasempresas(intLinhaSubRegistro).razaosocial = razaosocialTextEdit.Text
            ElseIf confirmarbutton.Tag.ToString = "exclusao" Then
                inforegrasempresas.Remove(inforegrasempresas(intLinhaSubRegistro))
            End If
            pdgGrid.DataSource = Nothing
            pdgGrid.DataSource = inforegrasempresas
            pdgGrid.ForceInitialize()
            inforegras.empresas = inforegrasempresas
        ElseIf penuRegra = enuRegra.obrigacao Then
            If confirmarbutton.Tag.ToString = "inclusao" Then
                Dim obrigacoesinfo As New regrasobrigacoesinfo(obrigacaoSearchLookUpEdit.EditValue.ToString, obrigacaodescricaoTextEdit.Text)
                inforegrasobrigacoes.Add(obrigacoesinfo)
            ElseIf confirmarbutton.Tag.ToString = "alteracao" Then
                inforegrasobrigacoes(intLinhaSubRegistro).obrigacao = obrigacaoSearchLookUpEdit.EditValue.ToString
                inforegrasobrigacoes(intLinhaSubRegistro).descricao = obrigacaodescricaoTextEdit.Text
            ElseIf confirmarbutton.Tag.ToString = "exclusao" Then
                inforegrasobrigacoes.Remove(inforegrasobrigacoes(intLinhaSubRegistro))
            End If
            pdgGrid.DataSource = Nothing
            pdgGrid.DataSource = inforegrasobrigacoes
            pdgGrid.ForceInitialize()
            inforegras.obrigacoes = inforegrasobrigacoes
        End If
        LimpaDados(penuRegra, confirmarbutton)
    End Sub

    Private Sub VerificaDadosGravacao(penuRegra As enuRegra, pCampoChave As SearchLookUpEdit, confirmarbutton As SimpleButton)
        If penuRegra = enuRegra.empresa Then
            For index = 0 To inforegrasempresas.Count - 1
                If confirmarbutton.Tag.ToString = "inclusao" Then
                    If inforegrasempresas(index).empresa = pCampoChave.EditValue.ToString Then
                        Throw New Exception("Já existe uma empresa cadastrada")
                        Exit For
                    End If
                ElseIf confirmarbutton.Tag.ToString = "alteracao" Then
                    If index <> intLinhaSubRegistro Then
                        If inforegrasempresas(index).empresa = pCampoChave.EditValue.ToString Then
                            Throw New Exception("Já existe uma empresa cadastrada")
                            Exit For
                        End If
                    End If
                End If
            Next
            If String.IsNullOrEmpty(pCampoChave.EditValue.ToString) Then Throw New Exception("O código da empresa é obrigatório")
        ElseIf penuRegra = enuRegra.obrigacao Then
            For index = 0 To inforegrasobrigacoes.Count - 1
                If confirmarbutton.Tag.ToString = "inclusao" Then
                    If inforegrasobrigacoes(index).obrigacao = pCampoChave.EditValue.ToString Then
                        Throw New Exception("Já existe uma obrigação cadastrada")
                        Exit For
                    End If
                ElseIf confirmarbutton.Tag.ToString = "alteracao" Then
                    If index <> intLinhaSubRegistro Then
                        If inforegrasobrigacoes(index).obrigacao = pCampoChave.EditValue.ToString Then
                            Throw New Exception("Já existe uma obrigação cadastrada")
                            Exit For
                        End If
                    End If
                End If
            Next
            If String.IsNullOrEmpty(pCampoChave.EditValue.ToString) Then Throw New Exception("O código da obrigação é obrigatório")
        End If
    End Sub

    Private Sub RetornaGridFocu()
        CarregaGrid()
        If intLinhaRegistro >= 0 And okSimpleButton.Tag.ToString <> "exclusao" Then
            regrasGridView.FocusedRowHandle = intLinhaRegistro
        End If
    End Sub

    Private Sub RetornaIndexRegistro(penuRegra As enuRegra, pstrValor As String)
        If penuRegra = enuRegra.obrigacao Then
            For index = 0 To inforegrasobrigacoes.Count - 1
                If inforegrasobrigacoes(index).obrigacao = pstrValor Then
                    intLinhaSubRegistro = index
                End If
            Next
        ElseIf penuRegra = enuRegra.empresa Then
            For index = 0 To inforegrasempresas.Count - 1
                If inforegrasempresas(index).empresa = pstrValor Then
                    intLinhaSubRegistro = index
                End If
            Next
        End If
    End Sub
End Class