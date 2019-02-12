<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class selecionarcompetenciaXtraForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(selecionarcompetenciaXtraForm))
        Me.cancelarSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.okSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.competenciaLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.competenciaComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.competenciaComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cancelarSimpleButton
        '
        Me.cancelarSimpleButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancelarSimpleButton.Image = CType(resources.GetObject("cancelarSimpleButton.Image"), System.Drawing.Image)
        Me.cancelarSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.cancelarSimpleButton.Location = New System.Drawing.Point(177, 44)
        Me.cancelarSimpleButton.Name = "cancelarSimpleButton"
        Me.cancelarSimpleButton.Size = New System.Drawing.Size(62, 45)
        Me.cancelarSimpleButton.TabIndex = 5
        Me.cancelarSimpleButton.Text = "Cancelar"
        '
        'okSimpleButton
        '
        Me.okSimpleButton.Image = CType(resources.GetObject("okSimpleButton.Image"), System.Drawing.Image)
        Me.okSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.okSimpleButton.Location = New System.Drawing.Point(108, 44)
        Me.okSimpleButton.Name = "okSimpleButton"
        Me.okSimpleButton.Size = New System.Drawing.Size(62, 45)
        Me.okSimpleButton.TabIndex = 4
        Me.okSimpleButton.Text = "OK"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.competenciaLabelControl)
        Me.PanelControl1.Controls.Add(Me.competenciaComboBoxEdit)
        Me.PanelControl1.Location = New System.Drawing.Point(5, 5)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(234, 33)
        Me.PanelControl1.TabIndex = 3
        '
        'competenciaLabelControl
        '
        Me.competenciaLabelControl.Location = New System.Drawing.Point(6, 9)
        Me.competenciaLabelControl.Name = "competenciaLabelControl"
        Me.competenciaLabelControl.Size = New System.Drawing.Size(116, 13)
        Me.competenciaLabelControl.TabIndex = 0
        Me.competenciaLabelControl.Text = "Informar a Competência"
        '
        'competenciaComboBoxEdit
        '
        Me.competenciaComboBoxEdit.Location = New System.Drawing.Point(128, 6)
        Me.competenciaComboBoxEdit.Name = "competenciaComboBoxEdit"
        Me.competenciaComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.competenciaComboBoxEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.competenciaComboBoxEdit.Size = New System.Drawing.Size(99, 20)
        Me.competenciaComboBoxEdit.TabIndex = 1
        '
        'selecionarcompetenciaXtraForm
        '
        Me.AcceptButton = Me.okSimpleButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.CancelButton = Me.cancelarSimpleButton
        Me.ClientSize = New System.Drawing.Size(242, 92)
        Me.Controls.Add(Me.cancelarSimpleButton)
        Me.Controls.Add(Me.okSimpleButton)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "selecionarcompetenciaXtraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Competência"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.competenciaComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cancelarSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents okSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents competenciaLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents competenciaComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
End Class
