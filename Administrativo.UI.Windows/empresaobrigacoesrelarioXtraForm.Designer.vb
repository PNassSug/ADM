Imports DevExpress.XtraEditors.Mask
Imports DevExpress.XtraEditors.Repository

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class empresaobrigacoesrelarioXtraForm
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
    Private components As System.ComponentModel.IContainer
    Dim edit As New RepositoryItemTextEdit
    Dim obrigacaoEdit As New RepositoryItemTextEdit

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(empresaobrigacoesrelarioXtraForm))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.obrigacaoLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.voltarSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.imprimirSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.obrigacaoPanelControl = New DevExpress.XtraEditors.PanelControl()
        Me.obrigacaofinalTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.obrigacaofinalSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.obrigacoesInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.obrigacaofinalGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.obrigacaoinicialTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.obrigacaoinicialSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.obrigacaoinicialGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.obrigacaofinalLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.obrigacaoinicialLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.empresasInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.empresaLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.empresaPanelControl = New DevExpress.XtraEditors.PanelControl()
        Me.empresafinalTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.empresafinalSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.empresafinalGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.empresainicialTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.empresainicialSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.empresainicialGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.empresafinalLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.empresainicialLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.tipolucroPanelControl = New DevExpress.XtraEditors.PanelControl()
        Me.tipolucrodescTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.tipolucroSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.tipolucroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tipolucroGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.tipoempresaPanelControl = New DevExpress.XtraEditors.PanelControl()
        Me.tipoempresadescTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.tipoempresaSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.tipoempresaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tipoempresaGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.tipolucroLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.tipoempresaLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.tiporelatorioLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.tiporelatorioPanelControl = New DevExpress.XtraEditors.PanelControl()
        Me.tiporelatorioComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.tipoempresaGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tipoempresadescGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tipolucroGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tipolucrodescGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.empresafinalGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.razaosocialfinalGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.empresaincialGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.razaosocialinicialGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.obrigacaofinalGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.descricaofinalGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.obrigacaoinicialGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.descricaoinicialGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.obrigacaoPanelControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.obrigacaoPanelControl.SuspendLayout()
        CType(Me.obrigacaofinalTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacaofinalSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacoesInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacaofinalGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacaoinicialTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacaoinicialSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacaoinicialGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresasInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresaPanelControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.empresaPanelControl.SuspendLayout()
        CType(Me.empresafinalTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresafinalSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresafinalGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresainicialTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresainicialSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresainicialGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tipolucroPanelControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tipolucroPanelControl.SuspendLayout()
        CType(Me.tipolucrodescTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tipolucroSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tipolucroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tipolucroGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tipoempresaPanelControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tipoempresaPanelControl.SuspendLayout()
        CType(Me.tipoempresadescTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tipoempresaSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tipoempresaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tipoempresaGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tiporelatorioPanelControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tiporelatorioPanelControl.SuspendLayout()
        CType(Me.tiporelatorioComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'obrigacaoLabelControl
        '
        Me.obrigacaoLabelControl.Location = New System.Drawing.Point(12, 107)
        Me.obrigacaoLabelControl.Name = "obrigacaoLabelControl"
        Me.obrigacaoLabelControl.Size = New System.Drawing.Size(54, 13)
        Me.obrigacaoLabelControl.TabIndex = 2
        Me.obrigacaoLabelControl.Text = "Obrigações"
        '
        'voltarSimpleButton
        '
        Me.voltarSimpleButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.voltarSimpleButton.Image = CType(resources.GetObject("voltarSimpleButton.Image"), System.Drawing.Image)
        Me.voltarSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.voltarSimpleButton.Location = New System.Drawing.Point(639, 278)
        Me.voltarSimpleButton.Name = "voltarSimpleButton"
        Me.voltarSimpleButton.Size = New System.Drawing.Size(62, 45)
        Me.voltarSimpleButton.TabIndex = 11
        Me.voltarSimpleButton.Text = "Voltar"
        '
        'imprimirSimpleButton
        '
        Me.imprimirSimpleButton.Image = CType(resources.GetObject("imprimirSimpleButton.Image"), System.Drawing.Image)
        Me.imprimirSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.imprimirSimpleButton.Location = New System.Drawing.Point(571, 278)
        Me.imprimirSimpleButton.Name = "imprimirSimpleButton"
        Me.imprimirSimpleButton.Size = New System.Drawing.Size(62, 45)
        Me.imprimirSimpleButton.TabIndex = 10
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
        Me.obrigacaoPanelControl.Location = New System.Drawing.Point(6, 113)
        Me.obrigacaoPanelControl.Name = "obrigacaoPanelControl"
        Me.obrigacaoPanelControl.Size = New System.Drawing.Size(695, 97)
        Me.obrigacaoPanelControl.TabIndex = 3
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
        Me.obrigacaofinalSearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("obrigacaofinalSearchLookUpEdit.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
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
        Me.obrigacaofinalGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.obrigacaofinalGridColumn, Me.descricaofinalGridColumn})
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
        Me.obrigacaoinicialSearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("obrigacaoinicialSearchLookUpEdit.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.obrigacaoinicialSearchLookUpEdit.Properties.DataSource = Me.obrigacoesInfoBindingSource
        Me.obrigacaoinicialSearchLookUpEdit.Properties.DisplayMember = "obrigacao"
        Me.obrigacaoinicialSearchLookUpEdit.Properties.NullText = ""
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
        Me.obrigacaoinicialGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.obrigacaoinicialGridColumn, Me.descricaoinicialGridColumn})
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
        'empresaLabelControl
        '
        Me.empresaLabelControl.Location = New System.Drawing.Point(12, 1)
        Me.empresaLabelControl.Name = "empresaLabelControl"
        Me.empresaLabelControl.Size = New System.Drawing.Size(46, 13)
        Me.empresaLabelControl.TabIndex = 0
        Me.empresaLabelControl.Text = "Empresas"
        '
        'empresaPanelControl
        '
        Me.empresaPanelControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.empresaPanelControl.Controls.Add(Me.empresafinalTextEdit)
        Me.empresaPanelControl.Controls.Add(Me.empresafinalSearchLookUpEdit)
        Me.empresaPanelControl.Controls.Add(Me.empresainicialTextEdit)
        Me.empresaPanelControl.Controls.Add(Me.empresainicialSearchLookUpEdit)
        Me.empresaPanelControl.Controls.Add(Me.empresafinalLabelControl)
        Me.empresaPanelControl.Controls.Add(Me.empresainicialLabelControl)
        Me.empresaPanelControl.Location = New System.Drawing.Point(6, 7)
        Me.empresaPanelControl.Name = "empresaPanelControl"
        Me.empresaPanelControl.Size = New System.Drawing.Size(695, 97)
        Me.empresaPanelControl.TabIndex = 1
        '
        'empresafinalTextEdit
        '
        Me.empresafinalTextEdit.Enabled = False
        Me.empresafinalTextEdit.Location = New System.Drawing.Point(111, 70)
        Me.empresafinalTextEdit.Name = "empresafinalTextEdit"
        Me.empresafinalTextEdit.Properties.AutoHeight = True
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
        Me.empresainicialSearchLookUpEdit.Properties.Mask.MaskType = MaskType.Simple
        Me.empresainicialSearchLookUpEdit.Properties.Mask.UseMaskAsDisplayFormat = True
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
        'tipolucroPanelControl
        '
        Me.tipolucroPanelControl.Controls.Add(Me.tipolucrodescTextEdit)
        Me.tipolucroPanelControl.Controls.Add(Me.tipolucroSearchLookUpEdit)
        Me.tipolucroPanelControl.Location = New System.Drawing.Point(197, 221)
        Me.tipolucroPanelControl.Name = "tipolucroPanelControl"
        Me.tipolucroPanelControl.Size = New System.Drawing.Size(249, 40)
        Me.tipolucroPanelControl.TabIndex = 7
        '
        'tipolucrodescTextEdit
        '
        Me.tipolucrodescTextEdit.Enabled = False
        Me.tipolucrodescTextEdit.Location = New System.Drawing.Point(65, 12)
        Me.tipolucrodescTextEdit.Name = "tipolucrodescTextEdit"
        Me.tipolucrodescTextEdit.Properties.AutoHeight = False
        Me.tipolucrodescTextEdit.Size = New System.Drawing.Size(178, 22)
        Me.tipolucrodescTextEdit.TabIndex = 1
        '
        'tipolucroSearchLookUpEdit
        '
        Me.tipolucroSearchLookUpEdit.Location = New System.Drawing.Point(6, 12)
        Me.tipolucroSearchLookUpEdit.Name = "tipolucroSearchLookUpEdit"
        Me.tipolucroSearchLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.tipolucroSearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("tipolucroSearchLookUpEdit.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, "", Nothing, Nothing, True)})
        Me.tipolucroSearchLookUpEdit.Properties.DataSource = Me.tipolucroBindingSource
        Me.tipolucroSearchLookUpEdit.Properties.DisplayMember = "tipolucro"
        Me.tipolucroSearchLookUpEdit.Properties.NullText = ""
        Me.tipolucroSearchLookUpEdit.Properties.ValueMember = "tipolucro"
        Me.tipolucroSearchLookUpEdit.Properties.View = Me.tipolucroGridView
        Me.tipolucroSearchLookUpEdit.Size = New System.Drawing.Size(54, 22)
        Me.tipolucroSearchLookUpEdit.TabIndex = 0
        '
        'tipolucroGridView
        '
        Me.tipolucroGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.tipolucroGridColumn, Me.tipolucrodescGridColumn})
        Me.tipolucroGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.tipolucroGridView.Name = "tipolucroGridView"
        Me.tipolucroGridView.OptionsFind.AlwaysVisible = True
        Me.tipolucroGridView.OptionsFind.SearchInPreview = True
        Me.tipolucroGridView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.tipolucroGridView.OptionsView.ShowGroupPanel = False
        '
        'tipoempresaPanelControl
        '
        Me.tipoempresaPanelControl.Controls.Add(Me.tipoempresadescTextEdit)
        Me.tipoempresaPanelControl.Controls.Add(Me.tipoempresaSearchLookUpEdit)
        Me.tipoempresaPanelControl.Location = New System.Drawing.Point(451, 221)
        Me.tipoempresaPanelControl.Name = "tipoempresaPanelControl"
        Me.tipoempresaPanelControl.Size = New System.Drawing.Size(250, 40)
        Me.tipoempresaPanelControl.TabIndex = 9
        '
        'tipoempresadescTextEdit
        '
        Me.tipoempresadescTextEdit.Enabled = False
        Me.tipoempresadescTextEdit.Location = New System.Drawing.Point(65, 12)
        Me.tipoempresadescTextEdit.Name = "tipoempresadescTextEdit"
        Me.tipoempresadescTextEdit.Properties.AutoHeight = False
        Me.tipoempresadescTextEdit.Size = New System.Drawing.Size(179, 22)
        Me.tipoempresadescTextEdit.TabIndex = 1
        '
        'tipoempresaSearchLookUpEdit
        '
        Me.tipoempresaSearchLookUpEdit.Location = New System.Drawing.Point(7, 12)
        Me.tipoempresaSearchLookUpEdit.Name = "tipoempresaSearchLookUpEdit"
        Me.tipoempresaSearchLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.tipoempresaSearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("tipoempresaSearchLookUpEdit.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject6, "", Nothing, Nothing, True)})
        Me.tipoempresaSearchLookUpEdit.Properties.DataSource = Me.tipoempresaBindingSource
        Me.tipoempresaSearchLookUpEdit.Properties.DisplayMember = "tipoempresa"
        Me.tipoempresaSearchLookUpEdit.Properties.NullText = ""
        Me.tipoempresaSearchLookUpEdit.Properties.ValueMember = "tipoempresa"
        Me.tipoempresaSearchLookUpEdit.Properties.View = Me.tipoempresaGridView
        Me.tipoempresaSearchLookUpEdit.Size = New System.Drawing.Size(52, 22)
        Me.tipoempresaSearchLookUpEdit.TabIndex = 0
        '
        'tipoempresaGridView
        '
        Me.tipoempresaGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.tipoempresaGridColumn, Me.tipoempresadescGridColumn})
        Me.tipoempresaGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.tipoempresaGridView.Name = "tipoempresaGridView"
        Me.tipoempresaGridView.OptionsFind.AlwaysVisible = True
        Me.tipoempresaGridView.OptionsFind.SearchInPreview = True
        Me.tipoempresaGridView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.tipoempresaGridView.OptionsView.ShowGroupPanel = False
        '
        'tipolucroLabelControl
        '
        Me.tipolucroLabelControl.Location = New System.Drawing.Point(202, 215)
        Me.tipolucroLabelControl.Name = "tipolucroLabelControl"
        Me.tipolucroLabelControl.Size = New System.Drawing.Size(64, 13)
        Me.tipolucroLabelControl.TabIndex = 6
        Me.tipolucroLabelControl.Text = "Tipo de Lucro"
        '
        'tipoempresaLabelControl
        '
        Me.tipoempresaLabelControl.Location = New System.Drawing.Point(459, 214)
        Me.tipoempresaLabelControl.Name = "tipoempresaLabelControl"
        Me.tipoempresaLabelControl.Size = New System.Drawing.Size(79, 13)
        Me.tipoempresaLabelControl.TabIndex = 8
        Me.tipoempresaLabelControl.Text = "Tipo de Empresa"
        '
        'tiporelatorioLabelControl
        '
        Me.tiporelatorioLabelControl.Location = New System.Drawing.Point(11, 214)
        Me.tiporelatorioLabelControl.Name = "tiporelatorioLabelControl"
        Me.tiporelatorioLabelControl.Size = New System.Drawing.Size(81, 13)
        Me.tiporelatorioLabelControl.TabIndex = 4
        Me.tiporelatorioLabelControl.Text = "Tipo de Relatório"
        '
        'tiporelatorioPanelControl
        '
        Me.tiporelatorioPanelControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tiporelatorioPanelControl.Controls.Add(Me.tiporelatorioComboBoxEdit)
        Me.tiporelatorioPanelControl.Location = New System.Drawing.Point(6, 221)
        Me.tiporelatorioPanelControl.Name = "tiporelatorioPanelControl"
        Me.tiporelatorioPanelControl.Size = New System.Drawing.Size(185, 40)
        Me.tiporelatorioPanelControl.TabIndex = 5
        '
        'tiporelatorioComboBoxEdit
        '
        Me.tiporelatorioComboBoxEdit.EditValue = "Empresas e suas obrigações"
        Me.tiporelatorioComboBoxEdit.Location = New System.Drawing.Point(5, 14)
        Me.tiporelatorioComboBoxEdit.Name = "tiporelatorioComboBoxEdit"
        Me.tiporelatorioComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tiporelatorioComboBoxEdit.Properties.Items.AddRange(New Object() {"Empresas e suas obrigações", "Obrigações e suas empresas"})
        Me.tiporelatorioComboBoxEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.tiporelatorioComboBoxEdit.Size = New System.Drawing.Size(175, 20)
        Me.tiporelatorioComboBoxEdit.TabIndex = 0
        '
        'tipoempresaGridColumn
        '
        Me.tipoempresaGridColumn.Caption = "Tipo Empresa"
        Me.tipoempresaGridColumn.FieldName = "tipoempresa"
        Me.tipoempresaGridColumn.Name = "tipoempresaGridColumn"
        Me.tipoempresaGridColumn.Visible = True
        Me.tipoempresaGridColumn.VisibleIndex = 0
        Me.tipoempresaGridColumn.Width = 80
        '
        'tipoempresadescGridColumn
        '
        Me.tipoempresadescGridColumn.Caption = "Descrição"
        Me.tipoempresadescGridColumn.FieldName = "descricao"
        Me.tipoempresadescGridColumn.Name = "tipoempresadescGridColumn"
        Me.tipoempresadescGridColumn.Visible = True
        Me.tipoempresadescGridColumn.VisibleIndex = 1
        Me.tipoempresadescGridColumn.Width = 200
        '
        'tipolucroGridColumn
        '
        Me.tipolucroGridColumn.Caption = "Tipo Lucro"
        Me.tipolucroGridColumn.FieldName = "tipolucro"
        Me.tipolucroGridColumn.Name = "tipolucroGridColumn"
        Me.tipolucroGridColumn.Visible = True
        Me.tipolucroGridColumn.VisibleIndex = 0
        Me.tipolucroGridColumn.Width = 80
        '
        'tipolucrodescGridColumn
        '
        Me.tipolucrodescGridColumn.Caption = "Descrição"
        Me.tipolucrodescGridColumn.FieldName = "descricao"
        Me.tipolucrodescGridColumn.Name = "tipolucrodescGridColumn"
        Me.tipolucrodescGridColumn.Visible = True
        Me.tipolucrodescGridColumn.VisibleIndex = 1
        Me.tipolucrodescGridColumn.Width = 200
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
        'obrigacaofinalGridColumn
        '
        Me.obrigacaofinalGridColumn.Caption = "Obrigação"
        Me.obrigacaofinalGridColumn.FieldName = "obrigacao"
        Me.obrigacaofinalGridColumn.Name = "obrigacaofinalGridColumn"
        Me.obrigacaofinalGridColumn.Visible = True
        Me.obrigacaofinalGridColumn.VisibleIndex = 0
        Me.obrigacaofinalGridColumn.Width = 80
        '
        'descricaofinalGridColumn
        '
        Me.descricaofinalGridColumn.Caption = "Descrição"
        Me.descricaofinalGridColumn.FieldName = "descricao"
        Me.descricaofinalGridColumn.Name = "descricaofinalGridColumn"
        Me.descricaofinalGridColumn.Visible = True
        Me.descricaofinalGridColumn.VisibleIndex = 1
        Me.descricaofinalGridColumn.Width = 200
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
        'descricaoinicialGridColumn
        '
        Me.descricaoinicialGridColumn.Caption = "Descrição"
        Me.descricaoinicialGridColumn.FieldName = "descricao"
        Me.descricaoinicialGridColumn.Name = "descricaoinicialGridColumn"
        Me.descricaoinicialGridColumn.Visible = True
        Me.descricaoinicialGridColumn.VisibleIndex = 1
        Me.descricaoinicialGridColumn.Width = 200
        '
        'empresaobrigacoesrelarioXtraForm
        '
        Me.AcceptButton = Me.imprimirSimpleButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.CancelButton = Me.voltarSimpleButton
        Me.ClientSize = New System.Drawing.Size(706, 327)
        Me.Controls.Add(Me.tiporelatorioLabelControl)
        Me.Controls.Add(Me.tiporelatorioPanelControl)
        Me.Controls.Add(Me.tipoempresaLabelControl)
        Me.Controls.Add(Me.tipolucroLabelControl)
        Me.Controls.Add(Me.tipoempresaPanelControl)
        Me.Controls.Add(Me.tipolucroPanelControl)
        Me.Controls.Add(Me.empresaLabelControl)
        Me.Controls.Add(Me.empresaPanelControl)
        Me.Controls.Add(Me.obrigacaoLabelControl)
        Me.Controls.Add(Me.voltarSimpleButton)
        Me.Controls.Add(Me.imprimirSimpleButton)
        Me.Controls.Add(Me.obrigacaoPanelControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "empresaobrigacoesrelarioXtraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Obrigações das Empresas"
        CType(Me.obrigacaoPanelControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.obrigacaoPanelControl.ResumeLayout(False)
        Me.obrigacaoPanelControl.PerformLayout()
        CType(Me.obrigacaofinalTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacaofinalSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacoesInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacaofinalGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacaoinicialTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacaoinicialSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacaoinicialGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.empresasInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.empresaPanelControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.empresaPanelControl.ResumeLayout(False)
        Me.empresaPanelControl.PerformLayout()
        CType(Me.empresafinalTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.empresafinalSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.empresafinalGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.empresainicialTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.empresainicialSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.empresainicialGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tipolucroPanelControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tipolucroPanelControl.ResumeLayout(False)
        CType(Me.tipolucrodescTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tipolucroSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tipolucroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tipolucroGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tipoempresaPanelControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tipoempresaPanelControl.ResumeLayout(False)
        CType(Me.tipoempresadescTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tipoempresaSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tipoempresaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tipoempresaGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tiporelatorioPanelControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tiporelatorioPanelControl.ResumeLayout(False)
        CType(Me.tiporelatorioComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents obrigacaoLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents voltarSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents imprimirSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents obrigacaoPanelControl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents obrigacaofinalTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents obrigacaofinalSearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents obrigacaofinalGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents obrigacaofinalGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents descricaofinalGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents obrigacaoinicialTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents obrigacaoinicialSearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents obrigacaoinicialGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents obrigacaoinicialGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents descricaoinicialGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents obrigacaofinalLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents obrigacaoinicialLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents empresasInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents obrigacoesInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents empresaLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents empresaPanelControl As DevExpress.XtraEditors.PanelControl
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
    Friend WithEvents tipolucroPanelControl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents tipolucrodescTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tipolucroSearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents tipolucroGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tipolucroGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tipolucrodescGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tipoempresaPanelControl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents tipoempresadescTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tipoempresaSearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents tipoempresaGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tipoempresaGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tipoempresadescGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tipolucroLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tipoempresaLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tipolucroBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents tipoempresaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents tiporelatorioLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tiporelatorioPanelControl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents tiporelatorioComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
End Class

