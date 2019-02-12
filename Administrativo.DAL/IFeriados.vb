Imports DevExpress.XtraScheduler
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports Administrativo.Modelo

Public Interface IFeriados
    Sub CriaFeriados(ByRef pstrQuery As String, ByVal psccFeriados As SchedulerControl)
    Sub Grid(ByRef pstrQuery As String, ByVal pdgGrid As GridControl, ByVal pgvGrid As GridView, ByRef infoFiltro As List(Of feriadosfiltro), ByRef pstrVariacao As String)
    Sub IUDFeriados(ByRef pstrOperacao As String, ByRef infoFeriados As feriadosInfo, ByRef originalinfoFiltro As List(Of feriadosfiltro))
    Sub ApagaFeriados(ByVal paptFeriados As Appointment, ByVal psccFeriados As SchedulerStorage)
    Sub Feriados(ByRef pdtaDataFeriado As Date, ByRef pstrDescricao As String, ByRef pstrLocalizacao As String, ByRef pstrTipoData As String, ByRef pstrTipoFeriado As String, ByVal psccFeriados As SchedulerStorage)
    Sub Feriados(ByRef pstrDescricao As String, ByRef pstrLocalizacao As String, ByRef pstrTipoFeriado As String, ByVal paptFeriados As Appointment)
End Interface
