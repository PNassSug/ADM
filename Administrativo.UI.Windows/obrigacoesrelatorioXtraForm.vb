Imports Administrativo.BLL
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraEditors

Public Class obrigacoesrelatorioXtraForm
    Private bsObrigacacoes As BindingSource

    Dim objObrigacoes As New ObrigacoesBLL
    Dim objComum As New ComumBLL

    Public Sub New()
        InitializeComponent()
        objComum.Browse("select obrigacao, descricao from admobrigacoes order by obrigacao", obrigacoesInfoBindingSource)
    End Sub

    Private Sub obrigacoesrelatorioXtraForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        objComum.DefineValoresDefault("admobrigacoes", "obrigacao", obrigacaoinicialSearchLookUpEdit, obrigacaofinalSearchLookUpEdit)
    End Sub

    Private Sub imprimirSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles imprimirSimpleButton.Click
        Dim strSistema As String = String.Empty
        If Not String.IsNullOrEmpty(sistemaComboBoxEdit.Text) Then
            strSistema = sistemaComboBoxEdit.Text.ToUpper.Substring(9, 3)
        End If
        If (tiporelatorioComboBoxEdit.SelectedIndex = 0) Then
            Try
                Dim reportDetalhado As New obrigacoesdetalhadoXtraReport()

                SplashScreenManager.ShowForm(Me, GetType(aguardeWaitForm), True, True, False)
                objObrigacoes.Report(obrigacaoinicialSearchLookUpEdit.Text, obrigacaofinalSearchLookUpEdit.Text, periodicidadeComboBoxEdit.Text, tributoComboBoxEdit.Text, strSistema, reportDetalhado)

                Dim printTool As New ReportPrintTool(reportDetalhado)

                reportDetalhado.Parameters.Item("Sistema").Value = Application.ProductName
                reportDetalhado.Parameters.Item("Sistema").Visible = False

                Dim obrigacaogroupField As New GroupField("obrigacao")
                reportDetalhado.obrigacaoGroupHeader.GroupFields.Add(obrigacaogroupField)

                Dim tipogroupField As New GroupField("tipo")
                reportDetalhado.tipoGroupHeader.GroupFields.Add(tipogroupField)

                Dim detalhegroupField As New GroupField("varcod")
                reportDetalhado.detalheGroupHeader.GroupFields.Add(detalhegroupField)

                printTool.AutoShowParametersPanel = False

                SplashScreenManager.CloseForm()
                printTool.ShowRibbonPreview()
            Catch ex As Exception
                SplashScreenManager.CloseForm()
                XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            Try
                Dim reportResumido As New obrigacoesresumidoXtraReport()

                SplashScreenManager.ShowForm(Me, GetType(aguardeWaitForm), True, True, False)
                objObrigacoes.Report(obrigacaoinicialSearchLookUpEdit.Text, obrigacaofinalSearchLookUpEdit.Text, periodicidadeComboBoxEdit.Text, tributoComboBoxEdit.Text, strSistema, reportResumido, True)

                Dim printTool As New ReportPrintTool(reportResumido)

                reportResumido.Parameters.Item("Sistema").Value = Application.ProductName
                reportResumido.Parameters.Item("Sistema").Visible = False

                printTool.AutoShowParametersPanel = False

                SplashScreenManager.CloseForm()
                printTool.ShowRibbonPreview()
            Catch ex As Exception
                SplashScreenManager.CloseForm()
                XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub voltarSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles voltarSimpleButton.Click
        Me.Close()
    End Sub

    Private Sub obrigacaoinicialSearchLookUpEdit_CustomDisplayText(sender As System.Object, e As DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs) Handles obrigacaoinicialSearchLookUpEdit.CustomDisplayText
        Dim editor As SearchLookUpEdit = TryCast(sender, SearchLookUpEdit)
        If editor.EditValue IsNot Nothing Then
            Dim index As Integer = editor.Properties.GetIndexByKeyValue(editor.EditValue)
            obrigacaoinicialTextEdit.Text = objComum.RetornaDescricao(obrigacoesInfoBindingSource, index, "descricao")
        Else
            obrigacaoinicialTextEdit.Text = String.Empty
        End If
    End Sub

    Private Sub obrigacaofinalSearchLookUpEdit_CustomDisplayText(sender As System.Object, e As DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs) Handles obrigacaofinalSearchLookUpEdit.CustomDisplayText
        Dim editor As SearchLookUpEdit = TryCast(sender, SearchLookUpEdit)
        If editor.EditValue IsNot Nothing Then
            Dim index As Integer = editor.Properties.GetIndexByKeyValue(editor.EditValue)
            obrigacaofinalTextEdit.Text = objComum.RetornaDescricao(obrigacoesInfoBindingSource, index, "descricao")
        Else
            obrigacaofinalTextEdit.Text = String.Empty
        End If
    End Sub
End Class