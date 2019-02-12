<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class regrasXtraReport
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.vDescricao_emp_obrXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.vcodigo_emp_obrXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.vRegraXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.cabecalhoXrLine = New DevExpress.XtraReports.UI.XRLine()
        Me.DataXrPageInfo = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.cTituloXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.pSistemaXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.Sistema = New DevExpress.XtraReports.Parameters.Parameter()
        Me.rodapeXrLine = New DevExpress.XtraReports.UI.XRLine()
        Me.NroPaginaXrPageInfo = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.tipoGroupHeader = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.vTipoXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.vDescricaoXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.regraGroupHeader = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
        Me.cRegraXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.regrasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.regrasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.vDescricao_emp_obrXrLabel, Me.vcodigo_emp_obrXrLabel})
        Me.Detail.Dpi = 100.0!
        Me.Detail.HeightF = 30.29169!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'vDescricao_emp_obrXrLabel
        '
        Me.vDescricao_emp_obrXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "descricao_emp_obr")})
        Me.vDescricao_emp_obrXrLabel.Dpi = 100.0!
        Me.vDescricao_emp_obrXrLabel.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.vDescricao_emp_obrXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(99.99998!, 4.291681!)
        Me.vDescricao_emp_obrXrLabel.Name = "vDescricao_emp_obrXrLabel"
        Me.vDescricao_emp_obrXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.vDescricao_emp_obrXrLabel.SizeF = New System.Drawing.SizeF(661.0!, 23.0!)
        Me.vDescricao_emp_obrXrLabel.StylePriority.UseFont = False
        Me.vDescricao_emp_obrXrLabel.Text = "vDescricao_emp_obrXrLabel"
        '
        'vcodigo_emp_obrXrLabel
        '
        Me.vcodigo_emp_obrXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "codigo_emp_obr")})
        Me.vcodigo_emp_obrXrLabel.Dpi = 100.0!
        Me.vcodigo_emp_obrXrLabel.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.vcodigo_emp_obrXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(0!, 4.291691!)
        Me.vcodigo_emp_obrXrLabel.Name = "vcodigo_emp_obrXrLabel"
        Me.vcodigo_emp_obrXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.vcodigo_emp_obrXrLabel.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.vcodigo_emp_obrXrLabel.StylePriority.UseFont = False
        Me.vcodigo_emp_obrXrLabel.Text = "vcodigo_emp_obrXrLabel"
        '
        'vRegraXrLabel
        '
        Me.vRegraXrLabel.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.vRegraXrLabel.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.vRegraXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "regra")})
        Me.vRegraXrLabel.Dpi = 100.0!
        Me.vRegraXrLabel.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.vRegraXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(63.12504!, 4.666672!)
        Me.vRegraXrLabel.Name = "vRegraXrLabel"
        Me.vRegraXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.vRegraXrLabel.SizeF = New System.Drawing.SizeF(60.41666!, 23.0!)
        Me.vRegraXrLabel.StylePriority.UseBorderDashStyle = False
        Me.vRegraXrLabel.StylePriority.UseBorders = False
        Me.vRegraXrLabel.StylePriority.UseFont = False
        Me.vRegraXrLabel.Text = "vRegraXrLabel"
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.cabecalhoXrLine, Me.DataXrPageInfo, Me.cTituloXrLabel})
        Me.TopMargin.Dpi = 100.0!
        Me.TopMargin.HeightF = 73.00641!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'cabecalhoXrLine
        '
        Me.cabecalhoXrLine.Dpi = 100.0!
        Me.cabecalhoXrLine.LocationFloat = New DevExpress.Utils.PointFloat(0!, 63.32999!)
        Me.cabecalhoXrLine.Name = "cabecalhoXrLine"
        Me.cabecalhoXrLine.SizeF = New System.Drawing.SizeF(758.96!, 8.42!)
        '
        'DataXrPageInfo
        '
        Me.DataXrPageInfo.Dpi = 100.0!
        Me.DataXrPageInfo.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.DataXrPageInfo.Format = "{0:dd/MM/yyyy HH:mm}"
        Me.DataXrPageInfo.LocationFloat = New DevExpress.Utils.PointFloat(637.0416!, 41.32999!)
        Me.DataXrPageInfo.Name = "DataXrPageInfo"
        Me.DataXrPageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.DataXrPageInfo.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.DataXrPageInfo.SizeF = New System.Drawing.SizeF(123.9584!, 22.0!)
        Me.DataXrPageInfo.StylePriority.UseFont = False
        Me.DataXrPageInfo.StylePriority.UseTextAlignment = False
        Me.DataXrPageInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'cTituloXrLabel
        '
        Me.cTituloXrLabel.Dpi = 100.0!
        Me.cTituloXrLabel.Font = New System.Drawing.Font("Verdana", 14.0!, System.Drawing.FontStyle.Bold)
        Me.cTituloXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(0!, 9.999996!)
        Me.cTituloXrLabel.Name = "cTituloXrLabel"
        Me.cTituloXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.cTituloXrLabel.SizeF = New System.Drawing.SizeF(761.0!, 31.33001!)
        Me.cTituloXrLabel.StylePriority.UseFont = False
        Me.cTituloXrLabel.StylePriority.UseTextAlignment = False
        Me.cTituloXrLabel.Text = "Relatório de Regras"
        Me.cTituloXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pSistemaXrLabel, Me.rodapeXrLine, Me.NroPaginaXrPageInfo})
        Me.BottomMargin.Dpi = 100.0!
        Me.BottomMargin.HeightF = 37.20829!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'pSistemaXrLabel
        '
        Me.pSistemaXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.Sistema, "Text", "")})
        Me.pSistemaXrLabel.Dpi = 100.0!
        Me.pSistemaXrLabel.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.pSistemaXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(0!, 8.416668!)
        Me.pSistemaXrLabel.Name = "pSistemaXrLabel"
        Me.pSistemaXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.pSistemaXrLabel.SizeF = New System.Drawing.SizeF(304.5834!, 23.0!)
        Me.pSistemaXrLabel.StylePriority.UseFont = False
        Me.pSistemaXrLabel.Text = "pSistemaXrLabel"
        '
        'Sistema
        '
        Me.Sistema.Description = "Sistema"
        Me.Sistema.Name = "Sistema"
        '
        'rodapeXrLine
        '
        Me.rodapeXrLine.Dpi = 100.0!
        Me.rodapeXrLine.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.rodapeXrLine.Name = "rodapeXrLine"
        Me.rodapeXrLine.SizeF = New System.Drawing.SizeF(761.0!, 8.416668!)
        '
        'NroPaginaXrPageInfo
        '
        Me.NroPaginaXrPageInfo.Dpi = 100.0!
        Me.NroPaginaXrPageInfo.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.NroPaginaXrPageInfo.LocationFloat = New DevExpress.Utils.PointFloat(661.0!, 8.416668!)
        Me.NroPaginaXrPageInfo.Name = "NroPaginaXrPageInfo"
        Me.NroPaginaXrPageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.NroPaginaXrPageInfo.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.NroPaginaXrPageInfo.StylePriority.UseFont = False
        Me.NroPaginaXrPageInfo.StylePriority.UseTextAlignment = False
        Me.NroPaginaXrPageInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'tipoGroupHeader
        '
        Me.tipoGroupHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.vTipoXrLabel})
        Me.tipoGroupHeader.Dpi = 100.0!
        Me.tipoGroupHeader.HeightF = 29.62878!
        Me.tipoGroupHeader.KeepTogether = True
        Me.tipoGroupHeader.Name = "tipoGroupHeader"
        Me.tipoGroupHeader.RepeatEveryPage = True
        '
        'vTipoXrLabel
        '
        Me.vTipoXrLabel.AutoWidth = True
        Me.vTipoXrLabel.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.vTipoXrLabel.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.vTipoXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "tipo")})
        Me.vTipoXrLabel.Dpi = 100.0!
        Me.vTipoXrLabel.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.vTipoXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(0!, 3.000015!)
        Me.vTipoXrLabel.Name = "vTipoXrLabel"
        Me.vTipoXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.vTipoXrLabel.Scripts.OnBeforePrint = "vTipoXrLabel_BeforePrint"
        Me.vTipoXrLabel.SizeF = New System.Drawing.SizeF(761.0!, 23.0!)
        Me.vTipoXrLabel.StylePriority.UseBorderDashStyle = False
        Me.vTipoXrLabel.StylePriority.UseBorders = False
        Me.vTipoXrLabel.StylePriority.UseFont = False
        Me.vTipoXrLabel.Text = "vTipoXrLabel"
        '
        'vDescricaoXrLabel
        '
        Me.vDescricaoXrLabel.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.vDescricaoXrLabel.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.vDescricaoXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "descricao")})
        Me.vDescricaoXrLabel.Dpi = 100.0!
        Me.vDescricaoXrLabel.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.vDescricaoXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(123.5417!, 4.666671!)
        Me.vDescricaoXrLabel.Name = "vDescricaoXrLabel"
        Me.vDescricaoXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.vDescricaoXrLabel.SizeF = New System.Drawing.SizeF(633.4583!, 23.0!)
        Me.vDescricaoXrLabel.StylePriority.UseBorderDashStyle = False
        Me.vDescricaoXrLabel.StylePriority.UseBorders = False
        Me.vDescricaoXrLabel.StylePriority.UseFont = False
        Me.vDescricaoXrLabel.Text = "vDescricaoXrLabel"
        '
        'regraGroupHeader
        '
        Me.regraGroupHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPanel1})
        Me.regraGroupHeader.Dpi = 100.0!
        Me.regraGroupHeader.HeightF = 31.66667!
        Me.regraGroupHeader.KeepTogether = True
        Me.regraGroupHeader.Level = 1
        Me.regraGroupHeader.Name = "regraGroupHeader"
        Me.regraGroupHeader.RepeatEveryPage = True
        '
        'XrPanel1
        '
        Me.XrPanel1.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
        Me.XrPanel1.BackColor = System.Drawing.Color.Transparent
        Me.XrPanel1.BorderColor = System.Drawing.Color.Black
        Me.XrPanel1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash
        Me.XrPanel1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.cRegraXrLabel, Me.vRegraXrLabel, Me.vDescricaoXrLabel})
        Me.XrPanel1.Dpi = 100.0!
        Me.XrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrPanel1.Name = "XrPanel1"
        Me.XrPanel1.SizeF = New System.Drawing.SizeF(761.0!, 31.66667!)
        Me.XrPanel1.StylePriority.UseBackColor = False
        Me.XrPanel1.StylePriority.UseBorderColor = False
        Me.XrPanel1.StylePriority.UseBorderDashStyle = False
        Me.XrPanel1.StylePriority.UseBorders = False
        '
        'cRegraXrLabel
        '
        Me.cRegraXrLabel.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.cRegraXrLabel.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.cRegraXrLabel.Dpi = 100.0!
        Me.cRegraXrLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cRegraXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(2.000015!, 4.666671!)
        Me.cRegraXrLabel.Name = "cRegraXrLabel"
        Me.cRegraXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.cRegraXrLabel.SizeF = New System.Drawing.SizeF(61.12502!, 23.0!)
        Me.cRegraXrLabel.StylePriority.UseBorderDashStyle = False
        Me.cRegraXrLabel.StylePriority.UseBorders = False
        Me.cRegraXrLabel.StylePriority.UseFont = False
        Me.cRegraXrLabel.Text = "Regra:"
        '
        'regrasXtraReport
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.tipoGroupHeader, Me.regraGroupHeader})
        Me.DataSource = Me.regrasBindingSource
        Me.Margins = New System.Drawing.Printing.Margins(47, 42, 73, 37)
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.Sistema})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "16.2"
        CType(Me.regrasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents regrasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sistema As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents NroPaginaXrPageInfo As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents DataXrPageInfo As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents cTituloXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents vRegraXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents tipoGroupHeader As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents regraGroupHeader As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents vDescricaoXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents vTipoXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents vDescricao_emp_obrXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents vcodigo_emp_obrXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents cRegraXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPanel1 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents cabecalhoXrLine As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents rodapeXrLine As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents pSistemaXrLabel As DevExpress.XtraReports.UI.XRLabel
End Class
