<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class manualsistemaXtraForm
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(manualsistemaXtraForm))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.manualPdfViewer = New DevExpress.XtraPdfViewer.PdfViewer()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.PanelControl1.Controls.Add(Me.manualPdfViewer)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(979, 630)
        Me.PanelControl1.TabIndex = 1
        '
        'manualPdfViewer
        '
        Me.manualPdfViewer.DetachStreamAfterLoadComplete = True
        Me.manualPdfViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.manualPdfViewer.Location = New System.Drawing.Point(2, 2)
        Me.manualPdfViewer.Name = "manualPdfViewer"
        Me.manualPdfViewer.Size = New System.Drawing.Size(975, 626)
        Me.manualPdfViewer.TabIndex = 3
        Me.manualPdfViewer.ZoomFactor = 100.0!
        Me.manualPdfViewer.ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.Custom
        '
        'manualsistemaXtraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(979, 630)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "manualsistemaXtraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manual do Sistema"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents manualPdfViewer As DevExpress.XtraPdfViewer.PdfViewer
End Class
