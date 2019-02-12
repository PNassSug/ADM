Imports Administrativo.Modelo
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils

Public Interface ICnd
   Sub Grid(ByRef pstrQuery As String, ByVal pdgGrid As GridControl, ByVal pgvGrid As GridView, ByValpicStatusImageColection As ImageCollection)
End Interface
