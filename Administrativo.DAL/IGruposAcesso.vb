Imports Administrativo.Modelo
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraTreeList

Public Interface IGruposAcesso
    Sub IUDGruposAcesso(ByRef pstrOperacao As String, ByRef infoGruposAcesso As gruposacessoInfo)
    Sub Grid(ByRef pstrQuery As String, ByVal pdgGrid As GridControl, ByVal pgvGrid As GridView)
    Sub VisualizaGrupoAcesso(ByRef pstrQuery As String, ByRef pstrCampoPai As String, ByRef pstrCampoFilho As String, ByVal ptlGrupoAcesso As TreeList)
End Interface
