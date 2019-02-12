Imports Administrativo.Modelo
Imports DevExpress.XtraReports.UI

Public Class sincronizaportallogXtraReport

    Public Sub New()
        ' Esta chamada é requerida pelo designer.
        InitializeComponent()
        sincronizalogportalBindingSource.DataSource = GetType(empresaobrigacoesrelatorioInfo)
    End Sub

    Private Sub codempresaXrLabel_BeforePrint(sender As Object, e As System.Drawing.Printing.PrintEventArgs) Handles vEmpresaXrLabel.BeforePrint
        If Not String.IsNullOrEmpty(vEmpresaXrLabel.Text) Then
            vEmpresaXrLabel.Text = vEmpresaXrLabel.Text.Substring(0, 2) + "." + vEmpresaXrLabel.Text.Substring(2, 4)
        End If
    End Sub

    Private Sub vCompetenciaXrLabel_BeforePrint(sender As Object, e As System.Drawing.Printing.PrintEventArgs) Handles vCompetenciaXrLabel.BeforePrint
        If Not String.IsNullOrEmpty(vCompetenciaXrLabel.Text) Then
            vCompetenciaXrLabel.Text = vCompetenciaXrLabel.Text.Substring(0, 2) + "/" + vCompetenciaXrLabel.Text.Substring(2, 4)
        End If
    End Sub

    Private Sub codobrigacaoXrLabel_BeforePrint(sender As Object, e As System.Drawing.Printing.PrintEventArgs) Handles vCodObrigacaoXrLabel.BeforePrint
        If Not String.IsNullOrEmpty(vEmpresaXrLabel.Text) Then
            vCodObrigacaoXrLabel.Text = vCodObrigacaoXrLabel.Text.Substring(0, 1) + "-" + vCodObrigacaoXrLabel.Text.Substring(1, 5)
        End If
    End Sub

    Private Sub vFuncionarioCnpjCpfXrLabel_BeforePrint(sender As Object, e As System.Drawing.Printing.PrintEventArgs) Handles vFuncionarioCnpjCpfXrLabel.BeforePrint
        If Not String.IsNullOrEmpty(vFuncionarioCnpjCpfXrLabel.Text) Then
            If vFuncionarioCnpjCpfXrLabel.Text.Length = 6 Then
                vFuncionarioCnpjCpfXrLabel.Text = vFuncionarioCnpjCpfXrLabel.Text.Substring(0, 2) + "." + vFuncionarioCnpjCpfXrLabel.Text.Substring(2, 4)
            ElseIf vFuncionarioCnpjCpfXrLabel.Text.Length = 11 Then
                vFuncionarioCnpjCpfXrLabel.Text = vFuncionarioCnpjCpfXrLabel.Text.Substring(0, 3) + "." + vFuncionarioCnpjCpfXrLabel.Text.Substring(3, 3) + "." +
                                                  vFuncionarioCnpjCpfXrLabel.Text.Substring(6, 3) + "-" + vFuncionarioCnpjCpfXrLabel.Text.Substring(9, 2)
            ElseIf vFuncionarioCnpjCpfXrLabel.Text.Length = 14 Then
                vFuncionarioCnpjCpfXrLabel.Text = vFuncionarioCnpjCpfXrLabel.Text.Substring(0, 2) + "." + vFuncionarioCnpjCpfXrLabel.Text.Substring(2, 3) + "." +
                                                  vFuncionarioCnpjCpfXrLabel.Text.Substring(5, 3) + "/" + vFuncionarioCnpjCpfXrLabel.Text.Substring(8, 4) + "-" +
                                                  vFuncionarioCnpjCpfXrLabel.Text.Substring(12, 2)
            End If
        End If
    End Sub

    Private Sub vTipoXrLabel_BeforePrint(sender As Object, e As System.Drawing.Printing.PrintEventArgs) Handles vTipoXrLabel.BeforePrint
        If Not String.IsNullOrEmpty(vTipoXrLabel.Text) Then
            If vTipoXrLabel.Text = "J" Then
                vTipoXrLabel.Text = "CNPJ:"
            ElseIf vTipoXrLabel.Text = "F" Then
                vTipoXrLabel.Text = "CPF:"
            ElseIf vTipoXrLabel.Text = "C" Then
                vTipoXrLabel.Text = "Funcionário:"
            End If
        End If
    End Sub

    Private Sub Detail_BeforePrint(sender As Object, e As System.Drawing.Printing.PrintEventArgs) Handles Detail.BeforePrint
        Dim strTipo As String = CType(sender, DetailBand).Report.GetCurrentColumnValue("tipo").ToString
        If String.IsNullOrEmpty(strTipo) Then
            e.Cancel = True
        End If
    End Sub
End Class