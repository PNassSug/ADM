Imports DevExpress.XtraEditors.Mask
Imports DevExpress.XtraEditors.Repository

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class obrigacoesusuarioXtraForm
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Dim edit As New RepositoryItemTextEdit
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(obrigacoesusuarioXtraForm))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.obrigacoesusuariosSplitContainerControl = New DevExpress.XtraEditors.SplitContainerControl()
        Me.obrigacoesGroupControl = New DevExpress.XtraEditors.GroupControl()
        Me.obrigacoesSplitContainerControl = New DevExpress.XtraEditors.SplitContainerControl()
        Me.obrigacaoLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.obrigacaodescricaoTextEdit = New DevExpress.XtraEditors.TextEdit()
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
        Me.voltarSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.okSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.usuarioPanelControl = New DevExpress.XtraEditors.PanelControl()
        Me.usuarioLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.nomeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.usuarioSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.usuariosInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.usuariogeracaoGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.usuarioGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.nomeGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.obrigacoesusuariosGridControl = New DevExpress.XtraGrid.GridControl()
        Me.obrigacoesusuariosGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.obrigacoesusuariosRibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.incluirBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.alterarBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.excluirBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.localizarBarCheckItem = New DevExpress.XtraBars.BarCheckItem()
        Me.atualizarBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.empresaobrigacaoRibbonPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.regrasRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        CType(Me.obrigacoesusuariosSplitContainerControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.obrigacoesusuariosSplitContainerControl.SuspendLayout()
        CType(Me.obrigacoesGroupControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.obrigacoesGroupControl.SuspendLayout()
        CType(Me.obrigacoesSplitContainerControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.obrigacoesSplitContainerControl.SuspendLayout()
        CType(Me.obrigacaodescricaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacaoSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacoesInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacaoGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacoesGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacoesGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacoesPanelControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.obrigacoesPanelControl.SuspendLayout()
        CType(Me.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.usuarioPanelControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.usuarioPanelControl.SuspendLayout()
        CType(Me.nomeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.usuarioSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.usuariosInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.usuariogeracaoGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacoesusuariosGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacoesusuariosGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacoesusuariosRibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'obrigacoesusuariosSplitContainerControl
        '
        Me.obrigacoesusuariosSplitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.obrigacoesusuariosSplitContainerControl.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None
        Me.obrigacoesusuariosSplitContainerControl.Location = New System.Drawing.Point(0, 95)
        Me.obrigacoesusuariosSplitContainerControl.Name = "obrigacoesusuariosSplitContainerControl"
        Me.obrigacoesusuariosSplitContainerControl.Panel1.Controls.Add(Me.obrigacoesGroupControl)
        Me.obrigacoesusuariosSplitContainerControl.Panel1.Controls.Add(Me.voltarSimpleButton)
        Me.obrigacoesusuariosSplitContainerControl.Panel1.Controls.Add(Me.okSimpleButton)
        Me.obrigacoesusuariosSplitContainerControl.Panel1.Controls.Add(Me.usuarioPanelControl)
        Me.obrigacoesusuariosSplitContainerControl.Panel2.Controls.Add(Me.obrigacoesusuariosGridControl)
        Me.obrigacoesusuariosSplitContainerControl.Panel2.Text = "Panel2"
        Me.obrigacoesusuariosSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
        Me.obrigacoesusuariosSplitContainerControl.Size = New System.Drawing.Size(724, 393)
        Me.obrigacoesusuariosSplitContainerControl.SplitterPosition = 110
        Me.obrigacoesusuariosSplitContainerControl.TabIndex = 0
        '
        'obrigacoesGroupControl
        '
        Me.obrigacoesGroupControl.Controls.Add(Me.obrigacoesSplitContainerControl)
        Me.obrigacoesGroupControl.Controls.Add(Me.obrigacoesPanelControl)
        Me.obrigacoesGroupControl.Location = New System.Drawing.Point(5, 59)
        Me.obrigacoesGroupControl.Name = "obrigacoesGroupControl"
        Me.obrigacoesGroupControl.Size = New System.Drawing.Size(714, 274)
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
        Me.obrigacoesSplitContainerControl.Size = New System.Drawing.Size(699, 200)
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
        Me.obrigacaodescricaoTextEdit.Size = New System.Drawing.Size(583, 22)
        Me.obrigacaodescricaoTextEdit.TabIndex = 2
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
        edit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
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
        Me.obrigacaoGridView.Columns(0).ColumnEdit = edit
        edit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        edit.Mask.UseMaskAsDisplayFormat = True
        edit.Mask.EditMask = "0-00000"
        '
        'obrigacaoGridColumn
        '
        Me.obrigacaoGridColumn.Caption = "Obrigação"
        Me.obrigacaoGridColumn.FieldName = "obrigacao"
        Me.obrigacaoGridColumn.Name = "obrigacaoGridColumn"
        Me.obrigacaoGridColumn.Visible = True
        Me.obrigacaoGridColumn.VisibleIndex = 0
        Me.obrigacaoGridColumn.Width = 80
        edit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        edit.Mask.UseMaskAsDisplayFormat = True
        edit.Mask.EditMask = "0-00000"
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
        Me.obrigacoesGridControl.Size = New System.Drawing.Size(699, 200)
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
        'voltarSimpleButton
        '
        Me.voltarSimpleButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.voltarSimpleButton.Image = CType(resources.GetObject("voltarSimpleButton.Image"), System.Drawing.Image)
        Me.voltarSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.voltarSimpleButton.Location = New System.Drawing.Point(657, 339)
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
        Me.okSimpleButton.Location = New System.Drawing.Point(591, 339)
        Me.okSimpleButton.Name = "okSimpleButton"
        Me.okSimpleButton.Size = New System.Drawing.Size(62, 45)
        Me.okSimpleButton.TabIndex = 2
        Me.okSimpleButton.Text = "OK"
        '
        'usuarioPanelControl
        '
        Me.usuarioPanelControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.usuarioPanelControl.Controls.Add(Me.usuarioLabelControl)
        Me.usuarioPanelControl.Controls.Add(Me.nomeTextEdit)
        Me.usuarioPanelControl.Controls.Add(Me.usuarioSearchLookUpEdit)
        Me.usuarioPanelControl.Location = New System.Drawing.Point(5, 3)
        Me.usuarioPanelControl.Name = "usuarioPanelControl"
        Me.usuarioPanelControl.Size = New System.Drawing.Size(714, 50)
        Me.usuarioPanelControl.TabIndex = 0
        '
        'usuarioLabelControl
        '
        Me.usuarioLabelControl.Location = New System.Drawing.Point(5, 6)
        Me.usuarioLabelControl.Name = "usuarioLabelControl"
        Me.usuarioLabelControl.Size = New System.Drawing.Size(36, 13)
        Me.usuarioLabelControl.TabIndex = 0
        Me.usuarioLabelControl.Text = "Usuário"
        '
        'nomeTextEdit
        '
        Me.nomeTextEdit.EditValue = ""
        Me.nomeTextEdit.Enabled = False
        Me.nomeTextEdit.Location = New System.Drawing.Point(111, 23)
        Me.nomeTextEdit.Name = "nomeTextEdit"
        Me.nomeTextEdit.Properties.AutoHeight = False
        Me.nomeTextEdit.Size = New System.Drawing.Size(598, 20)
        Me.nomeTextEdit.TabIndex = 2
        '
        'usuarioSearchLookUpEdit
        '
        Me.usuarioSearchLookUpEdit.Location = New System.Drawing.Point(5, 23)
        Me.usuarioSearchLookUpEdit.Name = "usuarioSearchLookUpEdit"
        Me.usuarioSearchLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.usuarioSearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("usuarioSearchLookUpEdit.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.usuarioSearchLookUpEdit.Properties.DataSource = Me.usuariosInfoBindingSource
        Me.usuarioSearchLookUpEdit.Properties.DisplayMember = "login"
        Me.usuarioSearchLookUpEdit.Properties.NullText = ""
        Me.usuarioSearchLookUpEdit.Properties.ValueMember = "login"
        Me.usuarioSearchLookUpEdit.Properties.View = Me.usuariogeracaoGridView
        Me.usuarioSearchLookUpEdit.Size = New System.Drawing.Size(100, 22)
        Me.usuarioSearchLookUpEdit.TabIndex = 1
        '
        'usuariogeracaoGridView
        '
        Me.usuariogeracaoGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.usuarioGridColumn, Me.nomeGridColumn})
        Me.usuariogeracaoGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.usuariogeracaoGridView.Name = "usuariogeracaoGridView"
        Me.usuariogeracaoGridView.OptionsFind.AlwaysVisible = True
        Me.usuariogeracaoGridView.OptionsFind.SearchInPreview = True
        Me.usuariogeracaoGridView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.usuariogeracaoGridView.OptionsView.ShowGroupPanel = False
        '
        'usuarioGridColumn
        '
        Me.usuarioGridColumn.Caption = "Usuário"
        Me.usuarioGridColumn.FieldName = "login"
        Me.usuarioGridColumn.Name = "usuarioGridColumn"
        Me.usuarioGridColumn.Visible = True
        Me.usuarioGridColumn.VisibleIndex = 0
        Me.usuarioGridColumn.Width = 80
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
        'obrigacoesusuariosGridControl
        '
        Me.obrigacoesusuariosGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.obrigacoesusuariosGridControl.Location = New System.Drawing.Point(0, 0)
        Me.obrigacoesusuariosGridControl.MainView = Me.obrigacoesusuariosGridView
        Me.obrigacoesusuariosGridControl.Name = "obrigacoesusuariosGridControl"
        Me.obrigacoesusuariosGridControl.Size = New System.Drawing.Size(0, 0)
        Me.obrigacoesusuariosGridControl.TabIndex = 0
        Me.obrigacoesusuariosGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.obrigacoesusuariosGridView})
        '
        'obrigacoesusuariosGridView
        '
        Me.obrigacoesusuariosGridView.GridControl = Me.obrigacoesusuariosGridControl
        Me.obrigacoesusuariosGridView.Name = "obrigacoesusuariosGridView"
        Me.obrigacoesusuariosGridView.OptionsBehavior.Editable = False
        Me.obrigacoesusuariosGridView.OptionsCustomization.AllowColumnMoving = False
        Me.obrigacoesusuariosGridView.OptionsCustomization.AllowColumnResizing = False
        Me.obrigacoesusuariosGridView.OptionsCustomization.AllowGroup = False
        Me.obrigacoesusuariosGridView.OptionsCustomization.AllowQuickHideColumns = False
        Me.obrigacoesusuariosGridView.OptionsView.ShowGroupPanel = False
        '
        'obrigacoesusuariosRibbonControl
        '
        Me.obrigacoesusuariosRibbonControl.ExpandCollapseItem.Id = 0
        Me.obrigacoesusuariosRibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.obrigacoesusuariosRibbonControl.ExpandCollapseItem, Me.incluirBarButtonItem, Me.alterarBarButtonItem, Me.excluirBarButtonItem, Me.localizarBarCheckItem, Me.atualizarBarButtonItem})
        Me.obrigacoesusuariosRibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.obrigacoesusuariosRibbonControl.MaxItemId = 6
        Me.obrigacoesusuariosRibbonControl.Name = "obrigacoesusuariosRibbonControl"
        Me.obrigacoesusuariosRibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.empresaobrigacaoRibbonPage})
        Me.obrigacoesusuariosRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.obrigacoesusuariosRibbonControl.ShowCategoryInCaption = False
        Me.obrigacoesusuariosRibbonControl.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.obrigacoesusuariosRibbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.obrigacoesusuariosRibbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.obrigacoesusuariosRibbonControl.ShowToolbarCustomizeItem = False
        Me.obrigacoesusuariosRibbonControl.Size = New System.Drawing.Size(724, 95)
        Me.obrigacoesusuariosRibbonControl.Toolbar.ShowCustomizeItem = False
        Me.obrigacoesusuariosRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'incluirBarButtonItem
        '
        Me.incluirBarButtonItem.Caption = "Incluir"
        Me.incluirBarButtonItem.Id = 1
        Me.incluirBarButtonItem.ImageOptions.Image = CType(resources.GetObject("incluirBarButtonItem.ImageOptions.Image"), System.Drawing.Image)
        Me.incluirBarButtonItem.Name = "incluirBarButtonItem"
        Me.incluirBarButtonItem.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        Me.incluirBarButtonItem.Tag = "cadousinc"
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
        Me.alterarBarButtonItem.Tag = "cadousalt"
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
        Me.excluirBarButtonItem.Tag = "cadousexc"
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
        'obrigacoesusuarioXtraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(724, 488)
        Me.Controls.Add(Me.obrigacoesusuariosSplitContainerControl)
        Me.Controls.Add(Me.obrigacoesusuariosRibbonControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "obrigacoesusuarioXtraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Vínculo de Usuários/Obrigações"
        CType(Me.obrigacoesusuariosSplitContainerControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.obrigacoesusuariosSplitContainerControl.ResumeLayout(False)
        CType(Me.obrigacoesGroupControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.obrigacoesGroupControl.ResumeLayout(False)
        CType(Me.obrigacoesSplitContainerControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.obrigacoesSplitContainerControl.ResumeLayout(False)
        CType(Me.obrigacaodescricaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacaoSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacoesInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacaoGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacoesGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacoesGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacoesPanelControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.obrigacoesPanelControl.ResumeLayout(False)
        CType(Me.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.usuarioPanelControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.usuarioPanelControl.ResumeLayout(False)
        Me.usuarioPanelControl.PerformLayout()
        CType(Me.nomeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.usuarioSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.usuariosInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.usuariogeracaoGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacoesusuariosGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacoesusuariosGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacoesusuariosRibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents obrigacoesusuariosSplitContainerControl As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents obrigacoesusuariosRibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents incluirBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents alterarBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents excluirBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents localizarBarCheckItem As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents atualizarBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents empresaobrigacaoRibbonPage As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents regrasRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents obrigacoesGroupControl As DevExpress.XtraEditors.GroupControl
    Friend WithEvents obrigacoesSplitContainerControl As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents obrigacaoLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents obrigacaodescricaoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents obrigacaoSearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents obrigacaoGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents obrigacaoGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents descricaoGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents obrigacoesGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents obrigacoesGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents obrigacoesPanelControl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents voltarobrigacoesSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents confirmarobrigacoesSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents excluirobrigacoesSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents alterarobrigacoesSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents incluirobrigacoesSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents usuarioPanelControl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents obrigacoesusuariosGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents obrigacoesusuariosGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ImageCollection As DevExpress.Utils.ImageCollection
    Friend WithEvents obrigacoesInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents voltarSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents okSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents usuariosInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents usuarioLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents nomeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents usuarioSearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents usuariogeracaoGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents usuarioGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nomeGridColumn As DevExpress.XtraGrid.Columns.GridColumn
End Class
