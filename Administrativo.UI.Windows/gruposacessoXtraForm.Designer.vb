<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gruposacessoXtraForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gruposacessoXtraForm))
        Me.gruposacessoRibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.incluirBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.alterarBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.excluirBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.localizarBarCheckItem = New DevExpress.XtraBars.BarCheckItem()
        Me.atualizarBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.gruposacessoRibbonPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.gruposacessoRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.gruposacessoSplitContainerControl = New DevExpress.XtraEditors.SplitContainerControl()
        Me.okSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.ImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.voltarSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.gruposacessoPanelControl = New DevExpress.XtraEditors.PanelControl()
        Me.desmarcarSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.marcarSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.grupoacessoTreeList = New DevExpress.XtraTreeList.TreeList()
        Me.grupoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.grupoLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.gruposacessoGridControl = New DevExpress.XtraGrid.GridControl()
        Me.gruposacessoGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gruposacessoinfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.gruposacessoRibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gruposacessoSplitContainerControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gruposacessoSplitContainerControl.SuspendLayout()
        CType(Me.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gruposacessoPanelControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gruposacessoPanelControl.SuspendLayout()
        CType(Me.grupoacessoTreeList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grupoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gruposacessoGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gruposacessoGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gruposacessoinfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gruposacessoRibbonControl
        '
        Me.gruposacessoRibbonControl.ExpandCollapseItem.Id = 0
        Me.gruposacessoRibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.gruposacessoRibbonControl.ExpandCollapseItem, Me.incluirBarButtonItem, Me.alterarBarButtonItem, Me.excluirBarButtonItem, Me.localizarBarCheckItem, Me.atualizarBarButtonItem})
        Me.gruposacessoRibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.gruposacessoRibbonControl.MaxItemId = 6
        Me.gruposacessoRibbonControl.Name = "gruposacessoRibbonControl"
        Me.gruposacessoRibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.gruposacessoRibbonPage})
        Me.gruposacessoRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.gruposacessoRibbonControl.ShowCategoryInCaption = False
        Me.gruposacessoRibbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.gruposacessoRibbonControl.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.gruposacessoRibbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.gruposacessoRibbonControl.ShowToolbarCustomizeItem = False
        Me.gruposacessoRibbonControl.Size = New System.Drawing.Size(854, 96)
        Me.gruposacessoRibbonControl.Toolbar.ShowCustomizeItem = False
        Me.gruposacessoRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'incluirBarButtonItem
        '
        Me.incluirBarButtonItem.Caption = "Incluir"
        Me.incluirBarButtonItem.Glyph = CType(resources.GetObject("incluirBarButtonItem.Glyph"), System.Drawing.Image)
        Me.incluirBarButtonItem.Id = 1
        Me.incluirBarButtonItem.Name = "incluirBarButtonItem"
        Me.incluirBarButtonItem.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        Me.incluirBarButtonItem.Tag = "cadgruinc"
        Me.incluirBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInRuntime
        '
        'alterarBarButtonItem
        '
        Me.alterarBarButtonItem.Caption = "Alterar"
        Me.alterarBarButtonItem.Glyph = CType(resources.GetObject("alterarBarButtonItem.Glyph"), System.Drawing.Image)
        Me.alterarBarButtonItem.Id = 2
        Me.alterarBarButtonItem.Name = "alterarBarButtonItem"
        Me.alterarBarButtonItem.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        Me.alterarBarButtonItem.Tag = "cadgrualt"
        Me.alterarBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInRuntime
        '
        'excluirBarButtonItem
        '
        Me.excluirBarButtonItem.Caption = "Excluir"
        Me.excluirBarButtonItem.Glyph = CType(resources.GetObject("excluirBarButtonItem.Glyph"), System.Drawing.Image)
        Me.excluirBarButtonItem.Id = 3
        Me.excluirBarButtonItem.Name = "excluirBarButtonItem"
        Me.excluirBarButtonItem.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        Me.excluirBarButtonItem.Tag = "cadgruexc"
        Me.excluirBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInRuntime
        '
        'localizarBarCheckItem
        '
        Me.localizarBarCheckItem.Caption = "Localizar"
        Me.localizarBarCheckItem.Glyph = CType(resources.GetObject("localizarBarCheckItem.Glyph"), System.Drawing.Image)
        Me.localizarBarCheckItem.Id = 4
        Me.localizarBarCheckItem.Name = "localizarBarCheckItem"
        Me.localizarBarCheckItem.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'atualizarBarButtonItem
        '
        Me.atualizarBarButtonItem.Caption = "Atualizar"
        Me.atualizarBarButtonItem.Glyph = CType(resources.GetObject("atualizarBarButtonItem.Glyph"), System.Drawing.Image)
        Me.atualizarBarButtonItem.Id = 5
        Me.atualizarBarButtonItem.Name = "atualizarBarButtonItem"
        Me.atualizarBarButtonItem.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'gruposacessoRibbonPage
        '
        Me.gruposacessoRibbonPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.gruposacessoRibbonPageGroup})
        Me.gruposacessoRibbonPage.Name = "gruposacessoRibbonPage"
        Me.gruposacessoRibbonPage.Text = "RibbonPage1"
        '
        'gruposacessoRibbonPageGroup
        '
        Me.gruposacessoRibbonPageGroup.ItemLinks.Add(Me.incluirBarButtonItem)
        Me.gruposacessoRibbonPageGroup.ItemLinks.Add(Me.alterarBarButtonItem)
        Me.gruposacessoRibbonPageGroup.ItemLinks.Add(Me.excluirBarButtonItem)
        Me.gruposacessoRibbonPageGroup.ItemLinks.Add(Me.localizarBarCheckItem)
        Me.gruposacessoRibbonPageGroup.ItemLinks.Add(Me.atualizarBarButtonItem)
        Me.gruposacessoRibbonPageGroup.Name = "gruposacessoRibbonPageGroup"
        Me.gruposacessoRibbonPageGroup.ShowCaptionButton = False
        '
        'gruposacessoSplitContainerControl
        '
        Me.gruposacessoSplitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gruposacessoSplitContainerControl.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None
        Me.gruposacessoSplitContainerControl.Location = New System.Drawing.Point(0, 96)
        Me.gruposacessoSplitContainerControl.Name = "gruposacessoSplitContainerControl"
        Me.gruposacessoSplitContainerControl.Panel1.Controls.Add(Me.okSimpleButton)
        Me.gruposacessoSplitContainerControl.Panel1.Controls.Add(Me.voltarSimpleButton)
        Me.gruposacessoSplitContainerControl.Panel1.Controls.Add(Me.gruposacessoPanelControl)
        Me.gruposacessoSplitContainerControl.Panel2.Controls.Add(Me.gruposacessoGridControl)
        Me.gruposacessoSplitContainerControl.Panel2.Text = "Panel2"
        Me.gruposacessoSplitContainerControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
        Me.gruposacessoSplitContainerControl.Size = New System.Drawing.Size(854, 466)
        Me.gruposacessoSplitContainerControl.SplitterPosition = 116
        Me.gruposacessoSplitContainerControl.TabIndex = 0
        '
        'okSimpleButton
        '
        Me.okSimpleButton.ImageIndex = 0
        Me.okSimpleButton.ImageList = Me.ImageCollection
        Me.okSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.okSimpleButton.Location = New System.Drawing.Point(717, 415)
        Me.okSimpleButton.Name = "okSimpleButton"
        Me.okSimpleButton.Size = New System.Drawing.Size(62, 45)
        Me.okSimpleButton.TabIndex = 1
        Me.okSimpleButton.Text = "OK"
        '
        'ImageCollection
        '
        Me.ImageCollection.ImageSize = New System.Drawing.Size(24, 24)
        Me.ImageCollection.ImageStream = CType(resources.GetObject("ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection.Images.SetKeyName(0, "disk_blue.png")
        Me.ImageCollection.Images.SetKeyName(1, "delete.png")
        Me.ImageCollection.Images.SetKeyName(2, "lock.png")
        Me.ImageCollection.Images.SetKeyName(3, "lock_open.png")
        '
        'voltarSimpleButton
        '
        Me.voltarSimpleButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.voltarSimpleButton.Image = CType(resources.GetObject("voltarSimpleButton.Image"), System.Drawing.Image)
        Me.voltarSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.voltarSimpleButton.Location = New System.Drawing.Point(785, 415)
        Me.voltarSimpleButton.Name = "voltarSimpleButton"
        Me.voltarSimpleButton.Size = New System.Drawing.Size(62, 45)
        Me.voltarSimpleButton.TabIndex = 2
        Me.voltarSimpleButton.Text = "Voltar"
        '
        'gruposacessoPanelControl
        '
        Me.gruposacessoPanelControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.gruposacessoPanelControl.Controls.Add(Me.desmarcarSimpleButton)
        Me.gruposacessoPanelControl.Controls.Add(Me.marcarSimpleButton)
        Me.gruposacessoPanelControl.Controls.Add(Me.grupoacessoTreeList)
        Me.gruposacessoPanelControl.Controls.Add(Me.grupoTextEdit)
        Me.gruposacessoPanelControl.Controls.Add(Me.grupoLabelControl)
        Me.gruposacessoPanelControl.Location = New System.Drawing.Point(4, 3)
        Me.gruposacessoPanelControl.Name = "gruposacessoPanelControl"
        Me.gruposacessoPanelControl.Size = New System.Drawing.Size(843, 405)
        Me.gruposacessoPanelControl.TabIndex = 0
        '
        'desmarcarSimpleButton
        '
        Me.desmarcarSimpleButton.Image = CType(resources.GetObject("desmarcarSimpleButton.Image"), System.Drawing.Image)
        Me.desmarcarSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.desmarcarSimpleButton.Location = New System.Drawing.Point(798, 6)
        Me.desmarcarSimpleButton.Name = "desmarcarSimpleButton"
        Me.desmarcarSimpleButton.Size = New System.Drawing.Size(38, 32)
        Me.desmarcarSimpleButton.TabIndex = 4
        '
        'marcarSimpleButton
        '
        Me.marcarSimpleButton.Image = CType(resources.GetObject("marcarSimpleButton.Image"), System.Drawing.Image)
        Me.marcarSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.marcarSimpleButton.Location = New System.Drawing.Point(754, 6)
        Me.marcarSimpleButton.Name = "marcarSimpleButton"
        Me.marcarSimpleButton.Size = New System.Drawing.Size(38, 32)
        Me.marcarSimpleButton.TabIndex = 3
        '
        'grupoacessoTreeList
        '
        Me.grupoacessoTreeList.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.grupoacessoTreeList.Location = New System.Drawing.Point(8, 44)
        Me.grupoacessoTreeList.Name = "grupoacessoTreeList"
        Me.grupoacessoTreeList.OptionsBehavior.Editable = False
        Me.grupoacessoTreeList.Size = New System.Drawing.Size(830, 354)
        Me.grupoacessoTreeList.TabIndex = 2
        '
        'grupoTextEdit
        '
        Me.grupoTextEdit.Location = New System.Drawing.Point(6, 19)
        Me.grupoTextEdit.MenuManager = Me.gruposacessoRibbonControl
        Me.grupoTextEdit.Name = "grupoTextEdit"
        Me.grupoTextEdit.Properties.MaxLength = 10
        Me.grupoTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.grupoTextEdit.TabIndex = 1
        '
        'grupoLabelControl
        '
        Me.grupoLabelControl.Location = New System.Drawing.Point(6, 3)
        Me.grupoLabelControl.Name = "grupoLabelControl"
        Me.grupoLabelControl.Size = New System.Drawing.Size(29, 13)
        Me.grupoLabelControl.TabIndex = 0
        Me.grupoLabelControl.Text = "Grupo"
        '
        'gruposacessoGridControl
        '
        Me.gruposacessoGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gruposacessoGridControl.Location = New System.Drawing.Point(0, 0)
        Me.gruposacessoGridControl.MainView = Me.gruposacessoGridView
        Me.gruposacessoGridControl.MenuManager = Me.gruposacessoRibbonControl
        Me.gruposacessoGridControl.Name = "gruposacessoGridControl"
        Me.gruposacessoGridControl.Size = New System.Drawing.Size(0, 0)
        Me.gruposacessoGridControl.TabIndex = 0
        Me.gruposacessoGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gruposacessoGridView})
        '
        'gruposacessoGridView
        '
        Me.gruposacessoGridView.GridControl = Me.gruposacessoGridControl
        Me.gruposacessoGridView.Name = "gruposacessoGridView"
        Me.gruposacessoGridView.OptionsBehavior.Editable = False
        Me.gruposacessoGridView.OptionsCustomization.AllowColumnMoving = False
        Me.gruposacessoGridView.OptionsCustomization.AllowColumnResizing = False
        Me.gruposacessoGridView.OptionsCustomization.AllowGroup = False
        Me.gruposacessoGridView.OptionsCustomization.AllowQuickHideColumns = False
        Me.gruposacessoGridView.OptionsView.ColumnAutoWidth = False
        Me.gruposacessoGridView.OptionsView.ShowGroupPanel = False
        '
        'gruposacessoXtraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.CancelButton = Me.voltarSimpleButton
        Me.ClientSize = New System.Drawing.Size(854, 562)
        Me.Controls.Add(Me.gruposacessoSplitContainerControl)
        Me.Controls.Add(Me.gruposacessoRibbonControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "gruposacessoXtraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Grupos de Acessos"
        CType(Me.gruposacessoRibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gruposacessoSplitContainerControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gruposacessoSplitContainerControl.ResumeLayout(False)
        CType(Me.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gruposacessoPanelControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gruposacessoPanelControl.ResumeLayout(False)
        Me.gruposacessoPanelControl.PerformLayout()
        CType(Me.grupoacessoTreeList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grupoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gruposacessoGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gruposacessoGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gruposacessoinfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gruposacessoRibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents incluirBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents alterarBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents excluirBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents localizarBarCheckItem As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents gruposacessoRibbonPage As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents gruposacessoRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents gruposacessoSplitContainerControl As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents okSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents voltarSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gruposacessoPanelControl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grupoacessoTreeList As DevExpress.XtraTreeList.TreeList
    Friend WithEvents grupoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents grupoLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gruposacessoGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents gruposacessoGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ImageCollection As DevExpress.Utils.ImageCollection
    Friend WithEvents gruposacessoinfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents desmarcarSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents marcarSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents atualizarBarButtonItem As DevExpress.XtraBars.BarButtonItem
End Class
