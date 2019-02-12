Imports Administrativo.DAL

Public Class FiltroBLL
    Implements IFiltro

    Dim objFiltro As New FiltroDAL

    Public Sub CarregaFiltro() Implements DAL.IFiltro.CarregaFiltro
        Try
            objFiltro.CarregaFiltro()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function RetornaWhereFiltro(pstrTabela As String) As String Implements DAL.IFiltro.RetornaWhereFiltro
        Try
            Return objFiltro.RetornaWhereFiltro(pstrTabela)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Sub GravaFiltro(pstrFiltrarpor As String, pstrTipoVencimento As String, pintDias As Integer, pdtaDataInicial As Nullable(Of DateTime), pdtaDataFinal As Nullable(Of DateTime)) Implements DAL.IFiltro.GravaFiltro
        If pstrTipoVencimento = "PERIODO" Then
            If Not pdtaDataInicial.HasValue Then Throw New Exception("A data inicial deve ser preenchida")
            If Not pdtaDataFinal.HasValue Then Throw New Exception("A data final deve ser preenchida")
            If pdtaDataInicial > pdtaDataFinal Then Throw New Exception("A data inicial deve ser menor que a data final")
        End If
        objFiltro.GravaFiltro(pstrFiltrarpor, pstrTipoVencimento, pintDias, pdtaDataInicial, pdtaDataFinal)
    End Sub

    Public Sub IconeOpcaoFiltro(pOpcaoBarButtonItem As DevExpress.XtraBars.BarButtonItem) Implements DAL.IFiltro.IconeOpcaoFiltro
        Try
            objFiltro.IconeOpcaoFiltro(pOpcaoBarButtonItem)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class
