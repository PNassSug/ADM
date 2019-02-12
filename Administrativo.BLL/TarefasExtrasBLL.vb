Imports Administrativo.DAL

Public Class TarefasExtrasBLL
    Implements ITarefasExtras

    Dim objTarefasExtras As New TarefasExtrasDAL

    Public Sub Grid(ByRef pstrQuery As String, ByRef pstrFieldGroup As String, ByRef pstrCaptionGroup As String, ByRef pstrTituloGrid As String, ByRef pintQtdLinhaTitulo As Integer, pdgGrid As DevExpress.XtraGrid.GridControl, pbgvGrid As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView) Implements DAL.ITarefasExtras.Grid
        Try
            objTarefasExtras.Grid(pstrQuery, pstrFieldGroup, pstrCaptionGroup, pstrTituloGrid, pintQtdLinhaTitulo, pdgGrid, pbgvGrid)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub IUDTarefasExtras(ByRef pstrOperacao As String, ByRef infoTarefasExtras As Modelo.tarefasextrasInfo) Implements DAL.ITarefasExtras.IUDTarefasExtras
        Try
            If String.IsNullOrEmpty(infoTarefasExtras.empresa) Then Throw New Exception("A empresa deve ser preenchida")
            If String.IsNullOrEmpty(infoTarefasExtras.competencia) Then Throw New Exception("A competência deve ser preenchida")
            If String.IsNullOrEmpty(infoTarefasExtras.obrigacao) Then Throw New Exception("A obrigação deve ser preenchida")
            If Not infoTarefasExtras.datavencimento.HasValue Then Throw New Exception("A data de vencimento deve ser preenchida")
            objTarefasExtras.IUDTarefasExtras(pstrOperacao, infoTarefasExtras)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function ProximaTarefa(ByRef pstrEmpresa As String, ByRef pstrObrigacao As String) As Integer Implements DAL.ITarefasExtras.ProximaTarefa
        Try
            Return objTarefasExtras.ProximaTarefa(pstrEmpresa, pstrObrigacao)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Sub BuscaVencimento(ByRef pstrEstado As String, ByRef pstrMunicipio As String, pDataVencimentoDateEdit As DevExpress.XtraEditors.DateEdit, ByRef pstrCompetencia As String, ByRef pstrPeriodicidade As String, ByRef pintDiaVencimento As Integer, ByRef pstrTipoDia As String, ByRef pintSabDomUtil As Integer, ByRef pintAntecipaUtil As Integer, ByRef pintSubsequente As Integer, ByRef pstrTipoSubsequente As String) Implements DAL.ITarefasExtras.BuscaVencimento
        Try
            objTarefasExtras.BuscaVencimento(pstrEstado, pstrMunicipio, pDataVencimentoDateEdit, pstrCompetencia, pstrPeriodicidade, pintDiaVencimento, pstrTipoDia, pintSabDomUtil, pintAntecipaUtil, pintSubsequente, pstrTipoSubsequente)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function BuscaDados(ByRef pstrEmpresa As String, ByRef pstrCompetencia As String, ByRef pintExercicio As Integer, ByRef pstrObrigacao As String, pintSequenciaExtra As Integer) As Modelo.tarefasextrasInfo Implements DAL.ITarefasExtras.BuscaDados
        Try
            Return objTarefasExtras.BuscaDados(pstrEmpresa, pstrCompetencia, pintExercicio, pstrObrigacao, pintSequenciaExtra)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
