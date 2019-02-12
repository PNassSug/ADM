Imports DevExpress.XtraEditors.Mask
Imports DevExpress.XtraEditors.Repository

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class empresaobrigacoesXtraForm
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
    Dim obrigacoesedit As New RepositoryItemTextEdit

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(empresaobrigacoesXtraForm))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.empresaobrigacaoRibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.incluirBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.alterarBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.excluirBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.localizarBarCheckItem = New DevExpress.XtraBars.BarCheckItem()
        Me.atualizarBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.empresaobrigacaoRibbonPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.empresaobrigacoesRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.empresaobrigacoesSplitContainerControl = New DevExpress.XtraEditors.SplitContainerControl()
        Me.obrigacoesGroupControl = New DevExpress.XtraEditors.GroupControl()
        Me.obrigacoesSplitContainerControl = New DevExpress.XtraEditors.SplitContainerControl()
        Me.competenciaobsoletaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.competenciaobsoletaLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.obrigacaoLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.descricaoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.obrigacaoSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.obrigacoesInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.obrigacaoGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.obrigacaoGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.descricaoGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.obrigacoesGridControl = New DevExpress.XtraGrid.GridControl()
        Me.obrigacoesGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.obrigacoesPanelControl = New DevExpress.XtraEditors.PanelControl()
        Me.voltarobrigacoesSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.confirmarobrigacoesSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.ImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.excluirobrigacoesSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.alterarobrigacoesSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.incluirobrigacoesSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.empresaPanelControl = New DevExpress.XtraEditors.PanelControl()
        Me.competenciaobsoletageralLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.competenciaobsoletageralTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.empresaLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.razaosocialTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.empresaSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.empresasInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.empresaGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.empresaGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.razaosocialGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cnpjcpfGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.voltarSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.okSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.empresaobrigacoesGridControl = New DevExpress.XtraGrid.GridControl()
        Me.empresaobrigacoesGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.empresaobrigacaoRibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresaobrigacoesSplitContainerControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.empresaobrigacoesSplitContainerControl.SuspendLayout()
        CType(Me.obrigacoesGroupControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.obrigacoesGroupControl.SuspendLayout()
        CType(Me.obrigacoesSplitContainerControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.obrigacoesSplitContainerControl.SuspendLayout()
        CType(Me.competenciaobsoletaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.descricaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacaoSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacoesInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacaoGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacoesGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacoesGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacoesPanelControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.obrigacoesPanelControl.SuspendLayout()
        CType(Me.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresaPanelControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.empresaPanelControl.SuspendLayout()
        CType(Me.competenciaobsoletageralTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.razaosocialTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresaSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresasInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresaGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresaobrigacoesGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresaobrigacoesGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'empresaobrigacaoRibbonControl
        '
        Me.empresaobrigacaoRibbonControl.ExpandCollapseItem.Id = 0
        Me.empresaobrigacaoRibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.empresaobrigacaoRibbonControl.ExpandCollapseItem, Me.incluirBarButtonItem, Me.alterarBarButtonItem, Me.excluirBarButtonItem, Me.localizarBarCheckItem, Me.atualizarBarButtonItem})
        Me.empresaobrigacaoRibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.empresaobrigacaoRibbonControl.MaxItemId = 6
        Me.empresaobrigacaoRibbonControl.Name = "empresaobrigacaoRibbonControl"
        Me.empresaobrigacaoRibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.empresaobrigacaoRibbonPage})
        Me.empresaobrigacaoRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.empresaobrigacaoRibbonControl.ShowCategoryInCaption = False
        Me.empresaobrigacaoRibbonControl.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.empresaobrigacaoRibbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.empresaobrigacaoRibbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.empresaobrigacaoRibbonControl.ShowToolbarCustomizeItem = False
        Me.empresaobrigacaoRibbonControl.Size = New System.Drawing.Size(727, 95)
        Me.empresaobrigacaoRibbonControl.Toolbar.ShowCustomizeItem = False
        Me.empresaobrigacaoRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'incluirBarButtonItem
        '
        Me.incluirBarButtonItem.Caption = "Incluir"
        Me.incluirBarButtonItem.Id = 1
        Me.incluirBarButtonItem.ImageOptions.Image = CType(resources.GetObject("incluirBarButtonItem.ImageOptions.Image"), System.Drawing.Image)
        Me.incluirBarButtonItem.Name = "incluirBarButtonItem"
        Me.incluirBarButtonItem.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        Me.incluirBarButtonItem.Tag = "cadempinc"
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
        Me.alterarBarButtonItem.Tag = "cadempalt"
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
        Me.excluirBarButtonItem.Tag = "cadempexc"
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
        Me.empresaobrigacaoRibbonPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.empresaobrigacoesRibbonPageGroup})
        Me.empresaobrigacaoRibbonPage.Name = "empresaobrigacaoRibbonPage"
        Me.empresaobrigacaoRibbonPage.Text = "RibbonPage1"
        '
        'empresaobrigacoesRibbonPageGroup
        '
        Me.empresaobrigacoesRibbonPageGroup.ItemLinks.Add(Me.incluirBarButtonItem)
        Me.empresaobrigacoesRibbonPageGroup.ItemLinks.Add(Me.alterarBarButtonItem)
        Me.empresaobrigacoesRibbonPageGroup.ItemLinks.Add(Me.excluirBarButtonItem)
        Me.empresaobrigacoesRibbonPageGroup.ItemLinks.Add(Me.localizarBarCheckItem)
        Me.empresaobrigacoesRibbonPageGroup.ItemLinks.Add(Me.atualizarBarButtonItem)
        Me.empresaobrigacoesRibbonPageGroup.Name = "empresaobrigacoesRibbonPageGroup"
        Me.empresaobrigacoesRibbonPageGroup.ShowCaptionButton = False
        '
        'empresaobrigacoesSplitContainerControl
        '
        Me.empresaobrigacoesSplitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.empresaobrigacoesSplitContainerControl.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None
        Me.empresaobrigacoesSplitContainerControl.Location = New System.Drawing.Point(0, 95)
        Me.empresaobrigacoesSplitContainerControl.Name = "empresaobrigacoesSplitContainerControl"
        Me.empresaobrigacoesSplitContainerControl.Panel1.Controls.Add(Me.obrigacoesGroupControl)
        Me.empresaobrigacoesSplitContainerControl.Panel1.Controls.Add(Me.empresaPanelControl)
        Me.empresaobrigacoesSplitContainerControl.Panel1.Controls.Add(Me.voltarSimpleButton)
        Me.empresaobrigacoesSplitContainerControl.Panel1.Controls.Add(Me.okSimpleButton)
        Me.empresaobrigacoesSplitContainerControl.Panel2.Controls.Add(Me.empresaobrigacoesGridControl)
        Me.empresaobrigacoesSplitContainerControl.Panel2.Text = "Panel2"
        Me.empresaobrigacoesSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
        Me.empresaobrigacoesSplitContainerControl.Size = New System.Drawing.Size(727, 392)
        Me.empresaobrigacoesSplitContainerControl.SplitterPosition = 99
        Me.empresaobrigacoesSplitContainerControl.TabIndex = 0
        '
        'obrigacoesGroupControl
        '
        Me.obrigacoesGroupControl.Controls.Add(Me.obrigacoesSplitContainerControl)
        Me.obrigacoesGroupControl.Controls.Add(Me.obrigacoesPanelControl)
        Me.obrigacoesGroupControl.Location = New System.Drawing.Point(6, 63)
        Me.obrigacoesGroupControl.Name = "obrigacoesGroupControl"
        Me.obrigacoesGroupControl.Size = New System.Drawing.Size(717, 274)
        Me.obrigacoesGroupControl.TabIndex = 1
        Me.obrigacoesGroupControl.Text = "Relação das Obrigações"
        '
        'obrigacoesSplitContainerControl
        '
        Me.obrigacoesSplitContainerControl.Location = New System.Drawing.Point(6, 69)
        Me.obrigacoesSplitContainerControl.Name = "obrigacoesSplitContainerControl"
        Me.obrigacoesSplitContainerControl.Panel1.Controls.Add(Me.competenciaobsoletaTextEdit)
        Me.obrigacoesSplitContainerControl.Panel1.Controls.Add(Me.competenciaobsoletaLabelControl)
        Me.obrigacoesSplitContainerControl.Panel1.Controls.Add(Me.obrigacaoLabelControl)
        Me.obrigacoesSplitContainerControl.Panel1.Controls.Add(Me.descricaoTextEdit)
        Me.obrigacoesSplitContainerControl.Panel1.Controls.Add(Me.obrigacaoSearchLookUpEdit)
        Me.obrigacoesSplitContainerControl.Panel2.Controls.Add(Me.obrigacoesGridControl)
        Me.obrigacoesSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
        Me.obrigacoesSplitContainerControl.Size = New System.Drawing.Size(703, 200)
        Me.obrigacoesSplitContainerControl.TabIndex = 1
        '
        'competenciaobsoletaTextEdit
        '
        Me.competenciaobsoletaTextEdit.Location = New System.Drawing.Point(589, 21)
        Me.competenciaobsoletaTextEdit.Name = "competenciaobsoletaTextEdit"
        Me.competenciaobsoletaTextEdit.Properties.Mask.EditMask = "00/0000"
        Me.competenciaobsoletaTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.competenciaobsoletaTextEdit.Properties.Mask.SaveLiteral = False
        Me.competenciaobsoletaTextEdit.Properties.Mask.ShowPlaceHolders = False
        Me.competenciaobsoletaTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.competenciaobsoletaTextEdit.Size = New System.Drawing.Size(111, 20)
        Me.competenciaobsoletaTextEdit.TabIndex = 4
        '
        'competenciaobsoletaLabelControl
        '
        Me.competenciaobsoletaLabelControl.Location = New System.Drawing.Point(589, 3)
        Me.competenciaobsoletaLabelControl.Name = "competenciaobsoletaLabelControl"
        Me.competenciaobsoletaLabelControl.Size = New System.Drawing.Size(108, 13)
        Me.competenciaobsoletaLabelControl.TabIndex = 3
        Me.competenciaobsoletaLabelControl.Text = "Competência Obsoleta"
        '
        'obrigacaoLabelControl
        '
        Me.obrigacaoLabelControl.Location = New System.Drawing.Point(6, 3)
        Me.obrigacaoLabelControl.Name = "obrigacaoLabelControl"
        Me.obrigacaoLabelControl.Size = New System.Drawing.Size(49, 13)
        Me.obrigacaoLabelControl.TabIndex = 0
        Me.obrigacaoLabelControl.Text = "Obrigação"
        '
        'descricaoTextEdit
        '
        Me.descricaoTextEdit.Enabled = False
        Me.descricaoTextEdit.Location = New System.Drawing.Point(111, 21)
        Me.descricaoTextEdit.Name = "descricaoTextEdit"
        Me.descricaoTextEdit.Properties.AutoHeight = False
        Me.descricaoTextEdit.Size = New System.Drawing.Size(472, 22)
        Me.descricaoTextEdit.TabIndex = 2
        '
        'obrigacaoSearchLookUpEdit
        '
        Me.obrigacaoSearchLookUpEdit.Location = New System.Drawing.Point(6, 21)
        Me.obrigacaoSearchLookUpEdit.Name = "obrigacaoSearchLookUpEdit"
        Me.obrigacaoSearchLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.obrigacaoSearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("obrigacaoSearchLookUpEdit.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.obrigacaoSearchLookUpEdit.Properties.DataSource = Me.obrigacoesInfoBindingSource
        Me.obrigacaoSearchLookUpEdit.Properties.DisplayMember = "obrigacao"
        Me.obrigacaoSearchLookUpEdit.Properties.NullText = ""
        Me.obrigacaoSearchLookUpEdit.Properties.ValueMember = "obrigacao"
        Me.obrigacaoSearchLookUpEdit.Properties.View = Me.obrigacaoGridView
        Me.obrigacaoSearchLookUpEdit.Size = New System.Drawing.Size(100, 22)
        Me.obrigacaoSearchLookUpEdit.TabIndex = 1
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
        Me.obrigacaoGridView.Columns(0).ColumnEdit = obrigacoesedit
        obrigacoesedit.Mask.MaskType = MaskType.Simple
        obrigacoesedit.Mask.UseMaskAsDisplayFormat = True
        obrigacoesedit.Mask.EditMask = "0-00000"
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
        Me.obrigacoesGridControl.Size = New System.Drawing.Size(0, 0)
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
        Me.obrigacoesGridView.OptionsView.ColumnAutoWidth = False
        Me.obrigacoesGridView.OptionsView.ShowGroupPanel = False
        '
        'obrigacoesPanelControl
        '
        Me.obrigacoesPanelControl.Controls.Add(Me.voltarobrigacoesSimpleButton)
        Me.obrigacoesPanelControl.Controls.Add(Me.confirmarobrigacoesSimpleButton)
        Me.obrigacoesPanelControl.Controls.Add(Me.excluirobrigacoesSimpleButton)
        Me.obrigacoesPanelControl.Controls.Add(Me.alterarobrigacoesSimpleButton)
        Me.obrigacoesPanelControl.Controls.Add(Me.incluirobrigacoesSimpleButton)
        Me.obrigacoesPanelControl.Location = New System.Drawing.Point(6, 24)
        Me.obrigacoesPanelControl.Name = "obrigacoesPanelControl"
        Me.obrigacoesPanelControl.Size = New System.Drawing.Size(704, 39)
        Me.obrigacoesPanelControl.TabIndex = 0
        '
        'voltarobrigacoesSimpleButton
        '
        Me.voltarobrigacoesSimpleButton.Image = CType(resources.GetObject("voltarobrigacoesSimpleButton.Image"), System.Drawing.Image)
        Me.voltarobrigacoesSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.voltarobrigacoesSimpleButton.Location = New System.Drawing.Point(669, 6)
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
        Me.confirmarobrigacoesSimpleButton.Location = New System.Drawing.Point(635, 6)
        Me.confirmarobrigacoesSimpleButton.Name = "confirmarobrigacoesSimpleButton"
        Me.confirmarobrigacoesSimpleButton.Size = New System.Drawing.Size(30, 27)
        Me.confirmarobrigacoesSimpleButton.TabIndex = 3
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
        'empresaPanelControl
        '
        Me.empresaPanelControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.empresaPanelControl.Controls.Add(Me.competenciaobsoletageralLabelControl)
        Me.empresaPanelControl.Controls.Add(Me.competenciaobsoletageralTextEdit)
        Me.empresaPanelControl.Controls.Add(Me.empresaLabelControl)
        Me.empresaPanelControl.Controls.Add(Me.razaosocialTextEdit)
        Me.empresaPanelControl.Controls.Add(Me.empresaSearchLookUpEdit)
        Me.empresaPanelControl.Location = New System.Drawing.Point(6, 6)
        Me.empresaPanelControl.Name = "empresaPanelControl"
        Me.empresaPanelControl.Size = New System.Drawing.Size(717, 51)
        Me.empresaPanelControl.TabIndex = 0
        '
        'competenciaobsoletageralLabelControl
        '
        Me.competenciaobsoletageralLabelControl.Location = New System.Drawing.Point(595, 6)
        Me.competenciaobsoletageralLabelControl.Name = "competenciaobsoletageralLabelControl"
        Me.competenciaobsoletageralLabelControl.Size = New System.Drawing.Size(108, 13)
        Me.competenciaobsoletageralLabelControl.TabIndex = 3
        Me.competenciaobsoletageralLabelControl.Text = "Competência Obsoleta"
        '
        'competenciaobsoletageralTextEdit
        '
        Me.competenciaobsoletageralTextEdit.Location = New System.Drawing.Point(595, 23)
        Me.competenciaobsoletageralTextEdit.Name = "competenciaobsoletageralTextEdit"
        Me.competenciaobsoletageralTextEdit.Properties.AutoHeight = False
        Me.competenciaobsoletageralTextEdit.Properties.Mask.EditMask = "00/0000"
        Me.competenciaobsoletageralTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.competenciaobsoletageralTextEdit.Properties.Mask.SaveLiteral = False
        Me.competenciaobsoletageralTextEdit.Properties.Mask.ShowPlaceHolders = False
        Me.competenciaobsoletageralTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.competenciaobsoletageralTextEdit.Size = New System.Drawing.Size(111, 22)
        Me.competenciaobsoletageralTextEdit.TabIndex = 4
        '
        'empresaLabelControl
        '
        Me.empresaLabelControl.Location = New System.Drawing.Point(6, 6)
        Me.empresaLabelControl.Name = "empresaLabelControl"
        Me.empresaLabelControl.Size = New System.Drawing.Size(41, 13)
        Me.empresaLabelControl.TabIndex = 0
        Me.empresaLabelControl.Text = "Empresa"
        '
        'razaosocialTextEdit
        '
        Me.razaosocialTextEdit.EditValue = ""
        Me.razaosocialTextEdit.Enabled = False
        Me.razaosocialTextEdit.Location = New System.Drawing.Point(110, 23)
        Me.razaosocialTextEdit.Name = "razaosocialTextEdit"
        Me.razaosocialTextEdit.Properties.AutoHeight = False
        Me.razaosocialTextEdit.Size = New System.Drawing.Size(479, 22)
        Me.razaosocialTextEdit.TabIndex = 2
        '
        'empresaSearchLookUpEdit
        '
        Me.empresaSearchLookUpEdit.Location = New System.Drawing.Point(6, 23)
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
        Me.empresaSearchLookUpEdit.Properties.Mask.SaveLiteral = True
        '
        'empresaGridView
        '
        Me.empresaGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.empresaGridColumn, Me.razaosocialGridColumn, Me.cnpjcpfGridColumn})
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
        'cnpjcpfGridColumn
        '
        Me.cnpjcpfGridColumn.Caption = "cnpjcpf"
        Me.cnpjcpfGridColumn.FieldName = "cnpj"
        Me.cnpjcpfGridColumn.Name = "cnpjcpfGridColumn"
        '
        'voltarSimpleButton
        '
        Me.voltarSimpleButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.voltarSimpleButton.Image = CType(resources.GetObject("voltarSimpleButton.Image"), System.Drawing.Image)
        Me.voltarSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.voltarSimpleButton.Location = New System.Drawing.Point(661, 343)
        Me.voltarSimpleButton.Name = "voltarSimpleButton"
        Me.voltarSimpleButton.Size = New System.Drawing.Size(62, 45)
        Me.voltarSimpleButton.TabIndex = 3
        Me.voltarSimpleButton.Text = "Voltar"
        '
        'okSimpleButton
        '
        Me.okSimpleButton.ImageIndex = 0
        Me.okSimpleButton.ImageList = Me.ImageCollection
        Me.okSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.okSimpleButton.Location = New System.Drawing.Point(595, 343)
        Me.okSimpleButton.Name = "okSimpleButton"
        Me.okSimpleButton.Size = New System.Drawing.Size(62, 45)
        Me.okSimpleButton.TabIndex = 2
        Me.okSimpleButton.Text = "OK"
        '
        'empresaobrigacoesGridControl
        '
        Me.empresaobrigacoesGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.empresaobrigacoesGridControl.Location = New System.Drawing.Point(0, 0)
        Me.empresaobrigacoesGridControl.MainView = Me.empresaobrigacoesGridView
        Me.empresaobrigacoesGridControl.Name = "empresaobrigacoesGridControl"
        Me.empresaobrigacoesGridControl.Size = New System.Drawing.Size(0, 0)
        Me.empresaobrigacoesGridControl.TabIndex = 1
        Me.empresaobrigacoesGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.empresaobrigacoesGridView})
        '
        'empresaobrigacoesGridView
        '
        Me.empresaobrigacoesGridView.GridControl = Me.empresaobrigacoesGridControl
        Me.empresaobrigacoesGridView.Name = "empresaobrigacoesGridView"
        Me.empresaobrigacoesGridView.OptionsBehavior.Editable = False
        Me.empresaobrigacoesGridView.OptionsCustomization.AllowColumnMoving = False
        Me.empresaobrigacoesGridView.OptionsCustomization.AllowColumnResizing = False
        Me.empresaobrigacoesGridView.OptionsCustomization.AllowGroup = False
        Me.empresaobrigacoesGridView.OptionsCustomization.AllowQuickHideColumns = False
        Me.empresaobrigacoesGridView.OptionsView.ColumnAutoWidth = False
        Me.empresaobrigacoesGridView.OptionsView.ShowGroupPanel = False
        '
        'empresaobrigacoesXtraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.CancelButton = Me.voltarSimpleButton
        Me.ClientSize = New System.Drawing.Size(727, 487)
        Me.Controls.Add(Me.empresaobrigacoesSplitContainerControl)
        Me.Controls.Add(Me.empresaobrigacaoRibbonControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "empresaobrigacoesXtraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Obrigações das Empresas"
        CType(Me.empresaobrigacaoRibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.empresaobrigacoesSplitContainerControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.empresaobrigacoesSplitContainerControl.ResumeLayout(False)
        CType(Me.obrigacoesGroupControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.obrigacoesGroupControl.ResumeLayout(False)
        CType(Me.obrigacoesSplitContainerControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.obrigacoesSplitContainerControl.ResumeLayout(False)
        CType(Me.competenciaobsoletaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.descricaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacaoSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacoesInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacaoGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacoesGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacoesGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacoesPanelControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.obrigacoesPanelControl.ResumeLayout(False)
        CType(Me.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.empresaPanelControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.empresaPanelControl.ResumeLayout(False)
        Me.empresaPanelControl.PerformLayout()
        CType(Me.competenciaobsoletageralTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.razaosocialTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.empresaSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.empresasInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.empresaGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.empresaobrigacoesGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.empresaobrigacoesGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents empresaobrigacaoRibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents incluirBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents alterarBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents excluirBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents localizarBarCheckItem As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents empresaobrigacaoRibbonPage As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents empresaobrigacoesRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents empresaobrigacoesSplitContainerControl As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents voltarSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents okSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents empresasInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents obrigacoesInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents atualizarBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents obrigacoesGroupControl As DevExpress.XtraEditors.GroupControl
    Friend WithEvents obrigacoesSplitContainerControl As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents obrigacoesGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents obrigacoesGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents obrigacoesPanelControl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents voltarobrigacoesSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents confirmarobrigacoesSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents excluirobrigacoesSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents alterarobrigacoesSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents incluirobrigacoesSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents empresaPanelControl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents empresaLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents razaosocialTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents empresaSearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents empresaGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents empresaGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents razaosocialGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ImageCollection As DevExpress.Utils.ImageCollection
    Friend WithEvents competenciaobsoletaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents competenciaobsoletaLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents obrigacaoLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents descricaoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents obrigacaoSearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents obrigacaoGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents obrigacaoGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents descricaoGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents empresaobrigacoesGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents empresaobrigacoesGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cnpjcpfGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents competenciaobsoletageralLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents competenciaobsoletageralTextEdit As DevExpress.XtraEditors.TextEdit
End Class
