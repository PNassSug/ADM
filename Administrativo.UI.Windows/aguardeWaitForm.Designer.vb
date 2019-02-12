<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aguardeWaitForm
    Inherits DevExpress.XtraWaitForm.WaitForm

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
        Me.aguardetableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.textoprogressPanel = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.aguardetableLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'aguardetableLayoutPanel
        '
        Me.aguardetableLayoutPanel.AutoSize = True
        Me.aguardetableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.aguardetableLayoutPanel.BackColor = System.Drawing.Color.Transparent
        Me.aguardetableLayoutPanel.ColumnCount = 1
        Me.aguardetableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.aguardetableLayoutPanel.Controls.Add(Me.textoprogressPanel, 0, 0)
        Me.aguardetableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.aguardetableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.aguardetableLayoutPanel.Name = "aguardetableLayoutPanel"
        Me.aguardetableLayoutPanel.Padding = New System.Windows.Forms.Padding(0, 14, 0, 14)
        Me.aguardetableLayoutPanel.RowCount = 1
        Me.aguardetableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.aguardetableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.aguardetableLayoutPanel.Size = New System.Drawing.Size(374, 73)
        Me.aguardetableLayoutPanel.TabIndex = 1
        '
        'textoprogressPanel
        '
        Me.textoprogressPanel.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.textoprogressPanel.Appearance.Options.UseBackColor = True
        Me.textoprogressPanel.AppearanceCaption.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.textoprogressPanel.AppearanceCaption.Options.UseFont = True
        Me.textoprogressPanel.AppearanceDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.textoprogressPanel.AppearanceDescription.Options.UseFont = True
        Me.textoprogressPanel.AutoHeight = True
        Me.textoprogressPanel.AutoWidth = True
        Me.textoprogressPanel.BarAnimationElementThickness = 2
        Me.textoprogressPanel.Caption = "Aguarde um Momento"
        Me.textoprogressPanel.Description = "Carregando ..."
        Me.textoprogressPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textoprogressPanel.ImageHorzOffset = 20
        Me.textoprogressPanel.Location = New System.Drawing.Point(0, 17)
        Me.textoprogressPanel.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.textoprogressPanel.Name = "textoprogressPanel"
        Me.textoprogressPanel.Size = New System.Drawing.Size(374, 39)
        Me.textoprogressPanel.TabIndex = 0
        '
        'aguardeWaitForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(374, 73)
        Me.Controls.Add(Me.aguardetableLayoutPanel)
        Me.DoubleBuffered = True
        Me.Name = "aguardeWaitForm"
        Me.aguardetableLayoutPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents aguardetableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Private WithEvents textoprogressPanel As DevExpress.XtraWaitForm.ProgressPanel
End Class
