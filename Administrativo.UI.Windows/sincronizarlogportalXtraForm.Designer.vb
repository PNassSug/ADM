Imports DevExpress.XtraEditors.Mask
Imports DevExpress.XtraEditors.Repository

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sincronizarlogportalXtraForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sincronizarlogportalXtraForm))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.obrigacaoLabelControl = New DevExpress.XtraEditors.LabelControl()
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
        Me.sincronizarSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.competenciaPanelControl = New DevExpress.XtraEditors.PanelControl()
        Me.competenciaFinalControl = New DevExpress.XtraEditors.LabelControl()
        Me.competenciafinalTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.competenciainicialTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.competenciaInicialControl = New DevExpress.XtraEditors.LabelControl()
        Me.obrigacaoinicialSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.obrigacoesInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.obrigacaoGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.obrigacaoGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.descricaoGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.descricaoinicialTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.obrigacoesPanelControl = New DevExpress.XtraEditors.PanelControl()
        Me.obrigacaoInicialLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.obrigacaoFinalLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.descricaofinalTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.obrigacaofinalSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.competenciaLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.relatorioSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.empresasPanelControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.empresasPanelControl.SuspendLayout()
        CType(Me.empresafinalTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresafinalSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresasInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresafinalGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresainicialTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresainicialSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresainicialGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.competenciaPanelControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.competenciaPanelControl.SuspendLayout()
        CType(Me.competenciafinalTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.competenciainicialTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacaoinicialSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacoesInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacaoGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.descricaoinicialTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacoesPanelControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.obrigacoesPanelControl.SuspendLayout()
        CType(Me.descricaofinalTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacaofinalSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'obrigacaoLabelControl
        '
        Me.obrigacaoLabelControl.Location = New System.Drawing.Point(133, 5)
        Me.obrigacaoLabelControl.Name = "obrigacaoLabelControl"
        Me.obrigacaoLabelControl.Size = New System.Drawing.Size(49, 13)
        Me.obrigacaoLabelControl.TabIndex = 3
        Me.obrigacaoLabelControl.Text = "Obrigação"
        '
        'empresaLabelControl
        '
        Me.empresaLabelControl.Location = New System.Drawing.Point(14, 117)
        Me.empresaLabelControl.Name = "empresaLabelControl"
        Me.empresaLabelControl.Size = New System.Drawing.Size(46, 13)
        Me.empresaLabelControl.TabIndex = 5
        Me.empresaLabelControl.Text = "Empresas"
        '
        'voltarSimpleButton
        '
        Me.voltarSimpleButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.voltarSimpleButton.Image = CType(resources.GetObject("voltarSimpleButton.Image"), System.Drawing.Image)
        Me.voltarSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.voltarSimpleButton.Location = New System.Drawing.Point(645, 227)
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
        Me.empresasPanelControl.Location = New System.Drawing.Point(8, 124)
        Me.empresasPanelControl.Name = "empresasPanelControl"
        Me.empresasPanelControl.Size = New System.Drawing.Size(699, 97)
        Me.empresasPanelControl.TabIndex = 4
        '
        'empresafinalTextEdit
        '
        Me.empresafinalTextEdit.Enabled = False
        Me.empresafinalTextEdit.Location = New System.Drawing.Point(111, 70)
        Me.empresafinalTextEdit.Name = "empresafinalTextEdit"
        Me.empresafinalTextEdit.Properties.AutoHeight = False
        Me.empresafinalTextEdit.Size = New System.Drawing.Size(582, 22)
        Me.empresafinalTextEdit.TabIndex = 5
        '
        'empresafinalSearchLookUpEdit
        '
        Me.empresafinalSearchLookUpEdit.Location = New System.Drawing.Point(6, 70)
        Me.empresafinalSearchLookUpEdit.Name = "empresafinalSearchLookUpEdit"
        Me.empresafinalSearchLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.empresafinalSearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("empresafinalSearchLookUpEdit.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
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
        Me.empresainicialTextEdit.Size = New System.Drawing.Size(582, 22)
        Me.empresainicialTextEdit.TabIndex = 2
        '
        'empresainicialSearchLookUpEdit
        '
        Me.empresainicialSearchLookUpEdit.Location = New System.Drawing.Point(6, 28)
        Me.empresainicialSearchLookUpEdit.Name = "empresainicialSearchLookUpEdit"
        Me.empresainicialSearchLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.empresainicialSearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("empresainicialSearchLookUpEdit.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
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
        'sincronizarSimpleButton
        '
        Me.sincronizarSimpleButton.Image = CType(resources.GetObject("sincronizarSimpleButton.Image"), System.Drawing.Image)
        Me.sincronizarSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.sincronizarSimpleButton.Location = New System.Drawing.Point(577, 227)
        Me.sincronizarSimpleButton.Name = "sincronizarSimpleButton"
        Me.sincronizarSimpleButton.Size = New System.Drawing.Size(62, 45)
        Me.sincronizarSimpleButton.TabIndex = 7
        Me.sincronizarSimpleButton.Text = "Sincronizar"
        '
        'competenciaPanelControl
        '
        Me.competenciaPanelControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.competenciaPanelControl.Controls.Add(Me.competenciaFinalControl)
        Me.competenciaPanelControl.Controls.Add(Me.competenciafinalTextEdit)
        Me.competenciaPanelControl.Controls.Add(Me.competenciainicialTextEdit)
        Me.competenciaPanelControl.Controls.Add(Me.competenciaInicialControl)
        Me.competenciaPanelControl.Location = New System.Drawing.Point(8, 12)
        Me.competenciaPanelControl.Name = "competenciaPanelControl"
        Me.competenciaPanelControl.Size = New System.Drawing.Size(113, 106)
        Me.competenciaPanelControl.TabIndex = 0
        '
        'competenciaFinalControl
        '
        Me.competenciaFinalControl.Location = New System.Drawing.Point(7, 59)
        Me.competenciaFinalControl.Name = "competenciaFinalControl"
        Me.competenciaFinalControl.Size = New System.Drawing.Size(22, 13)
        Me.competenciaFinalControl.TabIndex = 2
        Me.competenciaFinalControl.Text = "Final"
        '
        'competenciafinalTextEdit
        '
        Me.competenciafinalTextEdit.Location = New System.Drawing.Point(7, 77)
        Me.competenciafinalTextEdit.Name = "competenciafinalTextEdit"
        Me.competenciafinalTextEdit.Properties.AutoHeight = False
        Me.competenciafinalTextEdit.Properties.Mask.EditMask = "00/0000"
        Me.competenciafinalTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.competenciafinalTextEdit.Properties.Mask.SaveLiteral = False
        Me.competenciafinalTextEdit.Properties.Mask.ShowPlaceHolders = False
        Me.competenciafinalTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.competenciafinalTextEdit.Size = New System.Drawing.Size(100, 22)
        Me.competenciafinalTextEdit.TabIndex = 3
        '
        'competenciainicialTextEdit
        '
        Me.competenciainicialTextEdit.Location = New System.Drawing.Point(7, 31)
        Me.competenciainicialTextEdit.Name = "competenciainicialTextEdit"
        Me.competenciainicialTextEdit.Properties.AutoHeight = False
        Me.competenciainicialTextEdit.Properties.Mask.EditMask = "00/0000"
        Me.competenciainicialTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.competenciainicialTextEdit.Properties.Mask.SaveLiteral = False
        Me.competenciainicialTextEdit.Properties.Mask.ShowPlaceHolders = False
        Me.competenciainicialTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.competenciainicialTextEdit.Size = New System.Drawing.Size(100, 22)
        Me.competenciainicialTextEdit.TabIndex = 1
        '
        'competenciaInicialControl
        '
        Me.competenciaInicialControl.Location = New System.Drawing.Point(7, 13)
        Me.competenciaInicialControl.Name = "competenciaInicialControl"
        Me.competenciaInicialControl.Size = New System.Drawing.Size(27, 13)
        Me.competenciaInicialControl.TabIndex = 0
        Me.competenciaInicialControl.Text = "Inicial"
        '
        'obrigacaoinicialSearchLookUpEdit
        '
        Me.obrigacaoinicialSearchLookUpEdit.Location = New System.Drawing.Point(5, 31)
        Me.obrigacaoinicialSearchLookUpEdit.Name = "obrigacaoinicialSearchLookUpEdit"
        Me.obrigacaoinicialSearchLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.obrigacaoinicialSearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("obrigacaoinicialSearchLookUpEdit.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, Nothing, True)})
        Me.obrigacaoinicialSearchLookUpEdit.Properties.DataSource = Me.obrigacoesInfoBindingSource
        Me.obrigacaoinicialSearchLookUpEdit.Properties.DisplayMember = "obrigacao"
        Me.obrigacaoinicialSearchLookUpEdit.Properties.NullText = ""
        Me.obrigacaoinicialSearchLookUpEdit.Properties.ValueMember = "obrigacao"
        Me.obrigacaoinicialSearchLookUpEdit.Properties.View = Me.obrigacaoGridView
        Me.obrigacaoinicialSearchLookUpEdit.Size = New System.Drawing.Size(100, 22)
        Me.obrigacaoinicialSearchLookUpEdit.TabIndex = 1
        Me.obrigacaoinicialSearchLookUpEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.obrigacaoinicialSearchLookUpEdit.Properties.Mask.MaskType = MaskType.Numeric
        Me.obrigacaoinicialSearchLookUpEdit.Properties.Mask.EditMask = "0-00000"
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
        'descricaoinicialTextEdit
        '
        Me.descricaoinicialTextEdit.Enabled = False
        Me.descricaoinicialTextEdit.Location = New System.Drawing.Point(110, 31)
        Me.descricaoinicialTextEdit.Name = "descricaoinicialTextEdit"
        Me.descricaoinicialTextEdit.Properties.AutoHeight = False
        Me.descricaoinicialTextEdit.Size = New System.Drawing.Size(464, 22)
        Me.descricaoinicialTextEdit.TabIndex = 2
        '
        'obrigacoesPanelControl
        '
        Me.obrigacoesPanelControl.Controls.Add(Me.obrigacaoInicialLabelControl)
        Me.obrigacoesPanelControl.Controls.Add(Me.obrigacaoFinalLabelControl)
        Me.obrigacoesPanelControl.Controls.Add(Me.descricaofinalTextEdit)
        Me.obrigacoesPanelControl.Controls.Add(Me.obrigacaofinalSearchLookUpEdit)
        Me.obrigacoesPanelControl.Controls.Add(Me.descricaoinicialTextEdit)
        Me.obrigacoesPanelControl.Controls.Add(Me.obrigacaoinicialSearchLookUpEdit)
        Me.obrigacoesPanelControl.Location = New System.Drawing.Point(127, 12)
        Me.obrigacoesPanelControl.Name = "obrigacoesPanelControl"
        Me.obrigacoesPanelControl.Size = New System.Drawing.Size(580, 106)
        Me.obrigacoesPanelControl.TabIndex = 2
        '
        'obrigacaoInicialLabelControl
        '
        Me.obrigacaoInicialLabelControl.Location = New System.Drawing.Point(5, 13)
        Me.obrigacaoInicialLabelControl.Name = "obrigacaoInicialLabelControl"
        Me.obrigacaoInicialLabelControl.Size = New System.Drawing.Size(27, 13)
        Me.obrigacaoInicialLabelControl.TabIndex = 0
        Me.obrigacaoInicialLabelControl.Text = "Inicial"
        '
        'obrigacaoFinalLabelControl
        '
        Me.obrigacaoFinalLabelControl.Location = New System.Drawing.Point(5, 59)
        Me.obrigacaoFinalLabelControl.Name = "obrigacaoFinalLabelControl"
        Me.obrigacaoFinalLabelControl.Size = New System.Drawing.Size(22, 13)
        Me.obrigacaoFinalLabelControl.TabIndex = 3
        Me.obrigacaoFinalLabelControl.Text = "Final"
        '
        'descricaofinalTextEdit
        '
        Me.descricaofinalTextEdit.Enabled = False
        Me.descricaofinalTextEdit.Location = New System.Drawing.Point(110, 77)
        Me.descricaofinalTextEdit.Name = "descricaofinalTextEdit"
        Me.descricaofinalTextEdit.Properties.AutoHeight = False
        Me.descricaofinalTextEdit.Size = New System.Drawing.Size(464, 22)
        Me.descricaofinalTextEdit.TabIndex = 5
        '
        'obrigacaofinalSearchLookUpEdit
        '
        Me.obrigacaofinalSearchLookUpEdit.Location = New System.Drawing.Point(5, 77)
        Me.obrigacaofinalSearchLookUpEdit.Name = "obrigacaofinalSearchLookUpEdit"
        Me.obrigacaofinalSearchLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.obrigacaofinalSearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("obrigacaofinalSearchLookUpEdit.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject4, "", Nothing, Nothing, True)})
        Me.obrigacaofinalSearchLookUpEdit.Properties.DataSource = Me.obrigacoesInfoBindingSource
        Me.obrigacaofinalSearchLookUpEdit.Properties.DisplayMember = "obrigacao"
        Me.obrigacaofinalSearchLookUpEdit.Properties.NullText = ""
        Me.obrigacaofinalSearchLookUpEdit.Properties.ValueMember = "obrigacao"
        Me.obrigacaofinalSearchLookUpEdit.Properties.View = Me.GridView1
        Me.obrigacaofinalSearchLookUpEdit.Size = New System.Drawing.Size(100, 22)
        Me.obrigacaofinalSearchLookUpEdit.TabIndex = 4
        Me.obrigacaofinalSearchLookUpEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.obrigacaofinalSearchLookUpEdit.Properties.Mask.MaskType = MaskType.Numeric
        Me.obrigacaofinalSearchLookUpEdit.Properties.Mask.EditMask = "0-00000"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsFind.SearchInPreview = True
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.Columns(0).ColumnEdit = obrigacaoEdit
        obrigacaoEdit.Mask.MaskType = MaskType.Simple
        obrigacaoEdit.Mask.UseMaskAsDisplayFormat = True
        obrigacaoEdit.Mask.EditMask = "0-00000"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Obrigação"
        Me.GridColumn1.FieldName = "obrigacao"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 80
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Descrição"
        Me.GridColumn2.FieldName = "descricao"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 200
        '
        'competenciaLabelControl
        '
        Me.competenciaLabelControl.Location = New System.Drawing.Point(15, 5)
        Me.competenciaLabelControl.Name = "competenciaLabelControl"
        Me.competenciaLabelControl.Size = New System.Drawing.Size(62, 13)
        Me.competenciaLabelControl.TabIndex = 1
        Me.competenciaLabelControl.Text = "Competência"
        '
        'relatorioSimpleButton
        '
        Me.relatorioSimpleButton.Image = CType(resources.GetObject("relatorioSimpleButton.Image"), System.Drawing.Image)
        Me.relatorioSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.relatorioSimpleButton.Location = New System.Drawing.Point(509, 227)
        Me.relatorioSimpleButton.Name = "relatorioSimpleButton"
        Me.relatorioSimpleButton.Size = New System.Drawing.Size(62, 45)
        Me.relatorioSimpleButton.TabIndex = 6
        Me.relatorioSimpleButton.Text = "Relatório"
        '
        'sincronizarlogportalXtraForm
        '
        Me.AcceptButton = Me.sincronizarSimpleButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.voltarSimpleButton
        Me.ClientSize = New System.Drawing.Size(712, 277)
        Me.Controls.Add(Me.relatorioSimpleButton)
        Me.Controls.Add(Me.competenciaLabelControl)
        Me.Controls.Add(Me.competenciaPanelControl)
        Me.Controls.Add(Me.obrigacaoLabelControl)
        Me.Controls.Add(Me.empresaLabelControl)
        Me.Controls.Add(Me.voltarSimpleButton)
        Me.Controls.Add(Me.empresasPanelControl)
        Me.Controls.Add(Me.sincronizarSimpleButton)
        Me.Controls.Add(Me.obrigacoesPanelControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sincronizarlogportalXtraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sincronizar o monitoramento das obrigações enviadas pelo portal"
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
        CType(Me.competenciaPanelControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.competenciaPanelControl.ResumeLayout(False)
        Me.competenciaPanelControl.PerformLayout()
        CType(Me.competenciafinalTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.competenciainicialTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacaoinicialSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacoesInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacaoGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.descricaoinicialTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacoesPanelControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.obrigacoesPanelControl.ResumeLayout(False)
        Me.obrigacoesPanelControl.PerformLayout()
        CType(Me.descricaofinalTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacaofinalSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents obrigacaoLabelControl As DevExpress.XtraEditors.LabelControl
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
    Friend WithEvents sincronizarSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents competenciaPanelControl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents competenciaInicialControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents obrigacaoinicialSearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents obrigacaoGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents obrigacaoGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents descricaoGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents descricaoinicialTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents obrigacoesPanelControl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents competenciaLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents obrigacoesInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents competenciaFinalControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents obrigacaoInicialLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents obrigacaoFinalLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents descricaofinalTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents obrigacaofinalSearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents empresasInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents competenciafinalTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents competenciainicialTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents relatorioSimpleButton As DevExpress.XtraEditors.SimpleButton
End Class
