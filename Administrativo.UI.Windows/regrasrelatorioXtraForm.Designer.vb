Imports DevExpress.XtraEditors.Mask
Imports DevExpress.XtraEditors.Repository

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class regrasrelatorioXtraForm
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
    Dim edit As New RepositoryItemTextEdit


    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(regrasrelatorioXtraForm))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.voltarSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.obrigacaoinicialTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.obrigacaoinicialSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.obrigacoesInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.obrigacaoinicialGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.obrigacaoinicialGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.obrigacaodescricaoinicialGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.empresafinalGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.empresafinalGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.razaosocialfinalGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.empresafinalTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.empresafinalSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.empresasInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.empresainicialTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.empresainicialSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.empresainicialGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.empresaincialGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.razaosocialinicialGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.empresafinalLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.empresainicialLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.obrigacaofinalTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.obrigacaofinalSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.obrigacaofinalGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.obrigacaofinalGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.obrigacaodescricaofinalGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.empresaLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.obrigacaoLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.imprimirSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.obrigacaoPanelControl = New DevExpress.XtraEditors.PanelControl()
        Me.obrigacaofinalLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.obrigacaoinicialLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.regraLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.regrafinalTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.regrafinalSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.regrasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.regrafinalGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.regrafinalGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.regradescricaofinalGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.regrainicialTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.regrainicialSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.regrainicialGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.regrainicialGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.regradescricaoinicialGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.regrafinalLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.regrainicialLabelControl = New DevExpress.XtraEditors.LabelControl()
        CType(Me.obrigacaoinicialTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacaoinicialSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacoesInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacaoinicialGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresafinalGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.empresafinalTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresafinalSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresasInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresainicialTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresainicialSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresainicialGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacaofinalTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacaofinalSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacaofinalGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacaoPanelControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.obrigacaoPanelControl.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.regrafinalTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.regrafinalSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.regrasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.regrafinalGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.regrainicialTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.regrainicialSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.regrainicialGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'voltarSimpleButton
        '
        Me.voltarSimpleButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.voltarSimpleButton.Image = CType(resources.GetObject("voltarSimpleButton.Image"), System.Drawing.Image)
        Me.voltarSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.voltarSimpleButton.Location = New System.Drawing.Point(638, 328)
        Me.voltarSimpleButton.Name = "voltarSimpleButton"
        Me.voltarSimpleButton.Size = New System.Drawing.Size(62, 45)
        Me.voltarSimpleButton.TabIndex = 7
        Me.voltarSimpleButton.Text = "Voltar"
        '
        'obrigacaoinicialTextEdit
        '
        Me.obrigacaoinicialTextEdit.Enabled = False
        Me.obrigacaoinicialTextEdit.Location = New System.Drawing.Point(111, 28)
        Me.obrigacaoinicialTextEdit.Name = "obrigacaoinicialTextEdit"
        Me.obrigacaoinicialTextEdit.Properties.AutoHeight = False
        Me.obrigacaoinicialTextEdit.Size = New System.Drawing.Size(578, 22)
        Me.obrigacaoinicialTextEdit.TabIndex = 2
        '
        'obrigacaoinicialSearchLookUpEdit
        '
        Me.obrigacaoinicialSearchLookUpEdit.Location = New System.Drawing.Point(6, 28)
        Me.obrigacaoinicialSearchLookUpEdit.Name = "obrigacaoinicialSearchLookUpEdit"
        Me.obrigacaoinicialSearchLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.obrigacaoinicialSearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("obrigacaoinicialSearchLookUpEdit.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.obrigacaoinicialSearchLookUpEdit.Properties.DataSource = Me.obrigacoesInfoBindingSource
        Me.obrigacaoinicialSearchLookUpEdit.Properties.DisplayMember = "obrigacao"
        Me.obrigacaoinicialSearchLookUpEdit.Properties.NullText = ""
        Me.obrigacaoinicialSearchLookUpEdit.Properties.Mask.EditMask = "0-00000"
        Me.obrigacaoinicialSearchLookUpEdit.Properties.ValueMember = "obrigacao"
        Me.obrigacaoinicialSearchLookUpEdit.Properties.View = Me.obrigacaoinicialGridView
        Me.obrigacaoinicialSearchLookUpEdit.Size = New System.Drawing.Size(100, 22)
        Me.obrigacaoinicialSearchLookUpEdit.TabIndex = 1
        Me.obrigacaoinicialSearchLookUpEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.obrigacaoinicialSearchLookUpEdit.Properties.Mask.MaskType = MaskType.Numeric
        Me.obrigacaoinicialSearchLookUpEdit.Properties.Mask.EditMask = "0-00000"
        '
        'obrigacaoinicialGridView
        '
        Me.obrigacaoinicialGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.obrigacaoinicialGridColumn, Me.obrigacaodescricaoinicialGridColumn})
        Me.obrigacaoinicialGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.obrigacaoinicialGridView.Name = "obrigacaoinicialGridView"
        Me.obrigacaoinicialGridView.OptionsFind.AlwaysVisible = True
        Me.obrigacaoinicialGridView.OptionsFind.SearchInPreview = True
        Me.obrigacaoinicialGridView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.obrigacaoinicialGridView.OptionsView.ShowGroupPanel = False
        Me.obrigacaoinicialGridView.Columns(0).ColumnEdit = obrigacaoEdit
        obrigacaoEdit.Mask.MaskType = MaskType.Simple
        obrigacaoEdit.Mask.UseMaskAsDisplayFormat = True
        obrigacaoEdit.Mask.EditMask = "0-00000"
        '
        'obrigacaoinicialGridColumn
        '
        Me.obrigacaoinicialGridColumn.Caption = "Obrigação"
        Me.obrigacaoinicialGridColumn.FieldName = "obrigacao"
        Me.obrigacaoinicialGridColumn.Name = "obrigacaoinicialGridColumn"
        Me.obrigacaoinicialGridColumn.Visible = True
        Me.obrigacaoinicialGridColumn.VisibleIndex = 0
        Me.obrigacaoinicialGridColumn.Width = 80
        '
        'obrigacaodescricaoinicialGridColumn
        '
        Me.obrigacaodescricaoinicialGridColumn.Caption = "Descrição"
        Me.obrigacaodescricaoinicialGridColumn.FieldName = "descricao"
        Me.obrigacaodescricaoinicialGridColumn.Name = "obrigacaodescricaoinicialGridColumn"
        Me.obrigacaodescricaoinicialGridColumn.Visible = True
        Me.obrigacaodescricaoinicialGridColumn.VisibleIndex = 1
        Me.obrigacaodescricaoinicialGridColumn.Width = 200
        '
        'empresafinalGridView
        '
        Me.empresafinalGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.empresafinalGridColumn, Me.razaosocialfinalGridColumn})
        Me.empresafinalGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.empresafinalGridView.Name = "empresafinalGridView"
        Me.empresafinalGridView.OptionsFind.AlwaysVisible = True
        Me.empresafinalGridView.OptionsFind.SearchInPreview = True
        Me.empresafinalGridView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.empresafinalGridView.OptionsView.ShowGroupPanel = False
        Me.empresafinalGridView.Columns(0).ColumnEdit = edit
        edit.Mask.MaskType = MaskType.Simple
        edit.Mask.UseMaskAsDisplayFormat = True
        edit.Mask.EditMask = "00.0000"
        '
        'empresafinalGridColumn
        '
        Me.empresafinalGridColumn.Caption = "Empresa"
        Me.empresafinalGridColumn.FieldName = "empresa"
        Me.empresafinalGridColumn.Name = "empresafinalGridColumn"
        Me.empresafinalGridColumn.Visible = True
        Me.empresafinalGridColumn.VisibleIndex = 0
        Me.empresafinalGridColumn.Width = 80
        '
        'razaosocialfinalGridColumn
        '
        Me.razaosocialfinalGridColumn.Caption = "Razão Social"
        Me.razaosocialfinalGridColumn.FieldName = "razaosocial"
        Me.razaosocialfinalGridColumn.Name = "razaosocialfinalGridColumn"
        Me.razaosocialfinalGridColumn.Visible = True
        Me.razaosocialfinalGridColumn.VisibleIndex = 1
        Me.razaosocialfinalGridColumn.Width = 200
        '
        'PanelControl3
        '
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.PanelControl3.Controls.Add(Me.empresafinalTextEdit)
        Me.PanelControl3.Controls.Add(Me.empresafinalSearchLookUpEdit)
        Me.PanelControl3.Controls.Add(Me.empresainicialTextEdit)
        Me.PanelControl3.Controls.Add(Me.empresainicialSearchLookUpEdit)
        Me.PanelControl3.Controls.Add(Me.empresafinalLabelControl)
        Me.PanelControl3.Controls.Add(Me.empresainicialLabelControl)
        Me.PanelControl3.Location = New System.Drawing.Point(5, 221)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(695, 97)
        Me.PanelControl3.TabIndex = 4
        '
        'empresafinalTextEdit
        '
        Me.empresafinalTextEdit.Enabled = False
        Me.empresafinalTextEdit.Location = New System.Drawing.Point(111, 70)
        Me.empresafinalTextEdit.Name = "empresafinalTextEdit"
        Me.empresafinalTextEdit.Properties.AutoHeight = False
        Me.empresafinalTextEdit.Size = New System.Drawing.Size(578, 22)
        Me.empresafinalTextEdit.TabIndex = 5
        '
        'empresafinalSearchLookUpEdit
        '
        Me.empresafinalSearchLookUpEdit.Location = New System.Drawing.Point(6, 70)
        Me.empresafinalSearchLookUpEdit.Name = "empresafinalSearchLookUpEdit"
        Me.empresafinalSearchLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.empresafinalSearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("empresafinalSearchLookUpEdit.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.empresafinalSearchLookUpEdit.Properties.DataSource = Me.empresasInfoBindingSource
        Me.empresafinalSearchLookUpEdit.Properties.DisplayMember = "empresa"
        Me.empresafinalSearchLookUpEdit.Properties.NullText = ""
        Me.empresafinalSearchLookUpEdit.Properties.ValueMember = "empresa"
        Me.empresafinalSearchLookUpEdit.Properties.View = Me.empresafinalGridView
        Me.empresafinalSearchLookUpEdit.Size = New System.Drawing.Size(100, 22)
        Me.empresafinalSearchLookUpEdit.TabIndex = 4
        Me.empresafinalSearchLookUpEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.empresafinalSearchLookUpEdit.Properties.Mask.MaskType = MaskType.Simple
        Me.empresafinalSearchLookUpEdit.Properties.Mask.EditMask = "00.0000"
        '
        'empresainicialTextEdit
        '
        Me.empresainicialTextEdit.Enabled = False
        Me.empresainicialTextEdit.Location = New System.Drawing.Point(111, 28)
        Me.empresainicialTextEdit.Name = "empresainicialTextEdit"
        Me.empresainicialTextEdit.Properties.AutoHeight = False
        Me.empresainicialTextEdit.Size = New System.Drawing.Size(578, 22)
        Me.empresainicialTextEdit.TabIndex = 2
        '
        'empresainicialSearchLookUpEdit
        '
        Me.empresainicialSearchLookUpEdit.Location = New System.Drawing.Point(6, 28)
        Me.empresainicialSearchLookUpEdit.Name = "empresainicialSearchLookUpEdit"
        Me.empresainicialSearchLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.empresainicialSearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("empresainicialSearchLookUpEdit.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, Nothing, True)})
        Me.empresainicialSearchLookUpEdit.Properties.DataSource = Me.empresasInfoBindingSource
        Me.empresainicialSearchLookUpEdit.Properties.DisplayMember = "empresa"
        Me.empresainicialSearchLookUpEdit.Properties.NullText = ""
        Me.empresainicialSearchLookUpEdit.Properties.ValueMember = "empresa"
        Me.empresainicialSearchLookUpEdit.Properties.View = Me.empresainicialGridView
        Me.empresainicialSearchLookUpEdit.Size = New System.Drawing.Size(100, 22)
        Me.empresainicialSearchLookUpEdit.TabIndex = 1
        Me.empresainicialSearchLookUpEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.empresainicialSearchLookUpEdit.Properties.Mask.MaskType = MaskType.Simple
        Me.empresainicialSearchLookUpEdit.Properties.Mask.EditMask = "00.0000"
        '
        'empresainicialGridView
        '
        Me.empresainicialGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.empresaincialGridColumn, Me.razaosocialinicialGridColumn})
        Me.empresainicialGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.empresainicialGridView.Name = "empresainicialGridView"
        Me.empresainicialGridView.OptionsFind.AlwaysVisible = True
        Me.empresainicialGridView.OptionsFind.SearchInPreview = True
        Me.empresainicialGridView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.empresainicialGridView.OptionsView.ShowGroupPanel = False
        Me.empresainicialGridView.Columns(0).ColumnEdit = edit
        edit.Mask.MaskType = MaskType.Simple
        edit.Mask.UseMaskAsDisplayFormat = True
        edit.Mask.EditMask = "00.0000"
        '
        'empresaincialGridColumn
        '
        Me.empresaincialGridColumn.Caption = "Empresa"
        Me.empresaincialGridColumn.FieldName = "empresa"
        Me.empresaincialGridColumn.Name = "empresaincialGridColumn"
        Me.empresaincialGridColumn.Visible = True
        Me.empresaincialGridColumn.VisibleIndex = 0
        Me.empresaincialGridColumn.Width = 80
        '
        'razaosocialinicialGridColumn
        '
        Me.razaosocialinicialGridColumn.Caption = "Razão Social"
        Me.razaosocialinicialGridColumn.FieldName = "razaosocial"
        Me.razaosocialinicialGridColumn.Name = "razaosocialinicialGridColumn"
        Me.razaosocialinicialGridColumn.Visible = True
        Me.razaosocialinicialGridColumn.VisibleIndex = 1
        Me.razaosocialinicialGridColumn.Width = 200
        '
        'empresafinalLabelControl
        '
        Me.empresafinalLabelControl.Location = New System.Drawing.Point(7, 55)
        Me.empresafinalLabelControl.Name = "empresafinalLabelControl"
        Me.empresafinalLabelControl.Size = New System.Drawing.Size(22, 13)
        Me.empresafinalLabelControl.TabIndex = 3
        Me.empresafinalLabelControl.Text = "Final"
        '
        'empresainicialLabelControl
        '
        Me.empresainicialLabelControl.Location = New System.Drawing.Point(7, 13)
        Me.empresainicialLabelControl.Name = "empresainicialLabelControl"
        Me.empresainicialLabelControl.Size = New System.Drawing.Size(27, 13)
        Me.empresainicialLabelControl.TabIndex = 0
        Me.empresainicialLabelControl.Text = "Inicial"
        '
        'obrigacaofinalTextEdit
        '
        Me.obrigacaofinalTextEdit.Enabled = False
        Me.obrigacaofinalTextEdit.Location = New System.Drawing.Point(111, 70)
        Me.obrigacaofinalTextEdit.Name = "obrigacaofinalTextEdit"
        Me.obrigacaofinalTextEdit.Properties.AutoHeight = False
        Me.obrigacaofinalTextEdit.Size = New System.Drawing.Size(578, 22)
        Me.obrigacaofinalTextEdit.TabIndex = 5
        '
        'obrigacaofinalSearchLookUpEdit
        '
        Me.obrigacaofinalSearchLookUpEdit.Location = New System.Drawing.Point(6, 70)
        Me.obrigacaofinalSearchLookUpEdit.Name = "obrigacaofinalSearchLookUpEdit"
        Me.obrigacaofinalSearchLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.obrigacaofinalSearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("obrigacaofinalSearchLookUpEdit.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject4, "", Nothing, Nothing, True)})
        Me.obrigacaofinalSearchLookUpEdit.Properties.DataSource = Me.obrigacoesInfoBindingSource
        Me.obrigacaofinalSearchLookUpEdit.Properties.DisplayMember = "obrigacao"
        Me.obrigacaofinalSearchLookUpEdit.Properties.NullText = ""
        Me.obrigacaofinalSearchLookUpEdit.Properties.ValueMember = "obrigacao"
        Me.obrigacaofinalSearchLookUpEdit.Properties.View = Me.obrigacaofinalGridView
        Me.obrigacaofinalSearchLookUpEdit.Size = New System.Drawing.Size(100, 22)
        Me.obrigacaofinalSearchLookUpEdit.TabIndex = 4
        Me.obrigacaofinalSearchLookUpEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.obrigacaofinalSearchLookUpEdit.Properties.Mask.MaskType = MaskType.Numeric
        Me.obrigacaofinalSearchLookUpEdit.Properties.Mask.EditMask = "0-00000"
        '
        'obrigacaofinalGridView
        '
        Me.obrigacaofinalGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.obrigacaofinalGridColumn, Me.obrigacaodescricaofinalGridColumn})
        Me.obrigacaofinalGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.obrigacaofinalGridView.Name = "obrigacaofinalGridView"
        Me.obrigacaofinalGridView.OptionsFind.AlwaysVisible = True
        Me.obrigacaofinalGridView.OptionsFind.SearchInPreview = True
        Me.obrigacaofinalGridView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.obrigacaofinalGridView.OptionsView.ShowGroupPanel = False
        Me.obrigacaofinalGridView.Columns(0).ColumnEdit = obrigacaoEdit
        obrigacaoEdit.Mask.MaskType = MaskType.Simple
        obrigacaoEdit.Mask.UseMaskAsDisplayFormat = True
        obrigacaoEdit.Mask.EditMask = "0-00000"
        '
        'obrigacaofinalGridColumn
        '
        Me.obrigacaofinalGridColumn.Caption = "Obrigação"
        Me.obrigacaofinalGridColumn.FieldName = "obrigacao"
        Me.obrigacaofinalGridColumn.Name = "obrigacaofinalGridColumn"
        Me.obrigacaofinalGridColumn.Visible = True
        Me.obrigacaofinalGridColumn.VisibleIndex = 0
        Me.obrigacaofinalGridColumn.Width = 80
        '
        'obrigacaodescricaofinalGridColumn
        '
        Me.obrigacaodescricaofinalGridColumn.Caption = "Descrição"
        Me.obrigacaodescricaofinalGridColumn.FieldName = "descricao"
        Me.obrigacaodescricaofinalGridColumn.Name = "obrigacaodescricaofinalGridColumn"
        Me.obrigacaodescricaofinalGridColumn.Visible = True
        Me.obrigacaodescricaofinalGridColumn.VisibleIndex = 1
        Me.obrigacaodescricaofinalGridColumn.Width = 200
        '
        'empresaLabelControl
        '
        Me.empresaLabelControl.Location = New System.Drawing.Point(11, 214)
        Me.empresaLabelControl.Name = "empresaLabelControl"
        Me.empresaLabelControl.Size = New System.Drawing.Size(46, 13)
        Me.empresaLabelControl.TabIndex = 5
        Me.empresaLabelControl.Text = "Empresas"
        '
        'obrigacaoLabelControl
        '
        Me.obrigacaoLabelControl.Location = New System.Drawing.Point(11, 108)
        Me.obrigacaoLabelControl.Name = "obrigacaoLabelControl"
        Me.obrigacaoLabelControl.Size = New System.Drawing.Size(54, 13)
        Me.obrigacaoLabelControl.TabIndex = 3
        Me.obrigacaoLabelControl.Text = "Obrigações"
        '
        'imprimirSimpleButton
        '
        Me.imprimirSimpleButton.Image = CType(resources.GetObject("imprimirSimpleButton.Image"), System.Drawing.Image)
        Me.imprimirSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.imprimirSimpleButton.Location = New System.Drawing.Point(570, 328)
        Me.imprimirSimpleButton.Name = "imprimirSimpleButton"
        Me.imprimirSimpleButton.Size = New System.Drawing.Size(62, 45)
        Me.imprimirSimpleButton.TabIndex = 6
        Me.imprimirSimpleButton.Text = "Imprimir"
        '
        'obrigacaoPanelControl
        '
        Me.obrigacaoPanelControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.obrigacaoPanelControl.Controls.Add(Me.obrigacaofinalTextEdit)
        Me.obrigacaoPanelControl.Controls.Add(Me.obrigacaofinalSearchLookUpEdit)
        Me.obrigacaoPanelControl.Controls.Add(Me.obrigacaoinicialTextEdit)
        Me.obrigacaoPanelControl.Controls.Add(Me.obrigacaoinicialSearchLookUpEdit)
        Me.obrigacaoPanelControl.Controls.Add(Me.obrigacaofinalLabelControl)
        Me.obrigacaoPanelControl.Controls.Add(Me.obrigacaoinicialLabelControl)
        Me.obrigacaoPanelControl.Location = New System.Drawing.Point(5, 114)
        Me.obrigacaoPanelControl.Name = "obrigacaoPanelControl"
        Me.obrigacaoPanelControl.Size = New System.Drawing.Size(695, 97)
        Me.obrigacaoPanelControl.TabIndex = 2
        '
        'obrigacaofinalLabelControl
        '
        Me.obrigacaofinalLabelControl.Location = New System.Drawing.Point(7, 55)
        Me.obrigacaofinalLabelControl.Name = "obrigacaofinalLabelControl"
        Me.obrigacaofinalLabelControl.Size = New System.Drawing.Size(22, 13)
        Me.obrigacaofinalLabelControl.TabIndex = 3
        Me.obrigacaofinalLabelControl.Text = "Final"
        '
        'obrigacaoinicialLabelControl
        '
        Me.obrigacaoinicialLabelControl.Location = New System.Drawing.Point(7, 13)
        Me.obrigacaoinicialLabelControl.Name = "obrigacaoinicialLabelControl"
        Me.obrigacaoinicialLabelControl.Size = New System.Drawing.Size(27, 13)
        Me.obrigacaoinicialLabelControl.TabIndex = 0
        Me.obrigacaoinicialLabelControl.Text = "Inicial"
        '
        'regraLabelControl
        '
        Me.regraLabelControl.Location = New System.Drawing.Point(10, 2)
        Me.regraLabelControl.Name = "regraLabelControl"
        Me.regraLabelControl.Size = New System.Drawing.Size(34, 13)
        Me.regraLabelControl.TabIndex = 1
        Me.regraLabelControl.Text = "Regras"
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.PanelControl1.Controls.Add(Me.regrafinalTextEdit)
        Me.PanelControl1.Controls.Add(Me.regrafinalSearchLookUpEdit)
        Me.PanelControl1.Controls.Add(Me.regrainicialTextEdit)
        Me.PanelControl1.Controls.Add(Me.regrainicialSearchLookUpEdit)
        Me.PanelControl1.Controls.Add(Me.regrafinalLabelControl)
        Me.PanelControl1.Controls.Add(Me.regrainicialLabelControl)
        Me.PanelControl1.Location = New System.Drawing.Point(4, 9)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(695, 97)
        Me.PanelControl1.TabIndex = 0
        '
        'regrafinalTextEdit
        '
        Me.regrafinalTextEdit.Enabled = False
        Me.regrafinalTextEdit.Location = New System.Drawing.Point(111, 70)
        Me.regrafinalTextEdit.Name = "regrafinalTextEdit"
        Me.regrafinalTextEdit.Properties.AutoHeight = False
        Me.regrafinalTextEdit.Size = New System.Drawing.Size(578, 22)
        Me.regrafinalTextEdit.TabIndex = 5
        '
        'regrafinalSearchLookUpEdit
        '
        Me.regrafinalSearchLookUpEdit.Location = New System.Drawing.Point(6, 70)
        Me.regrafinalSearchLookUpEdit.Name = "regrafinalSearchLookUpEdit"
        Me.regrafinalSearchLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.regrafinalSearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("regrafinalSearchLookUpEdit.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, "", Nothing, Nothing, True)})
        Me.regrafinalSearchLookUpEdit.Properties.DataSource = Me.regrasBindingSource
        Me.regrafinalSearchLookUpEdit.Properties.DisplayMember = "regra"
        Me.regrafinalSearchLookUpEdit.Properties.NullText = ""
        Me.regrafinalSearchLookUpEdit.Properties.ValueMember = "regra"
        Me.regrafinalSearchLookUpEdit.Properties.View = Me.regrafinalGridView
        Me.regrafinalSearchLookUpEdit.Size = New System.Drawing.Size(100, 22)
        Me.regrafinalSearchLookUpEdit.TabIndex = 4
        '
        'regrafinalGridView
        '
        Me.regrafinalGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.regrafinalGridColumn, Me.regradescricaofinalGridColumn})
        Me.regrafinalGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.regrafinalGridView.Name = "regrafinalGridView"
        Me.regrafinalGridView.OptionsFind.AlwaysVisible = True
        Me.regrafinalGridView.OptionsFind.SearchInPreview = True
        Me.regrafinalGridView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.regrafinalGridView.OptionsView.ShowGroupPanel = False
        '
        'regrafinalGridColumn
        '
        Me.regrafinalGridColumn.Caption = "Regra"
        Me.regrafinalGridColumn.FieldName = "regra"
        Me.regrafinalGridColumn.Name = "regrafinalGridColumn"
        Me.regrafinalGridColumn.Visible = True
        Me.regrafinalGridColumn.VisibleIndex = 0
        Me.regrafinalGridColumn.Width = 80
        '
        'regradescricaofinalGridColumn
        '
        Me.regradescricaofinalGridColumn.Caption = "Descrição"
        Me.regradescricaofinalGridColumn.FieldName = "descricao"
        Me.regradescricaofinalGridColumn.Name = "regradescricaofinalGridColumn"
        Me.regradescricaofinalGridColumn.Visible = True
        Me.regradescricaofinalGridColumn.VisibleIndex = 1
        Me.regradescricaofinalGridColumn.Width = 200
        '
        'regrainicialTextEdit
        '
        Me.regrainicialTextEdit.Enabled = False
        Me.regrainicialTextEdit.Location = New System.Drawing.Point(111, 28)
        Me.regrainicialTextEdit.Name = "regrainicialTextEdit"
        Me.regrainicialTextEdit.Properties.AutoHeight = False
        Me.regrainicialTextEdit.Size = New System.Drawing.Size(578, 22)
        Me.regrainicialTextEdit.TabIndex = 2
        '
        'regrainicialSearchLookUpEdit
        '
        Me.regrainicialSearchLookUpEdit.Location = New System.Drawing.Point(6, 28)
        Me.regrainicialSearchLookUpEdit.Name = "regrainicialSearchLookUpEdit"
        Me.regrainicialSearchLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.regrainicialSearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("regrainicialSearchLookUpEdit.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject6, "", Nothing, Nothing, True)})
        Me.regrainicialSearchLookUpEdit.Properties.DataSource = Me.regrasBindingSource
        Me.regrainicialSearchLookUpEdit.Properties.DisplayMember = "regra"
        Me.regrainicialSearchLookUpEdit.Properties.NullText = ""
        Me.regrainicialSearchLookUpEdit.Properties.ValueMember = "regra"
        Me.regrainicialSearchLookUpEdit.Properties.View = Me.regrainicialGridView
        Me.regrainicialSearchLookUpEdit.Size = New System.Drawing.Size(100, 22)
        Me.regrainicialSearchLookUpEdit.TabIndex = 1
        '
        'regrainicialGridView
        '
        Me.regrainicialGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.regrainicialGridColumn, Me.regradescricaoinicialGridColumn})
        Me.regrainicialGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.regrainicialGridView.Name = "regrainicialGridView"
        Me.regrainicialGridView.OptionsFind.AlwaysVisible = True
        Me.regrainicialGridView.OptionsFind.SearchInPreview = True
        Me.regrainicialGridView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.regrainicialGridView.OptionsView.ShowGroupPanel = False
        '
        'regrainicialGridColumn
        '
        Me.regrainicialGridColumn.Caption = "Regra"
        Me.regrainicialGridColumn.FieldName = "regra"
        Me.regrainicialGridColumn.Name = "regrainicialGridColumn"
        Me.regrainicialGridColumn.Visible = True
        Me.regrainicialGridColumn.VisibleIndex = 0
        Me.regrainicialGridColumn.Width = 80
        '
        'regradescricaoinicialGridColumn
        '
        Me.regradescricaoinicialGridColumn.Caption = "Descrição"
        Me.regradescricaoinicialGridColumn.FieldName = "descricao"
        Me.regradescricaoinicialGridColumn.Name = "regradescricaoinicialGridColumn"
        Me.regradescricaoinicialGridColumn.Visible = True
        Me.regradescricaoinicialGridColumn.VisibleIndex = 1
        Me.regradescricaoinicialGridColumn.Width = 200
        '
        'regrafinalLabelControl
        '
        Me.regrafinalLabelControl.Location = New System.Drawing.Point(7, 55)
        Me.regrafinalLabelControl.Name = "regrafinalLabelControl"
        Me.regrafinalLabelControl.Size = New System.Drawing.Size(22, 13)
        Me.regrafinalLabelControl.TabIndex = 3
        Me.regrafinalLabelControl.Text = "Final"
        '
        'regrainicialLabelControl
        '
        Me.regrainicialLabelControl.Location = New System.Drawing.Point(7, 13)
        Me.regrainicialLabelControl.Name = "regrainicialLabelControl"
        Me.regrainicialLabelControl.Size = New System.Drawing.Size(27, 13)
        Me.regrainicialLabelControl.TabIndex = 0
        Me.regrainicialLabelControl.Text = "Inicial"
        '
        'regrasrelatorioXtraForm
        '
        Me.AcceptButton = Me.imprimirSimpleButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.CancelButton = Me.voltarSimpleButton
        Me.ClientSize = New System.Drawing.Size(703, 376)
        Me.Controls.Add(Me.regraLabelControl)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.empresaLabelControl)
        Me.Controls.Add(Me.voltarSimpleButton)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.obrigacaoLabelControl)
        Me.Controls.Add(Me.imprimirSimpleButton)
        Me.Controls.Add(Me.obrigacaoPanelControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "regrasrelatorioXtraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Regras"
        CType(Me.obrigacaoinicialTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacaoinicialSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacoesInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacaoinicialGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.empresafinalGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.empresafinalTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.empresafinalSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.empresasInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.empresainicialTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.empresainicialSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.empresainicialGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacaofinalTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacaofinalSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacaofinalGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacaoPanelControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.obrigacaoPanelControl.ResumeLayout(False)
        Me.obrigacaoPanelControl.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.regrafinalTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.regrafinalSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.regrasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.regrafinalGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.regrainicialTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.regrainicialSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.regrainicialGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents voltarSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents obrigacaoinicialTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents empresafinalGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents obrigacaoinicialSearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents obrigacoesInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents obrigacaoinicialGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents obrigacaoinicialGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents obrigacaodescricaoinicialGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents empresafinalGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents razaosocialfinalGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents empresafinalTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents empresafinalSearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents empresasInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents empresainicialTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents empresainicialSearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents empresainicialGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents empresaincialGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents razaosocialinicialGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents empresafinalLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents empresainicialLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents obrigacaofinalTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents obrigacaofinalSearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents obrigacaofinalGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents obrigacaofinalGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents obrigacaodescricaofinalGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents empresaLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents obrigacaoLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents imprimirSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents obrigacaoPanelControl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents obrigacaofinalLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents obrigacaoinicialLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents regraLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents regrafinalTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents regrafinalSearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents regrafinalGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents regrafinalGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents regradescricaofinalGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents regrainicialTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents regrainicialSearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents regrainicialGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents regrainicialGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents regradescricaoinicialGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents regrafinalLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents regrainicialLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents regrasBindingSource As System.Windows.Forms.BindingSource
End Class
