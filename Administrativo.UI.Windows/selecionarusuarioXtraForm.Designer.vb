<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class selecionarusuarioXtraForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(selecionarusuarioXtraForm))
        Me.cancelarSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.okSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.usuarioPanelControl = New DevExpress.XtraEditors.PanelControl()
        Me.senhaLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.usuarioLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.senhaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.usuarioTextEdit = New DevExpress.XtraEditors.TextEdit()
        CType(Me.usuarioPanelControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.usuarioPanelControl.SuspendLayout()
        CType(Me.senhaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.usuarioTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cancelarSimpleButton
        '
        Me.cancelarSimpleButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancelarSimpleButton.Image = CType(resources.GetObject("cancelarSimpleButton.Image"), System.Drawing.Image)
        Me.cancelarSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.cancelarSimpleButton.Location = New System.Drawing.Point(73, 97)
        Me.cancelarSimpleButton.Name = "cancelarSimpleButton"
        Me.cancelarSimpleButton.Size = New System.Drawing.Size(62, 45)
        Me.cancelarSimpleButton.TabIndex = 2
        Me.cancelarSimpleButton.Text = "Cancelar"
        '
        'okSimpleButton
        '
        Me.okSimpleButton.Image = CType(resources.GetObject("okSimpleButton.Image"), System.Drawing.Image)
        Me.okSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.okSimpleButton.Location = New System.Drawing.Point(4, 97)
        Me.okSimpleButton.Name = "okSimpleButton"
        Me.okSimpleButton.Size = New System.Drawing.Size(62, 45)
        Me.okSimpleButton.TabIndex = 1
        Me.okSimpleButton.Text = "OK"
        '
        'usuarioPanelControl
        '
        Me.usuarioPanelControl.Controls.Add(Me.senhaLabelControl)
        Me.usuarioPanelControl.Controls.Add(Me.usuarioLabelControl)
        Me.usuarioPanelControl.Controls.Add(Me.senhaTextEdit)
        Me.usuarioPanelControl.Controls.Add(Me.usuarioTextEdit)
        Me.usuarioPanelControl.Location = New System.Drawing.Point(2, 2)
        Me.usuarioPanelControl.Name = "usuarioPanelControl"
        Me.usuarioPanelControl.Size = New System.Drawing.Size(133, 90)
        Me.usuarioPanelControl.TabIndex = 0
        '
        'senhaLabelControl
        '
        Me.senhaLabelControl.Location = New System.Drawing.Point(6, 46)
        Me.senhaLabelControl.Name = "senhaLabelControl"
        Me.senhaLabelControl.Size = New System.Drawing.Size(30, 13)
        Me.senhaLabelControl.TabIndex = 2
        Me.senhaLabelControl.Text = "Senha"
        '
        'usuarioLabelControl
        '
        Me.usuarioLabelControl.Location = New System.Drawing.Point(6, 5)
        Me.usuarioLabelControl.Name = "usuarioLabelControl"
        Me.usuarioLabelControl.Size = New System.Drawing.Size(36, 13)
        Me.usuarioLabelControl.TabIndex = 0
        Me.usuarioLabelControl.Text = "Usuário"
        '
        'senhaTextEdit
        '
        Me.senhaTextEdit.Location = New System.Drawing.Point(6, 63)
        Me.senhaTextEdit.Name = "senhaTextEdit"
        Me.senhaTextEdit.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.senhaTextEdit.Properties.UseSystemPasswordChar = True
        Me.senhaTextEdit.Size = New System.Drawing.Size(122, 20)
        Me.senhaTextEdit.TabIndex = 3
        '
        'usuarioTextEdit
        '
        Me.usuarioTextEdit.Location = New System.Drawing.Point(6, 22)
        Me.usuarioTextEdit.Name = "usuarioTextEdit"
        Me.usuarioTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.usuarioTextEdit.Size = New System.Drawing.Size(122, 20)
        Me.usuarioTextEdit.TabIndex = 1
        '
        'selecionarusuarioXtraForm
        '
        Me.AcceptButton = Me.okSimpleButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.CancelButton = Me.cancelarSimpleButton
        Me.ClientSize = New System.Drawing.Size(138, 145)
        Me.Controls.Add(Me.usuarioPanelControl)
        Me.Controls.Add(Me.cancelarSimpleButton)
        Me.Controls.Add(Me.okSimpleButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(148, 174)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(148, 174)
        Me.Name = "selecionarusuarioXtraForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.TopMost = True
        CType(Me.usuarioPanelControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.usuarioPanelControl.ResumeLayout(False)
        Me.usuarioPanelControl.PerformLayout()
        CType(Me.senhaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.usuarioTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cancelarSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents okSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents usuarioPanelControl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents usuarioTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents senhaLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents usuarioLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents senhaTextEdit As DevExpress.XtraEditors.TextEdit
End Class
