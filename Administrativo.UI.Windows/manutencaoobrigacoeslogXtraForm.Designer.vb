<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manutencaoobrigacoeslogXtraForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(manutencaoobrigacoeslogXtraForm))
        Me.logGridControl = New DevExpress.XtraGrid.GridControl()
        Me.logGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.logGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'logGridControl
        '
        Me.logGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.logGridControl.Location = New System.Drawing.Point(0, 0)
        Me.logGridControl.MainView = Me.logGridView
        Me.logGridControl.Name = "logGridControl"
        Me.logGridControl.Size = New System.Drawing.Size(622, 309)
        Me.logGridControl.TabIndex = 3
        Me.logGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.logGridView})
        '
        'logGridView
        '
        Me.logGridView.GridControl = Me.logGridControl
        Me.logGridView.Name = "logGridView"
        Me.logGridView.OptionsBehavior.Editable = False
        Me.logGridView.OptionsCustomization.AllowColumnMoving = False
        Me.logGridView.OptionsCustomization.AllowColumnResizing = False
        Me.logGridView.OptionsCustomization.AllowGroup = False
        Me.logGridView.OptionsCustomization.AllowQuickHideColumns = False
        Me.logGridView.OptionsView.ColumnAutoWidth = False
        Me.logGridView.OptionsView.ShowGroupPanel = False
        '
        'manutencaoobrigacoeslogXtraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(622, 309)
        Me.Controls.Add(Me.logGridControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "manutencaoobrigacoeslogXtraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visualização completa dos LOG's"
        CType(Me.logGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents logGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents logGridView As DevExpress.XtraGrid.Views.Grid.GridView
End Class
