<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class filtroXtraForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(filtroXtraForm))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.filtroSplitContainerControl = New DevExpress.XtraEditors.SplitContainerControl()
        Me.competenciaLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.competenciaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.vencimentoRadioGroup = New DevExpress.XtraEditors.RadioGroup()
        Me.vencimentoSplitContainerControl = New DevExpress.XtraEditors.SplitContainerControl()
        Me.diaLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.diasTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.datafinalDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.datafinalLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.datainicialDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.datainicialLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.filtroRadioGroup = New DevExpress.XtraEditors.RadioGroup()
        Me.voltarSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.okSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.filtroSplitContainerControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.filtroSplitContainerControl.SuspendLayout()
        CType(Me.competenciaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vencimentoRadioGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vencimentoSplitContainerControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.vencimentoSplitContainerControl.SuspendLayout()
        CType(Me.diasTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datafinalDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datafinalDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datainicialDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datainicialDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.filtroRadioGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'filtroSplitContainerControl
        '
        Me.filtroSplitContainerControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.filtroSplitContainerControl.Location = New System.Drawing.Point(133, 6)
        Me.filtroSplitContainerControl.Name = "filtroSplitContainerControl"
        Me.filtroSplitContainerControl.Panel1.Controls.Add(Me.competenciaLabelControl)
        Me.filtroSplitContainerControl.Panel1.Controls.Add(Me.competenciaTextEdit)
        Me.filtroSplitContainerControl.Panel1.Text = "Panel1"
        Me.filtroSplitContainerControl.Panel2.Controls.Add(Me.vencimentoRadioGroup)
        Me.filtroSplitContainerControl.Panel2.Controls.Add(Me.vencimentoSplitContainerControl)
        Me.filtroSplitContainerControl.Panel2.Text = "Panel2"
        Me.filtroSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
        Me.filtroSplitContainerControl.Size = New System.Drawing.Size(193, 105)
        Me.filtroSplitContainerControl.TabIndex = 0
        Me.filtroSplitContainerControl.Text = "SplitContainerControl1"
        '
        'competenciaLabelControl
        '
        Me.competenciaLabelControl.Location = New System.Drawing.Point(3, 7)
        Me.competenciaLabelControl.Name = "competenciaLabelControl"
        Me.competenciaLabelControl.Size = New System.Drawing.Size(64, 13)
        Me.competenciaLabelControl.TabIndex = 5
        Me.competenciaLabelControl.Text = "Fato Gerador"
        '
        'competenciaTextEdit
        '
        Me.competenciaTextEdit.Enabled = False
        Me.competenciaTextEdit.Location = New System.Drawing.Point(3, 24)
        Me.competenciaTextEdit.Name = "competenciaTextEdit"
        Me.competenciaTextEdit.Properties.AutoHeight = False
        Me.competenciaTextEdit.Properties.Mask.EditMask = "00/0000"
        Me.competenciaTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.competenciaTextEdit.Properties.Mask.SaveLiteral = False
        Me.competenciaTextEdit.Properties.Mask.ShowPlaceHolders = False
        Me.competenciaTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.competenciaTextEdit.Size = New System.Drawing.Size(73, 22)
        Me.competenciaTextEdit.TabIndex = 6
        '
        'vencimentoRadioGroup
        '
        Me.vencimentoRadioGroup.Location = New System.Drawing.Point(4, 9)
        Me.vencimentoRadioGroup.Name = "vencimentoRadioGroup"
        Me.vencimentoRadioGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.vencimentoRadioGroup.Properties.Appearance.Options.UseBackColor = True
        Me.vencimentoRadioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.vencimentoRadioGroup.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("DIAS", "Dias"), New DevExpress.XtraEditors.Controls.RadioGroupItem("PERIODO", "Período")})
        Me.vencimentoRadioGroup.Size = New System.Drawing.Size(67, 90)
        Me.vencimentoRadioGroup.TabIndex = 13
        '
        'vencimentoSplitContainerControl
        '
        Me.vencimentoSplitContainerControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.vencimentoSplitContainerControl.Location = New System.Drawing.Point(77, 9)
        Me.vencimentoSplitContainerControl.Name = "vencimentoSplitContainerControl"
        Me.vencimentoSplitContainerControl.Panel1.Controls.Add(Me.diaLabelControl)
        Me.vencimentoSplitContainerControl.Panel1.Controls.Add(Me.diasTextEdit)
        Me.vencimentoSplitContainerControl.Panel1.Text = "Panel1"
        Me.vencimentoSplitContainerControl.Panel2.Controls.Add(Me.datafinalDateEdit)
        Me.vencimentoSplitContainerControl.Panel2.Controls.Add(Me.datafinalLabelControl)
        Me.vencimentoSplitContainerControl.Panel2.Controls.Add(Me.datainicialDateEdit)
        Me.vencimentoSplitContainerControl.Panel2.Controls.Add(Me.datainicialLabelControl)
        Me.vencimentoSplitContainerControl.Panel2.Text = "Panel2"
        Me.vencimentoSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
        Me.vencimentoSplitContainerControl.Size = New System.Drawing.Size(107, 90)
        Me.vencimentoSplitContainerControl.TabIndex = 12
        Me.vencimentoSplitContainerControl.Text = "SplitContainerControl1"
        '
        'diaLabelControl
        '
        Me.diaLabelControl.Location = New System.Drawing.Point(3, 3)
        Me.diaLabelControl.Name = "diaLabelControl"
        Me.diaLabelControl.Size = New System.Drawing.Size(20, 13)
        Me.diaLabelControl.TabIndex = 20
        Me.diaLabelControl.Text = "Dias"
        '
        'diasTextEdit
        '
        Me.diasTextEdit.Location = New System.Drawing.Point(3, 20)
        Me.diasTextEdit.Name = "diasTextEdit"
        Me.diasTextEdit.Properties.AutoHeight = False
        Me.diasTextEdit.Size = New System.Drawing.Size(48, 22)
        Me.diasTextEdit.TabIndex = 21
        '
        'datafinalDateEdit
        '
        Me.datafinalDateEdit.EditValue = Nothing
        Me.datafinalDateEdit.Location = New System.Drawing.Point(3, 64)
        Me.datafinalDateEdit.Name = "datafinalDateEdit"
        Me.datafinalDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.datafinalDateEdit.Properties.AutoHeight = False
        Me.datafinalDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Data de Vencimento", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("datafinalDateEdit.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D)), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.datafinalDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.datafinalDateEdit.Properties.Mask.SaveLiteral = False
        Me.datafinalDateEdit.Properties.Mask.ShowPlaceHolders = False
        Me.datafinalDateEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.datafinalDateEdit.Size = New System.Drawing.Size(94, 22)
        Me.datafinalDateEdit.TabIndex = 15
        '
        'datafinalLabelControl
        '
        Me.datafinalLabelControl.Location = New System.Drawing.Point(3, 47)
        Me.datafinalLabelControl.Name = "datafinalLabelControl"
        Me.datafinalLabelControl.Size = New System.Drawing.Size(48, 13)
        Me.datafinalLabelControl.TabIndex = 14
        Me.datafinalLabelControl.Text = "Data Final"
        '
        'datainicialDateEdit
        '
        Me.datainicialDateEdit.EditValue = Nothing
        Me.datainicialDateEdit.Location = New System.Drawing.Point(3, 20)
        Me.datainicialDateEdit.Name = "datainicialDateEdit"
        Me.datainicialDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.datainicialDateEdit.Properties.AutoHeight = False
        Me.datainicialDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Data de Vencimento", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("datainicialDateEdit.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D)), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.datainicialDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.datainicialDateEdit.Properties.Mask.SaveLiteral = False
        Me.datainicialDateEdit.Properties.Mask.ShowPlaceHolders = False
        Me.datainicialDateEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.datainicialDateEdit.Size = New System.Drawing.Size(94, 22)
        Me.datainicialDateEdit.TabIndex = 13
        '
        'datainicialLabelControl
        '
        Me.datainicialLabelControl.Location = New System.Drawing.Point(3, 3)
        Me.datainicialLabelControl.Name = "datainicialLabelControl"
        Me.datainicialLabelControl.Size = New System.Drawing.Size(53, 13)
        Me.datainicialLabelControl.TabIndex = 12
        Me.datainicialLabelControl.Text = "Data Inicial"
        '
        'filtroRadioGroup
        '
        Me.filtroRadioGroup.Location = New System.Drawing.Point(3, 6)
        Me.filtroRadioGroup.Name = "filtroRadioGroup"
        Me.filtroRadioGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.filtroRadioGroup.Properties.Appearance.Options.UseBackColor = True
        Me.filtroRadioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.filtroRadioGroup.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("GERADOR", "Fato Gerador"), New DevExpress.XtraEditors.Controls.RadioGroupItem("VENCIMENTO", "Data de Vencimento")})
        Me.filtroRadioGroup.Size = New System.Drawing.Size(125, 105)
        Me.filtroRadioGroup.TabIndex = 1
        '
        'voltarSimpleButton
        '
        Me.voltarSimpleButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.voltarSimpleButton.Image = CType(resources.GetObject("voltarSimpleButton.Image"), System.Drawing.Image)
        Me.voltarSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.voltarSimpleButton.Location = New System.Drawing.Point(264, 117)
        Me.voltarSimpleButton.Name = "voltarSimpleButton"
        Me.voltarSimpleButton.Size = New System.Drawing.Size(62, 45)
        Me.voltarSimpleButton.TabIndex = 4
        Me.voltarSimpleButton.Text = "Voltar"
        '
        'okSimpleButton
        '
        Me.okSimpleButton.Image = CType(resources.GetObject("okSimpleButton.Image"), System.Drawing.Image)
        Me.okSimpleButton.ImageIndex = 0
        Me.okSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.okSimpleButton.Location = New System.Drawing.Point(198, 117)
        Me.okSimpleButton.Name = "okSimpleButton"
        Me.okSimpleButton.Size = New System.Drawing.Size(62, 45)
        Me.okSimpleButton.TabIndex = 3
        Me.okSimpleButton.Text = "OK"
        '
        'filtroXtraForm
        '
        Me.AcceptButton = Me.okSimpleButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.CancelButton = Me.voltarSimpleButton
        Me.ClientSize = New System.Drawing.Size(331, 165)
        Me.Controls.Add(Me.voltarSimpleButton)
        Me.Controls.Add(Me.okSimpleButton)
        Me.Controls.Add(Me.filtroRadioGroup)
        Me.Controls.Add(Me.filtroSplitContainerControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "filtroXtraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filtrar por:"
        CType(Me.filtroSplitContainerControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.filtroSplitContainerControl.ResumeLayout(False)
        CType(Me.competenciaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vencimentoRadioGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vencimentoSplitContainerControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.vencimentoSplitContainerControl.ResumeLayout(False)
        CType(Me.diasTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datafinalDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datafinalDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datainicialDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datainicialDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.filtroRadioGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents filtroSplitContainerControl As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents filtroRadioGroup As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents competenciaLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents competenciaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents vencimentoSplitContainerControl As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents datafinalDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents datafinalLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents datainicialDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents datainicialLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents diaLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents diasTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents vencimentoRadioGroup As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents voltarSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents okSimpleButton As DevExpress.XtraEditors.SimpleButton
End Class
