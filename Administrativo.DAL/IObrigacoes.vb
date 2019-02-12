Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI
Imports Administrativo.Modelo
Imports DevExpress.XtraBars.Ribbon

Public Interface IObrigacoes
    Sub Grid(ByRef pstrQuery() As String, ByRef pstrTituloGrid() As String, ByVal pdgGrid As GridControl, ByVal pgvGrid As GridView, ByRef prcRibbonControl As RibbonControl)
    Sub Grid(ByRef pstrQuery As String, ByVal pdgGrid As GridControl, ByVal pgvGrid As GridView, ByRef infoObrigacoes As List(Of obrigacoesusuarios))
    Sub Grid(ByRef pstrQuery As String, ByVal pdgGrid As GridControl, ByVal pgvGrid As GridView, ByRef infoVariacao As List(Of obrigacoesvariacao), ByRef pstrVariacao As String)
    Sub Grid(ByRef pstrQuery() As String, ByRef pstrTituloGrid() As String, ByVal pdgGrid As GridControl, ByVal pgvGrid As GridView,
             ByVal pgvGridItem As GridView, ByVal pgvGridCpr As GridView, ByVal pgvGridIss As GridView, ByVal pgvGridEiss As GridView, ByVal pgvGridIe As GridView, ByVal pgvGridCnpj As GridView)
    Sub Report(ByRef pstrCampoInicial As String, ByRef pstrCampoFinal As String, ByRef pstrPeriodicidade As String, ByRef pstrTributo As String, ByVal pstrSistema As String, ByVal pReport As XtraReport)
    Sub Report(ByRef pstrCampoInicial As String, ByRef pstrCampoFinal As String, ByRef pstrPeriodicidade As String, ByRef pstrTributo As String, ByVal pstrSistema As String, ByVal pReport As XtraReport, ByVal pblnResumido As Boolean)
    Sub IUDObrigacoes(ByRef pstrOperacao As String, ByRef infoObrigacoes As obrigacoesInfo, ByRef originalinfoVariacao As List(Of obrigacoesvariacao))
    Sub IUDObrigacoesUsuarios(ByRef pstrOperacao As String, ByRef infoObrigacoesUsuarios As obrigacoesusuariosInfo, ByRef originalinfoObrigacoes As List(Of obrigacoesusuarios))
    Sub SincronizarObrigacoes(ByRef pstrOperacao As String, ByRef infoObrigacoes As obrigacoesInfo)
    Function ProximaObrigacao() As String
    Function RetornaLayoutObrigacao(ByRef pstrObrigacao As String) As Int32
End Interface
