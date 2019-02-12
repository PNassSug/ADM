Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports Administrativo.Modelo
Imports DevExpress.Utils

Public Interface IParcelamento
    Sub Grid(ByRef pstrQuery() As String, ByRef pstrTituloGrid() As String, ByVal pdgGrid As GridControl, ByVal pgvGrid As GridView, ByVal pgvGridObrigacao As GridView, ByVal pgvGridParcelamento As GridView, picStatusImageColection As ImageCollection)
    Sub Grid(ByRef pstrQuery As String, ByVal pdgGrid As GridControl, ByVal pgvGrid As GridView, ByRef infoParcelamentoDetalhes As List(Of parcelamentodetalhes), picStatusImageColection As ImageCollection)
    Sub IUDParcelamento(ByRef pstrOperacao As String, ByRef infoParcelamento As parcelamentoInfo, ByRef originalinfoinfoParcelamentoDetalhes As List(Of parcelamentodetalhes))
    Function BuscaVencimento(ByRef pstrEstado As String, ByRef pstrMunicipio As String, ByRef pstrCompetencia As String, ByRef pstrPeriodicidade As String,
                             ByRef pintDiaVencimento As Int32, ByRef pstrTipoDia As String, ByRef pintSabDomUtil As Int32,
                             ByRef pintAntecipaUtil As Int32, ByRef pintSubsequente As Int32, ByRef pstrTipoSubsequente As String) As Date
End Interface
