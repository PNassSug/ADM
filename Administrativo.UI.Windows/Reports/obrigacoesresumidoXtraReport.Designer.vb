<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class obrigacoesresumidoXtraReport
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(obrigacoesresumidoXtraReport))
        Me.obrigacaoDetail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.vObrigacaoXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.vDescricaoXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.vSistemaXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.cSistemaXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.cDescricaoXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.cObrigacaoXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.cabecalhoXrLine = New DevExpress.XtraReports.UI.XRLine()
        Me.DataXrPageInfo = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.cTituloXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.pSistemaXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.Sistema = New DevExpress.XtraReports.Parameters.Parameter()
        Me.NroPaginaXrPageInfo = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.rodapeXrLine = New DevExpress.XtraReports.UI.XRLine()
        Me.obrigacoesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.obrigacoesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'obrigacaoDetail
        '
        Me.obrigacaoDetail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine1, Me.vObrigacaoXrLabel, Me.vDescricaoXrLabel, Me.vSistemaXrLabel, Me.cSistemaXrLabel, Me.cDescricaoXrLabel, Me.cObrigacaoXrLabel})
        Me.obrigacaoDetail.Dpi = 100.0!
        Me.obrigacaoDetail.HeightF = 56.67594!
        Me.obrigacaoDetail.KeepTogether = True
        Me.obrigacaoDetail.Name = "obrigacaoDetail"
        Me.obrigacaoDetail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.obrigacaoDetail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLine1
        '
        Me.XrLine1.Dpi = 100.0!
        Me.XrLine1.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(2.541701!, 48.99999!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(750.4375!, 4.201134!)
        '
        'vObrigacaoXrLabel
        '
        Me.vObrigacaoXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "obrigacao", "{0}")})
        Me.vObrigacaoXrLabel.Dpi = 100.0!
        Me.vObrigacaoXrLabel.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.vObrigacaoXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(87.25009!, 3.0!)
        Me.vObrigacaoXrLabel.Name = "vObrigacaoXrLabel"
        Me.vObrigacaoXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.vObrigacaoXrLabel.Scripts.OnBeforePrint = "vObrigacaoXrLabel_BeforePrint"
        Me.vObrigacaoXrLabel.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.vObrigacaoXrLabel.StylePriority.UseFont = False
        Me.vObrigacaoXrLabel.Text = "vObrigacaoXrLabel"
        '
        'vDescricaoXrLabel
        '
        Me.vDescricaoXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "descricao")})
        Me.vDescricaoXrLabel.Dpi = 100.0!
        Me.vDescricaoXrLabel.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.vDescricaoXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(87.25009!, 25.99999!)
        Me.vDescricaoXrLabel.Name = "vDescricaoXrLabel"
        Me.vDescricaoXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.vDescricaoXrLabel.SizeF = New System.Drawing.SizeF(651.0834!, 23.0!)
        Me.vDescricaoXrLabel.StylePriority.UseFont = False
        Me.vDescricaoXrLabel.Text = "vDescricaoXrLabel"
        '
        'vSistemaXrLabel
        '
        Me.vSistemaXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "sistema")})
        Me.vSistemaXrLabel.Dpi = 100.0!
        Me.vSistemaXrLabel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vSistemaXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(521.0092!, 1.999998!)
        Me.vSistemaXrLabel.Name = "vSistemaXrLabel"
        Me.vSistemaXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.vSistemaXrLabel.Scripts.OnBeforePrint = "vSistemaXrLabel_BeforePrint"
        Me.vSistemaXrLabel.SizeF = New System.Drawing.SizeF(217.3242!, 23.0!)
        Me.vSistemaXrLabel.StylePriority.UseFont = False
        Me.vSistemaXrLabel.Text = "vSistemaXrLabel"
        '
        'cSistemaXrLabel
        '
        Me.cSistemaXrLabel.Dpi = 100.0!
        Me.cSistemaXrLabel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cSistemaXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(455.3842!, 1.999998!)
        Me.cSistemaXrLabel.Name = "cSistemaXrLabel"
        Me.cSistemaXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.cSistemaXrLabel.SizeF = New System.Drawing.SizeF(65.62503!, 23.0!)
        Me.cSistemaXrLabel.StylePriority.UseFont = False
        Me.cSistemaXrLabel.Text = "Sistema:"
        '
        'cDescricaoXrLabel
        '
        Me.cDescricaoXrLabel.Dpi = 100.0!
        Me.cDescricaoXrLabel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cDescricaoXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(4.958438!, 26.00002!)
        Me.cDescricaoXrLabel.Name = "cDescricaoXrLabel"
        Me.cDescricaoXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.cDescricaoXrLabel.SizeF = New System.Drawing.SizeF(82.29165!, 23.0!)
        Me.cDescricaoXrLabel.StylePriority.UseFont = False
        Me.cDescricaoXrLabel.Text = "Descrição:"
        '
        'cObrigacaoXrLabel
        '
        Me.cObrigacaoXrLabel.Dpi = 100.0!
        Me.cObrigacaoXrLabel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cObrigacaoXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(4.958438!, 3.0!)
        Me.cObrigacaoXrLabel.Name = "cObrigacaoXrLabel"
        Me.cObrigacaoXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.cObrigacaoXrLabel.SizeF = New System.Drawing.SizeF(82.29165!, 23.0!)
        Me.cObrigacaoXrLabel.StylePriority.UseFont = False
        Me.cObrigacaoXrLabel.Text = "Obrigação:"
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.cabecalhoXrLine, Me.DataXrPageInfo, Me.cTituloXrLabel})
        Me.TopMargin.Dpi = 100.0!
        Me.TopMargin.HeightF = 71.875!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'cabecalhoXrLine
        '
        Me.cabecalhoXrLine.Dpi = 100.0!
        Me.cabecalhoXrLine.LocationFloat = New DevExpress.Utils.PointFloat(2.020844!, 64.33334!)
        Me.cabecalhoXrLine.Name = "cabecalhoXrLine"
        Me.cabecalhoXrLine.SizeF = New System.Drawing.SizeF(750.9583!, 5.624992!)
        '
        'DataXrPageInfo
        '
        Me.DataXrPageInfo.Dpi = 100.0!
        Me.DataXrPageInfo.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.DataXrPageInfo.Format = "{0:dd/MM/yyyy HH:mm}"
        Me.DataXrPageInfo.LocationFloat = New DevExpress.Utils.PointFloat(629.5625!, 41.33334!)
        Me.DataXrPageInfo.Name = "DataXrPageInfo"
        Me.DataXrPageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.DataXrPageInfo.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.DataXrPageInfo.SizeF = New System.Drawing.SizeF(123.9584!, 23.0!)
        Me.DataXrPageInfo.StylePriority.UseFont = False
        Me.DataXrPageInfo.StylePriority.UseTextAlignment = False
        Me.DataXrPageInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'cTituloXrLabel
        '
        Me.cTituloXrLabel.Dpi = 100.0!
        Me.cTituloXrLabel.Font = New System.Drawing.Font("Verdana", 14.0!, System.Drawing.FontStyle.Bold)
        Me.cTituloXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(1.520844!, 10.0!)
        Me.cTituloXrLabel.Multiline = True
        Me.cTituloXrLabel.Name = "cTituloXrLabel"
        Me.cTituloXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.cTituloXrLabel.SizeF = New System.Drawing.SizeF(750.9583!, 31.33334!)
        Me.cTituloXrLabel.StylePriority.UseFont = False
        Me.cTituloXrLabel.StylePriority.UseTextAlignment = False
        Me.cTituloXrLabel.Text = "Relatório Resumido de Obrigações"
        Me.cTituloXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pSistemaXrLabel, Me.NroPaginaXrPageInfo, Me.rodapeXrLine})
        Me.BottomMargin.Dpi = 100.0!
        Me.BottomMargin.HeightF = 38.43972!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'pSistemaXrLabel
        '
        Me.pSistemaXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.Sistema, "Text", "")})
        Me.pSistemaXrLabel.Dpi = 100.0!
        Me.pSistemaXrLabel.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.pSistemaXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(2.541701!, 6.624992!)
        Me.pSistemaXrLabel.Name = "pSistemaXrLabel"
        Me.pSistemaXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.pSistemaXrLabel.SizeF = New System.Drawing.SizeF(191.6667!, 23.0!)
        Me.pSistemaXrLabel.StylePriority.UseFont = False
        Me.pSistemaXrLabel.Text = "pSistemaXrLabel"
        '
        'Sistema
        '
        Me.Sistema.Description = "Sistema"
        Me.Sistema.Name = "Sistema"
        '
        'NroPaginaXrPageInfo
        '
        Me.NroPaginaXrPageInfo.Dpi = 100.0!
        Me.NroPaginaXrPageInfo.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.NroPaginaXrPageInfo.LocationFloat = New DevExpress.Utils.PointFloat(653.5209!, 6.624992!)
        Me.NroPaginaXrPageInfo.Name = "NroPaginaXrPageInfo"
        Me.NroPaginaXrPageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.NroPaginaXrPageInfo.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.NroPaginaXrPageInfo.StylePriority.UseFont = False
        Me.NroPaginaXrPageInfo.StylePriority.UseTextAlignment = False
        Me.NroPaginaXrPageInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'rodapeXrLine
        '
        Me.rodapeXrLine.Dpi = 100.0!
        Me.rodapeXrLine.LocationFloat = New DevExpress.Utils.PointFloat(1.520844!, 1.0!)
        Me.rodapeXrLine.Name = "rodapeXrLine"
        Me.rodapeXrLine.SizeF = New System.Drawing.SizeF(750.9583!, 5.624992!)
        '
        'obrigacoesresumidoXtraReport
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.obrigacaoDetail, Me.TopMargin, Me.BottomMargin})
        Me.DataSource = Me.obrigacoesBindingSource
        Me.Margins = New System.Drawing.Printing.Margins(47, 48, 72, 38)
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.Sistema})
        Me.ScriptsSource = resources.GetString("$this.ScriptsSource")
        Me.Version = "16.2"
        CType(Me.obrigacoesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents obrigacaoDetail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents cTituloXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents rodapeXrLine As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents NroPaginaXrPageInfo As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents vObrigacaoXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents vDescricaoXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents vSistemaXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents cSistemaXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents cDescricaoXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents cObrigacaoXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents obrigacoesBindingSource As BindingSource
    Friend WithEvents pSistemaXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Sistema As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents DataXrPageInfo As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents cabecalhoXrLine As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
End Class
