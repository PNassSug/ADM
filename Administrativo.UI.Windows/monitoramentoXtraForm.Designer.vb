<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class monitoramentoXtraForm
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode3 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode4 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(monitoramentoXtraForm))
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim SeriesPoint1 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Não geradas", New Object() {CType(10.0R, Object)})
        Dim SideBySideBarSeriesView1 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim RectangleGradientFillOptions1 As DevExpress.XtraCharts.RectangleGradientFillOptions = New DevExpress.XtraCharts.RectangleGradientFillOptions()
        Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesLabel2 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim SeriesPoint2 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Geradas", New Object() {CType(20.0R, Object)})
        Dim SideBySideBarSeriesView2 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim RectangleGradientFillOptions2 As DevExpress.XtraCharts.RectangleGradientFillOptions = New DevExpress.XtraCharts.RectangleGradientFillOptions()
        Dim Series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesLabel3 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim SeriesPoint3 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Conferido para entrega", New Object() {CType(30.0R, Object)})
        Dim SideBySideBarSeriesView3 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim RectangleGradientFillOptions3 As DevExpress.XtraCharts.RectangleGradientFillOptions = New DevExpress.XtraCharts.RectangleGradientFillOptions()
        Dim Series4 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesLabel4 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim SeriesPoint4 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Conferido pelo encarregado", New Object() {CType(40.0R, Object)})
        Dim SideBySideBarSeriesView4 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim RectangleGradientFillOptions4 As DevExpress.XtraCharts.RectangleGradientFillOptions = New DevExpress.XtraCharts.RectangleGradientFillOptions()
        Me.monitoramentoempresaGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.monitoramentoGridControl = New DevExpress.XtraGrid.GridControl()
        Me.monitoramentoempresadetalheGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.informeGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.funcionarioGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.monitoramentoGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.monitoramentoRibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.filtroImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.localizarBarCheckItem = New DevExpress.XtraBars.BarCheckItem()
        Me.detalhadoBarCheckItem = New DevExpress.XtraBars.BarCheckItem()
        Me.geralBarCheckItem = New DevExpress.XtraBars.BarCheckItem()
        Me.atualizarBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.filtroBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.monitoramentoRibbonPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.monitoramentoRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.monitoramentoSplitContainerControl = New DevExpress.XtraEditors.SplitContainerControl()
        Me.monitoramentoChartControl = New DevExpress.XtraCharts.ChartControl()
        Me.statusImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.navegadorPanelControl = New DevExpress.XtraEditors.PanelControl()
        Me.navegacaoLabelControl = New DevExpress.XtraEditors.LabelControl()
        CType(Me.monitoramentoempresaGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.monitoramentoGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.monitoramentoempresadetalheGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.informeGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.funcionarioGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.monitoramentoGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.monitoramentoRibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.filtroImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.monitoramentoSplitContainerControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.monitoramentoSplitContainerControl.SuspendLayout()
        CType(Me.monitoramentoChartControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.statusImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.navegadorPanelControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.navegadorPanelControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'monitoramentoempresaGridView
        '
        Me.monitoramentoempresaGridView.GridControl = Me.monitoramentoGridControl
        Me.monitoramentoempresaGridView.Name = "monitoramentoempresaGridView"
        Me.monitoramentoempresaGridView.OptionsBehavior.Editable = False
        Me.monitoramentoempresaGridView.OptionsView.ShowGroupPanel = False
        '
        'monitoramentoGridControl
        '
        Me.monitoramentoGridControl.Dock = System.Windows.Forms.DockStyle.Bottom
        GridLevelNode1.LevelTemplate = Me.monitoramentoempresaGridView
        GridLevelNode1.RelationName = "empresa"
        GridLevelNode2.LevelTemplate = Me.monitoramentoempresadetalheGridView
        GridLevelNode3.LevelTemplate = Me.informeGridView
        GridLevelNode3.RelationName = "informe"
        GridLevelNode4.LevelTemplate = Me.funcionarioGridView
        GridLevelNode4.RelationName = "funcionario"
        GridLevelNode2.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode3, GridLevelNode4})
        GridLevelNode2.RelationName = "empresadetalhe"
        Me.monitoramentoGridControl.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1, GridLevelNode2})
        Me.monitoramentoGridControl.Location = New System.Drawing.Point(0, 32)
        Me.monitoramentoGridControl.MainView = Me.monitoramentoGridView
        Me.monitoramentoGridControl.Name = "monitoramentoGridControl"
        Me.monitoramentoGridControl.Size = New System.Drawing.Size(1183, 445)
        Me.monitoramentoGridControl.TabIndex = 1
        Me.monitoramentoGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.monitoramentoempresadetalheGridView, Me.informeGridView, Me.funcionarioGridView, Me.monitoramentoGridView, Me.monitoramentoempresaGridView})
        '
        'monitoramentoempresadetalheGridView
        '
        Me.monitoramentoempresadetalheGridView.GridControl = Me.monitoramentoGridControl
        Me.monitoramentoempresadetalheGridView.Name = "monitoramentoempresadetalheGridView"
        Me.monitoramentoempresadetalheGridView.OptionsBehavior.Editable = False
        Me.monitoramentoempresadetalheGridView.OptionsView.ShowGroupPanel = False
        '
        'informeGridView
        '
        Me.informeGridView.GridControl = Me.monitoramentoGridControl
        Me.informeGridView.Name = "informeGridView"
        Me.informeGridView.OptionsBehavior.Editable = False
        Me.informeGridView.OptionsView.ShowGroupPanel = False
        '
        'funcionarioGridView
        '
        Me.funcionarioGridView.GridControl = Me.monitoramentoGridControl
        Me.funcionarioGridView.Name = "funcionarioGridView"
        Me.funcionarioGridView.OptionsBehavior.Editable = False
        Me.funcionarioGridView.OptionsView.ShowGroupPanel = False
        '
        'monitoramentoGridView
        '
        Me.monitoramentoGridView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.monitoramentoGridView.ColumnPanelRowHeight = 40
        Me.monitoramentoGridView.GridControl = Me.monitoramentoGridControl
        Me.monitoramentoGridView.Name = "monitoramentoGridView"
        Me.monitoramentoGridView.OptionsBehavior.Editable = False
        Me.monitoramentoGridView.OptionsView.ColumnAutoWidth = False
        Me.monitoramentoGridView.OptionsView.ShowGroupPanel = False
        '
        'monitoramentoRibbonControl
        '
        Me.monitoramentoRibbonControl.ExpandCollapseItem.Id = 0
        Me.monitoramentoRibbonControl.Images = Me.filtroImageCollection
        Me.monitoramentoRibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.monitoramentoRibbonControl.ExpandCollapseItem, Me.localizarBarCheckItem, Me.detalhadoBarCheckItem, Me.geralBarCheckItem, Me.atualizarBarButtonItem, Me.filtroBarButtonItem})
        Me.monitoramentoRibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.monitoramentoRibbonControl.MaxItemId = 9
        Me.monitoramentoRibbonControl.Name = "monitoramentoRibbonControl"
        Me.monitoramentoRibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.monitoramentoRibbonPage})
        Me.monitoramentoRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.monitoramentoRibbonControl.ShowCategoryInCaption = False
        Me.monitoramentoRibbonControl.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.monitoramentoRibbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.monitoramentoRibbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.monitoramentoRibbonControl.ShowToolbarCustomizeItem = False
        Me.monitoramentoRibbonControl.Size = New System.Drawing.Size(1183, 95)
        Me.monitoramentoRibbonControl.Toolbar.ShowCustomizeItem = False
        Me.monitoramentoRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'filtroImageCollection
        '
        Me.filtroImageCollection.ImageSize = New System.Drawing.Size(48, 48)
        Me.filtroImageCollection.ImageStream = CType(resources.GetObject("filtroImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.filtroImageCollection.Images.SetKeyName(0, "funnel.png")
        Me.filtroImageCollection.Images.SetKeyName(1, "funnel_preferences.png")
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
        'detalhadoBarCheckItem
        '
        Me.detalhadoBarCheckItem.Caption = "Detalhado"
        Me.detalhadoBarCheckItem.Glyph = CType(resources.GetObject("detalhadoBarCheckItem.Glyph"), System.Drawing.Image)
        Me.detalhadoBarCheckItem.Id = 5
        Me.detalhadoBarCheckItem.Name = "detalhadoBarCheckItem"
        Me.detalhadoBarCheckItem.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'geralBarCheckItem
        '
        Me.geralBarCheckItem.Caption = "Geral"
        Me.geralBarCheckItem.Glyph = CType(resources.GetObject("geralBarCheckItem.Glyph"), System.Drawing.Image)
        Me.geralBarCheckItem.Id = 6
        Me.geralBarCheckItem.Name = "geralBarCheckItem"
        Me.geralBarCheckItem.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'atualizarBarButtonItem
        '
        Me.atualizarBarButtonItem.Caption = "Atualizar"
        Me.atualizarBarButtonItem.Glyph = CType(resources.GetObject("atualizarBarButtonItem.Glyph"), System.Drawing.Image)
        Me.atualizarBarButtonItem.Id = 7
        Me.atualizarBarButtonItem.Name = "atualizarBarButtonItem"
        Me.atualizarBarButtonItem.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'filtroBarButtonItem
        '
        Me.filtroBarButtonItem.Caption = "Filtrar por"
        Me.filtroBarButtonItem.Id = 8
        Me.filtroBarButtonItem.ImageIndex = 0
        Me.filtroBarButtonItem.Name = "filtroBarButtonItem"
        Me.filtroBarButtonItem.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'monitoramentoRibbonPage
        '
        Me.monitoramentoRibbonPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.monitoramentoRibbonPageGroup})
        Me.monitoramentoRibbonPage.Name = "monitoramentoRibbonPage"
        Me.monitoramentoRibbonPage.Text = "RibbonPage1"
        '
        'monitoramentoRibbonPageGroup
        '
        Me.monitoramentoRibbonPageGroup.ItemLinks.Add(Me.detalhadoBarCheckItem)
        Me.monitoramentoRibbonPageGroup.ItemLinks.Add(Me.geralBarCheckItem)
        Me.monitoramentoRibbonPageGroup.ItemLinks.Add(Me.localizarBarCheckItem)
        Me.monitoramentoRibbonPageGroup.ItemLinks.Add(Me.atualizarBarButtonItem)
        Me.monitoramentoRibbonPageGroup.ItemLinks.Add(Me.filtroBarButtonItem)
        Me.monitoramentoRibbonPageGroup.Name = "monitoramentoRibbonPageGroup"
        Me.monitoramentoRibbonPageGroup.ShowCaptionButton = False
        '
        'monitoramentoSplitContainerControl
        '
        Me.monitoramentoSplitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.monitoramentoSplitContainerControl.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None
        Me.monitoramentoSplitContainerControl.Location = New System.Drawing.Point(0, 95)
        Me.monitoramentoSplitContainerControl.Name = "monitoramentoSplitContainerControl"
        Me.monitoramentoSplitContainerControl.Panel1.Controls.Add(Me.monitoramentoChartControl)
        Me.monitoramentoSplitContainerControl.Panel2.Controls.Add(Me.monitoramentoGridControl)
        Me.monitoramentoSplitContainerControl.Panel2.Text = "Panel2"
        Me.monitoramentoSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
        Me.monitoramentoSplitContainerControl.Size = New System.Drawing.Size(1183, 477)
        Me.monitoramentoSplitContainerControl.SplitterPosition = 99
        Me.monitoramentoSplitContainerControl.TabIndex = 4
        '
        'monitoramentoChartControl
        '
        Me.monitoramentoChartControl.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.monitoramentoChartControl.DataBindings = Nothing
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        Me.monitoramentoChartControl.Diagram = XyDiagram1
        Me.monitoramentoChartControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.monitoramentoChartControl.Legend.Name = "Default Legend"
        Me.monitoramentoChartControl.Location = New System.Drawing.Point(0, 0)
        Me.monitoramentoChartControl.Name = "monitoramentoChartControl"
        SideBySideBarSeriesLabel1.Border.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        SideBySideBarSeriesLabel1.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        SideBySideBarSeriesLabel1.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Series1.Label = SideBySideBarSeriesLabel1
        Series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series1.Name = "Não geradas"
        Series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {SeriesPoint1})
        SideBySideBarSeriesView1.BarWidth = 3.0R
        SideBySideBarSeriesView1.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        SideBySideBarSeriesView1.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Gradient
        RectangleGradientFillOptions1.Color2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        SideBySideBarSeriesView1.FillStyle.Options = RectangleGradientFillOptions1
        Series1.View = SideBySideBarSeriesView1
        SideBySideBarSeriesLabel2.Border.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        SideBySideBarSeriesLabel2.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        SideBySideBarSeriesLabel2.ShowForZeroValues = True
        SideBySideBarSeriesLabel2.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Series2.Label = SideBySideBarSeriesLabel2
        Series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series2.Name = "Geradas"
        Series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {SeriesPoint2})
        SideBySideBarSeriesView2.BarWidth = 3.0R
        SideBySideBarSeriesView2.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        SideBySideBarSeriesView2.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Gradient
        RectangleGradientFillOptions2.Color2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        SideBySideBarSeriesView2.FillStyle.Options = RectangleGradientFillOptions2
        SideBySideBarSeriesView2.Shadow.Visible = True
        Series2.View = SideBySideBarSeriesView2
        SideBySideBarSeriesLabel3.Border.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        SideBySideBarSeriesLabel3.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        SideBySideBarSeriesLabel3.ShowForZeroValues = True
        SideBySideBarSeriesLabel3.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Series3.Label = SideBySideBarSeriesLabel3
        Series3.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series3.Name = "Conferido para entrega"
        Series3.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {SeriesPoint3})
        SideBySideBarSeriesView3.BarWidth = 3.0R
        SideBySideBarSeriesView3.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        SideBySideBarSeriesView3.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Gradient
        RectangleGradientFillOptions3.Color2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        SideBySideBarSeriesView3.FillStyle.Options = RectangleGradientFillOptions3
        SideBySideBarSeriesView3.Shadow.Visible = True
        Series3.View = SideBySideBarSeriesView3
        SideBySideBarSeriesLabel4.Border.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        SideBySideBarSeriesLabel4.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        SideBySideBarSeriesLabel4.ShowForZeroValues = True
        SideBySideBarSeriesLabel4.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Series4.Label = SideBySideBarSeriesLabel4
        Series4.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series4.Name = "Conferido pelo encarregado"
        Series4.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {SeriesPoint4})
        SideBySideBarSeriesView4.BarWidth = 3.0R
        SideBySideBarSeriesView4.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        SideBySideBarSeriesView4.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Gradient
        RectangleGradientFillOptions4.Color2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        SideBySideBarSeriesView4.FillStyle.Options = RectangleGradientFillOptions4
        SideBySideBarSeriesView4.Shadow.Visible = True
        Series4.View = SideBySideBarSeriesView4
        Me.monitoramentoChartControl.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1, Series2, Series3, Series4}
        Me.monitoramentoChartControl.Size = New System.Drawing.Size(0, 0)
        Me.monitoramentoChartControl.TabIndex = 0
        '
        'statusImageCollection
        '
        Me.statusImageCollection.ImageStream = CType(resources.GetObject("statusImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.statusImageCollection.Images.SetKeyName(0, "pawn_glass_red.png")
        Me.statusImageCollection.Images.SetKeyName(1, "pawn_glass_yellow.png")
        Me.statusImageCollection.Images.SetKeyName(2, "pawn_glass_green.png")
        '
        'navegadorPanelControl
        '
        Me.navegadorPanelControl.Controls.Add(Me.navegacaoLabelControl)
        Me.navegadorPanelControl.Location = New System.Drawing.Point(3, 96)
        Me.navegadorPanelControl.Name = "navegadorPanelControl"
        Me.navegadorPanelControl.Size = New System.Drawing.Size(1177, 25)
        Me.navegadorPanelControl.TabIndex = 5
        '
        'navegacaoLabelControl
        '
        Me.navegacaoLabelControl.Location = New System.Drawing.Point(10, 5)
        Me.navegacaoLabelControl.Name = "navegacaoLabelControl"
        Me.navegacaoLabelControl.Size = New System.Drawing.Size(0, 13)
        Me.navegacaoLabelControl.TabIndex = 0
        '
        'monitoramentoXtraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1183, 572)
        Me.Controls.Add(Me.navegadorPanelControl)
        Me.Controls.Add(Me.monitoramentoSplitContainerControl)
        Me.Controls.Add(Me.monitoramentoRibbonControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "monitoramentoXtraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monitoramento das Obrigações das Empresas"
        CType(Me.monitoramentoempresaGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.monitoramentoGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.monitoramentoempresadetalheGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.informeGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.funcionarioGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.monitoramentoGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.monitoramentoRibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.filtroImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.monitoramentoSplitContainerControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.monitoramentoSplitContainerControl.ResumeLayout(False)
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.monitoramentoChartControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.statusImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.navegadorPanelControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.navegadorPanelControl.ResumeLayout(False)
        Me.navegadorPanelControl.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents monitoramentoRibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents localizarBarCheckItem As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents monitoramentoRibbonPage As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents monitoramentoRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents monitoramentoSplitContainerControl As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents detalhadoBarCheckItem As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents geralBarCheckItem As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents monitoramentoGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents monitoramentoGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents statusImageCollection As DevExpress.Utils.ImageCollection
    Friend WithEvents monitoramentoChartControl As DevExpress.XtraCharts.ChartControl
    Friend WithEvents monitoramentoempresaGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents atualizarBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents filtroBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents filtroImageCollection As DevExpress.Utils.ImageCollection
    Friend WithEvents monitoramentoempresadetalheGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents informeGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents funcionarioGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents navegadorPanelControl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents navegacaoLabelControl As DevExpress.XtraEditors.LabelControl
End Class
