Imports Administrativo.Modelo
Imports Administrativo.BLL
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Mask

Public Class obrigacoesXtraForm
   Dim objObrigacoes As New ObrigacoesBLL
   Dim objComum As New ComumBLL
   Dim blnCancela As Boolean = False
   Dim intLinhaRegistro As Int32 = 0
   Dim intLinhaSubRegistro As Int32 = -1
   Dim intLinhaGroup As Int32 = -1
   Dim blnCarregaVariacao As Boolean = False

   Dim infoobrigacoes As obrigacoesInfo

   Dim infovariacao As List(Of obrigacoesvariacao)
   Dim originalinfovariacao As List(Of obrigacoesvariacao)

   Public Sub New()
      InitializeComponent()
      objComum.Browse("select u.login, u.nome " +
                          "from usuarios u " +
                          "join usernivel un on un.login = u.login and un.sistema = 'Administrativo' " +
                      "order by u.login", usuarioInfoBindingSource)
      obrigacoesSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
      vencimentoporSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
   End Sub

   Private Sub obrigacoesXtraForm_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
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

   Private Sub obrigacoesXtraForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
      Try
         CarregaGrid()
      Catch ex As Exception
         XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
   End Sub

   Private Sub obrigacoesXtraForm_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
      If blnCancela Then
         e.Cancel = True
         Call voltarSimpleButton_Click(sender, e)
         blnCancela = False
      End If
   End Sub

   Private Sub okSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles okSimpleButton.Click
      Try
         SetModelo(okSimpleButton.Tag.ToString)
         obrigacoesSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
      Catch ex As Exception
         XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
   End Sub

   Private Sub voltarSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles voltarSimpleButton.Click
      Try
         RetornaGridFocu()
         LimpaDados()
         obrigacoesSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
         blnCancela = False
      Catch ex As Exception
         XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
   End Sub

   Private Sub obrigacoesGridView_DoubleClick(sender As Object, e As System.EventArgs) Handles obrigacoesGridView.DoubleClick
      Try
         If alterarBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always Then
            okSimpleButton.Tag = "alteracao"
            CarregaDados(obrigacoesGridView)
         End If
      Catch ex As Exception
         XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
   End Sub

   Private Sub obrigacoesGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles obrigacoesGridView.KeyDown
      Try
         If e.KeyCode = Keys.Enter Then
            If alterarBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always Then
               okSimpleButton.Tag = "alteracao"
               CarregaDados(obrigacoesGridView)
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

   Private Sub vencimentoporGridView_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles vencimentoporGridView.CustomColumnDisplayText
      Try
         Dim strValor As String = String.Empty

         If e.Column.FieldName = "periodicidade" Then
            If vencimentoporGridView.GetRowCellValue(e.ListSourceRowIndex, "periodicidade") IsNot Nothing Then
               strValor = vencimentoporGridView.GetRowCellValue(e.ListSourceRowIndex, "periodicidade").ToString()
            Else
               strValor = e.Value.ToString
            End If
            e.DisplayText = DisplayComboBox(e.Column.FieldName, strValor)
         ElseIf e.Column.FieldName = "tipodia" Then
            If vencimentoporGridView.GetRowCellValue(e.ListSourceRowIndex, "tipodia") IsNot Nothing Then
               strValor = vencimentoporGridView.GetRowCellValue(e.ListSourceRowIndex, "tipodia").ToString()
            Else
               strValor = e.Value.ToString
            End If
            e.DisplayText = DisplayComboBox(e.Column.FieldName, strValor)
         ElseIf e.Column.FieldName = "tributo" Then
            If vencimentoporGridView.GetRowCellValue(e.ListSourceRowIndex, "tributo") IsNot Nothing Then
               strValor = vencimentoporGridView.GetRowCellValue(e.ListSourceRowIndex, "tributo").ToString()
            Else
               strValor = e.Value.ToString
            End If
            e.DisplayText = DisplayComboBox(e.Column.FieldName, strValor)
         ElseIf e.Column.FieldName = "tiposubsequente" Then
            If vencimentoporGridView.GetRowCellValue(e.ListSourceRowIndex, "tiposubsequente") IsNot Nothing Then
               strValor = vencimentoporGridView.GetRowCellValue(e.ListSourceRowIndex, "tiposubsequente").ToString()
            Else
               strValor = e.Value.ToString
            End If
            e.DisplayText = DisplayComboBox(e.Column.FieldName, strValor)
         ElseIf e.Column.FieldName = "sabdomutil" Then
            If vencimentoporGridView.GetRowCellValue(e.ListSourceRowIndex, "sabdomutil") IsNot Nothing Then
               strValor = vencimentoporGridView.GetRowCellValue(e.ListSourceRowIndex, "sabdomutil").ToString()
            Else
               strValor = e.Value.ToString
            End If

            If strValor.EndsWith("0") Then
               e.DisplayText = "Não"
            ElseIf strValor.EndsWith("-1") Then
               e.DisplayText = "Sim"
            End If
         ElseIf e.Column.FieldName = "antecipautil" Then
            If vencimentoporGridView.GetRowCellValue(e.ListSourceRowIndex, "antecipautil") IsNot Nothing Then
               strValor = vencimentoporGridView.GetRowCellValue(e.ListSourceRowIndex, "antecipautil").ToString()
            Else
               strValor = e.Value.ToString
            End If

            If strValor.EndsWith("0") Then
               e.DisplayText = "Não"
            ElseIf strValor.EndsWith("-1") Then
               e.DisplayText = "Sim"
            End If
         End If
      Catch ex As Exception
         XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
   End Sub

   Private Sub vencimentoporGridView_DoubleClick(sender As Object, e As System.EventArgs) Handles vencimentoporGridView.DoubleClick
      Try
         If okSimpleButton.Tag.ToString <> "exclusao" Then
            confirmarvencimentoporSimpleButton.Tag = "alteracao"
            CarregaDados(vencimentoporGridView,
                             incluirvencimentoporSimpleButton, alterarvencimentoporSimpleButton, excluirvencimentoporSimpleButton, confirmarvencimentoporSimpleButton, voltarvencimentoporSimpleButton)
         End If
      Catch ex As Exception
         XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
   End Sub

   Private Sub vencimentoporComboBoxEdit_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles vencimentoporComboBoxEdit.EditValueChanged
      Try
         If vencimentoporComboBoxEdit.EditValue IsNot Nothing Then
            Dim strTipo As String = String.Empty
            If vencimentoporComboBoxEdit.EditValue.ToString = "Não tem" Then
               strTipo = "item"
            ElseIf vencimentoporComboBoxEdit.EditValue.ToString = "por CPR" Then
               strTipo = "cpr"
            ElseIf vencimentoporComboBoxEdit.EditValue.ToString = "por IE" Then
               strTipo = "ie"
            ElseIf vencimentoporComboBoxEdit.EditValue.ToString = "por CNPJ" Then
               strTipo = "cnpj"
            ElseIf vencimentoporComboBoxEdit.EditValue.ToString = "por ISS" Then
               strTipo = "iss"
            ElseIf vencimentoporComboBoxEdit.EditValue.ToString = "por e-ISS" Then
               strTipo = "eiss"
            End If
            Dim strValor As String = String.Empty
            If strTipo = "iss" Or strTipo = "eiss" Or strTipo = "cpr" Then
               If variacaoSearchLookUpEdit.EditValue IsNot Nothing Then
                  strValor = variacaoSearchLookUpEdit.EditValue.ToString
               End If
            ElseIf strTipo = "ie" Or strTipo = "cnpj" Then
               strValor = variacaocodTextEdit.Text.ToString
            End If
            RedimensionaTela(strTipo, strValor)
            If blnCarregaVariacao Then
               HabilitaVencimentoPor()
            End If
         End If
      Catch ex As Exception
         XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
   End Sub

   Private Sub variacaoSearchLookUpEdit_CustomDisplayText(sender As System.Object, e As DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs) Handles variacaoSearchLookUpEdit.CustomDisplayText
      Dim editor As SearchLookUpEdit = TryCast(sender, SearchLookUpEdit)
      If editor.EditValue IsNot Nothing Then
         Dim index As Integer = editor.Properties.GetIndexByKeyValue(editor.EditValue)
         If index >= 0 Then
            If variacaodescTextEdit.Visible Then
               variacaodescTextEdit.Text = objComum.RetornaDescricao(variacaoBindingSource, index, "nome")
            Else
               variacaodescTextEdit.Text = String.Empty
            End If
         Else
            variacaodescTextEdit.Text = String.Empty
         End If
      Else
         variacaodescTextEdit.Text = String.Empty
      End If
   End Sub

   Private Sub subsequenteTextEdit_CustomDisplayText(sender As System.Object, e As DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs) Handles subsequenteTextEdit.CustomDisplayText
      If Not subsequenteTextEdit.EditValue Is Nothing Then
         If Not String.IsNullOrEmpty(subsequenteTextEdit.EditValue.ToString) Then
            tiposubsequenteComboBoxEdit.Visible = (Convert.ToInt32(subsequenteTextEdit.EditValue.ToString) <> 0)
         End If
      Else
         tiposubsequenteComboBoxEdit.Visible = False
         tiposubsequenteComboBoxEdit.EditValue = String.Empty
      End If
   End Sub

   Private Sub obrigacoesGridView_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles obrigacoesGridView.CustomColumnDisplayText
      Dim strValor As String = String.Empty
      If e.Column.FieldName = "sistema" Then
         If obrigacoesitemGridView.GetRowCellValue(e.ListSourceRowIndex, "sistema") IsNot Nothing Then
            strValor = obrigacoesitemGridView.GetRowCellValue(e.ListSourceRowIndex, "sistema").ToString()
         Else
            strValor = e.Value.ToString
         End If
         e.DisplayText = DisplayComboBox(e.Column.FieldName, strValor)
      End If
   End Sub

   Private Sub usuarioenvioSearchLookUpEdit_CustomDisplayText(sender As Object, e As DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs) Handles usuarioenvioSearchLookUpEdit.CustomDisplayText
      Try
         Dim editor As SearchLookUpEdit = TryCast(sender, SearchLookUpEdit)

         If editor.EditValue IsNot Nothing Then
            Dim index As Integer = editor.Properties.GetIndexByKeyValue(editor.EditValue)
            If index >= 0 Then
               nomeenvioTextEdit.Text = objComum.RetornaDescricao(usuarioInfoBindingSource, index, "nome")
            Else
               nomeenvioTextEdit.Text = String.Empty
            End If
         Else
            nomeenvioTextEdit.Text = String.Empty
         End If
      Catch ex As Exception
         XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
   End Sub

   Private Sub obrigacoesitemGridView_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles obrigacoesitemGridView.CustomColumnDisplayText
      Try
         Dim strValor As String = String.Empty

         If e.Column.FieldName = "periodicidade" Then
            If obrigacoesitemGridView.GetRowCellValue(e.ListSourceRowIndex, "periodicidade") IsNot Nothing Then
               strValor = obrigacoesitemGridView.GetRowCellValue(e.ListSourceRowIndex, "periodicidade").ToString()
            Else
               strValor = e.Value.ToString
            End If
            e.DisplayText = DisplayComboBox(e.Column.FieldName, strValor)
         ElseIf e.Column.FieldName = "tipodia" Then
            If obrigacoesitemGridView.GetRowCellValue(e.ListSourceRowIndex, "tipodia") IsNot Nothing Then
               strValor = obrigacoesitemGridView.GetRowCellValue(e.ListSourceRowIndex, "tipodia").ToString()
            Else
               strValor = e.Value.ToString
            End If
            e.DisplayText = DisplayComboBox(e.Column.FieldName, strValor)
         ElseIf e.Column.FieldName = "tributo" Then
            If obrigacoesitemGridView.GetRowCellValue(e.ListSourceRowIndex, "tributo") IsNot Nothing Then
               strValor = obrigacoesitemGridView.GetRowCellValue(e.ListSourceRowIndex, "tributo").ToString()
            Else
               strValor = e.Value.ToString
            End If
            e.DisplayText = DisplayComboBox(e.Column.FieldName, strValor)
         ElseIf e.Column.FieldName = "tiposubsequente" Then
            If obrigacoesitemGridView.GetRowCellValue(e.ListSourceRowIndex, "tiposubsequente") IsNot Nothing Then
               strValor = obrigacoesitemGridView.GetRowCellValue(e.ListSourceRowIndex, "tiposubsequente").ToString()
            Else
               strValor = e.Value.ToString
            End If
            e.DisplayText = DisplayComboBox(e.Column.FieldName, strValor)
         ElseIf e.Column.FieldName = "sabdomutil" Then
            If obrigacoesitemGridView.GetRowCellValue(e.ListSourceRowIndex, "sabdomutil") IsNot Nothing Then
               strValor = obrigacoesitemGridView.GetRowCellValue(e.ListSourceRowIndex, "sabdomutil").ToString()
            Else
               strValor = e.Value.ToString
            End If

            If strValor.EndsWith("0") Then
               e.DisplayText = "Não"
            ElseIf strValor.EndsWith("-1") Then
               e.DisplayText = "Sim"
            End If
         ElseIf e.Column.FieldName = "antecipautil" Then
            If obrigacoesitemGridView.GetRowCellValue(e.ListSourceRowIndex, "antecipautil") IsNot Nothing Then
               strValor = obrigacoesitemGridView.GetRowCellValue(e.ListSourceRowIndex, "antecipautil").ToString()
            Else
               strValor = e.Value.ToString
            End If

            If strValor.EndsWith("0") Then
               e.DisplayText = "Não"
            ElseIf strValor.EndsWith("-1") Then
               e.DisplayText = "Sim"
            End If
         End If
      Catch ex As Exception
         XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
   End Sub

   Private Sub obrigacoescprGridView_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles obrigacoescprGridView.CustomColumnDisplayText
      Try
         Dim strValor As String = String.Empty

         If e.Column.FieldName = "periodicidade" Then
            If obrigacoescprGridView.GetRowCellValue(e.ListSourceRowIndex, "periodicidade") IsNot Nothing Then
               strValor = obrigacoescprGridView.GetRowCellValue(e.ListSourceRowIndex, "periodicidade").ToString()
            Else
               strValor = e.Value.ToString
            End If
            e.DisplayText = DisplayComboBox(e.Column.FieldName, strValor)
         ElseIf e.Column.FieldName = "tipodia" Then
            If obrigacoescprGridView.GetRowCellValue(e.ListSourceRowIndex, "tipodia") IsNot Nothing Then
               strValor = obrigacoescprGridView.GetRowCellValue(e.ListSourceRowIndex, "tipodia").ToString()
            Else
               strValor = e.Value.ToString
            End If
            e.DisplayText = DisplayComboBox(e.Column.FieldName, strValor)
         ElseIf e.Column.FieldName = "tributo" Then
            If obrigacoescprGridView.GetRowCellValue(e.ListSourceRowIndex, "tributo") IsNot Nothing Then
               strValor = obrigacoescprGridView.GetRowCellValue(e.ListSourceRowIndex, "tributo").ToString()
            Else
               strValor = e.Value.ToString
            End If
            e.DisplayText = DisplayComboBox(e.Column.FieldName, strValor)
         ElseIf e.Column.FieldName = "tiposubsequente" Then
            If obrigacoescprGridView.GetRowCellValue(e.ListSourceRowIndex, "tiposubsequente") IsNot Nothing Then
               strValor = obrigacoescprGridView.GetRowCellValue(e.ListSourceRowIndex, "tiposubsequente").ToString()
            Else
               strValor = e.Value.ToString
            End If
            e.DisplayText = DisplayComboBox(e.Column.FieldName, strValor)
         ElseIf e.Column.FieldName = "sabdomutil" Then
            If obrigacoescprGridView.GetRowCellValue(e.ListSourceRowIndex, "sabdomutil") IsNot Nothing Then
               strValor = obrigacoescprGridView.GetRowCellValue(e.ListSourceRowIndex, "sabdomutil").ToString()
            Else
               strValor = e.Value.ToString
            End If

            If strValor.EndsWith("0") Then
               e.DisplayText = "Não"
            ElseIf strValor.EndsWith("-1") Then
               e.DisplayText = "Sim"
            End If
         ElseIf e.Column.FieldName = "antecipautil" Then
            If obrigacoescprGridView.GetRowCellValue(e.ListSourceRowIndex, "antecipautil") IsNot Nothing Then
               strValor = obrigacoescprGridView.GetRowCellValue(e.ListSourceRowIndex, "antecipautil").ToString()
            Else
               strValor = e.Value.ToString
            End If

            If strValor.EndsWith("0") Then
               e.DisplayText = "Não"
            ElseIf strValor.EndsWith("-1") Then
               e.DisplayText = "Sim"
            End If
         End If
      Catch ex As Exception
         XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
   End Sub

   Private Sub obrigacoescnpjGridView_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles obrigacoescnpjGridView.CustomColumnDisplayText
      Try
         Dim strValor As String = String.Empty

         If e.Column.FieldName = "periodicidade" Then
            If obrigacoescnpjGridView.GetRowCellValue(e.ListSourceRowIndex, "periodicidade") IsNot Nothing Then
               strValor = obrigacoescnpjGridView.GetRowCellValue(e.ListSourceRowIndex, "periodicidade").ToString()
            Else
               strValor = e.Value.ToString
            End If
            e.DisplayText = DisplayComboBox(e.Column.FieldName, strValor)
         ElseIf e.Column.FieldName = "tipodia" Then
            If obrigacoescnpjGridView.GetRowCellValue(e.ListSourceRowIndex, "tipodia") IsNot Nothing Then
               strValor = obrigacoescnpjGridView.GetRowCellValue(e.ListSourceRowIndex, "tipodia").ToString()
            Else
               strValor = e.Value.ToString
            End If
            e.DisplayText = DisplayComboBox(e.Column.FieldName, strValor)
         ElseIf e.Column.FieldName = "tributo" Then
            If obrigacoescnpjGridView.GetRowCellValue(e.ListSourceRowIndex, "tributo") IsNot Nothing Then
               strValor = obrigacoescnpjGridView.GetRowCellValue(e.ListSourceRowIndex, "tributo").ToString()
            Else
               strValor = e.Value.ToString
            End If
            e.DisplayText = DisplayComboBox(e.Column.FieldName, strValor)
         ElseIf e.Column.FieldName = "tiposubsequente" Then
            If obrigacoescnpjGridView.GetRowCellValue(e.ListSourceRowIndex, "tiposubsequente") IsNot Nothing Then
               strValor = obrigacoescnpjGridView.GetRowCellValue(e.ListSourceRowIndex, "tiposubsequente").ToString()
            Else
               strValor = e.Value.ToString
            End If
            e.DisplayText = DisplayComboBox(e.Column.FieldName, strValor)
         ElseIf e.Column.FieldName = "sabdomutil" Then
            If obrigacoescnpjGridView.GetRowCellValue(e.ListSourceRowIndex, "sabdomutil") IsNot Nothing Then
               strValor = obrigacoescnpjGridView.GetRowCellValue(e.ListSourceRowIndex, "sabdomutil").ToString()
            Else
               strValor = e.Value.ToString
            End If

            If strValor.EndsWith("0") Then
               e.DisplayText = "Não"
            ElseIf strValor.EndsWith("-1") Then
               e.DisplayText = "Sim"
            End If
         ElseIf e.Column.FieldName = "antecipautil" Then
            If obrigacoescnpjGridView.GetRowCellValue(e.ListSourceRowIndex, "antecipautil") IsNot Nothing Then
               strValor = obrigacoescnpjGridView.GetRowCellValue(e.ListSourceRowIndex, "antecipautil").ToString()
            Else
               strValor = e.Value.ToString
            End If

            If strValor.EndsWith("0") Then
               e.DisplayText = "Não"
            ElseIf strValor.EndsWith("-1") Then
               e.DisplayText = "Sim"
            End If
         End If
      Catch ex As Exception
         XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
   End Sub

   Private Sub obrigacoeseissGridView_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles obrigacoeseissGridView.CustomColumnDisplayText
      Try
         Dim strValor As String = String.Empty

         If e.Column.FieldName = "periodicidade" Then
            If obrigacoeseissGridView.GetRowCellValue(e.ListSourceRowIndex, "periodicidade") IsNot Nothing Then
               strValor = obrigacoeseissGridView.GetRowCellValue(e.ListSourceRowIndex, "periodicidade").ToString()
            Else
               strValor = e.Value.ToString
            End If
            e.DisplayText = DisplayComboBox(e.Column.FieldName, strValor)
         ElseIf e.Column.FieldName = "tipodia" Then
            If obrigacoeseissGridView.GetRowCellValue(e.ListSourceRowIndex, "tipodia") IsNot Nothing Then
               strValor = obrigacoeseissGridView.GetRowCellValue(e.ListSourceRowIndex, "tipodia").ToString()
            Else
               strValor = e.Value.ToString
            End If
            e.DisplayText = DisplayComboBox(e.Column.FieldName, strValor)
         ElseIf e.Column.FieldName = "tributo" Then
            If obrigacoeseissGridView.GetRowCellValue(e.ListSourceRowIndex, "tributo") IsNot Nothing Then
               strValor = obrigacoeseissGridView.GetRowCellValue(e.ListSourceRowIndex, "tributo").ToString()
            Else
               strValor = e.Value.ToString
            End If
            e.DisplayText = DisplayComboBox(e.Column.FieldName, strValor)
         ElseIf e.Column.FieldName = "tiposubsequente" Then
            If obrigacoeseissGridView.GetRowCellValue(e.ListSourceRowIndex, "tiposubsequente") IsNot Nothing Then
               strValor = obrigacoeseissGridView.GetRowCellValue(e.ListSourceRowIndex, "tiposubsequente").ToString()
            Else
               strValor = e.Value.ToString
            End If
            e.DisplayText = DisplayComboBox(e.Column.FieldName, strValor)
         ElseIf e.Column.FieldName = "sabdomutil" Then
            If obrigacoeseissGridView.GetRowCellValue(e.ListSourceRowIndex, "sabdomutil") IsNot Nothing Then
               strValor = obrigacoeseissGridView.GetRowCellValue(e.ListSourceRowIndex, "sabdomutil").ToString()
            Else
               strValor = e.Value.ToString
            End If

            If strValor.EndsWith("0") Then
               e.DisplayText = "Não"
            ElseIf strValor.EndsWith("-1") Then
               e.DisplayText = "Sim"
            End If
         ElseIf e.Column.FieldName = "antecipautil" Then
            If obrigacoeseissGridView.GetRowCellValue(e.ListSourceRowIndex, "antecipautil") IsNot Nothing Then
               strValor = obrigacoeseissGridView.GetRowCellValue(e.ListSourceRowIndex, "antecipautil").ToString()
            Else
               strValor = e.Value.ToString
            End If

            If strValor.EndsWith("0") Then
               e.DisplayText = "Não"
            ElseIf strValor.EndsWith("-1") Then
               e.DisplayText = "Sim"
            End If
         End If
      Catch ex As Exception
         XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
   End Sub

   Private Sub obrigacoesieGridView_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles obrigacoesieGridView.CustomColumnDisplayText
      Try
         Dim strValor As String = String.Empty

         If e.Column.FieldName = "periodicidade" Then
            If obrigacoesieGridView.GetRowCellValue(e.ListSourceRowIndex, "periodicidade") IsNot Nothing Then
               strValor = obrigacoesieGridView.GetRowCellValue(e.ListSourceRowIndex, "periodicidade").ToString()
            Else
               strValor = e.Value.ToString
            End If
            e.DisplayText = DisplayComboBox(e.Column.FieldName, strValor)
         ElseIf e.Column.FieldName = "tipodia" Then
            If obrigacoesieGridView.GetRowCellValue(e.ListSourceRowIndex, "tipodia") IsNot Nothing Then
               strValor = obrigacoesieGridView.GetRowCellValue(e.ListSourceRowIndex, "tipodia").ToString()
            Else
               strValor = e.Value.ToString
            End If
            e.DisplayText = DisplayComboBox(e.Column.FieldName, strValor)
         ElseIf e.Column.FieldName = "tributo" Then
            If obrigacoesieGridView.GetRowCellValue(e.ListSourceRowIndex, "tributo") IsNot Nothing Then
               strValor = obrigacoesieGridView.GetRowCellValue(e.ListSourceRowIndex, "tributo").ToString()
            Else
               strValor = e.Value.ToString
            End If
            e.DisplayText = DisplayComboBox(e.Column.FieldName, strValor)
         ElseIf e.Column.FieldName = "tiposubsequente" Then
            If obrigacoesieGridView.GetRowCellValue(e.ListSourceRowIndex, "tiposubsequente") IsNot Nothing Then
               strValor = obrigacoesieGridView.GetRowCellValue(e.ListSourceRowIndex, "tiposubsequente").ToString()
            Else
               strValor = e.Value.ToString
            End If
            e.DisplayText = DisplayComboBox(e.Column.FieldName, strValor)
         ElseIf e.Column.FieldName = "sabdomutil" Then
            If obrigacoesieGridView.GetRowCellValue(e.ListSourceRowIndex, "sabdomutil") IsNot Nothing Then
               strValor = obrigacoesieGridView.GetRowCellValue(e.ListSourceRowIndex, "sabdomutil").ToString()
            Else
               strValor = e.Value.ToString
            End If

            If strValor.EndsWith("0") Then
               e.DisplayText = "Não"
            ElseIf strValor.EndsWith("-1") Then
               e.DisplayText = "Sim"
            End If
         ElseIf e.Column.FieldName = "antecipautil" Then
            If obrigacoesieGridView.GetRowCellValue(e.ListSourceRowIndex, "antecipautil") IsNot Nothing Then
               strValor = obrigacoesieGridView.GetRowCellValue(e.ListSourceRowIndex, "antecipautil").ToString()
            Else
               strValor = e.Value.ToString
            End If

            If strValor.EndsWith("0") Then
               e.DisplayText = "Não"
            ElseIf strValor.EndsWith("-1") Then
               e.DisplayText = "Sim"
            End If
         End If
      Catch ex As Exception
         XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
   End Sub

   Private Sub obrigacoesissGridView_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles obrigacoesissGridView.CustomColumnDisplayText
      Try
         Dim strValor As String = String.Empty

         If e.Column.FieldName = "periodicidade" Then
            If obrigacoesissGridView.GetRowCellValue(e.ListSourceRowIndex, "periodicidade") IsNot Nothing Then
               strValor = obrigacoesissGridView.GetRowCellValue(e.ListSourceRowIndex, "periodicidade").ToString()
            Else
               strValor = e.Value.ToString
            End If
            e.DisplayText = DisplayComboBox(e.Column.FieldName, strValor)
         ElseIf e.Column.FieldName = "tipodia" Then
            If obrigacoesissGridView.GetRowCellValue(e.ListSourceRowIndex, "tipodia") IsNot Nothing Then
               strValor = obrigacoesissGridView.GetRowCellValue(e.ListSourceRowIndex, "tipodia").ToString()
            Else
               strValor = e.Value.ToString
            End If
            e.DisplayText = DisplayComboBox(e.Column.FieldName, strValor)
         ElseIf e.Column.FieldName = "tributo" Then
            If obrigacoesissGridView.GetRowCellValue(e.ListSourceRowIndex, "tributo") IsNot Nothing Then
               strValor = obrigacoesissGridView.GetRowCellValue(e.ListSourceRowIndex, "tributo").ToString()
            Else
               strValor = e.Value.ToString
            End If
            e.DisplayText = DisplayComboBox(e.Column.FieldName, strValor)
         ElseIf e.Column.FieldName = "tiposubsequente" Then
            If obrigacoesissGridView.GetRowCellValue(e.ListSourceRowIndex, "tiposubsequente") IsNot Nothing Then
               strValor = obrigacoesissGridView.GetRowCellValue(e.ListSourceRowIndex, "tiposubsequente").ToString()
            Else
               strValor = e.Value.ToString
            End If
            e.DisplayText = DisplayComboBox(e.Column.FieldName, strValor)
         ElseIf e.Column.FieldName = "sabdomutil" Then
            If obrigacoesissGridView.GetRowCellValue(e.ListSourceRowIndex, "sabdomutil") IsNot Nothing Then
               strValor = obrigacoesissGridView.GetRowCellValue(e.ListSourceRowIndex, "sabdomutil").ToString()
            Else
               strValor = e.Value.ToString
            End If

            If strValor.EndsWith("0") Then
               e.DisplayText = "Não"
            ElseIf strValor.EndsWith("-1") Then
               e.DisplayText = "Sim"
            End If
         ElseIf e.Column.FieldName = "antecipautil" Then
            If obrigacoesissGridView.GetRowCellValue(e.ListSourceRowIndex, "antecipautil") IsNot Nothing Then
               strValor = obrigacoesissGridView.GetRowCellValue(e.ListSourceRowIndex, "antecipautil").ToString()
            Else
               strValor = e.Value.ToString
            End If

            If strValor.EndsWith("0") Then
               e.DisplayText = "Não"
            ElseIf strValor.EndsWith("-1") Then
               e.DisplayText = "Sim"
            End If
         End If
      Catch ex As Exception
         XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
   End Sub

   Private Sub tipodiaComboBoxEdit_CustomDisplayText(sender As System.Object, e As DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs) Handles tipodiaComboBoxEdit.CustomDisplayText
      If Not tipodiaComboBoxEdit.EditValue Is Nothing Then
         If Not String.IsNullOrEmpty(tipodiaComboBoxEdit.EditValue.ToString) Then
            sabdomutilCheckEdit.Enabled = Not (tipodiaComboBoxEdit.EditValue.ToString = "Dia Útil")
            If Not sabdomutilCheckEdit.Enabled Then
               sabdomutilCheckEdit.Checked = False
            End If
         End If
      Else
         sabdomutilCheckEdit.Enabled = False
         sabdomutilCheckEdit.Checked = False
      End If
   End Sub

   Private Sub incluirBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles incluirBarButtonItem.ItemClick
      Try
         okSimpleButton.Tag = "inclusao"
         HabilitaBotoes(okSimpleButton.Tag.ToString)
         obrigacoesSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
         blnCarregaVariacao = True
         descricaoTextEdit.Focus()
      Catch ex As Exception
         XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
   End Sub

   Private Sub alterarBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles alterarBarButtonItem.ItemClick
      Try
         okSimpleButton.Tag = "alteracao"
         CarregaDados(obrigacoesGridView)
      Catch ex As Exception
         XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
   End Sub

   Private Sub excluirBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles excluirBarButtonItem.ItemClick
      Try
         okSimpleButton.Tag = "exclusao"
         CarregaDados(obrigacoesGridView)
      Catch ex As Exception
         XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
   End Sub

   Private Sub localizarBarCheckItem_CheckedChanged(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles localizarBarCheckItem.CheckedChanged
      Try
         obrigacoesGridView.OptionsFind.AlwaysVisible = localizarBarCheckItem.Checked
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

   Private Sub incluirvencimentoporSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles incluirvencimentoporSimpleButton.Click
      Try
         confirmarvencimentoporSimpleButton.Tag = "inclusao"
         HabilitaBotoes(confirmarvencimentoporSimpleButton.Tag.ToString, vencimentoporGridView,
                           incluirvencimentoporSimpleButton, alterarvencimentoporSimpleButton, excluirvencimentoporSimpleButton, confirmarvencimentoporSimpleButton, voltarvencimentoporSimpleButton)
         vencimentoporSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1

         Dim strTipo As String = "item"
         If vencimentoporComboBoxEdit.EditValue.ToString = "por CPR" Then
            strTipo = "cpr"
         ElseIf vencimentoporComboBoxEdit.EditValue.ToString = "por IE" Then
            strTipo = "ie"
         ElseIf vencimentoporComboBoxEdit.EditValue.ToString = "por CNPJ" Then
            strTipo = "cnpj"
         ElseIf vencimentoporComboBoxEdit.EditValue.ToString = "por ISS" Then
            strTipo = "iss"
         ElseIf vencimentoporComboBoxEdit.EditValue.ToString = "por e-ISS" Then
            strTipo = "eiss"
         End If

         RedimensionaTela(strTipo, String.Empty)
         If strTipo <> "item" Then
            If strTipo = "cpr" Or strTipo = "iss" Or strTipo = "eiss" Then
               variacaoSearchLookUpEdit.Focus()
            Else
               variacaocodTextEdit.Focus()
            End If
         Else
            periodicidadeComboBoxEdit.Focus()
         End If
      Catch ex As Exception
         XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
   End Sub

   Private Sub alterarvencimentoporSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles alterarvencimentoporSimpleButton.Click
      Try
         confirmarvencimentoporSimpleButton.Tag = "alteracao"
         CarregaDados(vencimentoporGridView, incluirvencimentoporSimpleButton, alterarvencimentoporSimpleButton, excluirvencimentoporSimpleButton, confirmarvencimentoporSimpleButton, voltarvencimentoporSimpleButton)
      Catch ex As Exception
         XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
   End Sub

   Private Sub excluirvencimentoporSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles excluirvencimentoporSimpleButton.Click
      Try
         confirmarvencimentoporSimpleButton.Tag = "exclusao"
         CarregaDados(vencimentoporGridView, incluirvencimentoporSimpleButton, alterarvencimentoporSimpleButton, excluirvencimentoporSimpleButton, confirmarvencimentoporSimpleButton, voltarvencimentoporSimpleButton)
      Catch ex As Exception
         XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try

   End Sub

   Private Sub confirmarvencimentoporSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles confirmarvencimentoporSimpleButton.Click
      Try
         Dim strTipo As String = "item"
         If vencimentoporComboBoxEdit.EditValue.ToString = "por CPR" Then
            strTipo = "cpr"
         ElseIf vencimentoporComboBoxEdit.EditValue.ToString = "por IE" Then
            strTipo = "ie"
         ElseIf vencimentoporComboBoxEdit.EditValue.ToString = "por CNPJ" Then
            strTipo = "cnpj"
         ElseIf vencimentoporComboBoxEdit.EditValue.ToString = "por ISS" Then
            strTipo = "iss"
         ElseIf vencimentoporComboBoxEdit.EditValue.ToString = "por e-ISS" Then
            strTipo = "eiss"
         End If

         Dim strVariacao As String = String.Empty
         If strTipo <> "item" Then
            If strTipo = "cpr" Or strTipo = "iss" Or strTipo = "eiss" Then
               strVariacao = variacaoSearchLookUpEdit.EditValue.ToString()
            Else
               strVariacao = variacaocodTextEdit.Text
            End If
         End If
         VerificaDadosGravacao(strVariacao, confirmarvencimentoporSimpleButton)
         SetModelo(vencimentoporGridControl, confirmarvencimentoporSimpleButton)
         HabilitaBotoes(confirmarvencimentoporSimpleButton.Tag.ToString, vencimentoporGridView,
                           incluirvencimentoporSimpleButton, alterarvencimentoporSimpleButton, excluirvencimentoporSimpleButton, confirmarvencimentoporSimpleButton, voltarvencimentoporSimpleButton)
         vencimentoporSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
      Catch ex As Exception
         XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
   End Sub

   Private Sub voltarvencimentoporSimpleButton_Click(sender As System.Object, e As System.EventArgs) Handles voltarvencimentoporSimpleButton.Click
      Try
         LimpaDados(confirmarvencimentoporSimpleButton)
         HabilitaBotoes(confirmarvencimentoporSimpleButton.Tag.ToString, vencimentoporGridView,
                           incluirvencimentoporSimpleButton, alterarvencimentoporSimpleButton, excluirvencimentoporSimpleButton, confirmarvencimentoporSimpleButton, voltarvencimentoporSimpleButton)
         vencimentoporSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
      Catch ex As Exception
         XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
   End Sub

   Private Sub CarregaGrid()
      Try
         SplashScreenManager.ShowForm(Me, GetType(aguardeWaitForm), True, True, False)

         Dim strQuery() As String = {"", "", "", "", "", "", ""}
         Dim strTitulo() As String = {"Obrigações", "Item", "CPR", "ISS", "e-ISS", "IE", "CNPJ"}
         strQuery(0) = "select obr.obrigacao, obr.descricao, coalesce(obr.sistema,'') as sistema, " +
                              "case when obr.cpr = -1 then cast('cpr' as varchar) else " +
                              "case when obr.iss = -1 then cast('iss' as varchar) else " +
                              "case when obr.eiss = -1 then cast('eiss' as varchar) else " +
                              "case when obr.ie = -1 then cast('ie' as varchar) else " +
                              "case when obr.cnpj = -1 then cast('cnpj' as varchar) else cast('item' as varchar) end end end end end as tipo, obr.parcelamento, coalesce(obr.envioautomatico,0) as envioautomatico, coalesce(obr.usuarioenvio,'') as usuarioenvio " +
                            "from admobrigacoes obr " +
                        "order by obr.obrigacao"

         strQuery(1) = "select obr.obrigacao, obr.descricao, cast('item' as varchar) as tipo, obr.periodicidade, coalesce(obr.tipodia,'F') as tipodia, obr.vencimento, obr.tributo, obr.competenciaobsoleta, obr.subsequente, obr.tiposubsequente, obr.sabdomutil, obr.antecipautil, coalesce(obr.sistema,'') as sistema " +
                            "from admobrigacoes obr " +
                           "where obr.cpr = 0 and obr.iss = 0 and obr.eiss = 0 and obr.ie = 0 and obr.cnpj = 0 " +
                        "order by obr.obrigacao"

         strQuery(2) = "select cpr.obrigacao, obr.descricao, cast('cpr' as varchar) as tipo, cpr.cpr, cpr.periodicidade, coalesce(cpr.tipodia,'F') as tipodia, cpr.vencimento, cpr.tributo, cpr.competenciaobsoleta, cpr.subsequente, cpr.tiposubsequente, cpr.sabdomutil, cpr.antecipautil, coalesce(obr.sistema,'') as sistema " +
                            "from admobrigacoescpr cpr " +
                            "join admobrigacoes obr on obr.obrigacao = cpr.obrigacao " +
                        "order by cpr.obrigacao, cpr.cpr"

         strQuery(3) = "select iss.obrigacao, obr.descricao, cast('iss' as varchar) as tipo, iss.municipio, m.nome, iss.periodicidade, coalesce(iss.tipodia,'F') as tipodia, iss.vencimento, iss.tributo, iss.competenciaobsoleta, iss.subsequente, iss.tiposubsequente, iss.sabdomutil, iss.antecipautil, coalesce(obr.sistema,'') as sistema " +
                            "from admobrigacoesiss iss " +
                            "join admobrigacoes obr on obr.obrigacao = iss.obrigacao " +
                            "join municipios m on m.municipio = iss.municipio " +
                        "order by iss.obrigacao, iss.municipio"

         strQuery(4) = "select eiss.obrigacao, obr.descricao, cast('eiss' as varchar) as tipo, eiss.municipio, m.nome, eiss.periodicidade, coalesce(eiss.tipodia,'F') as tipodia, eiss.vencimento, eiss.tributo, eiss.competenciaobsoleta, eiss.subsequente, eiss.tiposubsequente, eiss.sabdomutil, eiss.antecipautil, coalesce(obr.sistema,'') as sistema " +
                            "from admobrigacoeseiss eiss " +
                            "join admobrigacoes obr on obr.obrigacao = eiss.obrigacao " +
                            "join municipios m on m.municipio = eiss.municipio " +
                        "order by eiss.obrigacao, eiss.municipio"

         strQuery(5) = "select ie.obrigacao, obr.descricao, cast('ie' as varchar) as tipo, ie.ie, ie.periodicidade, coalesce(ie.tipodia,'F') as tipodia, ie.vencimento, ie.tributo, ie.competenciaobsoleta, ie.subsequente, ie.tiposubsequente, ie.sabdomutil, ie.antecipautil, coalesce(obr.sistema,'') as sistema " +
                            "from admobrigacoesie ie " +
                            "join admobrigacoes obr on obr.obrigacao = ie.obrigacao " +
                        "order by ie.obrigacao, ie.ie"

         strQuery(6) = "select cnpj.obrigacao, obr.descricao, cast('cnpj' as varchar) as tipo, cnpj.cnpj, cnpj.periodicidade, coalesce(cnpj.tipodia,'F') as tipodia, cnpj.vencimento, cnpj.tributo, cnpj.competenciaobsoleta, cnpj.subsequente, cnpj.tiposubsequente, cnpj.sabdomutil, cnpj.antecipautil, coalesce(obr.sistema,'') as sistema " +
                            "from admobrigacoescnpj cnpj " +
                            "join admobrigacoes obr on obr.obrigacao = cnpj.obrigacao " +
                        "order by cnpj.obrigacao, cnpj.cnpj"

         objObrigacoes.Grid(strQuery, strTitulo, obrigacoesGridControl, obrigacoesGridView, obrigacoesitemGridView, obrigacoescprGridView, obrigacoesissGridView, obrigacoeseissGridView, obrigacoesieGridView, obrigacoescnpjGridView)

         CarregaOpcao()
         SplashScreenManager.CloseForm()
      Catch ex As Exception
         SplashScreenManager.CloseForm()
         XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
   End Sub

   Private Sub CarregaDados()
      periodicidadeComboBoxEdit.EditValue = DisplayComboBox("periodicidade", infovariacao(0).periodicidade.ToString)
      diavencimentoTextEdit.Text = infovariacao(0).vencimento.ToString()
      If Not String.IsNullOrEmpty(infovariacao(0).tipodia.ToString) Then
         tipodiaComboBoxEdit.EditValue = DisplayComboBox("tipodia", infovariacao(0).tipodia.ToString)
      End If
      tributoComboBoxEdit.EditValue = DisplayComboBox("tributo", infovariacao(0).tributo.ToString)
      If Not String.IsNullOrEmpty(infovariacao(0).competenciaobsoleta.ToString) Then
         competenciaobsoletaTextEdit.Text = infovariacao(0).competenciaobsoleta.ToString
      End If
      subsequenteTextEdit.Text = infovariacao(0).subsequente.ToString()
      If Not String.IsNullOrEmpty(infovariacao(0).tiposubsequente.ToString) Then
         tiposubsequenteComboBoxEdit.EditValue = DisplayComboBox("tiposubsequente", infovariacao(0).tiposubsequente.ToString)
      End If
      sabdomutilCheckEdit.Checked = Convert.ToBoolean(infovariacao(0).sabdomutil)
      antecipautilCheckEdit.Checked = Convert.ToBoolean(infovariacao(0).antecipautil)
   End Sub

   Private Sub CarregaDados(pgvGrid As GridView)
      Dim intLinha As Integer() = pgvGrid.GetSelectedRows()
      For i As Integer = 0 To intLinha.Length - 1
         If intLinha(i) >= 0 Then
            intLinhaRegistro = intLinha(i)
            obrigacaoTextEdit.Text = pgvGrid.GetRowCellValue(intLinha(i), "obrigacao").ToString()
            descricaoTextEdit.Text = pgvGrid.GetRowCellValue(intLinha(i), "descricao").ToString()
            parcelamentoCheckEdit.Checked = Convert.ToBoolean(pgvGrid.GetRowCellValue(intLinha(i), "parcelamento"))
            If Convert.ToBoolean(pgvGrid.GetRowCellValue(intLinha(i), "envioautomatico")) Then
               usuarioenvioSearchLookUpEdit.EditValue = pgvGrid.GetRowCellValue(intLinha(i), "usuarioenvio").ToString
            End If
            usuarioenvioLabelControl.Visible = Convert.ToBoolean(pgvGrid.GetRowCellValue(intLinha(i), "envioautomatico"))
            usuarioenvioSearchLookUpEdit.Visible = Convert.ToBoolean(pgvGrid.GetRowCellValue(intLinha(i), "envioautomatico"))
            nomeenvioTextEdit.Visible = Convert.ToBoolean(pgvGrid.GetRowCellValue(intLinha(i), "envioautomatico"))
            sistemaComboBoxEdit.EditValue = DisplayComboBox("sistema", pgvGrid.GetRowCellValue(intLinha(i), "sistema").ToString())
            Dim strTipo As String = pgvGrid.GetRowCellValue(intLinha(i), "tipo").ToString()
            vencimentoporComboBoxEdit.EditValue = DisplayComboBox("tipo", strTipo)
            HabilitaBotoes(okSimpleButton.Tag.ToString)
            obrigacoesSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
            descricaoTextEdit.Focus()
         End If
      Next
   End Sub

   Private Sub CarregaDados(pgvGrid As GridView, incluirbutton As SimpleButton, alterarbutton As SimpleButton, excluirbutton As SimpleButton,
                             confirmarbutton As SimpleButton, voltarbutton As SimpleButton)
      Dim intLinha As Integer() = pgvGrid.GetSelectedRows()
      For i As Integer = 0 To intLinha.Length - 1
         If intLinha(i) >= 0 Then
            Dim strTipo As String = "item"
            If vencimentoporComboBoxEdit.EditValue.ToString = "por CPR" Then
               strTipo = "cpr"
            ElseIf vencimentoporComboBoxEdit.EditValue.ToString = "por IE" Then
               strTipo = "ie"
            ElseIf vencimentoporComboBoxEdit.EditValue.ToString = "por CNPJ" Then
               strTipo = "cnpj"
            ElseIf vencimentoporComboBoxEdit.EditValue.ToString = "por ISS" Then
               strTipo = "iss"
            ElseIf vencimentoporComboBoxEdit.EditValue.ToString = "por e-ISS" Then
               strTipo = "eiss"
            End If

            periodicidadeComboBoxEdit.EditValue = DisplayComboBox("periodicidade", pgvGrid.GetRowCellValue(intLinha(i), "periodicidade").ToString())
            diavencimentoTextEdit.Text = pgvGrid.GetRowCellValue(intLinha(i), "vencimento").ToString()
            If pgvGrid.GetRowCellValue(intLinha(i), "tipodia") IsNot Nothing Then
               tipodiaComboBoxEdit.EditValue = DisplayComboBox("tipodia", pgvGrid.GetRowCellValue(intLinha(i), "tipodia").ToString())
            End If
            tributoComboBoxEdit.EditValue = DisplayComboBox("tributo", pgvGrid.GetRowCellValue(intLinha(i), "tributo").ToString())
            If pgvGrid.GetRowCellValue(intLinha(i), "competenciaobsoleta") IsNot Nothing Then
               competenciaobsoletaTextEdit.Text = pgvGrid.GetRowCellValue(intLinha(i), "competenciaobsoleta").ToString()
            End If
            subsequenteTextEdit.Text = pgvGrid.GetRowCellValue(intLinha(i), "subsequente").ToString()
            If pgvGrid.GetRowCellValue(intLinha(i), "tiposubsequente") IsNot Nothing Then
               tiposubsequenteComboBoxEdit.EditValue = DisplayComboBox("tiposubsequente", pgvGrid.GetRowCellValue(intLinha(i), "tiposubsequente").ToString())
            End If
            sabdomutilCheckEdit.Checked = Convert.ToBoolean(pgvGrid.GetRowCellValue(intLinha(i), "sabdomutil"))
            antecipautilCheckEdit.Checked = Convert.ToBoolean(pgvGrid.GetRowCellValue(intLinha(i), "antecipautil"))

            HabilitaBotoes(confirmarbutton.Tag.ToString, pgvGrid, incluirbutton, alterarbutton, excluirbutton, confirmarbutton, voltarbutton)
            vencimentoporSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1

            Dim strVariacao As String = String.Empty
            strVariacao = pgvGrid.GetRowCellValue(intLinha(i), "variacao").ToString()
            RetornaIndexRegistro(strVariacao)
            RedimensionaTela(strTipo, strVariacao)

            periodicidadeComboBoxEdit.Focus()
         End If
      Next
   End Sub

   Private Sub CarregaOpcao()
      Dim infoGrupoAcesso As New usuariogruposacessoInfo
      Dim objUsuario As New UsuarioBLL
      infoGrupoAcesso = objUsuario.RetornaGrupoAcessoUsuario("cadobr")

      If obrigacaoRibbonControl.Items.Count > 0 Then
         For index = 0 To obrigacaoRibbonControl.Items.Count - 1
            If obrigacaoRibbonControl.Items(index).Tag IsNot Nothing Then
               If objUsuario.UsuarioTemAcesso(infoGrupoAcesso, obrigacaoRibbonControl.Items(index).Tag.ToString) Then
                  obrigacaoRibbonControl.Items(index).Visibility = DevExpress.XtraBars.BarItemVisibility.Always
               Else
                  obrigacaoRibbonControl.Items(index).Visibility = DevExpress.XtraBars.BarItemVisibility.Never
               End If
            End If
         Next
      End If
   End Sub

   Private Sub HabilitaBotoes(pstrOperacao As String)
      incluirBarButtonItem.Enabled = (pstrOperacao = String.Empty)
      localizarBarCheckItem.Enabled = (pstrOperacao = String.Empty)
      atualizarBarButtonItem.Enabled = (pstrOperacao = String.Empty)
      alterarBarButtonItem.Enabled = (pstrOperacao = String.Empty And obrigacoesGridView.RowCount > 0)
      excluirBarButtonItem.Enabled = (pstrOperacao = String.Empty And obrigacoesGridView.RowCount > 0)
      vencimentoporComboBoxEdit.Enabled = (okSimpleButton.Tag.ToString = "inclusao")
      sistemaComboBoxEdit.Enabled = (okSimpleButton.Tag.ToString = "inclusao" Or String.IsNullOrEmpty(portalservidorInfo.cnpjcpf))
      If okSimpleButton.Tag.ToString = "exclusao" Then
         okSimpleButton.Text = "Excluir"
         okSimpleButton.ImageIndex = 1
      Else
         okSimpleButton.Text = "OK"
         okSimpleButton.ImageIndex = 0
         If okSimpleButton.Tag.ToString = "inclusao" Then
            variacaoGroupControl.Visible = False
            variacaocodTextEdit.Visible = False
            variacaodescTextEdit.Visible = False
            variacaoSearchLookUpEdit.Visible = False
            vencimentoporComboBoxEdit.EditValue = DisplayComboBox("tipo", "item")
         End If
      End If

      If Not String.IsNullOrEmpty(pstrOperacao) Then
         infoobrigacoes = New obrigacoesInfo
         infoobrigacoes.obrigacao = String.Empty
         If okSimpleButton.Tag.ToString <> "inclusao" Then
            infoobrigacoes.obrigacao = obrigacaoTextEdit.EditValue.ToString
         End If
         infoobrigacoes.descricao = descricaoTextEdit.Text
         infoobrigacoes.sistema = String.Empty
         If Not String.IsNullOrEmpty(sistemaComboBoxEdit.Text) Then
            infoobrigacoes.sistema = sistemaComboBoxEdit.Text.ToUpper.Substring(9, 3)
         End If
         HabilitaVencimentoPor()
      End If
      If okSimpleButton.Tag.ToString <> String.Empty Then
         Me.AcceptButton = okSimpleButton
      End If
   End Sub

   Private Sub HabilitaBotoes(pstrOperacao As String, pgvItens As GridView,
                               incluirbutton As SimpleButton, alterarbutton As SimpleButton, excluirbutton As SimpleButton,
                               confirmarbutton As SimpleButton, voltarbutton As SimpleButton)
      incluirbutton.Enabled = (pstrOperacao = String.Empty And okSimpleButton.Tag.ToString <> "exclusao")
      alterarbutton.Enabled = (pstrOperacao = String.Empty And pgvItens.RowCount > 0)
      excluirbutton.Enabled = (pstrOperacao = String.Empty And pgvItens.RowCount > 0 And okSimpleButton.Tag.ToString <> "exclusao")
      confirmarbutton.Enabled = (pstrOperacao <> String.Empty And okSimpleButton.Tag.ToString <> "exclusao")
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

   Private Sub HabilitaVencimentoPor()
      Dim strVariacao As String = String.Empty
      Dim strQuery As String = String.Empty
      If vencimentoporComboBoxEdit.EditValue.ToString = "Não tem" Then
         strVariacao = "item"
         strQuery = "select cast('' as varchar) as variacao, cast('' as varchar) as nomevariacao, coalesce(obr.periodicidade,'') as periodicidade, coalesce(obr.tipodia,'F') as tipodia, obr.vencimento, coalesce(obr.tributo,'') as tributo, obr.competenciaobsoleta, obr.subsequente, coalesce(obr.tiposubsequente,'') as tiposubsequente, obr.sabdomutil, obr.antecipautil, cast('item' as varchar) as tipo " +
                         "from admobrigacoes obr " +
                        "where obr.obrigacao = '" + infoobrigacoes.obrigacao.ToString + "' " +
                          "and obr.cpr = 0 and obr.iss = 0 and obr.eiss = 0 and obr.ie = 0 and obr.cnpj = 0 " +
                     "order by obr.obrigacao"
      ElseIf vencimentoporComboBoxEdit.EditValue.ToString = "por CPR" Then
         strVariacao = "cpr"
         strQuery = "select cast(cpr.cpr as varchar) as variacao, cast('' as varchar) as nomevariacao, coalesce(cpr.periodicidade,'') as periodicidade, coalesce(cpr.tipodia,'F') as tipodia, cpr.vencimento, coalesce(cpr.tributo,'') as tributo, cpr.competenciaobsoleta, cpr.subsequente, coalesce(cpr.tiposubsequente,'') as tiposubsequente, cpr.sabdomutil, cpr.antecipautil, cast('cpr' as varchar) as tipo " +
                         "from admobrigacoescpr cpr " +
                         "join admobrigacoes obr on obr.obrigacao = cpr.obrigacao " +
                        "where cpr.obrigacao = '" + infoobrigacoes.obrigacao.ToString + "' " +
                     "order by cpr.obrigacao, cpr.cpr"
      ElseIf vencimentoporComboBoxEdit.EditValue.ToString = "por IE" Then
         strVariacao = "ie"
         strQuery = "select cast(ie.ie as varchar) as variacao, cast('' as varchar) as nomevariacao, coalesce(ie.periodicidade,'') as periodicidade, coalesce(ie.tipodia,'F') as tipodia, ie.vencimento, coalesce(ie.tributo,'') as tributo, ie.competenciaobsoleta, ie.subsequente, coalesce(ie.tiposubsequente,'') as tiposubsequente, ie.sabdomutil, ie.antecipautil, cast('ie' as varchar) as tipo " +
                         "from admobrigacoesie ie " +
                         "join admobrigacoes obr on obr.obrigacao = ie.obrigacao " +
                        "where ie.obrigacao = '" + infoobrigacoes.obrigacao.ToString + "' " +
                     "order by ie.obrigacao, ie.ie"
      ElseIf vencimentoporComboBoxEdit.EditValue.ToString = "por CNPJ" Then
         strVariacao = "cnpj"
         strQuery = "select cast(cnpj.cnpj as varchar) as variacao, cast('' as varchar) as nomevariacao, coalesce(cnpj.periodicidade,'') as periodicidade, coalesce(cnpj.tipodia,'F') as tipodia, cnpj.vencimento, coalesce(cnpj.tributo,'') as tributo, cnpj.competenciaobsoleta, cnpj.subsequente, coalesce(cnpj.tiposubsequente,'') as tiposubsequente, cnpj.sabdomutil, cnpj.antecipautil, cast('cnpj' as varchar) as tipo " +
                         "from admobrigacoescnpj cnpj " +
                         "join admobrigacoes obr on obr.obrigacao = cnpj.obrigacao " +
                        "where cnpj.obrigacao = '" + infoobrigacoes.obrigacao.ToString + "' " +
                     "order by cnpj.obrigacao, cnpj.cnpj"
      ElseIf vencimentoporComboBoxEdit.EditValue.ToString = "por ISS" Then
         strVariacao = "iss"
         strQuery = "select cast(iss.municipio as varchar) as variacao, cast(m.nome as varchar) as nomevariacao, coalesce(iss.periodicidade,'') as periodicidade, coalesce(iss.tipodia,'F') as tipodia, iss.vencimento, coalesce(iss.tributo,'') as tributo, iss.competenciaobsoleta, iss.subsequente, coalesce(iss.tiposubsequente,'') as tiposubsequente, iss.sabdomutil, iss.antecipautil, cast('iss' as varchar) as tipo " +
                         "from admobrigacoesiss iss " +
                         "join admobrigacoes obr on obr.obrigacao = iss.obrigacao " +
                         "join municipios m on m.municipio = iss.municipio " +
                        "where iss.obrigacao = '" + infoobrigacoes.obrigacao.ToString + "' " +
                     "order by iss.obrigacao, iss.municipio"
      ElseIf vencimentoporComboBoxEdit.EditValue.ToString = "por e-ISS" Then
         strVariacao = "eiss"
         strQuery = "select cast(eiss.municipio as varchar) as variacao, cast(m.nome as varchar) as nomevariacao, coalesce(eiss.periodicidade,'') as periodicidade, coalesce(eiss.tipodia,'F') as tipodia, eiss.vencimento, coalesce(eiss.tributo,'') as tributo, eiss.competenciaobsoleta, eiss.subsequente, coalesce(eiss.tiposubsequente,'') as tiposubsequente, eiss.sabdomutil, eiss.antecipautil, cast('eiss' as varchar) as tipo " +
                         "from admobrigacoeseiss eiss " +
                         "join admobrigacoes obr on obr.obrigacao = eiss.obrigacao " +
                         "join municipios m on m.municipio = eiss.municipio " +
                        "where eiss.obrigacao = '" + infoobrigacoes.obrigacao.ToString + "' " +
                     "order by eiss.obrigacao, eiss.municipio"
      End If
      If Not String.IsNullOrEmpty(strVariacao) Then
         infovariacao = New List(Of obrigacoesvariacao)
         objObrigacoes.Grid(strQuery, vencimentoporGridControl, vencimentoporGridView, infovariacao, strVariacao)
         infoobrigacoes.variacao = infovariacao
         originalinfovariacao = New List(Of obrigacoesvariacao)
         For index = 0 To infovariacao.Count - 1
            Dim variacaoinfo As New obrigacoesvariacao(infovariacao(index).variacao.ToString, infovariacao(index).nomevariacao.ToString, infovariacao(index).periodicidade.ToString,
                                                           infovariacao(index).tipodia.ToString, infovariacao(index).vencimento, infovariacao(index).tributo.ToString,
                                                           infovariacao(index).competenciaobsoleta.ToString, infovariacao(index).subsequente, infovariacao(index).tiposubsequente.ToString,
                                                           infovariacao(index).sabdomutil, infovariacao(index).antecipautil)
            originalinfovariacao.Add(variacaoinfo)
         Next

         If strVariacao = "item" Then
            If infovariacao.Count > 0 Then
               CarregaDados()
            End If
         Else
            vencimentoporSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
            HabilitaBotoes(String.Empty, vencimentoporGridView,
                               incluirvencimentoporSimpleButton, alterarvencimentoporSimpleButton, excluirvencimentoporSimpleButton, confirmarvencimentoporSimpleButton, voltarvencimentoporSimpleButton)
         End If
      End If
   End Sub

   Private Sub LimpaDados()
      infoobrigacoes = Nothing
      obrigacaoTextEdit.EditValue = String.Empty
      descricaoTextEdit.Text = String.Empty
      parcelamentoCheckEdit.Checked = False
      usuarioenvioSearchLookUpEdit.EditValue = String.Empty
      sistemaComboBoxEdit.EditValue = String.Empty
      vencimentoporComboBoxEdit.EditValue = String.Empty
      vencimentoporGridControl.DataSource = Nothing
      infovariacao = Nothing
      originalinfovariacao = Nothing
      LimpaDados(confirmarvencimentoporSimpleButton)
      If vencimentoporSplitContainerControl.PanelVisibility = SplitPanelVisibility.Panel1 Then
         vencimentoporSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
      End If
      okSimpleButton.Tag = String.Empty
      Me.AcceptButton = Nothing
      intLinhaRegistro = 0
      blnCarregaVariacao = False
      HabilitaBotoes(okSimpleButton.Tag.ToString)
   End Sub

   Private Sub LimpaDados(confirmarbutton As SimpleButton)
      periodicidadeComboBoxEdit.EditValue = String.Empty
      diavencimentoTextEdit.Text = String.Empty
      tipodiaComboBoxEdit.EditValue = String.Empty
      tributoComboBoxEdit.EditValue = String.Empty
      competenciaobsoletaTextEdit.Text = String.Empty
      sabdomutilCheckEdit.Checked = False
      antecipautilCheckEdit.Checked = False
      subsequenteTextEdit.Text = String.Empty
      tiposubsequenteComboBoxEdit.EditValue = String.Empty
      variacaoSearchLookUpEdit.EditValue = String.Empty
      variacaocodTextEdit.Text = String.Empty
      variacaodescTextEdit.Text = String.Empty
      intLinhaSubRegistro = -1
      confirmarbutton.Tag = String.Empty
   End Sub

   Private Sub SetModelo(pstrOperacao As String)
      Try
         SplashScreenManager.ShowForm(Me, GetType(aguardeWaitForm), True, True, False)
         If pstrOperacao = "inclusao" Then
            infoobrigacoes.obrigacao = objObrigacoes.ProximaObrigacao()
         Else
            infoobrigacoes.obrigacao = obrigacaoTextEdit.Text
         End If

         infoobrigacoes.descricao = descricaoTextEdit.Text
         infoobrigacoes.sistema = String.Empty
         infoobrigacoes.parcelamento = 0
         If parcelamentoCheckEdit.Checked Then
            infoobrigacoes.parcelamento = -1
         End If
         If Not String.IsNullOrEmpty(sistemaComboBoxEdit.Text) Then
            infoobrigacoes.sistema = sistemaComboBoxEdit.Text.ToUpper.Substring(9, 3)
         End If
         infoobrigacoes.envioautomatico = 0
         infoobrigacoes.usuarioenvio = String.Empty
         If usuarioenvioSearchLookUpEdit.Visible Then
            infoobrigacoes.envioautomatico = -1
            If Not usuarioenvioSearchLookUpEdit.EditValue Is Nothing Then
               infoobrigacoes.usuarioenvio = usuarioenvioSearchLookUpEdit.EditValue.ToString
            End If
         End If
         Dim strTipo As String = "item"
         If vencimentoporComboBoxEdit.EditValue.ToString = "por CPR" Then
            strTipo = "cpr"
         ElseIf vencimentoporComboBoxEdit.EditValue.ToString = "por IE" Then
            strTipo = "ie"
         ElseIf vencimentoporComboBoxEdit.EditValue.ToString = "por CNPJ" Then
            strTipo = "cnpj"
         ElseIf vencimentoporComboBoxEdit.EditValue.ToString = "por ISS" Then
            strTipo = "iss"
         ElseIf vencimentoporComboBoxEdit.EditValue.ToString = "por e-ISS" Then
            strTipo = "eiss"
         End If

         infoobrigacoes.cpr = (strTipo = "cpr")
         infoobrigacoes.ie = (strTipo = "ie")
         infoobrigacoes.cnpj = (strTipo = "cnpj")
         infoobrigacoes.iss = (strTipo = "iss")
         infoobrigacoes.eiss = (strTipo = "eiss")
         If strTipo = "item" Then
            intLinhaSubRegistro = 0
            SetModelo(vencimentoporGridControl, okSimpleButton)
         End If
         infoobrigacoes.variacao = infovariacao
         objObrigacoes.IUDObrigacoes(pstrOperacao, infoobrigacoes, originalinfovariacao)
         SplashScreenManager.CloseForm()
         RetornaGridFocu()
         LimpaDados()
      Catch ex As Exception
         SplashScreenManager.CloseForm()
         Throw New Exception(ex.Message)
      End Try
   End Sub

   Private Sub SetModelo(pdgGrid As GridControl, confirmarbutton As SimpleButton)
      If confirmarbutton.Tag.ToString <> "exclusao" Then
         Dim strPeriodicidade As String = String.Empty
         If Not String.IsNullOrEmpty(periodicidadeComboBoxEdit.Text) Then
            Dim intIndex As Int32 = 0
            If periodicidadeComboBoxEdit.Text.ToUpper = "DIÁRIA" Then
               intIndex = 1
            End If
            strPeriodicidade = periodicidadeComboBoxEdit.Text.ToUpper.Substring(intIndex, 1)
         End If
         Dim intVencimento As Int32
         If Not String.IsNullOrEmpty(diavencimentoTextEdit.Text) Then
            intVencimento = Convert.ToInt32(diavencimentoTextEdit.Text)
         End If
         Dim strTipoDia As String = String.Empty
         strTipoDia = String.Empty
         If Not String.IsNullOrEmpty(tipodiaComboBoxEdit.Text) Then
            If tipodiaComboBoxEdit.Text.Substring(4, 1) = "F" Then
               strTipoDia = tipodiaComboBoxEdit.Text.Substring(4, 1)
            Else
               strTipoDia = "U"
            End If
         End If
         Dim strTributo As String = String.Empty
         strTributo = String.Empty
         If Not String.IsNullOrEmpty(tributoComboBoxEdit.Text) Then
            strTributo = tributoComboBoxEdit.Text.Substring(0, 1)
         End If
         Dim strCompetenciaObsoleta As String = String.Empty
         If Not competenciaobsoletaTextEdit.EditValue Is Nothing Then
            strCompetenciaObsoleta = competenciaobsoletaTextEdit.EditValue.ToString.Replace("_", String.Empty).Replace("/", String.Empty)
         End If
         Dim intSubsequente As Int32
         If Not String.IsNullOrEmpty(subsequenteTextEdit.Text) Then
            intSubsequente = Convert.ToInt32(subsequenteTextEdit.Text)
         End If
         Dim strTipoSubsequente = String.Empty
         If tiposubsequenteComboBoxEdit.Visible Then
            If Not String.IsNullOrEmpty(tiposubsequenteComboBoxEdit.Text) Then
               strTipoSubsequente = tiposubsequenteComboBoxEdit.Text.Substring(0, 1)
            End If
         End If
         Dim intSabDomUtil As Int32
         If sabdomutilCheckEdit.Checked Then
            intSabDomUtil = -1
         End If
         Dim intAntecipaUtil As Int32
         If antecipautilCheckEdit.Checked Then
            intAntecipaUtil = -1
         End If

         Dim strTipo As String = "item"
         If vencimentoporComboBoxEdit.EditValue.ToString = "por CPR" Then
            strTipo = "cpr"
         ElseIf vencimentoporComboBoxEdit.EditValue.ToString = "por IE" Then
            strTipo = "ie"
         ElseIf vencimentoporComboBoxEdit.EditValue.ToString = "por CNPJ" Then
            strTipo = "cnpj"
         ElseIf vencimentoporComboBoxEdit.EditValue.ToString = "por ISS" Then
            strTipo = "iss"
         ElseIf vencimentoporComboBoxEdit.EditValue.ToString = "por e-ISS" Then
            strTipo = "eiss"
         End If

         Dim strVariacao As String = String.Empty
         Dim strNomeVariacao As String = String.Empty
         If strTipo <> "item" Then
            If strTipo = "cpr" Or strTipo = "iss" Or strTipo = "eiss" Then
               strVariacao = variacaoSearchLookUpEdit.EditValue.ToString()
               If strTipo = "iss" Or strTipo = "eiss" Then
                  strNomeVariacao = variacaodescTextEdit.Text
               End If
            Else
               strVariacao = variacaocodTextEdit.Text
            End If
         End If
         If confirmarbutton.Tag.ToString = "inclusao" Then
            Dim variacaoinfo As New obrigacoesvariacao(strVariacao, strNomeVariacao, strPeriodicidade, strTipoDia, intVencimento, strTributo, strCompetenciaObsoleta, intSubsequente, strTipoSubsequente, intSabDomUtil, intAntecipaUtil)
            infovariacao.Add(variacaoinfo)
         ElseIf confirmarbutton.Tag.ToString = "alteracao" Then
            infovariacao(intLinhaSubRegistro).variacao = strVariacao
            infovariacao(intLinhaSubRegistro).nomevariacao = strNomeVariacao
            infovariacao(intLinhaSubRegistro).periodicidade = strPeriodicidade
            infovariacao(intLinhaSubRegistro).tipodia = strTipoDia
            infovariacao(intLinhaSubRegistro).vencimento = intVencimento
            infovariacao(intLinhaSubRegistro).tributo = strTributo
            infovariacao(intLinhaSubRegistro).competenciaobsoleta = strCompetenciaObsoleta
            infovariacao(intLinhaSubRegistro).subsequente = intSubsequente
            infovariacao(intLinhaSubRegistro).tiposubsequente = strTipoSubsequente
            infovariacao(intLinhaSubRegistro).sabdomutil = intSabDomUtil
            infovariacao(intLinhaSubRegistro).antecipautil = intAntecipaUtil
         End If
      ElseIf confirmarbutton.Tag.ToString = "exclusao" Then
         infovariacao.Remove(infovariacao(intLinhaSubRegistro))
      End If
      pdgGrid.DataSource = Nothing
      pdgGrid.DataSource = infovariacao
      pdgGrid.ForceInitialize()
      infoobrigacoes.variacao = infovariacao
      LimpaDados(confirmarbutton)
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
      ElseIf pstrCampo = "periodicidade" Then
         If pstrValor = "I" Then
            strDisplayComboBox = "Diária"
         ElseIf pstrValor = "D" Then
            strDisplayComboBox = "Decendial"
         ElseIf pstrValor = "Q" Then
            strDisplayComboBox = "Quinzenal"
         ElseIf pstrValor = "M" Then
            strDisplayComboBox = "Mensal"
         ElseIf pstrValor = "T" Then
            strDisplayComboBox = "Trimestral"
         ElseIf pstrValor = "S" Then
            strDisplayComboBox = "Semestral"
         ElseIf pstrValor = "A" Then
            strDisplayComboBox = "Anual"
         End If
      ElseIf pstrCampo = "tributo" Then
         If pstrValor = "M" Then
            strDisplayComboBox = "Municipal"
         ElseIf pstrValor = "E" Then
            strDisplayComboBox = "Estadual"
         ElseIf pstrValor = "F" Then
            strDisplayComboBox = "Federal"
         ElseIf pstrValor = "T" Then
            strDisplayComboBox = "Trabalhista"
         ElseIf pstrValor = "P" Then
            strDisplayComboBox = "Previdenciária"
         End If
      ElseIf pstrCampo = "tiposubsequente" Then
         If pstrValor = "D" Then
            strDisplayComboBox = "Dia"
         ElseIf pstrValor = "M" Then
            strDisplayComboBox = "Mês"
         ElseIf pstrValor = "A" Then
            strDisplayComboBox = "Ano"
         End If
      ElseIf pstrCampo = "tipodia" Then
         If pstrValor = "F" Then
            strDisplayComboBox = "Dia Fixo"
         ElseIf pstrValor = "U" Then
            strDisplayComboBox = "Dia Útil"
         End If
      ElseIf pstrCampo = "tipo" Then
         If pstrValor = "item" Then
            strDisplayComboBox = "Não tem"
         ElseIf pstrValor = "cpr" Then
            strDisplayComboBox = "por CPR"
         ElseIf pstrValor = "ie" Then
            strDisplayComboBox = "por IE"
         ElseIf pstrValor = "cnpj" Then
            strDisplayComboBox = "por CNPJ"
         ElseIf pstrValor = "iss" Then
            strDisplayComboBox = "por ISS"
         ElseIf pstrValor = "eiss" Then
            strDisplayComboBox = "por e-ISS"
         End If
      End If
      Return strDisplayComboBox
   End Function

   Private Sub VerificaDadosGravacao(pstrCampoChave As String, confirmarbutton As SimpleButton)
      For index = 0 To infovariacao.Count - 1
         If confirmarbutton.Tag.ToString = "inclusao" Then
            If infovariacao(index).variacao = pstrCampoChave Then
               Throw New Exception("Já existe um " + variacaoLabelControl.Text.ToString + " cadastrado")
               Exit For
            End If
         ElseIf confirmarbutton.Tag.ToString = "alteracao" Then
            If index <> intLinhaSubRegistro Then
               If infovariacao(index).variacao = pstrCampoChave Then
                  Throw New Exception("Já existe um " + variacaoLabelControl.Text.ToString + " cadastrado")
                  Exit For
               End If
            End If
         End If
      Next
      If String.IsNullOrEmpty(pstrCampoChave) Then Throw New Exception("O " + variacaoLabelControl.Text.ToString + " é obrigatório")
   End Sub

   Private Sub RetornaGridFocu()
      CarregaGrid()
      If intLinhaRegistro >= 0 And okSimpleButton.Tag.ToString <> "exclusao" Then
         obrigacoesGridView.FocusedRowHandle = intLinhaRegistro
         Dim intExpanded As Int32 = intLinhaGroup
         intLinhaGroup = -1
         obrigacoesGridView.SetMasterRowExpanded(intExpanded, True)
      End If
   End Sub

   Private Sub RedimensionaTela(ByVal pstrTipo As String, ByVal pstrValor As String)
      vencimentoporGroupControl.Text = "Vencimento por: [" + vencimentoporComboBoxEdit.Text + "]"
      Dim intTopCaption As Int32 = 0
      Dim intTopValue As Int32 = 0
      Dim intTopSplitContainerControl As Int32 = 0
      If pstrTipo = "item" Then
         intTopSplitContainerControl = 30
         intTopCaption = 0
         intTopValue = 16
         vencimentoporSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
      Else
         intTopSplitContainerControl = 69
         intTopCaption = 83
         intTopValue = 101
      End If

      variacaoGroupControl.Visible = Not (pstrTipo = "item")
      vencimentoporPanelControl.Visible = Not (pstrTipo = "item")
      variacaocodTextEdit.Visible = pstrTipo = "ie" Or pstrTipo = "cnpj"
      variacaodescTextEdit.Visible = pstrTipo = "iss" Or pstrTipo = "eiss"
      variacaoSearchLookUpEdit.Visible = pstrTipo = "iss" Or pstrTipo = "eiss" Or pstrTipo = "cpr"
      If variacaoGroupControl.Visible Then
         Dim strOperacao As String = String.Empty
         If confirmarvencimentoporSimpleButton.Tag IsNot Nothing Then
            strOperacao = confirmarvencimentoporSimpleButton.Tag.ToString
         End If
         variacaoGroupControl.Enabled = (strOperacao = "inclusao")
      End If
      If pstrTipo = "iss" Or pstrTipo = "eiss" Then
         If variacaoSearchLookUpEdit.Properties.View.Columns.Count > 0 Then
            variacaoSearchLookUpEdit.Properties.View.Columns.Clear()
         End If
         Dim column As GridColumn = variacaoSearchLookUpEdit.Properties.View.Columns.AddField("municipio")

         Dim edit As New RepositoryItemTextEdit
         edit.Mask.MaskType = MaskType.Simple
         edit.Mask.UseMaskAsDisplayFormat = True
         edit.Mask.EditMask = "00-00000"

         column.ColumnEdit = edit
         column.Visible = True
         column.Caption = "Município"
         column.FieldName = "municipio"
         column = variacaoSearchLookUpEdit.Properties.View.Columns.AddField("nome")
         column.Visible = True
         column.Caption = "Nome"
         column.FieldName = "nome"

         objComum.Browse("select municipio, nome from municipios order by municipio", variacaoBindingSource)
         variacaoSearchLookUpEdit.Properties.DisplayMember = "municipio"
         variacaoSearchLookUpEdit.Properties.ValueMember = "municipio"
         variacaoSearchLookUpEdit.EditValue = pstrValor
         If pstrTipo = "iss" Then
            variacaoGroupControl.Text = "ISS"
         ElseIf pstrTipo = "eiss" Then
            variacaoGroupControl.Text = "e-ISS"
         End If
         variacaoLabelControl.Text = "Município"
      ElseIf pstrTipo = "cpr" Then
         If variacaoSearchLookUpEdit.Properties.View.Columns.Count > 0 Then
            variacaoSearchLookUpEdit.Properties.View.Columns.Clear()
         End If
         Dim column As GridColumn = variacaoSearchLookUpEdit.Properties.View.Columns.AddField("cpr")
         column.Visible = True
         column.Caption = "CPR"
         column.FieldName = "cpr"

         objComum.Browse("select cpr from venctoscpr where exercicio = " + administrativoInfo.Exercicio.ToString(), variacaoBindingSource)
         variacaoSearchLookUpEdit.Properties.DisplayMember = "cpr"
         variacaoSearchLookUpEdit.Properties.ValueMember = "cpr"
         variacaoSearchLookUpEdit.EditValue = pstrValor
         variacaoGroupControl.Text = "CPR"
         variacaoLabelControl.Text = "CPR"
      ElseIf pstrTipo = "ie" Or pstrTipo = "cnpj" Then
         variacaocodTextEdit.Text = pstrValor
         If pstrTipo = "ie" Then
            variacaoGroupControl.Text = "Inscrição Estadual"
            variacaoLabelControl.Text = "Último Digíto"
         ElseIf pstrTipo = "cnpj" Then
            variacaoGroupControl.Text = "CNPJ"
            variacaoLabelControl.Text = "Oitavo Digíto"
         End If
      End If
      periodicidadeLabelControl.Location = New Point(periodicidadeLabelControl.Location.X, intTopCaption)
      periodicidadeComboBoxEdit.Location = New Point(periodicidadeComboBoxEdit.Location.X, intTopValue)
      tributoLabelControl.Location = New Point(tributoLabelControl.Location.X, intTopCaption)
      tributoComboBoxEdit.Location = New Point(tributoComboBoxEdit.Location.X, intTopValue)
      tipodiaLabelControl.Location = New Point(tipodiaLabelControl.Location.X, intTopCaption)
      tipodiaComboBoxEdit.Location = New Point(tipodiaComboBoxEdit.Location.X, intTopValue)
      diavencimentoLabelControl.Location = New Point(diavencimentoLabelControl.Location.X, intTopCaption)
      diavencimentoTextEdit.Location = New Point(diavencimentoTextEdit.Location.X, intTopValue)
      competenciaobsoletaLabelControl.Location = New Point(competenciaobsoletaLabelControl.Location.X, intTopCaption)
      competenciaobsoletaTextEdit.Location = New Point(competenciaobsoletaTextEdit.Location.X, intTopValue)
      subsequenteLabelControl.Location = New Point(subsequenteLabelControl.Location.X, intTopCaption)
      subsequenteTextEdit.Location = New Point(subsequenteTextEdit.Location.X, intTopValue)
      tiposubsequenteComboBoxEdit.Location = New Point(tiposubsequenteComboBoxEdit.Location.X, intTopValue)
      sabdomutilCheckEdit.Location = New Point(sabdomutilCheckEdit.Location.X, intTopCaption + 43)
      antecipautilCheckEdit.Location = New Point(antecipautilCheckEdit.Location.X, intTopValue + 43)
      vencimentoporSplitContainerControl.Location = New Point(vencimentoporSplitContainerControl.Location.X, intTopSplitContainerControl)
   End Sub

   Private Sub RetornaIndexRegistro(pstrValor As String)
      For index = 0 To infovariacao.Count - 1
         If infovariacao(index).variacao = pstrValor Then
            intLinhaSubRegistro = index
         End If
      Next
   End Sub

   Private Sub obrigacoesGridControl_KeyUp(sender As Object, e As KeyEventArgs) Handles obrigacoesGridControl.KeyUp
      Dim gcSender As GridControl = DirectCast(sender, GridControl)
      If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up Then
         If gcSender.FocusedView.Name = "obrigacoesGridView" Then
            excluirBarButtonItem.Enabled = True
         Else
            excluirBarButtonItem.Enabled = False
         End If
      End If
   End Sub

   Private Sub HabilitaDesabilitaExcluirBarButton(pobjSender As Object, prccEvent As RowCellClickEventArgs) Handles obrigacoesGridView.RowCellClick, obrigacoesitemGridView.RowCellClick, obrigacoescprGridView.RowCellClick, obrigacoesissGridView.RowCellClick, obrigacoeseissGridView.RowCellClick, obrigacoesieGridView.RowCellClick, obrigacoescnpjGridView.RowCellClick
      Dim gvSender As GridView = DirectCast(pobjSender, GridView)
      If gvSender.Name = "obrigacoesGridView" Then
         If prccEvent.Clicks = 1 Then
            excluirBarButtonItem.Enabled = True
         Else
            excluirBarButtonItem.Enabled = False
         End If
      Else
         excluirBarButtonItem.Enabled = False
      End If
   End Sub
End Class