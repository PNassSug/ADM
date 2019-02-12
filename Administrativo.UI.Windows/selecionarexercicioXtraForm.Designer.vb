<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class selecionarexercicioXtraForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(selecionarexercicioXtraForm))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.exercicioLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.exercicioComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cancelarSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.okSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.exercicioComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.exercicioLabelControl)
        Me.PanelControl1.Controls.Add(Me.exercicioComboBoxEdit)
        Me.PanelControl1.Location = New System.Drawing.Point(5, 5)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(198, 33)
        Me.PanelControl1.TabIndex = 0
        '
        'exercicioLabelControl
        '
        Me.exercicioLabelControl.Location = New System.Drawing.Point(6, 9)
        Me.exercicioLabelControl.Name = "exercicioLabelControl"
        Me.exercicioLabelControl.Size = New System.Drawing.Size(96, 13)
        Me.exercicioLabelControl.TabIndex = 0
        Me.exercicioLabelControl.Text = "Informar o Exercício"
        '
        'exercicioComboBoxEdit
        '
        Me.exercicioComboBoxEdit.Location = New System.Drawing.Point(105, 6)
        Me.exercicioComboBoxEdit.Name = "exercicioComboBoxEdit"
        Me.exercicioComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.exercicioComboBoxEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.exercicioComboBoxEdit.Size = New System.Drawing.Size(86, 20)
        Me.exercicioComboBoxEdit.TabIndex = 1
        '
        'cancelarSimpleButton
        '
        Me.cancelarSimpleButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancelarSimpleButton.Image = CType(resources.GetObject("cancelarSimpleButton.Image"), System.Drawing.Image)
        Me.cancelarSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.cancelarSimpleButton.Location = New System.Drawing.Point(141, 44)
        Me.cancelarSimpleButton.Name = "cancelarSimpleButton"
        Me.cancelarSimpleButton.Size = New System.Drawing.Size(62, 45)
        Me.cancelarSimpleButton.TabIndex = 2
        Me.cancelarSimpleButton.Text = "Cancelar"
        '
        'okSimpleButton
        '
        Me.okSimpleButton.Image = CType(resources.GetObject("okSimpleButton.Image"), System.Drawing.Image)
        Me.okSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.okSimpleButton.Location = New System.Drawing.Point(72, 44)
        Me.okSimpleButton.Name = "okSimpleButton"
        Me.okSimpleButton.Size = New System.Drawing.Size(62, 45)
        Me.okSimpleButton.TabIndex = 1
        Me.okSimpleButton.Text = "OK"
        '
        'selecionarexercicioXtraForm
        '
        Me.AcceptButton = Me.okSimpleButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.CancelButton = Me.cancelarSimpleButton
        Me.ClientSize = New System.Drawing.Size(206, 92)
        Me.Controls.Add(Me.cancelarSimpleButton)
        Me.Controls.Add(Me.okSimpleButton)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "selecionarexercicioXtraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exercício"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.exercicioComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cancelarSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents okSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents exercicioLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents exercicioComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
End Class
