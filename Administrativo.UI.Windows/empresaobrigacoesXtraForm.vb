Imports Administrativo.Modelo
Imports Administrativo.BLL
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors.Mask

Public Class empresaobrigacoesXtraForm
    Dim objEmpresaObrigacoes As New EmpresaObrigacoesBLL
    Dim objComum As New ComumBLL
    Dim blnCancela As Boolean = False
    Dim intLinhaRegistro As Int32 = 0
    Dim intLinhaSubRegistro As Int32 = -1
    Dim infoempresasobrigacoes As empresaobrigacoesInfo
    Dim strCnpjCpf As String = String.Empty

    Dim infoobrigacoes As List(Of empresaobrigacoes)
    Dim originalinfoobrigacoes As List(Of empresaobrigacoes)

    Public Sub New()
        InitializeComponent()
        objComum.Browse("select emp.empresa, emp.razaosocial, emp.cnpj from empresas emp where emp.exercicio = " + administrativoInfo.Exercicio.ToString + " order by emp.empresa", empresasInfoBindingSource)
        objComum.Browse("select ao.obrigacao, ao.descricao from admobrigacoes ao order by ao.obrigacao", obrigacoesInfoBindingSource)
        empresaobrigacoesSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
        obrigacoesSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
    End Sub

    Private Sub empresaobrigacoesXtraForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            CarregaGrid()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub empresaobrigacoesXtraForm_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
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

    Private Sub empresaobrigacoesXtraForm_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If blnCancela Then
            e.Cancel = True
            Call voltarSimpleButton_Click(sender, e)
            blnCancela = False
        End If
    End Sub

    Private Sub okSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles okSimpleButton.Click
        Try
            SetModelo(okSimpleButton.Tag.ToString)
            empresaobrigacoesSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub voltarSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles voltarSimpleButton.Click
        Try
            RetornaGridFocu()
            LimpaDados()
            empresaobrigacoesSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
            blnCancela = False
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub empresaobrigacoesGridView_DoubleClick(sender As Object, e As System.EventArgs) Handles empresaobrigacoesGridView.DoubleClick
        Try
            If alterarBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always Then
                okSimpleButton.Tag = "alteracao"
                CarregaDados(empresaobrigacoesGridView)
                empresaSearchLookUpEdit.Properties.Mask.MaskType = MaskType.Simple
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub empresaobrigacoesGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles empresaobrigacoesGridView.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If alterarBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always Then
                    okSimpleButton.Tag = "alteracao"
                    CarregaDados(empresaobrigacoesGridView)
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
                Dim strField() As String = {"obrigacao", "descricao", "competenciaobsoleta"}
                CarregaDados(obrigacoesGridView, strField, obrigacaoSearchLookUpEdit, descricaoTextEdit, competenciaobsoletaTextEdit, obrigacoesSplitContainerControl,
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
            empresaobrigacoesSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
            empresaSearchLookUpEdit.Focus()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub alterarBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles alterarBarButtonItem.ItemClick
        Try
            okSimpleButton.Tag = "alteracao"
            CarregaDados(empresaobrigacoesGridView)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub excluirBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles excluirBarButtonItem.ItemClick
        Try
            okSimpleButton.Tag = "exclusao"
            CarregaDados(empresaobrigacoesGridView)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub localizarBarCheckItem_CheckedChanged(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles localizarBarCheckItem.CheckedChanged
        Try
            empresaobrigacoesGridView.OptionsFind.AlwaysVisible = localizarBarCheckItem.Checked
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
            Dim strField() As String = {"obrigacao", "descricao", "competenciaobsoleta"}
            CarregaDados(obrigacoesGridView, strField, obrigacaoSearchLookUpEdit, descricaoTextEdit, competenciaobsoletaTextEdit, obrigacoesSplitContainerControl,
                         incluirobrigacoesSimpleButton, alterarobrigacoesSimpleButton, excluirobrigacoesSimpleButton, confirmarobrigacoesSimpleButton, voltarobrigacoesSimpleButton)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub excluirobrigacoesSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles excluirobrigacoesSimpleButton.Click
        Try
            confirmarobrigacoesSimpleButton.Tag = "exclusao"
            Dim strField() As String = {"obrigacao", "descricao", "competenciaobsoleta"}
            CarregaDados(obrigacoesGridView, strField, obrigacaoSearchLookUpEdit, descricaoTextEdit, competenciaobsoletaTextEdit, obrigacoesSplitContainerControl,
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

    Private Sub empresaSearchLookUpEdit_CustomDisplayText(sender As System.Object, e As DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs) Handles empresaSearchLookUpEdit.CustomDisplayText
        Dim editor As SearchLookUpEdit = TryCast(sender, SearchLookUpEdit)
        If editor.EditValue IsNot Nothing Then
            Dim index As Integer = editor.Properties.GetIndexByKeyValue(editor.EditValue)
            If index >= 0 Then
                razaosocialTextEdit.Text = objComum.RetornaDescricao(empresasInfoBindingSource, index, "razaosocial")
                strCnpjCpf = objComum.RetornaDescricao(empresasInfoBindingSource, index, "cnpj")
            Else
                razaosocialTextEdit.Text = String.Empty
                strCnpjCpf = String.Empty
            End If
        Else
            razaosocialTextEdit.Text = String.Empty
            strCnpjCpf = String.Empty
        End If
    End Sub

    Private Sub empresaSearchLookUpEdit_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles empresaSearchLookUpEdit.EditValueChanged

        If okSimpleButton.Tag.ToString = "inclusao" Then
            If empresaSearchLookUpEdit.EditValue IsNot Nothing Then
                Dim objDataBase As New DataBaseBLL
                Dim intCount As Int32 = Convert.ToInt32(objDataBase.QuerySimples("select count(*) " +
                                                                                   "from admobrigacoesempresas aoe " +
                                                                                  "where aoe.exercicio = " + administrativoInfo.Exercicio.ToString + " " +
                                                                                    "and aoe.empresa = '" + empresaSearchLookUpEdit.EditValue.ToString + "'"))
                If (intCount > 0) Then
                    XtraMessageBox.Show("Já existe obrigações configuradas para essa empresa", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    empresaSearchLookUpEdit.EditValue = empresaSearchLookUpEdit.OldEditValue
                Else
                    Dim strValueOld As String = String.Empty
                    Dim strValue As String = String.Empty
                    If empresaSearchLookUpEdit.OldEditValue IsNot Nothing Then
                        strValueOld = empresaSearchLookUpEdit.OldEditValue.ToString
                    End If

                    If empresaSearchLookUpEdit.EditValue IsNot Nothing Then
                        strValue = empresaSearchLookUpEdit.EditValue.ToString
                    End If

                    Dim blnSugereObrigacoes As Boolean = String.IsNullOrEmpty(strValueOld) And Not String.IsNullOrEmpty(strValue)
                    If Not blnSugereObrigacoes Then
                        blnSugereObrigacoes = strValue <> strValueOld And Not String.IsNullOrEmpty(strValue)
                    End If
                    Try
                        If blnSugereObrigacoes Then
                            SugereObrigacoes()
                        End If
                    Catch ex As Exception
                        XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub obrigacaoSearchLookUpEdit_CustomDisplayText(sender As System.Object, e As DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs) Handles obrigacaoSearchLookUpEdit.CustomDisplayText
        Dim editor As SearchLookUpEdit = TryCast(sender, SearchLookUpEdit)
        If editor.EditValue IsNot Nothing Then
            Dim index As Integer = editor.Properties.GetIndexByKeyValue(editor.EditValue)
            If index >= 0 Then
                descricaoTextEdit.Text = objComum.RetornaDescricao(obrigacoesInfoBindingSource, index, "descricao")
                confirmarobrigacoesSimpleButton.Focus()
            Else
                descricaoTextEdit.Text = String.Empty
            End If
        Else
            descricaoTextEdit.Text = String.Empty
        End If
    End Sub

    Private Sub CarregaGrid()
        Try
            SplashScreenManager.ShowForm(Me, GetType(aguardeWaitForm), True, True, False)
            infoempresasobrigacoes = New empresaobrigacoesInfo
            Dim strQuery() As String = {"", ""}
            Dim strTitulo() As String = {"Empresas", "Obrigações"}
            strQuery(0) = "select aoe.empresa, max(e.razaosocial) as razaosocial, max(e.cnpj) as cnpjcpf " +
                            "from admobrigacoesempresas aoe " +
                            "join empresas e on e.empresa = aoe.empresa and e.exercicio = aoe.exercicio " +
                           "where aoe.exercicio = " + administrativoInfo.Exercicio.ToString + " " +
                        "group by aoe.empresa " +
                        "order by aoe.empresa"
            strQuery(1) = "select aoe.empresa, aoe.obrigacao, ao.descricao, aoe.competenciaobsoleta " +
                            "from admobrigacoesempresas aoe " +
                            "join admobrigacoes ao on ao.obrigacao = aoe.obrigacao " +
                           "where aoe.exercicio = " + administrativoInfo.Exercicio.ToString + " " +
                        "order by aoe.empresa, aoe.obrigacao"
            objEmpresaObrigacoes.Grid(strQuery, strTitulo, empresaobrigacoesGridControl, empresaobrigacoesGridView, empresaobrigacaoRibbonControl)
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
                strCnpjCpf = pgvGrid.GetRowCellValue(intLinha(i), "cnpjcpf").ToString()
                If okSimpleButton.Tag.ToString = "alteracao" Then
                    competenciaobsoletageralTextEdit.EditValue = String.Empty
                End If
                HabilitaBotoes(okSimpleButton.Tag.ToString)
                empresaobrigacoesSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
                empresaSearchLookUpEdit.Focus()
            End If
        Next
    End Sub

    Private Sub CarregaDados(pgvGrid As GridView, pstrField() As String,
                             pFieldSearchLookUpEdit As SearchLookUpEdit, pFieldTextEdit As TextEdit, pFieldCompetenciaObsoletaTextEdit As TextEdit, pSplitContainerControl As SplitContainerControl,
                             incluirbutton As SimpleButton, alterarbutton As SimpleButton, excluirbutton As SimpleButton,
                             confirmarbutton As SimpleButton, voltarbutton As SimpleButton)
        Dim intLinha As Integer() = pgvGrid.GetSelectedRows()
        For i As Integer = 0 To intLinha.Length - 1
            If intLinha(i) >= 0 Then
                pFieldSearchLookUpEdit.EditValue = pgvGrid.GetRowCellValue(intLinha(i), pstrField(0)).ToString()
                pFieldTextEdit.Text = pgvGrid.GetRowCellValue(intLinha(i), pstrField(1)).ToString()
                pFieldCompetenciaObsoletaTextEdit.EditValue = pgvGrid.GetRowCellValue(intLinha(i), pstrField(2)).ToString()
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
        infoGrupoAcesso = objUsuario.RetornaGrupoAcessoUsuario("cademp")

        If empresaobrigacaoRibbonControl.Items.Count > 0 Then
            For index = 0 To empresaobrigacaoRibbonControl.Items.Count - 1
                If empresaobrigacaoRibbonControl.Items(index).Tag IsNot Nothing Then
                    If objUsuario.UsuarioTemAcesso(infoGrupoAcesso, empresaobrigacaoRibbonControl.Items(index).Tag.ToString) Then
                        empresaobrigacaoRibbonControl.Items(index).Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    Else
                        empresaobrigacaoRibbonControl.Items(index).Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub HabilitaBotoes(pstrOperacao As String)
        incluirBarButtonItem.Enabled = (pstrOperacao = String.Empty)
        localizarBarCheckItem.Enabled = (pstrOperacao = String.Empty)
        atualizarBarButtonItem.Enabled = (pstrOperacao = String.Empty)
        alterarBarButtonItem.Enabled = (pstrOperacao = String.Empty And empresaobrigacoesGridView.RowCount > 0)
        excluirBarButtonItem.Enabled = (pstrOperacao = String.Empty And empresaobrigacoesGridView.RowCount > 0)
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
            infoempresasobrigacoes = New empresaobrigacoesInfo
            If okSimpleButton.Tag.ToString <> "inclusao" Then
                infoempresasobrigacoes.empresa = empresaSearchLookUpEdit.EditValue.ToString
            Else
                infoempresasobrigacoes.empresa = String.Empty
            End If
            empresaSearchLookUpEdit.Enabled = (okSimpleButton.Tag.ToString = "inclusao")

            Dim strQuery As String = "select aoe.obrigacao, ao.descricao, coalesce(aoe.competenciaobsoleta,'') as competenciaobsoleta " +
                                       "from admobrigacoesempresas aoe " +
                                       "join admobrigacoes ao on ao.obrigacao = aoe.obrigacao " +
                                      "where aoe.exercicio = " + administrativoInfo.Exercicio.ToString + " " +
                                        "and aoe.empresa = '" + infoempresasobrigacoes.empresa.ToString + "' " +
                                   "order by aoe.obrigacao"
            infoobrigacoes = New List(Of empresaobrigacoes)
            objEmpresaObrigacoes.Grid(strQuery, obrigacoesGridControl, obrigacoesGridView, infoobrigacoes)
            infoempresasobrigacoes.obrigacoes = infoobrigacoes
            originalinfoobrigacoes = New List(Of empresaobrigacoes)
            For index = 0 To infoobrigacoes.Count - 1
                Dim obrigacoesinfo As New empresaobrigacoes(infoobrigacoes(index).obrigacao.ToString(), infoobrigacoes(index).descricao.ToString(), infoobrigacoes(index).competenciaobsoleta.ToString())
                originalinfoobrigacoes.Add(obrigacoesinfo)
            Next
            HabilitaBotoes(String.Empty, obrigacoesGridView,
                           incluirobrigacoesSimpleButton, alterarobrigacoesSimpleButton, excluirobrigacoesSimpleButton, confirmarobrigacoesSimpleButton, voltarobrigacoesSimpleButton)
        End If
        If okSimpleButton.Tag.ToString <> String.Empty Then
            Me.AcceptButton = okSimpleButton
        End If
    End Sub

    Private Sub SugereObrigacoes()
        Dim strEmpresa As String = String.Empty
        Dim strRazaoSocial As String = String.Empty
        Dim strQuery As String = objEmpresaObrigacoes.SugereObrigacoes(empresaSearchLookUpEdit.EditValue.ToString, strEmpresa, strRazaoSocial)

        If Not String.IsNullOrEmpty(strQuery) Then
            infoobrigacoes = New List(Of empresaobrigacoes)
            objEmpresaObrigacoes.Grid(strQuery, obrigacoesGridControl, obrigacoesGridView, infoobrigacoes)
            infoempresasobrigacoes.obrigacoes = infoobrigacoes
            originalinfoobrigacoes = New List(Of empresaobrigacoes)
            If infoobrigacoes.Count > 0 Then
                XtraMessageBox.Show("Com base nas configurações cadastrais da empresa, o sistema sugere as obrigações da empresa [" + strEmpresa + " - " + strRazaoSocial + "].", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                If incluirobrigacoesSimpleButton.Enabled Then
                    incluirobrigacoesSimpleButton.Focus()
                End If
            End If

            HabilitaBotoes(String.Empty, obrigacoesGridView,
                           incluirobrigacoesSimpleButton, alterarobrigacoesSimpleButton, excluirobrigacoesSimpleButton, confirmarobrigacoesSimpleButton, voltarobrigacoesSimpleButton)
        End If
    End Sub

    Private Sub HabilitaBotoes(pstrOperacao As String, pgvItens As GridView,
                               incluirbutton As SimpleButton, alterarbutton As SimpleButton, excluirbutton As SimpleButton,
                               confirmarbutton As SimpleButton, voltarbutton As SimpleButton)
        Dim blnHabilitaCompetenciaObsoleta As Boolean = False
        incluirbutton.Enabled = (pstrOperacao = String.Empty)
        alterarbutton.Enabled = (pstrOperacao = String.Empty And pgvItens.RowCount > 0)
        excluirbutton.Enabled = (pstrOperacao = String.Empty And pgvItens.RowCount > 0)
        confirmarbutton.Enabled = (pstrOperacao <> String.Empty)
        voltarbutton.Enabled = (pstrOperacao <> String.Empty)
        If okSimpleButton.Tag.ToString = "alteracao" Then
            For index = 0 To infoobrigacoes.Count - 1
                If String.IsNullOrEmpty(infoobrigacoes(index).competenciaobsoleta) Then
                    blnHabilitaCompetenciaObsoleta = True
                    Exit For
                End If
            Next
        End If
        HabilitaCompetenciaObsoletaGeral(blnHabilitaCompetenciaObsoleta)
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
        infoempresasobrigacoes = Nothing
        empresaSearchLookUpEdit.EditValue = String.Empty
        razaosocialTextEdit.Text = String.Empty
        strCnpjCpf = String.Empty
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
        descricaoTextEdit.Text = String.Empty
        competenciaobsoletaTextEdit.EditValue = String.Empty
        intLinhaSubRegistro = -1
        confirmarbutton.Tag = String.Empty
    End Sub

    Private Sub SetModelo(pstrOperacao As String)
        Try
            infoempresasobrigacoes.empresa = empresaSearchLookUpEdit.EditValue.ToString
            infoempresasobrigacoes.razaosocial = razaosocialTextEdit.Text
            infoempresasobrigacoes.cnpjcpf = strCnpjCpf
            If competenciaobsoletageralTextEdit.Visible Then
                If Not String.IsNullOrEmpty(competenciaobsoletageralTextEdit.EditValue.ToString) Then
                    If XtraMessageBox.Show("Deseja aplicar a Competência Obsoleta para todas as obrigações?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = System.Windows.Forms.DialogResult.Yes Then
                        For index = 0 To infoobrigacoes.Count - 1
                            If String.IsNullOrEmpty(infoobrigacoes(index).competenciaobsoleta) Then
                                infoobrigacoes(index).competenciaobsoleta = competenciaobsoletageralTextEdit.EditValue.ToString
                            End If
                        Next
                    End If
                End If
            End If
            infoempresasobrigacoes.obrigacoes = infoobrigacoes
            SplashScreenManager.ShowForm(Me, GetType(aguardeWaitForm), True, True, False)
            objEmpresaObrigacoes.IUDEmpresaObrigacoes(pstrOperacao, infoempresasobrigacoes, originalinfoobrigacoes)
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
            Dim strCompetenciaObsoleta As String = String.Empty
            If Not competenciaobsoletaTextEdit.EditValue Is Nothing Then
                strCompetenciaObsoleta = competenciaobsoletaTextEdit.EditValue.ToString.Replace("_", String.Empty).Replace("/", String.Empty)
            End If
            Dim obrigacoesinfo As New empresaobrigacoes(obrigacaoSearchLookUpEdit.EditValue.ToString, descricaoTextEdit.Text, strCompetenciaObsoleta)
            infoobrigacoes.Add(obrigacoesinfo)
        ElseIf confirmarbutton.Tag.ToString = "alteracao" Then
            infoobrigacoes(intLinhaSubRegistro).obrigacao = obrigacaoSearchLookUpEdit.EditValue.ToString
            infoobrigacoes(intLinhaSubRegistro).descricao = descricaoTextEdit.Text
            infoobrigacoes(intLinhaSubRegistro).competenciaobsoleta = competenciaobsoletaTextEdit.EditValue.ToString
        ElseIf confirmarbutton.Tag.ToString = "exclusao" Then
            infoobrigacoes.Remove(infoobrigacoes(intLinhaSubRegistro))
        End If
        pdgGrid.DataSource = Nothing
        pdgGrid.DataSource = infoobrigacoes
        pdgGrid.ForceInitialize()
        infoempresasobrigacoes.obrigacoes = infoobrigacoes
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
            empresaobrigacoesGridView.FocusedRowHandle = intLinhaRegistro
        End If
    End Sub

    Private Sub RetornaIndexRegistro(pstrValor As String)
        For index = 0 To infoobrigacoes.Count - 1
            If infoobrigacoes(index).obrigacao = pstrValor Then
                intLinhaSubRegistro = index
            End If
        Next
    End Sub

    Private Sub HabilitaCompetenciaObsoletaGeral(pblnComptenciaObsoleta As Boolean)
        competenciaobsoletageralTextEdit.Visible = pblnComptenciaObsoleta
        competenciaobsoletageralLabelControl.Visible = pblnComptenciaObsoleta
        If pblnComptenciaObsoleta Then
            razaosocialTextEdit.Size = New System.Drawing.Size(479, 22)
            razaosocialTextEdit.Location = New System.Drawing.Point(110, 23)
        Else
            razaosocialTextEdit.Size = New System.Drawing.Size(601, 22)
            razaosocialTextEdit.Location = New System.Drawing.Point(110, 23)
        End If
    End Sub
End Class