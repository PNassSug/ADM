<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manutencaoobrigacoesfuncionariosXtraForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(manutencaoobrigacoesfuncionariosXtraForm))
        Me.funcionariosGridControl = New DevExpress.XtraGrid.GridControl()
        Me.funcionariosGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.funcionariosGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.funcionariosGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'funcionariosGridControl
        '
        Me.funcionariosGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.funcionariosGridControl.Location = New System.Drawing.Point(0, 0)
        Me.funcionariosGridControl.MainView = Me.funcionariosGridView
        Me.funcionariosGridControl.Name = "funcionariosGridControl"
        Me.funcionariosGridControl.Size = New System.Drawing.Size(577, 306)
        Me.funcionariosGridControl.TabIndex = 1
        Me.funcionariosGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.funcionariosGridView})
        '
        'funcionariosGridView
        '
        Me.funcionariosGridView.GridControl = Me.funcionariosGridControl
        Me.funcionariosGridView.Name = "funcionariosGridView"
        Me.funcionariosGridView.OptionsBehavior.Editable = False
        Me.funcionariosGridView.OptionsCustomization.AllowColumnMoving = False
        Me.funcionariosGridView.OptionsCustomization.AllowColumnResizing = False
        Me.funcionariosGridView.OptionsCustomization.AllowGroup = False
        Me.funcionariosGridView.OptionsCustomization.AllowQuickHideColumns = False
        Me.funcionariosGridView.OptionsView.ColumnAutoWidth = False
        Me.funcionariosGridView.OptionsView.ShowGroupPanel = False
        '
        'manutencaoobrigacoesfuncionariosXtraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(577, 306)
        Me.Controls.Add(Me.funcionariosGridControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "manutencaoobrigacoesfuncionariosXtraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relação de Funcionários"
        CType(Me.funcionariosGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.funcionariosGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents funcionariosGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents funcionariosGridView As DevExpress.XtraGrid.Views.Grid.GridView
End Class
