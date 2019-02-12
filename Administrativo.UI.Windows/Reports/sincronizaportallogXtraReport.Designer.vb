<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class sincronizaportallogXtraReport
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
        Me.vNomeXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.vFuncionarioCnpjCpfXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.vTipoXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.vDataFimXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.vCodObrigacaoXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.vNomeObrigacaoXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.vLoginUsuarioXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.vDataEnvioXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.vCompetenciaXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.cUsuarioEnvioXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.cObrigacaoXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.cabecalhoXrLine = New DevExpress.XtraReports.UI.XRLine()
        Me.DataXrPageInfo = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.cTituloXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.rodapeXrLine = New DevExpress.XtraReports.UI.XRLine()
        Me.NroPaginaXrPageInfo = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.pSistemaXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.Sistema = New DevExpress.XtraReports.Parameters.Parameter()
        Me.sincronizalogportalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.obrigacaoGroupHeader = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.cFimEnvioXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.cInicioEnvioXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.cDadosEnvioXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.cEmpresaXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.vRazaoSocialXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.vEmpresaXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.cCompetenciaXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.FormattingRule1 = New DevExpress.XtraReports.UI.FormattingRule()
        Me.empresaGroupFooter = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrLine4 = New DevExpress.XtraReports.UI.XRLine()
        Me.empresaGroupHeader = New DevExpress.XtraReports.UI.GroupHeaderBand()
        CType(Me.sincronizalogportalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.vNomeXrLabel, Me.XrLine3, Me.vFuncionarioCnpjCpfXrLabel, Me.vTipoXrLabel})
        Me.Detail.Dpi = 100.0!
        Me.Detail.HeightF = 23.00004!
        Me.Detail.KeepTogether = True
        Me.Detail.KeepTogetherWithDetailReports = True
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("empresa", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("competencia", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("obrigacao", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'vNomeXrLabel
        '
        Me.vNomeXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "nome")})
        Me.vNomeXrLabel.Dpi = 100.0!
        Me.vNomeXrLabel.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.vNomeXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(324.0501!, 0!)
        Me.vNomeXrLabel.Name = "vNomeXrLabel"
        Me.vNomeXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.vNomeXrLabel.SizeF = New System.Drawing.SizeF(427.9499!, 16.57877!)
        Me.vNomeXrLabel.StylePriority.UseFont = False
        '
        'XrLine3
        '
        Me.XrLine3.Dpi = 100.0!
        Me.XrLine3.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(83.04162!, 16.5788!)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.SizeF = New System.Drawing.SizeF(671.9984!, 6.421232!)
        '
        'vFuncionarioCnpjCpfXrLabel
        '
        Me.vFuncionarioCnpjCpfXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "funcionariocnpjcpf")})
        Me.vFuncionarioCnpjCpfXrLabel.Dpi = 100.0!
        Me.vFuncionarioCnpjCpfXrLabel.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.vFuncionarioCnpjCpfXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(167.5!, 0!)
        Me.vFuncionarioCnpjCpfXrLabel.Name = "vFuncionarioCnpjCpfXrLabel"
        Me.vFuncionarioCnpjCpfXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.vFuncionarioCnpjCpfXrLabel.SizeF = New System.Drawing.SizeF(156.5502!, 16.57877!)
        Me.vFuncionarioCnpjCpfXrLabel.StylePriority.UseFont = False
        '
        'vTipoXrLabel
        '
        Me.vTipoXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "tipo")})
        Me.vTipoXrLabel.Dpi = 100.0!
        Me.vTipoXrLabel.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.vTipoXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(83.04163!, 0!)
        Me.vTipoXrLabel.Name = "vTipoXrLabel"
        Me.vTipoXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.vTipoXrLabel.SizeF = New System.Drawing.SizeF(84.45832!, 16.57877!)
        Me.vTipoXrLabel.StylePriority.UseFont = False
        '
        'vDataFimXrLabel
        '
        Me.vDataFimXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "datahoraenviofim")})
        Me.vDataFimXrLabel.Dpi = 100.0!
        Me.vDataFimXrLabel.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.vDataFimXrLabel.KeepTogether = True
        Me.vDataFimXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(643.1556!, 0!)
        Me.vDataFimXrLabel.Name = "vDataFimXrLabel"
        Me.vDataFimXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.vDataFimXrLabel.SizeF = New System.Drawing.SizeF(111.8843!, 16.57877!)
        Me.vDataFimXrLabel.StylePriority.UseFont = False
        Me.vDataFimXrLabel.Text = "vDataFimXrLabel"
        '
        'vCodObrigacaoXrLabel
        '
        Me.vCodObrigacaoXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "obrigacao")})
        Me.vCodObrigacaoXrLabel.Dpi = 100.0!
        Me.vCodObrigacaoXrLabel.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.vCodObrigacaoXrLabel.KeepTogether = True
        Me.vCodObrigacaoXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(83.03725!, 0!)
        Me.vCodObrigacaoXrLabel.Name = "vCodObrigacaoXrLabel"
        Me.vCodObrigacaoXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.vCodObrigacaoXrLabel.SizeF = New System.Drawing.SizeF(57.0!, 16.58!)
        Me.vCodObrigacaoXrLabel.StylePriority.UseFont = False
        Me.vCodObrigacaoXrLabel.Text = "vCodObrigacaoXrLabel"
        '
        'vNomeObrigacaoXrLabel
        '
        Me.vNomeObrigacaoXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "descricao")})
        Me.vNomeObrigacaoXrLabel.Dpi = 100.0!
        Me.vNomeObrigacaoXrLabel.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.vNomeObrigacaoXrLabel.KeepTogether = True
        Me.vNomeObrigacaoXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(140.0372!, 0!)
        Me.vNomeObrigacaoXrLabel.Name = "vNomeObrigacaoXrLabel"
        Me.vNomeObrigacaoXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.vNomeObrigacaoXrLabel.SizeF = New System.Drawing.SizeF(306.0085!, 16.57877!)
        Me.vNomeObrigacaoXrLabel.StylePriority.UseFont = False
        Me.vNomeObrigacaoXrLabel.Text = "vNomeObrigacaoXrLabel"
        '
        'vLoginUsuarioXrLabel
        '
        Me.vLoginUsuarioXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "usuarioenvio")})
        Me.vLoginUsuarioXrLabel.Dpi = 100.0!
        Me.vLoginUsuarioXrLabel.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.vLoginUsuarioXrLabel.KeepTogether = True
        Me.vLoginUsuarioXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(449.5358!, 0!)
        Me.vLoginUsuarioXrLabel.Name = "vLoginUsuarioXrLabel"
        Me.vLoginUsuarioXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.vLoginUsuarioXrLabel.SizeF = New System.Drawing.SizeF(73.72263!, 16.57877!)
        Me.vLoginUsuarioXrLabel.StylePriority.UseFont = False
        Me.vLoginUsuarioXrLabel.Text = "vLoginUsuarioXrLabel"
        '
        'vDataEnvioXrLabel
        '
        Me.vDataEnvioXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "datahoraenvioinicio")})
        Me.vDataEnvioXrLabel.Dpi = 100.0!
        Me.vDataEnvioXrLabel.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.vDataEnvioXrLabel.KeepTogether = True
        Me.vDataEnvioXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(527.2257!, 0!)
        Me.vDataEnvioXrLabel.Name = "vDataEnvioXrLabel"
        Me.vDataEnvioXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.vDataEnvioXrLabel.SizeF = New System.Drawing.SizeF(111.8843!, 16.57877!)
        Me.vDataEnvioXrLabel.StylePriority.UseFont = False
        Me.vDataEnvioXrLabel.Text = "vDataEnvioXrLabel"
        '
        'vCompetenciaXrLabel
        '
        Me.vCompetenciaXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "competencia")})
        Me.vCompetenciaXrLabel.Dpi = 100.0!
        Me.vCompetenciaXrLabel.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.vCompetenciaXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(3.995641!, 0!)
        Me.vCompetenciaXrLabel.Name = "vCompetenciaXrLabel"
        Me.vCompetenciaXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.vCompetenciaXrLabel.SizeF = New System.Drawing.SizeF(74.04164!, 16.57877!)
        Me.vCompetenciaXrLabel.StylePriority.UseFont = False
        Me.vCompetenciaXrLabel.Text = "Competencia"
        '
        'cUsuarioEnvioXrLabel
        '
        Me.cUsuarioEnvioXrLabel.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.cUsuarioEnvioXrLabel.Dpi = 100.0!
        Me.cUsuarioEnvioXrLabel.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.cUsuarioEnvioXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(450.54!, 47.0!)
        Me.cUsuarioEnvioXrLabel.Name = "cUsuarioEnvioXrLabel"
        Me.cUsuarioEnvioXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.cUsuarioEnvioXrLabel.SizeF = New System.Drawing.SizeF(72.72!, 22.0!)
        Me.cUsuarioEnvioXrLabel.StylePriority.UseBorders = False
        Me.cUsuarioEnvioXrLabel.StylePriority.UseFont = False
        Me.cUsuarioEnvioXrLabel.StylePriority.UseTextAlignment = False
        Me.cUsuarioEnvioXrLabel.Text = "Usuário"
        Me.cUsuarioEnvioXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'cObrigacaoXrLabel
        '
        Me.cObrigacaoXrLabel.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.cObrigacaoXrLabel.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.cObrigacaoXrLabel.Dpi = 100.0!
        Me.cObrigacaoXrLabel.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.cObrigacaoXrLabel.KeepTogether = True
        Me.cObrigacaoXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(83.04163!, 22.99999!)
        Me.cObrigacaoXrLabel.Name = "cObrigacaoXrLabel"
        Me.cObrigacaoXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.cObrigacaoXrLabel.SizeF = New System.Drawing.SizeF(363.01!, 46.0!)
        Me.cObrigacaoXrLabel.StylePriority.UseBorderDashStyle = False
        Me.cObrigacaoXrLabel.StylePriority.UseBorders = False
        Me.cObrigacaoXrLabel.StylePriority.UseFont = False
        Me.cObrigacaoXrLabel.StylePriority.UseTextAlignment = False
        Me.cObrigacaoXrLabel.Text = "Obrigação"
        Me.cObrigacaoXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.cabecalhoXrLine, Me.DataXrPageInfo, Me.cTituloXrLabel})
        Me.TopMargin.Dpi = 100.0!
        Me.TopMargin.HeightF = 72.37499!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'cabecalhoXrLine
        '
        Me.cabecalhoXrLine.Dpi = 100.0!
        Me.cabecalhoXrLine.LocationFloat = New DevExpress.Utils.PointFloat(0.0001033147!, 63.95833!)
        Me.cabecalhoXrLine.Name = "cabecalhoXrLine"
        Me.cabecalhoXrLine.SizeF = New System.Drawing.SizeF(762.0!, 8.416664!)
        '
        'DataXrPageInfo
        '
        Me.DataXrPageInfo.Dpi = 100.0!
        Me.DataXrPageInfo.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.DataXrPageInfo.Format = "{0:dd/MM/yyyy HH:mm}"
        Me.DataXrPageInfo.LocationFloat = New DevExpress.Utils.PointFloat(638.0417!, 40.95832!)
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
        Me.cTituloXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.cTituloXrLabel.Name = "cTituloXrLabel"
        Me.cTituloXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.cTituloXrLabel.SizeF = New System.Drawing.SizeF(762.0!, 40.95832!)
        Me.cTituloXrLabel.StylePriority.UseFont = False
        Me.cTituloXrLabel.StylePriority.UseTextAlignment = False
        Me.cTituloXrLabel.Text = "Relação de Empresas que não Visualizaram as Obrigações"
        Me.cTituloXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'BottomMargin
        '
        Me.BottomMargin.BorderColor = System.Drawing.Color.Black
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.rodapeXrLine, Me.NroPaginaXrPageInfo, Me.pSistemaXrLabel})
        Me.BottomMargin.Dpi = 100.0!
        Me.BottomMargin.ForeColor = System.Drawing.Color.Black
        Me.BottomMargin.HeightF = 37.41668!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.StylePriority.UseBorderColor = False
        Me.BottomMargin.StylePriority.UseForeColor = False
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'rodapeXrLine
        '
        Me.rodapeXrLine.Dpi = 100.0!
        Me.rodapeXrLine.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.rodapeXrLine.Name = "rodapeXrLine"
        Me.rodapeXrLine.SizeF = New System.Drawing.SizeF(762.0!, 8.416668!)
        '
        'NroPaginaXrPageInfo
        '
        Me.NroPaginaXrPageInfo.Dpi = 100.0!
        Me.NroPaginaXrPageInfo.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.NroPaginaXrPageInfo.LocationFloat = New DevExpress.Utils.PointFloat(662.0001!, 12.0!)
        Me.NroPaginaXrPageInfo.Name = "NroPaginaXrPageInfo"
        Me.NroPaginaXrPageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.NroPaginaXrPageInfo.SizeF = New System.Drawing.SizeF(100.0!, 25.41668!)
        Me.NroPaginaXrPageInfo.StylePriority.UseFont = False
        Me.NroPaginaXrPageInfo.StylePriority.UseTextAlignment = False
        Me.NroPaginaXrPageInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'pSistemaXrLabel
        '
        Me.pSistemaXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.Sistema, "Text", "")})
        Me.pSistemaXrLabel.Dpi = 100.0!
        Me.pSistemaXrLabel.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.pSistemaXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(0!, 12.0!)
        Me.pSistemaXrLabel.Name = "pSistemaXrLabel"
        Me.pSistemaXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.pSistemaXrLabel.SizeF = New System.Drawing.SizeF(304.5834!, 25.41668!)
        Me.pSistemaXrLabel.StylePriority.UseFont = False
        Me.pSistemaXrLabel.Text = "pSistemaXrLabel"
        '
        'Sistema
        '
        Me.Sistema.Description = "Sistema"
        Me.Sistema.Name = "Sistema"
        '
        'obrigacaoGroupHeader
        '
        Me.obrigacaoGroupHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.vDataEnvioXrLabel, Me.vCodObrigacaoXrLabel, Me.vNomeObrigacaoXrLabel, Me.vLoginUsuarioXrLabel, Me.vCompetenciaXrLabel, Me.vDataFimXrLabel})
        Me.obrigacaoGroupHeader.Dpi = 100.0!
        Me.obrigacaoGroupHeader.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("empresa", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("competencia", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("obrigacao", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("tipo", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("funcionariocnpjcpf", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.obrigacaoGroupHeader.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WholePage
        Me.obrigacaoGroupHeader.HeightF = 16.58!
        Me.obrigacaoGroupHeader.KeepTogether = True
        Me.obrigacaoGroupHeader.Name = "obrigacaoGroupHeader"
        Me.obrigacaoGroupHeader.RepeatEveryPage = True
        '
        'cFimEnvioXrLabel
        '
        Me.cFimEnvioXrLabel.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.cFimEnvioXrLabel.Dpi = 100.0!
        Me.cFimEnvioXrLabel.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.cFimEnvioXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(643.16!, 47.0!)
        Me.cFimEnvioXrLabel.Name = "cFimEnvioXrLabel"
        Me.cFimEnvioXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.cFimEnvioXrLabel.SizeF = New System.Drawing.SizeF(111.88!, 22.0!)
        Me.cFimEnvioXrLabel.StylePriority.UseBorders = False
        Me.cFimEnvioXrLabel.StylePriority.UseFont = False
        Me.cFimEnvioXrLabel.StylePriority.UseTextAlignment = False
        Me.cFimEnvioXrLabel.Text = "Fim do Envio"
        Me.cFimEnvioXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'cInicioEnvioXrLabel
        '
        Me.cInicioEnvioXrLabel.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.cInicioEnvioXrLabel.Dpi = 100.0!
        Me.cInicioEnvioXrLabel.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.cInicioEnvioXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(527.23!, 47.0!)
        Me.cInicioEnvioXrLabel.Name = "cInicioEnvioXrLabel"
        Me.cInicioEnvioXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.cInicioEnvioXrLabel.SizeF = New System.Drawing.SizeF(111.88!, 22.0!)
        Me.cInicioEnvioXrLabel.StylePriority.UseBorders = False
        Me.cInicioEnvioXrLabel.StylePriority.UseFont = False
        Me.cInicioEnvioXrLabel.StylePriority.UseTextAlignment = False
        Me.cInicioEnvioXrLabel.Text = "Inicio do Envio"
        Me.cInicioEnvioXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'cDadosEnvioXrLabel
        '
        Me.cDadosEnvioXrLabel.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.cDadosEnvioXrLabel.Dpi = 100.0!
        Me.cDadosEnvioXrLabel.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.cDadosEnvioXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(450.54!, 22.99999!)
        Me.cDadosEnvioXrLabel.Name = "cDadosEnvioXrLabel"
        Me.cDadosEnvioXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.cDadosEnvioXrLabel.SizeF = New System.Drawing.SizeF(304.5!, 22.0!)
        Me.cDadosEnvioXrLabel.StylePriority.UseBorders = False
        Me.cDadosEnvioXrLabel.StylePriority.UseFont = False
        Me.cDadosEnvioXrLabel.StylePriority.UseTextAlignment = False
        Me.cDadosEnvioXrLabel.Text = "Dados de Envio para o Portal"
        Me.cDadosEnvioXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'cEmpresaXrLabel
        '
        Me.cEmpresaXrLabel.Dpi = 100.0!
        Me.cEmpresaXrLabel.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.cEmpresaXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(3.068495!, 0!)
        Me.cEmpresaXrLabel.Name = "cEmpresaXrLabel"
        Me.cEmpresaXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.cEmpresaXrLabel.SizeF = New System.Drawing.SizeF(74.04164!, 23.0!)
        Me.cEmpresaXrLabel.StylePriority.UseFont = False
        Me.cEmpresaXrLabel.StylePriority.UseTextAlignment = False
        Me.cEmpresaXrLabel.Text = "Empresa:"
        Me.cEmpresaXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'vRazaoSocialXrLabel
        '
        Me.vRazaoSocialXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "razaosocial")})
        Me.vRazaoSocialXrLabel.Dpi = 100.0!
        Me.vRazaoSocialXrLabel.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.vRazaoSocialXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(146.6104!, 0!)
        Me.vRazaoSocialXrLabel.Name = "vRazaoSocialXrLabel"
        Me.vRazaoSocialXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.vRazaoSocialXrLabel.SizeF = New System.Drawing.SizeF(493.4996!, 23.0!)
        Me.vRazaoSocialXrLabel.StylePriority.UseFont = False
        Me.vRazaoSocialXrLabel.Text = "vRazaoSocialXrLabel"
        '
        'vEmpresaXrLabel
        '
        Me.vEmpresaXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "empresa")})
        Me.vEmpresaXrLabel.Dpi = 100.0!
        Me.vEmpresaXrLabel.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.vEmpresaXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(77.11013!, 0!)
        Me.vEmpresaXrLabel.Name = "vEmpresaXrLabel"
        Me.vEmpresaXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.vEmpresaXrLabel.SizeF = New System.Drawing.SizeF(69.50027!, 23.0!)
        Me.vEmpresaXrLabel.StylePriority.UseFont = False
        Me.vEmpresaXrLabel.Text = "vEmpresaXrLabel"
        '
        'cCompetenciaXrLabel
        '
        Me.cCompetenciaXrLabel.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.cCompetenciaXrLabel.Dpi = 100.0!
        Me.cCompetenciaXrLabel.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.cCompetenciaXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(4.000028!, 23.00002!)
        Me.cCompetenciaXrLabel.Name = "cCompetenciaXrLabel"
        Me.cCompetenciaXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.cCompetenciaXrLabel.SizeF = New System.Drawing.SizeF(74.04164!, 46.0!)
        Me.cCompetenciaXrLabel.StylePriority.UseBorders = False
        Me.cCompetenciaXrLabel.StylePriority.UseFont = False
        Me.cCompetenciaXrLabel.StylePriority.UseTextAlignment = False
        Me.cCompetenciaXrLabel.Text = "Fato Gerador"
        Me.cCompetenciaXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'FormattingRule1
        '
        Me.FormattingRule1.Name = "FormattingRule1"
        '
        'empresaGroupFooter
        '
        Me.empresaGroupFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine4})
        Me.empresaGroupFooter.Dpi = 100.0!
        Me.empresaGroupFooter.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail
        Me.empresaGroupFooter.HeightF = 8.416668!
        Me.empresaGroupFooter.KeepTogether = True
        Me.empresaGroupFooter.Name = "empresaGroupFooter"
        Me.empresaGroupFooter.RepeatEveryPage = True
        '
        'XrLine4
        '
        Me.XrLine4.BorderColor = System.Drawing.Color.Black
        Me.XrLine4.Dpi = 100.0!
        Me.XrLine4.ForeColor = System.Drawing.Color.Black
        Me.XrLine4.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.XrLine4.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLine4.Name = "XrLine4"
        Me.XrLine4.SizeF = New System.Drawing.SizeF(762.0!, 8.416668!)
        Me.XrLine4.StylePriority.UseBorderColor = False
        Me.XrLine4.StylePriority.UseForeColor = False
        '
        'empresaGroupHeader
        '
        Me.empresaGroupHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.vRazaoSocialXrLabel, Me.cEmpresaXrLabel, Me.vEmpresaXrLabel, Me.cDadosEnvioXrLabel, Me.cObrigacaoXrLabel, Me.cCompetenciaXrLabel, Me.cUsuarioEnvioXrLabel, Me.cInicioEnvioXrLabel, Me.cFimEnvioXrLabel})
        Me.empresaGroupHeader.Dpi = 100.0!
        Me.empresaGroupHeader.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("empresa", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.empresaGroupHeader.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WholePage
        Me.empresaGroupHeader.HeightF = 69.00002!
        Me.empresaGroupHeader.KeepTogether = True
        Me.empresaGroupHeader.Level = 1
        Me.empresaGroupHeader.Name = "empresaGroupHeader"
        Me.empresaGroupHeader.RepeatEveryPage = True
        '
        'sincronizaportallogXtraReport
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.obrigacaoGroupHeader, Me.empresaGroupFooter, Me.empresaGroupHeader})
        Me.DataSource = Me.sincronizalogportalBindingSource
        Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.FormattingRule1})
        Me.Margins = New System.Drawing.Printing.Margins(43, 45, 72, 37)
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.Sistema})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "16.2"
        CType(Me.sincronizalogportalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents sincronizalogportalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NroPaginaXrPageInfo As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents pSistemaXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents rodapeXrLine As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents cabecalhoXrLine As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents DataXrPageInfo As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents cTituloXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents obrigacaoGroupHeader As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents vLoginUsuarioXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents vDataFimXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents vDataEnvioXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents vNomeObrigacaoXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents vCodObrigacaoXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents vRazaoSocialXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents vEmpresaXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents cEmpresaXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents cUsuarioEnvioXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents cObrigacaoXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Sistema As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents FormattingRule1 As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents empresaGroupFooter As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrLine4 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents cDadosEnvioXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents cFimEnvioXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents cInicioEnvioXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents cCompetenciaXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents vCompetenciaXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents vFuncionarioCnpjCpfXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents vNomeXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents vTipoXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents empresaGroupHeader As DevExpress.XtraReports.UI.GroupHeaderBand
End Class
