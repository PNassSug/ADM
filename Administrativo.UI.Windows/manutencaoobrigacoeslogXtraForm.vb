Imports Administrativo.Modelo
Imports Administrativo.BLL
Imports DevExpress.XtraEditors

Public Class manutencaoobrigacoeslogXtraForm
    Dim objManutencaoObrigacoes As New ManutencaoObrigacoesBLL
    Public infoPortalLog As manutencaoobrigacoesInfo

    Public Sub New(ByRef pinfoPortalLog As manutencaoobrigacoesInfo)
        InitializeComponent()
        infoPortalLog = pinfoPortalLog
    End Sub

    Private Sub manutencaoobrigacoeslog_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Try
            objManutencaoObrigacoes.Grid(enuGridManutecaoObrigacao.PortalLog, infoPortalLog, logGridControl, logGridView)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class