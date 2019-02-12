Imports Administrativo.Modelo
Imports DevExpress.XtraReports.UI

Public Class regrasXtraReport
    Dim strTipo As String = String.Empty

    Public Sub New()
        ' Esta chamada é requerida pelo designer.
        InitializeComponent()
        regrasBindingSource.DataSource = GetType(regrasrelatorioInfo)

        Dim objGroupField As New GroupField("regra")
        regraGroupHeader.GroupFields.Add(objGroupField)

        objGroupField = New GroupField("tipo")
        tipoGroupHeader.GroupFields.Add(objGroupField)
    End Sub

    Private Sub vTipoXrLabel_BeforePrint(sender As Object, e As System.Drawing.Printing.PrintEventArgs) Handles vTipoXrLabel.BeforePrint
        If vTipoXrLabel.Text = "OBRIGACAO" Then
            vTipoXrLabel.Text = "Obrigações"
            strTipo = "O"
        ElseIf vTipoXrLabel.Text = "EMPRESA" Then
            vTipoXrLabel.Text = "Empresas"
            strTipo = "E"
        End If
    End Sub

    Private Sub vcodigo_emp_obrXrLabel_BeforePrint(sender As Object, e As System.Drawing.Printing.PrintEventArgs) Handles vcodigo_emp_obrXrLabel.BeforePrint
        If Not String.IsNullOrEmpty(vcodigo_emp_obrXrLabel.Text) Then
            If strTipo = "O" Then
                vcodigo_emp_obrXrLabel.Text = vcodigo_emp_obrXrLabel.Text.Substring(0, 1) + "-" + vcodigo_emp_obrXrLabel.Text.Substring(1, 5)
            ElseIf strTipo = "E" Then
                vcodigo_emp_obrXrLabel.Text = vcodigo_emp_obrXrLabel.Text.Substring(0, 2) + "." + vcodigo_emp_obrXrLabel.Text.Substring(2, 4)
            End If
        End If
    End Sub
End Class