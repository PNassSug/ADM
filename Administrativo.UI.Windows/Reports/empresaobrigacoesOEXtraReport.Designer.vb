<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class empresaobrigacoesOEXtraReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(empresaobrigacoesOEXtraReport))
        Me.empresaDetail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.cabecalhoXrLine = New DevExpress.XtraReports.UI.XRLine()
        Me.DataXrPageInfo = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.cTituloXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.pSistemaXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.Sistema = New DevExpress.XtraReports.Parameters.Parameter()
        Me.rodapeXrLine = New DevExpress.XtraReports.UI.XRLine()
        Me.NroPaginaXrPageInfo = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.obrigacaoGroupHeader = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.cObrigacaoXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.vObrigacaoXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.vDescricaoXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.obrigacaoGroupFooter = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.empresaobrigacoesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.cEmpresaXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.cRazaoSocialXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.cCompetenciaObsoletaXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.vRazaoSocialXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.vEmpresaXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.vCompetenciaObsoletaXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.vTipoEmpresaDescXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.vTipoLucroDescXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.separador1XrLine = New DevExpress.XtraReports.UI.XRLine()
        Me.vTipoEmpresaXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.vTipoLucroXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me.empresaobrigacoesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'empresaDetail
        '
        Me.empresaDetail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.vRazaoSocialXrLabel, Me.vEmpresaXrLabel, Me.vCompetenciaObsoletaXrLabel, Me.vTipoEmpresaDescXrLabel, Me.vTipoLucroDescXrLabel, Me.vTipoEmpresaXrLabel, Me.vTipoLucroXrLabel})
        Me.empresaDetail.Dpi = 100.0!
        Me.empresaDetail.HeightF = 35.7048!
        Me.empresaDetail.Name = "empresaDetail"
        Me.empresaDetail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.empresaDetail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.cabecalhoXrLine, Me.DataXrPageInfo, Me.cTituloXrLabel})
        Me.TopMargin.Dpi = 100.0!
        Me.TopMargin.HeightF = 77.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'cabecalhoXrLine
        '
        Me.cabecalhoXrLine.Dpi = 100.0!
        Me.cabecalhoXrLine.LocationFloat = New DevExpress.Utils.PointFloat(0.5208424!, 64.33334!)
        Me.cabecalhoXrLine.Name = "cabecalhoXrLine"
        Me.cabecalhoXrLine.SizeF = New System.Drawing.SizeF(765.4792!, 2.666656!)
        '
        'DataXrPageInfo
        '
        Me.DataXrPageInfo.Dpi = 100.0!
        Me.DataXrPageInfo.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.DataXrPageInfo.Format = "{0:dd/MM/yyyy HH:mm}"
        Me.DataXrPageInfo.LocationFloat = New DevExpress.Utils.PointFloat(642.0417!, 41.33335!)
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
        Me.cTituloXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(1.041628!, 10.00001!)
        Me.cTituloXrLabel.Name = "cTituloXrLabel"
        Me.cTituloXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.cTituloXrLabel.SizeF = New System.Drawing.SizeF(764.9583!, 31.33334!)
        Me.cTituloXrLabel.StylePriority.UseFont = False
        Me.cTituloXrLabel.StylePriority.UseTextAlignment = False
        Me.cTituloXrLabel.Text = "Relatório das Obrigações e suas Empresas"
        Me.cTituloXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pSistemaXrLabel, Me.rodapeXrLine, Me.NroPaginaXrPageInfo})
        Me.BottomMargin.Dpi = 100.0!
        Me.BottomMargin.HeightF = 41.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'pSistemaXrLabel
        '
        Me.pSistemaXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.Sistema, "Text", "")})
        Me.pSistemaXrLabel.Dpi = 100.0!
        Me.pSistemaXrLabel.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.pSistemaXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(1.020844!, 8.0!)
        Me.pSistemaXrLabel.Name = "pSistemaXrLabel"
        Me.pSistemaXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.pSistemaXrLabel.SizeF = New System.Drawing.SizeF(244.7917!, 23.0!)
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
        Me.rodapeXrLine.LocationFloat = New DevExpress.Utils.PointFloat(1.020846!, 4.76784!)
        Me.rodapeXrLine.Name = "rodapeXrLine"
        Me.rodapeXrLine.SizeF = New System.Drawing.SizeF(764.9791!, 2.232142!)
        '
        'NroPaginaXrPageInfo
        '
        Me.NroPaginaXrPageInfo.Dpi = 100.0!
        Me.NroPaginaXrPageInfo.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.NroPaginaXrPageInfo.LocationFloat = New DevExpress.Utils.PointFloat(666.0!, 6.999983!)
        Me.NroPaginaXrPageInfo.Name = "NroPaginaXrPageInfo"
        Me.NroPaginaXrPageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.NroPaginaXrPageInfo.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.NroPaginaXrPageInfo.StylePriority.UseFont = False
        Me.NroPaginaXrPageInfo.StylePriority.UseTextAlignment = False
        Me.NroPaginaXrPageInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'obrigacaoGroupHeader
        '
        Me.obrigacaoGroupHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.cEmpresaXrLabel, Me.cRazaoSocialXrLabel, Me.cCompetenciaObsoletaXrLabel, Me.XrLabel1, Me.XrLabel2, Me.cObrigacaoXrLabel, Me.vObrigacaoXrLabel, Me.vDescricaoXrLabel})
        Me.obrigacaoGroupHeader.Dpi = 100.0!
        Me.obrigacaoGroupHeader.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WholePage
        Me.obrigacaoGroupHeader.HeightF = 69.27201!
        Me.obrigacaoGroupHeader.KeepTogether = True
        Me.obrigacaoGroupHeader.Name = "obrigacaoGroupHeader"
        '
        'cObrigacaoXrLabel
        '
        Me.cObrigacaoXrLabel.BorderColor = System.Drawing.Color.Transparent
        Me.cObrigacaoXrLabel.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.cObrigacaoXrLabel.Dpi = 100.0!
        Me.cObrigacaoXrLabel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cObrigacaoXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(0!, 5.999973!)
        Me.cObrigacaoXrLabel.Name = "cObrigacaoXrLabel"
        Me.cObrigacaoXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.cObrigacaoXrLabel.SizeF = New System.Drawing.SizeF(86.4167!, 23.0!)
        Me.cObrigacaoXrLabel.StylePriority.UseBackColor = False
        Me.cObrigacaoXrLabel.StylePriority.UseBorderColor = False
        Me.cObrigacaoXrLabel.StylePriority.UseBorders = False
        Me.cObrigacaoXrLabel.StylePriority.UseFont = False
        Me.cObrigacaoXrLabel.StylePriority.UseTextAlignment = False
        Me.cObrigacaoXrLabel.Text = "Obrigação:"
        Me.cObrigacaoXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'vObrigacaoXrLabel
        '
        Me.vObrigacaoXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "obrigacao")})
        Me.vObrigacaoXrLabel.Dpi = 100.0!
        Me.vObrigacaoXrLabel.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.vObrigacaoXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(86.41662!, 5.999979!)
        Me.vObrigacaoXrLabel.Name = "vObrigacaoXrLabel"
        Me.vObrigacaoXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.vObrigacaoXrLabel.Scripts.OnBeforePrint = "vObrigacaoXrLabel_BeforePrint"
        Me.vObrigacaoXrLabel.SizeF = New System.Drawing.SizeF(72.61114!, 23.0!)
        Me.vObrigacaoXrLabel.StylePriority.UseFont = False
        Me.vObrigacaoXrLabel.StylePriority.UseTextAlignment = False
        Me.vObrigacaoXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'vDescricaoXrLabel
        '
        Me.vDescricaoXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "descricao")})
        Me.vDescricaoXrLabel.Dpi = 100.0!
        Me.vDescricaoXrLabel.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.vDescricaoXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(159.0277!, 6.0!)
        Me.vDescricaoXrLabel.Name = "vDescricaoXrLabel"
        Me.vDescricaoXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.vDescricaoXrLabel.SizeF = New System.Drawing.SizeF(606.9722!, 23.0!)
        Me.vDescricaoXrLabel.StylePriority.UseFont = False
        Me.vDescricaoXrLabel.StylePriority.UseTextAlignment = False
        Me.vDescricaoXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'obrigacaoGroupFooter
        '
        Me.obrigacaoGroupFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.separador1XrLine})
        Me.obrigacaoGroupFooter.Dpi = 100.0!
        Me.obrigacaoGroupFooter.HeightF = 19.5463!
        Me.obrigacaoGroupFooter.Name = "obrigacaoGroupFooter"
        '
        'PageFooter
        '
        Me.PageFooter.Dpi = 100.0!
        Me.PageFooter.HeightF = 0!
        Me.PageFooter.Name = "PageFooter"
        '
        'cEmpresaXrLabel
        '
        Me.cEmpresaXrLabel.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.cEmpresaXrLabel.Dpi = 100.0!
        Me.cEmpresaXrLabel.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.cEmpresaXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(0!, 34.7491!)
        Me.cEmpresaXrLabel.Name = "cEmpresaXrLabel"
        Me.cEmpresaXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.cEmpresaXrLabel.SizeF = New System.Drawing.SizeF(61.89775!, 32.0!)
        Me.cEmpresaXrLabel.StylePriority.UseBorderColor = False
        Me.cEmpresaXrLabel.StylePriority.UseBorders = False
        Me.cEmpresaXrLabel.StylePriority.UseFont = False
        Me.cEmpresaXrLabel.StylePriority.UseTextAlignment = False
        Me.cEmpresaXrLabel.Text = "Empresa"
        Me.cEmpresaXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'cRazaoSocialXrLabel
        '
        Me.cRazaoSocialXrLabel.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.cRazaoSocialXrLabel.Dpi = 100.0!
        Me.cRazaoSocialXrLabel.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.cRazaoSocialXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(67.9165!, 34.7491!)
        Me.cRazaoSocialXrLabel.Name = "cRazaoSocialXrLabel"
        Me.cRazaoSocialXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.cRazaoSocialXrLabel.SizeF = New System.Drawing.SizeF(334.6678!, 32.0!)
        Me.cRazaoSocialXrLabel.StylePriority.UseBorderColor = False
        Me.cRazaoSocialXrLabel.StylePriority.UseBorders = False
        Me.cRazaoSocialXrLabel.StylePriority.UseFont = False
        Me.cRazaoSocialXrLabel.StylePriority.UseTextAlignment = False
        Me.cRazaoSocialXrLabel.Text = "Razão Social"
        Me.cRazaoSocialXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'cCompetenciaObsoletaXrLabel
        '
        Me.cCompetenciaObsoletaXrLabel.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.cCompetenciaObsoletaXrLabel.Dpi = 100.0!
        Me.cCompetenciaObsoletaXrLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cCompetenciaObsoletaXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(681.0208!, 34.7491!)
        Me.cCompetenciaObsoletaXrLabel.Multiline = True
        Me.cCompetenciaObsoletaXrLabel.Name = "cCompetenciaObsoletaXrLabel"
        Me.cCompetenciaObsoletaXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.cCompetenciaObsoletaXrLabel.SizeF = New System.Drawing.SizeF(84.97913!, 29.99995!)
        Me.cCompetenciaObsoletaXrLabel.StylePriority.UseBorders = False
        Me.cCompetenciaObsoletaXrLabel.StylePriority.UseFont = False
        Me.cCompetenciaObsoletaXrLabel.StylePriority.UseTextAlignment = False
        Me.cCompetenciaObsoletaXrLabel.Text = "Competência" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Obsoleta"
        Me.cCompetenciaObsoletaXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel1
        '
        Me.XrLabel1.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel1.BorderColor = System.Drawing.Color.Black
        Me.XrLabel1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel1.Dpi = 100.0!
        Me.XrLabel1.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(409.3192!, 34.74904!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(148.1217!, 32.0!)
        Me.XrLabel1.StylePriority.UseBackColor = False
        Me.XrLabel1.StylePriority.UseBorderColor = False
        Me.XrLabel1.StylePriority.UseBorders = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Tipo Lucro"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel2
        '
        Me.XrLabel2.BorderColor = System.Drawing.Color.Black
        Me.XrLabel2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel2.Dpi = 100.0!
        Me.XrLabel2.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(565.4409!, 34.74906!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(108.5591!, 31.99999!)
        Me.XrLabel2.StylePriority.UseBorderColor = False
        Me.XrLabel2.StylePriority.UseBorders = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "Tipo Empresa"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'vRazaoSocialXrLabel
        '
        Me.vRazaoSocialXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "razaosocial")})
        Me.vRazaoSocialXrLabel.Dpi = 100.0!
        Me.vRazaoSocialXrLabel.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.vRazaoSocialXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(67.9165!, 5.670136!)
        Me.vRazaoSocialXrLabel.Name = "vRazaoSocialXrLabel"
        Me.vRazaoSocialXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.vRazaoSocialXrLabel.SizeF = New System.Drawing.SizeF(333.6679!, 23.0!)
        Me.vRazaoSocialXrLabel.StylePriority.UseFont = False
        Me.vRazaoSocialXrLabel.StylePriority.UseTextAlignment = False
        Me.vRazaoSocialXrLabel.Text = "vRazaoSocialXrLabel"
        Me.vRazaoSocialXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'vEmpresaXrLabel
        '
        Me.vEmpresaXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "empresa")})
        Me.vEmpresaXrLabel.Dpi = 100.0!
        Me.vEmpresaXrLabel.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.vEmpresaXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(1.520874!, 5.670137!)
        Me.vEmpresaXrLabel.Name = "vEmpresaXrLabel"
        Me.vEmpresaXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.vEmpresaXrLabel.Scripts.OnBeforePrint = "vEmpresaXrLabel_BeforePrint"
        Me.vEmpresaXrLabel.SizeF = New System.Drawing.SizeF(62.85611!, 23.0!)
        Me.vEmpresaXrLabel.StylePriority.UseFont = False
        Me.vEmpresaXrLabel.StylePriority.UseTextAlignment = False
        Me.vEmpresaXrLabel.Text = "vEmpresaXrLabel"
        Me.vEmpresaXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'vCompetenciaObsoletaXrLabel
        '
        Me.vCompetenciaObsoletaXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "competenciaobsoleta")})
        Me.vCompetenciaObsoletaXrLabel.Dpi = 100.0!
        Me.vCompetenciaObsoletaXrLabel.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.vCompetenciaObsoletaXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(686.1672!, 5.670137!)
        Me.vCompetenciaObsoletaXrLabel.Name = "vCompetenciaObsoletaXrLabel"
        Me.vCompetenciaObsoletaXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.vCompetenciaObsoletaXrLabel.Scripts.OnBeforePrint = "vCompetenciaObsoletaXrLabel_BeforePrint"
        Me.vCompetenciaObsoletaXrLabel.SizeF = New System.Drawing.SizeF(69.31201!, 23.0!)
        Me.vCompetenciaObsoletaXrLabel.StylePriority.UseFont = False
        Me.vCompetenciaObsoletaXrLabel.StylePriority.UseTextAlignment = False
        Me.vCompetenciaObsoletaXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'vTipoEmpresaDescXrLabel
        '
        Me.vTipoEmpresaDescXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "tipoempresadesc")})
        Me.vTipoEmpresaDescXrLabel.Dpi = 100.0!
        Me.vTipoEmpresaDescXrLabel.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.vTipoEmpresaDescXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(675.0!, 5.670136!)
        Me.vTipoEmpresaDescXrLabel.Name = "vTipoEmpresaDescXrLabel"
        Me.vTipoEmpresaDescXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.vTipoEmpresaDescXrLabel.SizeF = New System.Drawing.SizeF(7.500305!, 23.0!)
        Me.vTipoEmpresaDescXrLabel.StylePriority.UseFont = False
        Me.vTipoEmpresaDescXrLabel.StylePriority.UseTextAlignment = False
        Me.vTipoEmpresaDescXrLabel.Text = "vTipoEmpresaDescXrLabel"
        Me.vTipoEmpresaDescXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.vTipoEmpresaDescXrLabel.Visible = False
        '
        'vTipoLucroDescXrLabel
        '
        Me.vTipoLucroDescXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "tipolucrodesc")})
        Me.vTipoLucroDescXrLabel.Dpi = 100.0!
        Me.vTipoLucroDescXrLabel.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.vTipoLucroDescXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(559.4409!, 5.670136!)
        Me.vTipoLucroDescXrLabel.Name = "vTipoLucroDescXrLabel"
        Me.vTipoLucroDescXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.vTipoLucroDescXrLabel.SizeF = New System.Drawing.SizeF(6.166626!, 23.0!)
        Me.vTipoLucroDescXrLabel.StylePriority.UseFont = False
        Me.vTipoLucroDescXrLabel.StylePriority.UseTextAlignment = False
        Me.vTipoLucroDescXrLabel.Text = "vTipoLucroDescXrLabel"
        Me.vTipoLucroDescXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.vTipoLucroDescXrLabel.Visible = False
        '
        'separador1XrLine
        '
        Me.separador1XrLine.Dpi = 100.0!
        Me.separador1XrLine.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.separador1XrLine.LocationFloat = New DevExpress.Utils.PointFloat(1.020846!, 6.0!)
        Me.separador1XrLine.Name = "separador1XrLine"
        Me.separador1XrLine.SizeF = New System.Drawing.SizeF(763.4999!, 5.708332!)
        '
        'vTipoEmpresaXrLabel
        '
        Me.vTipoEmpresaXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "tipoempresa")})
        Me.vTipoEmpresaXrLabel.Dpi = 100.0!
        Me.vTipoEmpresaXrLabel.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.vTipoEmpresaXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(566.4409!, 5.670143!)
        Me.vTipoEmpresaXrLabel.Name = "vTipoEmpresaXrLabel"
        Me.vTipoEmpresaXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.vTipoEmpresaXrLabel.Scripts.OnBeforePrint = "vTipoEmpresaXrLabel_BeforePrint"
        Me.vTipoEmpresaXrLabel.SizeF = New System.Drawing.SizeF(107.9409!, 23.0!)
        Me.vTipoEmpresaXrLabel.StylePriority.UseFont = False
        Me.vTipoEmpresaXrLabel.StylePriority.UseTextAlignment = False
        Me.vTipoEmpresaXrLabel.Text = "vTipoEmpresaXrLabel"
        Me.vTipoEmpresaXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'vTipoLucroXrLabel
        '
        Me.vTipoLucroXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "tipolucro")})
        Me.vTipoLucroXrLabel.Dpi = 100.0!
        Me.vTipoLucroXrLabel.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.vTipoLucroXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(409.3192!, 5.670143!)
        Me.vTipoLucroXrLabel.Name = "vTipoLucroXrLabel"
        Me.vTipoLucroXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.vTipoLucroXrLabel.Scripts.OnBeforePrint = "vTipoLucroXrLabel_BeforePrint"
        Me.vTipoLucroXrLabel.SizeF = New System.Drawing.SizeF(150.1217!, 23.0!)
        Me.vTipoLucroXrLabel.StylePriority.UseFont = False
        Me.vTipoLucroXrLabel.StylePriority.UseTextAlignment = False
        Me.vTipoLucroXrLabel.Text = "vTipoLucroXrLabel"
        Me.vTipoLucroXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'empresaobrigacoesOEXtraReport
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.empresaDetail, Me.TopMargin, Me.BottomMargin, Me.obrigacaoGroupHeader, Me.obrigacaoGroupFooter, Me.PageFooter})
        Me.DataSource = Me.empresaobrigacoesBindingSource
        Me.Margins = New System.Drawing.Printing.Margins(39, 45, 77, 41)
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.Sistema})
        Me.ScriptsSource = resources.GetString("$this.ScriptsSource")
        Me.Version = "16.2"
        CType(Me.empresaobrigacoesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents empresaDetail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents empresaobrigacoesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cTituloXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DataXrPageInfo As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents cabecalhoXrLine As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents pSistemaXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Sistema As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents rodapeXrLine As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents NroPaginaXrPageInfo As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents obrigacaoGroupHeader As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents obrigacaoGroupFooter As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents vObrigacaoXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents vDescricaoXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents cObrigacaoXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents vRazaoSocialXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents vEmpresaXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents vCompetenciaObsoletaXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents vTipoEmpresaDescXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents vTipoLucroDescXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents separador1XrLine As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents vTipoEmpresaXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents vTipoLucroXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents cEmpresaXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents cRazaoSocialXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents cCompetenciaObsoletaXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
End Class
