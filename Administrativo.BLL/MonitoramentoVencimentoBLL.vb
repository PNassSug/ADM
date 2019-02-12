Imports Administrativo.DAL

Public Class MonitoramentoVencimentoBLL
    Implements IMonitoramentoVencimento

    Dim objMonitoramentoVencimento As New MonitoramentoVencimentoDAL

    Public Sub Grafico(ByRef pstrQuery As String, pcGrafico As DevExpress.XtraCharts.ChartControl) Implements DAL.IMonitoramentoVencimento.Grafico
        Try
            objMonitoramentoVencimento.Grafico(pstrQuery, pcGrafico)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Grid(ByRef pstrQuery() As String, pdgGrid As DevExpress.XtraGrid.GridControl, pgvGrid As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridObrigacao As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridEmpresa As DevExpress.XtraGrid.Views.Grid.GridView, ByVal pgvGridEmpresaDetalhe As DevExpress.XtraGrid.Views.Grid.GridView, ByVal pgvGridInforme As DevExpress.XtraGrid.Views.Grid.GridView, ByVal pgvGridFuncionario As DevExpress.XtraGrid.Views.Grid.GridView, picVencimentoImageColection As DevExpress.Utils.ImageCollection, picEmpresaImageColection As DevExpress.Utils.ImageCollection) Implements DAL.IMonitoramentoVencimento.Grid
        Try
            objMonitoramentoVencimento.Grid(pstrQuery, pdgGrid, pgvGrid, pgvGridObrigacao, pgvGridEmpresa, pgvGridEmpresaDetalhe, pgvGridInforme, pgvGridFuncionario, picVencimentoImageColection, picEmpresaImageColection)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class