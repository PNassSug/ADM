﻿Imports Administrativo.Modelo
Imports Administrativo.BLL
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraEditors

Public Class regrasrelatorioXtraForm
    Dim objRegras As New RegrasBLL
    Dim objComum As New ComumBLL

    Public Sub New()
        InitializeComponent()
        objComum.Browse("select empresa, razaosocial " +
                          "from empresas " +
                         "where exercicio = " + administrativoInfo.Exercicio.ToString + " order by empresa", empresasInfoBindingSource)
        objComum.Browse("select obrigacao, descricao from admobrigacoes order by obrigacao", obrigacoesInfoBindingSource)
        objComum.Browse("select regra, descricao from admregras where exercicio = " + administrativoInfo.Exercicio.ToString + " order by regra", regrasBindingSource)
    End Sub

    Private Sub empresaobrigacoesrelarioXtraForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        objComum.DefineValoresDefault("empresas", "empresa", empresainicialSearchLookUpEdit, empresafinalSearchLookUpEdit,
                                      "exercicio = " + administrativoInfo.Exercicio.ToString)
        objComum.DefineValoresDefault("admobrigacoes", "obrigacao", obrigacaoinicialSearchLookUpEdit, obrigacaofinalSearchLookUpEdit)
        objComum.DefineValoresDefault("admregras", "regra", regrainicialSearchLookUpEdit, regrafinalSearchLookUpEdit, "exercicio = " + administrativoInfo.Exercicio.ToString)
    End Sub

    Private Sub imprimirSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles imprimirSimpleButton.Click
        Try
            Dim report As New regrasXtraReport()

            SplashScreenManager.ShowForm(Me, GetType(aguardeWaitForm), True, True, False)
            objRegras.Report(regrainicialSearchLookUpEdit.Text, regrafinalSearchLookUpEdit.Text, obrigacaoinicialSearchLookUpEdit.Text, obrigacaofinalSearchLookUpEdit.Text, empresainicialSearchLookUpEdit.Text, empresafinalSearchLookUpEdit.Text, report)

            Dim printTool As New ReportPrintTool(report)

            report.Parameters.Item("Sistema").Value = Application.ProductName
            report.Parameters.Item("Sistema").Visible = False

            printTool.AutoShowParametersPanel = False

            SplashScreenManager.CloseForm()
            printTool.ShowRibbonPreview()
        Catch ex As Exception
            SplashScreenManager.CloseForm()
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub voltarSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles voltarSimpleButton.Click
        Me.Close()
    End Sub

    Private Sub regrainicialSearchLookUpEdit_CustomDisplayText(sender As System.Object, e As DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs) Handles regrainicialSearchLookUpEdit.CustomDisplayText
        Dim editor As SearchLookUpEdit = TryCast(sender, SearchLookUpEdit)
        If editor.EditValue IsNot Nothing Then
            Dim index As Integer = editor.Properties.GetIndexByKeyValue(editor.EditValue)
            If index >= 0 Then
                regrainicialTextEdit.Text = objComum.RetornaDescricao(regrasBindingSource, index, "descricao")
            Else
                regrainicialTextEdit.Text = String.Empty
            End If
        Else
            regrainicialTextEdit.Text = String.Empty
        End If
    End Sub

    Private Sub regrafinalSearchLookUpEdit_CustomDisplayText(sender As System.Object, e As DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs) Handles regrafinalSearchLookUpEdit.CustomDisplayText
        Dim editor As SearchLookUpEdit = TryCast(sender, SearchLookUpEdit)
        If editor.EditValue IsNot Nothing Then
            Dim index As Integer = editor.Properties.GetIndexByKeyValue(editor.EditValue)
            If index >= 0 Then
                regrafinalTextEdit.Text = objComum.RetornaDescricao(regrasBindingSource, index, "descricao")
            Else
                regrafinalTextEdit.Text = String.Empty
            End If
        Else
            regrafinalTextEdit.Text = String.Empty
        End If
    End Sub

    Private Sub obrigacaoinicialSearchLookUpEdit_CustomDisplayText(sender As System.Object, e As DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs) Handles obrigacaoinicialSearchLookUpEdit.CustomDisplayText
        Dim editor As SearchLookUpEdit = TryCast(sender, SearchLookUpEdit)
        If editor.EditValue IsNot Nothing Then
            Dim index As Integer = editor.Properties.GetIndexByKeyValue(editor.EditValue)
            If index >= 0 Then
                obrigacaoinicialTextEdit.Text = objComum.RetornaDescricao(obrigacoesInfoBindingSource, index, "descricao")
            Else
                obrigacaoinicialTextEdit.Text = String.Empty
            End If

        Else
            obrigacaoinicialTextEdit.Text = String.Empty
        End If
    End Sub

    Private Sub obrigacaofinalSearchLookUpEdit_CustomDisplayText(sender As System.Object, e As DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs) Handles obrigacaofinalSearchLookUpEdit.CustomDisplayText
        Dim editor As SearchLookUpEdit = TryCast(sender, SearchLookUpEdit)
        If editor.EditValue IsNot Nothing Then
            Dim index As Integer = editor.Properties.GetIndexByKeyValue(editor.EditValue)
            If index >= 0 Then
                obrigacaofinalTextEdit.Text = objComum.RetornaDescricao(obrigacoesInfoBindingSource, index, "descricao")
            Else
                obrigacaofinalTextEdit.Text = String.Empty
            End If
        Else
            obrigacaofinalTextEdit.Text = String.Empty
        End If
    End Sub

    Private Sub empresainicialSearchLookUpEdit_CustomDisplayText(sender As System.Object, e As DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs) Handles empresainicialSearchLookUpEdit.CustomDisplayText
        Dim editor As SearchLookUpEdit = TryCast(sender, SearchLookUpEdit)
        If editor.EditValue IsNot Nothing Then
            Dim index As Integer = editor.Properties.GetIndexByKeyValue(editor.EditValue)
            If index >= 0 Then
                empresainicialTextEdit.Text = objComum.RetornaDescricao(empresasInfoBindingSource, index, "razaosocial")
            Else
                empresainicialTextEdit.Text = String.Empty
            End If
        Else
            empresainicialTextEdit.Text = String.Empty
        End If
    End Sub

    Private Sub empresafinalSearchLookUpEdit_CustomDisplayText(sender As System.Object, e As DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs) Handles empresafinalSearchLookUpEdit.CustomDisplayText
        Dim editor As SearchLookUpEdit = TryCast(sender, SearchLookUpEdit)
        If editor.EditValue IsNot Nothing Then
            Dim index As Integer = editor.Properties.GetIndexByKeyValue(editor.EditValue)
            If index >= 0 Then
                empresafinalTextEdit.Text = objComum.RetornaDescricao(empresasInfoBindingSource, index, "razaosocial")
            Else
                empresafinalTextEdit.Text = String.Empty
            End If
        Else
            empresafinalTextEdit.Text = String.Empty
        End If
    End Sub
End Class