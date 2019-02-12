Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraCharts
Imports DevExpress.Utils

Public Interface IMonitoramento
    Sub Grid(ByRef pstrQuery() As String, ByVal pdgGrid As GridControl, ByVal pgvGrid As GridView, ByVal pgvGridEmpresa As GridView, pgvGridEmpresaDetalhe As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridInforme As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridFuncionario As DevExpress.XtraGrid.Views.Grid.GridView, picImageColection As ImageCollection)
    Sub Grafico(ByRef pstrQuery As String, ByVal pcGrafico As ChartControl)
End Interface
