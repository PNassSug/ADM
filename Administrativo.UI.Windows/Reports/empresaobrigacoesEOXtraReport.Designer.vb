<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class empresaobrigacoesEOXtraReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(empresaobrigacoesEOXtraReport))
        Me.obrigacaoDetail = New DevExpress.XtraReports.UI.DetailBand()
        Me.vDescricaoXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.vObrigacaoXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.vCompetenciaObsoletaXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.DataXrPageInfo = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.cTituloXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.cabecalhoXrLine = New DevExpress.XtraReports.UI.XRLine()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.pSistemaXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.Sistema = New DevExpress.XtraReports.Parameters.Parameter()
        Me.NroPaginaXrPageInfo = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.rodapeXrLine = New DevExpress.XtraReports.UI.XRLine()
        Me.empresaGroupHeader = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.cTipoEmpresaXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.cTipoLucroXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.vTipoEmpresaDescXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.vTipoEmpresaXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.vTipoLucroDescXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.vTipoLucroXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.cCompetenciaObsoletaXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.cDescricaoXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.cObrigacaoXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.cEmpresaXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.vRazaoSocialXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.vEmpresaXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.empresaGroupFooter = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.separadorXrLine = New DevExpress.XtraReports.UI.XRLine()
        Me.empresaobrigacoesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.empresaobrigacoesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'obrigacaoDetail
        '
        Me.obrigacaoDetail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.vDescricaoXrLabel, Me.vObrigacaoXrLabel, Me.vCompetenciaObsoletaXrLabel})
        Me.obrigacaoDetail.Dpi = 100.0!
        Me.obrigacaoDetail.HeightF = 27.79166!
        Me.obrigacaoDetail.KeepTogether = True
        Me.obrigacaoDetail.Name = "obrigacaoDetail"
        Me.obrigacaoDetail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.obrigacaoDetail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'vDescricaoXrLabel
        '
        Me.vDescricaoXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "descricao")})
        Me.vDescricaoXrLabel.Dpi = 100.0!
        Me.vDescricaoXrLabel.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.vDescricaoXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(104.9583!, 0!)
        Me.vDescricaoXrLabel.Name = "vDescricaoXrLabel"
        Me.vDescricaoXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.vDescricaoXrLabel.SizeF = New System.Drawing.SizeF(485.37!, 23.0!)
        Me.vDescricaoXrLabel.StylePriority.UseFont = False
        '
        'vObrigacaoXrLabel
        '
        Me.vObrigacaoXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "obrigacao")})
        Me.vObrigacaoXrLabel.Dpi = 100.0!
        Me.vObrigacaoXrLabel.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.vObrigacaoXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.vObrigacaoXrLabel.Name = "vObrigacaoXrLabel"
        Me.vObrigacaoXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.vObrigacaoXrLabel.Scripts.OnBeforePrint = "vObrigacaoXrLabel_BeforePrint"
        Me.vObrigacaoXrLabel.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.vObrigacaoXrLabel.StylePriority.UseFont = False
        '
        'vCompetenciaObsoletaXrLabel
        '
        Me.vCompetenciaObsoletaXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "competenciaobsoleta")})
        Me.vCompetenciaObsoletaXrLabel.Dpi = 100.0!
        Me.vCompetenciaObsoletaXrLabel.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.vCompetenciaObsoletaXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(595.7499!, 0!)
        Me.vCompetenciaObsoletaXrLabel.Name = "vCompetenciaObsoletaXrLabel"
        Me.vCompetenciaObsoletaXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.vCompetenciaObsoletaXrLabel.Scripts.OnBeforePrint = "vCompetenciaObsoletaXrLabel_BeforePrint"
        Me.vCompetenciaObsoletaXrLabel.SizeF = New System.Drawing.SizeF(155.2083!, 23.0!)
        Me.vCompetenciaObsoletaXrLabel.StylePriority.UseFont = False
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.DataXrPageInfo, Me.cTituloXrLabel, Me.cabecalhoXrLine})
        Me.TopMargin.Dpi = 100.0!
        Me.TopMargin.HeightF = 68.75!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'DataXrPageInfo
        '
        Me.DataXrPageInfo.Dpi = 100.0!
        Me.DataXrPageInfo.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.DataXrPageInfo.Format = "{0:dd/MM/yyyy HH:mm}"
        Me.DataXrPageInfo.LocationFloat = New DevExpress.Utils.PointFloat(626.9999!, 41.33334!)
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
        Me.cTituloXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(0!, 10.0!)
        Me.cTituloXrLabel.Name = "cTituloXrLabel"
        Me.cTituloXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.cTituloXrLabel.SizeF = New System.Drawing.SizeF(750.9583!, 31.33334!)
        Me.cTituloXrLabel.StylePriority.UseFont = False
        Me.cTituloXrLabel.StylePriority.UseTextAlignment = False
        Me.cTituloXrLabel.Text = "Relatório das Empresas e suas Obrigações"
        Me.cTituloXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'cabecalhoXrLine
        '
        Me.cabecalhoXrLine.Dpi = 100.0!
        Me.cabecalhoXrLine.LocationFloat = New DevExpress.Utils.PointFloat(0!, 64.33334!)
        Me.cabecalhoXrLine.Name = "cabecalhoXrLine"
        Me.cabecalhoXrLine.SizeF = New System.Drawing.SizeF(750.9583!, 4.416656!)
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pSistemaXrLabel, Me.NroPaginaXrPageInfo, Me.rodapeXrLine})
        Me.BottomMargin.Dpi = 100.0!
        Me.BottomMargin.HeightF = 36.45833!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'pSistemaXrLabel
        '
        Me.pSistemaXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.Sistema, "Text", "")})
        Me.pSistemaXrLabel.Dpi = 100.0!
        Me.pSistemaXrLabel.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.pSistemaXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(1.041667!, 3.458341!)
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
        'NroPaginaXrPageInfo
        '
        Me.NroPaginaXrPageInfo.Dpi = 100.0!
        Me.NroPaginaXrPageInfo.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.NroPaginaXrPageInfo.LocationFloat = New DevExpress.Utils.PointFloat(651.0!, 3.458341!)
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
        Me.rodapeXrLine.LocationFloat = New DevExpress.Utils.PointFloat(1.041667!, 0.4583359!)
        Me.rodapeXrLine.Name = "rodapeXrLine"
        Me.rodapeXrLine.SizeF = New System.Drawing.SizeF(749.9583!, 2.0!)
        '
        'empresaGroupHeader
        '
        Me.empresaGroupHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.cTipoEmpresaXrLabel, Me.cTipoLucroXrLabel, Me.vTipoEmpresaDescXrLabel, Me.vTipoEmpresaXrLabel, Me.vTipoLucroDescXrLabel, Me.vTipoLucroXrLabel, Me.cCompetenciaObsoletaXrLabel, Me.cDescricaoXrLabel, Me.cObrigacaoXrLabel, Me.cEmpresaXrLabel, Me.vRazaoSocialXrLabel, Me.vEmpresaXrLabel})
        Me.empresaGroupHeader.Dpi = 100.0!
        Me.empresaGroupHeader.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WholePage
        Me.empresaGroupHeader.HeightF = 81.20833!
        Me.empresaGroupHeader.KeepTogether = True
        Me.empresaGroupHeader.Name = "empresaGroupHeader"
        Me.empresaGroupHeader.SnapLinePadding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        '
        'cTipoEmpresaXrLabel
        '
        Me.cTipoEmpresaXrLabel.Dpi = 100.0!
        Me.cTipoEmpresaXrLabel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cTipoEmpresaXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(358.375!, 25.0!)
        Me.cTipoEmpresaXrLabel.Name = "cTipoEmpresaXrLabel"
        Me.cTipoEmpresaXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.cTipoEmpresaXrLabel.SizeF = New System.Drawing.SizeF(105.0832!, 23.0!)
        Me.cTipoEmpresaXrLabel.StylePriority.UseFont = False
        Me.cTipoEmpresaXrLabel.Text = "Tipo Empresa:"
        '
        'cTipoLucroXrLabel
        '
        Me.cTipoLucroXrLabel.Dpi = 100.0!
        Me.cTipoLucroXrLabel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cTipoLucroXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(0!, 25.0!)
        Me.cTipoLucroXrLabel.Name = "cTipoLucroXrLabel"
        Me.cTipoLucroXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.cTipoLucroXrLabel.SizeF = New System.Drawing.SizeF(85.41666!, 23.0!)
        Me.cTipoLucroXrLabel.StylePriority.UseFont = False
        Me.cTipoLucroXrLabel.Text = "Tipo Lucro:"
        '
        'vTipoEmpresaDescXrLabel
        '
        Me.vTipoEmpresaDescXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "tipoempresadesc")})
        Me.vTipoEmpresaDescXrLabel.Dpi = 100.0!
        Me.vTipoEmpresaDescXrLabel.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.vTipoEmpresaDescXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(699.9166!, 25.0!)
        Me.vTipoEmpresaDescXrLabel.Name = "vTipoEmpresaDescXrLabel"
        Me.vTipoEmpresaDescXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.vTipoEmpresaDescXrLabel.SizeF = New System.Drawing.SizeF(46.0834!, 23.0!)
        Me.vTipoEmpresaDescXrLabel.StylePriority.UseFont = False
        Me.vTipoEmpresaDescXrLabel.Text = "vTipoEmpresaDescXrLabel"
        Me.vTipoEmpresaDescXrLabel.Visible = False
        '
        'vTipoEmpresaXrLabel
        '
        Me.vTipoEmpresaXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "tipoempresa")})
        Me.vTipoEmpresaXrLabel.Dpi = 100.0!
        Me.vTipoEmpresaXrLabel.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.vTipoEmpresaXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(463.4582!, 25.0!)
        Me.vTipoEmpresaXrLabel.Name = "vTipoEmpresaXrLabel"
        Me.vTipoEmpresaXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.vTipoEmpresaXrLabel.Scripts.OnBeforePrint = "vTipoEmpresaXrLabel_BeforePrint"
        Me.vTipoEmpresaXrLabel.SizeF = New System.Drawing.SizeF(217.7083!, 23.0!)
        Me.vTipoEmpresaXrLabel.StylePriority.UseFont = False
        Me.vTipoEmpresaXrLabel.Text = "vTipoEmpresaXrLabel"
        '
        'vTipoLucroDescXrLabel
        '
        Me.vTipoLucroDescXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "tipolucrodesc")})
        Me.vTipoLucroDescXrLabel.Dpi = 100.0!
        Me.vTipoLucroDescXrLabel.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.vTipoLucroDescXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(323.9999!, 25.0!)
        Me.vTipoLucroDescXrLabel.Name = "vTipoLucroDescXrLabel"
        Me.vTipoLucroDescXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.vTipoLucroDescXrLabel.SizeF = New System.Drawing.SizeF(34.37502!, 23.0!)
        Me.vTipoLucroDescXrLabel.StylePriority.UseFont = False
        Me.vTipoLucroDescXrLabel.Text = "vTipoLucroDescXrLabel"
        Me.vTipoLucroDescXrLabel.Visible = False
        '
        'vTipoLucroXrLabel
        '
        Me.vTipoLucroXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "tipolucro")})
        Me.vTipoLucroXrLabel.Dpi = 100.0!
        Me.vTipoLucroXrLabel.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.vTipoLucroXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(85.41666!, 25.0!)
        Me.vTipoLucroXrLabel.Name = "vTipoLucroXrLabel"
        Me.vTipoLucroXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.vTipoLucroXrLabel.Scripts.OnBeforePrint = "vTipoLucroXrLabel_BeforePrint"
        Me.vTipoLucroXrLabel.SizeF = New System.Drawing.SizeF(214.5833!, 23.0!)
        Me.vTipoLucroXrLabel.StylePriority.UseFont = False
        Me.vTipoLucroXrLabel.Text = "vTipoLucroXrLabel"
        '
        'cCompetenciaObsoletaXrLabel
        '
        Me.cCompetenciaObsoletaXrLabel.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.cCompetenciaObsoletaXrLabel.Dpi = 100.0!
        Me.cCompetenciaObsoletaXrLabel.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.cCompetenciaObsoletaXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(595.7499!, 49.87499!)
        Me.cCompetenciaObsoletaXrLabel.Name = "cCompetenciaObsoletaXrLabel"
        Me.cCompetenciaObsoletaXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.cCompetenciaObsoletaXrLabel.SizeF = New System.Drawing.SizeF(155.2083!, 23.0!)
        Me.cCompetenciaObsoletaXrLabel.StylePriority.UseBorders = False
        Me.cCompetenciaObsoletaXrLabel.StylePriority.UseFont = False
        Me.cCompetenciaObsoletaXrLabel.StylePriority.UseTextAlignment = False
        Me.cCompetenciaObsoletaXrLabel.Text = "Competência Obsoleta"
        Me.cCompetenciaObsoletaXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'cDescricaoXrLabel
        '
        Me.cDescricaoXrLabel.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.cDescricaoXrLabel.Dpi = 100.0!
        Me.cDescricaoXrLabel.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.cDescricaoXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(104.9583!, 49.87499!)
        Me.cDescricaoXrLabel.Name = "cDescricaoXrLabel"
        Me.cDescricaoXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.cDescricaoXrLabel.SizeF = New System.Drawing.SizeF(485.37!, 23.0!)
        Me.cDescricaoXrLabel.StylePriority.UseBorders = False
        Me.cDescricaoXrLabel.StylePriority.UseFont = False
        Me.cDescricaoXrLabel.StylePriority.UseTextAlignment = False
        Me.cDescricaoXrLabel.Text = "Descrição"
        Me.cDescricaoXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'cObrigacaoXrLabel
        '
        Me.cObrigacaoXrLabel.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.cObrigacaoXrLabel.Dpi = 100.0!
        Me.cObrigacaoXrLabel.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.cObrigacaoXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(0!, 49.87499!)
        Me.cObrigacaoXrLabel.Name = "cObrigacaoXrLabel"
        Me.cObrigacaoXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.cObrigacaoXrLabel.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.cObrigacaoXrLabel.StylePriority.UseBorders = False
        Me.cObrigacaoXrLabel.StylePriority.UseFont = False
        Me.cObrigacaoXrLabel.StylePriority.UseTextAlignment = False
        Me.cObrigacaoXrLabel.Text = "Obrigação"
        Me.cObrigacaoXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'cEmpresaXrLabel
        '
        Me.cEmpresaXrLabel.Dpi = 100.0!
        Me.cEmpresaXrLabel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cEmpresaXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(0!, 1.999998!)
        Me.cEmpresaXrLabel.Name = "cEmpresaXrLabel"
        Me.cEmpresaXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.cEmpresaXrLabel.SizeF = New System.Drawing.SizeF(72.91664!, 23.0!)
        Me.cEmpresaXrLabel.StylePriority.UseFont = False
        Me.cEmpresaXrLabel.Text = "Empresa:"
        '
        'vRazaoSocialXrLabel
        '
        Me.vRazaoSocialXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "razaosocial")})
        Me.vRazaoSocialXrLabel.Dpi = 100.0!
        Me.vRazaoSocialXrLabel.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.vRazaoSocialXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(172.9166!, 1.999998!)
        Me.vRazaoSocialXrLabel.Name = "vRazaoSocialXrLabel"
        Me.vRazaoSocialXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.vRazaoSocialXrLabel.SizeF = New System.Drawing.SizeF(573.0834!, 23.0!)
        Me.vRazaoSocialXrLabel.StylePriority.UseFont = False
        Me.vRazaoSocialXrLabel.Text = "vRazaoSocialXrLabel"
        '
        'vEmpresaXrLabel
        '
        Me.vEmpresaXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "empresa")})
        Me.vEmpresaXrLabel.Dpi = 100.0!
        Me.vEmpresaXrLabel.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.vEmpresaXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(72.91664!, 2.0!)
        Me.vEmpresaXrLabel.Name = "vEmpresaXrLabel"
        Me.vEmpresaXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.vEmpresaXrLabel.Scripts.OnBeforePrint = "vEmpresaXrLabel_BeforePrint"
        Me.vEmpresaXrLabel.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.vEmpresaXrLabel.StylePriority.UseFont = False
        Me.vEmpresaXrLabel.Text = "vEmpresaXrLabel"
        '
        'PageFooter
        '
        Me.PageFooter.Dpi = 100.0!
        Me.PageFooter.HeightF = 3.625011!
        Me.PageFooter.Name = "PageFooter"
        '
        'empresaGroupFooter
        '
        Me.empresaGroupFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.separadorXrLine})
        Me.empresaGroupFooter.Dpi = 100.0!
        Me.empresaGroupFooter.HeightF = 23.00002!
        Me.empresaGroupFooter.Name = "empresaGroupFooter"
        '
        'separadorXrLine
        '
        Me.separadorXrLine.Dpi = 100.0!
        Me.separadorXrLine.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.separadorXrLine.LocationFloat = New DevExpress.Utils.PointFloat(0!, 4.291662!)
        Me.separadorXrLine.Name = "separadorXrLine"
        Me.separadorXrLine.SizeF = New System.Drawing.SizeF(750.9582!, 5.708329!)
        '
        'empresaobrigacoesEOXtraReport
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.obrigacaoDetail, Me.TopMargin, Me.BottomMargin, Me.empresaGroupHeader, Me.PageFooter, Me.empresaGroupFooter})
        Me.DataSource = Me.empresaobrigacoesBindingSource
        Me.Margins = New System.Drawing.Printing.Margins(49, 50, 69, 36)
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.Sistema})
        Me.ScriptsSource = resources.GetString("$this.ScriptsSource")
        Me.Version = "16.2"
        CType(Me.empresaobrigacoesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents obrigacaoDetail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents empresaobrigacoesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents empresaGroupHeader As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents vDescricaoXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents vObrigacaoXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents vRazaoSocialXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents vEmpresaXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents cTituloXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DataXrPageInfo As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents cabecalhoXrLine As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents cEmpresaXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents cCompetenciaObsoletaXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents cDescricaoXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents cObrigacaoXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents NroPaginaXrPageInfo As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents rodapeXrLine As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents pSistemaXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Sistema As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents empresaGroupFooter As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents separadorXrLine As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents vCompetenciaObsoletaXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents cTipoEmpresaXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents cTipoLucroXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents vTipoEmpresaDescXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents vTipoEmpresaXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents vTipoLucroDescXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents vTipoLucroXrLabel As DevExpress.XtraReports.UI.XRLabel
End Class
