Imports Administrativo.Modelo
Imports Administrativo.BLL
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.XtraTreeList.Nodes.Operations

Public Class gruposacessoXtraForm
    Dim objGrupoAcesso As New GruposAcessoBLL
    Dim blnCancela As Boolean = False
    Dim intLinhaRegistro As Int32 = 0

    Public Sub New()
        InitializeComponent()
        gruposacessoSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
    End Sub

    Private Sub gruposacessoXtraForm_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
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

    Private Sub gruposacessoXtraForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Try
            CarregaGrid()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub gruposacessoXtraForm_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If blnCancela Then
            e.Cancel = True
            Call voltarSimpleButton_Click(sender, e)
            blnCancela = False
        End If
    End Sub

    Private Sub okSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles okSimpleButton.Click
        Try
            SetModelo(okSimpleButton.Tag.ToString)
            LimpaDados()
            gruposacessoSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub voltarSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles voltarSimpleButton.Click
        Try
            RetornaGridFocu()
            LimpaDados()
            gruposacessoSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
            blnCancela = False
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub marcarSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles marcarSimpleButton.Click
        grupoacessoTreeList.CheckAll()
    End Sub

    Private Sub desmarcarSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles desmarcarSimpleButton.Click
        grupoacessoTreeList.UncheckAll()
    End Sub

    Private Sub gruposacessoGridView_DoubleClick(sender As System.Object, e As System.EventArgs) Handles gruposacessoGridView.DoubleClick
        Try
            If alterarBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always Then
                okSimpleButton.Tag = "alteracao"
                CarregaDados(gruposacessoGridView)
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub gruposacessoGridView_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles gruposacessoGridView.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If alterarBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always Then
                    okSimpleButton.Tag = "alteracao"
                    CarregaDados(gruposacessoGridView)
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

    Private Sub incluirBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles incluirBarButtonItem.ItemClick
        Try
            okSimpleButton.Tag = "inclusao"
            HabilitaBotoes(okSimpleButton.Tag.ToString)
            gruposacessoSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
            CarregaDados(gruposacessoGridView)
            grupoTextEdit.Focus()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub alterarBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles alterarBarButtonItem.ItemClick
        Try
            okSimpleButton.Tag = "alteracao"
            CarregaDados(gruposacessoGridView)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub excluirBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles excluirBarButtonItem.ItemClick
        Try
            okSimpleButton.Tag = "exclusao"
            CarregaDados(gruposacessoGridView)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub localizarBarCheckItem_CheckedChanged(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles localizarBarCheckItem.CheckedChanged
        Try
            gruposacessoGridView.OptionsFind.AlwaysVisible = localizarBarCheckItem.Checked
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

    Private Sub grupoacessoTreeList_AfterCheckNode(sender As System.Object, e As DevExpress.XtraTreeList.NodeEventArgs) Handles grupoacessoTreeList.AfterCheckNode
        Dim nodesindeterminados As New NodesChecadosIndeterminados()
        grupoacessoTreeList.NodesIterator.DoOperation(nodesindeterminados)
    End Sub

    Private Sub CarregaGrid()
        Try
            SplashScreenManager.ShowForm(Me, GetType(aguardeWaitForm), True, True, False)
            objGrupoAcesso.Grid("select g.grupo " +
                                  "from gruposacesso g " +
                                 "where g.sistema = 'Administrativo' " +
                              "group by g.grupo " +
                              "order by g.grupo",
                            gruposacessoGridControl, gruposacessoGridView)
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
                If okSimpleButton.Tag.ToString <> "inclusao" Then
                    intLinhaRegistro = intLinha(i)
                    grupoTextEdit.Text = gruposacessoGridView.GetRowCellValue(intLinha(i), pdgGrid.Columns("grupo")).ToString()
                    okSimpleButton.Enabled = True
                    If grupoTextEdit.Text = "Total" Then
                        okSimpleButton.Enabled = False
                        XtraMessageBox.Show("Atenção. O Grupo de Acesso 'Total' é de atualização Interna da GlanData Sistemas!" + Chr(13) + Chr(10) +
                                            "Para personalizar os direitos de acesso dos usuários, crie grupos de acesso com outro nome.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If

                Dim strSQL As String = "select menu.menuprincipal, menu.submenu, " +
                                              "max(menu.descricao) as descricao, menu.opcao, menu.operacoes, max(menu.checado) as checado " +
                                         "from (select gd_grupoacessosadministrativo('P',g.opcao) as menuprincipal, " +
                                                      "gd_grupoacessosadministrativo('F',g.opcao) as submenu, " +
                                                      "coalesce(g.descricao,'') as descricao, g.opcao, g.operacoes, 0 as checado " +
                                                 "from gruposacesso g " +
                                                "where g.sistema = 'Administrativo' and g.grupo = 'Total' " +
                                                "union " +
                                               "select gd_grupoacessosadministrativo('P',g.opcao) as menuprincipal, " +
                                                      "gd_grupoacessosadministrativo('F',g.opcao) as submenu, " +
                                                      "'' as descricao, g.opcao, g.operacoes, 1 as checado " +
                                                 "from gruposacesso g where g.sistema = 'Administrativo' and g.grupo = '" + grupoTextEdit.Text + "') menu " +
                                     "where coalesce(menu.menuprincipal,'') <> '' " +
                                     "group by menu.menuprincipal, menu.submenu, menu.opcao, menu.operacoes " +
                                     "order by 1"
                objGrupoAcesso.VisualizaGrupoAcesso(strSQL, "menuprincipal", "submenu", grupoacessoTreeList)
                Dim carregarnodes As New CarregarNodesChecados()
                grupoacessoTreeList.NodesIterator.DoOperation(carregarnodes)

                HabilitaBotoes(okSimpleButton.Tag.ToString)
                gruposacessoSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
                grupoTextEdit.Focus()
            End If
        Next
    End Sub

    Private Sub CarregaOpcao()
        Dim infoGrupoAcesso As New usuariogruposacessoInfo
        Dim objUsuario As New UsuarioBLL
        infoGrupoAcesso = objUsuario.RetornaGrupoAcessoUsuario("cadgru")

        If gruposacessoRibbonControl.Items.Count > 0 Then
            For index = 0 To gruposacessoRibbonControl.Items.Count - 1
                If gruposacessoRibbonControl.Items(index).Tag IsNot Nothing Then
                    If objUsuario.UsuarioTemAcesso(infoGrupoAcesso, gruposacessoRibbonControl.Items(index).Tag.ToString) Then
                        gruposacessoRibbonControl.Items(index).Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    Else
                        gruposacessoRibbonControl.Items(index).Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub HabilitaBotoes(pstrOperacao As String)
        incluirBarButtonItem.Enabled = (pstrOperacao = String.Empty)
        localizarBarCheckItem.Enabled = (pstrOperacao = String.Empty)
        atualizarBarButtonItem.Enabled = (pstrOperacao = String.Empty)
        alterarBarButtonItem.Enabled = (pstrOperacao = String.Empty And gruposacessoGridView.RowCount > 0)
        excluirBarButtonItem.Enabled = (pstrOperacao = String.Empty And gruposacessoGridView.RowCount > 0)
        If okSimpleButton.Tag.ToString = "exclusao" Then
            okSimpleButton.Text = "Excluir"
            okSimpleButton.ImageIndex = 1
            intLinhaRegistro = 0
        Else
            okSimpleButton.Text = "OK"
            okSimpleButton.ImageIndex = 0
        End If
        grupoTextEdit.Enabled = (okSimpleButton.Tag.ToString = "inclusao")
        If okSimpleButton.Tag.ToString <> String.Empty Then
            Me.AcceptButton = okSimpleButton
        End If
    End Sub

    Private Sub LimpaDados()
        Try
            grupoTextEdit.Text = String.Empty
            okSimpleButton.Tag = String.Empty
            Me.AcceptButton = Nothing
            intLinhaRegistro = 0
            grupoacessoTreeList.ClearNodes()
            HabilitaBotoes(okSimpleButton.Tag.ToString)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub SetModelo(pstrOperacao As String)
        Try
            Dim gruposacesso As New gruposacessoInfo

            Dim lstMenu As New List(Of menuInfo)

            gruposacesso.sistema = "Administrativo"
            gruposacesso.grupo = grupoTextEdit.Text

            Dim nodesopcao As New ValidarNodesChecados()
            grupoacessoTreeList.NodesIterator.DoOperation(nodesopcao)
            Dim intNodes As Int32 = nodesopcao.CheckedNodes.Count - 1
            For index = 0 To intNodes
                Dim menu As New menuInfo
                Dim aNodes = Split(nodesopcao.CheckedNodes(index).ToString, "|")
                If aNodes.Length = 3 Then
                    menu.descricao = aNodes(0).ToString
                    menu.opcao = aNodes(1).ToString
                    menu.operacao = Convert.ToInt32(aNodes(2))
                    lstMenu.Add(menu)
                End If
            Next
            gruposacesso.opcao = lstMenu

            objGrupoAcesso.IUDGruposAcesso(pstrOperacao, gruposacesso)
            If usuarioInfo.grupo = gruposacesso.grupo And okSimpleButton.Tag.ToString <> "exclusao" Then
                XtraMessageBox.Show("As alterações definidas nesse Grupo de Acesso só serão aplicadas após [Seleção de Usuários].", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            RetornaGridFocu()
            LimpaDados()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub RetornaGridFocu()
        CarregaGrid()
        If intLinhaRegistro >= 0 And okSimpleButton.Tag.ToString <> "exclusao" Then
            gruposacessoGridView.FocusedRowHandle = intLinhaRegistro
        End If
    End Sub
End Class

Public Class ValidarNodesChecados
    Inherits TreeListOperation

    Private nodeschecados_opcao As List(Of String) = New List(Of String)()

    Public ReadOnly Property CheckedNodes() As List(Of String)
        Get
            Return nodeschecados_opcao
        End Get
    End Property

    Public Overrides Sub Execute(ByVal node As TreeListNode)
        If node.CheckState = CheckState.Checked OrElse node.CheckState = CheckState.Indeterminate Then
            nodeschecados_opcao.Add(node(node.TreeList.Columns(0)).ToString + "|" + node(node.TreeList.Columns(1)).ToString + "|" + node(node.TreeList.Columns(2)).ToString)
        End If
    End Sub
End Class

Public Class CarregarNodesChecados
    Inherits TreeListOperation

    Public Overrides Sub Execute(ByVal node As TreeListNode)
        If Convert.ToInt32(node(node.TreeList.Columns(3))) = 0 Then
            node.CheckState = CheckState.Unchecked
        End If
    End Sub
End Class

Public Class NodesChecadosIndeterminados
    Inherits TreeListOperation

    Public Overrides Sub Execute(ByVal node As TreeListNode)
        If node.CheckState = CheckState.Indeterminate Then
            node.CheckState = CheckState.Checked
        End If
    End Sub
End Class
