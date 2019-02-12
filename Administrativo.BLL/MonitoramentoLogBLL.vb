Imports Administrativo.DAL

Public Class MonitoramentoLogBLL
    Implements IMonitoramentoLog


    Dim objMonitoramentoLog As New MonitoramentoLogDAL

    Public Sub Grid(ByRef pstrQuery() As String, pdgGrid As DevExpress.XtraGrid.GridControl, pgvGrid As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridEmpresa As DevExpress.XtraGrid.Views.Grid.GridView, pgvLogGridEmpresa As DevExpress.XtraGrid.Views.Grid.GridView, pgvPortalGridEmpresa As DevExpress.XtraGrid.Views.Grid.GridView, pgvLogPortalGridEmpresa As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridFuncionario As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridDetalheFuncionario As DevExpress.XtraGrid.Views.Grid.GridView, pgvLogGridFuncionario As DevExpress.XtraGrid.Views.Grid.GridView, pgvPortalGridFuncionario As DevExpress.XtraGrid.Views.Grid.GridView, pgvLogPortalGridFuncionario As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridInforme As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridDetalheInforme As DevExpress.XtraGrid.Views.Grid.GridView, pgvLogGridInforme As DevExpress.XtraGrid.Views.Grid.GridView, pgvPortalGridInforme As DevExpress.XtraGrid.Views.Grid.GridView, pgvLogPortalGridInforme As DevExpress.XtraGrid.Views.Grid.GridView, picStatusImageColection As DevExpress.Utils.ImageCollection, picEnvioImageColection As DevExpress.Utils.ImageCollection, picVisualizouImageColection As DevExpress.Utils.ImageCollection) Implements DAL.IMonitoramentoLog.Grid
        Try
            objMonitoramentoLog.Grid(pstrQuery, pdgGrid, pgvGrid,
                                     pgvGridEmpresa, pgvLogGridEmpresa, pgvPortalGridEmpresa, pgvLogPortalGridEmpresa,
                                     pgvGridFuncionario, pgvGridDetalheFuncionario, pgvLogGridFuncionario, pgvPortalGridFuncionario, pgvLogPortalGridFuncionario,
                                     pgvGridInforme, pgvGridDetalheInforme, pgvLogGridInforme, pgvPortalGridInforme, pgvLogPortalGridInforme,
                                     picStatusImageColection, picEnvioImageColection, picVisualizouImageColection)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class