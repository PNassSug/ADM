Imports Administrativo.Modelo
Imports Administrativo.BLL
Imports DevExpress.XtraEditors

Public Class manutencaoobrigacoesfuncionariosXtraForm
    Dim objManutencaoObrigacoes As New ManutencaoObrigacoesBLL
    Public infoPortalGuia As manutencaoobrigacoesInfo

    Public Sub New(ByRef pinfoPortalGuia As manutencaoobrigacoesInfo)
        InitializeComponent()
        infoPortalGuia = pinfoPortalGuia
    End Sub

    Private Sub manutencaoobrigacoesfuncionariosXtraForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Try
            objManutencaoObrigacoes.Grid(enuGridManutecaoObrigacao.Funcionario, infoPortalGuia, funcionariosGridControl, funcionariosGridView)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class