Imports DevExpress.XtraEditors.Mask
Imports DevExpress.XtraEditors.Repository

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class regrasXtraForm
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
    Dim edit As New RepositoryItemTextEdit
    Dim obrigacaoEdit As New RepositoryItemTextEdit

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(regrasXtraForm))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.ImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.empresasInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.obrigacoesInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.regrasSplitContainerControl = New DevExpress.XtraEditors.SplitContainerControl()
        Me.empresasGroupControl = New DevExpress.XtraEditors.GroupControl()
        Me.empresasSplitContainerControl = New DevExpress.XtraEditors.SplitContainerControl()
        Me.empresaLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.razaosocialTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.empresaSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.empresaGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.empresaGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.razaosocialGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.empresasGridControl = New DevExpress.XtraGrid.GridControl()
        Me.empresasGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.regrasRibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.incluirBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.alterarBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.excluirBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.localizarBarCheckItem = New DevExpress.XtraBars.BarCheckItem()
        Me.atualizarBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.empresaobrigacaoRibbonPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.regrasRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.empresasPanelControl = New DevExpress.XtraEditors.PanelControl()
        Me.voltarempresasSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.confirmarempresasSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.excluirempresasSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.alterarempresasSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.incluirempresasSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.obrigacoesGroupControl = New DevExpress.XtraEditors.GroupControl()
        Me.obrigacoesSplitContainerControl = New DevExpress.XtraEditors.SplitContainerControl()
        Me.obrigacaoLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.obrigacaodescricaoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.obrigacaoSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.obrigacaoGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.obrigacaoGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.descricaoGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.obrigacoesGridControl = New DevExpress.XtraGrid.GridControl()
        Me.obrigacoesGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.obrigacoesPanelControl = New DevExpress.XtraEditors.PanelControl()
        Me.voltarobrigacoesSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.confirmarobrigacoesSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.excluirobrigacoesSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.alterarobrigacoesSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.incluirobrigacoesSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.voltarSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.okSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.regrasPanelControl = New DevExpress.XtraEditors.PanelControl()
        Me.descricaoLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.regraLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.descricaoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.regraTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.regrasGridControl = New DevExpress.XtraGrid.GridControl()
        Me.regrasGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresasInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacoesInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.regrasSplitContainerControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.regrasSplitContainerControl.SuspendLayout()
        CType(Me.empresasGroupControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.empresasGroupControl.SuspendLayout()
        CType(Me.empresasSplitContainerControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.empresasSplitContainerControl.SuspendLayout()
        CType(Me.razaosocialTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresaSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresaGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresasGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresasGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.regrasRibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresasPanelControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.empresasPanelControl.SuspendLayout()
        CType(Me.obrigacoesGroupControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.obrigacoesGroupControl.SuspendLayout()
        CType(Me.obrigacoesSplitContainerControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.obrigacoesSplitContainerControl.SuspendLayout()
        CType(Me.obrigacaodescricaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacaoSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacaoGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacoesGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacoesGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacoesPanelControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.obrigacoesPanelControl.SuspendLayout()
        CType(Me.regrasPanelControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.regrasPanelControl.SuspendLayout()
        CType(Me.descricaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.regraTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.regrasGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.regrasGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageCollection
        '
        Me.ImageCollection.ImageSize = New System.Drawing.Size(24, 24)
        Me.ImageCollection.ImageStream = CType(resources.GetObject("ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection.Images.SetKeyName(0, "disk_blue.png")
        Me.ImageCollection.Images.SetKeyName(1, "delete.png")
        Me.ImageCollection.Images.SetKeyName(2, "disk_blue_ok.png")
        Me.ImageCollection.Images.SetKeyName(3, "disk_blue_error.png")
        '
        'regrasSplitContainerControl
        '
        Me.regrasSplitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.regrasSplitContainerControl.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None
        Me.regrasSplitContainerControl.Location = New System.Drawing.Point(0, 95)
        Me.regrasSplitContainerControl.Name = "regrasSplitContainerControl"
        Me.regrasSplitContainerControl.Panel1.Controls.Add(Me.empresasGroupControl)
        Me.regrasSplitContainerControl.Panel1.Controls.Add(Me.obrigacoesGroupControl)
        Me.regrasSplitContainerControl.Panel1.Controls.Add(Me.voltarSimpleButton)
        Me.regrasSplitContainerControl.Panel1.Controls.Add(Me.okSimpleButton)
        Me.regrasSplitContainerControl.Panel1.Controls.Add(Me.regrasPanelControl)
        Me.regrasSplitContainerControl.Panel2.Controls.Add(Me.regrasGridControl)
        Me.regrasSplitContainerControl.Panel2.Text = "Panel2"
        Me.regrasSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
        Me.regrasSplitContainerControl.Size = New System.Drawing.Size(936, 387)
        Me.regrasSplitContainerControl.SplitterPosition = 110
        Me.regrasSplitContainerControl.TabIndex = 0
        '
        'empresasGroupControl
        '
        Me.empresasGroupControl.Controls.Add(Me.empresasSplitContainerControl)
        Me.empresasGroupControl.Controls.Add(Me.empresasPanelControl)
        Me.empresasGroupControl.Location = New System.Drawing.Point(472, 59)
        Me.empresasGroupControl.Name = "empresasGroupControl"
        Me.empresasGroupControl.Size = New System.Drawing.Size(461, 274)
        Me.empresasGroupControl.TabIndex = 2
        Me.empresasGroupControl.Text = "Relação das Empresas"
        '
        'empresasSplitContainerControl
        '
        Me.empresasSplitContainerControl.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None
        Me.empresasSplitContainerControl.Location = New System.Drawing.Point(4, 69)
        Me.empresasSplitContainerControl.Name = "empresasSplitContainerControl"
        Me.empresasSplitContainerControl.Panel1.Controls.Add(Me.empresaLabelControl)
        Me.empresasSplitContainerControl.Panel1.Controls.Add(Me.razaosocialTextEdit)
        Me.empresasSplitContainerControl.Panel1.Controls.Add(Me.empresaSearchLookUpEdit)
        Me.empresasSplitContainerControl.Panel2.Controls.Add(Me.empresasGridControl)
        Me.empresasSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
        Me.empresasSplitContainerControl.Size = New System.Drawing.Size(450, 200)
        Me.empresasSplitContainerControl.TabIndex = 1
        '
        'empresaLabelControl
        '
        Me.empresaLabelControl.Location = New System.Drawing.Point(7, 3)
        Me.empresaLabelControl.Name = "empresaLabelControl"
        Me.empresaLabelControl.Size = New System.Drawing.Size(41, 13)
        Me.empresaLabelControl.TabIndex = 0
        Me.empresaLabelControl.Text = "Empresa"
        '
        'razaosocialTextEdit
        '
        Me.razaosocialTextEdit.EditValue = ""
        Me.razaosocialTextEdit.Enabled = False
        Me.razaosocialTextEdit.Location = New System.Drawing.Point(112, 20)
        Me.razaosocialTextEdit.Name = "razaosocialTextEdit"
        Me.razaosocialTextEdit.Properties.AutoHeight = False
        Me.razaosocialTextEdit.Size = New System.Drawing.Size(335, 22)
        Me.razaosocialTextEdit.TabIndex = 2
        '
        'empresaSearchLookUpEdit
        '
        Me.empresaSearchLookUpEdit.Location = New System.Drawing.Point(7, 20)
        Me.empresaSearchLookUpEdit.Name = "empresaSearchLookUpEdit"
        Me.empresaSearchLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.empresaSearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("empresaSearchLookUpEdit.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.empresaSearchLookUpEdit.Properties.DataSource = Me.empresasInfoBindingSource
        Me.empresaSearchLookUpEdit.Properties.DisplayMember = "empresa"
        Me.empresaSearchLookUpEdit.Properties.NullText = ""
        Me.empresaSearchLookUpEdit.Properties.ValueMember = "empresa"
        Me.empresaSearchLookUpEdit.Properties.View = Me.empresaGridView
        Me.empresaSearchLookUpEdit.Size = New System.Drawing.Size(100, 22)
        Me.empresaSearchLookUpEdit.TabIndex = 1
        Me.empresaSearchLookUpEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.empresaSearchLookUpEdit.Properties.Mask.EditMask = "00.0000"
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
        Me.empresaGridView.Columns(0).ColumnEdit = edit
        edit.Mask.MaskType = MaskType.Simple
        edit.Mask.UseMaskAsDisplayFormat = True
        edit.Mask.EditMask = "00.0000"
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
        Me.razaosocialGridColumn.Caption = "RazãoSocial"
        Me.razaosocialGridColumn.FieldName = "razaosocial"
        Me.razaosocialGridColumn.Name = "razaosocialGridColumn"
        Me.razaosocialGridColumn.Visible = True
        Me.razaosocialGridColumn.VisibleIndex = 1
        Me.razaosocialGridColumn.Width = 200
        '
        'empresasGridControl
        '
        Me.empresasGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.empresasGridControl.Location = New System.Drawing.Point(0, 0)
        Me.empresasGridControl.MainView = Me.empresasGridView
        Me.empresasGridControl.MenuManager = Me.regrasRibbonControl
        Me.empresasGridControl.Name = "empresasGridControl"
        Me.empresasGridControl.Size = New System.Drawing.Size(450, 200)
        Me.empresasGridControl.TabIndex = 2
        Me.empresasGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.empresasGridView})
        '
        'empresasGridView
        '
        Me.empresasGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.empresasGridView.GridControl = Me.empresasGridControl
        Me.empresasGridView.Name = "empresasGridView"
        Me.empresasGridView.OptionsBehavior.Editable = False
        Me.empresasGridView.OptionsCustomization.AllowColumnMoving = False
        Me.empresasGridView.OptionsCustomization.AllowColumnResizing = False
        Me.empresasGridView.OptionsCustomization.AllowGroup = False
        Me.empresasGridView.OptionsCustomization.AllowQuickHideColumns = False
        Me.empresasGridView.OptionsView.ShowGroupPanel = False
        '
        'regrasRibbonControl
        '
        Me.regrasRibbonControl.ExpandCollapseItem.Id = 0
        Me.regrasRibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.regrasRibbonControl.ExpandCollapseItem, Me.incluirBarButtonItem, Me.alterarBarButtonItem, Me.excluirBarButtonItem, Me.localizarBarCheckItem, Me.atualizarBarButtonItem})
        Me.regrasRibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.regrasRibbonControl.MaxItemId = 6
        Me.regrasRibbonControl.Name = "regrasRibbonControl"
        Me.regrasRibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.empresaobrigacaoRibbonPage})
        Me.regrasRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.regrasRibbonControl.ShowCategoryInCaption = False
        Me.regrasRibbonControl.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.regrasRibbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.regrasRibbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.regrasRibbonControl.ShowToolbarCustomizeItem = False
        Me.regrasRibbonControl.Size = New System.Drawing.Size(936, 95)
        Me.regrasRibbonControl.Toolbar.ShowCustomizeItem = False
        Me.regrasRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'incluirBarButtonItem
        '
        Me.incluirBarButtonItem.Caption = "Incluir"
        Me.incluirBarButtonItem.Id = 1
        Me.incluirBarButtonItem.ImageOptions.Image = CType(resources.GetObject("incluirBarButtonItem.ImageOptions.Image"), System.Drawing.Image)
        Me.incluirBarButtonItem.Name = "incluirBarButtonItem"
        Me.incluirBarButtonItem.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        Me.incluirBarButtonItem.Tag = "cadreginc"
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
        Me.alterarBarButtonItem.Tag = "cadregalt"
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
        Me.excluirBarButtonItem.Tag = "cadregexc"
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
        'empresaobrigacaoRibbonPage
        '
        Me.empresaobrigacaoRibbonPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.regrasRibbonPageGroup})
        Me.empresaobrigacaoRibbonPage.Name = "empresaobrigacaoRibbonPage"
        Me.empresaobrigacaoRibbonPage.Text = "RibbonPage1"
        '
        'regrasRibbonPageGroup
        '
        Me.regrasRibbonPageGroup.ItemLinks.Add(Me.incluirBarButtonItem)
        Me.regrasRibbonPageGroup.ItemLinks.Add(Me.alterarBarButtonItem)
        Me.regrasRibbonPageGroup.ItemLinks.Add(Me.excluirBarButtonItem)
        Me.regrasRibbonPageGroup.ItemLinks.Add(Me.localizarBarCheckItem)
        Me.regrasRibbonPageGroup.ItemLinks.Add(Me.atualizarBarButtonItem)
        Me.regrasRibbonPageGroup.Name = "regrasRibbonPageGroup"
        Me.regrasRibbonPageGroup.ShowCaptionButton = False
        '
        'empresasPanelControl
        '
        Me.empresasPanelControl.Controls.Add(Me.voltarempresasSimpleButton)
        Me.empresasPanelControl.Controls.Add(Me.confirmarempresasSimpleButton)
        Me.empresasPanelControl.Controls.Add(Me.excluirempresasSimpleButton)
        Me.empresasPanelControl.Controls.Add(Me.alterarempresasSimpleButton)
        Me.empresasPanelControl.Controls.Add(Me.incluirempresasSimpleButton)
        Me.empresasPanelControl.Location = New System.Drawing.Point(4, 24)
        Me.empresasPanelControl.Name = "empresasPanelControl"
        Me.empresasPanelControl.Size = New System.Drawing.Size(452, 39)
        Me.empresasPanelControl.TabIndex = 0
        '
        'voltarempresasSimpleButton
        '
        Me.voltarempresasSimpleButton.Image = CType(resources.GetObject("voltarempresasSimpleButton.Image"), System.Drawing.Image)
        Me.voltarempresasSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.voltarempresasSimpleButton.Location = New System.Drawing.Point(418, 6)
        Me.voltarempresasSimpleButton.Name = "voltarempresasSimpleButton"
        Me.voltarempresasSimpleButton.Size = New System.Drawing.Size(30, 27)
        Me.voltarempresasSimpleButton.TabIndex = 4
        '
        'confirmarempresasSimpleButton
        '
        Me.confirmarempresasSimpleButton.Image = CType(resources.GetObject("confirmarempresasSimpleButton.Image"), System.Drawing.Image)
        Me.confirmarempresasSimpleButton.ImageIndex = 2
        Me.confirmarempresasSimpleButton.ImageList = Me.ImageCollection
        Me.confirmarempresasSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.confirmarempresasSimpleButton.Location = New System.Drawing.Point(384, 6)
        Me.confirmarempresasSimpleButton.Name = "confirmarempresasSimpleButton"
        Me.confirmarempresasSimpleButton.Size = New System.Drawing.Size(30, 27)
        Me.confirmarempresasSimpleButton.TabIndex = 3
        '
        'excluirempresasSimpleButton
        '
        Me.excluirempresasSimpleButton.Image = CType(resources.GetObject("excluirempresasSimpleButton.Image"), System.Drawing.Image)
        Me.excluirempresasSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.excluirempresasSimpleButton.Location = New System.Drawing.Point(73, 6)
        Me.excluirempresasSimpleButton.Name = "excluirempresasSimpleButton"
        Me.excluirempresasSimpleButton.Size = New System.Drawing.Size(30, 27)
        Me.excluirempresasSimpleButton.TabIndex = 2
        '
        'alterarempresasSimpleButton
        '
        Me.alterarempresasSimpleButton.Image = CType(resources.GetObject("alterarempresasSimpleButton.Image"), System.Drawing.Image)
        Me.alterarempresasSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.alterarempresasSimpleButton.Location = New System.Drawing.Point(40, 6)
        Me.alterarempresasSimpleButton.Name = "alterarempresasSimpleButton"
        Me.alterarempresasSimpleButton.Size = New System.Drawing.Size(30, 27)
        Me.alterarempresasSimpleButton.TabIndex = 1
        '
        'incluirempresasSimpleButton
        '
        Me.incluirempresasSimpleButton.Image = CType(resources.GetObject("incluirempresasSimpleButton.Image"), System.Drawing.Image)
        Me.incluirempresasSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.incluirempresasSimpleButton.Location = New System.Drawing.Point(7, 6)
        Me.incluirempresasSimpleButton.Name = "incluirempresasSimpleButton"
        Me.incluirempresasSimpleButton.Size = New System.Drawing.Size(30, 27)
        Me.incluirempresasSimpleButton.TabIndex = 0
        '
        'obrigacoesGroupControl
        '
        Me.obrigacoesGroupControl.Controls.Add(Me.obrigacoesSplitContainerControl)
        Me.obrigacoesGroupControl.Controls.Add(Me.obrigacoesPanelControl)
        Me.obrigacoesGroupControl.Location = New System.Drawing.Point(5, 59)
        Me.obrigacoesGroupControl.Name = "obrigacoesGroupControl"
        Me.obrigacoesGroupControl.Size = New System.Drawing.Size(461, 274)
        Me.obrigacoesGroupControl.TabIndex = 1
        Me.obrigacoesGroupControl.Text = "Relação das Obrigações"
        '
        'obrigacoesSplitContainerControl
        '
        Me.obrigacoesSplitContainerControl.Location = New System.Drawing.Point(5, 69)
        Me.obrigacoesSplitContainerControl.Name = "obrigacoesSplitContainerControl"
        Me.obrigacoesSplitContainerControl.Panel1.Controls.Add(Me.obrigacaoLabelControl)
        Me.obrigacoesSplitContainerControl.Panel1.Controls.Add(Me.obrigacaodescricaoTextEdit)
        Me.obrigacoesSplitContainerControl.Panel1.Controls.Add(Me.obrigacaoSearchLookUpEdit)
        Me.obrigacoesSplitContainerControl.Panel2.Controls.Add(Me.obrigacoesGridControl)
        Me.obrigacoesSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
        Me.obrigacoesSplitContainerControl.Size = New System.Drawing.Size(450, 200)
        Me.obrigacoesSplitContainerControl.TabIndex = 1
        '
        'obrigacaoLabelControl
        '
        Me.obrigacaoLabelControl.Location = New System.Drawing.Point(6, 3)
        Me.obrigacaoLabelControl.Name = "obrigacaoLabelControl"
        Me.obrigacaoLabelControl.Size = New System.Drawing.Size(49, 13)
        Me.obrigacaoLabelControl.TabIndex = 0
        Me.obrigacaoLabelControl.Text = "Obrigação"
        '
        'obrigacaodescricaoTextEdit
        '
        Me.obrigacaodescricaoTextEdit.Enabled = False
        Me.obrigacaodescricaoTextEdit.Location = New System.Drawing.Point(111, 20)
        Me.obrigacaodescricaoTextEdit.Name = "obrigacaodescricaoTextEdit"
        Me.obrigacaodescricaoTextEdit.Properties.AutoHeight = False
        Me.obrigacaodescricaoTextEdit.Size = New System.Drawing.Size(335, 22)
        Me.obrigacaodescricaoTextEdit.TabIndex = 2
        '
        'obrigacaoSearchLookUpEdit
        '
        Me.obrigacaoSearchLookUpEdit.Location = New System.Drawing.Point(6, 20)
        Me.obrigacaoSearchLookUpEdit.Name = "obrigacaoSearchLookUpEdit"
        Me.obrigacaoSearchLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.obrigacaoSearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("obrigacaoSearchLookUpEdit.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.obrigacaoSearchLookUpEdit.Properties.DataSource = Me.obrigacoesInfoBindingSource
        Me.obrigacaoSearchLookUpEdit.Properties.DisplayMember = "obrigacao"
        Me.obrigacaoSearchLookUpEdit.Properties.NullText = ""
        Me.obrigacaoSearchLookUpEdit.Properties.ValueMember = "obrigacao"
        Me.obrigacaoSearchLookUpEdit.Properties.View = Me.obrigacaoGridView
        Me.obrigacaoSearchLookUpEdit.Size = New System.Drawing.Size(100, 22)
        Me.obrigacaoSearchLookUpEdit.TabIndex = 1
        Me.obrigacaoSearchLookUpEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.obrigacaoSearchLookUpEdit.Properties.Mask.MaskType = MaskType.Simple
        Me.obrigacaoSearchLookUpEdit.Properties.Mask.EditMask = "0-00000"
        '
        'obrigacaoGridView
        '
        Me.obrigacaoGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.obrigacaoGridColumn, Me.descricaoGridColumn})
        Me.obrigacaoGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.obrigacaoGridView.Name = "obrigacaoGridView"
        Me.obrigacaoGridView.OptionsFind.AlwaysVisible = True
        Me.obrigacaoGridView.OptionsFind.SearchInPreview = True
        Me.obrigacaoGridView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.obrigacaoGridView.OptionsView.ShowGroupPanel = False
        Me.obrigacaoGridView.Columns(0).ColumnEdit = obrigacaoEdit
        obrigacaoEdit.Mask.UseMaskAsDisplayFormat = True
        obrigacaoEdit.Mask.EditMask = "0-00000"
        obrigacaoEdit.Mask.MaskType = MaskType.Simple
        '
        'obrigacaoGridColumn
        '
        Me.obrigacaoGridColumn.Caption = "Obrigação"
        Me.obrigacaoGridColumn.FieldName = "obrigacao"
        Me.obrigacaoGridColumn.Name = "obrigacaoGridColumn"
        Me.obrigacaoGridColumn.Visible = True
        Me.obrigacaoGridColumn.VisibleIndex = 0
        Me.obrigacaoGridColumn.Width = 80
        '
        'descricaoGridColumn
        '
        Me.descricaoGridColumn.Caption = "Descrição"
        Me.descricaoGridColumn.FieldName = "descricao"
        Me.descricaoGridColumn.Name = "descricaoGridColumn"
        Me.descricaoGridColumn.Visible = True
        Me.descricaoGridColumn.VisibleIndex = 1
        Me.descricaoGridColumn.Width = 200
        '
        'obrigacoesGridControl
        '
        Me.obrigacoesGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.obrigacoesGridControl.Location = New System.Drawing.Point(0, 0)
        Me.obrigacoesGridControl.MainView = Me.obrigacoesGridView
        Me.obrigacoesGridControl.Name = "obrigacoesGridControl"
        Me.obrigacoesGridControl.Size = New System.Drawing.Size(450, 200)
        Me.obrigacoesGridControl.TabIndex = 1
        Me.obrigacoesGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.obrigacoesGridView})
        '
        'obrigacoesGridView
        '
        Me.obrigacoesGridView.GridControl = Me.obrigacoesGridControl
        Me.obrigacoesGridView.Name = "obrigacoesGridView"
        Me.obrigacoesGridView.OptionsBehavior.Editable = False
        Me.obrigacoesGridView.OptionsCustomization.AllowColumnMoving = False
        Me.obrigacoesGridView.OptionsCustomization.AllowColumnResizing = False
        Me.obrigacoesGridView.OptionsCustomization.AllowGroup = False
        Me.obrigacoesGridView.OptionsCustomization.AllowQuickHideColumns = False
        Me.obrigacoesGridView.OptionsView.ShowGroupPanel = False
        '
        'obrigacoesPanelControl
        '
        Me.obrigacoesPanelControl.Controls.Add(Me.voltarobrigacoesSimpleButton)
        Me.obrigacoesPanelControl.Controls.Add(Me.confirmarobrigacoesSimpleButton)
        Me.obrigacoesPanelControl.Controls.Add(Me.excluirobrigacoesSimpleButton)
        Me.obrigacoesPanelControl.Controls.Add(Me.alterarobrigacoesSimpleButton)
        Me.obrigacoesPanelControl.Controls.Add(Me.incluirobrigacoesSimpleButton)
        Me.obrigacoesPanelControl.Location = New System.Drawing.Point(5, 24)
        Me.obrigacoesPanelControl.Name = "obrigacoesPanelControl"
        Me.obrigacoesPanelControl.Size = New System.Drawing.Size(452, 39)
        Me.obrigacoesPanelControl.TabIndex = 0
        '
        'voltarobrigacoesSimpleButton
        '
        Me.voltarobrigacoesSimpleButton.Image = CType(resources.GetObject("voltarobrigacoesSimpleButton.Image"), System.Drawing.Image)
        Me.voltarobrigacoesSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.voltarobrigacoesSimpleButton.Location = New System.Drawing.Point(417, 6)
        Me.voltarobrigacoesSimpleButton.Name = "voltarobrigacoesSimpleButton"
        Me.voltarobrigacoesSimpleButton.Size = New System.Drawing.Size(30, 27)
        Me.voltarobrigacoesSimpleButton.TabIndex = 4
        '
        'confirmarobrigacoesSimpleButton
        '
        Me.confirmarobrigacoesSimpleButton.Image = CType(resources.GetObject("confirmarobrigacoesSimpleButton.Image"), System.Drawing.Image)
        Me.confirmarobrigacoesSimpleButton.ImageIndex = 2
        Me.confirmarobrigacoesSimpleButton.ImageList = Me.ImageCollection
        Me.confirmarobrigacoesSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.confirmarobrigacoesSimpleButton.Location = New System.Drawing.Point(383, 6)
        Me.confirmarobrigacoesSimpleButton.Name = "confirmarobrigacoesSimpleButton"
        Me.confirmarobrigacoesSimpleButton.Size = New System.Drawing.Size(30, 27)
        Me.confirmarobrigacoesSimpleButton.TabIndex = 3
        '
        'excluirobrigacoesSimpleButton
        '
        Me.excluirobrigacoesSimpleButton.Image = CType(resources.GetObject("excluirobrigacoesSimpleButton.Image"), System.Drawing.Image)
        Me.excluirobrigacoesSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.excluirobrigacoesSimpleButton.Location = New System.Drawing.Point(72, 6)
        Me.excluirobrigacoesSimpleButton.Name = "excluirobrigacoesSimpleButton"
        Me.excluirobrigacoesSimpleButton.Size = New System.Drawing.Size(30, 27)
        Me.excluirobrigacoesSimpleButton.TabIndex = 2
        '
        'alterarobrigacoesSimpleButton
        '
        Me.alterarobrigacoesSimpleButton.Image = CType(resources.GetObject("alterarobrigacoesSimpleButton.Image"), System.Drawing.Image)
        Me.alterarobrigacoesSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.alterarobrigacoesSimpleButton.Location = New System.Drawing.Point(39, 6)
        Me.alterarobrigacoesSimpleButton.Name = "alterarobrigacoesSimpleButton"
        Me.alterarobrigacoesSimpleButton.Size = New System.Drawing.Size(30, 27)
        Me.alterarobrigacoesSimpleButton.TabIndex = 1
        '
        'incluirobrigacoesSimpleButton
        '
        Me.incluirobrigacoesSimpleButton.Image = CType(resources.GetObject("incluirobrigacoesSimpleButton.Image"), System.Drawing.Image)
        Me.incluirobrigacoesSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.incluirobrigacoesSimpleButton.Location = New System.Drawing.Point(6, 6)
        Me.incluirobrigacoesSimpleButton.Name = "incluirobrigacoesSimpleButton"
        Me.incluirobrigacoesSimpleButton.Size = New System.Drawing.Size(30, 27)
        Me.incluirobrigacoesSimpleButton.TabIndex = 0
        '
        'voltarSimpleButton
        '
        Me.voltarSimpleButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.voltarSimpleButton.Image = CType(resources.GetObject("voltarSimpleButton.Image"), System.Drawing.Image)
        Me.voltarSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.voltarSimpleButton.Location = New System.Drawing.Point(867, 339)
        Me.voltarSimpleButton.Name = "voltarSimpleButton"
        Me.voltarSimpleButton.Size = New System.Drawing.Size(62, 45)
        Me.voltarSimpleButton.TabIndex = 4
        Me.voltarSimpleButton.Text = "Voltar"
        '
        'okSimpleButton
        '
        Me.okSimpleButton.ImageIndex = 0
        Me.okSimpleButton.ImageList = Me.ImageCollection
        Me.okSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.okSimpleButton.Location = New System.Drawing.Point(801, 339)
        Me.okSimpleButton.Name = "okSimpleButton"
        Me.okSimpleButton.Size = New System.Drawing.Size(62, 45)
        Me.okSimpleButton.TabIndex = 3
        Me.okSimpleButton.Text = "OK"
        '
        'regrasPanelControl
        '
        Me.regrasPanelControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.regrasPanelControl.Controls.Add(Me.descricaoLabelControl)
        Me.regrasPanelControl.Controls.Add(Me.regraLabelControl)
        Me.regrasPanelControl.Controls.Add(Me.descricaoTextEdit)
        Me.regrasPanelControl.Controls.Add(Me.regraTextEdit)
        Me.regrasPanelControl.Location = New System.Drawing.Point(5, 3)
        Me.regrasPanelControl.Name = "regrasPanelControl"
        Me.regrasPanelControl.Size = New System.Drawing.Size(661, 50)
        Me.regrasPanelControl.TabIndex = 0
        '
        'descricaoLabelControl
        '
        Me.descricaoLabelControl.Location = New System.Drawing.Point(93, 5)
        Me.descricaoLabelControl.Name = "descricaoLabelControl"
        Me.descricaoLabelControl.Size = New System.Drawing.Size(46, 13)
        Me.descricaoLabelControl.TabIndex = 2
        Me.descricaoLabelControl.Text = "Descrição"
        '
        'regraLabelControl
        '
        Me.regraLabelControl.Location = New System.Drawing.Point(6, 5)
        Me.regraLabelControl.Name = "regraLabelControl"
        Me.regraLabelControl.Size = New System.Drawing.Size(29, 13)
        Me.regraLabelControl.TabIndex = 0
        Me.regraLabelControl.Text = "Regra"
        '
        'descricaoTextEdit
        '
        Me.descricaoTextEdit.Location = New System.Drawing.Point(93, 22)
        Me.descricaoTextEdit.MenuManager = Me.regrasRibbonControl
        Me.descricaoTextEdit.Name = "descricaoTextEdit"
        Me.descricaoTextEdit.Properties.MaxLength = 100
        Me.descricaoTextEdit.Size = New System.Drawing.Size(563, 20)
        Me.descricaoTextEdit.TabIndex = 3
        '
        'regraTextEdit
        '
        Me.regraTextEdit.Enabled = False
        Me.regraTextEdit.Location = New System.Drawing.Point(6, 22)
        Me.regraTextEdit.MenuManager = Me.regrasRibbonControl
        Me.regraTextEdit.Name = "regraTextEdit"
        Me.regraTextEdit.Size = New System.Drawing.Size(81, 20)
        Me.regraTextEdit.TabIndex = 1
        '
        'regrasGridControl
        '
        Me.regrasGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.regrasGridControl.Location = New System.Drawing.Point(0, 0)
        Me.regrasGridControl.MainView = Me.regrasGridView
        Me.regrasGridControl.Name = "regrasGridControl"
        Me.regrasGridControl.Size = New System.Drawing.Size(0, 0)
        Me.regrasGridControl.TabIndex = 0
        Me.regrasGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.regrasGridView})
        '
        'regrasGridView
        '
        Me.regrasGridView.GridControl = Me.regrasGridControl
        Me.regrasGridView.Name = "regrasGridView"
        Me.regrasGridView.OptionsBehavior.Editable = False
        Me.regrasGridView.OptionsCustomization.AllowColumnMoving = False
        Me.regrasGridView.OptionsCustomization.AllowColumnResizing = False
        Me.regrasGridView.OptionsCustomization.AllowGroup = False
        Me.regrasGridView.OptionsCustomization.AllowQuickHideColumns = False
        Me.regrasGridView.OptionsView.ShowGroupPanel = False
        '
        'regrasXtraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(936, 482)
        Me.Controls.Add(Me.regrasSplitContainerControl)
        Me.Controls.Add(Me.regrasRibbonControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "regrasXtraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Regras"
        CType(Me.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.empresasInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacoesInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.regrasSplitContainerControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.regrasSplitContainerControl.ResumeLayout(False)
        CType(Me.empresasGroupControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.empresasGroupControl.ResumeLayout(False)
        CType(Me.empresasSplitContainerControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.empresasSplitContainerControl.ResumeLayout(False)
        CType(Me.razaosocialTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.empresaSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.empresaGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.empresasGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.empresasGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.regrasRibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.empresasPanelControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.empresasPanelControl.ResumeLayout(False)
        CType(Me.obrigacoesGroupControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.obrigacoesGroupControl.ResumeLayout(False)
        CType(Me.obrigacoesSplitContainerControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.obrigacoesSplitContainerControl.ResumeLayout(False)
        CType(Me.obrigacaodescricaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacaoSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacaoGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacoesGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacoesGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacoesPanelControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.obrigacoesPanelControl.ResumeLayout(False)
        CType(Me.regrasPanelControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.regrasPanelControl.ResumeLayout(False)
        Me.regrasPanelControl.PerformLayout()
        CType(Me.descricaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.regraTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.regrasGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.regrasGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImageCollection As DevExpress.Utils.ImageCollection
    Friend WithEvents empresasInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents obrigacoesInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents regrasSplitContainerControl As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents voltarSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents okSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents regrasPanelControl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents regrasGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents regrasRibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents incluirBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents alterarBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents excluirBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents localizarBarCheckItem As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents empresaobrigacaoRibbonPage As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents regrasRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents empresasGroupControl As DevExpress.XtraEditors.GroupControl
    Friend WithEvents empresasSplitContainerControl As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents empresasPanelControl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents voltarempresasSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents confirmarempresasSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents excluirempresasSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents alterarempresasSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents incluirempresasSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents obrigacoesGroupControl As DevExpress.XtraEditors.GroupControl
    Friend WithEvents obrigacoesSplitContainerControl As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents obrigacoesPanelControl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents voltarobrigacoesSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents confirmarobrigacoesSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents excluirobrigacoesSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents alterarobrigacoesSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents incluirobrigacoesSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents empresasGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents empresasGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents empresaLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents razaosocialTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents empresaSearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents empresaGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents empresaGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents razaosocialGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents obrigacaoLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents obrigacaodescricaoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents obrigacaoSearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents obrigacaoGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents obrigacaoGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents descricaoGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents descricaoLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents regraLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents descricaoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents regraTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents regrasGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents obrigacoesGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents obrigacoesGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents atualizarBarButtonItem As DevExpress.XtraBars.BarButtonItem
End Class
