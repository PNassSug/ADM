Imports Administrativo.Modelo
Imports Administrativo.BLL
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors.Mask

Public Class parcelamentoXtraForm
    Dim objParcelamento As New ParcelamentoBLL
    Dim objComum As New ComumBLL
    Dim blnCancela As Boolean = False
    Dim intLinhaRegistro As Int32 = 0

    Dim infoparcelamento As parcelamentoInfo
    Dim infodetalhes As List(Of parcelamentodetalhes)
    Dim originalinfoDetalhes As List(Of parcelamentodetalhes)

    Dim infoobrigacoes As New obrigacoesInfo
    Dim infovariacao As List(Of obrigacoesvariacao)
    Dim strEstado As String = String.Empty
    Dim strMunicipio As String = String.Empty
    Dim intSequenciaExtra As Int32 = 0

    Private intLinhaGroupMaster As Int32 = 0
    Private listGridLinhaFocu As New List(Of GridLinhaFocu)()

    Public Sub New()
        InitializeComponent()
        objComum.Browse("select emp.empresa, emp.razaosocial, emp.estado, emp.municipio " +
                          "from (select aoe.empresa, max(aoe.exercicio) as exercicio from admobrigacoesempresas aoe group by aoe.empresa) aoe " +
                          "join empresas emp on emp.empresa = aoe.empresa and emp.exercicio = aoe.exercicio " +
                      "order by emp.empresa", empresasInfoBindingSource)
        parcelamentoSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
    End Sub

    Private Sub parcelamentoXtraForm_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If blnCancela Then
            e.Cancel = True
            Call voltarSimpleButton_Click(sender, e)
            blnCancela = False
        End If
    End Sub

    Private Sub parcelamentoXtraForm_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
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

    Private Sub parcelamentoXtraForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Try
            CarregaGrid()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub okSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles okSimpleButton.Click
        Try
            SetModelo(okSimpleButton.Tag.ToString)
            parcelamentoSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub voltarSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles voltarSimpleButton.Click
        Try
            RetornaGridFocu()
            LimpaDados()
            parcelamentoSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
            blnCancela = False
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub empresaSearchLookUpEdit_CustomDisplayText(sender As System.Object, e As DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs) Handles empresaSearchLookUpEdit.CustomDisplayText
        Try
            Dim editor As SearchLookUpEdit = TryCast(sender, SearchLookUpEdit)

            obrigacaoSearchLookUpEdit.Enabled = editor.EditValue IsNot Nothing And (okSimpleButton.Tag.ToString = "inclusao")
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
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub empresaSearchLookUpEdit_Validated(sender As Object, e As System.EventArgs) Handles empresaSearchLookUpEdit.Validated
        If Not empresaSearchLookUpEdit.EditValue Is Nothing Then
            If empresaSearchLookUpEdit.IsModified Then
                BrowseObrigacoes()
            End If
        Else
            obrigacaoSearchLookUpEdit.EditValue = String.Empty
        End If
    End Sub

    Private Sub obrigacaoSearchLookUpEdit_CustomDisplayText(sender As System.Object, e As DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs) Handles obrigacaoSearchLookUpEdit.CustomDisplayText
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
                        CriaParcelamento()
                    End If
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

    Private Sub competenciainicialTextEdit_Validated(sender As Object, e As System.EventArgs) Handles competenciainicialTextEdit.Validated
        Try
            CriaParcelamento()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub competenciafinalTextEdit_Validated(sender As Object, e As System.EventArgs) Handles competenciafinalTextEdit.Validated
        Try
            CriaParcelamento()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub parcelamentosGridView_MasterRowCollapsing(sender As Object, e As DevExpress.XtraGrid.Views.Grid.MasterRowCanExpandEventArgs) Handles parcelamentosGridView.MasterRowCollapsing
        intLinhaGroupMaster = -1
    End Sub

    Private Sub parcelamentosGridView_MasterRowExpanding(sender As Object, e As DevExpress.XtraGrid.Views.Grid.MasterRowCanExpandEventArgs) Handles parcelamentosGridView.MasterRowExpanding
        If intLinhaGroupMaster >= 0 Then
            parcelamentosGridView.SetMasterRowExpanded(intLinhaGroupMaster, False)
        End If
        intLinhaGroupMaster = e.RowHandle
    End Sub

    Private Sub parcelamentoobrigacoesGridView_DoubleClick(sender As Object, e As System.EventArgs) Handles parcelamentoobrigacoesGridView.DoubleClick
        Try
            If alterarBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always Then
                okSimpleButton.Tag = "alteracao"
                CarregaDados(parcelamentoobrigacoesGridView)
                empresaSearchLookUpEdit.Properties.Mask.MaskType = MaskType.Simple
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub parcelamentoobrigacoesGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles parcelamentoobrigacoesGridView.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If alterarBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always Then
                    okSimpleButton.Tag = "alteracao"
                    CarregaDados(parcelamentoobrigacoesGridView)
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
            parcelamentoSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
            empresaSearchLookUpEdit.Focus()
            empresaSearchLookUpEdit.Properties.Mask.MaskType = MaskType.Simple
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub alterarBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles alterarBarButtonItem.ItemClick
        Try
            okSimpleButton.Tag = "alteracao"
            CarregaDados(parcelamentoobrigacoesGridView)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub excluirBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles excluirBarButtonItem.ItemClick
        Try
            okSimpleButton.Tag = "exclusao"
            CarregaDados(parcelamentoobrigacoesGridView)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub localizarBarCheckItem_CheckedChanged(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles localizarBarCheckItem.CheckedChanged
        Try
            parcelamentosGridView.OptionsFind.AlwaysVisible = localizarBarCheckItem.Checked
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

    Private Sub CarregaGrid()
        Try
            SplashScreenManager.ShowForm(Me, GetType(aguardeWaitForm), True, True, False)
            Dim strJoinUsuario As String = String.Empty
            If usuarioInfo.obrigacoes Then
                strJoinUsuario = "join admobrigacoesusuarios aou on aou.obrigacao = aca.obrigacao and aou.usuario = '" + usuarioInfo.usuario + "' "
            End If

            infoparcelamento = New parcelamentoInfo
            Dim strQuery() As String = {"", "", ""}
            Dim strTitulo() As String = {"Empresas", "Obrigações", "Parcelamentos"}

            strQuery(0) = "select aca.empresa, max(emp.razaosocial) as razaosocial " +
                           "from admcontroleadministrativo aca " +
                           "join empresas emp on emp.empresa = aca.empresa " +
                           strJoinUsuario +
                          "where coalesce(aca.obrigacaoextra,0) = -1 and coalesce(aca.sequenciaextra,0) > 0 and coalesce(aca.parcela,0) > 0 " +
                       "group by aca.empresa " +
                       "order by 1"

            strQuery(1) = "select aca.empresa, aca.obrigacao, max(ao.descricao) as descricao, aca.sequenciaextra, desinvertecompetencia(min(invertecompetencia(competencia))) as periodoinicial, desinvertecompetencia(max(invertecompetencia(competencia))) as periodofinal, count(*) as qtdparcelas " +
                            "from admcontroleadministrativo aca " +
                            "join admobrigacoes ao on ao.obrigacao = aca.obrigacao " +
                            strJoinUsuario +
                           "where coalesce(aca.obrigacaoextra,0) = -1 and coalesce(aca.sequenciaextra,0) > 0 and coalesce(aca.parcela,0) > 0 " +
                        "group by aca.empresa, aca.obrigacao, aca.sequenciaextra " +
                        "order by 1, 2, 4 "

            strQuery(2) = "select aca.empresa, aca.obrigacao, aca.sequenciaextra, aca.parcela, aca.competencia, aca.datavencimento, " +
                                 "case when coalesce(aca.usuariogeracao,'') = '' and coalesce(aca.vistoentrega,0) = 0 and coalesce(aca.vistoencarregado,0) = 0 then 0 " +
                                      "else case when coalesce(aca.usuariogeracao,'') <> '' and coalesce(aca.vistoentrega,0) <> 0 and coalesce(aca.vistoencarregado,0) <> 0 then 2 else 1 end end as status " +
                            "from admcontroleadministrativo aca " +
                            strJoinUsuario +
                           "where coalesce(aca.obrigacaoextra,0) = -1 and coalesce(aca.sequenciaextra,0) > 0 and coalesce(aca.parcela,0) > 0 " +
                        "order by 1, 2, 3, 4 "

            objParcelamento.Grid(strQuery, strTitulo, parcelamentosGridControl, parcelamentosGridView, parcelamentoobrigacoesGridView, parcelamentodetalhesGridView, statusImageCollection)
            CarregaOpcao()
            SplashScreenManager.CloseForm()
        Catch ex As Exception
            SplashScreenManager.CloseForm()
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CarregaDados(pgvGrid As GridView)
        Dim detailView As GridView = TryCast(parcelamentosGridControl.FocusedView, GridView)
        Dim intLinha As Integer() = detailView.GetSelectedRows()

        If detailView.Name.ToLower <> "parcelamentoobrigacoesgridview" Then
            Exit Sub
        End If
        intLinhaGroupMaster = (CType(parcelamentosGridControl.MainView, ColumnView)).FocusedRowHandle

        If parcelamentosGridView.GetMasterRowExpanded(intLinhaGroupMaster) Then
            For i As Integer = 0 To intLinha.Length - 1
                If intLinha(i) >= 0 Then
                    intLinhaRegistro = intLinha(i)

                    empresaSearchLookUpEdit.EditValue = detailView.GetRowCellValue(intLinha(i), detailView.Columns("empresa")).ToString()
                    BrowseObrigacoes()
                    obrigacaoSearchLookUpEdit.EditValue = detailView.GetRowCellValue(intLinha(i), detailView.Columns("obrigacao")).ToString()
                    competenciainicialTextEdit.EditValue = detailView.GetRowCellValue(intLinha(i), detailView.Columns("periodoinicial")).ToString()
                    competenciafinalTextEdit.EditValue = detailView.GetRowCellValue(intLinha(i), detailView.Columns("periodofinal")).ToString()
                    intSequenciaExtra = Convert.ToInt32(detailView.GetRowCellValue(intLinha(i), detailView.Columns("sequenciaextra")))
                    HabilitaBotoes(okSimpleButton.Tag.ToString)
                    parcelamentoSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
                    empresaSearchLookUpEdit.Focus()
                End If
            Next
        End If
    End Sub

    Private Sub CarregaOpcao()
        Dim infoGrupoAcesso As New usuariogruposacessoInfo
        Dim objUsuario As New UsuarioBLL
        infoGrupoAcesso = objUsuario.RetornaGrupoAcessoUsuario("movpar")

        If parcelamentoRibbonControl.Items.Count > 0 Then
            For index = 0 To parcelamentoRibbonControl.Items.Count - 1
                If parcelamentoRibbonControl.Items(index).Tag IsNot Nothing Then
                    If objUsuario.UsuarioTemAcesso(infoGrupoAcesso, parcelamentoRibbonControl.Items(index).Tag.ToString) Then
                        parcelamentoRibbonControl.Items(index).Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    Else
                        parcelamentoRibbonControl.Items(index).Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub HabilitaBotoes(pstrOperacao As String)
        incluirBarButtonItem.Enabled = (pstrOperacao = String.Empty)
        localizarBarCheckItem.Enabled = (pstrOperacao = String.Empty)
        atualizarBarButtonItem.Enabled = (pstrOperacao = String.Empty)
        alterarBarButtonItem.Enabled = (pstrOperacao = String.Empty And parcelamentosGridView.RowCount > 0)
        excluirBarButtonItem.Enabled = (pstrOperacao = String.Empty And parcelamentosGridView.RowCount > 0)
        If okSimpleButton.Tag.ToString = "exclusao" Then
            okSimpleButton.Text = "Excluir"
            okSimpleButton.ImageIndex = 1
            intLinhaRegistro = 0
        Else
            okSimpleButton.Text = "OK"
            okSimpleButton.ImageIndex = 0
        End If
        If Not String.IsNullOrEmpty(pstrOperacao) Then
            infoparcelamento = New parcelamentoInfo
            If okSimpleButton.Tag.ToString <> "inclusao" Then
                infoparcelamento.empresa = empresaSearchLookUpEdit.EditValue.ToString
                infoparcelamento.obrigacao = obrigacaoSearchLookUpEdit.EditValue.ToString
                infoparcelamento.sequenciaextra = intSequenciaExtra
            End If
            empresaSearchLookUpEdit.Enabled = (okSimpleButton.Tag.ToString = "inclusao")
            competenciainicialTextEdit.Enabled = True
            competenciafinalTextEdit.Enabled = True
            okSimpleButton.Enabled = True

            Dim strQuery As String = "select aca.empresa, aca.obrigacao, aca.sequenciaextra, aca.parcela, aca.competencia, aca.datavencimento, " +
                                            "case when coalesce(aca.usuariogeracao,'') = '' and coalesce(aca.vistoentrega,0) = 0 and coalesce(aca.vistoencarregado,0) = 0 then 0 " +
                                                 "else case when coalesce(aca.usuariogeracao,'') <> '' and coalesce(aca.vistoentrega,0) <> 0 and coalesce(aca.vistoencarregado,0) <> 0 then 2 else 1 end end as status " +
                                       "from admcontroleadministrativo aca " +
                                      "where aca.empresa = '" + infoparcelamento.empresa + "' " +
                                        "and aca.obrigacao = '" + infoparcelamento.obrigacao + "' " +
                                        "and coalesce(aca.obrigacaoextra,0) = -1 " +
                                        "and coalesce(aca.sequenciaextra,0) = " + intSequenciaExtra.ToString + " " +
                                        "and coalesce(aca.parcela,0) > 0 " +
                                   "order by 1, 2, 3, 4"
            infodetalhes = New List(Of parcelamentodetalhes)
            objParcelamento.Grid(strQuery, detalhesGridControl, detalhesGridView, infodetalhes, statusImageCollection)
            infoparcelamento.detalhes = infodetalhes
            originalinfoDetalhes = New List(Of parcelamentodetalhes)
            For index = 0 To infodetalhes.Count - 1
                Dim detalhesinfo As New parcelamentodetalhes(infodetalhes(index).parcela, infodetalhes(index).competencia.ToString, infodetalhes(index).datavencimento, infodetalhes(index).status)
                originalinfoDetalhes.Add(detalhesinfo)
                If competenciainicialTextEdit.Enabled Then
                    competenciainicialTextEdit.Enabled = (infodetalhes(index).status = 0)
                End If
            Next
        End If
        If okSimpleButton.Tag.ToString <> String.Empty Then
            Me.AcceptButton = okSimpleButton
        End If
    End Sub

    Private Sub LimpaDados()
        infoparcelamento = Nothing
        empresaSearchLookUpEdit.EditValue = String.Empty
        razaosocialTextEdit.Text = String.Empty
        obrigacaoSearchLookUpEdit.EditValue = String.Empty
        descricaoTextEdit.Text = String.Empty
        competenciainicialTextEdit.Text = String.Empty
        competenciafinalTextEdit.Text = String.Empty
        intSequenciaExtra = 0
        detalhesGridControl.DataSource = Nothing
        infodetalhes = Nothing
        originalinfoDetalhes = Nothing

        okSimpleButton.Tag = String.Empty
        Me.AcceptButton = Nothing
        intLinhaRegistro = 0
        HabilitaBotoes(okSimpleButton.Tag.ToString)
    End Sub

    Private Sub SetModelo(pstrOperacao As String)
        Try
            SplashScreenManager.ShowForm(Me, GetType(aguardeWaitForm), True, True, False)
            If Not empresaSearchLookUpEdit.EditValue Is Nothing Then
                infoparcelamento.empresa = empresaSearchLookUpEdit.EditValue.ToString
            End If
            If Not obrigacaoSearchLookUpEdit.EditValue Is Nothing Then
                infoparcelamento.obrigacao = obrigacaoSearchLookUpEdit.EditValue.ToString
            End If
            infoparcelamento.detalhes = infodetalhes
            objParcelamento.IUDParcelamento(pstrOperacao, infoparcelamento, originalinfoDetalhes)
            SplashScreenManager.CloseForm()
            RetornaGridFocu()
            LimpaDados()
        Catch ex As Exception
            SplashScreenManager.CloseForm()
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub SetModelo(pdgGrid As GridControl)
        pdgGrid.DataSource = Nothing
        pdgGrid.DataSource = infodetalhes
        pdgGrid.ForceInitialize()
        infoparcelamento.detalhes = infodetalhes
    End Sub

    Private Sub CriaParcelamento()
        Try
            If empresaSearchLookUpEdit.EditValue Is Nothing Then
                Exit Sub
            End If
            If obrigacaoSearchLookUpEdit.EditValue Is Nothing Then
                Exit Sub
            End If
            If competenciafinalTextEdit.EditValue Is Nothing Or competenciafinalTextEdit.EditValue Is Nothing Then
                Exit Sub
            End If
            If String.IsNullOrEmpty(competenciafinalTextEdit.EditValue.ToString) Or String.IsNullOrEmpty(competenciafinalTextEdit.EditValue.ToString) Then
                Exit Sub
            End If

            Dim dtaDataInicial As Date = DateTime.Parse("01/" + competenciainicialTextEdit.EditValue.ToString.Substring(0, 2) + "/" + competenciainicialTextEdit.EditValue.ToString.Substring(2, 4))
            Dim dtaDataFinal As Date = DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Month, 1, DateTime.Parse("01/" + competenciafinalTextEdit.EditValue.ToString.Substring(0, 2) + "/" + competenciafinalTextEdit.EditValue.ToString.Substring(2, 4))))
            Dim intQtdMeses As Int64 = DateDiff(DateInterval.Month, dtaDataInicial, dtaDataFinal)
            infodetalhes = New List(Of parcelamentodetalhes)
            SplashScreenManager.ShowForm(Me, GetType(aguardeWaitForm), True, True, False)
            For index = 0 To intQtdMeses
                Dim strCompetencia As String = DateAdd(DateInterval.Month, index, DateTime.Parse("01/" + competenciainicialTextEdit.EditValue.ToString.Substring(0, 2) + "/" + competenciainicialTextEdit.EditValue.ToString.Substring(2, 4))).ToString.Substring(3, 7).Replace("/", String.Empty)
                Dim dtaDataVencimento As Nullable(Of DateTime) = objParcelamento.BuscaVencimento(strEstado, strMunicipio, strCompetencia, infoobrigacoes.variacao(0).periodicidade,
                                                                                                 infoobrigacoes.variacao(0).vencimento, infoobrigacoes.variacao(0).tipodia,
                                                                                                 infoobrigacoes.variacao(0).sabdomutil, infoobrigacoes.variacao(0).antecipautil,
                                                                                                 infoobrigacoes.variacao(0).subsequente, infoobrigacoes.variacao(0).tiposubsequente)

                If dtaDataVencimento.HasValue Then
                    Dim intStatus As Int32 = 0
                    If competenciafinalTextEdit.Enabled And Not competenciainicialTextEdit.Enabled Then
                        If originalinfoDetalhes.Count >= index Then
                            intStatus = originalinfoDetalhes(Convert.ToInt32(index)).status
                        End If
                    End If
                    Dim detalhesinfo As New parcelamentodetalhes(Convert.ToInt32(index) + 1, strCompetencia, dtaDataVencimento, intStatus)
                    infodetalhes.Add(detalhesinfo)
                End If
            Next
            SetModelo(detalhesGridControl)
            SplashScreenManager.CloseForm()
        Catch ex As Exception
            SplashScreenManager.CloseForm()
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub BrowseObrigacoes()
        If usuarioInfo.obrigacoes Then
            objComum.Browse("select ao.obrigacao, ao.descricao, coalesce(ao.sistema,'') as sistema, coalesce(ao.periodicidade,'') as periodicidade, " +
                                   "ao.vencimento, coalesce(ao.tipodia,'F') as tipodia, ao.sabdomutil, ao.antecipautil, ao.subsequente, coalesce(ao.tiposubsequente,'') as tiposubsequente " +
                              "from admobrigacoes ao " +
                              "join (select aoe.obrigacao " +
                                      "from admobrigacoesempresas aoe " +
                                     "where aoe.empresa = '" + empresaSearchLookUpEdit.EditValue.ToString + "' group by aoe.obrigacao) aoe on aoe.obrigacao = ao.obrigacao " +
                              "join admobrigacoesusuarios aou on aou.obrigacao = ao.obrigacao and aou.usuario = '" + usuarioInfo.usuario + "' " +
                             "where coalesce(ao.parcelamento,0) = -1 " +
                          "order by ao.obrigacao", obrigacoesInfoBindingSource)
        Else
            objComum.Browse("select ao.obrigacao, ao.descricao, coalesce(ao.sistema,'') as sistema, coalesce(ao.periodicidade,'') as periodicidade, " +
                                   "ao.vencimento, coalesce(ao.tipodia,'F') as tipodia, ao.sabdomutil, ao.antecipautil, ao.subsequente, coalesce(ao.tiposubsequente,'') as tiposubsequente " +
                              "from admobrigacoes ao " +
                              "join (select aoe.obrigacao " +
                                      "from admobrigacoesempresas aoe " +
                                     "where aoe.empresa = '" + empresaSearchLookUpEdit.EditValue.ToString + "' group by aoe.obrigacao) aoe on aoe.obrigacao = ao.obrigacao " +
                             "where coalesce(ao.parcelamento,0) = -1 " +
                          "order by ao.obrigacao", obrigacoesInfoBindingSource)
        End If
    End Sub

    Private Sub RetornaGridFocu()
        Dim focusedView As GridView = CType(parcelamentosGridControl.FocusedView, GridView)
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
            parcelamentosGridView.FocusedRowHandle = focusedRowHandle
        Else
            parcelamentosGridView.SetMasterRowExpandedEx(listGridLinhaFocu(listGridLinhaFocu.Count - 1).SourceRowHandle, listGridLinhaFocu(listGridLinhaFocu.Count - 1).RelationIndex, True)
            parcelamentosGridView.FocusedRowHandle = listGridLinhaFocu(listGridLinhaFocu.Count - 1).SourceRowHandle
            Dim view As GridView = CType(parcelamentosGridView.GetVisibleDetailView(listGridLinhaFocu(listGridLinhaFocu.Count - 1).SourceRowHandle), GridView)

            For i As Integer = listGridLinhaFocu.Count - 2 To 0 Step -1
                view.SetMasterRowExpandedEx(listGridLinhaFocu(i).SourceRowHandle, listGridLinhaFocu(i).RelationIndex, True)
                view = CType(view.GetVisibleDetailView(listGridLinhaFocu(i).SourceRowHandle), GridView)
            Next i

            If Not SplashScreenManager.ActivateParentOnSplashFormClosing Then
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