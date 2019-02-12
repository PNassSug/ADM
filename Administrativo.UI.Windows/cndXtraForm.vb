Imports Administrativo.Modelo
Imports Administrativo.BLL
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views

Public Class cndXtraForm
   Dim objCnd As New CndBLL
   Dim objComum As New ComumBLL
   Dim intLinhaRegistro As Int32 = 0
   Dim blnCarregaDados As Boolean = False
   Dim blnHouveAlteracao As Boolean = False

   Public Sub New()
      InitializeComponent()
      objComum.Browse("select emp.empresa, emp.razaosocial " +
                        "from (select aoe.empresa, max(aoe.exercicio) as exercicio from admobrigacoesempresas aoe group by aoe.empresa) aoe " +
                        "join empresas emp on emp.empresa = aoe.empresa and emp.exercicio = aoe.exercicio " +
                    "order by emp.empresa", empresasInfoBindingSource)
      cndSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
   End Sub

   Private Sub cndXtraForm_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
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

   Private Sub cndXtraForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
      Try
         CarregaGrid()
      Catch ex As Exception
         XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
   End Sub

   Private Sub voltarSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles voltarSimpleButton.Click
      Try
         RetornaGridFocu()
         LimpaDados()
         cndSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
      Catch ex As Exception
         XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
   End Sub

   Private Sub empresaSearchLookUpEdit_CustomDisplayText(sender As System.Object, e As DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs) Handles empresaSearchLookUpEdit.CustomDisplayText
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

   Private Sub cndGridView_DoubleClick(sender As Object, e As System.EventArgs) Handles cndGridView.DoubleClick
      Try
         CarregaDados(cndGridView)
      Catch ex As Exception
         XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
   End Sub

   Private Sub cndGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles cndGridView.KeyDown
      Try
         If e.KeyCode = Keys.Enter Then
            CarregaDados(cndGridView)
         ElseIf e.KeyCode = Keys.F5 Then
            If atualizarBarButtonItem.Enabled Then
               CarregaGrid()
            End If
         End If
      Catch ex As Exception
         XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
   End Sub

   Private Sub alterarBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles alterarBarButtonItem.ItemClick
      Try
         CarregaDados(cndGridView)
      Catch ex As Exception
         XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
   End Sub

   Private Sub localizarBarCheckItem_CheckedChanged(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles localizarBarCheckItem.CheckedChanged
      Try
         cndGridView.OptionsFind.AlwaysVisible = localizarBarCheckItem.Checked
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
         objCnd.Grid("select aec.empresa, e.razaosocial, aec.datahoraemissao, aec.datavalidade, aec.codigocontrolecertidao, aec.status, aec.observacao, aec.tempo, aec.competencia " +
                           "from admempresascnd aec " +
                           "join empresas e on e.empresa = aec.empresa and e.exercicio = " + administrativoInfo.Exercicio.ToString + " " +
                          "where aec.competencia = '" + administrativoInfo.Competencia + "' " +
                       "order by aec.empresa",
                         cndGridControl, cndGridView, statusImageCollection)

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
            intLinhaRegistro = intLinha(i)
            empresaSearchLookUpEdit.EditValue = pdgGrid.GetRowCellValue(intLinha(i), "empresa").ToString()
            competenciaTextEdit.EditValue = pdgGrid.GetRowCellValue(intLinha(i), "competencia").ToString()
            tempoTextEdit.Text = pdgGrid.GetRowCellValue(intLinha(i), "tempo").ToString()
            datahoraemissaoDateEdit.EditValue = pdgGrid.GetRowCellValue(intLinha(i), "datahoraemissao").ToString()
            datavalidadeDateEdit.EditValue = pdgGrid.GetRowCellValue(intLinha(i), "datavalidade").ToString()
            codigocontrolecertidaoTextEdit.Text = pdgGrid.GetRowCellValue(intLinha(i), "codigocontrolecertidao").ToString()
            observacaoTextEdit.Text = pdgGrid.GetRowCellValue(intLinha(i), "observacao").ToString()

            HabilitaBotoes("alteracao")
            cndSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
         End If
      Next
   End Sub


   Private Sub HabilitaBotoes(pstrOperacao As String)
      incluirBarButtonItem.Enabled = (pstrOperacao = String.Empty)
      localizarBarCheckItem.Enabled = (pstrOperacao = String.Empty)
      atualizarBarButtonItem.Enabled = (pstrOperacao = String.Empty)
      alterarBarButtonItem.Enabled = (pstrOperacao = String.Empty And cndGridView.RowCount > 0)
      excluirBarButtonItem.Enabled = (pstrOperacao = String.Empty And cndGridView.RowCount > 0)
   End Sub

   Private Sub LimpaDados()
      empresaSearchLookUpEdit.EditValue = String.Empty
      razaosocialTextEdit.Text = String.Empty
      competenciaTextEdit.Text = String.Empty
      tempoTextEdit.Text = String.Empty
      datahoraemissaoDateEdit.EditValue = Nothing
      datavalidadeDateEdit.EditValue = Nothing
      codigocontrolecertidaoTextEdit.Text = String.Empty
      observacaoTextEdit.Text = String.Empty

      Me.AcceptButton = Nothing
      intLinhaRegistro = 0
      HabilitaBotoes(String.Empty)
   End Sub

   Private Sub SetModelo(pstrOperacao As String)
      Try
         SplashScreenManager.ShowForm(Me, GetType(aguardeWaitForm), True, True, False)
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
      If intLinhaRegistro >= 0 Then
         cndGridView.FocusedRowHandle = intLinhaRegistro
      End If
   End Sub
End Class