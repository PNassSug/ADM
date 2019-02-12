Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports Administrativo.Modelo
Imports DevExpress.XtraEditors

Public Interface ITarefasExtras
    Sub Grid(ByRef pstrQuery As String, ByRef pstrFieldGroup As String, ByRef pstrCaptionGroup As String, ByRef pstrTituloGrid As String, ByRef pintQtdLinhaTitulo As Int32, ByVal pdgGrid As GridControl, ByVal pbgvGrid As AdvBandedGridView)
    Sub IUDTarefasExtras(ByRef pstrOperacao As String, ByRef infoTarefasExtras As tarefasextrasInfo)
    Sub BuscaVencimento(ByRef pstrEstado As String, ByRef pstrMunicipio As String, ByVal pDataVencimentoDateEdit As DateEdit, ByRef pstrCompetencia As String, ByRef pstrPeriodicidade As String,
                        ByRef pintDiaVencimento As Int32, ByRef pstrTipoDia As String, ByRef pintSabDomUtil As Int32,
                        ByRef pintAntecipaUtil As Int32, ByRef pintSubsequente As Int32, ByRef pstrTipoSubsequente As String)
    Function ProximaTarefa(ByRef pstrEmpresa As String, ByRef pstrObrigacao As String) As Int32
    Function BuscaDados(ByRef pstrEmpresa As String, ByRef pstrCompetencia As String, ByRef pintExercicio As Int32, ByRef pstrObrigacao As String, pintSequenciaExtra As Int32) As tarefasextrasInfo
End Interface
