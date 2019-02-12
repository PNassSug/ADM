Imports Administrativo.Modelo
Imports Administrativo.BLL
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views

Public Class usuariosXtraForm
    Dim objUsuario As New UsuarioBLL
    Dim objComum As New ComumBLL
    Dim intLinhaRegistro As Int32 = 0
    Dim blnCarregaDados As Boolean = False
    Dim blnHouveAlteracao As Boolean = False

    Public Sub New()
        InitializeComponent()
        objComum.Browse("select grupo from gruposacesso where sistema = 'Administrativo' group by grupo", gruposacessoinfoBindingSource)
        objComum.Browse("select codigo, descricao from tabaux where tabela = 'UserAdministrativo'", tabauxinfoBindingSource)
        usuariosSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
    End Sub

    Private Sub usuariosXtraForm_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
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

    Private Sub usuariosXtraForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            CarregaGrid()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub okSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles okSimpleButton.Click
        Try
            SetModelo(okSimpleButton.Tag.ToString)
            LimpaDados()
            usuariosSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub voltarSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles voltarSimpleButton.Click
        Try
            RetornaGridFocu()
            LimpaDados()
            usuariosSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub usuariosGridView_DoubleClick(sender As Object, e As System.EventArgs) Handles usuariosGridView.DoubleClick
        Try
            If alterarBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always Then
                okSimpleButton.Tag = "alteracao"
                CarregaDados(usuariosGridView)
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub usuariosGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles usuariosGridView.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If alterarBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always Then
                    okSimpleButton.Tag = "alteracao"
                    CarregaDados(usuariosGridView)
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

    Private Sub usuariosGridView_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles usuariosGridView.CustomColumnDisplayText
        Try
            Dim strValor As String = String.Empty
            If e.Column.FieldName = "nivel" Then
                If usuariosGridView.GetRowCellValue(e.ListSourceRowIndex, "nivel") IsNot Nothing Then
                    strValor = usuariosGridView.GetRowCellValue(e.ListSourceRowIndex, "nivel").ToString()
                Else
                    strValor = e.DisplayText
                End If
                If Not String.IsNullOrEmpty(strValor) Then
                    If strValor = "SP" Then
                        e.DisplayText = "Supervisor"
                    ElseIf strValor = "OP" Then
                        e.DisplayText = "Operador"
                    ElseIf strValor = "AD" Then
                        e.DisplayText = "Administrador"
                    End If
                End If
            ElseIf e.Column.FieldName = "usuariomaster" Then
                If usuariosGridView.GetRowCellValue(e.ListSourceRowIndex, "usuariomaster") IsNot Nothing Then
                    strValor = usuariosGridView.GetRowCellValue(e.ListSourceRowIndex, "usuariomaster").ToString()
                Else
                    strValor = e.DisplayText
                End If

                If strValor.EndsWith("0") Then
                    e.DisplayText = "Não"
                ElseIf strValor.EndsWith("-1") Then
                    e.DisplayText = "Sim"
                End If
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub incluirBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles incluirBarButtonItem.ItemClick
        Try
            blnCarregaDados = True
            okSimpleButton.Tag = "inclusao"
            HabilitaBotoes(okSimpleButton.Tag.ToString)
            usuariosSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
            loginTextEdit.Focus()
            blnCarregaDados = False
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub alterarBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles alterarBarButtonItem.ItemClick
        Try
            okSimpleButton.Tag = "alteracao"
            CarregaDados(usuariosGridView)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub excluirBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles excluirBarButtonItem.ItemClick
        Try
            okSimpleButton.Tag = "exclusao"
            CarregaDados(usuariosGridView)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub localizarBarCheckItem_CheckedChanged(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles localizarBarCheckItem.CheckedChanged
        Try
            usuariosGridView.OptionsFind.AlwaysVisible = localizarBarCheckItem.Checked
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

    Private Sub usernivelSearchLookUpEdit_CustomDisplayText(sender As System.Object, e As DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs) Handles usernivelSearchLookUpEdit.CustomDisplayText
        Dim editor As SearchLookUpEdit = TryCast(sender, SearchLookUpEdit)
        If editor.EditValue IsNot Nothing Then
            Dim index As Integer = editor.Properties.GetIndexByKeyValue(editor.EditValue)
            If index >= 0 Then
                usernivelTextEdit.Text = objComum.RetornaDescricao(tabauxinfoBindingSource, index, "descricao")
            Else
                usernivelTextEdit.Text = String.Empty
            End If
        Else
            usernivelTextEdit.Text = String.Empty
        End If
    End Sub

    Private Sub loginTextEdit_CustomDisplayText(sender As Object, e As DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs) Handles loginTextEdit.CustomDisplayText
        Try
            If blnHouveAlteracao Then
                If okSimpleButton.Tag.ToString = "inclusao" And Not String.IsNullOrEmpty(loginTextEdit.EditValue.ToString) And Not blnCarregaDados Then
                    Dim usuarios As New usuariocadastroInfo
                    If objUsuario.BuscaUsuario(loginTextEdit.Text.ToString, usuarios) Then
                        nomeTextEdit.Text = usuarios.nome
                        departamentoTextEdit.Text = usuarios.departamento
                        usuariomasterCheckEdit.Checked = Convert.ToBoolean(usuarios.usuariomaster)
                        senhaCheckButton.Checked = Not String.IsNullOrEmpty(usuarios.senha)
                        If senhaCheckButton.Checked Then
                            senhaTextEdit.Text = usuarios.senha
                            confirmarsenhaTextEdit.Text = usuarios.senha
                            confirmarsenhaTextEdit_EditValueChanging(Nothing, Nothing)
                        Else
                            senhaTextEdit.Text = String.Empty
                            confirmarsenhaTextEdit.Text = String.Empty
                        End If
                        blnHouveAlteracao = False
                    End If
                End If
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub loginTextEdit_TextChanged(sender As System.Object, e As System.EventArgs) Handles loginTextEdit.TextChanged
        If okSimpleButton.Tag.ToString = "inclusao" And Not String.IsNullOrEmpty(loginTextEdit.Text) And Not blnCarregaDados Then
            blnHouveAlteracao = True
        End If
    End Sub

    Private Sub grupoSearchLookUpEdit_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles grupoSearchLookUpEdit.EditValueChanged
        Try
            Dim strSQL As String = "select gd_grupoacessosadministrativo('P',g.opcao) as menuprincipal, " +
                                          "gd_grupoacessosadministrativo('F',g.opcao) as submenu, " +
                                          "coalesce(g.descricao,'') as descricao " +
                                     "from gruposacesso g " +
                                    "where g.sistema = 'Administrativo' " +
                                      "and grupo = '" + grupoSearchLookUpEdit.EditValue.ToString + "' " +
                                      "and gd_grupoacessosadministrativo('P',g.opcao) <> '' " +
                                      "and gd_grupoacessosadministrativo('F',g.opcao) <> '' " +
                                 "order by gd_grupoacessosadministrativo('P',g.opcao)"

            objUsuario.VisualizaGrupoAcesso(strSQL, "menuprincipal", "submenu", grupoacessoTreeList)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub senhaCheckButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles senhaCheckButton.CheckedChanged
        senhaPanelControl.Visible = senhaCheckButton.Checked
        okSimpleButton.Enabled = Not senhaCheckButton.Checked
        If senhaCheckButton.Checked Then
            senhaCheckButton.ImageIndex = 3
        Else
            senhaCheckButton.ImageIndex = 2
            senhaTextEdit.Text = String.Empty
            confirmarsenhaTextEdit.Text = String.Empty
        End If
    End Sub

    Private Sub senhaTextEdit_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles senhaTextEdit.EditValueChanging
        If Not String.IsNullOrEmpty(senhaTextEdit.Text) And Not String.IsNullOrEmpty(confirmarsenhaTextEdit.Text) Then
            okSimpleButton.Enabled = (senhaTextEdit.Text.ToString = confirmarsenhaTextEdit.Text.ToString)
        End If
    End Sub

    Private Sub confirmarsenhaTextEdit_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles confirmarsenhaTextEdit.EditValueChanging
        If Not String.IsNullOrEmpty(senhaTextEdit.Text) And Not String.IsNullOrEmpty(confirmarsenhaTextEdit.Text) Then
            okSimpleButton.Enabled = (senhaTextEdit.Text.ToString = confirmarsenhaTextEdit.Text.ToString)
        End If
    End Sub

    Private Sub CarregaGrid()
        Try
            SplashScreenManager.ShowForm(Me, GetType(aguardeWaitForm), True, True, False)
            objUsuario.Grid("select u.login, u.nome, u.email, u.departamento, un.grupo, u.usuariomaster, un.nivel, u.alertarvencimentoobrigacao, u.diasantesalerta, u.assinatura " +
                              "from usuarios u " +
                              "join usernivel un on un.login = u.login and un.sistema = 'Administrativo' " +
                          "order by u.login",
                            usuariosGridControl, usuariosGridView)

            CarregaOpcao()
            SplashScreenManager.CloseForm()
        Catch ex As Exception
            SplashScreenManager.CloseForm()
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CarregaDados(pdgGrid As Grid.GridView)
        Dim intLinha As Integer() = pdgGrid.GetSelectedRows()

        For i As Integer = 0 To intLinha.Length - 1
            If intLinha(i) >= 0 Then
                intLinhaRegistro = intLinha(i)
                loginTextEdit.EditValue = pdgGrid.GetRowCellValue(intLinha(i), "login").ToString()
                nomeTextEdit.EditValue = pdgGrid.GetRowCellValue(intLinha(i), "nome").ToString()
                If pdgGrid.GetRowCellValue(intLinha(i), "email") IsNot Nothing Then
                    emailTextEdit.EditValue = pdgGrid.GetRowCellValue(intLinha(i), "email").ToString()
                End If
                departamentoTextEdit.EditValue = pdgGrid.GetRowCellValue(intLinha(i), "departamento").ToString()
                If usuariosGridView.GetRowCellValue(intLinha(i), "grupo") IsNot Nothing Then
                    grupoSearchLookUpEdit.EditValue = pdgGrid.GetRowCellValue(intLinha(i), "grupo").ToString()
                End If
                If usuariosGridView.GetRowCellValue(intLinha(i), "nivel") IsNot Nothing Then
                    usernivelSearchLookUpEdit.EditValue = pdgGrid.GetRowCellValue(intLinha(i), "nivel").ToString()
                End If
                usuariomasterCheckEdit.Checked = Convert.ToBoolean(pdgGrid.GetRowCellValue(intLinha(i), "usuariomaster"))
                alertarvencimentoobrigacaoCheckEdit.Checked = Convert.ToBoolean(pdgGrid.GetRowCellValue(intLinha(i), "alertarvencimentoobrigacao"))
                diasantesalertaTextEdit.Text = Convert.ToInt32(pdgGrid.GetRowCellValue(intLinha(i), "diasantesalerta")).ToString
                diasantesalertaTextEdit.Enabled = alertarvencimentoobrigacaoCheckEdit.Checked
                If usuariosGridView.GetRowCellValue(intLinha(i), "assinatura") IsNot Nothing Then
                    assinaturaRichEditControl.RtfText = pdgGrid.GetRowCellValue(intLinha(i), "assinatura").ToString()
                End If
                HabilitaBotoes(okSimpleButton.Tag.ToString)
                usuariosSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
                loginTextEdit.Focus()
            End If
        Next
    End Sub

    Private Sub CarregaOpcao()
        Dim infoGrupoAcesso As New usuariogruposacessoInfo
        infoGrupoAcesso = objUsuario.RetornaGrupoAcessoUsuario("cadusu")

        If usuarioRibbonControl.Items.Count > 0 Then
            For index = 0 To usuarioRibbonControl.Items.Count - 1
                If usuarioRibbonControl.Items(index).Tag IsNot Nothing Then
                    If objUsuario.UsuarioTemAcesso(infoGrupoAcesso, usuarioRibbonControl.Items(index).Tag.ToString) Then
                        usuarioRibbonControl.Items(index).Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    Else
                        usuarioRibbonControl.Items(index).Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub HabilitaBotoes(pstrOperacao As String)
        incluirBarButtonItem.Enabled = (pstrOperacao = String.Empty)
        localizarBarCheckItem.Enabled = (pstrOperacao = String.Empty)
        atualizarBarButtonItem.Enabled = (pstrOperacao = String.Empty)
        alterarBarButtonItem.Enabled = (pstrOperacao = String.Empty And usuariosGridView.RowCount > 0)
        excluirBarButtonItem.Enabled = (pstrOperacao = String.Empty And usuariosGridView.RowCount > 0)
        If okSimpleButton.Tag.ToString = "exclusao" Then
            okSimpleButton.Text = "Excluir"
            okSimpleButton.ImageIndex = 1
            intLinhaRegistro = 0
        Else
            okSimpleButton.Text = "OK"
            okSimpleButton.ImageIndex = 0
        End If
        loginTextEdit.Enabled = (okSimpleButton.Tag.ToString = "inclusao")
        If loginTextEdit.Enabled Then
            loginTextEdit.Text = Environment.UserName
        End If
        If okSimpleButton.Tag.ToString <> String.Empty Then
            Me.AcceptButton = okSimpleButton
        End If
    End Sub

    Private Sub LimpaDados()
        Try
            loginTextEdit.Text = String.Empty
            nomeTextEdit.Text = String.Empty
            emailTextEdit.Text = String.Empty
            departamentoTextEdit.Text = String.Empty
            grupoSearchLookUpEdit.EditValue = String.Empty
            usuariomasterCheckEdit.Checked = False
            usernivelSearchLookUpEdit.EditValue = String.Empty
            usernivelTextEdit.Text = String.Empty
            okSimpleButton.Tag = String.Empty
            senhaCheckButton.Checked = False
            senhaTextEdit.Text = String.Empty
            confirmarsenhaTextEdit.Text = String.Empty
            assinaturaRichEditControl.Text = String.Empty
            assinaturaRichEditControl.RtfText = String.Empty
            Me.AcceptButton = Nothing
            intLinhaRegistro = 0
            HabilitaBotoes(okSimpleButton.Tag.ToString)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub SetModelo(pstrOperacao As String)
        Try
            Dim usuarios As New usuariocadastroInfo

            usuarios.login = loginTextEdit.Text
            usuarios.nome = nomeTextEdit.Text
            usuarios.email = emailTextEdit.Text
            usuarios.departamento = departamentoTextEdit.Text
            usuarios.grupo = grupoSearchLookUpEdit.Text
            If usuariomasterCheckEdit.Checked Then
                usuarios.usuariomaster = -1
            End If
            usuarios.nivel = usernivelSearchLookUpEdit.Text
            If senhaCheckButton.Checked Then
                usuarios.senha = senhaTextEdit.Text
            End If
            If alertarvencimentoobrigacaoCheckEdit.Checked Then
                usuarios.alertarvencimentoobrigacao = -1
                usuarios.diasantesalerta = Convert.ToInt32(diasantesalertaTextEdit.Text)
            End If
            usuarios.assinatura = assinaturaRichEditControl.RtfText

            SplashScreenManager.ShowForm(Me, GetType(aguardeWaitForm), True, True, False)
            objUsuario.IUDUsuarios(pstrOperacao, usuarios)
            SplashScreenManager.CloseForm()
            If usuarioInfo.usuario = usuarios.login And okSimpleButton.Tag.ToString <> "exclusao" Then
                XtraMessageBox.Show("As alterações definidas nesse usuário só serão aplicadas após [Seleção de Usuários].", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            RetornaGridFocu()
            LimpaDados()
        Catch ex As Exception
            SplashScreenManager.CloseForm()
            Throw New Exception(ex.Message)
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RetornaGridFocu()
        CarregaGrid()
        If intLinhaRegistro >= 0 And okSimpleButton.Tag.ToString <> "exclusao" Then
            usuariosGridView.FocusedRowHandle = intLinhaRegistro
        End If
    End Sub

    Private Sub alertarvencimentoobrigacaoCheckEdit_CheckedChanged(sender As Object, e As EventArgs) Handles alertarvencimentoobrigacaoCheckEdit.CheckedChanged
        diasantesalertaTextEdit.Enabled = alertarvencimentoobrigacaoCheckEdit.Checked
        If Not alertarvencimentoobrigacaoCheckEdit.Checked Then
            diasantesalertaTextEdit.Text = "0"
        End If
    End Sub
End Class