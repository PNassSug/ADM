Imports Administrativo.Modelo
Imports Administrativo.BLL
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors.Mask

Public Class manutencaoobrigacoesXtraForm

    Dim objManutencaoObrigacoes As New ManutencaoObrigacoesBLL
    Dim objComum As New ComumBLL
    Dim objFiltro As New FiltroBLL
    Dim blnCancela As Boolean = False
    Dim blnCarregaDados As Boolean = False
    Dim intSequenciaExtra As Int32 = 0
    Dim intObrigacaoExtra As Int32 = 0
    Dim intTipoPessoaInforme As Int32 = 0
    Dim intInforme As Int32 = 0
    Dim strAlertaObrigacao As String = String.Empty
    Dim manutencaoobrigacoes As New manutencaoobrigacoesInfo

    Private intLinhaGroupMaster As Int32 = 0
    Private listGridLinhaFocu As New List(Of GridLinhaFocu)()

    Public Sub New(Optional ByVal pstrAlertaObrigacao As String = "")
        InitializeComponent()
        objComum.Browse("select obrigacao, descricao from admobrigacoes order by obrigacao", obrigacoesInfoBindingSource)
        objComum.Browse("select login, nome from usuarios order by login", usuarioInfoBindingSource)
        strAlertaObrigacao = pstrAlertaObrigacao
        If Not String.IsNullOrEmpty(strAlertaObrigacao) Then
            filtroBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        manutencaoSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
    End Sub

    Private Sub manutencaoobrigacoesXtraForm_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
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

    Private Sub manutencaoobrigacoesXtraForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Try
            CarregaGrid()
            objFiltro.IconeOpcaoFiltro(filtroBarButtonItem)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub manutencaoobrigacoesXtraForm_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If blnCancela Then
            e.Cancel = True
            Call voltarSimpleButton_Click(sender, e)
            blnCancela = False
        End If
    End Sub

    Private Sub okSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles okSimpleButton.Click
        Try
            SetModelo(okSimpleButton.Tag.ToString)
            manutencaoSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub voltarSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles voltarSimpleButton.Click
        Try
            RetornaGridFocu()
            LimpaDados()
            manutencaoSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
            blnCancela = False
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub alterarBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles alterarBarButtonItem.ItemClick
        Try
            okSimpleButton.Tag = "alteracao"
            CarregaDados()
            empresaSearchLookUpEdit.Properties.Mask.MaskType = MaskType.Simple
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub localizarBarCheckItem_CheckedChanged(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles localizarBarCheckItem.CheckedChanged
        Try
            manutencaoGridView.OptionsFind.AlwaysVisible = localizarBarCheckItem.Checked
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

    Private Sub filtroBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles filtroBarButtonItem.ItemClick
        Dim form As filtroXtraForm = New filtroXtraForm()
        form.ShowDialog(Me)
        objFiltro.IconeOpcaoFiltro(filtroBarButtonItem)
        CarregaGrid()
    End Sub

    Private Sub manutencaoGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles manutencaoGridView.KeyDown
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

    Private Sub manutencaoGridView_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles manutencaoGridView.CustomColumnDisplayText
        Dim strValor As String = String.Empty

        If e.Column.FieldName = "cnpj" Then
            If manutencaoGridView.GetRowCellValue(e.ListSourceRowIndex, "cnpj") IsNot Nothing Then
                strValor = manutencaoGridView.GetRowCellValue(e.ListSourceRowIndex, "cnpj").ToString()
            Else
                strValor = e.Value.ToString
            End If
            If strValor.Length = 14 Then
                '##.###.###/####-##
                e.DisplayText = strValor.Substring(0, 2) + "." + strValor.Substring(2, 3) + "." + strValor.Substring(5, 3) + "/" + strValor.Substring(8, 4) + "-" + strValor.Substring(12, 2)
            ElseIf strValor.Length = 11 Then
                '###.###.###-##
                e.DisplayText = strValor.Substring(0, 3) + "." + strValor.Substring(3, 3) + "." + strValor.Substring(6, 3) + "-" + strValor.Substring(9, 2)
            Else
                e.DisplayText = strValor
            End If
        End If
    End Sub

    Private Sub manutencaoGridView_MasterRowCollapsing(sender As Object, e As DevExpress.XtraGrid.Views.Grid.MasterRowCanExpandEventArgs) Handles manutencaoGridView.MasterRowCollapsing
        intLinhaGroupMaster = -1
    End Sub

    Private Sub manutencaoGridView_MasterRowExpanding(sender As Object, e As DevExpress.XtraGrid.Views.Grid.MasterRowCanExpandEventArgs) Handles manutencaoGridView.MasterRowExpanding
        If intLinhaGroupMaster >= 0 Then
            manutencaoGridView.SetMasterRowExpanded(intLinhaGroupMaster, False)
        End If
        intLinhaGroupMaster = e.RowHandle
    End Sub

    Private Sub manutencaoempresaGridView_DoubleClick(sender As Object, e As System.EventArgs) Handles manutencaoempresaGridView.DoubleClick
        Try
            If alterarBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always Then
                okSimpleButton.Tag = "alteracao"
                CarregaDados()
                empresaSearchLookUpEdit.Properties.Mask.MaskType = MaskType.Simple
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub manutencaoempresaGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles manutencaoempresaGridView.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If alterarBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always Then
                    okSimpleButton.Tag = "alteracao"
                    CarregaDados()
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

    Private Sub manutencaoempresaGridView_RowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles manutencaoempresaGridView.RowStyle
        Dim View As GridView = CType(sender, GridView)
        If (e.RowHandle >= 0) Then
            Dim obrigacaoextra As Boolean = Convert.ToInt32(View.GetRowCellDisplayText(e.RowHandle, View.Columns("obrigacaoextra"))) = -1 And
                                          Convert.ToInt32(View.GetRowCellDisplayText(e.RowHandle, View.Columns("sequenciaextra"))) > 0

            If obrigacaoextra Then
                e.Appearance.BackColor = Color.CadetBlue
                e.Appearance.BackColor2 = Color.White
                If Convert.ToInt32(View.GetRowCellDisplayText(e.RowHandle, View.Columns("parcela"))) > 0 Then
                    e.Appearance.BackColor = Color.Goldenrod
                    e.Appearance.BackColor2 = Color.White
                End If
            End If
        End If
    End Sub

    Private Sub detalhefuncionarioGridView_DoubleClick(sender As Object, e As System.EventArgs) Handles detalhefuncionarioGridView.DoubleClick
        Try
            If alterarBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always Then
                okSimpleButton.Tag = "alteracao"
                CarregaDados()
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub detalhefuncionarioGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles detalhefuncionarioGridView.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If alterarBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always Then
                    okSimpleButton.Tag = "alteracao"
                    CarregaDados()
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

    Private Sub detalhefuncionarioGridView_RowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles detalhefuncionarioGridView.RowStyle
        Dim View As GridView = CType(sender, GridView)
        If (e.RowHandle >= 0) Then
            Dim obrigacaoextra As Boolean = Convert.ToInt32(View.GetRowCellDisplayText(e.RowHandle, View.Columns("obrigacaoextra"))) = -1 And
                                          Convert.ToInt32(View.GetRowCellDisplayText(e.RowHandle, View.Columns("sequenciaextra"))) > 0
            If obrigacaoextra Then
                e.Appearance.BackColor = Color.CadetBlue
                e.Appearance.BackColor2 = Color.White
                If Convert.ToInt32(View.GetRowCellDisplayText(e.RowHandle, View.Columns("parcela"))) > 0 Then
                    e.Appearance.BackColor = Color.Goldenrod
                    e.Appearance.BackColor2 = Color.White
                End If
            End If
        End If
    End Sub

    Private Sub manutencaoinformeGridView_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles manutencaoinformeGridView.CustomColumnDisplayText
        Dim strValor As String = String.Empty

        If e.Column.FieldName = "cnpjcpfinforme" Then
            If manutencaoGridView.GetRowCellValue(e.ListSourceRowIndex, "cnpjcpfinforme") IsNot Nothing Then
                strValor = manutencaoGridView.GetRowCellValue(e.ListSourceRowIndex, "cnpjcpfinforme").ToString()
            Else
                strValor = e.Value.ToString
            End If
            If strValor.Length = 14 Then
                '##.###.###/####-##
                e.DisplayText = strValor.Substring(0, 2) + "." + strValor.Substring(2, 3) + "." + strValor.Substring(5, 3) + "/" + strValor.Substring(8, 4) + "-" + strValor.Substring(12, 2)
            ElseIf strValor.Length = 11 Then
                '###.###.###-##
                e.DisplayText = strValor.Substring(0, 3) + "." + strValor.Substring(3, 3) + "." + strValor.Substring(6, 3) + "-" + strValor.Substring(9, 2)
            Else
                e.DisplayText = strValor
            End If
        End If
    End Sub

    Private Sub detalheinformeGridView_DoubleClick(sender As Object, e As System.EventArgs) Handles detalheinformeGridView.DoubleClick
        Try
            If alterarBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always Then
                okSimpleButton.Tag = "alteracao"
                CarregaDados()
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub detalheinformeGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles detalheinformeGridView.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If alterarBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always Then
                    okSimpleButton.Tag = "alteracao"
                    CarregaDados()
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

    Private Sub detalheinformeGridView_RowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles detalheinformeGridView.RowStyle
        Dim View As GridView = CType(sender, GridView)
        If (e.RowHandle >= 0) Then
            Dim obrigacaoextra As Boolean = Convert.ToInt32(View.GetRowCellDisplayText(e.RowHandle, View.Columns("obrigacaoextra"))) = -1 And
                                          Convert.ToInt32(View.GetRowCellDisplayText(e.RowHandle, View.Columns("sequenciaextra"))) > 0
            If obrigacaoextra Then
                e.Appearance.BackColor = Color.CadetBlue
                e.Appearance.BackColor2 = Color.White
                If Convert.ToInt32(View.GetRowCellDisplayText(e.RowHandle, View.Columns("parcela"))) > 0 Then
                    e.Appearance.BackColor = Color.Goldenrod
                    e.Appearance.BackColor2 = Color.White
                End If
            End If
        End If
    End Sub

    Private Sub manutencaoicmsstGridView_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles manutencaoicmsstGridView.CustomColumnDisplayText
        Dim strValor As String = String.Empty

        If e.Column.FieldName = "nota" Then
            If manutencaoGridView.GetRowCellValue(e.ListSourceRowIndex, "nota") IsNot Nothing Then
                strValor = manutencaoGridView.GetRowCellValue(e.ListSourceRowIndex, "nota").ToString()
            Else
                strValor = e.Value.ToString
            End If
            e.DisplayText = strValor
        End If
    End Sub

    Private Sub detalheicmsstGridView_DoubleClick(sender As Object, e As System.EventArgs) Handles detalheicmsstGridView.DoubleClick
        Try
            If alterarBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always Then
                okSimpleButton.Tag = "alteracao"
                CarregaDados()
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub detalheicmsstGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles detalheicmsstGridView.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If alterarBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always Then
                    okSimpleButton.Tag = "alteracao"
                    CarregaDados()
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

    Private Sub detalheicmsstGridView_RowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles detalheicmsstGridView.RowStyle
        Dim View As GridView = CType(sender, GridView)
        If (e.RowHandle >= 0) Then
            Dim obrigacaoextra As Boolean = Convert.ToInt32(View.GetRowCellDisplayText(e.RowHandle, View.Columns("obrigacaoextra"))) = -1 And
                                          Convert.ToInt32(View.GetRowCellDisplayText(e.RowHandle, View.Columns("sequenciaextra"))) > 0
            If obrigacaoextra Then
                e.Appearance.BackColor = Color.CadetBlue
                e.Appearance.BackColor2 = Color.White
                If Convert.ToInt32(View.GetRowCellDisplayText(e.RowHandle, View.Columns("parcela"))) > 0 Then
                    e.Appearance.BackColor = Color.Goldenrod
                    e.Appearance.BackColor2 = Color.White
                End If
            End If
        End If
    End Sub
    Private Sub vistoentregaCheckButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles vistoentregaCheckButton.CheckedChanged
        If Not blnCarregaDados Then
            If vistoentregaCheckButton.Checked Then
                vistoentregaCheckButton.ImageIndex = 1
                usuarioentregaSearchLookUpEdit.EditValue = usuarioInfo.usuario
                datahoraentregaDateEdit.EditValue = Now
                If usuarioInfo.master Then
                    encarregadoGroupControl.Enabled = True
                End If
            Else
                vistoentregaCheckButton.ImageIndex = 0
                usuarioentregaSearchLookUpEdit.EditValue = String.Empty
                datahoraentregaDateEdit.EditValue = Nothing
                If usuarioInfo.master Then
                    vistoencarregadoCheckButton.Checked = False
                    encarregadoGroupControl.Enabled = False
                    If Not String.IsNullOrEmpty(obrigacaoSearchLookUpEdit.EditValue.ToString) Then
                        If obrigacaoSearchLookUpEdit.EditValue.ToString.Substring(0, 1) = "1" Then
                            geracaoGroupControl.Enabled = True
                            usuariogeracaoSearchLookUpEdit.Enabled = True
                            datahorageracaoDateEdit.Enabled = True
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub vistoencarregadoCheckButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles vistoencarregadoCheckButton.CheckedChanged
        If Not blnCarregaDados Then
            If vistoencarregadoCheckButton.Checked Then
                vistoencarregadoCheckButton.ImageIndex = 1
                usuarioencarregadoSearchLookUpEdit.EditValue = usuarioInfo.usuario
                datahoraencarregadoDateEdit.EditValue = Now
            Else
                vistoencarregadoCheckButton.ImageIndex = 0
                usuarioencarregadoSearchLookUpEdit.EditValue = String.Empty
                datahoraencarregadoDateEdit.EditValue = Nothing
                If usuarioInfo.master Then
                    entregaGroupControl.Enabled = True
                End If
            End If
            detalhesGroupControl.Enabled = (vistoencarregadoCheckButton.Checked)
            tipoenvioGroupControl.Enabled = (vistoencarregadoCheckButton.Checked)
        End If
    End Sub

    Private Sub empresaSearchLookUpEdit_CustomDisplayText(sender As Object, e As DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs) Handles empresaSearchLookUpEdit.CustomDisplayText
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

    Private Sub funcionarioSearchLookUpEdit_CustomDisplayText(sender As Object, e As DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs) Handles funcionarioSearchLookUpEdit.CustomDisplayText
        Try
            Dim editor As SearchLookUpEdit = TryCast(sender, SearchLookUpEdit)

            If editor.EditValue IsNot Nothing Then
                Dim index As Integer = editor.Properties.GetIndexByKeyValue(editor.EditValue)
                If index >= 0 Then
                    nomeTextEdit.Text = objComum.RetornaDescricao(funcionariosInfoBindingSource, index, "nome")
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

    Private Sub obrigacaoSearchLookUpEdit_CustomDisplayText(sender As Object, e As DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs) Handles obrigacaoSearchLookUpEdit.CustomDisplayText
        Try
            Dim editor As SearchLookUpEdit = TryCast(sender, SearchLookUpEdit)

            If editor.EditValue IsNot Nothing Then
                Dim index As Integer = editor.Properties.GetIndexByKeyValue(editor.EditValue)
                If index >= 0 Then
                    descricaoTextEdit.Text = objComum.RetornaDescricao(obrigacoesInfoBindingSource, index, "descricao")
                Else
                    descricaoTextEdit.Text = String.Empty
                End If
            Else
                descricaoTextEdit.Text = String.Empty
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub usuarioencarregadoSearchLookUpEdit_CustomDisplayText(sender As Object, e As DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs) Handles usuarioencarregadoSearchLookUpEdit.CustomDisplayText
        Try
            Dim editor As SearchLookUpEdit = TryCast(sender, SearchLookUpEdit)

            If editor.EditValue IsNot Nothing Then
                Dim index As Integer = editor.Properties.GetIndexByKeyValue(editor.EditValue)
                If index >= 0 Then
                    nomeencarregadoTextEdit.Text = objComum.RetornaDescricao(usuarioInfoBindingSource, index, "nome")
                Else
                    nomeencarregadoTextEdit.Text = String.Empty
                End If
            Else
                nomeencarregadoTextEdit.Text = String.Empty
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub usuarioentregaSearchLookUpEdit_CustomDisplayText(sender As Object, e As DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs) Handles usuarioentregaSearchLookUpEdit.CustomDisplayText
        Try
            Dim editor As SearchLookUpEdit = TryCast(sender, SearchLookUpEdit)

            If editor.EditValue IsNot Nothing Then
                Dim index As Integer = editor.Properties.GetIndexByKeyValue(editor.EditValue)
                If index >= 0 Then
                    nomeentregaTextEdit.Text = objComum.RetornaDescricao(usuarioInfoBindingSource, index, "nome")
                Else
                    nomeentregaTextEdit.Text = String.Empty
                End If
            Else
                nomeentregaTextEdit.Text = String.Empty
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub usuariogeracaoSearchLookUpEdit_CustomDisplayText(sender As Object, e As DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs) Handles usuariogeracaoSearchLookUpEdit.CustomDisplayText
        Try
            Dim editor As SearchLookUpEdit = TryCast(sender, SearchLookUpEdit)

            If editor.EditValue IsNot Nothing Then
                Dim index As Integer = editor.Properties.GetIndexByKeyValue(editor.EditValue)
                If index >= 0 Then
                    nomegeracaoTextEdit.Text = objComum.RetornaDescricao(usuarioInfoBindingSource, index, "nome")
                Else
                    nomegeracaoTextEdit.Text = String.Empty
                End If
            Else
                nomegeracaoTextEdit.Text = String.Empty
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tipoenvioImageComboBoxEdit_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles tipoenvioImageComboBoxEdit.SelectedIndexChanged
        siteSimpleButton.Visible = (tipoenvioImageComboBoxEdit.EditValue.ToString = "S" And Not String.IsNullOrEmpty(portalservidorInfo.cnpjcpf))
        If manutencaoobrigacoes.portalguias.Count > 0 Or manutencaoobrigacoes.portalarquivos.Count > 0 Then
            If manutencaoobrigacoes.portalguias.Count > 0 Then
                If Not String.IsNullOrEmpty(manutencaoobrigacoes.portalguias(0).usuarioenvio) Then
                    siteSimpleButton.ImageIndex = 1
                Else
                    siteSimpleButton.ImageIndex = 0
                End If
            End If
            If manutencaoobrigacoes.portalarquivos.Count > 0 Then
                If Not String.IsNullOrEmpty(manutencaoobrigacoes.portalarquivos(0).usuarioenvio) Then
                    siteSimpleButton.ImageIndex = 1
                Else
                    siteSimpleButton.ImageIndex = 0
                End If
            End If
        Else
            If siteSimpleButton.Visible Then
                siteSimpleButton.ImageIndex = 0
            End If
        End If
    End Sub

    Private Sub datahorageracaoDateEdit_EditValueChanged(sender As Object, e As System.EventArgs) Handles datahorageracaoDateEdit.EditValueChanged
        If datahorageracaoDateEdit.IsModified Then
            entregaGroupControl.Enabled = (Not datahorageracaoDateEdit.EditValue Is Nothing)
            If Not entregaGroupControl.Enabled Then
                vistoentregaCheckButton.Checked = False
                If usuarioInfo.master Then
                    encarregadoGroupControl.Enabled = (Not datahoraentregaDateEdit.EditValue Is Nothing)
                    If Not encarregadoGroupControl.Enabled Then
                        vistoencarregadoCheckButton.Checked = False
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub siteSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles siteSimpleButton.Click
        Dim objObrigacoes As New ObrigacoesBLL
        If objObrigacoes.RetornaLayoutObrigacao(obrigacaoSearchLookUpEdit.EditValue.ToString) > 0 Then
            If manutencaoobrigacoes.portalguias.Count > 0 Then
                Dim form As portalguiaXtraForm = New portalguiaXtraForm(manutencaoobrigacoes)
                form.ShowDialog(Me)
                If manutencaoobrigacoes.portalguias.Count > 0 Then
                    If Not String.IsNullOrEmpty(manutencaoobrigacoes.portalguias(0).usuarioenvio) Then
                        siteSimpleButton.ImageIndex = 1
                    Else
                        siteSimpleButton.ImageIndex = 0
                    End If
                End If
            Else
                XtraMessageBox.Show("Guia não gerada", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            Dim form As portalarquivoXtraForm = New portalarquivoXtraForm(manutencaoobrigacoes)
            form.ShowDialog(Me)

            If manutencaoobrigacoes.portalarquivos.Count > 0 Then
                If Not String.IsNullOrEmpty(manutencaoobrigacoes.portalarquivos(0).usuarioenvio) Then
                    siteSimpleButton.ImageIndex = 1
                Else
                    siteSimpleButton.ImageIndex = 0
                End If
            Else
                siteSimpleButton.ImageIndex = 0
            End If
        End If
    End Sub

    Private Sub funcionariosSimpleButton_Click(sender As Object, e As EventArgs) Handles funcionariosSimpleButton.Click
        Dim form As manutencaoobrigacoesfuncionariosXtraForm = New manutencaoobrigacoesfuncionariosXtraForm(manutencaoobrigacoes)
        form.ShowDialog(Me)
    End Sub

    Private Sub CarregaGrid()
        Try
            Dim strJoinUsuarios As String = String.Empty
            Dim strWhere As String = String.Empty
            If String.IsNullOrEmpty(strAlertaObrigacao) Then
                strWhere = objFiltro.RetornaWhereFiltro("aca")
            Else
                strWhere = strAlertaObrigacao
            End If

            If usuarioInfo.obrigacoes Then
                strJoinUsuarios = "join admobrigacoesusuarios aou on aou.obrigacao = aca.obrigacao and aou.usuario = '" + usuarioInfo.usuario + "' "
            End If
            Dim strQuery() As String = {"", "", "", "", "", "", "", ""}
            SplashScreenManager.ShowForm(Me, GetType(aguardeWaitForm), True, True, False)
            strQuery(0) = "select aca.empresa, max(e.razaosocial) as razaosocial, max(e.cnpj) as cnpj, aca.competencia, " +
                                         "case when  max(coalesce(ag.geradas,0)) + max(coalesce(ae.entrega,0)) + max(coalesce(ac.encarregado,0)) = 0 then 0 " +
                                         "else case when max(coalesce(ag.geradas,0)) = max(coalesce(ang.naogeradas,0)) and max(coalesce(ae.entrega,0)) = max(coalesce(ang.naogeradas,0)) and max(coalesce(ac.encarregado,0)) = max(coalesce(ang.naogeradas,0)) then 2 else 1 end end as status " +
                            "from admcontroleadministrativo aca " + strJoinUsuarios +
                            "join empresas e on e.empresa = aca.empresa and e.exercicio = aca.exercicio " +
                            "join (select aca.empresa, aca.competencia, sum(aca.naogeradas) as naogeradas " +
                                    "from ( " +
                                  "select aca.empresa, aca.competencia, count(*) as naogeradas from admcontroleadministrativo aca " + strJoinUsuarios + " where " + strWhere + " and coalesce(aca.tipopessoainforme,0) = 0 group by aca.empresa, aca.competencia " +
                               "union all " +
                                  "select aca.empresa, aca.competencia, count(*) as naogeradas from admcontroleadministrativo aca " + strJoinUsuarios + " join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio where " + strWhere + " group by aca.empresa, aca.competencia " +
                               "union all " +
                                  "select aca.empresa, aca.competencia, count(*) as naogeradas from admcontroleadministrativo aca " + strJoinUsuarios + " join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio where " + strWhere + " group by aca.empresa, aca.competencia " +
                                         ") aca group by aca.empresa, aca.competencia) ang on ang.empresa = aca.empresa and ang.competencia = aca.competencia " +
                       "left join (select aca.empresa, aca.competencia, sum(aca.geradas) as geradas " +
                                    "from ( " +
                                  "select aca.empresa, aca.competencia, count(*) as geradas from admcontroleadministrativo aca " + strJoinUsuarios + " where coalesce(aca.usuariogeracao,'') <> '' and not aca.datahorageracao is null and " + strWhere + " and coalesce(aca.tipopessoainforme,0) = 0 group by aca.empresa, aca.competencia " +
                               "union all " +
                                  "select aca.empresa, aca.competencia, count(*) as geradas from admcontroleadministrativo aca " + strJoinUsuarios + " join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio where coalesce(aca.usuariogeracao,'') <> '' and not aca.datahorageracao is null and " + strWhere + "group by aca.empresa, aca.competencia " +
                               "union all " +
                                  "select aca.empresa, aca.competencia, count(*) as geradas from admcontroleadministrativo aca " + strJoinUsuarios + " join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio where coalesce(aca.usuariogeracao,'') <> '' and not aca.datahorageracao is null and " + strWhere + "group by aca.empresa, aca.competencia " +
                                         ") aca group by aca.empresa, aca.competencia) ag on ag.empresa = aca.empresa and ag.competencia = aca.competencia " +
                       "left join (select aca.empresa, aca.competencia, sum(aca.entrega) as entrega " +
                                    "from ( " +
                                  "select aca.empresa, aca.competencia, count(*) as entrega from admcontroleadministrativo aca " + strJoinUsuarios + " where coalesce(aca.usuarioentrega,'') <> '' and not aca.datahoraentrega is null and aca.vistoentrega = -1 and " + strWhere + " and coalesce(aca.tipopessoainforme,0) = 0 group by aca.empresa, aca.competencia " +
                               "union all " +
                                  "select aca.empresa, aca.competencia, count(*) as entrega from admcontroleadministrativo aca " + strJoinUsuarios + " join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio where coalesce(aca.usuarioentrega,'') <> '' and not aca.datahoraentrega is null and aca.vistoentrega = -1 and " + strWhere + "group by aca.empresa, aca.competencia " +
                               "union all " +
                                  "select aca.empresa, aca.competencia, count(*) as entrega from admcontroleadministrativo aca " + strJoinUsuarios + " join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio where coalesce(aca.usuarioentrega,'') <> '' and not aca.datahoraentrega is null and aca.vistoentrega = -1 and " + strWhere + "group by aca.empresa, aca.competencia " +
                                         ") aca group by aca.empresa, aca.competencia) ae on ae.empresa = aca.empresa and ae.competencia = aca.competencia " +
                       "left join (select aca.empresa, aca.competencia, sum(aca.encarregado) as encarregado " +
                                    "from ( " +
                                   "select aca.empresa, aca.competencia, count(*) as encarregado from admcontroleadministrativo aca  " + strJoinUsuarios + " where coalesce(aca.usuarioencarregado,'') <> '' and not aca.datahoraencarregado is null and aca.vistoencarregado = -1 and " + strWhere + " and coalesce(aca.tipopessoainforme,0) = 0 group by aca.empresa, aca.competencia " +
                                "union all " +
                                   "select aca.empresa, aca.competencia, count(*) as encarregado from admcontroleadministrativo aca  " + strJoinUsuarios + " join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio where coalesce(aca.usuarioencarregado,'') <> '' and not aca.datahoraencarregado is null and aca.vistoencarregado = -1 and " + strWhere + "group by aca.empresa, aca.competencia " +
                                "union all " +
                                   "select aca.empresa, aca.competencia, count(*) as encarregado from admcontroleadministrativo aca  " + strJoinUsuarios + " join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio where coalesce(aca.usuarioencarregado,'') <> '' and not aca.datahoraencarregado is null and aca.vistoencarregado = -1 and " + strWhere + "group by aca.empresa, aca.competencia " +
                                         ") aca group by aca.empresa, aca.competencia) ac on ac.empresa = aca.empresa and ac.competencia = aca.competencia " +
                           "where " + strWhere + " " +
                        "group by aca.empresa, aca.competencia " +
                        "order by 1"
            strQuery(1) = "select aca.empresa, aca.obrigacao, ao.descricao, aca.datavencimento, " +
                                 "aca.usuariogeracao, aca.datahorageracao, aca.usuarioentrega,  aca.datahoraentrega, aca.usuarioencarregado, aca.datahoraencarregado, " +
                                 "case when coalesce(aca.usuariogeracao,'') = '' and coalesce(aca.vistoentrega,0) = 0 and coalesce(aca.vistoencarregado,0) = 0 then 0 " +
                                      "else case when coalesce(aca.usuariogeracao,'') <> '' and coalesce(aca.vistoentrega,0) <> 0 and coalesce(aca.vistoencarregado,0) <> 0 then 2 else 1 end end as status, " +
                                 "case when coalesce(aca.tipoenvio,'') = '' then 0 else case when coalesce(aca.tipoenvio,'') = 'E' then 1 else case when coalesce(aca.tipoenvio,'') = 'M' then 2 else 3 end end end as tipoenvio, " +
                                 "case when coalesce(ada.empresavisualizou,0) = -1 or coalesce(adg.empresavisualizou,0) = -1 then 1 else case when coalesce(aca.tipoenvio,'') = 'S' then case when coalesce(ada.usuarioenvio,'') <> '' or coalesce(adg.usuarioenvio,'') <> '' then 0 else 2 end else 3 end end as visualizou, " +
                                 "case when coalesce(ada.nomeusuarioempresa,'') <> '' then coalesce(ada.nomeusuarioempresa,'') else case when coalesce(adg.nomeusuarioempresa,'') <> '' then coalesce(adg.nomeusuarioempresa,'') else cast('' as varchar) end end as nomeusuarioempresa, " +
                                 "case when not ada.datahoraempresavisualizou is null then ada.datahoraempresavisualizou else case when not adg.datahoraempresavisualizou is null then adg.datahoraempresavisualizou else null end end as datahoraempresavisualizou, " +
                                 "aca.sequenciaextra, aca.obrigacaoextra, aca.vistoentrega, aca.vistoencarregado, aca.valorpago, aca.datapagamento, aca.valor, aca.parcela, aca.competencia, aca.observacao " +
                            "from admcontroleadministrativo aca " + strJoinUsuarios +
                            "join admobrigacoes ao on ao.obrigacao = aca.obrigacao " +
                       "left join admcontroleadministrativoportalguias adg on aca.empresa = adg.empresa " +
                                                                           "and aca.competencia = adg.competencia " +
                                                                           "and aca.obrigacao = adg.obrigacao " +
                                                                           "and aca.exercicio = adg.exercicio " +
                                                                           "and aca.parcela = adg.parcela " +
                                                                           "and aca.sequenciaextra = adg.sequenciaextra " +
                                                                           "and aca.obrigacaoextra = adg.obrigacaoextra " +
                                                                           "and aca.tipopessoainforme = adg.tipopessoainforme " +
                                                                           "and aca.informe = adg.informe " +
                                                                           "and coalesce(aca.funcionario,'') = coalesce(adg.funcionario,'') " +
                                                                           "and aca.exercicio = adg.exercicio " +
                       "left join admcontroleadministrativoportalarquivos ada on aca.empresa = ada.empresa " +
                                                                               "and aca.competencia = ada.competencia " +
                                                                               "and aca.obrigacao = ada.obrigacao " +
                                                                               "and aca.exercicio = ada.exercicio " +
                                                                               "and aca.parcela = ada.parcela " +
                                                                               "and aca.sequenciaextra = ada.sequenciaextra " +
                                                                               "and aca.obrigacaoextra = ada.obrigacaoextra " +
                                                                               "and aca.tipopessoainforme = ada.tipopessoainforme " +
                                                                               "and aca.informe = ada.informe " +
                                                                               "and coalesce(aca.funcionario,'') = coalesce(ada.funcionario,'') " +
                                                                               "and aca.exercicio = ada.exercicio " +
                           "where " + strWhere + " " +
                             "and coalesce(aca.funcionario,'') = '' " +
                             "and coalesce(aca.tipopessoainforme,0) = 0 "
            strQuery(1) += "union all "
            strQuery(1) += "select aca.empresa, aca.obrigacao, max(ao.descricao) as descricao, aca.datavencimento, " +
                                  "aca.usuariogeracao, aca.datahorageracao, max(aca.usuarioentrega) as usuarioentrega,  max(aca.datahoraentrega) as datahoraentrega, max(aca.usuarioencarregado) as usuarioencarregado, max(aca.datahoraencarregado) as datahoraencarregado, " +
                                  "case when coalesce(aca.usuariogeracao,'') = '' and min(coalesce(aca.vistoentrega,0)) = 0 and min(coalesce(aca.vistoencarregado,0)) = 0 then 0 " +
                                       "else case when coalesce(aca.usuariogeracao,'') <> '' and min(coalesce(aca.vistoentrega,0)) <> 0 and min(coalesce(aca.vistoencarregado,0)) <> 0 then 2 else 1 end end as status,  " +
                                  "max(case when coalesce(aca.tipoenvio,'') = '' then 0 else case when coalesce(aca.tipoenvio,'') = 'E' then 1 else case when coalesce(aca.tipoenvio,'') = 'M' then 2 else 3 end end end) as tipoenvio, " +
                                  "max(case when coalesce(ada.empresavisualizou,0) = -1 or coalesce(adg.empresavisualizou,0) = -1 then 1 else case when coalesce(aca.tipoenvio,'') = 'S' then case when coalesce(ada.usuarioenvio,'') <> '' or coalesce(adg.usuarioenvio,'') <> '' then 0 else 2 end else 3 end end) as visualizou, " +
                                  "max(case when coalesce(ada.nomeusuarioempresa,'') <> '' then coalesce(ada.nomeusuarioempresa,'') else case when coalesce(adg.nomeusuarioempresa,'') <> '' then coalesce(adg.nomeusuarioempresa,'') else cast('' as varchar) end end) as nomeusuarioempresa, " +
                                  "max(case when not ada.datahoraempresavisualizou is null then ada.datahoraempresavisualizou else case when not adg.datahoraempresavisualizou is null then adg.datahoraempresavisualizou else null end end) as datahoraempresavisualizou, " +
                                  "max(aca.sequenciaextra) as sequenciaextra, min(aca.obrigacaoextra) as obrigacaoextra, min(aca.vistoentrega) as vistoentrega, min(aca.vistoencarregado) as vistoencarregado, cast(0.00 as numeric(18,2)) as valorpago, max(aca.datapagamento) as datapagamento, cast(0.00 as numeric(18,2)) as valor, 0 as parcela, aca.competencia, max(aca.observacao) as observacao  " +
                             "from admcontroleadministrativo aca " + strJoinUsuarios +
                             "join admobrigacoes ao on ao.obrigacao = aca.obrigacao " +
                        "left join admcontroleadministrativoportalguias adg on aca.empresa = adg.empresa " +
                                                                            "and aca.competencia = adg.competencia " +
                                                                            "and aca.obrigacao = adg.obrigacao " +
                                                                            "and aca.exercicio = adg.exercicio " +
                                                                            "and aca.parcela = adg.parcela " +
                                                                            "and aca.sequenciaextra = adg.sequenciaextra " +
                                                                            "and aca.obrigacaoextra = adg.obrigacaoextra " +
                                                                            "and aca.tipopessoainforme = adg.tipopessoainforme " +
                                                                            "and aca.informe = adg.informe " +
                                                                            "and coalesce(aca.funcionario,'') = coalesce(adg.funcionario,'') " +
                                                                            "and aca.exercicio = adg.exercicio " +
                        "left join admcontroleadministrativoportalarquivos ada on aca.empresa = ada.empresa " +
                                                                                "and aca.competencia = ada.competencia " +
                                                                                "and aca.obrigacao = ada.obrigacao " +
                                                                                "and aca.exercicio = ada.exercicio " +
                                                                                "and aca.parcela = ada.parcela " +
                                                                                "and aca.sequenciaextra = ada.sequenciaextra " +
                                                                                "and aca.obrigacaoextra = ada.obrigacaoextra " +
                                                                                "and aca.tipopessoainforme = ada.tipopessoainforme " +
                                                                                "and aca.informe = ada.informe " +
                                                                                "and coalesce(aca.funcionario,'') = coalesce(ada.funcionario,'') " +
                                                                                "and aca.exercicio = ada.exercicio " +
                            "where " + strWhere + " " +
                              "and coalesce(aca.obrigacao,'') = '000003' " +
                              "and coalesce(aca.tipopessoainforme,0) = 0 " +
                         "group by aca.empresa, aca.competencia,  aca.datavencimento, aca.obrigacao, aca.usuariogeracao, aca.datahorageracao " +
                         "order by 1, 4, 2, 12"

            strQuery(2) = "select aca.empresa, aca.funcionario, max(f.nome) as nome, aca.competencia " +
                            "from admcontroleadministrativo aca " + strJoinUsuarios +
                            "join funcionarios f on f.empresa = aca.empresa and f.funcionario = aca.funcionario " +
                           "where " + strWhere + " " +
                             "and coalesce(aca.funcionario,'') <> '' " +
                             "and coalesce(aca.obrigacao,'') <> '000003' " +
                        "group by aca.empresa, aca.funcionario, aca.competencia " +
                        "order by aca.empresa, aca.funcionario"

            strQuery(3) = "select aca.empresa, aca.obrigacao, ao.descricao, aca.datavencimento, " +
                                 "aca.usuariogeracao, aca.datahorageracao, aca.usuarioentrega,  aca.datahoraentrega, aca.usuarioencarregado, aca.datahoraencarregado, " +
                                 "case when coalesce(aca.usuariogeracao,'') = '' and coalesce(aca.vistoentrega,0) = 0 and coalesce(aca.vistoencarregado,0) = 0 then 0 " +
                                      "else case when coalesce(aca.usuariogeracao,'') <> '' and coalesce(aca.vistoentrega,0) <> 0 and coalesce(aca.vistoencarregado,0) <> 0 then 2 else 1 end end as status, " +
                                 "case when coalesce(aca.tipoenvio,'') = '' then 0 else case when coalesce(aca.tipoenvio,'') = 'E' then 1 else case when coalesce(aca.tipoenvio,'') = 'M' then 2 else 3 end end end as tipoenvio, " +
                                 "case when coalesce(ada.empresavisualizou,0) = -1 or coalesce(adg.empresavisualizou,0) = -1 then 1 else case when coalesce(aca.tipoenvio,'') = 'S' then case when coalesce(ada.usuarioenvio,'') <> '' or coalesce(adg.usuarioenvio,'') <> '' then 0 else 2 end else 3 end end as visualizou, " +
                                 "case when coalesce(ada.nomeusuarioempresa,'') <> '' then coalesce(ada.nomeusuarioempresa,'') else case when coalesce(adg.nomeusuarioempresa,'') <> '' then coalesce(adg.nomeusuarioempresa,'') else cast('' as varchar) end end as nomeusuarioempresa, " +
                                 "case when not ada.datahoraempresavisualizou is null then ada.datahoraempresavisualizou else case when not adg.datahoraempresavisualizou is null then adg.datahoraempresavisualizou else null end end as datahoraempresavisualizou, " +
                                 "aca.funcionario, aca.sequenciaextra, aca.obrigacaoextra, aca.vistoentrega, aca.vistoencarregado, aca.valorpago, aca.datapagamento, aca.valor, aca.parcela, aca.competencia, aca.observacao " +
                            "from admcontroleadministrativo aca " + strJoinUsuarios +
                            "join admobrigacoes ao on ao.obrigacao = aca.obrigacao " +
                            "join funcionarios f on f.empresa = aca.empresa and f.funcionario = aca.funcionario " +
                       "left join admcontroleadministrativoportalguias adg on aca.empresa = adg.empresa " +
                                                                           "and aca.competencia = adg.competencia " +
                                                                           "and aca.obrigacao = adg.obrigacao " +
                                                                           "and aca.exercicio = adg.exercicio " +
                                                                           "and aca.parcela = adg.parcela " +
                                                                           "and aca.sequenciaextra = adg.sequenciaextra " +
                                                                           "and aca.obrigacaoextra = adg.obrigacaoextra " +
                                                                           "and aca.tipopessoainforme = adg.tipopessoainforme " +
                                                                           "and aca.informe = adg.informe " +
                                                                           "and coalesce(aca.funcionario,'') = coalesce(adg.funcionario,'') " +
                                                                           "and aca.exercicio = adg.exercicio " +
                       "left join admcontroleadministrativoportalarquivos ada on aca.empresa = ada.empresa " +
                                                                               "and aca.competencia = ada.competencia " +
                                                                               "and aca.obrigacao = ada.obrigacao " +
                                                                               "and aca.exercicio = ada.exercicio " +
                                                                               "and aca.parcela = ada.parcela " +
                                                                               "and aca.sequenciaextra = ada.sequenciaextra " +
                                                                               "and aca.obrigacaoextra = ada.obrigacaoextra " +
                                                                               "and aca.tipopessoainforme = ada.tipopessoainforme " +
                                                                               "and aca.informe = ada.informe " +
                                                                               "and coalesce(aca.funcionario,'') = coalesce(ada.funcionario,'') " +
                                                                               "and aca.exercicio = ada.exercicio " +
                           "where " + strWhere + " " +
                             "and coalesce(aca.funcionario,'') <> '' " +
                             "and coalesce(aca.obrigacao,'') <> '000003' " +
                        "order by aca.empresa, aca.datavencimento, aca.obrigacao, aca.sequenciaextra"

            strQuery(4) = "select aca.empresa, aca.cnpjcpfinforme, jur.nome, aca.competencia " +
                            "from admcontroleadministrativo aca " + strJoinUsuarios +
                            "join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio " +
                           "where " + strWhere + " " +
                             "and coalesce(aca.tipopessoainforme,0) = 1 " +
                        "group by aca.empresa, jur.nome, aca.cnpjcpfinforme, aca.competencia "
            strQuery(4) += "union all "
            strQuery(4) += "select aca.empresa, aca.cnpjcpfinforme, fis.nome, aca.competencia " +
                             "from admcontroleadministrativo aca " + strJoinUsuarios +
                             "join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio " +
                            "where " + strWhere + " " +
                              "and coalesce(aca.tipopessoainforme,0) = 2 " +
                         "group by aca.empresa, fis.nome, aca.cnpjcpfinforme, aca.competencia " +
                         "order by 1, 2"

            strQuery(5) = "select aca.empresa, aca.obrigacao, ao.descricao, aca.datavencimento, " +
                                 "aca.usuariogeracao, aca.datahorageracao, aca.usuarioentrega,  aca.datahoraentrega, aca.usuarioencarregado, aca.datahoraencarregado, " +
                                 "case when coalesce(aca.usuariogeracao,'') = '' and coalesce(aca.vistoentrega,0) = 0 and coalesce(aca.vistoencarregado,0) = 0 then 0 " +
                                      "else case when coalesce(aca.usuariogeracao,'') <> '' and coalesce(aca.vistoentrega,0) <> 0 and coalesce(aca.vistoencarregado,0) <> 0 then 2 else 1 end end as status, " +
                                 "case when coalesce(aca.tipoenvio,'') = '' then 0 else case when coalesce(aca.tipoenvio,'') = 'E' then 1 else case when coalesce(aca.tipoenvio,'') = 'M' then 2 else 3 end end end as tipoenvio, " +
                                 "case when coalesce(ada.empresavisualizou,0) = -1 or coalesce(adg.empresavisualizou,0) = -1 then 1 else case when coalesce(aca.tipoenvio,'') = 'S' then case when coalesce(ada.usuarioenvio,'') <> '' or coalesce(adg.usuarioenvio,'') <> '' then 0 else 2 end else 3 end end as visualizou, " +
                                 "case when coalesce(ada.nomeusuarioempresa,'') <> '' then coalesce(ada.nomeusuarioempresa,'') else case when coalesce(adg.nomeusuarioempresa,'') <> '' then coalesce(adg.nomeusuarioempresa,'') else cast('' as varchar) end end as nomeusuarioempresa, " +
                                 "case when not ada.datahoraempresavisualizou is null then ada.datahoraempresavisualizou else case when not adg.datahoraempresavisualizou is null then adg.datahoraempresavisualizou else null end end as datahoraempresavisualizou, " +
                                 "aca.cnpjcpfinforme, jur.nome, aca.tipopessoainforme, aca.informe, aca.darfinforme, aca.sequenciaextra, aca.obrigacaoextra, aca.vistoentrega, aca.vistoencarregado, aca.valorpago, aca.datapagamento, aca.valor, aca.parcela, aca.competencia, aca.observacao " +
                            "from admcontroleadministrativo aca " + strJoinUsuarios +
                            "join admobrigacoes ao on ao.obrigacao = aca.obrigacao " +
                            "join informesjuridica jur on jur.empresa = aca.empresa and jur.informejuridica = aca.informe and jur.darf = aca.darfinforme and jur.tipoinforme = aca.tipoinforme and jur.cnpj = aca.cnpjcpfinforme and jur.exercicio = aca.exercicio " +
                       "left join admcontroleadministrativoportalguias adg on aca.empresa = adg.empresa " +
                                                                           "and aca.competencia = adg.competencia " +
                                                                           "and aca.obrigacao = adg.obrigacao " +
                                                                           "and aca.parcela = adg.parcela " +
                                                                           "and aca.sequenciaextra = adg.sequenciaextra " +
                                                                           "and aca.obrigacaoextra = adg.obrigacaoextra " +
                                                                           "and aca.tipopessoainforme = adg.tipopessoainforme " +
                                                                           "and aca.informe = adg.informe " +
                                                                           "and coalesce(aca.funcionario,'') = coalesce(adg.funcionario,'') " +
                                                                           "and aca.exercicio = adg.exercicio " +
                       "left join admcontroleadministrativoportalarquivos ada on aca.empresa = ada.empresa " +
                                                                               "and aca.competencia = ada.competencia " +
                                                                               "and aca.obrigacao = ada.obrigacao " +
                                                                               "and aca.parcela = ada.parcela " +
                                                                               "and aca.sequenciaextra = ada.sequenciaextra " +
                                                                               "and aca.obrigacaoextra = ada.obrigacaoextra " +
                                                                               "and aca.tipopessoainforme = ada.tipopessoainforme " +
                                                                               "and aca.informe = ada.informe " +
                                                                               "and coalesce(aca.funcionario,'') = coalesce(ada.funcionario,'') " +
                                                                               "and aca.exercicio = ada.exercicio " +
                           "where " + strWhere + " " +
                             "and coalesce(aca.tipopessoainforme,0) = 1 "
            strQuery(5) += "union all "
            strQuery(5) += "select aca.empresa, aca.obrigacao, ao.descricao, aca.datavencimento, " +
                                  "aca.usuariogeracao, aca.datahorageracao, aca.usuarioentrega,  aca.datahoraentrega, aca.usuarioencarregado, aca.datahoraencarregado, " +
                                  "case when coalesce(aca.usuariogeracao,'') = '' and coalesce(aca.vistoentrega,0) = 0 and coalesce(aca.vistoencarregado,0) = 0 then 0 " +
                                       "else case when coalesce(aca.usuariogeracao,'') <> '' and coalesce(aca.vistoentrega,0) <> 0 and coalesce(aca.vistoencarregado,0) <> 0 then 2 else 1 end end as status, " +
                                 "case when coalesce(aca.tipoenvio,'') = '' then 0 else case when coalesce(aca.tipoenvio,'') = 'E' then 1 else case when coalesce(aca.tipoenvio,'') = 'M' then 2 else 3 end end end as tipoenvio, " +
                                 "case when coalesce(ada.empresavisualizou,0) = -1 or coalesce(adg.empresavisualizou,0) = -1 then 1 else case when coalesce(aca.tipoenvio,'') = 'S' then case when coalesce(ada.usuarioenvio,'') <> '' or coalesce(adg.usuarioenvio,'') <> '' then 0 else 2 end else 3 end end as visualizou, " +
                                 "case when coalesce(ada.nomeusuarioempresa,'') <> '' then coalesce(ada.nomeusuarioempresa,'') else case when coalesce(adg.nomeusuarioempresa,'') <> '' then coalesce(adg.nomeusuarioempresa,'') else cast('' as varchar) end end as nomeusuarioempresa, " +
                                 "case when not ada.datahoraempresavisualizou is null then ada.datahoraempresavisualizou else case when not adg.datahoraempresavisualizou is null then adg.datahoraempresavisualizou else null end end as datahoraempresavisualizou, " +
                                 "aca.cnpjcpfinforme, fis.nome, aca.tipopessoainforme, aca.informe, aca.darfinforme, aca.sequenciaextra, aca.obrigacaoextra, aca.vistoentrega, aca.vistoencarregado, aca.valorpago, aca.datapagamento, aca.valor, aca.parcela, aca.competencia, aca.observacao " +
                             "from admcontroleadministrativo aca " + strJoinUsuarios +
                             "join admobrigacoes ao on ao.obrigacao = aca.obrigacao " +
                             "join informesfisica fis on fis.empresa = aca.empresa and fis.informefisica = aca.informe and fis.darf = aca.darfinforme and fis.tipoinforme = aca.tipoinforme and fis.cpf = aca.cnpjcpfinforme and fis.exercicio = aca.exercicio " +
                        "left join admcontroleadministrativoportalguias adg on aca.empresa = adg.empresa " +
                                                                            "and aca.competencia = adg.competencia " +
                                                                            "and aca.obrigacao = adg.obrigacao " +
                                                                            "and aca.parcela = adg.parcela " +
                                                                            "and aca.sequenciaextra = adg.sequenciaextra " +
                                                                            "and aca.obrigacaoextra = adg.obrigacaoextra " +
                                                                            "and aca.tipopessoainforme = adg.tipopessoainforme " +
                                                                            "and aca.informe = adg.informe " +
                                                                            "and coalesce(aca.funcionario,'') = coalesce(adg.funcionario,'') " +
                                                                            "and aca.exercicio = adg.exercicio " +
                        "left join admcontroleadministrativoportalarquivos ada on aca.empresa = ada.empresa " +
                                                                                "and aca.competencia = ada.competencia " +
                                                                                "and aca.obrigacao = ada.obrigacao " +
                                                                                "and aca.parcela = ada.parcela " +
                                                                                "and aca.sequenciaextra = ada.sequenciaextra " +
                                                                                "and aca.obrigacaoextra = ada.obrigacaoextra " +
                                                                                "and aca.tipopessoainforme = ada.tipopessoainforme " +
                                                                                "and aca.informe = ada.informe " +
                                                                                "and coalesce(aca.funcionario,'') = coalesce(ada.funcionario,'') " +
                                                                                "and aca.exercicio = ada.exercicio " +
                            "where " + strWhere + " " +
                              "and coalesce(aca.tipopessoainforme,0) = 2 " +
                         "order by 1, 4, 2, 17"

            strQuery(6) = "select aca.empresa, aca.parcela, emi.razaosocial, aca.competencia " +
                            "from admcontroleadministrativo aca " + strJoinUsuarios +
                            "join entradasivaguias ent on ent.empresa = aca.empresa and ent.competencia = aca.competencia and ent.nota = aca.parcela and ent.emitente = aca.informe " +
                            "join fornecedores emi on emi.empresa = aca.empresa and emi.fornecedor = ent.emitente " +
                           "where " + strWhere + " " +
                             "and coalesce(aca.tipopessoainforme,0) = 1 " +
                        "group by aca.empresa, emi.razaosocial, aca.parcela, aca.competencia "

            strQuery(7) = "select aca.empresa, aca.obrigacao, ao.descricao, aca.datavencimento, " +
                                 "aca.usuariogeracao, aca.datahorageracao, aca.usuarioentrega,  aca.datahoraentrega, aca.usuarioencarregado, aca.datahoraencarregado, " +
                                 "case when coalesce(aca.usuariogeracao,'') = '' and coalesce(aca.vistoentrega,0) = 0 and coalesce(aca.vistoencarregado,0) = 0 then 0 " +
                                      "else case when coalesce(aca.usuariogeracao,'') <> '' and coalesce(aca.vistoentrega,0) <> 0 and coalesce(aca.vistoencarregado,0) <> 0 then 2 else 1 end end as status, " +
                                 "case when coalesce(aca.tipoenvio,'') = '' then 0 else case when coalesce(aca.tipoenvio,'') = 'E' then 1 else case when coalesce(aca.tipoenvio,'') = 'M' then 2 else 3 end end end as tipoenvio, " +
                                 "case when coalesce(ada.empresavisualizou,0) = -1 or coalesce(adg.empresavisualizou,0) = -1 then 1 else case when coalesce(aca.tipoenvio,'') = 'S' then case when coalesce(ada.usuarioenvio,'') <> '' or coalesce(adg.usuarioenvio,'') <> '' then 0 else 2 end else 3 end end as visualizou, " +
                                 "case when coalesce(ada.nomeusuarioempresa,'') <> '' then coalesce(ada.nomeusuarioempresa,'') else case when coalesce(adg.nomeusuarioempresa,'') <> '' then coalesce(adg.nomeusuarioempresa,'') else cast('' as varchar) end end as nomeusuarioempresa, " +
                                 "case when not ada.datahoraempresavisualizou is null then ada.datahoraempresavisualizou else case when not adg.datahoraempresavisualizou is null then adg.datahoraempresavisualizou else null end end as datahoraempresavisualizou, " +
                                 "aca.tipopessoainforme, aca.informe, aca.darfinforme, aca.sequenciaextra, aca.obrigacaoextra, aca.vistoentrega, aca.vistoencarregado, aca.valorpago, aca.datapagamento, aca.valor, aca.parcela, aca.competencia, aca.observacao, emi.razaosocial " +
                            "from admcontroleadministrativo aca " + strJoinUsuarios +
                            "join admobrigacoes ao on ao.obrigacao = aca.obrigacao " +
                            "join entradasivaguias e on e.empresa = aca.empresa and e.nota = aca.parcela and e.emitente = aca.informe " +
                            "join fornecedores emi on emi.empresa = aca.empresa and emi.fornecedor = e.emitente " +
                       "left join admcontroleadministrativoportalguias adg on aca.empresa = adg.empresa " +
                                                                           "and aca.competencia = adg.competencia " +
                                                                           "and aca.obrigacao = adg.obrigacao " +
                                                                           "and aca.exercicio = adg.exercicio " +
                                                                           "and aca.parcela = adg.parcela " +
                                                                           "and aca.sequenciaextra = adg.sequenciaextra " +
                                                                           "and aca.obrigacaoextra = adg.obrigacaoextra " +
                                                                           "and aca.tipopessoainforme = adg.tipopessoainforme " +
                                                                           "and aca.informe = adg.informe " +
                                                                           "and coalesce(aca.funcionario,'') = coalesce(adg.funcionario,'') " +
                                                                           "and aca.exercicio = adg.exercicio " +
                       "left join admcontroleadministrativoportalarquivos ada on aca.empresa = ada.empresa " +
                                                                               "and aca.competencia = ada.competencia " +
                                                                               "and aca.obrigacao = ada.obrigacao " +
                                                                               "and aca.exercicio = ada.exercicio " +
                                                                               "and aca.parcela = ada.parcela " +
                                                                               "and aca.sequenciaextra = ada.sequenciaextra " +
                                                                               "and aca.obrigacaoextra = ada.obrigacaoextra " +
                                                                               "and aca.tipopessoainforme = ada.tipopessoainforme " +
                                                                               "and aca.informe = ada.informe " +
                                                                               "and coalesce(aca.funcionario,'') = coalesce(ada.funcionario,'') " +
                                                                               "and aca.exercicio = ada.exercicio " +
                           "where " + strWhere + " " +
                             "and coalesce(aca.parcela,0) <> 0 " +
                             "and coalesce(aca.informe,0) <> 0 " +
                             "and coalesce(aca.obrigacao,'') = '000102' " +
                        "order by aca.empresa, aca.datavencimento, aca.obrigacao, aca.parcela, aca.informe, aca.sequenciaextra"

            objManutencaoObrigacoes.Grid(strQuery, manutencaoGridControl, manutencaoGridView, manutencaoempresaGridView, manutencaofuncionarioGridView, detalhefuncionarioGridView, manutencaoinformeGridView, detalheinformeGridView, manutencaoicmsstGridView, detalheicmsstGridView, statusImageCollection, tipoenvioImageCollection, visualizouempresaImageCollection)
            SplashScreenManager.CloseForm()
        Catch ex As Exception
            SplashScreenManager.CloseForm()
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CarregaDados()
        intLinhaGroupMaster = (CType(manutencaoGridControl.MainView, ColumnView)).FocusedRowHandle

        If manutencaoGridView.GetMasterRowExpanded(intLinhaGroupMaster) Then
            'Detalhe do Grid que será alterado
            Dim detailView As GridView = TryCast(manutencaoGridControl.FocusedView, GridView)

            Dim intLinha As Integer() = detailView.GetSelectedRows()
            For i As Integer = 0 To intLinha.Length - 1
                blnCarregaDados = True
                obrigacoesTabPane.SelectedPageIndex = 0
                competenciaTextEdit.EditValue = detailView.GetRowCellValue(intLinha(i), detailView.Columns("competencia")).ToString()

                Dim intExercicio As Int32 = 0
                If competenciaTextEdit.EditValue.ToString.Length > 0 Then
                    intExercicio = Convert.ToInt32(competenciaTextEdit.EditValue.ToString.Substring(2, 4))
                End If
                objComum.Browse("select empresa, razaosocial " +
                                  "from empresas " +
                                 "where exercicio = " + intExercicio.ToString + " order by empresa", empresasInfoBindingSource)
                empresaSearchLookUpEdit.EditValue = detailView.GetRowCellValue(intLinha(i), detailView.Columns("empresa")).ToString()

                obrigacaoSearchLookUpEdit.EditValue = detailView.GetRowCellValue(intLinha(i), detailView.Columns("obrigacao")).ToString()
                datavencimentoDateEdit.EditValue = detailView.GetRowCellValue(intLinha(i), detailView.Columns("datavencimento"))
                intSequenciaExtra = Convert.ToInt32(detailView.GetRowCellValue(intLinha(i), detailView.Columns("sequenciaextra")))
                intObrigacaoExtra = Convert.ToInt32(detailView.GetRowCellValue(intLinha(i), detailView.Columns("obrigacaoextra")))
                parcelaTextEdit.EditValue = Convert.ToInt32(detailView.GetRowCellValue(intLinha(i), detailView.Columns("parcela")))
                observacaoTextEdit.EditValue = detailView.GetRowCellValue(intLinha(i), detailView.Columns("observacao")).ToString()

                If String.IsNullOrEmpty(datavencimentoDateEdit.EditValue.ToString) And intSequenciaExtra = 0 Then
                    datavencimentoDateEdit.Enabled = True
                End If

                funcionarioSearchLookUpEdit.Visible = (manutencaoGridControl.FocusedView.LevelName().ToString = "DetalheFuncionario")
                nomeTextEdit.Visible = (manutencaoGridControl.FocusedView.LevelName().ToString = "DetalheFuncionario")
                nomebeneficiarioTextEdit.Visible = (manutencaoGridControl.FocusedView.LevelName().ToString = "DetalheInforme")
                funcionarioLabelControl.Visible = (manutencaoGridControl.FocusedView.LevelName().ToString = "DetalheFuncionario")
                cnpjcpfTextEdit.Visible = (manutencaoGridControl.FocusedView.LevelName().ToString = "DetalheInforme")
                cnpjcpfLabelControl.Visible = (manutencaoGridControl.FocusedView.LevelName().ToString = "DetalheInforme")
                darfTextEdit.Visible = (manutencaoGridControl.FocusedView.LevelName().ToString = "DetalheInforme")
                darfLabelControl.Visible = (manutencaoGridControl.FocusedView.LevelName().ToString = "DetalheInforme")
                informeLabelControl.Visible = (manutencaoGridControl.FocusedView.LevelName().ToString = "DetalheInforme")
                informeTextEdit.Visible = (manutencaoGridControl.FocusedView.LevelName().ToString = "DetalheInforme")
                Dim intTopGroupGeracao As Int32 = 138
                Dim intTopGroupEntrega As Int32 = 212
                Dim intTopGroupEncarregado As Int32 = 288
                Dim intTopGroupDetalhado As Int32 = 247

                If (manutencaoGridControl.FocusedView.LevelName().ToString = "DetalheFuncionario") Then
                    objComum.Browse("select f.funcionario, f.nome " +
                                      "from funcionarios f " +
                                      "join funcionarioscompetencias fc on fc.funcionario = f.funcionario and fc.empresa = f.empresa and fc.competencia = '" + competenciaTextEdit.EditValue.ToString + "' " +
                                     "where f.empresa = '" + empresaSearchLookUpEdit.EditValue.ToString + "' order by 1", funcionariosInfoBindingSource)
                    funcionarioSearchLookUpEdit.EditValue = detailView.GetRowCellValue(intLinha(i), detailView.Columns("funcionario")).ToString()
                ElseIf (manutencaoGridControl.FocusedView.LevelName().ToString = "DetalheInforme") Then
                    intInforme = Convert.ToInt32(detailView.GetRowCellValue(intLinha(i), detailView.Columns("informe")))
                    intTipoPessoaInforme = Convert.ToInt32(detailView.GetRowCellValue(intLinha(i), detailView.Columns("tipopessoainforme")))
                    If detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString().Length = 14 Then
                        cnpjcpfLabelControl.Text = "CNPJ - Beneficiário"
                        cnpjcpfTextEdit.Properties.Mask.EditMask = "00.000.000/0000-00"
                    ElseIf detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString().Length = 11 Then
                        cnpjcpfLabelControl.Text = "CPF - Beneficiário"
                        cnpjcpfTextEdit.Properties.Mask.EditMask = "000.000.000-00"
                    End If
                    cnpjcpfTextEdit.Text = detailView.GetRowCellValue(intLinha(i), detailView.Columns("cnpjcpfinforme")).ToString()
                    nomebeneficiarioTextEdit.Text = detailView.GetRowCellValue(intLinha(i), detailView.Columns("nome")).ToString()
                    informeTextEdit.Text = intInforme.ToString()
                    funcionariosInfoBindingSource.DataSource = Nothing
                    funcionarioSearchLookUpEdit.EditValue = String.Empty
                    intTopGroupDetalhado -= 35
                ElseIf (manutencaoGridControl.FocusedView.LevelName().ToString = "DetalheIcmsst") Then
                    intInforme = Convert.ToInt32(detailView.GetRowCellValue(intLinha(i), detailView.Columns("informe")))
                    intTipoPessoaInforme = Convert.ToInt32(detailView.GetRowCellValue(intLinha(i), detailView.Columns("tipopessoainforme")))
                    cnpjcpfTextEdit.Text = detailView.GetRowCellValue(intLinha(i), detailView.Columns("parcela")).ToString()
                    nomebeneficiarioTextEdit.Text = detailView.GetRowCellValue(intLinha(i), detailView.Columns("razaosocial")).ToString()
                    informeTextEdit.Text = intInforme.ToString()
                    funcionariosInfoBindingSource.DataSource = Nothing
                    funcionarioSearchLookUpEdit.EditValue = String.Empty
                    intTopGroupDetalhado -= 35
                Else
                    funcionariosInfoBindingSource.DataSource = Nothing
                    funcionarioSearchLookUpEdit.EditValue = String.Empty
                    nomeTextEdit.Text = String.Empty
                    nomebeneficiarioTextEdit.Text = String.Empty
                    cnpjcpfTextEdit.Text = String.Empty
                    darfTextEdit.Text = String.Empty

                    intTopGroupGeracao -= 45
                    intTopGroupEntrega -= 45
                    intTopGroupEncarregado -= 45
                    intTopGroupDetalhado -= 45
                End If

                manutencaoobrigacoes = objManutencaoObrigacoes.BuscaDados(empresaSearchLookUpEdit.EditValue.ToString, competenciaTextEdit.EditValue.ToString, intExercicio,
                                                                          obrigacaoSearchLookUpEdit.EditValue.ToString, intSequenciaExtra, intObrigacaoExtra, funcionarioSearchLookUpEdit.EditValue.ToString,
                                                                          Convert.ToInt32(parcelaTextEdit.EditValue), intTipoPessoaInforme, intInforme)

                usuariogeracaoSearchLookUpEdit.EditValue = manutencaoobrigacoes.usuariogeracao.ToString
                datahorageracaoDateEdit.EditValue = manutencaoobrigacoes.datahorageracao
                valorCalcEdit.EditValue = manutencaoobrigacoes.valor
                usuarioentregaSearchLookUpEdit.EditValue = manutencaoobrigacoes.usuarioentrega.ToString
                datahoraentregaDateEdit.EditValue = manutencaoobrigacoes.datahoraentrega
                vistoentregaCheckButton.Checked = Convert.ToBoolean(manutencaoobrigacoes.vistoentrega)
                If vistoentregaCheckButton.Checked Then
                    vistoentregaCheckButton.ImageIndex = 1
                Else
                    vistoentregaCheckButton.ImageIndex = 0
                End If
                usuarioencarregadoSearchLookUpEdit.EditValue = manutencaoobrigacoes.usuarioencarregado.ToString
                datahoraencarregadoDateEdit.EditValue = manutencaoobrigacoes.datahoraencarregado
                vistoencarregadoCheckButton.Checked = Convert.ToBoolean(manutencaoobrigacoes.vistoencarregado)
                If vistoencarregadoCheckButton.Checked Then
                    vistoencarregadoCheckButton.ImageIndex = 1
                Else
                    vistoencarregadoCheckButton.ImageIndex = 0
                End If
                datapagamentoDateEdit.EditValue = manutencaoobrigacoes.datapagamento
                valorpagoCalcEdit.EditValue = manutencaoobrigacoes.valorpago
                tipoenvioImageComboBoxEdit.EditValue = manutencaoobrigacoes.tipoenvio.ToString
                If obrigacaoSearchLookUpEdit.EditValue.ToString = "000092" Then
                    darfTextEdit.Visible = (manutencaoobrigacoes.portalguias.Count > 0)
                    darfLabelControl.Visible = (manutencaoobrigacoes.portalguias.Count > 0)
                    If manutencaoobrigacoes.portalguias.Count > 0 Then
                        darfTextEdit.Text = manutencaoobrigacoes.portalguias(0).codigoreceita.ToString
                    End If
                Else
                    darfTextEdit.Text = manutencaoobrigacoes.darfinforme.ToString
                End If
                entregaGroupControl.Enabled = (Not String.IsNullOrEmpty(usuariogeracaoSearchLookUpEdit.EditValue.ToString) And Not vistoencarregadoCheckButton.Checked)
                encarregadoGroupControl.Enabled = (Not String.IsNullOrEmpty(usuarioentregaSearchLookUpEdit.EditValue.ToString) And vistoentregaCheckButton.Checked And usuarioInfo.master)
                detalhesGroupControl.Enabled = (Not String.IsNullOrEmpty(usuarioencarregadoSearchLookUpEdit.EditValue.ToString) And vistoencarregadoCheckButton.Checked And usuarioInfo.master)
                tipoenvioGroupControl.Enabled = (Not String.IsNullOrEmpty(usuarioencarregadoSearchLookUpEdit.EditValue.ToString) And vistoencarregadoCheckButton.Checked)

                HabilitaBotoes(okSimpleButton.Tag.ToString)
                manutencaoSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1

                geracaoGroupControl.Enabled = (obrigacaoSearchLookUpEdit.EditValue.ToString.Substring(0, 1) = "1")
                geracaoGroupControl.Location = New Point(geracaoGroupControl.Location.X, intTopGroupGeracao)
                funcionariosSimpleButton.Location = New Point(funcionariosSimpleButton.Location.X, intTopGroupGeracao + 27)
                tipoenvioGroupControl.Location = New Point(tipoenvioGroupControl.Location.X, intTopGroupGeracao)
                entregaGroupControl.Location = New Point(entregaGroupControl.Location.X, intTopGroupEntrega)
                encarregadoGroupControl.Location = New Point(encarregadoGroupControl.Location.X, intTopGroupEncarregado)
                detalhesGroupControl.Location = New Point(detalhesGroupControl.Location.X, intTopGroupDetalhado)
                detalhesGroupControl.Height = 148
                parcelaTextEdit.Visible = (Convert.ToInt32(parcelaTextEdit.EditValue) > 0)
                parcelaLabelControl.Visible = parcelaTextEdit.Visible

                If parcelaLabelControl.Visible Then
                    If obrigacaoSearchLookUpEdit.EditValue.ToString = "000007" OrElse
                       obrigacaoSearchLookUpEdit.EditValue.ToString = "000008" OrElse
                       obrigacaoSearchLookUpEdit.EditValue.ToString = "000010" OrElse
                       obrigacaoSearchLookUpEdit.EditValue.ToString = "000011" OrElse
                       obrigacaoSearchLookUpEdit.EditValue.ToString = "000081" OrElse
                       obrigacaoSearchLookUpEdit.EditValue.ToString = "000082" OrElse
                       obrigacaoSearchLookUpEdit.EditValue.ToString = "000083" OrElse
                       obrigacaoSearchLookUpEdit.EditValue.ToString = "000084" Then
                        parcelaLabelControl.Text = "Parcela"
                    ElseIf obrigacaoSearchLookUpEdit.EditValue.ToString = "000022" Then
                        parcelaLabelControl.Text = "Quinzena"
                    ElseIf obrigacaoSearchLookUpEdit.EditValue.ToString = "000043" Then
                        parcelaLabelControl.Text = "Departamento"
                    End If
                Else
                    detalhesGroupControl.Height = detalhesGroupControl.Height - 35
                End If

                If geracaoGroupControl.Enabled Then
                    valorLabelControl.Visible = True
                    valorCalcEdit.Visible = True
                    If String.IsNullOrEmpty(usuariogeracaoSearchLookUpEdit.EditValue.ToString) Then
                        usuariogeracaoSearchLookUpEdit.EditValue = usuarioInfo.usuario
                    End If
                    geracaoGroupControl.Enabled = String.IsNullOrEmpty(usuarioentregaSearchLookUpEdit.EditValue.ToString)
                    If (obrigacaoSearchLookUpEdit.EditValue.ToString.Substring(0, 1) = "1") Then
                        If Not geracaoGroupControl.Enabled Then
                            geracaoGroupControl.Enabled = True
                            usuariogeracaoSearchLookUpEdit.Enabled = False
                            nomegeracaoTextEdit.Enabled = False
                            datahorageracaoDateEdit.Enabled = False
                        Else
                            usuariogeracaoSearchLookUpEdit.Enabled = True
                            datahorageracaoDateEdit.Enabled = True
                            If datahorageracaoDateEdit.EditValue Is Nothing Then
                                datahorageracaoDateEdit.IsModified = True
                                datahorageracaoDateEdit.EditValue = Date.Now
                            End If
                        End If
                    End If
                Else
                    valorLabelControl.Visible = (Convert.ToDecimal(valorCalcEdit.EditValue) <> 0 And obrigacaoSearchLookUpEdit.EditValue.ToString <> "000093" And obrigacaoSearchLookUpEdit.EditValue.ToString <> "000044" And obrigacaoSearchLookUpEdit.EditValue.ToString <> "000045" And obrigacaoSearchLookUpEdit.EditValue.ToString <> "000099")
                    valorCalcEdit.Visible = (Convert.ToDecimal(valorCalcEdit.EditValue) <> 0 And obrigacaoSearchLookUpEdit.EditValue.ToString <> "000093" And obrigacaoSearchLookUpEdit.EditValue.ToString <> "000044" And obrigacaoSearchLookUpEdit.EditValue.ToString <> "000045" And obrigacaoSearchLookUpEdit.EditValue.ToString <> "000099")
                End If
                funcionariosSimpleButton.Visible = (obrigacaoSearchLookUpEdit.EditValue.ToString = "000003")
                Me.Width = 915
                blnCarregaDados = False
            Next
        End If
    End Sub

    Private Sub HabilitaBotoes(pstrOperacao As String)
        localizarBarCheckItem.Enabled = (pstrOperacao = String.Empty)
        atualizarBarButtonItem.Enabled = (pstrOperacao = String.Empty)
        filtroBarButtonItem.Enabled = (pstrOperacao = String.Empty)
        alterarBarButtonItem.Enabled = (pstrOperacao = String.Empty And manutencaoGridView.RowCount > 0)
        If okSimpleButton.Tag.ToString = "exclusao" Then
            okSimpleButton.Text = "Excluir"
            okSimpleButton.ImageIndex = 1
        Else
            okSimpleButton.Text = "OK"
            okSimpleButton.ImageIndex = 0
        End If
        If okSimpleButton.Tag.ToString <> String.Empty Then
            Me.AcceptButton = okSimpleButton
        End If
    End Sub

    Private Sub LimpaDados()
        empresaSearchLookUpEdit.EditValue = String.Empty
        razaosocialTextEdit.Text = String.Empty
        competenciaTextEdit.EditValue = String.Empty
        obrigacaoSearchLookUpEdit.EditValue = String.Empty
        descricaoTextEdit.Text = String.Empty
        datavencimentoDateEdit.EditValue = Nothing
        funcionarioSearchLookUpEdit.EditValue = String.Empty
        nomeTextEdit.Text = String.Empty
        nomebeneficiarioTextEdit.Text = String.Empty
        cnpjcpfTextEdit.Text = String.Empty
        darfTextEdit.Text = String.Empty
        informeTextEdit.Text = String.Empty

        usuariogeracaoSearchLookUpEdit.EditValue = String.Empty
        nomegeracaoTextEdit.Text = String.Empty
        tipoenvioImageComboBoxEdit.EditValue = String.Empty

        usuarioentregaSearchLookUpEdit.EditValue = String.Empty
        nomeentregaTextEdit.Text = String.Empty
        datahoraentregaDateEdit.EditValue = Nothing
        vistoentregaCheckButton.Checked = False

        usuarioencarregadoSearchLookUpEdit.EditValue = String.Empty
        nomeencarregadoTextEdit.Text = String.Empty
        datahoraencarregadoDateEdit.EditValue = Nothing
        vistoencarregadoCheckButton.Checked = False

        datapagamentoDateEdit.EditValue = Nothing
        valorCalcEdit.EditValue = 0
        valorpagoCalcEdit.EditValue = 0
        intInforme = 0
        intTipoPessoaInforme = 0

        okSimpleButton.Tag = String.Empty
        Me.AcceptButton = Nothing
        HabilitaBotoes(okSimpleButton.Tag.ToString)
        Me.Width = 1224
    End Sub

    Private Sub SetModelo(pstrOperacao As String)
        If Not datavencimentoDateEdit.EditValue Is Nothing Then
            manutencaoobrigacoes.datavencimento = Convert.ToDateTime(datavencimentoDateEdit.EditValue)
        End If

        If Not usuariogeracaoSearchLookUpEdit.EditValue Is Nothing Then
            If Not String.IsNullOrEmpty(usuariogeracaoSearchLookUpEdit.EditValue.ToString) Then
                manutencaoobrigacoes.usuariogeracao = usuariogeracaoSearchLookUpEdit.EditValue.ToString
            End If
        Else
            manutencaoobrigacoes.usuariogeracao = String.Empty
        End If
        If Not datahorageracaoDateEdit.EditValue Is Nothing Then
            manutencaoobrigacoes.datahorageracao = Convert.ToDateTime(datahorageracaoDateEdit.EditValue)
        Else
            manutencaoobrigacoes.datahorageracao = Nothing
        End If

        manutencaoobrigacoes.tipoenvio = tipoenvioImageComboBoxEdit.EditValue.ToString
        manutencaoobrigacoes.usuarioentrega = usuarioentregaSearchLookUpEdit.EditValue.ToString
        If Not datahoraentregaDateEdit.EditValue Is Nothing Then
            manutencaoobrigacoes.datahoraentrega = Convert.ToDateTime(datahoraentregaDateEdit.EditValue)
        Else
            manutencaoobrigacoes.datahoraentrega = Nothing
        End If
        If vistoentregaCheckButton.Checked Then
            manutencaoobrigacoes.vistoentrega = -1
        Else
            manutencaoobrigacoes.vistoentrega = 0
        End If

        manutencaoobrigacoes.usuarioencarregado = usuarioencarregadoSearchLookUpEdit.EditValue.ToString
        If Not datahoraencarregadoDateEdit.EditValue Is Nothing Then
            manutencaoobrigacoes.datahoraencarregado = Convert.ToDateTime(datahoraencarregadoDateEdit.EditValue)
        Else
            manutencaoobrigacoes.datahoraencarregado = Nothing
        End If

        If vistoencarregadoCheckButton.Checked Then
            manutencaoobrigacoes.vistoencarregado = -1
        Else
            manutencaoobrigacoes.vistoencarregado = 0
        End If

        manutencaoobrigacoes.valor = Convert.ToDecimal(valorCalcEdit.EditValue)
        manutencaoobrigacoes.valorpago = Convert.ToDecimal(valorpagoCalcEdit.EditValue)
        If Not datapagamentoDateEdit.EditValue Is Nothing Then
            manutencaoobrigacoes.datapagamento = Convert.ToDateTime(datapagamentoDateEdit.EditValue)
        End If
        If parcelaTextEdit.Visible Then
            manutencaoobrigacoes.parcela = Convert.ToInt32(parcelaTextEdit.EditValue)
        End If
        If Not observacaoTextEdit.EditValue Is Nothing Then
            manutencaoobrigacoes.observacao = observacaoTextEdit.EditValue.ToString
        End If

        objManutencaoObrigacoes.IUDManutencaoObrigacoes(pstrOperacao, manutencaoobrigacoes)
        RetornaGridFocu()
        LimpaDados()
    End Sub

    Private Sub RetornaGridFocu()

        Dim focusedView As GridView = CType(manutencaoGridControl.FocusedView, GridView)
        Dim focusedRowHandle As Integer = focusedView.FocusedRowHandle

        listGridLinhaFocu.Clear()

        If focusedView.ParentView IsNot Nothing Then
            Dim nextView As GridView = MoveRegistroPai(focusedView)

            If nextView.ParentView IsNot Nothing Then
                MoveRegistroPai(nextView)
            End If

        End If
        CarregaGrid()
        If listGridLinhaFocu.Count = 0 Then
            manutencaoGridView.FocusedRowHandle = focusedRowHandle
        Else
            manutencaoGridView.SetMasterRowExpandedEx(listGridLinhaFocu(listGridLinhaFocu.Count - 1).SourceRowHandle, listGridLinhaFocu(listGridLinhaFocu.Count - 1).RelationIndex, True)
            manutencaoGridView.FocusedRowHandle = listGridLinhaFocu(listGridLinhaFocu.Count - 1).SourceRowHandle
            Dim view As GridView = CType(manutencaoGridView.GetVisibleDetailView(listGridLinhaFocu(listGridLinhaFocu.Count - 1).SourceRowHandle), GridView)

            For i As Integer = listGridLinhaFocu.Count - 2 To 0 Step -1
                view.SetMasterRowExpandedEx(listGridLinhaFocu(i).SourceRowHandle, listGridLinhaFocu(i).RelationIndex, True)
                view = CType(view.GetVisibleDetailView(listGridLinhaFocu(i).SourceRowHandle), GridView)
            Next i
            If manutencaoGridView.FocusedRowHandle >= 0 Then
                view.FocusedRowHandle = focusedRowHandle
            End If
        End If
    End Sub

    Private Function MoveRegistroPai(ByVal view As GridView) As GridView
        Dim parentView As GridView = CType(view.ParentView, GridView)
        Dim firstSourceRowHandle As Integer = view.SourceRowHandle
        Dim relationIndex1 As Integer = parentView.GetVisibleDetailRelationIndex(firstSourceRowHandle)

        listGridLinhaFocu.Add(New GridLinhaFocu() With {.SourceRowHandle = firstSourceRowHandle, .RelationIndex = relationIndex1})

        Return parentView
    End Function
End Class
