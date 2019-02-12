<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cndXtraForm
   Inherits DevExpress.XtraEditors.XtraForm

   'Form overrides dispose to clean up the component list.
   <System.Diagnostics.DebuggerNonUserCode()> _
   Protected Overrides Sub Dispose(ByVal disposing As Boolean)
      If disposing AndAlso components IsNot Nothing Then
         components.Dispose()
      End If
      MyBase.Dispose(disposing)
   End Sub

   'Required by the Windows Form Designer
   Private components As System.ComponentModel.IContainer

   'NOTE: The following procedure is required by the Windows Form Designer
   'It can be modified using the Windows Form Designer.  
   'Do not modify it using the code editor.
   <System.Diagnostics.DebuggerStepThrough()> _
   Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cndXtraForm))
      Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
      Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
      Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
      Me.cndGridControl = New DevExpress.XtraGrid.GridControl()
      Me.cndGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
      Me.cndRibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
      Me.incluirBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
      Me.alterarBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
      Me.excluirBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
      Me.localizarBarCheckItem = New DevExpress.XtraBars.BarCheckItem()
      Me.atualizarBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
      Me.cndRibbonPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
      Me.cndRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
      Me.cndSplitContainerControl = New DevExpress.XtraEditors.SplitContainerControl()
      Me.voltarSimpleButton = New DevExpress.XtraEditors.SimpleButton()
      Me.cndPanelControl = New DevExpress.XtraEditors.PanelControl()
      Me.datavalidadeDateEdit = New DevExpress.XtraEditors.DateEdit()
      Me.competenciaTextEdit = New DevExpress.XtraEditors.TextEdit()
      Me.datahoraemissaoDateEdit = New DevExpress.XtraEditors.DateEdit()
      Me.observacaoLabelControl = New DevExpress.XtraEditors.LabelControl()
      Me.codigocontrolecertidaoLabelControl = New DevExpress.XtraEditors.LabelControl()
      Me.codigocontrolecertidaoTextEdit = New DevExpress.XtraEditors.TextEdit()
      Me.datavalidadeLabelControl = New DevExpress.XtraEditors.LabelControl()
      Me.datahoraemissaoLabelControl = New DevExpress.XtraEditors.LabelControl()
      Me.tempoLabelControl = New DevExpress.XtraEditors.LabelControl()
      Me.tempoTextEdit = New DevExpress.XtraEditors.TextEdit()
      Me.competenciaLabelControl = New DevExpress.XtraEditors.LabelControl()
      Me.empresaLabelControl = New DevExpress.XtraEditors.LabelControl()
      Me.razaosocialTextEdit = New DevExpress.XtraEditors.TextEdit()
      Me.empresaSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
      Me.empresasInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
      Me.empresaGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
      Me.empresaGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
      Me.razaosocialGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
      Me.observacaoTextEdit = New DevExpress.XtraEditors.MemoEdit()
      Me.statusImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
      CType(Me.cndGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.cndGridView, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.cndRibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.cndSplitContainerControl, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.cndSplitContainerControl.SuspendLayout()
      CType(Me.cndPanelControl, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.cndPanelControl.SuspendLayout()
      CType(Me.datavalidadeDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.datavalidadeDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.competenciaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.datahoraemissaoDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.datahoraemissaoDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.codigocontrolecertidaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.tempoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.razaosocialTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.empresaSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.empresasInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.empresaGridView, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.observacaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.statusImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'cndGridControl
      '
      Me.cndGridControl.Dock = System.Windows.Forms.DockStyle.Fill
      Me.cndGridControl.Location = New System.Drawing.Point(0, 0)
      Me.cndGridControl.MainView = Me.cndGridView
      Me.cndGridControl.Name = "cndGridControl"
      Me.cndGridControl.Size = New System.Drawing.Size(968, 425)
      Me.cndGridControl.TabIndex = 1
      Me.cndGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.cndGridView})
      '
      'cndGridView
      '
      Me.cndGridView.GridControl = Me.cndGridControl
      Me.cndGridView.Name = "cndGridView"
      Me.cndGridView.OptionsBehavior.Editable = False
      Me.cndGridView.OptionsCustomization.AllowColumnMoving = False
      Me.cndGridView.OptionsCustomization.AllowColumnResizing = False
      Me.cndGridView.OptionsCustomization.AllowGroup = False
      Me.cndGridView.OptionsCustomization.AllowQuickHideColumns = False
      Me.cndGridView.OptionsView.ShowGroupPanel = False
      '
      'cndRibbonControl
      '
      Me.cndRibbonControl.ExpandCollapseItem.Id = 0
      Me.cndRibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cndRibbonControl.ExpandCollapseItem, Me.incluirBarButtonItem, Me.alterarBarButtonItem, Me.excluirBarButtonItem, Me.localizarBarCheckItem, Me.atualizarBarButtonItem})
      Me.cndRibbonControl.Location = New System.Drawing.Point(0, 0)
      Me.cndRibbonControl.MaxItemId = 6
      Me.cndRibbonControl.Name = "cndRibbonControl"
      Me.cndRibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.cndRibbonPage})
      Me.cndRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
      Me.cndRibbonControl.ShowCategoryInCaption = False
      Me.cndRibbonControl.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[False]
      Me.cndRibbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
      Me.cndRibbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
      Me.cndRibbonControl.ShowToolbarCustomizeItem = False
      Me.cndRibbonControl.Size = New System.Drawing.Size(968, 95)
      Me.cndRibbonControl.Toolbar.ShowCustomizeItem = False
      Me.cndRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
      '
      'incluirBarButtonItem
      '
      Me.incluirBarButtonItem.Caption = "Incluir"
      Me.incluirBarButtonItem.Id = 1
      Me.incluirBarButtonItem.ImageOptions.Image = CType(resources.GetObject("incluirBarButtonItem.ImageOptions.Image"), System.Drawing.Image)
      Me.incluirBarButtonItem.Name = "incluirBarButtonItem"
      Me.incluirBarButtonItem.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
      Me.incluirBarButtonItem.Tag = "movparinc"
      Me.incluirBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInRuntime
      '
      'alterarBarButtonItem
      '
      Me.alterarBarButtonItem.Caption = "Alterar"
      Me.alterarBarButtonItem.Id = 2
      Me.alterarBarButtonItem.ImageOptions.Image = CType(resources.GetObject("alterarBarButtonItem.ImageOptions.Image"), System.Drawing.Image)
      Me.alterarBarButtonItem.Name = "alterarBarButtonItem"
      Me.alterarBarButtonItem.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
      Me.alterarBarButtonItem.Tag = "movcndcon"
      Me.alterarBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInRuntime
      '
      'excluirBarButtonItem
      '
      Me.excluirBarButtonItem.Caption = "Excluir"
      Me.excluirBarButtonItem.Id = 3
      Me.excluirBarButtonItem.ImageOptions.Image = CType(resources.GetObject("excluirBarButtonItem.ImageOptions.Image"), System.Drawing.Image)
      Me.excluirBarButtonItem.Name = "excluirBarButtonItem"
      Me.excluirBarButtonItem.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
      Me.excluirBarButtonItem.Tag = "movparexc"
      Me.excluirBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInRuntime
      '
      'localizarBarCheckItem
      '
      Me.localizarBarCheckItem.Caption = "Localizar"
      Me.localizarBarCheckItem.Id = 4
      Me.localizarBarCheckItem.ImageOptions.Image = CType(resources.GetObject("localizarBarCheckItem.ImageOptions.Image"), System.Drawing.Image)
      Me.localizarBarCheckItem.Name = "localizarBarCheckItem"
      Me.localizarBarCheckItem.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
      '
      'atualizarBarButtonItem
      '
      Me.atualizarBarButtonItem.Caption = "Atualizar"
      Me.atualizarBarButtonItem.Id = 5
      Me.atualizarBarButtonItem.ImageOptions.Image = CType(resources.GetObject("atualizarBarButtonItem.ImageOptions.Image"), System.Drawing.Image)
      Me.atualizarBarButtonItem.Name = "atualizarBarButtonItem"
      Me.atualizarBarButtonItem.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
      '
      'cndRibbonPage
      '
      Me.cndRibbonPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.cndRibbonPageGroup})
      Me.cndRibbonPage.Name = "cndRibbonPage"
      '
      'cndRibbonPageGroup
      '
      Me.cndRibbonPageGroup.ItemLinks.Add(Me.alterarBarButtonItem)
      Me.cndRibbonPageGroup.ItemLinks.Add(Me.localizarBarCheckItem)
      Me.cndRibbonPageGroup.ItemLinks.Add(Me.atualizarBarButtonItem)
      Me.cndRibbonPageGroup.Name = "cndRibbonPageGroup"
      Me.cndRibbonPageGroup.ShowCaptionButton = False
      '
      'cndSplitContainerControl
      '
      Me.cndSplitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill
      Me.cndSplitContainerControl.Location = New System.Drawing.Point(0, 95)
      Me.cndSplitContainerControl.Name = "cndSplitContainerControl"
      Me.cndSplitContainerControl.Panel1.Controls.Add(Me.voltarSimpleButton)
      Me.cndSplitContainerControl.Panel1.Controls.Add(Me.cndPanelControl)
      Me.cndSplitContainerControl.Panel1.Text = "Panel1"
      Me.cndSplitContainerControl.Panel2.Controls.Add(Me.cndGridControl)
      Me.cndSplitContainerControl.Panel2.Text = "Panel2"
      Me.cndSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
      Me.cndSplitContainerControl.Size = New System.Drawing.Size(968, 425)
      Me.cndSplitContainerControl.SplitterPosition = 110
      Me.cndSplitContainerControl.TabIndex = 0
      '
      'voltarSimpleButton
      '
      Me.voltarSimpleButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.voltarSimpleButton.Image = CType(resources.GetObject("voltarSimpleButton.Image"), System.Drawing.Image)
      Me.voltarSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
      Me.voltarSimpleButton.Location = New System.Drawing.Point(894, 377)
      Me.voltarSimpleButton.Name = "voltarSimpleButton"
      Me.voltarSimpleButton.Size = New System.Drawing.Size(62, 45)
      Me.voltarSimpleButton.TabIndex = 1
      Me.voltarSimpleButton.Text = "Voltar"
      '
      'cndPanelControl
      '
      Me.cndPanelControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
      Me.cndPanelControl.Controls.Add(Me.datavalidadeDateEdit)
      Me.cndPanelControl.Controls.Add(Me.competenciaTextEdit)
      Me.cndPanelControl.Controls.Add(Me.datahoraemissaoDateEdit)
      Me.cndPanelControl.Controls.Add(Me.observacaoLabelControl)
      Me.cndPanelControl.Controls.Add(Me.codigocontrolecertidaoLabelControl)
      Me.cndPanelControl.Controls.Add(Me.codigocontrolecertidaoTextEdit)
      Me.cndPanelControl.Controls.Add(Me.datavalidadeLabelControl)
      Me.cndPanelControl.Controls.Add(Me.datahoraemissaoLabelControl)
      Me.cndPanelControl.Controls.Add(Me.tempoLabelControl)
      Me.cndPanelControl.Controls.Add(Me.tempoTextEdit)
      Me.cndPanelControl.Controls.Add(Me.competenciaLabelControl)
      Me.cndPanelControl.Controls.Add(Me.empresaLabelControl)
      Me.cndPanelControl.Controls.Add(Me.razaosocialTextEdit)
      Me.cndPanelControl.Controls.Add(Me.empresaSearchLookUpEdit)
      Me.cndPanelControl.Controls.Add(Me.observacaoTextEdit)
      Me.cndPanelControl.Location = New System.Drawing.Point(4, 2)
      Me.cndPanelControl.Name = "cndPanelControl"
      Me.cndPanelControl.Size = New System.Drawing.Size(961, 369)
      Me.cndPanelControl.TabIndex = 0
      '
      'datavalidadeDateEdit
      '
      Me.datavalidadeDateEdit.EditValue = Nothing
      Me.datavalidadeDateEdit.Enabled = False
      Me.datavalidadeDateEdit.Location = New System.Drawing.Point(257, 64)
      Me.datavalidadeDateEdit.Name = "datavalidadeDateEdit"
      Me.datavalidadeDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
      Me.datavalidadeDateEdit.Properties.AutoHeight = False
      Me.datavalidadeDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Data de Vencimento", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("datavalidadeDateEdit.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D)), SerializableAppearanceObject4, "", Nothing, Nothing, True)})
      Me.datavalidadeDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
      Me.datavalidadeDateEdit.Properties.Mask.SaveLiteral = False
      Me.datavalidadeDateEdit.Properties.Mask.ShowPlaceHolders = False
      Me.datavalidadeDateEdit.Properties.Mask.UseMaskAsDisplayFormat = True
      Me.datavalidadeDateEdit.Size = New System.Drawing.Size(100, 20)
      Me.datavalidadeDateEdit.TabIndex = 10
      '
      'competenciaTextEdit
      '
      Me.competenciaTextEdit.Enabled = False
      Me.competenciaTextEdit.Location = New System.Drawing.Point(884, 18)
      Me.competenciaTextEdit.Name = "competenciaTextEdit"
      Me.competenciaTextEdit.Properties.AutoHeight = False
      Me.competenciaTextEdit.Properties.Mask.EditMask = "00/0000"
      Me.competenciaTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
      Me.competenciaTextEdit.Properties.Mask.SaveLiteral = False
      Me.competenciaTextEdit.Properties.Mask.ShowPlaceHolders = False
      Me.competenciaTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
      Me.competenciaTextEdit.Size = New System.Drawing.Size(72, 22)
      Me.competenciaTextEdit.TabIndex = 4
      '
      'datahoraemissaoDateEdit
      '
      Me.datahoraemissaoDateEdit.EditValue = Nothing
      Me.datahoraemissaoDateEdit.Enabled = False
      Me.datahoraemissaoDateEdit.Location = New System.Drawing.Point(107, 64)
      Me.datahoraemissaoDateEdit.Name = "datahoraemissaoDateEdit"
      Me.datahoraemissaoDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
      Me.datahoraemissaoDateEdit.Properties.AutoHeight = False
      Me.datahoraemissaoDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Data de Vencimento", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("datahoraemissaoDateEdit.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D)), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
      Me.datahoraemissaoDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
      Me.datahoraemissaoDateEdit.Properties.Mask.EditMask = "G"
      Me.datahoraemissaoDateEdit.Properties.Mask.SaveLiteral = False
      Me.datahoraemissaoDateEdit.Properties.Mask.ShowPlaceHolders = False
      Me.datahoraemissaoDateEdit.Properties.Mask.UseMaskAsDisplayFormat = True
      Me.datahoraemissaoDateEdit.Size = New System.Drawing.Size(144, 20)
      Me.datahoraemissaoDateEdit.TabIndex = 8
      '
      'observacaoLabelControl
      '
      Me.observacaoLabelControl.Location = New System.Drawing.Point(6, 92)
      Me.observacaoLabelControl.Name = "observacaoLabelControl"
      Me.observacaoLabelControl.Size = New System.Drawing.Size(58, 13)
      Me.observacaoLabelControl.TabIndex = 13
      Me.observacaoLabelControl.Text = "Observação"
      '
      'codigocontrolecertidaoLabelControl
      '
      Me.codigocontrolecertidaoLabelControl.Location = New System.Drawing.Point(364, 46)
      Me.codigocontrolecertidaoLabelControl.Name = "codigocontrolecertidaoLabelControl"
      Me.codigocontrolecertidaoLabelControl.Size = New System.Drawing.Size(121, 13)
      Me.codigocontrolecertidaoLabelControl.TabIndex = 11
      Me.codigocontrolecertidaoLabelControl.Text = "Código Controle Certidão"
      '
      'codigocontrolecertidaoTextEdit
      '
      Me.codigocontrolecertidaoTextEdit.Enabled = False
      Me.codigocontrolecertidaoTextEdit.Location = New System.Drawing.Point(364, 64)
      Me.codigocontrolecertidaoTextEdit.MenuManager = Me.cndRibbonControl
      Me.codigocontrolecertidaoTextEdit.Name = "codigocontrolecertidaoTextEdit"
      Me.codigocontrolecertidaoTextEdit.Size = New System.Drawing.Size(130, 20)
      Me.codigocontrolecertidaoTextEdit.TabIndex = 12
      '
      'datavalidadeLabelControl
      '
      Me.datavalidadeLabelControl.Location = New System.Drawing.Point(257, 46)
      Me.datavalidadeLabelControl.Name = "datavalidadeLabelControl"
      Me.datavalidadeLabelControl.Size = New System.Drawing.Size(66, 13)
      Me.datavalidadeLabelControl.TabIndex = 9
      Me.datavalidadeLabelControl.Text = "Data Validade"
      '
      'datahoraemissaoLabelControl
      '
      Me.datahoraemissaoLabelControl.Location = New System.Drawing.Point(107, 46)
      Me.datahoraemissaoLabelControl.Name = "datahoraemissaoLabelControl"
      Me.datahoraemissaoLabelControl.Size = New System.Drawing.Size(90, 13)
      Me.datahoraemissaoLabelControl.TabIndex = 7
      Me.datahoraemissaoLabelControl.Text = "Data Hora Emissão"
      '
      'tempoLabelControl
      '
      Me.tempoLabelControl.Location = New System.Drawing.Point(6, 46)
      Me.tempoLabelControl.Name = "tempoLabelControl"
      Me.tempoLabelControl.Size = New System.Drawing.Size(92, 13)
      Me.tempoLabelControl.TabIndex = 5
      Me.tempoLabelControl.Text = "Tempo de resposta"
      '
      'tempoTextEdit
      '
      Me.tempoTextEdit.Enabled = False
      Me.tempoTextEdit.Location = New System.Drawing.Point(6, 64)
      Me.tempoTextEdit.MenuManager = Me.cndRibbonControl
      Me.tempoTextEdit.Name = "tempoTextEdit"
      Me.tempoTextEdit.Size = New System.Drawing.Size(95, 20)
      Me.tempoTextEdit.TabIndex = 6
      '
      'competenciaLabelControl
      '
      Me.competenciaLabelControl.Location = New System.Drawing.Point(884, 2)
      Me.competenciaLabelControl.Name = "competenciaLabelControl"
      Me.competenciaLabelControl.Size = New System.Drawing.Size(62, 13)
      Me.competenciaLabelControl.TabIndex = 3
      Me.competenciaLabelControl.Text = "Competência"
      '
      'empresaLabelControl
      '
      Me.empresaLabelControl.Location = New System.Drawing.Point(6, 2)
      Me.empresaLabelControl.Name = "empresaLabelControl"
      Me.empresaLabelControl.Size = New System.Drawing.Size(41, 13)
      Me.empresaLabelControl.TabIndex = 0
      Me.empresaLabelControl.Text = "Empresa"
      '
      'razaosocialTextEdit
      '
      Me.razaosocialTextEdit.EditValue = ""
      Me.razaosocialTextEdit.Enabled = False
      Me.razaosocialTextEdit.Location = New System.Drawing.Point(110, 18)
      Me.razaosocialTextEdit.Name = "razaosocialTextEdit"
      Me.razaosocialTextEdit.Properties.AutoHeight = False
      Me.razaosocialTextEdit.Size = New System.Drawing.Size(768, 20)
      Me.razaosocialTextEdit.TabIndex = 2
      '
      'empresaSearchLookUpEdit
      '
      Me.empresaSearchLookUpEdit.Enabled = False
      Me.empresaSearchLookUpEdit.Location = New System.Drawing.Point(6, 18)
      Me.empresaSearchLookUpEdit.Name = "empresaSearchLookUpEdit"
      Me.empresaSearchLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
      Me.empresaSearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("empresaSearchLookUpEdit.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
      Me.empresaSearchLookUpEdit.Properties.DataSource = Me.empresasInfoBindingSource
      Me.empresaSearchLookUpEdit.Properties.DisplayMember = "empresa"
      Me.empresaSearchLookUpEdit.Properties.NullText = ""
      Me.empresaSearchLookUpEdit.Properties.ValueMember = "empresa"
      Me.empresaSearchLookUpEdit.Properties.View = Me.empresaGridView
      Me.empresaSearchLookUpEdit.Size = New System.Drawing.Size(100, 22)
      Me.empresaSearchLookUpEdit.TabIndex = 1
      '
      'empresaGridView
      '
      Me.empresaGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.empresaGridColumn, Me.razaosocialGridColumn})
      Me.empresaGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
      Me.empresaGridView.Name = "empresaGridView"
      Me.empresaGridView.OptionsFind.AlwaysVisible = True
      Me.empresaGridView.OptionsFind.SearchInPreview = True
      Me.empresaGridView.OptionsSelection.EnableAppearanceFocusedCell = False
      Me.empresaGridView.OptionsView.ShowGroupPanel = False
      '
      'empresaGridColumn
      '
      Me.empresaGridColumn.Caption = "Empresa"
      Me.empresaGridColumn.FieldName = "empresa"
      Me.empresaGridColumn.Name = "empresaGridColumn"
      Me.empresaGridColumn.Visible = True
      Me.empresaGridColumn.VisibleIndex = 0
      Me.empresaGridColumn.Width = 80
      '
      'razaosocialGridColumn
      '
      Me.razaosocialGridColumn.Caption = "Razão Social"
      Me.razaosocialGridColumn.FieldName = "razaosocial"
      Me.razaosocialGridColumn.Name = "razaosocialGridColumn"
      Me.razaosocialGridColumn.Visible = True
      Me.razaosocialGridColumn.VisibleIndex = 1
      Me.razaosocialGridColumn.Width = 200
      '
      'observacaoTextEdit
      '
      Me.observacaoTextEdit.Location = New System.Drawing.Point(6, 111)
      Me.observacaoTextEdit.MenuManager = Me.cndRibbonControl
      Me.observacaoTextEdit.Name = "observacaoTextEdit"
      Me.observacaoTextEdit.Size = New System.Drawing.Size(950, 253)
      Me.observacaoTextEdit.TabIndex = 14
      '
      'statusImageCollection
      '
      Me.statusImageCollection.ImageStream = CType(resources.GetObject("statusImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
      Me.statusImageCollection.Images.SetKeyName(0, "document_time.png")
      Me.statusImageCollection.Images.SetKeyName(1, "document_ok.png")
      Me.statusImageCollection.Images.SetKeyName(2, "document_warning.png")
      '
      'cndXtraForm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.CancelButton = Me.voltarSimpleButton
      Me.ClientSize = New System.Drawing.Size(968, 520)
      Me.Controls.Add(Me.cndSplitContainerControl)
      Me.Controls.Add(Me.cndRibbonControl)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "cndXtraForm"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "CND - Certidão Negativa de Débitos"
      CType(Me.cndGridControl, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.cndGridView, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.cndRibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.cndSplitContainerControl, System.ComponentModel.ISupportInitialize).EndInit()
      Me.cndSplitContainerControl.ResumeLayout(False)
      CType(Me.cndPanelControl, System.ComponentModel.ISupportInitialize).EndInit()
      Me.cndPanelControl.ResumeLayout(False)
      Me.cndPanelControl.PerformLayout()
      CType(Me.datavalidadeDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.datavalidadeDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.competenciaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.datahoraemissaoDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.datahoraemissaoDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.codigocontrolecertidaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.tempoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.razaosocialTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.empresaSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.empresasInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.empresaGridView, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.observacaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.statusImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents cndRibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
   Friend WithEvents incluirBarButtonItem As DevExpress.XtraBars.BarButtonItem
   Friend WithEvents alterarBarButtonItem As DevExpress.XtraBars.BarButtonItem
   Friend WithEvents excluirBarButtonItem As DevExpress.XtraBars.BarButtonItem
   Friend WithEvents localizarBarCheckItem As DevExpress.XtraBars.BarCheckItem
   Friend WithEvents atualizarBarButtonItem As DevExpress.XtraBars.BarButtonItem
   Friend WithEvents cndRibbonPage As DevExpress.XtraBars.Ribbon.RibbonPage
   Friend WithEvents cndRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
   Friend WithEvents cndSplitContainerControl As DevExpress.XtraEditors.SplitContainerControl
   Friend WithEvents voltarSimpleButton As DevExpress.XtraEditors.SimpleButton
   Friend WithEvents cndPanelControl As DevExpress.XtraEditors.PanelControl
   Friend WithEvents empresaLabelControl As DevExpress.XtraEditors.LabelControl
   Friend WithEvents razaosocialTextEdit As DevExpress.XtraEditors.TextEdit
   Friend WithEvents empresaSearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
   Friend WithEvents empresaGridView As DevExpress.XtraGrid.Views.Grid.GridView
   Friend WithEvents empresaGridColumn As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents razaosocialGridColumn As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents cndGridControl As DevExpress.XtraGrid.GridControl
   Friend WithEvents cndGridView As DevExpress.XtraGrid.Views.Grid.GridView
   Friend WithEvents empresasInfoBindingSource As BindingSource
   Friend WithEvents statusImageCollection As DevExpress.Utils.ImageCollection
   Friend WithEvents observacaoLabelControl As DevExpress.XtraEditors.LabelControl
   Friend WithEvents codigocontrolecertidaoLabelControl As DevExpress.XtraEditors.LabelControl
   Friend WithEvents codigocontrolecertidaoTextEdit As DevExpress.XtraEditors.TextEdit
   Friend WithEvents datavalidadeLabelControl As DevExpress.XtraEditors.LabelControl
   Friend WithEvents datahoraemissaoLabelControl As DevExpress.XtraEditors.LabelControl
   Friend WithEvents tempoLabelControl As DevExpress.XtraEditors.LabelControl
   Friend WithEvents tempoTextEdit As DevExpress.XtraEditors.TextEdit
   Friend WithEvents competenciaLabelControl As DevExpress.XtraEditors.LabelControl
   Friend WithEvents observacaoTextEdit As DevExpress.XtraEditors.MemoEdit
   Friend WithEvents datahoraemissaoDateEdit As DevExpress.XtraEditors.DateEdit
   Friend WithEvents competenciaTextEdit As DevExpress.XtraEditors.TextEdit
   Friend WithEvents datavalidadeDateEdit As DevExpress.XtraEditors.DateEdit
End Class
