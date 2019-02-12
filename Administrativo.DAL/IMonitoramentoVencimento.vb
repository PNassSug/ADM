Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraCharts
Imports DevExpress.Utils

Public Interface IMonitoramentoVencimento
    Sub Grid(ByRef pstrQuery() As String, ByVal pdgGrid As GridControl, ByVal pgvGrid As GridView, pgvGridObrigacao As GridView, ByVal pgvGridEmpresa As GridView, ByVal pgvGridEmpresaDetalhe As GridView, ByVal pgvGridInforme As GridView, ByVal pgvGridFuncionario As GridView, picVencimentoImageColection As ImageCollection, picEmpresaImageColection As ImageCollection)
    Sub Grafico(ByRef pstrQuery As String, ByVal pcGrafico As ChartControl)
End Interface
