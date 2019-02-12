<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class portalservidorXtraForm
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(portalservidorXtraForm))
        Me.portalservidorPanelControl = New DevExpress.XtraEditors.PanelControl()
        Me.sincronizarSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.telefoneTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.dddTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.telefoneLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.dddLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.razaosocialTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.razaosocialLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.tipopessoaLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.tipopessoaComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.servidorLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.cnpjcpfLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.servidorTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.cnpjcpfTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.okSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.voltarSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.portalservidorPanelControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.portalservidorPanelControl.SuspendLayout()
        CType(Me.telefoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dddTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.razaosocialTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tipopessoaComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.servidorTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cnpjcpfTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'portalservidorPanelControl
        '
        Me.portalservidorPanelControl.Controls.Add(Me.sincronizarSimpleButton)
        Me.portalservidorPanelControl.Controls.Add(Me.telefoneTextEdit)
        Me.portalservidorPanelControl.Controls.Add(Me.dddTextEdit)
        Me.portalservidorPanelControl.Controls.Add(Me.telefoneLabelControl)
        Me.portalservidorPanelControl.Controls.Add(Me.dddLabelControl)
        Me.portalservidorPanelControl.Controls.Add(Me.razaosocialTextEdit)
        Me.portalservidorPanelControl.Controls.Add(Me.razaosocialLabelControl)
        Me.portalservidorPanelControl.Controls.Add(Me.tipopessoaLabelControl)
        Me.portalservidorPanelControl.Controls.Add(Me.tipopessoaComboBoxEdit)
        Me.portalservidorPanelControl.Controls.Add(Me.servidorLabelControl)
        Me.portalservidorPanelControl.Controls.Add(Me.cnpjcpfLabelControl)
        Me.portalservidorPanelControl.Controls.Add(Me.servidorTextEdit)
        Me.portalservidorPanelControl.Controls.Add(Me.cnpjcpfTextEdit)
        Me.portalservidorPanelControl.Location = New System.Drawing.Point(4, 6)
        Me.portalservidorPanelControl.Name = "portalservidorPanelControl"
        Me.portalservidorPanelControl.Size = New System.Drawing.Size(619, 123)
        Me.portalservidorPanelControl.TabIndex = 0
        '
        'sincronizarSimpleButton
        '
        Me.sincronizarSimpleButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.sincronizarSimpleButton.Image = CType(resources.GetObject("sincronizarSimpleButton.Image"), System.Drawing.Image)
        Me.sincronizarSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.sincronizarSimpleButton.Location = New System.Drawing.Point(550, 46)
        Me.sincronizarSimpleButton.Name = "sincronizarSimpleButton"
        Me.sincronizarSimpleButton.Size = New System.Drawing.Size(62, 45)
        Me.sincronizarSimpleButton.TabIndex = 12
        Me.sincronizarSimpleButton.Text = "Sincronizar"
        '
        'telefoneTextEdit
        '
        Me.telefoneTextEdit.Location = New System.Drawing.Point(256, 58)
        Me.telefoneTextEdit.Name = "telefoneTextEdit"
        Me.telefoneTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.telefoneTextEdit.Properties.Mask.SaveLiteral = False
        Me.telefoneTextEdit.Properties.MaxLength = 9
        Me.telefoneTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.telefoneTextEdit.TabIndex = 9
        '
        'dddTextEdit
        '
        Me.dddTextEdit.Location = New System.Drawing.Point(200, 58)
        Me.dddTextEdit.Name = "dddTextEdit"
        Me.dddTextEdit.Properties.Mask.EditMask = "(0x000)"
        Me.dddTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.dddTextEdit.Properties.Mask.SaveLiteral = False
        Me.dddTextEdit.Size = New System.Drawing.Size(50, 20)
        Me.dddTextEdit.TabIndex = 7
        '
        'telefoneLabelControl
        '
        Me.telefoneLabelControl.Location = New System.Drawing.Point(256, 42)
        Me.telefoneLabelControl.Name = "telefoneLabelControl"
        Me.telefoneLabelControl.Size = New System.Drawing.Size(42, 13)
        Me.telefoneLabelControl.TabIndex = 8
        Me.telefoneLabelControl.Text = "Telefone"
        '
        'dddLabelControl
        '
        Me.dddLabelControl.Location = New System.Drawing.Point(200, 42)
        Me.dddLabelControl.Name = "dddLabelControl"
        Me.dddLabelControl.Size = New System.Drawing.Size(21, 13)
        Me.dddLabelControl.TabIndex = 6
        Me.dddLabelControl.Text = "DDD"
        '
        'razaosocialTextEdit
        '
        Me.razaosocialTextEdit.Location = New System.Drawing.Point(5, 19)
        Me.razaosocialTextEdit.Name = "razaosocialTextEdit"
        Me.razaosocialTextEdit.Properties.MaxLength = 50
        Me.razaosocialTextEdit.Size = New System.Drawing.Size(607, 20)
        Me.razaosocialTextEdit.TabIndex = 1
        '
        'razaosocialLabelControl
        '
        Me.razaosocialLabelControl.Location = New System.Drawing.Point(5, 4)
        Me.razaosocialLabelControl.Name = "razaosocialLabelControl"
        Me.razaosocialLabelControl.Size = New System.Drawing.Size(60, 13)
        Me.razaosocialLabelControl.TabIndex = 0
        Me.razaosocialLabelControl.Text = "Razão Social"
        '
        'tipopessoaLabelControl
        '
        Me.tipopessoaLabelControl.Location = New System.Drawing.Point(5, 42)
        Me.tipopessoaLabelControl.Name = "tipopessoaLabelControl"
        Me.tipopessoaLabelControl.Size = New System.Drawing.Size(57, 13)
        Me.tipopessoaLabelControl.TabIndex = 2
        Me.tipopessoaLabelControl.Text = "Tipo Pessoa"
        '
        'tipopessoaComboBoxEdit
        '
        Me.tipopessoaComboBoxEdit.EditValue = ""
        Me.tipopessoaComboBoxEdit.Location = New System.Drawing.Point(5, 58)
        Me.tipopessoaComboBoxEdit.Name = "tipopessoaComboBoxEdit"
        Me.tipopessoaComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tipopessoaComboBoxEdit.Properties.Items.AddRange(New Object() {"Jurídica", "Física"})
        Me.tipopessoaComboBoxEdit.Size = New System.Drawing.Size(70, 20)
        Me.tipopessoaComboBoxEdit.TabIndex = 3
        '
        'servidorLabelControl
        '
        Me.servidorLabelControl.Location = New System.Drawing.Point(5, 81)
        Me.servidorLabelControl.Name = "servidorLabelControl"
        Me.servidorLabelControl.Size = New System.Drawing.Size(103, 13)
        Me.servidorLabelControl.TabIndex = 10
        Me.servidorLabelControl.Text = "Endereço do Servidor"
        '
        'cnpjcpfLabelControl
        '
        Me.cnpjcpfLabelControl.Location = New System.Drawing.Point(81, 42)
        Me.cnpjcpfLabelControl.Name = "cnpjcpfLabelControl"
        Me.cnpjcpfLabelControl.Size = New System.Drawing.Size(48, 13)
        Me.cnpjcpfLabelControl.TabIndex = 4
        Me.cnpjcpfLabelControl.Text = "CNPJ/CPF"
        '
        'servidorTextEdit
        '
        Me.servidorTextEdit.EditValue = ""
        Me.servidorTextEdit.Location = New System.Drawing.Point(5, 97)
        Me.servidorTextEdit.Name = "servidorTextEdit"
        Me.servidorTextEdit.Properties.MaxLength = 100
        Me.servidorTextEdit.Size = New System.Drawing.Size(607, 20)
        Me.servidorTextEdit.TabIndex = 11
        '
        'cnpjcpfTextEdit
        '
        Me.cnpjcpfTextEdit.EditValue = ""
        Me.cnpjcpfTextEdit.Location = New System.Drawing.Point(81, 58)
        Me.cnpjcpfTextEdit.Name = "cnpjcpfTextEdit"
        Me.cnpjcpfTextEdit.Properties.Mask.EditMask = "00.000.000/0000-00"
        Me.cnpjcpfTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.cnpjcpfTextEdit.Properties.Mask.SaveLiteral = False
        Me.cnpjcpfTextEdit.Size = New System.Drawing.Size(113, 20)
        Me.cnpjcpfTextEdit.TabIndex = 5
        '
        'okSimpleButton
        '
        Me.okSimpleButton.Image = CType(resources.GetObject("okSimpleButton.Image"), System.Drawing.Image)
        Me.okSimpleButton.ImageIndex = 0
        Me.okSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.okSimpleButton.Location = New System.Drawing.Point(493, 133)
        Me.okSimpleButton.Name = "okSimpleButton"
        Me.okSimpleButton.Size = New System.Drawing.Size(62, 45)
        Me.okSimpleButton.TabIndex = 1
        Me.okSimpleButton.Text = "OK"
        '
        'voltarSimpleButton
        '
        Me.voltarSimpleButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.voltarSimpleButton.Image = CType(resources.GetObject("voltarSimpleButton.Image"), System.Drawing.Image)
        Me.voltarSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.voltarSimpleButton.Location = New System.Drawing.Point(561, 133)
        Me.voltarSimpleButton.Name = "voltarSimpleButton"
        Me.voltarSimpleButton.Size = New System.Drawing.Size(62, 45)
        Me.voltarSimpleButton.TabIndex = 2
        Me.voltarSimpleButton.Text = "Voltar"
        '
        'portalservidorXtraForm
        '
        Me.AcceptButton = Me.okSimpleButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.CancelButton = Me.voltarSimpleButton
        Me.ClientSize = New System.Drawing.Size(627, 182)
        Me.Controls.Add(Me.okSimpleButton)
        Me.Controls.Add(Me.voltarSimpleButton)
        Me.Controls.Add(Me.portalservidorPanelControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "portalservidorXtraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuração do Servidor"
        CType(Me.portalservidorPanelControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.portalservidorPanelControl.ResumeLayout(False)
        Me.portalservidorPanelControl.PerformLayout()
        CType(Me.telefoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dddTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.razaosocialTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tipopessoaComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.servidorTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cnpjcpfTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents portalservidorPanelControl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents okSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents voltarSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tipopessoaLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tipopessoaComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents servidorLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cnpjcpfLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents servidorTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cnpjcpfTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents telefoneTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dddTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents telefoneLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dddLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents razaosocialTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents razaosocialLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sincronizarSimpleButton As DevExpress.XtraEditors.SimpleButton
End Class
