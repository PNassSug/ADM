Imports Administrativo.Modelo
Imports Administrativo.BLL
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Mask

Public Class empresaobrigacoesgeracaoXtraForm

    Dim objEmpresaObrigacoes As New EmpresaObrigacoesBLL
    Dim objComum As New ComumBLL

    Public Sub New()
        InitializeComponent()
        objComum.Browse("select empresa, razaosocial " +
                          "from empresas " +
                         "where exercicio = " + administrativoInfo.Exercicio.ToString + " order by empresa", empresasInfoBindingSource)

    End Sub

    Private Sub empresaSearchLookUpEdit_CustomDisplayText(sender As System.Object, e As DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs) Handles empresaSearchLookUpEdit.CustomDisplayText

        Dim editor As SearchLookUpEdit = TryCast(sender, SearchLookUpEdit)
        If editor.EditValue IsNot Nothing Then
            Dim index As Integer = editor.Properties.GetIndexByKeyValue(editor.EditValue)
            If index >= 0 Then
                empresaTextEdit.Text = objComum.RetornaDescricao(empresasInfoBindingSource, index, "razaosocial")
            Else
                empresaTextEdit.Text = String.Empty
            End If
        Else
            empresaTextEdit.Text = String.Empty
        End If
        If editor.IsModified Then
            obrigacaoSearchLookUpEdit.EditValue = Nothing
            descricaoTextEdit.Text = String.Empty
            If editor.EditValue Is Nothing Then
                obrigacaoSearchLookUpEdit.Enabled = False
            Else
                objComum.Browse("select ao.obrigacao, ao.descricao " +
                                  "from admobrigacoesempresas aoe " +
                                  "join admobrigacoes ao on ao.obrigacao = aoe.obrigacao " +
                                 "where aoe.exercicio = " + administrativoInfo.Exercicio.ToString + " " +
                                   "and aoe.empresa = '" + editor.EditValue.ToString + "' " +
                              "order by 1", obrigacoesInfoBindingSource)
                obrigacaoSearchLookUpEdit.Enabled = True
            End If
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

    Private Sub gerarSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles gerarSimpleButton.Click
        Try
            SplashScreenManager.ShowForm(Me, GetType(aguardeWaitForm), True, True, False)
            Dim intExercicio As Int32 = 0
            If Not competenciaTextEdit.EditValue Is Nothing Then
                intExercicio = Convert.ToInt32(competenciaTextEdit.EditValue.ToString.Substring(2, 4))
            End If
            Dim strEmpresa As String = String.Empty
            If Not empresaSearchLookUpEdit.EditValue Is Nothing Then
                strEmpresa = empresaSearchLookUpEdit.EditValue.ToString
            End If

            Dim strCompetencia As String = String.Empty
            If Not competenciaTextEdit.EditValue Is Nothing Then
                strCompetencia = competenciaTextEdit.EditValue.ToString
            End If

            Dim strObrigacao As String = String.Empty
            If Not obrigacaoSearchLookUpEdit.EditValue Is Nothing Then
                strObrigacao = obrigacaoSearchLookUpEdit.EditValue.ToString
            End If

            objEmpresaObrigacoes.GeracaoControleObrigacoes(strEmpresa, strCompetencia, intExercicio, strObrigacao, Convert.ToBoolean(excluirempresaobrigacaoCheckEdit.Checked))
            SplashScreenManager.CloseForm()
            XtraMessageBox.Show("Controle das Obrigações gerada com sucesso", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            SplashScreenManager.CloseForm()
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub voltarSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles voltarSimpleButton.Click
        Me.Close()
    End Sub
End Class