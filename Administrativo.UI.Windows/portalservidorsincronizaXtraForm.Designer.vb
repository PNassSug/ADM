<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class portalservidorsincronizaXtraForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(portalservidorsincronizaXtraForm))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.usuariosescritoriosCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.usuariosempresasCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.obrigacoesCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.empresasCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.sincronizarSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.voltarSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.usuariosescritoriosCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.usuariosempresasCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obrigacoesCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresasCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.usuariosescritoriosCheckEdit)
        Me.PanelControl1.Controls.Add(Me.usuariosempresasCheckEdit)
        Me.PanelControl1.Controls.Add(Me.obrigacoesCheckEdit)
        Me.PanelControl1.Controls.Add(Me.empresasCheckEdit)
        Me.PanelControl1.Location = New System.Drawing.Point(4, 6)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(147, 100)
        Me.PanelControl1.TabIndex = 0
        '
        'usuariosescritoriosCheckEdit
        '
        Me.usuariosescritoriosCheckEdit.Location = New System.Drawing.Point(5, 80)
        Me.usuariosescritoriosCheckEdit.Name = "usuariosescritoriosCheckEdit"
        Me.usuariosescritoriosCheckEdit.Properties.Caption = "Usuários Escritórios"
        Me.usuariosescritoriosCheckEdit.Size = New System.Drawing.Size(116, 19)
        Me.usuariosescritoriosCheckEdit.TabIndex = 3
        '
        'usuariosempresasCheckEdit
        '
        Me.usuariosempresasCheckEdit.Location = New System.Drawing.Point(5, 55)
        Me.usuariosempresasCheckEdit.Name = "usuariosempresasCheckEdit"
        Me.usuariosempresasCheckEdit.Properties.Caption = "Usuários Empresas"
        Me.usuariosempresasCheckEdit.Size = New System.Drawing.Size(116, 19)
        Me.usuariosempresasCheckEdit.TabIndex = 2
        '
        'obrigacoesCheckEdit
        '
        Me.obrigacoesCheckEdit.Location = New System.Drawing.Point(5, 30)
        Me.obrigacoesCheckEdit.Name = "obrigacoesCheckEdit"
        Me.obrigacoesCheckEdit.Properties.Caption = "Obrigações"
        Me.obrigacoesCheckEdit.Size = New System.Drawing.Size(116, 19)
        Me.obrigacoesCheckEdit.TabIndex = 1
        '
        'empresasCheckEdit
        '
        Me.empresasCheckEdit.Location = New System.Drawing.Point(5, 5)
        Me.empresasCheckEdit.Name = "empresasCheckEdit"
        Me.empresasCheckEdit.Properties.Caption = "Empresas"
        Me.empresasCheckEdit.Size = New System.Drawing.Size(116, 19)
        Me.empresasCheckEdit.TabIndex = 0
        '
        'sincronizarSimpleButton
        '
        Me.sincronizarSimpleButton.Image = CType(resources.GetObject("sincronizarSimpleButton.Image"), System.Drawing.Image)
        Me.sincronizarSimpleButton.ImageIndex = 0
        Me.sincronizarSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.sincronizarSimpleButton.Location = New System.Drawing.Point(21, 111)
        Me.sincronizarSimpleButton.Name = "sincronizarSimpleButton"
        Me.sincronizarSimpleButton.Size = New System.Drawing.Size(62, 45)
        Me.sincronizarSimpleButton.TabIndex = 1
        Me.sincronizarSimpleButton.Text = "Sincronizar"
        '
        'voltarSimpleButton
        '
        Me.voltarSimpleButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.voltarSimpleButton.Image = CType(resources.GetObject("voltarSimpleButton.Image"), System.Drawing.Image)
        Me.voltarSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.voltarSimpleButton.Location = New System.Drawing.Point(89, 111)
        Me.voltarSimpleButton.Name = "voltarSimpleButton"
        Me.voltarSimpleButton.Size = New System.Drawing.Size(62, 45)
        Me.voltarSimpleButton.TabIndex = 2
        Me.voltarSimpleButton.Text = "Voltar"
        '
        'portalservidorsincronizaXtraForm
        '
        Me.AcceptButton = Me.sincronizarSimpleButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.CancelButton = Me.voltarSimpleButton
        Me.ClientSize = New System.Drawing.Size(156, 160)
        Me.Controls.Add(Me.sincronizarSimpleButton)
        Me.Controls.Add(Me.voltarSimpleButton)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "portalservidorsincronizaXtraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sincronizar dados"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.usuariosescritoriosCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.usuariosempresasCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obrigacoesCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.empresasCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents sincronizarSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents voltarSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents usuariosempresasCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents obrigacoesCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents empresasCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents usuariosescritoriosCheckEdit As DevExpress.XtraEditors.CheckEdit
End Class
