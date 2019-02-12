Imports DevExpress.XtraEditors.Mask
Imports DevExpress.XtraEditors.Repository

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class obrigacoesrelatorioXtraForm
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
    Dim edit As New RepositoryItemTextEdit
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(obrigacoesrelatorioXtraForm))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.obrigacaoPanelControl = New DevExpress.XtraEditors.PanelControl()
        Me.obrigacaofinalTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.obrigacaofinalSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.obrigacoesInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.obrigacaofinalGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.obrigacaofinal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.descricaofinal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.obrigacaoinicialTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.obrigacaoinicialSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.obrigacaoinicialGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.obrigacaoinicial = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.descricaoinicial = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.obrigacaofinalLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.obrigacaoinicialLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.voltarSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.imprimirSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.periodicidadePanelControl = New DevExpress.XtraEditors.PanelControl()
        Me.periodicidadeComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.tributoPanelControl = New DevExpress.XtraEditors.PanelControl()
        Me.tributoComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.obrigacaoLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.tributoLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.periodicidadeLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.sistemaPanelControl = New DevExpress.XtraEditors.PanelControl()
        Me.sistemaComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.sistemaLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.tiporelatorioPanelControl = New DevExpress.XtraEditors.PanelControl()
        Me.tiporelatorioComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.tiporelatorioLabelControl = New DevExpress.XtraEditors.LabelControl()
        CType(Me.obrigacaoPanelControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.obrigacaoPanelControl.SuspendLayout()
        CType(Me.obrigacaofinalTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacaofinalSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacoesInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacaofinalGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacaoinicialTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacaoinicialSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacaoinicialGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.periodicidadePanelControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.periodicidadePanelControl.SuspendLayout()
        CType(Me.periodicidadeComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tributoPanelControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tributoPanelControl.SuspendLayout()
        CType(Me.tributoComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sistemaPanelControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sistemaPanelControl.SuspendLayout()
        CType(Me.sistemaComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tiporelatorioPanelControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tiporelatorioPanelControl.SuspendLayout()
        CType(Me.tiporelatorioComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.obrigacaoPanelControl.Location = New System.Drawing.Point(6, 7)
        Me.obrigacaoPanelControl.Name = "obrigacaoPanelControl"
        Me.obrigacaoPanelControl.Size = New System.Drawing.Size(695, 97)
        Me.obrigacaoPanelControl.TabIndex = 1
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
        Me.obrigacaofinalSearchLookUpEdit.Properties.Mask.MaskType = MaskType.Simple
        Me.obrigacaofinalSearchLookUpEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.obrigacaofinalSearchLookUpEdit.Properties.Mask.EditMask = "0-00000"
        '
        'obrigacaofinalGridView
        '
        Me.obrigacaofinalGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.obrigacaofinal, Me.descricaofinal})
        Me.obrigacaofinalGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.obrigacaofinalGridView.Name = "obrigacaofinalGridView"
        Me.obrigacaofinalGridView.OptionsFind.AlwaysVisible = True
        Me.obrigacaofinalGridView.OptionsFind.SearchInPreview = True
        Me.obrigacaofinalGridView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.obrigacaofinalGridView.OptionsView.ShowGroupPanel = False
        Me.obrigacaofinalGridView.Columns(0).ColumnEdit = edit
        edit.Mask.MaskType = MaskType.Simple
        edit.Mask.UseMaskAsDisplayFormat = True
        edit.Mask.EditMask = "0-00000"
        '
        'obrigacaofinal
        '
        Me.obrigacaofinal.Caption = "Obrigação"
        Me.obrigacaofinal.FieldName = "obrigacao"
        Me.obrigacaofinal.Name = "obrigacaofinal"
        Me.obrigacaofinal.Visible = True
        Me.obrigacaofinal.VisibleIndex = 0
        Me.obrigacaofinal.Width = 80
        '
        'descricaofinal
        '
        Me.descricaofinal.Caption = "Descrição"
        Me.descricaofinal.FieldName = "descricao"
        Me.descricaofinal.Name = "descricaofinal"
        Me.descricaofinal.Visible = True
        Me.descricaofinal.VisibleIndex = 1
        Me.descricaofinal.Width = 200
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
        Me.obrigacaoinicialSearchLookUpEdit.Properties.Mask.MaskType = MaskType.Simple
        Me.obrigacaoinicialSearchLookUpEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.obrigacaoinicialSearchLookUpEdit.Properties.Mask.EditMask = "0-00000"
        '
        'obrigacaoinicialGridView
        '
        Me.obrigacaoinicialGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.obrigacaoinicial, Me.descricaoinicial})
        Me.obrigacaoinicialGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.obrigacaoinicialGridView.Name = "obrigacaoinicialGridView"
        Me.obrigacaoinicialGridView.OptionsFind.AlwaysVisible = True
        Me.obrigacaoinicialGridView.OptionsFind.SearchInPreview = True
        Me.obrigacaoinicialGridView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.obrigacaoinicialGridView.OptionsView.ShowGroupPanel = False
        Me.obrigacaoinicialGridView.Columns(0).ColumnEdit = edit
        edit.Mask.MaskType = MaskType.Simple
        edit.Mask.UseMaskAsDisplayFormat = True
        edit.Mask.EditMask = "0-00000"
        '
        'obrigacaoinicial
        '
        Me.obrigacaoinicial.Caption = "Obrigação"
        Me.obrigacaoinicial.FieldName = "obrigacao"
        Me.obrigacaoinicial.Name = "obrigacaoinicial"
        Me.obrigacaoinicial.Visible = True
        Me.obrigacaoinicial.VisibleIndex = 0
        Me.obrigacaoinicial.Width = 80
        '
        'descricaoinicial
        '
        Me.descricaoinicial.Caption = "Descrição"
        Me.descricaoinicial.FieldName = "descricao"
        Me.descricaoinicial.Name = "descricaoinicial"
        Me.descricaoinicial.Visible = True
        Me.descricaoinicial.VisibleIndex = 1
        Me.descricaoinicial.Width = 200
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
        'voltarSimpleButton
        '
        Me.voltarSimpleButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.voltarSimpleButton.Image = CType(resources.GetObject("voltarSimpleButton.Image"), System.Drawing.Image)
        Me.voltarSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.voltarSimpleButton.Location = New System.Drawing.Point(638, 156)
        Me.voltarSimpleButton.Name = "voltarSimpleButton"
        Me.voltarSimpleButton.Size = New System.Drawing.Size(62, 45)
        Me.voltarSimpleButton.TabIndex = 11
        Me.voltarSimpleButton.Text = "Voltar"
        '
        'imprimirSimpleButton
        '
        Me.imprimirSimpleButton.Image = CType(resources.GetObject("imprimirSimpleButton.Image"), System.Drawing.Image)
        Me.imprimirSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.imprimirSimpleButton.Location = New System.Drawing.Point(570, 156)
        Me.imprimirSimpleButton.Name = "imprimirSimpleButton"
        Me.imprimirSimpleButton.Size = New System.Drawing.Size(62, 45)
        Me.imprimirSimpleButton.TabIndex = 10
        Me.imprimirSimpleButton.Text = "Imprimir"
        '
        'periodicidadePanelControl
        '
        Me.periodicidadePanelControl.Controls.Add(Me.periodicidadeComboBoxEdit)
        Me.periodicidadePanelControl.Location = New System.Drawing.Point(138, 113)
        Me.periodicidadePanelControl.Name = "periodicidadePanelControl"
        Me.periodicidadePanelControl.Size = New System.Drawing.Size(120, 37)
        Me.periodicidadePanelControl.TabIndex = 5
        '
        'periodicidadeComboBoxEdit
        '
        Me.periodicidadeComboBoxEdit.Location = New System.Drawing.Point(5, 12)
        Me.periodicidadeComboBoxEdit.Name = "periodicidadeComboBoxEdit"
        Me.periodicidadeComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.periodicidadeComboBoxEdit.Properties.Items.AddRange(New Object() {"Diária", "Decendial", "Quinzenal", "Mensal", "Trimestral", "Semestral", "Anual"})
        Me.periodicidadeComboBoxEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.periodicidadeComboBoxEdit.Size = New System.Drawing.Size(110, 20)
        Me.periodicidadeComboBoxEdit.TabIndex = 0
        '
        'tributoPanelControl
        '
        Me.tributoPanelControl.Controls.Add(Me.tributoComboBoxEdit)
        Me.tributoPanelControl.Location = New System.Drawing.Point(264, 113)
        Me.tributoPanelControl.Name = "tributoPanelControl"
        Me.tributoPanelControl.Size = New System.Drawing.Size(127, 37)
        Me.tributoPanelControl.TabIndex = 7
        '
        'tributoComboBoxEdit
        '
        Me.tributoComboBoxEdit.Location = New System.Drawing.Point(6, 12)
        Me.tributoComboBoxEdit.Name = "tributoComboBoxEdit"
        Me.tributoComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tributoComboBoxEdit.Properties.Items.AddRange(New Object() {"Municipal", "Estadual", "Federal", "Trabalhista", "Previdenciária"})
        Me.tributoComboBoxEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.tributoComboBoxEdit.Size = New System.Drawing.Size(115, 20)
        Me.tributoComboBoxEdit.TabIndex = 0
        '
        'obrigacaoLabelControl
        '
        Me.obrigacaoLabelControl.Location = New System.Drawing.Point(12, 1)
        Me.obrigacaoLabelControl.Name = "obrigacaoLabelControl"
        Me.obrigacaoLabelControl.Size = New System.Drawing.Size(54, 13)
        Me.obrigacaoLabelControl.TabIndex = 0
        Me.obrigacaoLabelControl.Text = "Obrigações"
        '
        'tributoLabelControl
        '
        Me.tributoLabelControl.Location = New System.Drawing.Point(271, 106)
        Me.tributoLabelControl.Name = "tributoLabelControl"
        Me.tributoLabelControl.Size = New System.Drawing.Size(34, 13)
        Me.tributoLabelControl.TabIndex = 6
        Me.tributoLabelControl.Text = "Tributo"
        '
        'periodicidadeLabelControl
        '
        Me.periodicidadeLabelControl.Location = New System.Drawing.Point(144, 106)
        Me.periodicidadeLabelControl.Name = "periodicidadeLabelControl"
        Me.periodicidadeLabelControl.Size = New System.Drawing.Size(63, 13)
        Me.periodicidadeLabelControl.TabIndex = 4
        Me.periodicidadeLabelControl.Text = "Periodicidade"
        '
        'sistemaPanelControl
        '
        Me.sistemaPanelControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.sistemaPanelControl.Controls.Add(Me.sistemaComboBoxEdit)
        Me.sistemaPanelControl.Location = New System.Drawing.Point(397, 113)
        Me.sistemaPanelControl.Name = "sistemaPanelControl"
        Me.sistemaPanelControl.Size = New System.Drawing.Size(184, 37)
        Me.sistemaPanelControl.TabIndex = 9
        '
        'sistemaComboBoxEdit
        '
        Me.sistemaComboBoxEdit.Location = New System.Drawing.Point(7, 12)
        Me.sistemaComboBoxEdit.Name = "sistemaComboBoxEdit"
        Me.sistemaComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sistemaComboBoxEdit.Properties.Items.AddRange(New Object() {"Buddywin Cadastro Geral", "Buddywin Contábil", "Buddywin Declarar", "Buddywin Escrita Fiscal", "Buddywin Folha de Pagamento", "Buddywin Lalur", "Buddywin Fluxo de Caixa"})
        Me.sistemaComboBoxEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sistemaComboBoxEdit.Size = New System.Drawing.Size(171, 20)
        Me.sistemaComboBoxEdit.TabIndex = 0
        '
        'sistemaLabelControl
        '
        Me.sistemaLabelControl.Location = New System.Drawing.Point(404, 106)
        Me.sistemaLabelControl.Name = "sistemaLabelControl"
        Me.sistemaLabelControl.Size = New System.Drawing.Size(37, 13)
        Me.sistemaLabelControl.TabIndex = 8
        Me.sistemaLabelControl.Text = "Sistema"
        '
        'tiporelatorioPanelControl
        '
        Me.tiporelatorioPanelControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tiporelatorioPanelControl.Controls.Add(Me.tiporelatorioComboBoxEdit)
        Me.tiporelatorioPanelControl.Location = New System.Drawing.Point(6, 113)
        Me.tiporelatorioPanelControl.Name = "tiporelatorioPanelControl"
        Me.tiporelatorioPanelControl.Size = New System.Drawing.Size(126, 37)
        Me.tiporelatorioPanelControl.TabIndex = 3
        '
        'tiporelatorioComboBoxEdit
        '
        Me.tiporelatorioComboBoxEdit.EditValue = "Detalhado"
        Me.tiporelatorioComboBoxEdit.Location = New System.Drawing.Point(5, 12)
        Me.tiporelatorioComboBoxEdit.Name = "tiporelatorioComboBoxEdit"
        Me.tiporelatorioComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tiporelatorioComboBoxEdit.Properties.Items.AddRange(New Object() {"Detalhado", "Resumido"})
        Me.tiporelatorioComboBoxEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.tiporelatorioComboBoxEdit.Size = New System.Drawing.Size(116, 20)
        Me.tiporelatorioComboBoxEdit.TabIndex = 0
        '
        'tiporelatorioLabelControl
        '
        Me.tiporelatorioLabelControl.Location = New System.Drawing.Point(11, 106)
        Me.tiporelatorioLabelControl.Name = "tiporelatorioLabelControl"
        Me.tiporelatorioLabelControl.Size = New System.Drawing.Size(81, 13)
        Me.tiporelatorioLabelControl.TabIndex = 2
        Me.tiporelatorioLabelControl.Text = "Tipo de Relatório"
        '
        'obrigacoesrelatorioXtraForm
        '
        Me.AcceptButton = Me.imprimirSimpleButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.CancelButton = Me.voltarSimpleButton
        Me.ClientSize = New System.Drawing.Size(707, 204)
        Me.Controls.Add(Me.tiporelatorioLabelControl)
        Me.Controls.Add(Me.tiporelatorioPanelControl)
        Me.Controls.Add(Me.sistemaLabelControl)
        Me.Controls.Add(Me.sistemaPanelControl)
        Me.Controls.Add(Me.periodicidadeLabelControl)
        Me.Controls.Add(Me.tributoLabelControl)
        Me.Controls.Add(Me.obrigacaoLabelControl)
        Me.Controls.Add(Me.tributoPanelControl)
        Me.Controls.Add(Me.periodicidadePanelControl)
        Me.Controls.Add(Me.voltarSimpleButton)
        Me.Controls.Add(Me.imprimirSimpleButton)
        Me.Controls.Add(Me.obrigacaoPanelControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "obrigacoesrelatorioXtraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Cadastro de Obrigações"
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
        CType(Me.periodicidadePanelControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.periodicidadePanelControl.ResumeLayout(False)
        CType(Me.periodicidadeComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tributoPanelControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tributoPanelControl.ResumeLayout(False)
        CType(Me.tributoComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sistemaPanelControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sistemaPanelControl.ResumeLayout(False)
        CType(Me.sistemaComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tiporelatorioPanelControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tiporelatorioPanelControl.ResumeLayout(False)
        CType(Me.tiporelatorioComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents obrigacaoPanelControl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents voltarSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents imprimirSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents obrigacoesInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents obrigacaofinalLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents obrigacaoinicialLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents obrigacaoinicialSearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents obrigacaoinicialGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents obrigacaoinicial As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents descricaoinicial As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents obrigacaofinalTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents obrigacaofinalSearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents obrigacaofinalGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents obrigacaofinal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents descricaofinal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents obrigacaoinicialTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents periodicidadePanelControl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents tributoPanelControl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents obrigacaoLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents periodicidadeComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents tributoComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents tributoLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents periodicidadeLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sistemaPanelControl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents sistemaComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents sistemaLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tiporelatorioPanelControl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents tiporelatorioComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents tiporelatorioLabelControl As DevExpress.XtraEditors.LabelControl
End Class
