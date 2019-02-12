Imports DevExpress.XtraEditors.Mask
Imports DevExpress.XtraEditors.Repository

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class tarefasextrasXtraForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tarefasextrasXtraForm))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.tarefasextrasSplitContainerControl = New DevExpress.XtraEditors.SplitContainerControl()
        Me.voltarSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.okSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.ImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.obrigacoesPanelControl = New DevExpress.XtraEditors.PanelControl()
        Me.datavencimentoDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.tarefasextrasRibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.filtroImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.incluirBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.alterarBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.excluirBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.localizarBarCheckItem = New DevExpress.XtraBars.BarCheckItem()
        Me.atualizarBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.filtroBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.obrigacaoRibbonPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.obrigacoesRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.funcionarioLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.nomeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.funcionarioSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.funcionariosInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.funcionarioGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.funcionarioGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.nomeGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.observacaoLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.datavencimentoLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.competenciaLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.competenciaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.obrigacaoLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.descricaoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.obrigacaoSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.obrigacoesInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.obrigacaoGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.obrigacaoGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.descricaoGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.empresaLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.razaosocialTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.empresaSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.empresasInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.empresaGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.empresaGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.razaosocialGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.observacaoTextEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.tarefasextrasGridControl = New DevExpress.XtraGrid.GridControl()
        Me.tarefasextrasAdvBandedGridView = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
        CType(Me.tarefasextrasSplitContainerControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tarefasextrasSplitContainerControl.SuspendLayout()
        CType(Me.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacoesPanelControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.obrigacoesPanelControl.SuspendLayout()
        CType(Me.datavencimentoDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datavencimentoDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tarefasextrasRibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.filtroImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nomeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.funcionarioSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.funcionariosInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.funcionarioGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.competenciaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.descricaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacaoSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacoesInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacaoGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.razaosocialTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresaSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresasInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresaGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.observacaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tarefasextrasGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tarefasextrasAdvBandedGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tarefasextrasSplitContainerControl
        '
        Me.tarefasextrasSplitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tarefasextrasSplitContainerControl.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None
        Me.tarefasextrasSplitContainerControl.Location = New System.Drawing.Point(0, 95)
        Me.tarefasextrasSplitContainerControl.Name = "tarefasextrasSplitContainerControl"
        Me.tarefasextrasSplitContainerControl.Panel1.Controls.Add(Me.voltarSimpleButton)
        Me.tarefasextrasSplitContainerControl.Panel1.Controls.Add(Me.okSimpleButton)
        Me.tarefasextrasSplitContainerControl.Panel1.Controls.Add(Me.obrigacoesPanelControl)
        Me.tarefasextrasSplitContainerControl.Panel2.Controls.Add(Me.tarefasextrasGridControl)
        Me.tarefasextrasSplitContainerControl.Panel2.Text = "Panel2"
        Me.tarefasextrasSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
        Me.tarefasextrasSplitContainerControl.Size = New System.Drawing.Size(853, 416)
        Me.tarefasextrasSplitContainerControl.SplitterPosition = 99
        Me.tarefasextrasSplitContainerControl.TabIndex = 0
        '
        'voltarSimpleButton
        '
        Me.voltarSimpleButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.voltarSimpleButton.Image = CType(resources.GetObject("voltarSimpleButton.Image"), System.Drawing.Image)
        Me.voltarSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.voltarSimpleButton.Location = New System.Drawing.Point(786, 365)
        Me.voltarSimpleButton.Name = "voltarSimpleButton"
        Me.voltarSimpleButton.Size = New System.Drawing.Size(62, 45)
        Me.voltarSimpleButton.TabIndex = 2
        Me.voltarSimpleButton.Text = "Voltar"
        '
        'okSimpleButton
        '
        Me.okSimpleButton.ImageIndex = 0
        Me.okSimpleButton.ImageList = Me.ImageCollection
        Me.okSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.okSimpleButton.Location = New System.Drawing.Point(720, 365)
        Me.okSimpleButton.Name = "okSimpleButton"
        Me.okSimpleButton.Size = New System.Drawing.Size(62, 45)
        Me.okSimpleButton.TabIndex = 1
        Me.okSimpleButton.Text = "OK"
        '
        'ImageCollection
        '
        Me.ImageCollection.ImageSize = New System.Drawing.Size(24, 24)
        Me.ImageCollection.ImageStream = CType(resources.GetObject("ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection.Images.SetKeyName(0, "disk_blue.png")
        Me.ImageCollection.Images.SetKeyName(1, "delete.png")
        '
        'obrigacoesPanelControl
        '
        Me.obrigacoesPanelControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.obrigacoesPanelControl.Controls.Add(Me.datavencimentoDateEdit)
        Me.obrigacoesPanelControl.Controls.Add(Me.funcionarioLabelControl)
        Me.obrigacoesPanelControl.Controls.Add(Me.nomeTextEdit)
        Me.obrigacoesPanelControl.Controls.Add(Me.funcionarioSearchLookUpEdit)
        Me.obrigacoesPanelControl.Controls.Add(Me.observacaoLabelControl)
        Me.obrigacoesPanelControl.Controls.Add(Me.datavencimentoLabelControl)
        Me.obrigacoesPanelControl.Controls.Add(Me.competenciaLabelControl)
        Me.obrigacoesPanelControl.Controls.Add(Me.competenciaTextEdit)
        Me.obrigacoesPanelControl.Controls.Add(Me.obrigacaoLabelControl)
        Me.obrigacoesPanelControl.Controls.Add(Me.descricaoTextEdit)
        Me.obrigacoesPanelControl.Controls.Add(Me.obrigacaoSearchLookUpEdit)
        Me.obrigacoesPanelControl.Controls.Add(Me.empresaLabelControl)
        Me.obrigacoesPanelControl.Controls.Add(Me.razaosocialTextEdit)
        Me.obrigacoesPanelControl.Controls.Add(Me.empresaSearchLookUpEdit)
        Me.obrigacoesPanelControl.Controls.Add(Me.observacaoTextEdit)
        Me.obrigacoesPanelControl.Location = New System.Drawing.Point(5, 3)
        Me.obrigacoesPanelControl.Name = "obrigacoesPanelControl"
        Me.obrigacoesPanelControl.Size = New System.Drawing.Size(843, 356)
        Me.obrigacoesPanelControl.TabIndex = 0
        '
        'datavencimentoDateEdit
        '
        Me.datavencimentoDateEdit.EditValue = Nothing
        Me.datavencimentoDateEdit.Location = New System.Drawing.Point(728, 64)
        Me.datavencimentoDateEdit.MenuManager = Me.tarefasextrasRibbonControl
        Me.datavencimentoDateEdit.Name = "datavencimentoDateEdit"
        Me.datavencimentoDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.datavencimentoDateEdit.Properties.AutoHeight = False
        Me.datavencimentoDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Data de Vencimento", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("datavencimentoDateEdit.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D)), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.datavencimentoDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.datavencimentoDateEdit.Properties.Mask.SaveLiteral = False
        Me.datavencimentoDateEdit.Properties.Mask.ShowPlaceHolders = False
        Me.datavencimentoDateEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.datavencimentoDateEdit.Size = New System.Drawing.Size(100, 22)
        Me.datavencimentoDateEdit.TabIndex = 9
        '
        'tarefasextrasRibbonControl
        '
        Me.tarefasextrasRibbonControl.ExpandCollapseItem.Id = 0
        Me.tarefasextrasRibbonControl.Images = Me.filtroImageCollection
        Me.tarefasextrasRibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.tarefasextrasRibbonControl.ExpandCollapseItem, Me.incluirBarButtonItem, Me.alterarBarButtonItem, Me.excluirBarButtonItem, Me.localizarBarCheckItem, Me.atualizarBarButtonItem, Me.filtroBarButtonItem})
        Me.tarefasextrasRibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.tarefasextrasRibbonControl.MaxItemId = 7
        Me.tarefasextrasRibbonControl.Name = "tarefasextrasRibbonControl"
        Me.tarefasextrasRibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.obrigacaoRibbonPage})
        Me.tarefasextrasRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.tarefasextrasRibbonControl.ShowCategoryInCaption = False
        Me.tarefasextrasRibbonControl.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.tarefasextrasRibbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.tarefasextrasRibbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.tarefasextrasRibbonControl.ShowToolbarCustomizeItem = False
        Me.tarefasextrasRibbonControl.Size = New System.Drawing.Size(853, 95)
        Me.tarefasextrasRibbonControl.Toolbar.ShowCustomizeItem = False
        Me.tarefasextrasRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'filtroImageCollection
        '
        Me.filtroImageCollection.ImageSize = New System.Drawing.Size(48, 48)
        Me.filtroImageCollection.ImageStream = CType(resources.GetObject("filtroImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.filtroImageCollection.Images.SetKeyName(0, "funnel.png")
        Me.filtroImageCollection.Images.SetKeyName(1, "funnel_preferences.png")
        '
        'incluirBarButtonItem
        '
        Me.incluirBarButtonItem.Caption = "Incluir"
        Me.incluirBarButtonItem.Id = 1
        Me.incluirBarButtonItem.ImageOptions.Image = CType(resources.GetObject("incluirBarButtonItem.ImageOptions.Image"), System.Drawing.Image)
        Me.incluirBarButtonItem.Name = "incluirBarButtonItem"
        Me.incluirBarButtonItem.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        Me.incluirBarButtonItem.Tag = "movtarinc"
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
        Me.alterarBarButtonItem.Tag = "movtaralt"
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
        Me.excluirBarButtonItem.Tag = "movtarexc"
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
        'filtroBarButtonItem
        '
        Me.filtroBarButtonItem.Caption = "Filtrar por"
        Me.filtroBarButtonItem.Id = 6
        Me.filtroBarButtonItem.ImageOptions.ImageIndex = 0
        Me.filtroBarButtonItem.Name = "filtroBarButtonItem"
        Me.filtroBarButtonItem.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'obrigacaoRibbonPage
        '
        Me.obrigacaoRibbonPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.obrigacoesRibbonPageGroup})
        Me.obrigacaoRibbonPage.Name = "obrigacaoRibbonPage"
        Me.obrigacaoRibbonPage.Text = "RibbonPage1"
        '
        'obrigacoesRibbonPageGroup
        '
        Me.obrigacoesRibbonPageGroup.ItemLinks.Add(Me.incluirBarButtonItem)
        Me.obrigacoesRibbonPageGroup.ItemLinks.Add(Me.alterarBarButtonItem)
        Me.obrigacoesRibbonPageGroup.ItemLinks.Add(Me.excluirBarButtonItem)
        Me.obrigacoesRibbonPageGroup.ItemLinks.Add(Me.localizarBarCheckItem)
        Me.obrigacoesRibbonPageGroup.ItemLinks.Add(Me.atualizarBarButtonItem)
        Me.obrigacoesRibbonPageGroup.ItemLinks.Add(Me.filtroBarButtonItem)
        Me.obrigacoesRibbonPageGroup.Name = "obrigacoesRibbonPageGroup"
        Me.obrigacoesRibbonPageGroup.ShowCaptionButton = False
        '
        'funcionarioLabelControl
        '
        Me.funcionarioLabelControl.Location = New System.Drawing.Point(9, 93)
        Me.funcionarioLabelControl.Name = "funcionarioLabelControl"
        Me.funcionarioLabelControl.Size = New System.Drawing.Size(55, 13)
        Me.funcionarioLabelControl.TabIndex = 10
        Me.funcionarioLabelControl.Text = "Funcionário"
        '
        'nomeTextEdit
        '
        Me.nomeTextEdit.Enabled = False
        Me.nomeTextEdit.Location = New System.Drawing.Point(114, 110)
        Me.nomeTextEdit.Name = "nomeTextEdit"
        Me.nomeTextEdit.Properties.AutoHeight = False
        Me.nomeTextEdit.Size = New System.Drawing.Size(607, 22)
        Me.nomeTextEdit.TabIndex = 12
        '
        'funcionarioSearchLookUpEdit
        '
        Me.funcionarioSearchLookUpEdit.Location = New System.Drawing.Point(9, 110)
        Me.funcionarioSearchLookUpEdit.Name = "funcionarioSearchLookUpEdit"
        Me.funcionarioSearchLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.funcionarioSearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("funcionarioSearchLookUpEdit.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.funcionarioSearchLookUpEdit.Properties.DataSource = Me.funcionariosInfoBindingSource
        Me.funcionarioSearchLookUpEdit.Properties.DisplayMember = "funcionario"
        Me.funcionarioSearchLookUpEdit.Properties.NullText = ""
        Me.funcionarioSearchLookUpEdit.Properties.ValueMember = "funcionario"
        Me.funcionarioSearchLookUpEdit.Properties.View = Me.funcionarioGridView
        Me.funcionarioSearchLookUpEdit.Size = New System.Drawing.Size(100, 22)
        Me.funcionarioSearchLookUpEdit.TabIndex = 11
        '
        'funcionarioGridView
        '
        Me.funcionarioGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.funcionarioGridColumn, Me.nomeGridColumn})
        Me.funcionarioGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.funcionarioGridView.Name = "funcionarioGridView"
        Me.funcionarioGridView.OptionsFind.AlwaysVisible = True
        Me.funcionarioGridView.OptionsFind.SearchInPreview = True
        Me.funcionarioGridView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.funcionarioGridView.OptionsView.ShowGroupPanel = False
        '
        'funcionarioGridColumn
        '
        Me.funcionarioGridColumn.Caption = "Funcionario"
        Me.funcionarioGridColumn.FieldName = "funcionario"
        Me.funcionarioGridColumn.Name = "funcionarioGridColumn"
        Me.funcionarioGridColumn.Visible = True
        Me.funcionarioGridColumn.VisibleIndex = 0
        Me.funcionarioGridColumn.Width = 80
        '
        'nomeGridColumn
        '
        Me.nomeGridColumn.Caption = "Nome"
        Me.nomeGridColumn.FieldName = "nome"
        Me.nomeGridColumn.Name = "nomeGridColumn"
        Me.nomeGridColumn.Visible = True
        Me.nomeGridColumn.VisibleIndex = 1
        Me.nomeGridColumn.Width = 200
        '
        'observacaoLabelControl
        '
        Me.observacaoLabelControl.Location = New System.Drawing.Point(9, 140)
        Me.observacaoLabelControl.Name = "observacaoLabelControl"
        Me.observacaoLabelControl.Size = New System.Drawing.Size(58, 13)
        Me.observacaoLabelControl.TabIndex = 13
        Me.observacaoLabelControl.Text = "Observação"
        '
        'datavencimentoLabelControl
        '
        Me.datavencimentoLabelControl.Location = New System.Drawing.Point(728, 47)
        Me.datavencimentoLabelControl.Name = "datavencimentoLabelControl"
        Me.datavencimentoLabelControl.Size = New System.Drawing.Size(81, 13)
        Me.datavencimentoLabelControl.TabIndex = 8
        Me.datavencimentoLabelControl.Text = "Data Vencimento"
        '
        'competenciaLabelControl
        '
        Me.competenciaLabelControl.Location = New System.Drawing.Point(9, 4)
        Me.competenciaLabelControl.Name = "competenciaLabelControl"
        Me.competenciaLabelControl.Size = New System.Drawing.Size(64, 13)
        Me.competenciaLabelControl.TabIndex = 0
        Me.competenciaLabelControl.Text = "Fato Gerador"
        '
        'competenciaTextEdit
        '
        Me.competenciaTextEdit.Location = New System.Drawing.Point(9, 21)
        Me.competenciaTextEdit.MenuManager = Me.tarefasextrasRibbonControl
        Me.competenciaTextEdit.Name = "competenciaTextEdit"
        Me.competenciaTextEdit.Properties.AutoHeight = False
        Me.competenciaTextEdit.Properties.Mask.EditMask = "00/0000"
        Me.competenciaTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.competenciaTextEdit.Properties.Mask.SaveLiteral = False
        Me.competenciaTextEdit.Properties.Mask.ShowPlaceHolders = False
        Me.competenciaTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.competenciaTextEdit.Size = New System.Drawing.Size(100, 22)
        Me.competenciaTextEdit.TabIndex = 1
        '
        'obrigacaoLabelControl
        '
        Me.obrigacaoLabelControl.Location = New System.Drawing.Point(9, 47)
        Me.obrigacaoLabelControl.Name = "obrigacaoLabelControl"
        Me.obrigacaoLabelControl.Size = New System.Drawing.Size(49, 13)
        Me.obrigacaoLabelControl.TabIndex = 5
        Me.obrigacaoLabelControl.Text = "Obrigação"
        '
        'descricaoTextEdit
        '
        Me.descricaoTextEdit.Enabled = False
        Me.descricaoTextEdit.Location = New System.Drawing.Point(114, 64)
        Me.descricaoTextEdit.Name = "descricaoTextEdit"
        Me.descricaoTextEdit.Properties.AutoHeight = False
        Me.descricaoTextEdit.Size = New System.Drawing.Size(607, 22)
        Me.descricaoTextEdit.TabIndex = 7
        '
        'obrigacaoSearchLookUpEdit
        '
        Me.obrigacaoSearchLookUpEdit.Location = New System.Drawing.Point(9, 64)
        Me.obrigacaoSearchLookUpEdit.Name = "obrigacaoSearchLookUpEdit"
        Me.obrigacaoSearchLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.obrigacaoSearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("obrigacaoSearchLookUpEdit.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, Nothing, True)})
        Me.obrigacaoSearchLookUpEdit.Properties.DataSource = Me.obrigacoesInfoBindingSource
        Me.obrigacaoSearchLookUpEdit.Properties.DisplayMember = "obrigacao"
        Me.obrigacaoSearchLookUpEdit.Properties.NullText = ""
        Me.obrigacaoSearchLookUpEdit.Properties.ValueMember = "obrigacao"
        Me.obrigacaoSearchLookUpEdit.Properties.View = Me.obrigacaoGridView
        Me.obrigacaoSearchLookUpEdit.Size = New System.Drawing.Size(100, 22)
        Me.obrigacaoSearchLookUpEdit.TabIndex = 6
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
        Me.empresaLabelControl.Location = New System.Drawing.Point(114, 4)
        Me.empresaLabelControl.Name = "empresaLabelControl"
        Me.empresaLabelControl.Size = New System.Drawing.Size(41, 13)
        Me.empresaLabelControl.TabIndex = 2
        Me.empresaLabelControl.Text = "Empresa"
        '
        'razaosocialTextEdit
        '
        Me.razaosocialTextEdit.EditValue = ""
        Me.razaosocialTextEdit.Enabled = False
        Me.razaosocialTextEdit.Location = New System.Drawing.Point(219, 21)
        Me.razaosocialTextEdit.Name = "razaosocialTextEdit"
        Me.razaosocialTextEdit.Properties.AutoHeight = False
        Me.razaosocialTextEdit.Size = New System.Drawing.Size(607, 22)
        Me.razaosocialTextEdit.TabIndex = 4
        '
        'empresaSearchLookUpEdit
        '
        Me.empresaSearchLookUpEdit.Location = New System.Drawing.Point(114, 21)
        Me.empresaSearchLookUpEdit.Name = "empresaSearchLookUpEdit"
        Me.empresaSearchLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.empresaSearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("empresaSearchLookUpEdit.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject4, "", Nothing, Nothing, True)})
        Me.empresaSearchLookUpEdit.Properties.DataSource = Me.empresasInfoBindingSource
        Me.empresaSearchLookUpEdit.Properties.DisplayMember = "empresa"
        Me.empresaSearchLookUpEdit.Properties.NullText = ""
        Me.empresaSearchLookUpEdit.Properties.ValueMember = "empresa"
        Me.empresaSearchLookUpEdit.Properties.View = Me.empresaGridView
        Me.empresaSearchLookUpEdit.Size = New System.Drawing.Size(100, 22)
        Me.empresaSearchLookUpEdit.TabIndex = 3
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
        'observacaoTextEdit
        '
        Me.observacaoTextEdit.Location = New System.Drawing.Point(9, 159)
        Me.observacaoTextEdit.MenuManager = Me.tarefasextrasRibbonControl
        Me.observacaoTextEdit.Name = "observacaoTextEdit"
        Me.observacaoTextEdit.Size = New System.Drawing.Size(819, 188)
        Me.observacaoTextEdit.TabIndex = 14
        '
        'tarefasextrasGridControl
        '
        Me.tarefasextrasGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tarefasextrasGridControl.Location = New System.Drawing.Point(0, 0)
        Me.tarefasextrasGridControl.MainView = Me.tarefasextrasAdvBandedGridView
        Me.tarefasextrasGridControl.Name = "tarefasextrasGridControl"
        Me.tarefasextrasGridControl.Size = New System.Drawing.Size(0, 0)
        Me.tarefasextrasGridControl.TabIndex = 1
        Me.tarefasextrasGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.tarefasextrasAdvBandedGridView})
        '
        'tarefasextrasAdvBandedGridView
        '
        Me.tarefasextrasAdvBandedGridView.GridControl = Me.tarefasextrasGridControl
        Me.tarefasextrasAdvBandedGridView.Name = "tarefasextrasAdvBandedGridView"
        Me.tarefasextrasAdvBandedGridView.OptionsBehavior.Editable = False
        Me.tarefasextrasAdvBandedGridView.OptionsCustomization.AllowColumnMoving = False
        Me.tarefasextrasAdvBandedGridView.OptionsCustomization.AllowColumnResizing = False
        Me.tarefasextrasAdvBandedGridView.OptionsCustomization.AllowGroup = False
        Me.tarefasextrasAdvBandedGridView.OptionsCustomization.AllowQuickHideColumns = False
        Me.tarefasextrasAdvBandedGridView.OptionsCustomization.ShowBandsInCustomizationForm = False
        Me.tarefasextrasAdvBandedGridView.OptionsView.ShowGroupPanel = False
        '
        'tarefasextrasXtraForm
        '
        Me.AcceptButton = Me.okSimpleButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.CancelButton = Me.voltarSimpleButton
        Me.ClientSize = New System.Drawing.Size(853, 511)
        Me.Controls.Add(Me.tarefasextrasSplitContainerControl)
        Me.Controls.Add(Me.tarefasextrasRibbonControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "tarefasextrasXtraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Geração de Tarefas Extras"
        CType(Me.tarefasextrasSplitContainerControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tarefasextrasSplitContainerControl.ResumeLayout(False)
        CType(Me.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacoesPanelControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.obrigacoesPanelControl.ResumeLayout(False)
        Me.obrigacoesPanelControl.PerformLayout()
        CType(Me.datavencimentoDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datavencimentoDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tarefasextrasRibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.filtroImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nomeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.funcionarioSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.funcionariosInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.funcionarioGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.competenciaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.descricaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacaoSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacoesInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacaoGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.razaosocialTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.empresaSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.empresasInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.empresaGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.observacaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tarefasextrasGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tarefasextrasAdvBandedGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tarefasextrasSplitContainerControl As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents voltarSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents okSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents obrigacoesPanelControl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents tarefasextrasRibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents incluirBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents alterarBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents excluirBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents localizarBarCheckItem As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents obrigacaoRibbonPage As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents obrigacoesRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents ImageCollection As DevExpress.Utils.ImageCollection
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
    Friend WithEvents competenciaLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents competenciaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents datavencimentoLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents observacaoTextEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents observacaoLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents obrigacoesInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents empresasInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents tarefasextrasGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents tarefasextrasAdvBandedGridView As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents funcionarioLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents nomeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents funcionarioSearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents funcionarioGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents funcionarioGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nomeGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents funcionariosInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents datavencimentoDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents atualizarBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents filtroBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents filtroImageCollection As DevExpress.Utils.ImageCollection
End Class
