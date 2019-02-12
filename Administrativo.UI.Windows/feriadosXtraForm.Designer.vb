<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class feriadosXtraForm
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
        Me.components = New System.ComponentModel.Container()
        Dim TimeRuler1 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Dim TimeRuler2 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(feriadosXtraForm))
        Me.feriadosSchedulerControl = New DevExpress.XtraScheduler.SchedulerControl()
        Me.feriadosSchedulerStorage = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
        Me.feriadosDateNavigator = New DevExpress.XtraScheduler.DateNavigator()
        CType(Me.feriadosSchedulerControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.feriadosSchedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.feriadosDateNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.feriadosDateNavigator.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'feriadosSchedulerControl
        '
        Me.feriadosSchedulerControl.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Month
        Me.feriadosSchedulerControl.DateNavigationBar.Visible = False
        Me.feriadosSchedulerControl.Dock = System.Windows.Forms.DockStyle.Left
        Me.feriadosSchedulerControl.Location = New System.Drawing.Point(0, 0)
        Me.feriadosSchedulerControl.Name = "feriadosSchedulerControl"
        Me.feriadosSchedulerControl.Size = New System.Drawing.Size(890, 544)
        Me.feriadosSchedulerControl.Start = New Date(2015, 11, 8, 0, 0, 0, 0)
        Me.feriadosSchedulerControl.Storage = Me.feriadosSchedulerStorage
        Me.feriadosSchedulerControl.TabIndex = 0
        Me.feriadosSchedulerControl.Views.DayView.TimeRulers.Add(TimeRuler1)
        Me.feriadosSchedulerControl.Views.GanttView.Enabled = False
        Me.feriadosSchedulerControl.Views.TimelineView.Enabled = False
        Me.feriadosSchedulerControl.Views.WorkWeekView.Enabled = False
        Me.feriadosSchedulerControl.Views.WorkWeekView.TimeRulers.Add(TimeRuler2)
        '
        'feriadosSchedulerStorage
        '
        '
        'feriadosDateNavigator
        '
        Me.feriadosDateNavigator.AllowAnimatedContentChange = True
        Me.feriadosDateNavigator.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.feriadosDateNavigator.CellPadding = New System.Windows.Forms.Padding(2)
        Me.feriadosDateNavigator.Cursor = System.Windows.Forms.Cursors.Default
        Me.feriadosDateNavigator.Dock = System.Windows.Forms.DockStyle.Right
        Me.feriadosDateNavigator.FirstDayOfWeek = System.DayOfWeek.Sunday
        Me.feriadosDateNavigator.Location = New System.Drawing.Point(896, 0)
        Me.feriadosDateNavigator.Name = "feriadosDateNavigator"
        Me.feriadosDateNavigator.SchedulerControl = Me.feriadosSchedulerControl
        Me.feriadosDateNavigator.Size = New System.Drawing.Size(202, 544)
        Me.feriadosDateNavigator.TabIndex = 1
        '
        'feriadosXtraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1098, 544)
        Me.Controls.Add(Me.feriadosDateNavigator)
        Me.Controls.Add(Me.feriadosSchedulerControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "feriadosXtraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Feriados"
        CType(Me.feriadosSchedulerControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.feriadosSchedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.feriadosDateNavigator.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.feriadosDateNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents feriadosSchedulerControl As DevExpress.XtraScheduler.SchedulerControl
    Friend WithEvents feriadosSchedulerStorage As DevExpress.XtraScheduler.SchedulerStorage
    Friend WithEvents feriadosDateNavigator As DevExpress.XtraScheduler.DateNavigator
End Class
