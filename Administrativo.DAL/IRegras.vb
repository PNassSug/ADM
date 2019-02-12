Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI
Imports Administrativo.Modelo
Imports DevExpress.XtraBars.Ribbon

Public Interface IRegras
    Sub Grid(ByRef pstrQuery() As String, ByRef pstrTituloGrid() As String, ByVal pdgGrid As GridControl, ByVal pgvGrid As GridView, ByRef prcRibbonControl As RibbonControl)
    Sub Grid(ByRef pstrQuery As String, ByVal pdgGrid As GridControl, ByVal pgvGrid As GridView, ByRef infoEmpresas As List(Of regrasempresasinfo))
    Sub Grid(ByRef pstrQuery As String, ByVal pdgGrid As GridControl, ByVal pgvGrid As GridView, ByRef infoObrigacoes As List(Of regrasobrigacoesinfo))
    Sub Report(ByRef pstrCampoInicialRegra As String, ByRef pstrCampoFinalRegra As String, ByRef pstrCampoInicialObrigacao As String, ByRef pstrCampoFinalObrigacao As String, ByRef pstrCampoInicialEmpresa As String, ByRef pstrCampoFinalEmpresa As String, ByVal pReport As XtraReport)
    Sub IUDRegras(ByRef pstrOperacao As String, ByRef infoRegras As regrasinfo, ByRef originalinfoEmpresas As List(Of regrasempresasinfo), ByRef originalinfoObrigacoes As List(Of regrasobrigacoesinfo))
    Sub GerarRegras(ByRef pstrCampoInicialRegra As String, ByRef pstrCampoFinalRegra As String, ByRef pstrCampoInicialEmpresa As String, ByRef pstrCampoFinalEmpresa As String, ByRef pstrCampoObrigacao As String, ByVal pblnExcluiEmpresaObrigacao As Boolean)
    Sub SincronizarGerarRegras(ByRef pstrCampoInicialEmpresa As String, ByRef pstrCampoFinalEmpresa As String)
    Function ProximaRegra() As Int32
End Interface


