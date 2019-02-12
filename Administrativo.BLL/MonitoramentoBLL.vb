Imports Administrativo.DAL

Public Class MonitoramentoBLL
    Implements IMonitoramento

    Dim objMonitoramento As New MonitoramentoDAL

    Public Sub Grafico(ByRef pstrQuery As String, pcGrafico As DevExpress.XtraCharts.ChartControl) Implements DAL.IMonitoramento.Grafico
        Try
            objMonitoramento.Grafico(pstrQuery, pcGrafico)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Grid(ByRef pstrQuery() As String, pdgGrid As DevExpress.XtraGrid.GridControl, pgvGrid As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridEmpresa As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridEmpresaDetalhe As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridInforme As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridFuncionario As DevExpress.XtraGrid.Views.Grid.GridView, picImageColection As DevExpress.Utils.ImageCollection) Implements DAL.IMonitoramento.Grid
        Try
            objMonitoramento.Grid(pstrQuery, pdgGrid, pgvGrid, pgvGridEmpresa, pgvGridEmpresaDetalhe, pgvGridInforme, pgvGridFuncionario, picImageColection)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class
