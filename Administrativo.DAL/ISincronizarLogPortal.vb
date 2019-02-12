Imports DevExpress.XtraReports.UI

Public Interface ISincronizarlogportal
    Sub BuscaControleAdministrativo(pstrCompetenciaInicial As String, pstrCompetenciaFinal As String, pstrEmpresaInicial As String, pstrEmpresaFinal As String, pstrObrigacaoInicial As String, pstrObrigacaoFinal As String)
    Sub Report(pstrCompetenciaInicial As String, pstrCompetenciaFinal As String, pstrEmpresaInicial As String, pstrEmpresaFinal As String, pstrObrigacaoInicial As String, pstrObrigacaoFinal As String, ByVal pReport As XtraReport)
End Interface