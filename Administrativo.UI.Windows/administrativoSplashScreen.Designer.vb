<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class administrativoSplashScreen
    Inherits DevExpress.XtraSplashScreen.SplashScreen

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(administrativoSplashScreen))
        Me.pictureEdit2 = New DevExpress.XtraEditors.PictureEdit()
        Me.inicializandolabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.direitosautoraislabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.marqueeProgressBarControl1 = New DevExpress.XtraEditors.MarqueeProgressBarControl()
        Me.administrativoDefaultLookAndFeel = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.versaosistemaLabelControl = New DevExpress.XtraEditors.LabelControl()
        CType(Me.pictureEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.marqueeProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pictureEdit2
        '
        Me.pictureEdit2.Cursor = System.Windows.Forms.Cursors.Default
        Me.pictureEdit2.EditValue = CType(resources.GetObject("pictureEdit2.EditValue"), Object)
        Me.pictureEdit2.Location = New System.Drawing.Point(12, 12)
        Me.pictureEdit2.Name = "pictureEdit2"
        Me.pictureEdit2.Properties.AllowFocused = False
        Me.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.pictureEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pictureEdit2.Properties.ShowMenu = False
        Me.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.pictureEdit2.Properties.ZoomAccelerationFactor = 1.0R
        Me.pictureEdit2.Size = New System.Drawing.Size(442, 269)
        Me.pictureEdit2.TabIndex = 14
        '
        'inicializandolabelControl
        '
        Me.inicializandolabelControl.Location = New System.Drawing.Point(23, 287)
        Me.inicializandolabelControl.Name = "inicializandolabelControl"
        Me.inicializandolabelControl.Size = New System.Drawing.Size(118, 13)
        Me.inicializandolabelControl.TabIndex = 12
        Me.inicializandolabelControl.Text = "Inicializando o sistema..."
        '
        'direitosautoraislabelControl
        '
        Me.direitosautoraislabelControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.direitosautoraislabelControl.Location = New System.Drawing.Point(339, 330)
        Me.direitosautoraislabelControl.Name = "direitosautoraislabelControl"
        Me.direitosautoraislabelControl.Size = New System.Drawing.Size(115, 13)
        Me.direitosautoraislabelControl.TabIndex = 11
        Me.direitosautoraislabelControl.Text = "Copyright © 2001-2017"
        '
        'marqueeProgressBarControl1
        '
        Me.marqueeProgressBarControl1.EditValue = 0
        Me.marqueeProgressBarControl1.Location = New System.Drawing.Point(23, 312)
        Me.marqueeProgressBarControl1.Name = "marqueeProgressBarControl1"
        Me.marqueeProgressBarControl1.Size = New System.Drawing.Size(431, 12)
        Me.marqueeProgressBarControl1.TabIndex = 10
        '
        'versaosistemaLabelControl
        '
        Me.versaosistemaLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.versaosistemaLabelControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.versaosistemaLabelControl.Location = New System.Drawing.Point(23, 330)
        Me.versaosistemaLabelControl.Name = "versaosistemaLabelControl"
        Me.versaosistemaLabelControl.Size = New System.Drawing.Size(277, 13)
        Me.versaosistemaLabelControl.TabIndex = 15
        '
        'administrativoSplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 351)
        Me.Controls.Add(Me.versaosistemaLabelControl)
        Me.Controls.Add(Me.pictureEdit2)
        Me.Controls.Add(Me.inicializandolabelControl)
        Me.Controls.Add(Me.direitosautoraislabelControl)
        Me.Controls.Add(Me.marqueeProgressBarControl1)
        Me.Name = "administrativoSplashScreen"
        CType(Me.pictureEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.marqueeProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents pictureEdit2 As DevExpress.XtraEditors.PictureEdit
    Private WithEvents inicializandolabelControl As DevExpress.XtraEditors.LabelControl
    Private WithEvents direitosautoraislabelControl As DevExpress.XtraEditors.LabelControl
    Private WithEvents marqueeProgressBarControl1 As DevExpress.XtraEditors.MarqueeProgressBarControl
    Friend WithEvents administrativoDefaultLookAndFeel As DevExpress.LookAndFeel.DefaultLookAndFeel
    Private WithEvents versaosistemaLabelControl As DevExpress.XtraEditors.LabelControl
End Class
