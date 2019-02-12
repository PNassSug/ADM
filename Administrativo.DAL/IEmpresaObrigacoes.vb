Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI
Imports Administrativo.Modelo
Imports DevExpress.XtraBars.Ribbon

Public Interface IEmpresaObrigacoes
    Sub Grid(ByRef pstrQuery() As String, ByRef pstrTituloGrid() As String, ByVal pdgGrid As GridControl, ByVal pgvGrid As GridView, ByRef prcRibbonControl As RibbonControl)
    Sub Grid(ByRef pstrQuery As String, ByVal pdgGrid As GridControl, ByVal pgvGrid As GridView, ByRef infoEmpresaObrigacoes As List(Of empresaobrigacoes))
    Sub Report(ByRef pstrCampoInicialEmpresa As String, ByRef pstrCampoFinalEmpresa As String, ByRef pstrCampoInicialObrigacao As String, ByRef pstrCampoFinalObrigacao As String, ByRef pstrTipoLucro As String, ByRef pstrTipoEmpresa As String, ByVal pReport As XtraReport)
    Sub IUDEmpresaObrigacoes(ByRef pstrOperacao As String, ByRef infoEmpresaObrigacoes As empresaobrigacoesInfo, ByRef originalinfoEmpresaObrigacoes As List(Of empresaobrigacoes))
    Sub SincronizaEmpresaObrigacoes(ByRef pstrOperacao As String, ByRef infoEmpresaObrigacoes As empresaobrigacoesInfo)
    Sub GeracaoControleObrigacoes(ByRef pstrEmpresa As String, ByRef pstrCompetencia As String, ByRef pintExercicio As Integer, ByRef pstrObrigacao As String, ByRef pblnExcluiControleObrigacao As Boolean)
    Function SugereObrigacoes(ByRef pstrEmpresa As String, ByRef pstrEmpresaAux As String, ByRef pstrRazaoSocialAux As String) As String
End Interface


