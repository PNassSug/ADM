Imports DevExpress.XtraEditors.Mask
Imports DevExpress.XtraEditors.Repository

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class regrasgeracaoXtraForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(regrasgeracaoXtraForm))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.regraLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.regrasPanelControl = New DevExpress.XtraEditors.PanelControl()
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
        Me.empresaLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.voltarSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.empresasPanelControl = New DevExpress.XtraEditors.PanelControl()
        Me.empresafinalTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.empresafinalSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.empresasInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.empresafinalGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.empresafinalGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.razaosocialfinalGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.empresainicialTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.empresainicialSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.empresainicialGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.empresaincialGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.razaosocialinicialGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.empresafinalLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.empresainicialLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.gerarSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.excluirempresaobrigacaoCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.obrigacoesPanelControl = New DevExpress.XtraEditors.PanelControl()
        Me.descricaoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.obrigacaoSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.obrigacoesInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.obrigacaoGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.obrigacaoGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.descricaoGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.obrigacaoLabelControl = New DevExpress.XtraEditors.LabelControl()
        CType(Me.regrasPanelControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.regrasPanelControl.SuspendLayout()
        CType(Me.regrafinalTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.regrafinalSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.regrasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.regrafinalGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.regrainicialTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.regrainicialSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.regrainicialGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresasPanelControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.empresasPanelControl.SuspendLayout()
        CType(Me.empresafinalTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresafinalSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresasInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresafinalGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresainicialTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresainicialSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresainicialGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.excluirempresaobrigacaoCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacoesPanelControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.obrigacoesPanelControl.SuspendLayout()
        CType(Me.descricaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacaoSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacoesInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacaoGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'regraLabelControl
        '
        Me.regraLabelControl.Location = New System.Drawing.Point(12, 1)
        Me.regraLabelControl.Name = "regraLabelControl"
        Me.regraLabelControl.Size = New System.Drawing.Size(34, 13)
        Me.regraLabelControl.TabIndex = 0
        Me.regraLabelControl.Text = "Regras"
        '
        'regrasPanelControl
        '
        Me.regrasPanelControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.regrasPanelControl.Controls.Add(Me.regrafinalTextEdit)
        Me.regrasPanelControl.Controls.Add(Me.regrafinalSearchLookUpEdit)
        Me.regrasPanelControl.Controls.Add(Me.regrainicialTextEdit)
        Me.regrasPanelControl.Controls.Add(Me.regrainicialSearchLookUpEdit)
        Me.regrasPanelControl.Controls.Add(Me.regrafinalLabelControl)
        Me.regrasPanelControl.Controls.Add(Me.regrainicialLabelControl)
        Me.regrasPanelControl.Location = New System.Drawing.Point(6, 8)
        Me.regrasPanelControl.Name = "regrasPanelControl"
        Me.regrasPanelControl.Size = New System.Drawing.Size(695, 97)
        Me.regrasPanelControl.TabIndex = 1
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
        Me.regrafinalSearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("regrafinalSearchLookUpEdit.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
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
        Me.regrainicialSearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("regrainicialSearchLookUpEdit.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
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
        'empresaLabelControl
        '
        Me.empresaLabelControl.Location = New System.Drawing.Point(12, 107)
        Me.empresaLabelControl.Name = "empresaLabelControl"
        Me.empresaLabelControl.Size = New System.Drawing.Size(46, 13)
        Me.empresaLabelControl.TabIndex = 2
        Me.empresaLabelControl.Text = "Empresas"
        '
        'voltarSimpleButton
        '
        Me.voltarSimpleButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.voltarSimpleButton.Image = CType(resources.GetObject("voltarSimpleButton.Image"), System.Drawing.Image)
        Me.voltarSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.voltarSimpleButton.Location = New System.Drawing.Point(639, 266)
        Me.voltarSimpleButton.Name = "voltarSimpleButton"
        Me.voltarSimpleButton.Size = New System.Drawing.Size(62, 45)
        Me.voltarSimpleButton.TabIndex = 8
        Me.voltarSimpleButton.Text = "Voltar"
        '
        'empresasPanelControl
        '
        Me.empresasPanelControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.empresasPanelControl.Controls.Add(Me.empresafinalTextEdit)
        Me.empresasPanelControl.Controls.Add(Me.empresafinalSearchLookUpEdit)
        Me.empresasPanelControl.Controls.Add(Me.empresainicialTextEdit)
        Me.empresasPanelControl.Controls.Add(Me.empresainicialSearchLookUpEdit)
        Me.empresasPanelControl.Controls.Add(Me.empresafinalLabelControl)
        Me.empresasPanelControl.Controls.Add(Me.empresainicialLabelControl)
        Me.empresasPanelControl.Location = New System.Drawing.Point(6, 114)
        Me.empresasPanelControl.Name = "empresasPanelControl"
        Me.empresasPanelControl.Size = New System.Drawing.Size(695, 97)
        Me.empresasPanelControl.TabIndex = 3
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
        Me.empresafinalSearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("empresafinalSearchLookUpEdit.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, Nothing, True)})
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
        Me.empresainicialSearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("empresainicialSearchLookUpEdit.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject4, "", Nothing, Nothing, True)})
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
        'gerarSimpleButton
        '
        Me.gerarSimpleButton.Image = CType(resources.GetObject("gerarSimpleButton.Image"), System.Drawing.Image)
        Me.gerarSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.gerarSimpleButton.Location = New System.Drawing.Point(571, 266)
        Me.gerarSimpleButton.Name = "gerarSimpleButton"
        Me.gerarSimpleButton.Size = New System.Drawing.Size(62, 45)
        Me.gerarSimpleButton.TabIndex = 7
        Me.gerarSimpleButton.Text = "Gerar"
        '
        'excluirempresaobrigacaoCheckEdit
        '
        Me.excluirempresaobrigacaoCheckEdit.Location = New System.Drawing.Point(6, 266)
        Me.excluirempresaobrigacaoCheckEdit.Name = "excluirempresaobrigacaoCheckEdit"
        Me.excluirempresaobrigacaoCheckEdit.Properties.Caption = "Antes de gerar as regras, excluir a(s) obrigações das empresas?"
        Me.excluirempresaobrigacaoCheckEdit.Size = New System.Drawing.Size(334, 19)
        Me.excluirempresaobrigacaoCheckEdit.TabIndex = 6
        '
        'obrigacoesPanelControl
        '
        Me.obrigacoesPanelControl.Controls.Add(Me.descricaoTextEdit)
        Me.obrigacoesPanelControl.Controls.Add(Me.obrigacaoSearchLookUpEdit)
        Me.obrigacoesPanelControl.Location = New System.Drawing.Point(6, 222)
        Me.obrigacoesPanelControl.Name = "obrigacoesPanelControl"
        Me.obrigacoesPanelControl.Size = New System.Drawing.Size(695, 39)
        Me.obrigacoesPanelControl.TabIndex = 5
        '
        'descricaoTextEdit
        '
        Me.descricaoTextEdit.Enabled = False
        Me.descricaoTextEdit.Location = New System.Drawing.Point(111, 12)
        Me.descricaoTextEdit.Name = "descricaoTextEdit"
        Me.descricaoTextEdit.Properties.AutoHeight = False
        Me.descricaoTextEdit.Size = New System.Drawing.Size(578, 22)
        Me.descricaoTextEdit.TabIndex = 1
        '
        'obrigacaoSearchLookUpEdit
        '
        Me.obrigacaoSearchLookUpEdit.Location = New System.Drawing.Point(6, 12)
        Me.obrigacaoSearchLookUpEdit.Name = "obrigacaoSearchLookUpEdit"
        Me.obrigacaoSearchLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.obrigacaoSearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("obrigacaoSearchLookUpEdit.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, "", Nothing, Nothing, True)})
        Me.obrigacaoSearchLookUpEdit.Properties.DataSource = Me.obrigacoesInfoBindingSource
        Me.obrigacaoSearchLookUpEdit.Properties.DisplayMember = "obrigacao"
        Me.obrigacaoSearchLookUpEdit.Properties.NullText = ""
        Me.obrigacaoSearchLookUpEdit.Properties.ValueMember = "obrigacao"
        Me.obrigacaoSearchLookUpEdit.Properties.View = Me.obrigacaoGridView
        Me.obrigacaoSearchLookUpEdit.Size = New System.Drawing.Size(100, 22)
        Me.obrigacaoSearchLookUpEdit.TabIndex = 0
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
        'obrigacaoLabelControl
        '
        Me.obrigacaoLabelControl.Location = New System.Drawing.Point(12, 215)
        Me.obrigacaoLabelControl.Name = "obrigacaoLabelControl"
        Me.obrigacaoLabelControl.Size = New System.Drawing.Size(49, 13)
        Me.obrigacaoLabelControl.TabIndex = 4
        Me.obrigacaoLabelControl.Text = "Obrigação"
        '
        'regrasgeracaoXtraForm
        '
        Me.AcceptButton = Me.gerarSimpleButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.CancelButton = Me.voltarSimpleButton
        Me.ClientSize = New System.Drawing.Size(705, 314)
        Me.Controls.Add(Me.obrigacaoLabelControl)
        Me.Controls.Add(Me.excluirempresaobrigacaoCheckEdit)
        Me.Controls.Add(Me.regraLabelControl)
        Me.Controls.Add(Me.regrasPanelControl)
        Me.Controls.Add(Me.empresaLabelControl)
        Me.Controls.Add(Me.voltarSimpleButton)
        Me.Controls.Add(Me.empresasPanelControl)
        Me.Controls.Add(Me.gerarSimpleButton)
        Me.Controls.Add(Me.obrigacoesPanelControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "regrasgeracaoXtraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Geração das Regras das Empresas"
        CType(Me.regrasPanelControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.regrasPanelControl.ResumeLayout(False)
        Me.regrasPanelControl.PerformLayout()
        CType(Me.regrafinalTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.regrafinalSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.regrasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.regrafinalGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.regrainicialTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.regrainicialSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.regrainicialGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.empresasPanelControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.empresasPanelControl.ResumeLayout(False)
        Me.empresasPanelControl.PerformLayout()
        CType(Me.empresafinalTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.empresafinalSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.empresasInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.empresafinalGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.empresainicialTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.empresainicialSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.empresainicialGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.excluirempresaobrigacaoCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacoesPanelControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.obrigacoesPanelControl.ResumeLayout(False)
        CType(Me.descricaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacaoSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacoesInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacaoGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents regraLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents regrasPanelControl As DevExpress.XtraEditors.PanelControl
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
    Friend WithEvents empresaLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents voltarSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents empresasPanelControl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents empresafinalTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents empresafinalSearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents empresafinalGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents empresafinalGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents razaosocialfinalGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents empresainicialTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents empresainicialSearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents empresainicialGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents empresaincialGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents razaosocialinicialGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents empresafinalLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents empresainicialLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gerarSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents regrasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents empresasInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents excluirempresaobrigacaoCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents obrigacoesPanelControl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents obrigacaoLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents descricaoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents obrigacaoSearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents obrigacoesInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents obrigacaoGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents obrigacaoGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents descricaoGridColumn As DevExpress.XtraGrid.Columns.GridColumn
End Class
