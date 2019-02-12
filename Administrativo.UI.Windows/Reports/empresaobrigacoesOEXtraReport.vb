Imports Administrativo.Modelo
Imports DevExpress.XtraReports.UI

Public Class empresaobrigacoesOEXtraReport
    Public Sub New()
        ' Esta chamada é requerida pelo designer.
        InitializeComponent()
        empresaobrigacoesBindingSource.DataSource = GetType(empresaobrigacoesrelatorioInfo)

        Dim objGroupField As New GroupField
        objGroupField.FieldName = "obrigacao"
        obrigacaoGroupHeader.GroupFields.Add(objGroupField)
    End Sub
End Class