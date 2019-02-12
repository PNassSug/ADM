Imports Administrativo.Modelo
Imports Administrativo.BLL
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors.Mask

Public Class portalusuariosXtraForm
    Dim objPortalUsuarios As New PortalUsuariosBLL
    Dim objComum As New ComumBLL
    Dim blnCancela As Boolean = False
    Dim intLinhaRegistro As Int32 = 0
    Dim intLinhaSubRegistro As Int32 = -1
    Dim strEmailOriginal As String = String.Empty

    Dim infosistemasusuarios As portalusuariosInfo
    Dim infosistemas As List(Of portalusuariossistemas)
    Dim originalinfoSistemas As List(Of portalusuariossistemas)

    Public Sub New()
        InitializeComponent()
        objComum.Browse("select emp.empresa, emp.razaosocial " +
                          "from (select aoe.empresa, max(aoe.exercicio) as exercicio from admobrigacoesempresas aoe group by aoe.empresa) aoe " +
                          "join empresas emp on emp.empresa = aoe.empresa and emp.exercicio = aoe.exercicio " +
                      "order by emp.empresa", empresasInfoBindingSource)
        usuariosempresasSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
        sistemasSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
    End Sub

    Private Sub portalusuariosXtraForm_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If blnCancela Then
            e.Cancel = True
            Call voltarSimpleButton_Click(sender, e)
            blnCancela = False
        End If
    End Sub

    Private Sub portalusuariosXtraForm_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
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

    Private Sub portalusuariosXtraForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Try
            CarregaGrid()
            If String.IsNullOrEmpty(empresaSearchLookUpEdit.Text) Then
                empresaSearchLookUpEdit.Text = " "
            End If
            AddHandler empresaSearchLookUpEdit.CustomDisplayText, AddressOf empresaSearchLookUpEdit_CustomDisplayText
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub okSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles okSimpleButton.Click
        Try
            SetModelo(okSimpleButton.Tag.ToString)
            usuariosempresasSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub voltarSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles voltarSimpleButton.Click
        Try
            RetornaGridFocu()
            LimpaDados()
            usuariosempresasSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
            blnCancela = False
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub usuariosempresasGridView_DoubleClick(sender As Object, e As System.EventArgs) Handles usuariosempresasGridView.DoubleClick
        Try
            If alterarBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always Then
                okSimpleButton.Tag = "alteracao"
                CarregaDados(usuariosempresasGridView)
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub usuariosempresasGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles usuariosempresasGridView.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If alterarBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always Then
                    okSimpleButton.Tag = "alteracao"
                    CarregaDados(usuariosempresasGridView)
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

    Private Sub usuariosempresasGridView_CustomColumnDisplayText(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles usuariosempresasGridView.CustomColumnDisplayText
        Dim strValor As String = String.Empty

        If e.Column.FieldName = "telefone" Then
            If usuariosempresasGridView.GetRowCellValue(e.ListSourceRowIndex, "telefone") IsNot Nothing Then
                strValor = usuariosempresasGridView.GetRowCellValue(e.ListSourceRowIndex, "telefone").ToString()
            Else
                strValor = e.Value.ToString
            End If
            If strValor.Length = 9 Then
                '#####-####
                e.DisplayText = strValor.Substring(0, 5) + "-" + strValor.Substring(5, 4)
            ElseIf strValor.Length = 8 Then
                '####-####
                e.DisplayText = strValor.Substring(0, 4) + "-" + strValor.Substring(4, 4)
            Else
                e.DisplayText = strValor
            End If
        End If
    End Sub

    Private Sub usuariossistemasGridView_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles usuariossistemasGridView.CustomColumnDisplayText
        Dim strValor As String = String.Empty
        If e.Column.FieldName = "sistema" Then
            If usuariossistemasGridView.GetRowCellValue(e.ListSourceRowIndex, "sistema") IsNot Nothing Then
                strValor = usuariossistemasGridView.GetRowCellValue(e.ListSourceRowIndex, "sistema").ToString()
            Else
                strValor = e.Value.ToString
            End If
            e.DisplayText = DisplayComboBox(e.Column.FieldName, strValor)
        End If
    End Sub

    Private Sub sistemasGridView_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles sistemasGridView.CustomColumnDisplayText
        Dim strValor As String = String.Empty
        If e.Column.FieldName = "sistema" Then
            If sistemasGridView.GetRowCellValue(e.ListSourceRowIndex, "sistema") IsNot Nothing Then
                strValor = sistemasGridView.GetRowCellValue(e.ListSourceRowIndex, "sistema").ToString()
            Else
                strValor = e.Value.ToString
            End If
            e.DisplayText = DisplayComboBox(e.Column.FieldName, strValor)
        End If
    End Sub

    Private Sub sistemasGridView_DoubleClick(sender As Object, e As System.EventArgs) Handles sistemasGridView.DoubleClick
        Try
            If okSimpleButton.Tag.ToString <> "exclusao" Then
                confirmarsistemasSimpleButton.Tag = "alteracao"
                Dim strField() As String = {"obrigacao", "descricao"}
                CarregaDados(sistemasGridView, strField, sistemaComboBoxEdit, sistemasSplitContainerControl,
                             incluirsistemasSimpleButton, alterarsistemasSimpleButton, excluirsistemasSimpleButton, confirmarsistemasSimpleButton, voltarsistemasSimpleButton)
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub incluirBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles incluirBarButtonItem.ItemClick
        Try
            okSimpleButton.Tag = "inclusao"
            HabilitaBotoes(okSimpleButton.Tag.ToString)
            usuariosempresasSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
            empresaSearchLookUpEdit.Focus()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub alterarBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles alterarBarButtonItem.ItemClick
        Try
            okSimpleButton.Tag = "alteracao"
            CarregaDados(usuariosempresasGridView)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub excluirBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles excluirBarButtonItem.ItemClick
        Try
            okSimpleButton.Tag = "exclusao"
            CarregaDados(usuariosempresasGridView)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub localizarBarCheckItem_CheckedChanged(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles localizarBarCheckItem.CheckedChanged
        Try
            usuariosempresasGridView.OptionsFind.AlwaysVisible = localizarBarCheckItem.Checked
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

    Private Sub incluirsistemasSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles incluirsistemasSimpleButton.Click
        Try
            confirmarsistemasSimpleButton.Tag = "inclusao"
            HabilitaBotoes(confirmarsistemasSimpleButton.Tag.ToString, sistemasGridView,
                           incluirsistemasSimpleButton, alterarsistemasSimpleButton, excluirsistemasSimpleButton, confirmarsistemasSimpleButton, voltarsistemasSimpleButton)
            sistemasSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
            sistemaComboBoxEdit.Focus()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub alterarsistemasSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles alterarsistemasSimpleButton.Click
        Try
            confirmarsistemasSimpleButton.Tag = "alteracao"
            Dim strField() As String = {"sistema"}
            CarregaDados(sistemasGridView, strField, sistemaComboBoxEdit, sistemasSplitContainerControl,
                         incluirsistemasSimpleButton, alterarsistemasSimpleButton, excluirsistemasSimpleButton, confirmarsistemasSimpleButton, voltarsistemasSimpleButton)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub excluirsistemasSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles excluirsistemasSimpleButton.Click
        Try
            confirmarsistemasSimpleButton.Tag = "exclusao"
            Dim strField() As String = {"sistema"}
            CarregaDados(sistemasGridView, strField, sistemaComboBoxEdit, sistemasSplitContainerControl,
                         incluirsistemasSimpleButton, alterarsistemasSimpleButton, excluirsistemasSimpleButton, confirmarsistemasSimpleButton, voltarsistemasSimpleButton)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub confirmarsistemasSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles confirmarsistemasSimpleButton.Click
        Try
            VerificaDadosGravacao(sistemaComboBoxEdit, confirmarsistemasSimpleButton)
            SetModelo(sistemasGridControl, confirmarsistemasSimpleButton)
            HabilitaBotoes(confirmarsistemasSimpleButton.Tag.ToString, sistemasGridView,
                           incluirsistemasSimpleButton, alterarsistemasSimpleButton, excluirsistemasSimpleButton, confirmarsistemasSimpleButton, voltarsistemasSimpleButton)
            sistemasSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub voltarsistemasSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles voltarsistemasSimpleButton.Click
        Try
            LimpaDados(confirmarsistemasSimpleButton)
            HabilitaBotoes(confirmarsistemasSimpleButton.Tag.ToString, sistemasGridView,
                           incluirsistemasSimpleButton, alterarsistemasSimpleButton, excluirsistemasSimpleButton, confirmarsistemasSimpleButton, voltarsistemasSimpleButton)
            sistemasSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub empresaSearchLookUpEdit_CustomDisplayText(sender As Object, e As DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs)
        Try
            Dim editor As SearchLookUpEdit = TryCast(sender, SearchLookUpEdit)
            If editor.EditValue IsNot Nothing Then
                Dim index As Integer = editor.Properties.GetIndexByKeyValue(editor.EditValue)
                If index >= 0 Then
                    razaosocialTextEdit.Text = objComum.RetornaDescricao(empresasInfoBindingSource, index, "razaosocial")
                Else
                    razaosocialTextEdit.Text = String.Empty
                End If
            Else
                razaosocialTextEdit.Text = String.Empty
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub telefoneTextEdit_CustomDisplayText(sender As System.Object, e As DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs) Handles telefoneTextEdit.CustomDisplayText
        If Not telefoneTextEdit.EditValue Is Nothing Then
            If telefoneTextEdit.EditValue.ToString.Replace("_", String.Empty).Length = 8 Then
                telefoneTextEdit.Properties.Mask.EditMask = "0000-0000"
            ElseIf telefoneTextEdit.EditValue.ToString.Replace("_", String.Empty).Length = 9 Then
                telefoneTextEdit.Properties.Mask.EditMask = "00000-0000"
            Else
                telefoneTextEdit.Properties.Mask.EditMask = ""
            End If
        End If
    End Sub

    Private Sub CarregaGrid()
        Try
            SplashScreenManager.ShowForm(Me, GetType(aguardeWaitForm), True, True, False)
            infosistemasusuarios = New portalusuariosInfo
            Dim strQuery() As String = {"", ""}
            Dim strTitulo() As String = {"Empresas/Usuários", "Sistemas"}
            strQuery(0) = "select aup.empresa, emp.razaosocial as razaosocial, aup.email, aup.nome, aup.ddd, aup.telefone " +
                            "from admusuariosempresassistemasportal aup " +
                            "join (select aoe.empresa, max(aoe.exercicio) as exercicio from admobrigacoesempresas aoe group by aoe.empresa) aoe on aoe.empresa = aup.empresa " +
                            "join empresas emp on emp.empresa = aoe.empresa and emp.exercicio = aoe.exercicio " +
                        "order by aup.empresa, aup.email"
            strQuery(1) = "select aup.empresa, aup.email, coalesce(aup.sistema,'') as sistema " +
                            "from admusuariosempresassistemasitensportal aup " +
                        "order by aup.empresa, aup.email, aup.sistema"
            objPortalUsuarios.Grid(strQuery, strTitulo, usuariosempresasGridControl, usuariosempresasGridView, usuariossistemasGridView)
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
                empresaSearchLookUpEdit.EditValue = pgvGrid.GetRowCellValue(intLinha(i), "empresa").ToString()
                emailTextEdit.EditValue = pgvGrid.GetRowCellValue(intLinha(i), "email").ToString()
                nomeTextEdit.EditValue = pgvGrid.GetRowCellValue(intLinha(i), "nome").ToString()
                dddTextEdit.EditValue = pgvGrid.GetRowCellValue(intLinha(i), "ddd").ToString()
                telefoneTextEdit.EditValue = pgvGrid.GetRowCellValue(intLinha(i), "telefone").ToString()
                HabilitaBotoes(okSimpleButton.Tag.ToString)
                usuariosempresasSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
                empresaSearchLookUpEdit.Focus()
            End If
        Next
    End Sub

    Private Sub CarregaDados(pgvGrid As GridView, pstrField() As String,
                             pFieldComboBoxEdit As ComboBoxEdit, pSplitContainerControl As SplitContainerControl,
                             incluirbutton As SimpleButton, alterarbutton As SimpleButton, excluirbutton As SimpleButton,
                             confirmarbutton As SimpleButton, voltarbutton As SimpleButton)
        Dim intLinha As Integer() = pgvGrid.GetSelectedRows()
        For i As Integer = 0 To intLinha.Length - 1
            If intLinha(i) >= 0 Then
                pFieldComboBoxEdit.EditValue = DisplayComboBox("sistema", pgvGrid.GetRowCellValue(intLinha(i), "sistema").ToString())
                RetornaIndexRegistro(pgvGrid.GetRowCellValue(intLinha(i), "sistema").ToString())
                HabilitaBotoes(confirmarbutton.Tag.ToString, pgvGrid, incluirbutton, alterarbutton, excluirbutton, confirmarbutton, voltarbutton)
                pSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
                pFieldComboBoxEdit.Focus()
            End If
        Next
    End Sub

    Private Sub CarregaOpcao()
        Dim infoGrupoAcesso As New usuariogruposacessoInfo
        Dim objUsuario As New UsuarioBLL
        infoGrupoAcesso = objUsuario.RetornaGrupoAcessoUsuario("porcus")

        If usuariosempresasRibbonControl.Items.Count > 0 Then
            For index = 0 To usuariosempresasRibbonControl.Items.Count - 1
                If usuariosempresasRibbonControl.Items(index).Tag IsNot Nothing Then
                    If objUsuario.UsuarioTemAcesso(infoGrupoAcesso, usuariosempresasRibbonControl.Items(index).Tag.ToString) Then
                        usuariosempresasRibbonControl.Items(index).Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    Else
                        usuariosempresasRibbonControl.Items(index).Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub HabilitaBotoes(pstrOperacao As String)
        incluirBarButtonItem.Enabled = (pstrOperacao = String.Empty)
        localizarBarCheckItem.Enabled = (pstrOperacao = String.Empty)
        atualizarBarButtonItem.Enabled = (pstrOperacao = String.Empty)
        alterarBarButtonItem.Enabled = (pstrOperacao = String.Empty And usuariosempresasGridView.RowCount > 0)
        excluirBarButtonItem.Enabled = (pstrOperacao = String.Empty And usuariosempresasGridView.RowCount > 0)
        If okSimpleButton.Tag.ToString = "exclusao" Then
            okSimpleButton.Text = "Excluir"
            okSimpleButton.ImageIndex = 1
            intLinhaRegistro = 0
            sistemasPanelControl.Enabled = False
        Else
            okSimpleButton.Text = "OK"
            okSimpleButton.ImageIndex = 0
            sistemasPanelControl.Enabled = True
        End If
        If Not String.IsNullOrEmpty(pstrOperacao) Then
            infosistemasusuarios = New portalusuariosInfo
            If okSimpleButton.Tag.ToString <> "inclusao" Then
                infosistemasusuarios.empresa = empresaSearchLookUpEdit.EditValue.ToString
                infosistemasusuarios.email = emailTextEdit.EditValue.ToString
            End If
            empresaSearchLookUpEdit.Enabled = (okSimpleButton.Tag.ToString = "inclusao")

            Dim strQuery As String = "select aup.sistema " +
                                       "from admusuariosempresassistemasitensportal aup " +
                                      "where aup.empresa = '" + infosistemasusuarios.empresa + "' " +
                                        "and aup.email = '" + infosistemasusuarios.email + "' " +
                                   "order by aup.sistema"
            infosistemas = New List(Of portalusuariossistemas)
            objPortalUsuarios.Grid(strQuery, sistemasGridControl, sistemasGridView, infosistemas)
            infosistemasusuarios.sistemas = infosistemas
            originalinfoSistemas = New List(Of portalusuariossistemas)
            For index = 0 To infosistemas.Count - 1
                Dim sistemasinfo As New portalusuariossistemas(infosistemas(index).sistema.ToString())
                originalinfoSistemas.Add(sistemasinfo)
            Next
            HabilitaBotoes(String.Empty, sistemasGridView,
                           incluirsistemasSimpleButton, alterarsistemasSimpleButton, excluirsistemasSimpleButton, confirmarsistemasSimpleButton, voltarsistemasSimpleButton)
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
        infosistemasusuarios = Nothing
        empresaSearchLookUpEdit.EditValue = String.Empty
        razaosocialTextEdit.Text = String.Empty
        emailTextEdit.Text = String.Empty
        nomeTextEdit.Text = String.Empty
        dddTextEdit.Text = String.Empty
        telefoneTextEdit.Text = String.Empty

        sistemasGridControl.DataSource = Nothing
        infosistemas = Nothing
        originalinfoSistemas = Nothing
        If sistemasSplitContainerControl.PanelVisibility = SplitPanelVisibility.Panel1 Then
            LimpaDados(confirmarsistemasSimpleButton)
            sistemasSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
        End If

        okSimpleButton.Tag = String.Empty
        Me.AcceptButton = Nothing
        intLinhaRegistro = 0
        HabilitaBotoes(okSimpleButton.Tag.ToString)
    End Sub

    Private Sub LimpaDados(confirmarbutton As SimpleButton)
        sistemaComboBoxEdit.EditValue = String.Empty
        intLinhaSubRegistro = -1
        confirmarbutton.Tag = String.Empty
    End Sub

    Private Sub SetModelo(pstrOperacao As String)
        Try
            infosistemasusuarios.empresa = empresaSearchLookUpEdit.EditValue.ToString
            If pstrOperacao = "alteracao" Then
                strEmailOriginal = String.Empty
                If Not String.IsNullOrEmpty(infosistemasusuarios.email) Then
                    strEmailOriginal = infosistemasusuarios.email
                End If
            End If
            infosistemasusuarios.email = String.Empty
            If emailTextEdit.EditValue IsNot Nothing Then
                infosistemasusuarios.email = emailTextEdit.EditValue.ToString
            End If
            infosistemasusuarios.nome = String.Empty
            If nomeTextEdit.EditValue IsNot Nothing Then
                infosistemasusuarios.nome = nomeTextEdit.EditValue.ToString
            End If
            infosistemasusuarios.ddd = String.Empty
            If dddTextEdit.EditValue IsNot Nothing Then
                infosistemasusuarios.ddd = dddTextEdit.EditValue.ToString
            End If
            infosistemasusuarios.telefone = String.Empty
            If telefoneTextEdit.EditValue IsNot Nothing Then
                infosistemasusuarios.telefone = telefoneTextEdit.EditValue.ToString
            End If
            infosistemasusuarios.sistemas = infosistemas
            SplashScreenManager.ShowForm(Me, GetType(aguardeWaitForm), True, True, False)
            objPortalUsuarios.IUDPortalUsuarios(pstrOperacao, strEmailOriginal, infosistemasusuarios, originalinfoSistemas)
            SplashScreenManager.CloseForm()
            RetornaGridFocu()
            LimpaDados()
        Catch ex As Exception
            SplashScreenManager.CloseForm()
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub SetModelo(pdgGrid As GridControl, confirmarbutton As SimpleButton)
        If confirmarbutton.Tag.ToString = "inclusao" Then
            Dim obrigacoesinfo As New portalusuariossistemas(sistemaComboBoxEdit.Text.ToUpper.Substring(9, 3))
            infosistemas.Add(obrigacoesinfo)
        ElseIf confirmarbutton.Tag.ToString = "alteracao" Then
            infosistemas(intLinhaSubRegistro).sistema = sistemaComboBoxEdit.Text.ToUpper.Substring(9, 3)
        ElseIf confirmarbutton.Tag.ToString = "exclusao" Then
            infosistemas.Remove(infosistemas(intLinhaSubRegistro))
        End If
        pdgGrid.DataSource = Nothing
        pdgGrid.DataSource = infosistemas
        pdgGrid.ForceInitialize()
        infosistemasusuarios.sistemas = infosistemas
        LimpaDados(confirmarbutton)
    End Sub

    Private Sub VerificaDadosGravacao(pCampoChave As ComboBoxEdit, confirmarbutton As SimpleButton)
        For index = 0 To infosistemas.Count - 1
            If confirmarbutton.Tag.ToString = "inclusao" Then
                If infosistemas(index).sistema = pCampoChave.Text.ToUpper.Substring(9, 3) Then
                    Throw New Exception("Já existe o sistema cadastrado")
                    Exit For
                End If
            ElseIf confirmarbutton.Tag.ToString = "alteracao" Then
                If index <> intLinhaSubRegistro Then
                    If infosistemas(index).sistema = pCampoChave.Text.ToUpper.Substring(9, 3) Then
                        Throw New Exception("Já existe o sistema cadastrado")
                        Exit For
                    End If
                End If
            End If
        Next
        If String.IsNullOrEmpty(pCampoChave.EditValue.ToString) Then Throw New Exception("O sistema é obrigatório")
    End Sub

    Private Sub RetornaGridFocu()
        CarregaGrid()
        If intLinhaRegistro >= 0 And okSimpleButton.Tag.ToString <> "exclusao" Then
            usuariosempresasGridView.FocusedRowHandle = intLinhaRegistro
        End If
    End Sub

    Private Function DisplayComboBox(ByVal pstrCampo As String, ByVal pstrValor As String) As String
        Dim strDisplayComboBox As String = String.Empty

        If pstrCampo = "sistema" Then
            If pstrValor = "CAD" Then
                strDisplayComboBox = "Buddywin Cadastro Geral"
            ElseIf pstrValor = "CON" Then
                strDisplayComboBox = "Buddywin Contábil"
            ElseIf pstrValor = "DEC" Then
                strDisplayComboBox = "Buddywin Declarar"
            ElseIf pstrValor = "ESC" Then
                strDisplayComboBox = "Buddywin Escrita Fiscal"
            ElseIf pstrValor = "FOL" Then
                strDisplayComboBox = "Buddywin Folha de Pagamento"
            ElseIf pstrValor = "LAL" Then
                strDisplayComboBox = "Buddywin Lalur"
            ElseIf pstrValor = "FLU" Then
                strDisplayComboBox = "Buddywin Fluxo de Caixa"
            End If
        End If
        Return strDisplayComboBox
    End Function

    Private Sub RetornaIndexRegistro(pstrValor As String)
        For index = 0 To infosistemas.Count - 1
            If infosistemas(index).sistema = pstrValor Then
                intLinhaSubRegistro = index
            End If
        Next
    End Sub

    Private Sub usuariosempresasGridControl_KeyUp(sender As Object, e As KeyEventArgs) Handles usuariosempresasGridControl.KeyUp
        Dim gcSender As GridControl = DirectCast(sender, GridControl)
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up Then
            If gcSender.FocusedView.Name = "usuariosempresasGridView" Then
                excluirBarButtonItem.Enabled = True
            Else
                excluirBarButtonItem.Enabled = False
            End If
        End If
    End Sub

    Private Sub HabilitaDesabilitaExcluirBarButton(pobjSender As Object, prccEvent As RowCellClickEventArgs) Handles usuariosempresasGridView.RowCellClick, usuariossistemasGridView.RowCellClick
        Dim gvSender As GridView = DirectCast(pobjSender, GridView)
        If gvSender.Name = "usuariosempresasGridView" Then
            If prccEvent.Clicks = 1 Then
                excluirBarButtonItem.Enabled = True
            Else
                excluirBarButtonItem.Enabled = False
            End If
        Else
            excluirBarButtonItem.Enabled = False
        End If
    End Sub

    Private Sub sistemaComboBoxEdit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sistemaComboBoxEdit.SelectedIndexChanged
        confirmarsistemasSimpleButton.Focus()
    End Sub
End Class