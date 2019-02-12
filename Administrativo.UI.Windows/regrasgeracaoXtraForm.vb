Imports Administrativo.Modelo
Imports Administrativo.BLL
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Mask

Public Class regrasgeracaoXtraForm
    Dim objRegras As New RegrasBLL
    Dim objComum As New ComumBLL

    Dim gerarempresainicial As String
    Dim gerarempresafinal As String
    Dim gerarobrigacao As String




    Public Sub New()
        InitializeComponent()
        objComum.Browse("select empresa, razaosocial " +
                          "from empresas " +
                         "where exercicio = " + administrativoInfo.Exercicio.ToString + " order by empresa", empresasInfoBindingSource)
        objComum.Browse("select regra, descricao from admregras where exercicio = " + administrativoInfo.Exercicio.ToString + " order by regra", regrasBindingSource)
        objComum.Browse("select obrigacao, descricao from admobrigacoes order by obrigacao", obrigacoesInfoBindingSource)
    End Sub

    Private Sub regrasgeracaoXtraForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        objComum.DefineValoresDefault("empresas", "empresa", empresainicialSearchLookUpEdit, empresafinalSearchLookUpEdit,
                                      "exercicio = " + administrativoInfo.Exercicio.ToString)
        objComum.DefineValoresDefault("admregras", "regra", regrainicialSearchLookUpEdit, regrafinalSearchLookUpEdit, "exercicio = " + administrativoInfo.Exercicio.ToString)
    End Sub

    Private Sub gerarSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles gerarSimpleButton.Click

        gerarempresainicial = empresainicialSearchLookUpEdit.Text.Replace(".", "")
        gerarempresafinal = empresafinalSearchLookUpEdit.Text.Replace(".", "")
        gerarobrigacao = obrigacaoSearchLookUpEdit.Text.Replace(".", "")

        Try
            SplashScreenManager.ShowForm(Me, GetType(aguardeWaitForm), True, True, False)
            objRegras.GerarRegras(regrainicialSearchLookUpEdit.Text, regrafinalSearchLookUpEdit.Text, gerarempresainicial, gerarempresafinal, gerarobrigacao, Convert.ToBoolean(excluirempresaobrigacaoCheckEdit.Checked))
            SplashScreenManager.CloseForm()
            XtraMessageBox.Show("Regras geradas com sucesso", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub obrigacaoSearchLookUpEdit_CustomDisplayText(sender As System.Object, e As DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs) Handles obrigacaoSearchLookUpEdit.CustomDisplayText
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
    End Sub
End Class