Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports Administrativo.Modelo

Public Interface IPortalUsuarios
    Sub Grid(ByRef pstrQuery() As String, ByRef pstrTituloGrid() As String, ByVal pdgGrid As GridControl, ByVal pgvGrid As GridView, ByVal pgvGridSistema As GridView)
    Sub Grid(ByRef pstrQuery As String, ByVal pdgGrid As GridControl, ByVal pgvGrid As GridView, ByRef infoSistemas As List(Of portalusuariossistemas))
    Sub IUDPortalUsuarios(ByRef pstrOperacao As String, ByRef pstrFiltroEmail As String, ByRef infoPortalUsuarios As portalusuariosInfo, ByRef originalinfoSistemas As List(Of portalusuariossistemas))
    Sub SincronizarPortalUsuarios(ByRef pstrOperacao As String, ByRef infoPortalUsuarios As portalusuariosInfo)
End Interface
