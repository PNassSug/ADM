Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils

Public Interface IMonitoramentoLog
    Sub Grid(ByRef pstrQuery() As String, ByVal pdgGrid As GridControl, ByVal pgvGrid As GridView,
             ByVal pgvGridEmpresa As GridView, ByVal pgvLogGridEmpresa As GridView, ByVal pgvPortalGridEmpresa As GridView, ByVal pgvLogPortalGridEmpresa As GridView,
             ByVal pgvGridFuncionario As GridView, ByVal pgvGridDetalheFuncionario As GridView, ByVal pgvLogGridFuncionario As GridView, ByVal pgvPortalGridFuncionario As GridView, ByVal pgvLogPortalGridFuncionario As GridView,
             ByVal pgvGridInforme As GridView, ByVal pgvGridDetalheInforme As GridView, ByVal pgvLogGridInforme As GridView, ByVal pgvPortalGridInforme As GridView, ByVal pgvLogPortalGridInforme As GridView,
             ByVal picStatusImageColection As ImageCollection, ByVal picEnvioImageColection As ImageCollection, ByVal picVisualizouImageColection As ImageCollection)
End Interface