Imports DevExpress.XtraBars

Public Interface IFiltro
    Sub GravaFiltro(pstrFiltrarpor As String, pstrTipoVencimento As String, pintDias As Int32, pdtaDataInicial As Nullable(Of DateTime), pdtaDataFinal As Nullable(Of DateTime))
    Sub CarregaFiltro()
    Sub IconeOpcaoFiltro(pOpcaoBarButtonItem As BarButtonItem)
    Function RetornaWhereFiltro(pstrTabela As String) As String
End Interface