Imports DevExpress.XtraEditors.Mask
Imports DevExpress.XtraEditors.Repository

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class maladiretaXtraform
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
    Dim obrigacaoEdit As New RepositoryItemTextEdit

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(maladiretaXtraform))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.ImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.obrigacaoLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.obrigacaoGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.descricaoGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.obrigacoesGridControl = New DevExpress.XtraGrid.GridControl()
        Me.obrigacoesGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.obrigacaoGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.obrigacaoSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.obrigacoesInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.obrigacoesSplitContainerControl = New DevExpress.XtraEditors.SplitContainerControl()
        Me.obrigacaodescricaoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.obrigacoesPanelControl = New DevExpress.XtraEditors.PanelControl()
        Me.voltarobrigacoesSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.confirmarobrigacoesSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.excluirobrigacoesSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.alterarobrigacoesSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.incluirobrigacoesSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.voltarSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.mensagemLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.maladiretaLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.maladiretaRibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.incluirBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.alterarBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.excluirBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.localizarBarCheckItem = New DevExpress.XtraBars.BarCheckItem()
        Me.atualizarBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.empresaobrigacaoRibbonPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.maladiretaRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.obrigacoesGroupControl = New DevExpress.XtraEditors.GroupControl()
        Me.maladiretaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.maladiretaGridControl = New DevExpress.XtraGrid.GridControl()
        Me.maladiretaGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.maladiretaPanelControl = New DevExpress.XtraEditors.PanelControl()
        Me.descricaoLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.descricaoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.categoriapalavrareservadaComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.palavrareservadaListBoxControl = New DevExpress.XtraEditors.ListBoxControl()
        Me.mensagemMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.okSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.empresasInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.maladiretaSplitContainerControl = New DevExpress.XtraEditors.SplitContainerControl()
        CType(Me.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacoesGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacoesGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacaoGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacaoSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacoesInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacoesSplitContainerControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.obrigacoesSplitContainerControl.SuspendLayout()
        CType(Me.obrigacaodescricaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacoesPanelControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.obrigacoesPanelControl.SuspendLayout()
        CType(Me.maladiretaRibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacoesGroupControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.obrigacoesGroupControl.SuspendLayout()
        CType(Me.maladiretaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maladiretaGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maladiretaGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maladiretaPanelControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.maladiretaPanelControl.SuspendLayout()
        CType(Me.descricaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.categoriapalavrareservadaComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.palavrareservadaListBoxControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mensagemMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresasInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maladiretaSplitContainerControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.maladiretaSplitContainerControl.SuspendLayout()
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
        'obrigacaoLabelControl
        '
        Me.obrigacaoLabelControl.Location = New System.Drawing.Point(6, 3)
        Me.obrigacaoLabelControl.Name = "obrigacaoLabelControl"
        Me.obrigacaoLabelControl.Size = New System.Drawing.Size(49, 13)
        Me.obrigacaoLabelControl.TabIndex = 0
        Me.obrigacaoLabelControl.Text = "Obrigação"
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
        Me.obrigacoesGridControl.TabIndex = 0
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
        'obrigacaoSearchLookUpEdit
        '
        Me.obrigacaoSearchLookUpEdit.Location = New System.Drawing.Point(6, 20)
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
        'obrigacoesSplitContainerControl
        '
        Me.obrigacoesSplitContainerControl.Location = New System.Drawing.Point(5, 69)
        Me.obrigacoesSplitContainerControl.Name = "obrigacoesSplitContainerControl"
        Me.obrigacoesSplitContainerControl.Panel1.Controls.Add(Me.obrigacaoLabelControl)
        Me.obrigacoesSplitContainerControl.Panel1.Controls.Add(Me.obrigacaodescricaoTextEdit)
        Me.obrigacoesSplitContainerControl.Panel1.Controls.Add(Me.obrigacaoSearchLookUpEdit)
        Me.obrigacoesSplitContainerControl.Panel2.Controls.Add(Me.obrigacoesGridControl)
        Me.obrigacoesSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
        Me.obrigacoesSplitContainerControl.Size = New System.Drawing.Size(752, 200)
        Me.obrigacoesSplitContainerControl.TabIndex = 1
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
        'obrigacoesPanelControl
        '
        Me.obrigacoesPanelControl.Controls.Add(Me.voltarobrigacoesSimpleButton)
        Me.obrigacoesPanelControl.Controls.Add(Me.confirmarobrigacoesSimpleButton)
        Me.obrigacoesPanelControl.Controls.Add(Me.excluirobrigacoesSimpleButton)
        Me.obrigacoesPanelControl.Controls.Add(Me.alterarobrigacoesSimpleButton)
        Me.obrigacoesPanelControl.Controls.Add(Me.incluirobrigacoesSimpleButton)
        Me.obrigacoesPanelControl.Location = New System.Drawing.Point(5, 24)
        Me.obrigacoesPanelControl.Name = "obrigacoesPanelControl"
        Me.obrigacoesPanelControl.Size = New System.Drawing.Size(752, 39)
        Me.obrigacoesPanelControl.TabIndex = 0
        '
        'voltarobrigacoesSimpleButton
        '
        Me.voltarobrigacoesSimpleButton.Image = CType(resources.GetObject("voltarobrigacoesSimpleButton.Image"), System.Drawing.Image)
        Me.voltarobrigacoesSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.voltarobrigacoesSimpleButton.Location = New System.Drawing.Point(717, 7)
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
        Me.confirmarobrigacoesSimpleButton.Location = New System.Drawing.Point(683, 7)
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
        Me.voltarSimpleButton.Location = New System.Drawing.Point(703, 517)
        Me.voltarSimpleButton.Name = "voltarSimpleButton"
        Me.voltarSimpleButton.Size = New System.Drawing.Size(62, 45)
        Me.voltarSimpleButton.TabIndex = 3
        Me.voltarSimpleButton.Text = "Voltar"
        '
        'mensagemLabelControl
        '
        Me.mensagemLabelControl.Location = New System.Drawing.Point(10, 46)
        Me.mensagemLabelControl.Name = "mensagemLabelControl"
        Me.mensagemLabelControl.Size = New System.Drawing.Size(51, 13)
        Me.mensagemLabelControl.TabIndex = 4
        Me.mensagemLabelControl.Text = "Mensagem"
        '
        'maladiretaLabelControl
        '
        Me.maladiretaLabelControl.Location = New System.Drawing.Point(12, 5)
        Me.maladiretaLabelControl.Name = "maladiretaLabelControl"
        Me.maladiretaLabelControl.Size = New System.Drawing.Size(54, 13)
        Me.maladiretaLabelControl.TabIndex = 0
        Me.maladiretaLabelControl.Text = "Mala Direta"
        '
        'maladiretaRibbonControl
        '
        Me.maladiretaRibbonControl.ExpandCollapseItem.Id = 0
        Me.maladiretaRibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.maladiretaRibbonControl.ExpandCollapseItem, Me.incluirBarButtonItem, Me.alterarBarButtonItem, Me.excluirBarButtonItem, Me.localizarBarCheckItem, Me.atualizarBarButtonItem})
        Me.maladiretaRibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.maladiretaRibbonControl.MaxItemId = 6
        Me.maladiretaRibbonControl.Name = "maladiretaRibbonControl"
        Me.maladiretaRibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.empresaobrigacaoRibbonPage})
        Me.maladiretaRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.maladiretaRibbonControl.ShowCategoryInCaption = False
        Me.maladiretaRibbonControl.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.maladiretaRibbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.maladiretaRibbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.maladiretaRibbonControl.ShowToolbarCustomizeItem = False
        Me.maladiretaRibbonControl.Size = New System.Drawing.Size(771, 95)
        Me.maladiretaRibbonControl.Toolbar.ShowCustomizeItem = False
        Me.maladiretaRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'incluirBarButtonItem
        '
        Me.incluirBarButtonItem.Caption = "Incluir"
        Me.incluirBarButtonItem.Id = 1
        Me.incluirBarButtonItem.ImageOptions.Image = CType(resources.GetObject("incluirBarButtonItem.ImageOptions.Image"), System.Drawing.Image)
        Me.incluirBarButtonItem.Name = "incluirBarButtonItem"
        Me.incluirBarButtonItem.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        Me.incluirBarButtonItem.Tag = "cadmalinc"
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
        Me.alterarBarButtonItem.Tag = "cadmalalt"
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
        Me.excluirBarButtonItem.Tag = "cadmalexc"
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
        Me.empresaobrigacaoRibbonPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.maladiretaRibbonPageGroup})
        Me.empresaobrigacaoRibbonPage.Name = "empresaobrigacaoRibbonPage"
        Me.empresaobrigacaoRibbonPage.Text = "RibbonPage1"
        '
        'maladiretaRibbonPageGroup
        '
        Me.maladiretaRibbonPageGroup.ItemLinks.Add(Me.incluirBarButtonItem)
        Me.maladiretaRibbonPageGroup.ItemLinks.Add(Me.alterarBarButtonItem)
        Me.maladiretaRibbonPageGroup.ItemLinks.Add(Me.excluirBarButtonItem)
        Me.maladiretaRibbonPageGroup.ItemLinks.Add(Me.localizarBarCheckItem)
        Me.maladiretaRibbonPageGroup.ItemLinks.Add(Me.atualizarBarButtonItem)
        Me.maladiretaRibbonPageGroup.Name = "maladiretaRibbonPageGroup"
        Me.maladiretaRibbonPageGroup.ShowCaptionButton = False
        '
        'obrigacoesGroupControl
        '
        Me.obrigacoesGroupControl.Controls.Add(Me.obrigacoesSplitContainerControl)
        Me.obrigacoesGroupControl.Controls.Add(Me.obrigacoesPanelControl)
        Me.obrigacoesGroupControl.Location = New System.Drawing.Point(5, 239)
        Me.obrigacoesGroupControl.Name = "obrigacoesGroupControl"
        Me.obrigacoesGroupControl.Size = New System.Drawing.Size(762, 274)
        Me.obrigacoesGroupControl.TabIndex = 1
        Me.obrigacoesGroupControl.Text = "Relação das Obrigações"
        '
        'maladiretaTextEdit
        '
        Me.maladiretaTextEdit.Enabled = False
        Me.maladiretaTextEdit.Location = New System.Drawing.Point(11, 21)
        Me.maladiretaTextEdit.MenuManager = Me.maladiretaRibbonControl
        Me.maladiretaTextEdit.Name = "maladiretaTextEdit"
        Me.maladiretaTextEdit.Size = New System.Drawing.Size(85, 20)
        Me.maladiretaTextEdit.TabIndex = 1
        '
        'maladiretaGridControl
        '
        Me.maladiretaGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.maladiretaGridControl.Location = New System.Drawing.Point(0, 0)
        Me.maladiretaGridControl.MainView = Me.maladiretaGridView
        Me.maladiretaGridControl.Name = "maladiretaGridControl"
        Me.maladiretaGridControl.Size = New System.Drawing.Size(0, 0)
        Me.maladiretaGridControl.TabIndex = 0
        Me.maladiretaGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.maladiretaGridView})
        '
        'maladiretaGridView
        '
        Me.maladiretaGridView.GridControl = Me.maladiretaGridControl
        Me.maladiretaGridView.Name = "maladiretaGridView"
        Me.maladiretaGridView.OptionsBehavior.Editable = False
        Me.maladiretaGridView.OptionsCustomization.AllowColumnMoving = False
        Me.maladiretaGridView.OptionsCustomization.AllowColumnResizing = False
        Me.maladiretaGridView.OptionsCustomization.AllowGroup = False
        Me.maladiretaGridView.OptionsCustomization.AllowQuickHideColumns = False
        Me.maladiretaGridView.OptionsView.ShowGroupPanel = False
        '
        'maladiretaPanelControl
        '
        Me.maladiretaPanelControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.maladiretaPanelControl.Controls.Add(Me.descricaoLabelControl)
        Me.maladiretaPanelControl.Controls.Add(Me.descricaoTextEdit)
        Me.maladiretaPanelControl.Controls.Add(Me.LabelControl1)
        Me.maladiretaPanelControl.Controls.Add(Me.categoriapalavrareservadaComboBoxEdit)
        Me.maladiretaPanelControl.Controls.Add(Me.palavrareservadaListBoxControl)
        Me.maladiretaPanelControl.Controls.Add(Me.mensagemMemoEdit)
        Me.maladiretaPanelControl.Controls.Add(Me.mensagemLabelControl)
        Me.maladiretaPanelControl.Controls.Add(Me.maladiretaLabelControl)
        Me.maladiretaPanelControl.Controls.Add(Me.maladiretaTextEdit)
        Me.maladiretaPanelControl.Location = New System.Drawing.Point(5, 3)
        Me.maladiretaPanelControl.Name = "maladiretaPanelControl"
        Me.maladiretaPanelControl.Size = New System.Drawing.Size(762, 230)
        Me.maladiretaPanelControl.TabIndex = 0
        '
        'descricaoLabelControl
        '
        Me.descricaoLabelControl.Location = New System.Drawing.Point(105, 5)
        Me.descricaoLabelControl.Name = "descricaoLabelControl"
        Me.descricaoLabelControl.Size = New System.Drawing.Size(46, 13)
        Me.descricaoLabelControl.TabIndex = 2
        Me.descricaoLabelControl.Text = "Descrição"
        '
        'descricaoTextEdit
        '
        Me.descricaoTextEdit.EditValue = ""
        Me.descricaoTextEdit.Location = New System.Drawing.Point(105, 22)
        Me.descricaoTextEdit.MenuManager = Me.maladiretaRibbonControl
        Me.descricaoTextEdit.Name = "descricaoTextEdit"
        Me.descricaoTextEdit.Properties.MaxLength = 50
        Me.descricaoTextEdit.Size = New System.Drawing.Size(454, 20)
        Me.descricaoTextEdit.TabIndex = 3
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(569, 3)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(96, 13)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "Palavras Reservada"
        '
        'categoriapalavrareservadaComboBoxEdit
        '
        Me.categoriapalavrareservadaComboBoxEdit.Location = New System.Drawing.Point(569, 21)
        Me.categoriapalavrareservadaComboBoxEdit.MenuManager = Me.maladiretaRibbonControl
        Me.categoriapalavrareservadaComboBoxEdit.Name = "categoriapalavrareservadaComboBoxEdit"
        Me.categoriapalavrareservadaComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.categoriapalavrareservadaComboBoxEdit.Size = New System.Drawing.Size(184, 20)
        Me.categoriapalavrareservadaComboBoxEdit.TabIndex = 7
        '
        'palavrareservadaListBoxControl
        '
        Me.palavrareservadaListBoxControl.Cursor = System.Windows.Forms.Cursors.Default
        Me.palavrareservadaListBoxControl.Location = New System.Drawing.Point(569, 38)
        Me.palavrareservadaListBoxControl.Name = "palavrareservadaListBoxControl"
        Me.palavrareservadaListBoxControl.Size = New System.Drawing.Size(184, 186)
        Me.palavrareservadaListBoxControl.TabIndex = 8
        '
        'mensagemMemoEdit
        '
        Me.mensagemMemoEdit.Location = New System.Drawing.Point(10, 64)
        Me.mensagemMemoEdit.MenuManager = Me.maladiretaRibbonControl
        Me.mensagemMemoEdit.Name = "mensagemMemoEdit"
        Me.mensagemMemoEdit.Size = New System.Drawing.Size(549, 160)
        Me.mensagemMemoEdit.TabIndex = 5
        '
        'okSimpleButton
        '
        Me.okSimpleButton.ImageIndex = 0
        Me.okSimpleButton.ImageList = Me.ImageCollection
        Me.okSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.okSimpleButton.Location = New System.Drawing.Point(637, 517)
        Me.okSimpleButton.Name = "okSimpleButton"
        Me.okSimpleButton.Size = New System.Drawing.Size(62, 45)
        Me.okSimpleButton.TabIndex = 2
        Me.okSimpleButton.Text = "OK"
        '
        'maladiretaSplitContainerControl
        '
        Me.maladiretaSplitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.maladiretaSplitContainerControl.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None
        Me.maladiretaSplitContainerControl.Location = New System.Drawing.Point(0, 95)
        Me.maladiretaSplitContainerControl.Name = "maladiretaSplitContainerControl"
        Me.maladiretaSplitContainerControl.Panel1.Controls.Add(Me.obrigacoesGroupControl)
        Me.maladiretaSplitContainerControl.Panel1.Controls.Add(Me.voltarSimpleButton)
        Me.maladiretaSplitContainerControl.Panel1.Controls.Add(Me.okSimpleButton)
        Me.maladiretaSplitContainerControl.Panel1.Controls.Add(Me.maladiretaPanelControl)
        Me.maladiretaSplitContainerControl.Panel2.Controls.Add(Me.maladiretaGridControl)
        Me.maladiretaSplitContainerControl.Panel2.Text = "Panel2"
        Me.maladiretaSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
        Me.maladiretaSplitContainerControl.Size = New System.Drawing.Size(771, 565)
        Me.maladiretaSplitContainerControl.SplitterPosition = 110
        Me.maladiretaSplitContainerControl.TabIndex = 0
        '
        'maladiretaXtraform
        '
        Me.AcceptButton = Me.okSimpleButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.voltarSimpleButton
        Me.ClientSize = New System.Drawing.Size(771, 660)
        Me.Controls.Add(Me.maladiretaSplitContainerControl)
        Me.Controls.Add(Me.maladiretaRibbonControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "maladiretaXtraform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mala Direta"
        CType(Me.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacoesGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacoesGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacaoGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacaoSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacoesInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacoesSplitContainerControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.obrigacoesSplitContainerControl.ResumeLayout(False)
        CType(Me.obrigacaodescricaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacoesPanelControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.obrigacoesPanelControl.ResumeLayout(False)
        CType(Me.maladiretaRibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacoesGroupControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.obrigacoesGroupControl.ResumeLayout(False)
        CType(Me.maladiretaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maladiretaGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maladiretaGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maladiretaPanelControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.maladiretaPanelControl.ResumeLayout(False)
        Me.maladiretaPanelControl.PerformLayout()
        CType(Me.descricaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.categoriapalavrareservadaComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.palavrareservadaListBoxControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mensagemMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.empresasInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maladiretaSplitContainerControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.maladiretaSplitContainerControl.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImageCollection As DevExpress.Utils.ImageCollection
    Friend WithEvents obrigacaoLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents obrigacaoGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents descricaoGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents obrigacoesGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents obrigacoesGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents obrigacaoGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents obrigacaoSearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents obrigacoesInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents obrigacoesSplitContainerControl As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents obrigacaodescricaoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents obrigacoesPanelControl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents voltarobrigacoesSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents confirmarobrigacoesSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents excluirobrigacoesSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents alterarobrigacoesSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents incluirobrigacoesSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents voltarSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents mensagemLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents maladiretaLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents maladiretaRibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents incluirBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents alterarBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents excluirBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents localizarBarCheckItem As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents atualizarBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents empresaobrigacaoRibbonPage As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents maladiretaRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents obrigacoesGroupControl As DevExpress.XtraEditors.GroupControl
    Friend WithEvents maladiretaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents maladiretaGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents maladiretaGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents maladiretaPanelControl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents okSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents empresasInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents maladiretaSplitContainerControl As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents mensagemMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents categoriapalavrareservadaComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents palavrareservadaListBoxControl As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents descricaoLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents descricaoTextEdit As DevExpress.XtraEditors.TextEdit
End Class
