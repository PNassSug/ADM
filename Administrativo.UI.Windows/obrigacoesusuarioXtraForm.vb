Imports Administrativo.Modelo
Imports Administrativo.BLL
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors.Mask

Public Class obrigacoesusuarioXtraForm
    Dim objObrigacoes As New ObrigacoesBLL
    Dim objComum As New ComumBLL
    Dim blnCancela As Boolean = False
    Dim intLinhaRegistro As Int32 = 0
    Dim intLinhaSubRegistro As Int32 = -1
    Dim infoobrigacoesusuarios As obrigacoesusuariosInfo

    Dim infoobrigacoes As List(Of obrigacoesusuarios)
    Dim originalinfoobrigacoes As List(Of obrigacoesusuarios)

    Public Sub New()
        InitializeComponent()
        objComum.Browse("select obrigacao, descricao from admobrigacoes order by obrigacao", obrigacoesInfoBindingSource)
        objComum.Browse("select u.login, u.nome " +
                          "from usuarios u " +
                          "join usernivel un on un.login = u.login and un.sistema = 'Administrativo' " +
                      "order by u.login", usuariosInfoBindingSource)
        obrigacoesusuariosSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
        obrigacoesSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
    End Sub

    Private Sub obrigacoesusuarioXtraForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Try
            CarregaGrid()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub obrigacoesusuarioXtraForm_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
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

    Private Sub obrigacoesusuarioXtraForm_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If blnCancela Then
            e.Cancel = True
            Call voltarSimpleButton_Click(sender, e)
            blnCancela = False
        End If
    End Sub

    Private Sub okSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles okSimpleButton.Click
        Try
            SetModelo(okSimpleButton.Tag.ToString)
            obrigacoesusuariosSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub voltarSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles voltarSimpleButton.Click
        Try
            RetornaGridFocu()
            LimpaDados()
            obrigacoesusuariosSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
            blnCancela = False
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub obrigacoesusuariosGridView_DoubleClick(sender As Object, e As System.EventArgs) Handles obrigacoesusuariosGridView.DoubleClick
        Try
            If alterarBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always Then
                okSimpleButton.Tag = "alteracao"
                CarregaDados(obrigacoesusuariosGridView)
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub obrigacoesusuariosGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles obrigacoesusuariosGridView.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If alterarBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always Then
                    okSimpleButton.Tag = "alteracao"
                    CarregaDados(obrigacoesusuariosGridView)
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

    Private Sub obrigacoesGridView_DoubleClick(sender As System.Object, e As System.EventArgs) Handles obrigacoesGridView.DoubleClick
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

    Private Sub incluirBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles incluirBarButtonItem.ItemClick
        Try
            okSimpleButton.Tag = "inclusao"
            HabilitaBotoes(okSimpleButton.Tag.ToString)
            obrigacoesusuariosSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
            usuarioSearchLookUpEdit.Focus()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub alterarBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles alterarBarButtonItem.ItemClick
        Try
            okSimpleButton.Tag = "alteracao"
            CarregaDados(obrigacoesusuariosGridView)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub excluirBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles excluirBarButtonItem.ItemClick
        Try
            okSimpleButton.Tag = "exclusao"
            CarregaDados(obrigacoesusuariosGridView)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub localizarBarCheckItem_CheckedChanged(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles localizarBarCheckItem.CheckedChanged
        Try
            obrigacoesusuariosGridView.OptionsFind.AlwaysVisible = localizarBarCheckItem.Checked
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
            VerificaDadosGravacao(obrigacaoSearchLookUpEdit, confirmarobrigacoesSimpleButton)
            SetModelo(obrigacoesGridControl, confirmarobrigacoesSimpleButton)
            HabilitaBotoes(confirmarobrigacoesSimpleButton.Tag.ToString, obrigacoesGridView,
                           incluirobrigacoesSimpleButton, alterarobrigacoesSimpleButton, excluirobrigacoesSimpleButton, confirmarobrigacoesSimpleButton, voltarobrigacoesSimpleButton)
            obrigacoesSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub voltarobrigacoesSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles voltarobrigacoesSimpleButton.Click
        Try
            LimpaDados(confirmarobrigacoesSimpleButton)
            HabilitaBotoes(confirmarobrigacoesSimpleButton.Tag.ToString, obrigacoesGridView,
                           incluirobrigacoesSimpleButton, alterarobrigacoesSimpleButton, excluirobrigacoesSimpleButton, confirmarobrigacoesSimpleButton, voltarobrigacoesSimpleButton)
            obrigacoesSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub obrigacaoSearchLookUpEdit_CustomDisplayText(sender As Object, e As DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs) Handles obrigacaoSearchLookUpEdit.CustomDisplayText
        Dim editor As SearchLookUpEdit = TryCast(sender, SearchLookUpEdit)

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

    Private Sub usuarioSearchLookUpEdit_CustomDisplayText(sender As Object, e As DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs) Handles usuarioSearchLookUpEdit.CustomDisplayText
        Try
            Dim editor As SearchLookUpEdit = TryCast(sender, SearchLookUpEdit)

            If editor.EditValue IsNot Nothing Then
                Dim index As Integer = editor.Properties.GetIndexByKeyValue(editor.EditValue)
                If index >= 0 Then
                    nomeTextEdit.Text = objComum.RetornaDescricao(usuariosInfoBindingSource, index, "nome")
                Else
                    nomeTextEdit.Text = String.Empty
                End If
            Else
                nomeTextEdit.Text = String.Empty
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CarregaGrid()
        Try
            SplashScreenManager.ShowForm(Me, GetType(aguardeWaitForm), True, True, False)
            infoobrigacoesusuarios = New obrigacoesusuariosInfo
            Dim strQuery() As String = {"", ""}
            Dim strTitulo() As String = {"Usuários", "Obrigações"}
            strQuery(0) = "select aou.usuario, max(usu.nome) as nome " +
                            "from admobrigacoesusuarios aou " +
                            "join usuarios usu on usu.login = aou.usuario " +
                            "group by aou.usuario " +
                            "order by aou.usuario"
            strQuery(1) = "select aou.usuario, aou.obrigacao, ao.descricao " +
                            "from admobrigacoesusuarios aou " +
                            "join admobrigacoes ao on ao.obrigacao = aou.obrigacao " +
                        "order by aou.usuario, aou.obrigacao"
            objObrigacoes.Grid(strQuery, strTitulo, obrigacoesusuariosGridControl, obrigacoesusuariosGridView, obrigacoesusuariosRibbonControl)
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
                usuarioSearchLookUpEdit.EditValue = pgvGrid.GetRowCellValue(intLinha(i), "usuario").ToString()
                HabilitaBotoes(okSimpleButton.Tag.ToString)
                obrigacoesusuariosSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
                usuarioSearchLookUpEdit.Focus()
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
                RetornaIndexRegistro(pFieldSearchLookUpEdit.EditValue.ToString)
                HabilitaBotoes(confirmarbutton.Tag.ToString, pgvGrid, incluirbutton, alterarbutton, excluirbutton, confirmarbutton, voltarbutton)
                pSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
                pFieldSearchLookUpEdit.Focus()
            End If
        Next
    End Sub

    Private Sub CarregaOpcao()
        Dim infoGrupoAcesso As New usuariogruposacessoInfo
        Dim objUsuario As New UsuarioBLL
        infoGrupoAcesso = objUsuario.RetornaGrupoAcessoUsuario("cadous")

        If obrigacoesusuariosRibbonControl.Items.Count > 0 Then
            For index = 0 To obrigacoesusuariosRibbonControl.Items.Count - 1
                If obrigacoesusuariosRibbonControl.Items(index).Tag IsNot Nothing Then
                    If objUsuario.UsuarioTemAcesso(infoGrupoAcesso, obrigacoesusuariosRibbonControl.Items(index).Tag.ToString) Then
                        obrigacoesusuariosRibbonControl.Items(index).Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    Else
                        obrigacoesusuariosRibbonControl.Items(index).Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub HabilitaBotoes(pstrOperacao As String)
        incluirBarButtonItem.Enabled = (pstrOperacao = String.Empty)
        localizarBarCheckItem.Enabled = (pstrOperacao = String.Empty)
        atualizarBarButtonItem.Enabled = (pstrOperacao = String.Empty)
        alterarBarButtonItem.Enabled = (pstrOperacao = String.Empty And obrigacoesusuariosGridView.RowCount > 0)
        excluirBarButtonItem.Enabled = (pstrOperacao = String.Empty And obrigacoesusuariosGridView.RowCount > 0)
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
            infoobrigacoesusuarios = New obrigacoesusuariosInfo
            If okSimpleButton.Tag.ToString <> "inclusao" Then
                infoobrigacoesusuarios.usuario = usuarioSearchLookUpEdit.EditValue.ToString
            End If
            usuarioSearchLookUpEdit.Enabled = (okSimpleButton.Tag.ToString = "inclusao")

            Dim strQuery As String = "select aou.obrigacao, ao.descricao " +
                                       "from admobrigacoesusuarios aou " +
                                       "join admobrigacoes ao on ao.obrigacao = aou.obrigacao " +
                                      "where aou.usuario = '" + infoobrigacoesusuarios.usuario + "' " +
                                   "order by aou.obrigacao"
            infoobrigacoes = New List(Of obrigacoesusuarios)
            objObrigacoes.Grid(strQuery, obrigacoesGridControl, obrigacoesGridView, infoobrigacoes)
            infoobrigacoesusuarios.obrigacoes = infoobrigacoes
            originalinfoobrigacoes = New List(Of obrigacoesusuarios)
            For index = 0 To infoobrigacoes.Count - 1
                Dim obrigacoesinfo As New obrigacoesusuarios(infoobrigacoes(index).obrigacao.ToString(), infoobrigacoes(index).descricao.ToString())
                originalinfoobrigacoes.Add(obrigacoesinfo)
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
        infoobrigacoesusuarios = Nothing
        usuarioSearchLookUpEdit.EditValue = String.Empty
        nomeTextEdit.Text = String.Empty

        obrigacoesGridControl.DataSource = Nothing
        infoobrigacoes = Nothing
        originalinfoobrigacoes = Nothing
        If obrigacoesSplitContainerControl.PanelVisibility = SplitPanelVisibility.Panel1 Then
            LimpaDados(confirmarobrigacoesSimpleButton)
            obrigacoesSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
        End If

        okSimpleButton.Tag = String.Empty
        Me.AcceptButton = Nothing
        intLinhaRegistro = 0
        HabilitaBotoes(okSimpleButton.Tag.ToString)
    End Sub

    Private Sub LimpaDados(confirmarbutton As SimpleButton)
        obrigacaoSearchLookUpEdit.EditValue = String.Empty
        obrigacaodescricaoTextEdit.Text = String.Empty
        intLinhaSubRegistro = -1
        confirmarbutton.Tag = String.Empty
    End Sub

    Private Sub SetModelo(pstrOperacao As String)
        Try
            infoobrigacoesusuarios.usuario = usuarioSearchLookUpEdit.EditValue.ToString
            infoobrigacoesusuarios.obrigacoes = infoobrigacoes
            objObrigacoes.IUDObrigacoesUsuarios(pstrOperacao, infoobrigacoesusuarios, originalinfoobrigacoes)
            If okSimpleButton.Tag.ToString <> "alteracao" Then
                If usuarioInfo.usuario = usuarioSearchLookUpEdit.EditValue.ToString Then
                    XtraMessageBox.Show("Essa alteração só será aplicada para o usuário [" + usuarioInfo.usuario + "], no próximo acesso ao sistema.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
            RetornaGridFocu()
            LimpaDados()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub SetModelo(pdgGrid As GridControl, confirmarbutton As SimpleButton)
        If confirmarbutton.Tag.ToString = "inclusao" Then
            Dim obrigacoesinfo As New obrigacoesusuarios(obrigacaoSearchLookUpEdit.EditValue.ToString, obrigacaodescricaoTextEdit.Text)
            infoobrigacoes.Add(obrigacoesinfo)
        ElseIf confirmarbutton.Tag.ToString = "alteracao" Then
            infoobrigacoes(intLinhaSubRegistro).obrigacao = obrigacaoSearchLookUpEdit.EditValue.ToString
            infoobrigacoes(intLinhaSubRegistro).descricao = obrigacaodescricaoTextEdit.Text
        ElseIf confirmarbutton.Tag.ToString = "exclusao" Then
            infoobrigacoes.Remove(infoobrigacoes(intLinhaSubRegistro))
        End If
        pdgGrid.DataSource = Nothing
        pdgGrid.DataSource = infoobrigacoes
        pdgGrid.ForceInitialize()
        infoobrigacoesusuarios.obrigacoes = infoobrigacoes
        LimpaDados(confirmarbutton)
    End Sub

    Private Sub VerificaDadosGravacao(pCampoChave As SearchLookUpEdit, confirmarbutton As SimpleButton)
        For index = 0 To infoobrigacoes.Count - 1
            If confirmarbutton.Tag.ToString = "inclusao" Then
                If infoobrigacoes(index).obrigacao = pCampoChave.EditValue.ToString Then
                    Throw New Exception("Já existe uma obrigação cadastrada")
                    Exit For
                End If
            ElseIf confirmarbutton.Tag.ToString = "alteracao" Then
                If index <> intLinhaSubRegistro Then
                    If infoobrigacoes(index).obrigacao = pCampoChave.EditValue.ToString Then
                        Throw New Exception("Já existe uma obrigação cadastrada")
                        Exit For
                    End If
                End If
            End If
        Next
        If String.IsNullOrEmpty(pCampoChave.EditValue.ToString) Then Throw New Exception("O código da obrigação é obrigatório")
    End Sub

    Private Sub RetornaGridFocu()
        CarregaGrid()
        If intLinhaRegistro >= 0 And okSimpleButton.Tag.ToString <> "exclusao" Then
            obrigacoesusuariosGridView.FocusedRowHandle = intLinhaRegistro
        End If
    End Sub

    Private Sub RetornaIndexRegistro(pstrValor As String)
        For index = 0 To infoobrigacoes.Count - 1
            If infoobrigacoes(index).obrigacao = pstrValor Then
                intLinhaSubRegistro = index
            End If
        Next
    End Sub
End Class