<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class feriadosdetalheXtraForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(feriadosdetalheXtraForm))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.filtroGroupControl = New DevExpress.XtraEditors.GroupControl()
        Me.feriadoSplitContainerControl = New DevExpress.XtraEditors.SplitContainerControl()
        Me.filtrodescTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.filtroSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.filtroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.filtroGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.filtroLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.feriadoGridControl = New DevExpress.XtraGrid.GridControl()
        Me.feriadoGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.filtroPanelControl = New DevExpress.XtraEditors.PanelControl()
        Me.voltarvariacaoSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.confirmarvariacaoSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.ImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.excluirvariacaoSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.alterarvariacaoSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.incluirvariacaoSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.voltarSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.okSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.feriadosPanelControl = New DevExpress.XtraEditors.PanelControl()
        Me.descricaoLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.descricaoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.tipoferiadoLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.tipoferiadoComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.mesLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.mesComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.diaLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.diaTextEdit = New DevExpress.XtraEditors.TextEdit()
        CType(Me.filtroGroupControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.filtroGroupControl.SuspendLayout()
        CType(Me.feriadoSplitContainerControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.feriadoSplitContainerControl.SuspendLayout()
        CType(Me.filtrodescTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.filtroSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.filtroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.filtroGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.feriadoGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.feriadoGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.filtroPanelControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.filtroPanelControl.SuspendLayout()
        CType(Me.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.feriadosPanelControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.feriadosPanelControl.SuspendLayout()
        CType(Me.descricaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tipoferiadoComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mesComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.diaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'filtroGroupControl
        '
        Me.filtroGroupControl.Controls.Add(Me.feriadoSplitContainerControl)
        Me.filtroGroupControl.Controls.Add(Me.filtroPanelControl)
        Me.filtroGroupControl.Location = New System.Drawing.Point(6, 103)
        Me.filtroGroupControl.Name = "filtroGroupControl"
        Me.filtroGroupControl.Size = New System.Drawing.Size(538, 241)
        Me.filtroGroupControl.TabIndex = 1
        Me.filtroGroupControl.Text = "Relação de Munícipios"
        '
        'feriadoSplitContainerControl
        '
        Me.feriadoSplitContainerControl.Location = New System.Drawing.Point(5, 70)
        Me.feriadoSplitContainerControl.Name = "feriadoSplitContainerControl"
        Me.feriadoSplitContainerControl.Panel1.Controls.Add(Me.filtrodescTextEdit)
        Me.feriadoSplitContainerControl.Panel1.Controls.Add(Me.filtroSearchLookUpEdit)
        Me.feriadoSplitContainerControl.Panel1.Controls.Add(Me.filtroLabelControl)
        Me.feriadoSplitContainerControl.Panel2.Controls.Add(Me.feriadoGridControl)
        Me.feriadoSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
        Me.feriadoSplitContainerControl.Size = New System.Drawing.Size(526, 164)
        Me.feriadoSplitContainerControl.TabIndex = 1
        '
        'filtrodescTextEdit
        '
        Me.filtrodescTextEdit.Enabled = False
        Me.filtrodescTextEdit.Location = New System.Drawing.Point(110, 25)
        Me.filtrodescTextEdit.Name = "filtrodescTextEdit"
        Me.filtrodescTextEdit.Properties.AutoHeight = False
        Me.filtrodescTextEdit.Size = New System.Drawing.Size(412, 22)
        Me.filtrodescTextEdit.TabIndex = 2
        '
        'filtroSearchLookUpEdit
        '
        Me.filtroSearchLookUpEdit.Location = New System.Drawing.Point(6, 25)
        Me.filtroSearchLookUpEdit.Name = "filtroSearchLookUpEdit"
        Me.filtroSearchLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.filtroSearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("filtroSearchLookUpEdit.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.filtroSearchLookUpEdit.Properties.DataSource = Me.filtroBindingSource
        Me.filtroSearchLookUpEdit.Properties.NullText = ""
        Me.filtroSearchLookUpEdit.Properties.View = Me.filtroGridView
        Me.filtroSearchLookUpEdit.Size = New System.Drawing.Size(100, 22)
        Me.filtroSearchLookUpEdit.TabIndex = 1
        '
        'filtroGridView
        '
        Me.filtroGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.filtroGridView.Name = "filtroGridView"
        Me.filtroGridView.OptionsFind.AlwaysVisible = True
        Me.filtroGridView.OptionsFind.SearchInPreview = True
        Me.filtroGridView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.filtroGridView.OptionsView.ShowGroupPanel = False
        '
        'filtroLabelControl
        '
        Me.filtroLabelControl.Location = New System.Drawing.Point(6, 8)
        Me.filtroLabelControl.Name = "filtroLabelControl"
        Me.filtroLabelControl.Size = New System.Drawing.Size(43, 13)
        Me.filtroLabelControl.TabIndex = 0
        Me.filtroLabelControl.Text = "Munícipio"
        '
        'feriadoGridControl
        '
        Me.feriadoGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.feriadoGridControl.Location = New System.Drawing.Point(0, 0)
        Me.feriadoGridControl.MainView = Me.feriadoGridView
        Me.feriadoGridControl.Name = "feriadoGridControl"
        Me.feriadoGridControl.Size = New System.Drawing.Size(0, 0)
        Me.feriadoGridControl.TabIndex = 1
        Me.feriadoGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.feriadoGridView})
        '
        'feriadoGridView
        '
        Me.feriadoGridView.GridControl = Me.feriadoGridControl
        Me.feriadoGridView.Name = "feriadoGridView"
        Me.feriadoGridView.OptionsBehavior.Editable = False
        Me.feriadoGridView.OptionsCustomization.AllowColumnMoving = False
        Me.feriadoGridView.OptionsCustomization.AllowColumnResizing = False
        Me.feriadoGridView.OptionsCustomization.AllowGroup = False
        Me.feriadoGridView.OptionsCustomization.AllowQuickHideColumns = False
        Me.feriadoGridView.OptionsView.ShowGroupPanel = False
        '
        'filtroPanelControl
        '
        Me.filtroPanelControl.Controls.Add(Me.voltarvariacaoSimpleButton)
        Me.filtroPanelControl.Controls.Add(Me.confirmarvariacaoSimpleButton)
        Me.filtroPanelControl.Controls.Add(Me.excluirvariacaoSimpleButton)
        Me.filtroPanelControl.Controls.Add(Me.alterarvariacaoSimpleButton)
        Me.filtroPanelControl.Controls.Add(Me.incluirvariacaoSimpleButton)
        Me.filtroPanelControl.Location = New System.Drawing.Point(5, 25)
        Me.filtroPanelControl.Name = "filtroPanelControl"
        Me.filtroPanelControl.Size = New System.Drawing.Size(528, 39)
        Me.filtroPanelControl.TabIndex = 0
        '
        'voltarvariacaoSimpleButton
        '
        Me.voltarvariacaoSimpleButton.Image = CType(resources.GetObject("voltarvariacaoSimpleButton.Image"), System.Drawing.Image)
        Me.voltarvariacaoSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.voltarvariacaoSimpleButton.Location = New System.Drawing.Point(491, 6)
        Me.voltarvariacaoSimpleButton.Name = "voltarvariacaoSimpleButton"
        Me.voltarvariacaoSimpleButton.Size = New System.Drawing.Size(30, 27)
        Me.voltarvariacaoSimpleButton.TabIndex = 4
        '
        'confirmarvariacaoSimpleButton
        '
        Me.confirmarvariacaoSimpleButton.ImageIndex = 2
        Me.confirmarvariacaoSimpleButton.ImageList = Me.ImageCollection
        Me.confirmarvariacaoSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.confirmarvariacaoSimpleButton.Location = New System.Drawing.Point(457, 6)
        Me.confirmarvariacaoSimpleButton.Name = "confirmarvariacaoSimpleButton"
        Me.confirmarvariacaoSimpleButton.Size = New System.Drawing.Size(30, 27)
        Me.confirmarvariacaoSimpleButton.TabIndex = 3
        '
        'ImageCollection
        '
        Me.ImageCollection.ImageSize = New System.Drawing.Size(24, 24)
        Me.ImageCollection.ImageStream = CType(resources.GetObject("ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection.Images.SetKeyName(0, "disk_blue.png")
        Me.ImageCollection.Images.SetKeyName(1, "delete.png")
        Me.ImageCollection.Images.SetKeyName(2, "disk_blue_ok.png")
        Me.ImageCollection.Images.SetKeyName(3, "disk_blue_error.png")
        '
        'excluirvariacaoSimpleButton
        '
        Me.excluirvariacaoSimpleButton.Image = CType(resources.GetObject("excluirvariacaoSimpleButton.Image"), System.Drawing.Image)
        Me.excluirvariacaoSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.excluirvariacaoSimpleButton.Location = New System.Drawing.Point(72, 6)
        Me.excluirvariacaoSimpleButton.Name = "excluirvariacaoSimpleButton"
        Me.excluirvariacaoSimpleButton.Size = New System.Drawing.Size(30, 27)
        Me.excluirvariacaoSimpleButton.TabIndex = 2
        '
        'alterarvariacaoSimpleButton
        '
        Me.alterarvariacaoSimpleButton.Image = CType(resources.GetObject("alterarvariacaoSimpleButton.Image"), System.Drawing.Image)
        Me.alterarvariacaoSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.alterarvariacaoSimpleButton.Location = New System.Drawing.Point(39, 6)
        Me.alterarvariacaoSimpleButton.Name = "alterarvariacaoSimpleButton"
        Me.alterarvariacaoSimpleButton.Size = New System.Drawing.Size(30, 27)
        Me.alterarvariacaoSimpleButton.TabIndex = 1
        '
        'incluirvariacaoSimpleButton
        '
        Me.incluirvariacaoSimpleButton.Image = CType(resources.GetObject("incluirvariacaoSimpleButton.Image"), System.Drawing.Image)
        Me.incluirvariacaoSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.incluirvariacaoSimpleButton.Location = New System.Drawing.Point(6, 6)
        Me.incluirvariacaoSimpleButton.Name = "incluirvariacaoSimpleButton"
        Me.incluirvariacaoSimpleButton.Size = New System.Drawing.Size(30, 27)
        Me.incluirvariacaoSimpleButton.TabIndex = 0
        '
        'voltarSimpleButton
        '
        Me.voltarSimpleButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.voltarSimpleButton.Image = CType(resources.GetObject("voltarSimpleButton.Image"), System.Drawing.Image)
        Me.voltarSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.voltarSimpleButton.Location = New System.Drawing.Point(482, 350)
        Me.voltarSimpleButton.Name = "voltarSimpleButton"
        Me.voltarSimpleButton.Size = New System.Drawing.Size(62, 45)
        Me.voltarSimpleButton.TabIndex = 3
        Me.voltarSimpleButton.Text = "Voltar"
        '
        'okSimpleButton
        '
        Me.okSimpleButton.ImageIndex = 0
        Me.okSimpleButton.ImageList = Me.ImageCollection
        Me.okSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.okSimpleButton.Location = New System.Drawing.Point(416, 350)
        Me.okSimpleButton.Name = "okSimpleButton"
        Me.okSimpleButton.Size = New System.Drawing.Size(62, 45)
        Me.okSimpleButton.TabIndex = 2
        Me.okSimpleButton.Text = "OK"
        '
        'feriadosPanelControl
        '
        Me.feriadosPanelControl.Controls.Add(Me.descricaoLabelControl)
        Me.feriadosPanelControl.Controls.Add(Me.descricaoTextEdit)
        Me.feriadosPanelControl.Controls.Add(Me.tipoferiadoLabelControl)
        Me.feriadosPanelControl.Controls.Add(Me.tipoferiadoComboBoxEdit)
        Me.feriadosPanelControl.Controls.Add(Me.mesLabelControl)
        Me.feriadosPanelControl.Controls.Add(Me.mesComboBoxEdit)
        Me.feriadosPanelControl.Controls.Add(Me.diaLabelControl)
        Me.feriadosPanelControl.Controls.Add(Me.diaTextEdit)
        Me.feriadosPanelControl.Location = New System.Drawing.Point(6, 6)
        Me.feriadosPanelControl.Name = "feriadosPanelControl"
        Me.feriadosPanelControl.Size = New System.Drawing.Size(538, 91)
        Me.feriadosPanelControl.TabIndex = 0
        '
        'descricaoLabelControl
        '
        Me.descricaoLabelControl.Location = New System.Drawing.Point(6, 8)
        Me.descricaoLabelControl.Name = "descricaoLabelControl"
        Me.descricaoLabelControl.Size = New System.Drawing.Size(46, 13)
        Me.descricaoLabelControl.TabIndex = 0
        Me.descricaoLabelControl.Text = "Descrição"
        '
        'descricaoTextEdit
        '
        Me.descricaoTextEdit.EditValue = ""
        Me.descricaoTextEdit.Location = New System.Drawing.Point(6, 25)
        Me.descricaoTextEdit.Name = "descricaoTextEdit"
        Me.descricaoTextEdit.Properties.MaxLength = 100
        Me.descricaoTextEdit.Size = New System.Drawing.Size(527, 20)
        Me.descricaoTextEdit.TabIndex = 1
        '
        'tipoferiadoLabelControl
        '
        Me.tipoferiadoLabelControl.Location = New System.Drawing.Point(123, 51)
        Me.tipoferiadoLabelControl.Name = "tipoferiadoLabelControl"
        Me.tipoferiadoLabelControl.Size = New System.Drawing.Size(59, 13)
        Me.tipoferiadoLabelControl.TabIndex = 6
        Me.tipoferiadoLabelControl.Text = "Tipo Feriado"
        '
        'tipoferiadoComboBoxEdit
        '
        Me.tipoferiadoComboBoxEdit.EditValue = ""
        Me.tipoferiadoComboBoxEdit.Location = New System.Drawing.Point(122, 66)
        Me.tipoferiadoComboBoxEdit.Name = "tipoferiadoComboBoxEdit"
        Me.tipoferiadoComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tipoferiadoComboBoxEdit.Properties.Items.AddRange(New Object() {"Municipal", "Estadual", "Federal"})
        Me.tipoferiadoComboBoxEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.tipoferiadoComboBoxEdit.Size = New System.Drawing.Size(70, 20)
        Me.tipoferiadoComboBoxEdit.TabIndex = 7
        '
        'mesLabelControl
        '
        Me.mesLabelControl.Location = New System.Drawing.Point(45, 51)
        Me.mesLabelControl.Name = "mesLabelControl"
        Me.mesLabelControl.Size = New System.Drawing.Size(19, 13)
        Me.mesLabelControl.TabIndex = 4
        Me.mesLabelControl.Text = "Mês"
        '
        'mesComboBoxEdit
        '
        Me.mesComboBoxEdit.EditValue = ""
        Me.mesComboBoxEdit.Location = New System.Drawing.Point(44, 66)
        Me.mesComboBoxEdit.Name = "mesComboBoxEdit"
        Me.mesComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.mesComboBoxEdit.Properties.Items.AddRange(New Object() {"Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"})
        Me.mesComboBoxEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.mesComboBoxEdit.Size = New System.Drawing.Size(73, 20)
        Me.mesComboBoxEdit.TabIndex = 5
        '
        'diaLabelControl
        '
        Me.diaLabelControl.Location = New System.Drawing.Point(6, 51)
        Me.diaLabelControl.Name = "diaLabelControl"
        Me.diaLabelControl.Size = New System.Drawing.Size(15, 13)
        Me.diaLabelControl.TabIndex = 2
        Me.diaLabelControl.Text = "Dia"
        '
        'diaTextEdit
        '
        Me.diaTextEdit.Location = New System.Drawing.Point(6, 66)
        Me.diaTextEdit.Name = "diaTextEdit"
        Me.diaTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.diaTextEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.diaTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.diaTextEdit.Properties.MaxLength = 2
        Me.diaTextEdit.Size = New System.Drawing.Size(30, 20)
        Me.diaTextEdit.TabIndex = 3
        '
        'feriadosdetalheXtraForm
        '
        Me.AcceptButton = Me.okSimpleButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.voltarSimpleButton
        Me.ClientSize = New System.Drawing.Size(548, 398)
        Me.Controls.Add(Me.feriadosPanelControl)
        Me.Controls.Add(Me.voltarSimpleButton)
        Me.Controls.Add(Me.okSimpleButton)
        Me.Controls.Add(Me.filtroGroupControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "feriadosdetalheXtraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Feriados"
        CType(Me.filtroGroupControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.filtroGroupControl.ResumeLayout(False)
        CType(Me.feriadoSplitContainerControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.feriadoSplitContainerControl.ResumeLayout(False)
        CType(Me.filtrodescTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.filtroSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.filtroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.filtroGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.feriadoGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.feriadoGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.filtroPanelControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.filtroPanelControl.ResumeLayout(False)
        CType(Me.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.feriadosPanelControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.feriadosPanelControl.ResumeLayout(False)
        Me.feriadosPanelControl.PerformLayout()
        CType(Me.descricaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tipoferiadoComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mesComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.diaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents filtroGroupControl As DevExpress.XtraEditors.GroupControl
    Friend WithEvents feriadoSplitContainerControl As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents feriadoGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents feriadoGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents filtroPanelControl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents voltarvariacaoSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents confirmarvariacaoSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ImageCollection As DevExpress.Utils.ImageCollection
    Friend WithEvents excluirvariacaoSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents alterarvariacaoSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents incluirvariacaoSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents filtrodescTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents filtroSearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents filtroBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents filtroGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents filtroLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents voltarSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents okSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents feriadosPanelControl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents descricaoLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents descricaoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tipoferiadoLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tipoferiadoComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents mesLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents mesComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents diaLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents diaTextEdit As DevExpress.XtraEditors.TextEdit
End Class
