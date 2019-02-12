Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports Administrativo.Modelo
Imports DevExpress.XtraBars.Ribbon

Public Interface IMaladireta
    Sub CarregaListaPalavraReservada(ByVal pListBox As DevExpress.XtraEditors.ListBoxControl, ByVal pstrCategoria As String)
    Sub CarregaComboPalavraReservada(ByVal pComboBox As DevExpress.XtraEditors.ComboBoxEdit)
    Sub ValidaObrigacao(ByVal pstrQuery As String)
    Sub Grid(ByRef pstrQuery() As String, ByRef pstrTituloGrid() As String, ByVal pdgGrid As GridControl, ByVal pgvGrid As GridView, ByRef prcRibbonControl As RibbonControl)
    Sub Grid(ByRef pstrQuery As String, ByVal pdgGrid As GridControl, ByVal pgvGrid As GridView, ByRef infoObrigacoes As List(Of maladiretaobrigacoesInfo))
    Sub IUDMaladireta(ByRef pstrOperacao As String, ByRef infoMaladireta As maladiretaInfo, ByRef originalinfoObrigacoes As List(Of maladiretaobrigacoesInfo))
    Function ProximaMalaDireta() As Int32
    Function CarregaPalavraReservada(ByVal pstrCategoria As String, ByVal pstrNome As String) As String
    Function CarregaMensagem(ByVal pstrObrigacao As String, ByVal pstrCompetencia As String, ByVal pstrEmpresa As String, ByVal pintObrigacaoextra As Int32, ByVal pintSequenciaextra As Int32, ByVal pintParcela As Int32, ByVal pintInforme As Int32) As String
End Interface


