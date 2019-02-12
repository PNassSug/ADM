Imports DevExpress.Utils
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Mask

Public Class CndDAL
   Implements ICnd

   Private image As RepositoryItemImageComboBox
   Private edit As RepositoryItemTextEdit

   Public Sub Grid(ByRef pstrQuery As String, pdgGrid As GridControl, pgvGrid As GridView, picStatusImageColection As ImageCollection) Implements ICnd.Grid
      Try
         Dim objDataBase As New DataBaseDAL
         pdgGrid.DataSource = objDataBase.QueryDataView(pstrQuery)

         pgvGrid.ColumnPanelRowHeight = 60
         pgvGrid.OptionsView.ColumnAutoWidth = False
         pgvGrid.Appearance.HeaderPanel.Options.UseTextOptions = True
         pgvGrid.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center
         pgvGrid.Appearance.HeaderPanel.TextOptions.WordWrap = WordWrap.Wrap

         ' Definição de Mascarás no Grid
         edit = New RepositoryItemTextEdit()
         edit.Mask.MaskType = MaskType.Simple
         edit.Mask.UseMaskAsDisplayFormat = True
         edit.Mask.EditMask = "00.0000"
         pgvGrid.Columns(0).ColumnEdit = edit
         pgvGrid.Columns(0).Caption = "Empresa"
         pgvGrid.Columns(0).Width = 70

         pgvGrid.Columns(1).Caption = "Razão Social"
         pgvGrid.Columns(1).Width = 320

         edit = New RepositoryItemTextEdit()
         edit.Mask.MaskType = MaskType.DateTime
         edit.Mask.UseMaskAsDisplayFormat = True
         pgvGrid.Columns(2).ColumnEdit = edit
         pgvGrid.Columns(2).Caption = "Data Hora" + Environment.NewLine + "Emissão"
         pgvGrid.Columns(2).Width = 115

         pgvGrid.Columns(3).Caption = "Data Hora" + Environment.NewLine + "Validade"
         pgvGrid.Columns(3).Width = 80

         pgvGrid.Columns(4).Caption = "Código Controle" + Environment.NewLine + "Certidão"
         pgvGrid.Columns(4).Width = 120

         image = New RepositoryItemImageComboBox()
         image.SmallImages = picStatusImageColection
         image.Items.Add(New ImageComboBoxItem("Processando", 0, 0))
         image.Items.Add(New ImageComboBoxItem("Emitido", 1, 1))
         image.Items.Add(New ImageComboBoxItem("Não Emitido", 2, 2))
         pgvGrid.Columns(5).ColumnEdit = image
         pgvGrid.Columns(5).Caption = "Status"
         pgvGrid.Columns(5).Width = 100

         pgvGrid.Columns(6).Caption = "Observação"
         pgvGrid.Columns(6).Width = 200

         pgvGrid.Columns(7).Visible = False
         pgvGrid.Columns(8).Visible = False

         pdgGrid.ForceInitialize()
      Catch ex As Exception
         Throw New Exception(ex.Message)
      End Try
   End Sub
End Class
