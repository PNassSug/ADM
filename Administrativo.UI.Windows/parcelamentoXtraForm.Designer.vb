Imports DevExpress.XtraEditors.Mask
Imports DevExpress.XtraEditors.Repository

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class parcelamentoXtraForm
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(parcelamentoXtraForm))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.parcelamentoobrigacoesGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.parcelamentosGridControl = New DevExpress.XtraGrid.GridControl()
        Me.parcelamentosGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.parcelamentodetalhesGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.empresasInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.parcelamentoRibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.incluirBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.alterarBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.excluirBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.localizarBarCheckItem = New DevExpress.XtraBars.BarCheckItem()
        Me.atualizarBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.parcelamentoRibbonPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.regrasRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.obrigacoesInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.parcelamentoSplitContainerControl = New DevExpress.XtraEditors.SplitContainerControl()
        Me.detalhesGroupControl = New DevExpress.XtraEditors.GroupControl()
        Me.detalhesGridControl = New DevExpress.XtraGrid.GridControl()
        Me.detalhesGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.voltarSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.okSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.parcelamentoPanelControl = New DevExpress.XtraEditors.PanelControl()
        Me.periodoLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.periodoPanelControl = New DevExpress.XtraEditors.PanelControl()
        Me.competenciainicialTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.competenciafinalLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.competenciafinalTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.competenciainicialLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.obrigacaoLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.descricaoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.obrigacaoSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.obrigacaoGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.obrigacaoGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.descricaoGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.empresaLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.razaosocialTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.empresaSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.empresaGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.empresaGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.razaosocialGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.statusImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        CType(Me.parcelamentoobrigacoesGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.parcelamentosGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.parcelamentosGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.parcelamentodetalhesGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresasInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.parcelamentoRibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacoesInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.parcelamentoSplitContainerControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.parcelamentoSplitContainerControl.SuspendLayout()
        CType(Me.detalhesGroupControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.detalhesGroupControl.SuspendLayout()
        CType(Me.detalhesGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.detalhesGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.parcelamentoPanelControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.parcelamentoPanelControl.SuspendLayout()
        CType(Me.periodoPanelControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.periodoPanelControl.SuspendLayout()
        CType(Me.competenciainicialTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.competenciafinalTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.descricaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacaoSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacaoGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.razaosocialTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresaSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresaGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.statusImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'parcelamentoobrigacoesGridView
        '
        Me.parcelamentoobrigacoesGridView.GridControl = Me.parcelamentosGridControl
        Me.parcelamentoobrigacoesGridView.Name = "parcelamentoobrigacoesGridView"
        '
        'parcelamentosGridControl
        '
        Me.parcelamentosGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.parcelamentoobrigacoesGridView
        GridLevelNode2.LevelTemplate = Me.parcelamentodetalhesGridView
        GridLevelNode2.RelationName = "detalhe"
        GridLevelNode1.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        GridLevelNode1.RelationName = "obrigacao"
        Me.parcelamentosGridControl.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.parcelamentosGridControl.Location = New System.Drawing.Point(0, 0)
        Me.parcelamentosGridControl.MainView = Me.parcelamentosGridView
        Me.parcelamentosGridControl.Name = "parcelamentosGridControl"
        Me.parcelamentosGridControl.Size = New System.Drawing.Size(0, 0)
        Me.parcelamentosGridControl.TabIndex = 1
        Me.parcelamentosGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.parcelamentosGridView, Me.parcelamentodetalhesGridView, Me.parcelamentoobrigacoesGridView})
        '
        'parcelamentosGridView
        '
        Me.parcelamentosGridView.GridControl = Me.parcelamentosGridControl
        Me.parcelamentosGridView.Name = "parcelamentosGridView"
        Me.parcelamentosGridView.OptionsBehavior.Editable = False
        Me.parcelamentosGridView.OptionsCustomization.AllowColumnMoving = False
        Me.parcelamentosGridView.OptionsCustomization.AllowColumnResizing = False
        Me.parcelamentosGridView.OptionsCustomization.AllowGroup = False
        Me.parcelamentosGridView.OptionsCustomization.AllowQuickHideColumns = False
        Me.parcelamentosGridView.OptionsView.ShowGroupPanel = False
        '
        'parcelamentodetalhesGridView
        '
        Me.parcelamentodetalhesGridView.GridControl = Me.parcelamentosGridControl
        Me.parcelamentodetalhesGridView.Name = "parcelamentodetalhesGridView"
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
        'parcelamentoRibbonControl
        '
        Me.parcelamentoRibbonControl.ExpandCollapseItem.Id = 0
        Me.parcelamentoRibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.parcelamentoRibbonControl.ExpandCollapseItem, Me.incluirBarButtonItem, Me.alterarBarButtonItem, Me.excluirBarButtonItem, Me.localizarBarCheckItem, Me.atualizarBarButtonItem})
        Me.parcelamentoRibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.parcelamentoRibbonControl.MaxItemId = 6
        Me.parcelamentoRibbonControl.Name = "parcelamentoRibbonControl"
        Me.parcelamentoRibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.parcelamentoRibbonPage})
        Me.parcelamentoRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.parcelamentoRibbonControl.ShowCategoryInCaption = False
        Me.parcelamentoRibbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.parcelamentoRibbonControl.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.parcelamentoRibbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.parcelamentoRibbonControl.ShowToolbarCustomizeItem = False
        Me.parcelamentoRibbonControl.Size = New System.Drawing.Size(734, 96)
        Me.parcelamentoRibbonControl.Toolbar.ShowCustomizeItem = False
        Me.parcelamentoRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'incluirBarButtonItem
        '
        Me.incluirBarButtonItem.Caption = "Incluir"
        Me.incluirBarButtonItem.Glyph = CType(resources.GetObject("incluirBarButtonItem.Glyph"), System.Drawing.Image)
        Me.incluirBarButtonItem.Id = 1
        Me.incluirBarButtonItem.Name = "incluirBarButtonItem"
        Me.incluirBarButtonItem.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        Me.incluirBarButtonItem.Tag = "movparinc"
        Me.incluirBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInRuntime
        '
        'alterarBarButtonItem
        '
        Me.alterarBarButtonItem.Caption = "Alterar"
        Me.alterarBarButtonItem.Glyph = CType(resources.GetObject("alterarBarButtonItem.Glyph"), System.Drawing.Image)
        Me.alterarBarButtonItem.Id = 2
        Me.alterarBarButtonItem.Name = "alterarBarButtonItem"
        Me.alterarBarButtonItem.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        Me.alterarBarButtonItem.Tag = "movparalt"
        Me.alterarBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInRuntime
        '
        'excluirBarButtonItem
        '
        Me.excluirBarButtonItem.Caption = "Excluir"
        Me.excluirBarButtonItem.Glyph = CType(resources.GetObject("excluirBarButtonItem.Glyph"), System.Drawing.Image)
        Me.excluirBarButtonItem.Id = 3
        Me.excluirBarButtonItem.Name = "excluirBarButtonItem"
        Me.excluirBarButtonItem.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        Me.excluirBarButtonItem.Tag = "movparexc"
        Me.excluirBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInRuntime
        '
        'localizarBarCheckItem
        '
        Me.localizarBarCheckItem.Caption = "Localizar"
        Me.localizarBarCheckItem.Glyph = CType(resources.GetObject("localizarBarCheckItem.Glyph"), System.Drawing.Image)
        Me.localizarBarCheckItem.Id = 4
        Me.localizarBarCheckItem.Name = "localizarBarCheckItem"
        Me.localizarBarCheckItem.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'atualizarBarButtonItem
        '
        Me.atualizarBarButtonItem.Caption = "Atualizar"
        Me.atualizarBarButtonItem.Glyph = CType(resources.GetObject("atualizarBarButtonItem.Glyph"), System.Drawing.Image)
        Me.atualizarBarButtonItem.Id = 5
        Me.atualizarBarButtonItem.Name = "atualizarBarButtonItem"
        Me.atualizarBarButtonItem.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'parcelamentoRibbonPage
        '
        Me.parcelamentoRibbonPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.regrasRibbonPageGroup})
        Me.parcelamentoRibbonPage.Name = "parcelamentoRibbonPage"
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
        'parcelamentoSplitContainerControl
        '
        Me.parcelamentoSplitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.parcelamentoSplitContainerControl.Location = New System.Drawing.Point(0, 96)
        Me.parcelamentoSplitContainerControl.Name = "parcelamentoSplitContainerControl"
        Me.parcelamentoSplitContainerControl.Panel1.Controls.Add(Me.detalhesGroupControl)
        Me.parcelamentoSplitContainerControl.Panel1.Controls.Add(Me.voltarSimpleButton)
        Me.parcelamentoSplitContainerControl.Panel1.Controls.Add(Me.okSimpleButton)
        Me.parcelamentoSplitContainerControl.Panel1.Controls.Add(Me.parcelamentoPanelControl)
        Me.parcelamentoSplitContainerControl.Panel1.Text = "Panel1"
        Me.parcelamentoSplitContainerControl.Panel2.Controls.Add(Me.parcelamentosGridControl)
        Me.parcelamentoSplitContainerControl.Panel2.Text = "Panel2"
        Me.parcelamentoSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
        Me.parcelamentoSplitContainerControl.Size = New System.Drawing.Size(734, 425)
        Me.parcelamentoSplitContainerControl.SplitterPosition = 110
        Me.parcelamentoSplitContainerControl.TabIndex = 6
        '
        'detalhesGroupControl
        '
        Me.detalhesGroupControl.Controls.Add(Me.detalhesGridControl)
        Me.detalhesGroupControl.Location = New System.Drawing.Point(4, 112)
        Me.detalhesGroupControl.Name = "detalhesGroupControl"
        Me.detalhesGroupControl.Size = New System.Drawing.Size(726, 261)
        Me.detalhesGroupControl.TabIndex = 5
        Me.detalhesGroupControl.Text = "Detalhes dos Parcelamentos"
        '
        'detalhesGridControl
        '
        Me.detalhesGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.detalhesGridControl.Location = New System.Drawing.Point(2, 21)
        Me.detalhesGridControl.MainView = Me.detalhesGridView
        Me.detalhesGridControl.Name = "detalhesGridControl"
        Me.detalhesGridControl.Size = New System.Drawing.Size(722, 238)
        Me.detalhesGridControl.TabIndex = 0
        Me.detalhesGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.detalhesGridView})
        '
        'detalhesGridView
        '
        Me.detalhesGridView.GridControl = Me.detalhesGridControl
        Me.detalhesGridView.Name = "detalhesGridView"
        Me.detalhesGridView.OptionsBehavior.Editable = False
        Me.detalhesGridView.OptionsCustomization.AllowColumnMoving = False
        Me.detalhesGridView.OptionsCustomization.AllowColumnResizing = False
        Me.detalhesGridView.OptionsCustomization.AllowGroup = False
        Me.detalhesGridView.OptionsCustomization.AllowQuickHideColumns = False
        Me.detalhesGridView.OptionsView.ShowGroupPanel = False
        '
        'voltarSimpleButton
        '
        Me.voltarSimpleButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.voltarSimpleButton.Image = CType(resources.GetObject("voltarSimpleButton.Image"), System.Drawing.Image)
        Me.voltarSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.voltarSimpleButton.Location = New System.Drawing.Point(669, 377)
        Me.voltarSimpleButton.Name = "voltarSimpleButton"
        Me.voltarSimpleButton.Size = New System.Drawing.Size(62, 45)
        Me.voltarSimpleButton.TabIndex = 7
        Me.voltarSimpleButton.Text = "Voltar"
        '
        'okSimpleButton
        '
        Me.okSimpleButton.ImageIndex = 0
        Me.okSimpleButton.ImageList = Me.ImageCollection
        Me.okSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.okSimpleButton.Location = New System.Drawing.Point(603, 377)
        Me.okSimpleButton.Name = "okSimpleButton"
        Me.okSimpleButton.Size = New System.Drawing.Size(62, 45)
        Me.okSimpleButton.TabIndex = 6
        Me.okSimpleButton.Text = "OK"
        '
        'parcelamentoPanelControl
        '
        Me.parcelamentoPanelControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.parcelamentoPanelControl.Controls.Add(Me.periodoLabelControl)
        Me.parcelamentoPanelControl.Controls.Add(Me.periodoPanelControl)
        Me.parcelamentoPanelControl.Controls.Add(Me.obrigacaoLabelControl)
        Me.parcelamentoPanelControl.Controls.Add(Me.descricaoTextEdit)
        Me.parcelamentoPanelControl.Controls.Add(Me.obrigacaoSearchLookUpEdit)
        Me.parcelamentoPanelControl.Controls.Add(Me.empresaLabelControl)
        Me.parcelamentoPanelControl.Controls.Add(Me.razaosocialTextEdit)
        Me.parcelamentoPanelControl.Controls.Add(Me.empresaSearchLookUpEdit)
        Me.parcelamentoPanelControl.Location = New System.Drawing.Point(4, 2)
        Me.parcelamentoPanelControl.Name = "parcelamentoPanelControl"
        Me.parcelamentoPanelControl.Size = New System.Drawing.Size(726, 104)
        Me.parcelamentoPanelControl.TabIndex = 4
        '
        'periodoLabelControl
        '
        Me.periodoLabelControl.Location = New System.Drawing.Point(589, 39)
        Me.periodoLabelControl.Name = "periodoLabelControl"
        Me.periodoLabelControl.Size = New System.Drawing.Size(119, 13)
        Me.periodoLabelControl.TabIndex = 8
        Me.periodoLabelControl.Text = "Período de Parcelamento"
        '
        'periodoPanelControl
        '
        Me.periodoPanelControl.Controls.Add(Me.competenciainicialTextEdit)
        Me.periodoPanelControl.Controls.Add(Me.competenciafinalLabelControl)
        Me.periodoPanelControl.Controls.Add(Me.competenciafinalTextEdit)
        Me.periodoPanelControl.Controls.Add(Me.competenciainicialLabelControl)
        Me.periodoPanelControl.Location = New System.Drawing.Point(580, 46)
        Me.periodoPanelControl.Name = "periodoPanelControl"
        Me.periodoPanelControl.Size = New System.Drawing.Size(142, 52)
        Me.periodoPanelControl.TabIndex = 9
        '
        'competenciainicialTextEdit
        '
        Me.competenciainicialTextEdit.Location = New System.Drawing.Point(9, 23)
        Me.competenciainicialTextEdit.Name = "competenciainicialTextEdit"
        Me.competenciainicialTextEdit.Properties.AutoHeight = False
        Me.competenciainicialTextEdit.Properties.Mask.EditMask = "00/0000"
        Me.competenciainicialTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.competenciainicialTextEdit.Properties.Mask.SaveLiteral = False
        Me.competenciainicialTextEdit.Properties.Mask.ShowPlaceHolders = False
        Me.competenciainicialTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.competenciainicialTextEdit.Size = New System.Drawing.Size(61, 22)
        Me.competenciainicialTextEdit.TabIndex = 11
        '
        'competenciafinalLabelControl
        '
        Me.competenciafinalLabelControl.Location = New System.Drawing.Point(74, 6)
        Me.competenciafinalLabelControl.Name = "competenciafinalLabelControl"
        Me.competenciafinalLabelControl.Size = New System.Drawing.Size(22, 13)
        Me.competenciafinalLabelControl.TabIndex = 12
        Me.competenciafinalLabelControl.Text = "Final"
        '
        'competenciafinalTextEdit
        '
        Me.competenciafinalTextEdit.Location = New System.Drawing.Point(74, 23)
        Me.competenciafinalTextEdit.Name = "competenciafinalTextEdit"
        Me.competenciafinalTextEdit.Properties.AutoHeight = False
        Me.competenciafinalTextEdit.Properties.Mask.EditMask = "00/0000"
        Me.competenciafinalTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.competenciafinalTextEdit.Properties.Mask.SaveLiteral = False
        Me.competenciafinalTextEdit.Properties.Mask.ShowPlaceHolders = False
        Me.competenciafinalTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.competenciafinalTextEdit.Size = New System.Drawing.Size(61, 22)
        Me.competenciafinalTextEdit.TabIndex = 13
        '
        'competenciainicialLabelControl
        '
        Me.competenciainicialLabelControl.Location = New System.Drawing.Point(9, 6)
        Me.competenciainicialLabelControl.Name = "competenciainicialLabelControl"
        Me.competenciainicialLabelControl.Size = New System.Drawing.Size(27, 13)
        Me.competenciainicialLabelControl.TabIndex = 10
        Me.competenciainicialLabelControl.Text = "Inicial"
        '
        'obrigacaoLabelControl
        '
        Me.obrigacaoLabelControl.Location = New System.Drawing.Point(6, 48)
        Me.obrigacaoLabelControl.Name = "obrigacaoLabelControl"
        Me.obrigacaoLabelControl.Size = New System.Drawing.Size(49, 13)
        Me.obrigacaoLabelControl.TabIndex = 3
        Me.obrigacaoLabelControl.Text = "Obrigação"
        '
        'descricaoTextEdit
        '
        Me.descricaoTextEdit.Enabled = False
        Me.descricaoTextEdit.Location = New System.Drawing.Point(110, 65)
        Me.descricaoTextEdit.Name = "descricaoTextEdit"
        Me.descricaoTextEdit.Properties.AutoHeight = False
        Me.descricaoTextEdit.Size = New System.Drawing.Size(464, 22)
        Me.descricaoTextEdit.TabIndex = 5
        '
        'obrigacaoSearchLookUpEdit
        '
        Me.obrigacaoSearchLookUpEdit.Enabled = False
        Me.obrigacaoSearchLookUpEdit.Location = New System.Drawing.Point(6, 65)
        Me.obrigacaoSearchLookUpEdit.Name = "obrigacaoSearchLookUpEdit"
        Me.obrigacaoSearchLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.obrigacaoSearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("obrigacaoSearchLookUpEdit.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.obrigacaoSearchLookUpEdit.Properties.DataSource = Me.obrigacoesInfoBindingSource
        Me.obrigacaoSearchLookUpEdit.Properties.DisplayMember = "obrigacao"
        Me.obrigacaoSearchLookUpEdit.Properties.NullText = ""
        Me.obrigacaoSearchLookUpEdit.Properties.ValueMember = "obrigacao"
        Me.obrigacaoSearchLookUpEdit.Properties.View = Me.obrigacaoGridView
        Me.obrigacaoSearchLookUpEdit.Size = New System.Drawing.Size(100, 22)
        Me.obrigacaoSearchLookUpEdit.TabIndex = 4
        Me.obrigacaoSearchLookUpEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.obrigacaoSearchLookUpEdit.Properties.Mask.MaskType = MaskType.Numeric
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
        obrigacaoEdit.Mask.MaskType = MaskType.Simple
        obrigacaoEdit.Mask.UseMaskAsDisplayFormat = True
        obrigacaoEdit.Mask.EditMask = "0-00000"
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
        Me.razaosocialTextEdit.Size = New System.Drawing.Size(612, 20)
        Me.razaosocialTextEdit.TabIndex = 2
        '
        'empresaSearchLookUpEdit
        '
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
        Me.razaosocialGridColumn.Caption = "Razão Social"
        Me.razaosocialGridColumn.FieldName = "razaosocial"
        Me.razaosocialGridColumn.Name = "razaosocialGridColumn"
        Me.razaosocialGridColumn.Visible = True
        Me.razaosocialGridColumn.VisibleIndex = 1
        Me.razaosocialGridColumn.Width = 200
        '
        'statusImageCollection
        '
        Me.statusImageCollection.ImageStream = CType(resources.GetObject("statusImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.statusImageCollection.Images.SetKeyName(0, "pawn_glass_red.png")
        Me.statusImageCollection.Images.SetKeyName(1, "pawn_glass_yellow.png")
        Me.statusImageCollection.Images.SetKeyName(2, "pawn_glass_green.png")
        '
        'parcelamentoXtraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 521)
        Me.Controls.Add(Me.parcelamentoSplitContainerControl)
        Me.Controls.Add(Me.parcelamentoRibbonControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "parcelamentoXtraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Geração de Parcelamento das Obrigações"
        CType(Me.parcelamentoobrigacoesGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.parcelamentosGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.parcelamentosGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.parcelamentodetalhesGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.empresasInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.parcelamentoRibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacoesInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.parcelamentoSplitContainerControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.parcelamentoSplitContainerControl.ResumeLayout(False)
        CType(Me.detalhesGroupControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.detalhesGroupControl.ResumeLayout(False)
        CType(Me.detalhesGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.detalhesGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.parcelamentoPanelControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.parcelamentoPanelControl.ResumeLayout(False)
        Me.parcelamentoPanelControl.PerformLayout()
        CType(Me.periodoPanelControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.periodoPanelControl.ResumeLayout(False)
        Me.periodoPanelControl.PerformLayout()
        CType(Me.competenciainicialTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.competenciafinalTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.descricaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacaoSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacaoGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.razaosocialTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.empresaSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.empresaGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.statusImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents empresasInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ImageCollection As DevExpress.Utils.ImageCollection
    Friend WithEvents parcelamentoRibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents incluirBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents alterarBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents excluirBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents localizarBarCheckItem As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents atualizarBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents parcelamentoRibbonPage As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents regrasRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents obrigacoesInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents parcelamentoSplitContainerControl As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents detalhesGroupControl As DevExpress.XtraEditors.GroupControl
    Friend WithEvents detalhesGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents detalhesGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents voltarSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents okSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents parcelamentoPanelControl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents periodoLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents periodoPanelControl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents competenciainicialTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents competenciafinalLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents competenciafinalTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents competenciainicialLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents obrigacaoLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents descricaoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents obrigacaoSearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents obrigacaoGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents obrigacaoGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents descricaoGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents empresaLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents razaosocialTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents empresaSearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents empresaGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents empresaGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents razaosocialGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents parcelamentosGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents parcelamentoobrigacoesGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents parcelamentosGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents parcelamentodetalhesGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents statusImageCollection As DevExpress.Utils.ImageCollection
End Class
