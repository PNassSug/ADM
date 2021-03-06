﻿Imports Administrativo.Modelo
Imports Administrativo.BLL
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports DevExpress.XtraEditors.Mask

Public Class tarefasextrasXtraForm
    Dim objTarefasExtras As New TarefasExtrasBLL
    Dim objComum As New ComumBLL
    Dim objFiltro As New FiltroBLL
    Dim blnCancela As Boolean = False
    Dim intLinhaGroup As Int32 = 0
    Dim intLinhaRegistro As Int32 = 0
    Dim intSequenciaExtra As Int32 = 0

    Dim infoobrigacoes As New obrigacoesInfo
    Dim infovariacao As List(Of obrigacoesvariacao)
    Dim strEstado As String = String.Empty
    Dim strMunicipio As String = String.Empty

    Public Sub New()
        InitializeComponent()
        If usuarioInfo.obrigacoes Then
            objComum.Browse("select ao.obrigacao, ao.descricao, coalesce(ao.sistema,'') as sistema, coalesce(ao.periodicidade,'') as periodicidade, " +
                                   "ao.vencimento, coalesce(ao.tipodia,'F') as tipodia, ao.sabdomutil, ao.antecipautil, ao.subsequente, coalesce(ao.tiposubsequente,'') as tiposubsequente " +
                              "from admobrigacoes ao " +
                              "join admobrigacoesusuarios aou on aou.obrigacao = ao.obrigacao and aou.usuario = '" + usuarioInfo.usuario + "' " +
                             "where coalesce(ao.parcelamento,0) = 0 " +
                          "order by ao.obrigacao", obrigacoesInfoBindingSource)
        Else
            objComum.Browse("select ao.obrigacao, ao.descricao, coalesce(ao.sistema,'') as sistema, coalesce(ao.periodicidade,'') as periodicidade, " +
                                   "ao.vencimento, coalesce(ao.tipodia,'F') as tipodia, ao.sabdomutil, ao.antecipautil, ao.subsequente, coalesce(ao.tiposubsequente,'') as tiposubsequente " +
                              "from admobrigacoes ao " +
                             "where coalesce(ao.parcelamento,0) = 0 " +
                          "order by ao.obrigacao", obrigacoesInfoBindingSource)
        End If
        tarefasextrasSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
    End Sub

    Private Sub tarefasextrasXtraForm_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
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

    Private Sub tarefasextrasXtraForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Try
            CarregaGrid()
            objFiltro.IconeOpcaoFiltro(filtroBarButtonItem)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tarefasextrasXtraForm_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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
            tarefasextrasSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub voltarSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles voltarSimpleButton.Click
        Try
            RetornaGridFocu()
            LimpaDados()
            tarefasextrasSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
            blnCancela = False
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub obrigacaoGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles obrigacaoGridView.KeyDown
        If e.KeyCode = Keys.F5 Then
            If atualizarBarButtonItem.Enabled Then
                CarregaGrid()
            End If
        End If
    End Sub

    Private Sub tarefasextrasAdvBandedGridView_DoubleClick(sender As Object, e As System.EventArgs) Handles tarefasextrasAdvBandedGridView.DoubleClick
        Try
            If alterarBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always Then
                okSimpleButton.Tag = "alteracao"
                CarregaDados(tarefasextrasAdvBandedGridView)
                empresaSearchLookUpEdit.Properties.Mask.MaskType = MaskType.Simple
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tarefasextrasAdvBandedGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles tarefasextrasAdvBandedGridView.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If alterarBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always Then
                    okSimpleButton.Tag = "alteracao"
                    CarregaDados(tarefasextrasAdvBandedGridView)
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

    Private Sub tarefasextrasAdvBandedGridView_GroupRowExpanded(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowEventArgs) Handles tarefasextrasAdvBandedGridView.GroupRowExpanded
        intLinhaGroup = e.RowHandle
    End Sub

    Private Sub tarefasextrasAdvBandedGridView_GroupRowExpanding(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowAllowEventArgs) Handles tarefasextrasAdvBandedGridView.GroupRowExpanding
        intLinhaGroup = e.RowHandle
    End Sub

    Private Sub incluirBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles incluirBarButtonItem.ItemClick
        Try
            okSimpleButton.Tag = "inclusao"
            HabilitaBotoes(okSimpleButton.Tag.ToString)
            tarefasextrasSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
            competenciaTextEdit.EditValue = RetornaCompetencia()
            BrowseFuncionario(String.Empty, competenciaTextEdit.EditValue.ToString, String.Empty)
            BrowseEmpresa(competenciaTextEdit.EditValue.ToString)
            empresaSearchLookUpEdit.Focus()
            empresaSearchLookUpEdit.Properties.Mask.MaskType = MaskType.Simple
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub alterarBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles alterarBarButtonItem.ItemClick
        Try
            okSimpleButton.Tag = "alteracao"
            CarregaDados(tarefasextrasAdvBandedGridView)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub excluirBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles excluirBarButtonItem.ItemClick
        Try
            okSimpleButton.Tag = "exclusao"
            CarregaDados(tarefasextrasAdvBandedGridView)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub localizarBarCheckItem_CheckedChanged(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles localizarBarCheckItem.CheckedChanged
        Try
            tarefasextrasAdvBandedGridView.OptionsFind.AlwaysVisible = localizarBarCheckItem.Checked
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

    Private Sub empresaSearchLookUpEdit_CustomDisplayText(sender As Object, e As DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs) Handles empresaSearchLookUpEdit.CustomDisplayText
        Try
            Dim editor As SearchLookUpEdit = TryCast(sender, SearchLookUpEdit)
             If editor.EditValue IsNot Nothing Then
                Dim index As Integer = editor.Properties.GetIndexByKeyValue(editor.EditValue)
                If index >= 0 Then
                    razaosocialTextEdit.Text = objComum.RetornaDescricao(empresasInfoBindingSource, index, "razaosocial")
                    strEstado = objComum.RetornaDescricao(empresasInfoBindingSource, index, "estado")
                    strMunicipio = objComum.RetornaDescricao(empresasInfoBindingSource, index, "municipio")
                Else
                    razaosocialTextEdit.Text = String.Empty
                    strEstado = String.Empty
                    strMunicipio = String.Empty
                End If
            Else
                razaosocialTextEdit.Text = String.Empty
                strEstado = String.Empty
                strMunicipio = String.Empty
            End If
            If editor.IsModified Then
                BrowseFuncionario(Convert.ToString(empresaSearchLookUpEdit.EditValue), competenciaTextEdit.EditValue.ToString, Convert.ToString(infoobrigacoes.sistema))
            End If


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub empresaSearchLookUpEdit_Validated(sender As Object, e As System.EventArgs) Handles empresaSearchLookUpEdit.Validated

        If Not empresaSearchLookUpEdit.EditValue Is Nothing Then
            If empresaSearchLookUpEdit.IsModified Then
                BrowseFuncionario(Convert.ToString(empresaSearchLookUpEdit.EditValue), Convert.ToString(competenciaTextEdit.EditValue), Convert.ToString(infoobrigacoes.sistema))
                If Not obrigacaoSearchLookUpEdit.EditValue Is Nothing Then
                    If obrigacaoSearchLookUpEdit.EditValue.ToString <> String.Empty Then
                        objTarefasExtras.BuscaVencimento(strEstado, strMunicipio, datavencimentoDateEdit, competenciaTextEdit.EditValue.ToString,
                                                         infoobrigacoes.variacao(0).periodicidade, infoobrigacoes.variacao(0).vencimento, infoobrigacoes.variacao(0).tipodia,
                                                         infoobrigacoes.variacao(0).sabdomutil, infoobrigacoes.variacao(0).antecipautil, infoobrigacoes.variacao(0).subsequente,
                                                         infoobrigacoes.variacao(0).tiposubsequente)
                    End If
                End If
            End If
        Else
            BrowseFuncionario(Convert.ToString(empresaSearchLookUpEdit.EditValue), Convert.ToString(competenciaTextEdit.EditValue), Convert.ToString(infoobrigacoes.sistema))
        End If
    End Sub

    Private Sub competenciaTextEdit_Validated(sender As System.Object, e As System.EventArgs) Handles competenciaTextEdit.Validated
        If competenciaTextEdit.EditValue.ToString <> String.Empty Then
            If competenciaTextEdit.IsModified Then
                BrowseFuncionario(Convert.ToString(empresaSearchLookUpEdit.EditValue), Convert.ToString(competenciaTextEdit.EditValue), Convert.ToString(infoobrigacoes.sistema))
                BrowseEmpresa(Convert.ToString(competenciaTextEdit.EditValue))
                If Not obrigacaoSearchLookUpEdit.EditValue Is Nothing Then
                    If obrigacaoSearchLookUpEdit.EditValue.ToString <> String.Empty Then
                        objTarefasExtras.BuscaVencimento(strEstado, strMunicipio, datavencimentoDateEdit, competenciaTextEdit.EditValue.ToString,
                                                         infoobrigacoes.variacao(0).periodicidade, infoobrigacoes.variacao(0).vencimento, infoobrigacoes.variacao(0).tipodia,
                                                         infoobrigacoes.variacao(0).sabdomutil, infoobrigacoes.variacao(0).antecipautil, infoobrigacoes.variacao(0).subsequente,
                                                         infoobrigacoes.variacao(0).tiposubsequente)
                    End If
                End If
            End If
        Else
            BrowseFuncionario(Convert.ToString(empresaSearchLookUpEdit.EditValue), Convert.ToString(competenciaTextEdit.EditValue), Convert.ToString(infoobrigacoes.sistema))
            BrowseEmpresa(Convert.ToString(competenciaTextEdit.EditValue))
        End If
    End Sub

    Private Sub obrigacaoSearchLookUpEdit_CustomDisplayText(sender As Object, e As DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs) Handles obrigacaoSearchLookUpEdit.CustomDisplayText
        Try
            Dim editor As SearchLookUpEdit = TryCast(sender, SearchLookUpEdit)

            infoobrigacoes = New obrigacoesInfo
            infovariacao = New List(Of obrigacoesvariacao)
            If editor.EditValue IsNot Nothing Then
                Dim index As Integer = editor.Properties.GetIndexByKeyValue(editor.EditValue)
                If index >= 0 Then
                    descricaoTextEdit.Text = objComum.RetornaDescricao(obrigacoesInfoBindingSource, index, "descricao")
                    infoobrigacoes.sistema = objComum.RetornaDescricao(obrigacoesInfoBindingSource, index, "sistema")
                    Dim intVencimento = Convert.ToInt32(objComum.RetornaDescricao(obrigacoesInfoBindingSource, index, "vencimento"))
                    If objComum.RetornaDescricao(obrigacoesInfoBindingSource, index, "periodicidade") = "I" And intVencimento = 0 Then
                        intVencimento = Now.Day
                    End If
                    Dim variacaoinfo As New obrigacoesvariacao(String.Empty, String.Empty,
                                                               objComum.RetornaDescricao(obrigacoesInfoBindingSource, index, "periodicidade"),
                                                               objComum.RetornaDescricao(obrigacoesInfoBindingSource, index, "tipodia"), intVencimento,
                                                               String.Empty, String.Empty, Convert.ToInt32(objComum.RetornaDescricao(obrigacoesInfoBindingSource, index, "subsequente")),
                                                               objComum.RetornaDescricao(obrigacoesInfoBindingSource, index, "tiposubsequente"),
                                                               Convert.ToInt32(objComum.RetornaDescricao(obrigacoesInfoBindingSource, index, "sabdomutil")),
                                                               Convert.ToInt32(objComum.RetornaDescricao(obrigacoesInfoBindingSource, index, "antecipautil")))

                    infovariacao.Add(variacaoinfo)
                    infoobrigacoes.variacao = infovariacao
                    If editor.IsModified Then
                        objTarefasExtras.BuscaVencimento(strEstado, strMunicipio, datavencimentoDateEdit, competenciaTextEdit.EditValue.ToString, infoobrigacoes.variacao(0).periodicidade,
                                                         infoobrigacoes.variacao(0).vencimento, infoobrigacoes.variacao(0).tipodia, infoobrigacoes.variacao(0).sabdomutil, infoobrigacoes.variacao(0).antecipautil,
                                                         infoobrigacoes.variacao(0).subsequente, infoobrigacoes.variacao(0).tiposubsequente)
                    End If
                    BrowseFuncionario(Convert.ToString(empresaSearchLookUpEdit.EditValue), competenciaTextEdit.EditValue.ToString, Convert.ToString(infoobrigacoes.sistema))
                Else
                    descricaoTextEdit.Text = String.Empty
                    infoobrigacoes = New obrigacoesInfo
                    infovariacao = New List(Of obrigacoesvariacao)
                End If
            Else
                descricaoTextEdit.Text = String.Empty
                infoobrigacoes = New obrigacoesInfo
                infovariacao = New List(Of obrigacoesvariacao)
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

    Private Sub BrowseFuncionario(ByRef pstrEmpresa As String, ByRef pstrCompetencia As String, ByRef pstrSistema As String)
        funcionarioSearchLookUpEdit.Visible = (pstrSistema = "FOL" And Not String.IsNullOrEmpty(pstrEmpresa))
        nomeTextEdit.Visible = (pstrSistema = "FOL" And Not String.IsNullOrEmpty(pstrEmpresa))
        funcionarioLabelControl.Visible = (pstrSistema = "FOL" And Not String.IsNullOrEmpty(pstrEmpresa))
        Dim intTopCaption As Int32 = 0
        Dim intTopValue As Int32 = 0
        Dim intHeightValue As Int32 = 0

        If pstrSistema = "FOL" And Not String.IsNullOrEmpty(pstrEmpresa) Then
            objComum.Browse("select f.funcionario, f.nome " +
                              "from funcionarios f " +
                              "join funcionarioscompetencias fc on fc.funcionario = f.funcionario and fc.empresa = f.empresa and fc.competencia = '" + pstrCompetencia + "' " +
                             "where f.empresa = '" + pstrEmpresa + "' order by 1", funcionariosInfoBindingSource)
            intTopCaption = 140
            intHeightValue = 188
            intTopValue = 159
        Else
            funcionariosInfoBindingSource.DataSource = Nothing
            funcionarioSearchLookUpEdit.EditValue = String.Empty
            nomeTextEdit.Text = String.Empty
            intTopCaption = 93
            intHeightValue = 235
            intTopValue = 111
        End If
        observacaoLabelControl.Location = New Point(observacaoLabelControl.Location.X, intTopCaption)
        observacaoTextEdit.Height = intHeightValue
        observacaoTextEdit.Location = New Point(observacaoTextEdit.Location.X, intTopValue)
    End Sub

    Private Sub CarregaGrid()
        Try
            Dim strJoinUsuario As String = String.Empty
            Dim strWhere As String = objFiltro.RetornaWhereFiltro("aca")
            If usuarioInfo.obrigacoes Then
                strJoinUsuario = "join admobrigacoesusuarios aou on aou.obrigacao = a.obrigacao and aou.usuario = '" + usuarioInfo.usuario + "' "
            End If
            SplashScreenManager.ShowForm(Me, GetType(aguardeWaitForm), True, True, False)
            objTarefasExtras.Grid("select gd_formatsql(aca.empresa, '00.0000') <concat> ' - ' <concat> e.razaosocial as dadosempresa, aca.competencia, " +
                                         "aca.obrigacao, a.descricao, aca.datavencimento, aca.empresa, aca.observacao, aca.funcionario, aca.sequenciaextra " +
                                    "from admcontroleadministrativo aca " +
                                    "join empresas e on e.empresa = aca.empresa and e.exercicio = aca.exercicio " +
                                    "join admobrigacoes a on a.obrigacao = aca.obrigacao " + strJoinUsuario +
                                   "where " + strWhere + " " +
                                     "and aca.obrigacaoextra = -1 " +
                                     "and aca.parcela = 0 " +
                                "order by aca.empresa, aca.obrigacao", "dadosempresa", "Empresa", "Tarefas Extras das Empresas", 2,
                                 tarefasextrasGridControl, tarefasextrasAdvBandedGridView)
            CarregaOpcao()
            SplashScreenManager.CloseForm()
        Catch ex As Exception
            SplashScreenManager.CloseForm()
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CarregaDados(pbgvGrid As AdvBandedGridView)
        Dim intLinha As Integer() = pbgvGrid.GetSelectedRows()
        For i As Integer = 0 To intLinha.Length - 1
            If intLinha(i) >= 0 Then
                intLinhaRegistro = intLinha(i)
                competenciaTextEdit.EditValue = pbgvGrid.GetRowCellValue(intLinha(i), "competencia").ToString()
                BrowseEmpresa(competenciaTextEdit.EditValue.ToString)
                empresaSearchLookUpEdit.EditValue = tarefasextrasAdvBandedGridView.GetRowCellValue(intLinha(i), "empresa").ToString()
                obrigacaoSearchLookUpEdit.EditValue = tarefasextrasAdvBandedGridView.GetRowCellValue(intLinha(i), "obrigacao").ToString()
                intSequenciaExtra = Convert.ToInt32(pbgvGrid.GetRowCellValue(intLinha(i), "sequenciaextra"))

                Dim infoTarefasExtras As tarefasextrasInfo =
                    objTarefasExtras.BuscaDados(empresaSearchLookUpEdit.EditValue.ToString, competenciaTextEdit.EditValue.ToString,
                                                Convert.ToInt32(competenciaTextEdit.EditValue.ToString.Substring(2, 4)), obrigacaoSearchLookUpEdit.EditValue.ToString, intSequenciaExtra)

                datavencimentoDateEdit.EditValue = infoTarefasExtras.datavencimento
                observacaoTextEdit.EditValue = infoTarefasExtras.observacao.ToString
                BrowseFuncionario(Convert.ToString(empresaSearchLookUpEdit.EditValue), competenciaTextEdit.EditValue.ToString, Convert.ToString(infoobrigacoes.sistema))
                funcionarioSearchLookUpEdit.EditValue = infoTarefasExtras.funcionario.ToString

                HabilitaBotoes(okSimpleButton.Tag.ToString)
                tarefasextrasSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
                empresaSearchLookUpEdit.Focus()
            End If
        Next
    End Sub

    Private Sub CarregaOpcao()
        Dim infoGrupoAcesso As New usuariogruposacessoInfo
        Dim objUsuario As New UsuarioBLL
        infoGrupoAcesso = objUsuario.RetornaGrupoAcessoUsuario("movtar")
        If tarefasextrasRibbonControl.Items.Count > 0 Then
            For index = 0 To tarefasextrasRibbonControl.Items.Count - 1
                If tarefasextrasRibbonControl.Items(index).Tag IsNot Nothing Then
                    If objUsuario.UsuarioTemAcesso(infoGrupoAcesso, tarefasextrasRibbonControl.Items(index).Tag.ToString) Then
                        tarefasextrasRibbonControl.Items(index).Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    Else
                        tarefasextrasRibbonControl.Items(index).Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub HabilitaBotoes(pstrOperacao As String)
        incluirBarButtonItem.Enabled = (pstrOperacao = String.Empty)
        localizarBarCheckItem.Enabled = (pstrOperacao = String.Empty)
        atualizarBarButtonItem.Enabled = (pstrOperacao = String.Empty)
        filtroBarButtonItem.Enabled = (pstrOperacao = String.Empty)
        alterarBarButtonItem.Enabled = (pstrOperacao = String.Empty And tarefasextrasAdvBandedGridView.RowCount > 0)
        excluirBarButtonItem.Enabled = (pstrOperacao = String.Empty And tarefasextrasAdvBandedGridView.RowCount > 0)
        If okSimpleButton.Tag.ToString = "exclusao" Then
            okSimpleButton.Text = "Excluir"
            okSimpleButton.ImageIndex = 1
            intLinhaRegistro = 0
        Else
            okSimpleButton.Text = "OK"
            okSimpleButton.ImageIndex = 0
        End If
        empresaSearchLookUpEdit.Enabled = (okSimpleButton.Tag.ToString = "inclusao")
        obrigacaoSearchLookUpEdit.Enabled = (okSimpleButton.Tag.ToString = "inclusao")
        competenciaTextEdit.Enabled = (okSimpleButton.Tag.ToString = "inclusao")
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
        funcionarioSearchLookUpEdit.EditValue = String.Empty
        nomeTextEdit.Text = String.Empty
        datavencimentoDateEdit.EditValue = Nothing
        observacaoTextEdit.Text = String.Empty
        okSimpleButton.Tag = String.Empty
        intSequenciaExtra = 0
        Me.AcceptButton = Nothing
        intLinhaRegistro = 0
        HabilitaBotoes(okSimpleButton.Tag.ToString)
    End Sub

    Private Sub SetModelo(pstrOperacao As String)
        Try
            Dim tarefasextras As New tarefasextrasInfo
            If pstrOperacao = "inclusao" Then
                tarefasextras.sequenciaextra = objTarefasExtras.ProximaTarefa(empresaSearchLookUpEdit.EditValue.ToString, obrigacaoSearchLookUpEdit.EditValue.ToString)
            Else
                tarefasextras.sequenciaextra = intSequenciaExtra
            End If
            tarefasextras.empresa = empresaSearchLookUpEdit.Text.Replace(".", "")
            tarefasextras.obrigacao = obrigacaoSearchLookUpEdit.Text.Replace("-","")
            tarefasextras.competencia = competenciaTextEdit.EditValue.ToString
            If Not datavencimentoDateEdit.EditValue Is Nothing Then
                tarefasextras.datavencimento = Convert.ToDateTime(datavencimentoDateEdit.EditValue)
            End If
            tarefasextras.funcionario = funcionarioSearchLookUpEdit.Text
            tarefasextras.usuarioobrigacaoextra = usuarioInfo.usuario
            tarefasextras.datahoraobrigacaoextra = Now
            tarefasextras.observacao = String.Empty
            If Not observacaoTextEdit.EditValue Is Nothing Then
                tarefasextras.observacao = observacaoTextEdit.EditValue.ToString
            End If
            SplashScreenManager.ShowForm(Me, GetType(aguardeWaitForm), True, True, False)
            objTarefasExtras.IUDTarefasExtras(pstrOperacao, tarefasextras)
            SplashScreenManager.CloseForm()
            RetornaGridFocu()
            LimpaDados()
        Catch ex As Exception
            SplashScreenManager.CloseForm()
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub RetornaGridFocu()
        CarregaGrid()
        tarefasextrasAdvBandedGridView.SetRowExpanded(intLinhaGroup, True)
        If intLinhaRegistro >= 0 And okSimpleButton.Tag.ToString <> "exclusao" Then
            tarefasextrasAdvBandedGridView.FocusedRowHandle = intLinhaRegistro
        Else
            tarefasextrasAdvBandedGridView.FocusedRowHandle = intLinhaGroup
        End If
    End Sub

    Private Sub BrowseEmpresa(ByRef pstrCompetencia As String)
        Dim intExercicio As Int32 = 0
        If pstrCompetencia.Length > 0 Then
            intExercicio = Convert.ToInt32(pstrCompetencia.Substring(2, 4))
        End If
        objComum.Browse("select empresa, razaosocial, estado, municipio " +
                          "from empresas " +
                         "where exercicio = " + intExercicio.ToString + " order by empresa", empresasInfoBindingSource)
    End Sub

    Private Function RetornaCompetencia() As String
        Try
            Dim strCompetencia As String = String.Empty
            strCompetencia = Now.Month.ToString
            If strCompetencia.Length = 1 Then
                strCompetencia = "0" + strCompetencia
            End If
            strCompetencia = strCompetencia + Now.Year.ToString
            Return strCompetencia
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class