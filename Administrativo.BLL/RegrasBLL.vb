Imports Administrativo.DAL

Public Class RegrasBLL
    Implements IRegras

    Dim objRegras As New RegrasDAL

    Public Sub Grid(ByRef pstrQuery() As String, ByRef pstrTituloGrid() As String, pdgGrid As DevExpress.XtraGrid.GridControl, pgvGrid As DevExpress.XtraGrid.Views.Grid.GridView, ByRef prcRibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl) Implements DAL.IRegras.Grid
        Try
            objRegras.Grid(pstrQuery, pstrTituloGrid, pdgGrid, pgvGrid, prcRibbonControl)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Grid(ByRef pstrQuery As String, pdgGrid As DevExpress.XtraGrid.GridControl, pgvGrid As DevExpress.XtraGrid.Views.Grid.GridView, ByRef infoEmpresas As System.Collections.Generic.List(Of Modelo.regrasempresasinfo)) Implements DAL.IRegras.Grid
        Try
            objRegras.Grid(pstrQuery, pdgGrid, pgvGrid, infoEmpresas)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub

    Public Sub Grid(ByRef pstrQuery As String, pdgGrid As DevExpress.XtraGrid.GridControl, pgvGrid As DevExpress.XtraGrid.Views.Grid.GridView, ByRef infoObrigacoes As System.Collections.Generic.List(Of Modelo.regrasobrigacoesinfo)) Implements DAL.IRegras.Grid
        Try
            objRegras.Grid(pstrQuery, pdgGrid, pgvGrid, infoObrigacoes)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub

    Public Sub Report(ByRef pstrCampoInicialRegra As String, ByRef pstrCampoFinalRegra As String, ByRef pstrCampoInicialObrigacao As String, ByRef pstrCampoFinalObrigacao As String, ByRef pstrCampoInicialEmpresa As String, ByRef pstrCampoFinalEmpresa As String, pReport As DevExpress.XtraReports.UI.XtraReport) Implements DAL.IRegras.Report
        Try
            objRegras.Report(pstrCampoInicialRegra, pstrCampoFinalRegra, pstrCampoInicialObrigacao, pstrCampoFinalObrigacao, pstrCampoInicialEmpresa, pstrCampoFinalEmpresa, pReport)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function ProximaRegra() As Integer Implements DAL.IRegras.ProximaRegra
        Try
            Return objRegras.ProximaRegra()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Sub IUDRegras(ByRef pstrOperacao As String, ByRef infoRegras As Modelo.regrasinfo, ByRef originalinfoEmpresas As System.Collections.Generic.List(Of Modelo.regrasempresasinfo), ByRef originalinfoObrigacoes As System.Collections.Generic.List(Of Modelo.regrasobrigacoesinfo)) Implements DAL.IRegras.IUDRegras
        If String.IsNullOrEmpty(infoRegras.descricao) Then Throw New Exception("A descrição da regra deve ser preenchida")
        objRegras.IUDRegras(pstrOperacao, infoRegras, originalinfoEmpresas, originalinfoObrigacoes)
    End Sub

    Public Sub GerarRegras(ByRef pstrCampoInicialRegra As String, ByRef pstrCampoFinalRegra As String, ByRef pstrCampoInicialEmpresa As String, ByRef pstrCampoFinalEmpresa As String, ByRef pstrCampoObrigacao As String, pblnExcluiEmpresaObrigacao As Boolean) Implements DAL.IRegras.GerarRegras
        Try
            objRegras.GerarRegras(pstrCampoInicialRegra, pstrCampoFinalRegra, pstrCampoInicialEmpresa, pstrCampoFinalEmpresa, pstrCampoObrigacao, pblnExcluiEmpresaObrigacao)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub SincronizarGerarRegras(ByRef pstrCampoInicialEmpresa As String, ByRef pstrCampoFinalEmpresa As String) Implements DAL.IRegras.SincronizarGerarRegras
        Try
            objRegras.SincronizarGerarRegras(pstrCampoInicialEmpresa, pstrCampoFinalEmpresa)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class
