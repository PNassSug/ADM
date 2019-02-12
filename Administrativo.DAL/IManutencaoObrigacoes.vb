Imports Administrativo.Modelo
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils

Public Interface IManutencaoObrigacoes
    Sub Grid(ByRef penuGrid As enuGridManutecaoObrigacao, ByRef infoManutencaoObrigacoes As manutencaoobrigacoesInfo, ByVal pdgGrid As GridControl, ByVal pgvGrid As GridView)
    Sub Grid(ByRef pstrQuery() As String, ByVal pdgGrid As GridControl, ByVal pgvGrid As GridView, ByVal pgvGridEmpresa As GridView, ByVal pgvGridFuncionario As GridView, ByVal pgvGridDetalheFuncionario As GridView, ByVal pgvGridInforme As GridView, ByVal pgvGridDetalheInforme As GridView, ByVal pgvGridIcmsst As GridView, ByVal pgvGridDetalheIcmsst As GridView, picStatusImageColection As ImageCollection, picTipoEnvioImageColection As DevExpress.Utils.ImageCollection, picVisualizacaoImageColection As DevExpress.Utils.ImageCollection)
    Sub IUDManutencaoObrigacoes(ByRef pstrOperacao As String, ByRef infoManutencaoObrigacoes As manutencaoobrigacoesInfo)
    Sub IUDPortalGuias(ByRef pstrOperacao As String, ByRef infoManutencaoObrigacoes As manutencaoobrigacoesInfo)
    Sub IUDPortalArquivos(ByRef pstrOperacao As String, ByRef infoManutencaoObrigacoes As manutencaoobrigacoesInfo)
    Sub LogGuias(ByRef infoManutencaoObrigacoes As manutencaoobrigacoesInfo)
    Sub LogArquivos(ByRef infoManutencaoObrigacoes As manutencaoobrigacoesInfo)
    Function UploadGuias(ByRef pstrDados As String, ByRef infoManutencaoObrigacoes As manutencaoobrigacoesInfo) As Boolean
    Function UploadArquivos(ByRef pbArquivos As Byte(), ByRef infoManutencaoObrigacoes As manutencaoobrigacoesInfo) As Boolean
    Function DownloadArquivos(ByRef pstrCaminhoDownload As String, ByRef infoManutencaoObrigacoes As manutencaoobrigacoesInfo) As String
    Function BuscaDados(ByRef pstrEmpresa As String, ByRef pstrCompetencia As String, ByRef pintExercicio As Int32, ByRef pstrObrigacao As String, ByRef pintSequenciaExtra As Int32, ByRef pintObrigacaoExtra As Int32, ByRef pstrFuncionario As String, ByRef pintParcela As Int32, ByRef pintTipoPessoaInforme As Int32, ByRef pintInforme As Int32) As manutencaoobrigacoesInfo
    Function BuscaAlertas() As manutencaoobrigacoesalerta
End Interface

