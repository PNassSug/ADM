Imports Administrativo.Modelo
Imports DevExpress.XtraReports.UI

Public Class empresaobrigacoesEOXtraReport
    Public Sub New()
        ' Esta chamada é requerida pelo designer.
        InitializeComponent()
        empresaobrigacoesBindingSource.DataSource = GetType(empresaobrigacoesrelatorioInfo)

        Dim objGroupField As New GroupField
        objGroupField.FieldName = "empresa"
        empresaGroupHeader.GroupFields.Add(objGroupField)
    End Sub
End Class