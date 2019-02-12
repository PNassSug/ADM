Imports DevExpress.XtraEditors.Mask
Imports DevExpress.XtraEditors.Repository

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class empresaobrigacoesgeracaoXtraForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(empresaobrigacoesgeracaoXtraForm))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.obrigacaoLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.descricaoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.obrigacaoSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.obrigacoesInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.obrigacaoGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.obrigacaoGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.descricaoGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.competenciaLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.competenciaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.empresaLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.empresaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.empresaSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.empresasInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.empresainicialGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.empresaincialGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.razaosocialinicialGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.voltarSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.gerarSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.excluirempresaobrigacaoCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.descricaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacaoSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacoesInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacaoGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.competenciaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresaSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresasInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresainicialGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.excluirempresaobrigacaoCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.obrigacaoLabelControl)
        Me.PanelControl1.Controls.Add(Me.descricaoTextEdit)
        Me.PanelControl1.Controls.Add(Me.obrigacaoSearchLookUpEdit)
        Me.PanelControl1.Controls.Add(Me.competenciaLabelControl)
        Me.PanelControl1.Controls.Add(Me.competenciaTextEdit)
        Me.PanelControl1.Controls.Add(Me.empresaLabelControl)
        Me.PanelControl1.Controls.Add(Me.empresaTextEdit)
        Me.PanelControl1.Controls.Add(Me.empresaSearchLookUpEdit)
        Me.PanelControl1.Location = New System.Drawing.Point(6, 6)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(647, 90)
        Me.PanelControl1.TabIndex = 0
        '
        'obrigacaoLabelControl
        '
        Me.obrigacaoLabelControl.Location = New System.Drawing.Point(6, 48)
        Me.obrigacaoLabelControl.Name = "obrigacaoLabelControl"
        Me.obrigacaoLabelControl.Size = New System.Drawing.Size(49, 13)
        Me.obrigacaoLabelControl.TabIndex = 5
        Me.obrigacaoLabelControl.Text = "Obrigação"
        '
        'descricaoTextEdit
        '
        Me.descricaoTextEdit.Enabled = False
        Me.descricaoTextEdit.Location = New System.Drawing.Point(111, 64)
        Me.descricaoTextEdit.Name = "descricaoTextEdit"
        Me.descricaoTextEdit.Properties.AutoHeight = False
        Me.descricaoTextEdit.Size = New System.Drawing.Size(531, 22)
        Me.descricaoTextEdit.TabIndex = 7
        '
        'obrigacaoSearchLookUpEdit
        '
        Me.obrigacaoSearchLookUpEdit.Enabled = False
        Me.obrigacaoSearchLookUpEdit.Location = New System.Drawing.Point(6, 64)
        Me.obrigacaoSearchLookUpEdit.Name = "obrigacaoSearchLookUpEdit"
        Me.obrigacaoSearchLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.obrigacaoSearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("obrigacaoSearchLookUpEdit.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.obrigacaoSearchLookUpEdit.Properties.DataSource = Me.obrigacoesInfoBindingSource
        Me.obrigacaoSearchLookUpEdit.Properties.DisplayMember = "obrigacao"
        Me.obrigacaoSearchLookUpEdit.Properties.NullText = ""
        Me.obrigacaoSearchLookUpEdit.Properties.ValueMember = "obrigacao"
        Me.obrigacaoSearchLookUpEdit.Properties.View = Me.obrigacaoGridView
        Me.obrigacaoSearchLookUpEdit.Size = New System.Drawing.Size(100, 22)
        Me.obrigacaoSearchLookUpEdit.TabIndex = 6
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
        'competenciaLabelControl
        '
        Me.competenciaLabelControl.Location = New System.Drawing.Point(542, 5)
        Me.competenciaLabelControl.Name = "competenciaLabelControl"
        Me.competenciaLabelControl.Size = New System.Drawing.Size(62, 13)
        Me.competenciaLabelControl.TabIndex = 3
        Me.competenciaLabelControl.Text = "Competência"
        '
        'competenciaTextEdit
        '
        Me.competenciaTextEdit.Location = New System.Drawing.Point(542, 22)
        Me.competenciaTextEdit.Name = "competenciaTextEdit"
        Me.competenciaTextEdit.Properties.AutoHeight = False
        Me.competenciaTextEdit.Properties.Mask.EditMask = "00/0000"
        Me.competenciaTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.competenciaTextEdit.Properties.Mask.SaveLiteral = False
        Me.competenciaTextEdit.Properties.Mask.ShowPlaceHolders = False
        Me.competenciaTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.competenciaTextEdit.Size = New System.Drawing.Size(100, 22)
        Me.competenciaTextEdit.TabIndex = 4
        '
        'empresaLabelControl
        '
        Me.empresaLabelControl.Location = New System.Drawing.Point(6, 5)
        Me.empresaLabelControl.Name = "empresaLabelControl"
        Me.empresaLabelControl.Size = New System.Drawing.Size(41, 13)
        Me.empresaLabelControl.TabIndex = 0
        Me.empresaLabelControl.Text = "Empresa"
        '
        'empresaTextEdit
        '
        Me.empresaTextEdit.EditValue = ""
        Me.empresaTextEdit.Enabled = False
        Me.empresaTextEdit.Location = New System.Drawing.Point(111, 22)
        Me.empresaTextEdit.Name = "empresaTextEdit"
        Me.empresaTextEdit.Properties.AutoHeight = False
        Me.empresaTextEdit.Size = New System.Drawing.Size(426, 22)
        Me.empresaTextEdit.TabIndex = 2
        '
        'empresaSearchLookUpEdit
        '
        Me.empresaSearchLookUpEdit.Location = New System.Drawing.Point(6, 22)
        Me.empresaSearchLookUpEdit.Name = "empresaSearchLookUpEdit"
        Me.empresaSearchLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.empresaSearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("empresaSearchLookUpEdit.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.empresaSearchLookUpEdit.Properties.DataSource = Me.empresasInfoBindingSource
        Me.empresaSearchLookUpEdit.Properties.DisplayMember = "empresa"
        Me.empresaSearchLookUpEdit.Properties.NullText = ""
        Me.empresaSearchLookUpEdit.Properties.ValueMember = "empresa"
        Me.empresaSearchLookUpEdit.Properties.View = Me.empresainicialGridView
        Me.empresaSearchLookUpEdit.Size = New System.Drawing.Size(100, 22)
        Me.empresaSearchLookUpEdit.TabIndex = 1
        Me.empresaSearchLookUpEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.empresaSearchLookUpEdit.Properties.Mask.MaskType = MaskType.Simple
        Me.empresaSearchLookUpEdit.Properties.Mask.EditMask = "00.0000"
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
        'voltarSimpleButton
        '
        Me.voltarSimpleButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.voltarSimpleButton.Image = CType(resources.GetObject("voltarSimpleButton.Image"), System.Drawing.Image)
        Me.voltarSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.voltarSimpleButton.Location = New System.Drawing.Point(592, 101)
        Me.voltarSimpleButton.Name = "voltarSimpleButton"
        Me.voltarSimpleButton.Size = New System.Drawing.Size(62, 45)
        Me.voltarSimpleButton.TabIndex = 3
        Me.voltarSimpleButton.Text = "Voltar"
        '
        'gerarSimpleButton
        '
        Me.gerarSimpleButton.Image = CType(resources.GetObject("gerarSimpleButton.Image"), System.Drawing.Image)
        Me.gerarSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.gerarSimpleButton.Location = New System.Drawing.Point(524, 101)
        Me.gerarSimpleButton.Name = "gerarSimpleButton"
        Me.gerarSimpleButton.Size = New System.Drawing.Size(62, 45)
        Me.gerarSimpleButton.TabIndex = 2
        Me.gerarSimpleButton.Text = "Gerar"
        '
        'excluirempresaobrigacaoCheckEdit
        '
        Me.excluirempresaobrigacaoCheckEdit.Location = New System.Drawing.Point(4, 101)
        Me.excluirempresaobrigacaoCheckEdit.Name = "excluirempresaobrigacaoCheckEdit"
        Me.excluirempresaobrigacaoCheckEdit.Properties.Caption = "Antes de gerar, excluir o controle das obrigações da empresa conforme a competênc" &
    "ia informada?"
        Me.excluirempresaobrigacaoCheckEdit.Size = New System.Drawing.Size(505, 19)
        Me.excluirempresaobrigacaoCheckEdit.TabIndex = 1
        '
        'empresaobrigacoesgeracaoXtraForm
        '
        Me.AcceptButton = Me.gerarSimpleButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.CancelButton = Me.voltarSimpleButton
        Me.ClientSize = New System.Drawing.Size(656, 149)
        Me.Controls.Add(Me.excluirempresaobrigacaoCheckEdit)
        Me.Controls.Add(Me.voltarSimpleButton)
        Me.Controls.Add(Me.gerarSimpleButton)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "empresaobrigacoesgeracaoXtraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Geração do Controle das Obrigações por Empresa"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.descricaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacaoSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacoesInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacaoGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.competenciaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.empresaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.empresaSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.empresasInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.empresainicialGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.excluirempresaobrigacaoCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents voltarSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gerarSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents empresasInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents empresaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents empresaSearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents empresainicialGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents empresaincialGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents razaosocialinicialGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents empresaLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents competenciaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents excluirempresaobrigacaoCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents competenciaLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents descricaoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents obrigacaoSearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents obrigacoesInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents obrigacaoGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents obrigacaoGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents descricaoGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents obrigacaoLabelControl As DevExpress.XtraEditors.LabelControl
End Class
