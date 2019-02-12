Imports Administrativo.Modelo
Imports Administrativo.DAL

Public Class ManutencaoObrigacoesBLL
    Implements IManutencaoObrigacoes

    Dim objManutencaoObrigacoes As New ManutencaoObrigacoesDAL

    Public Sub Grid(ByRef penuGrid As enuGridManutecaoObrigacao, ByRef infoManutencaoObrigacoes As Modelo.manutencaoobrigacoesInfo, pdgGrid As DevExpress.XtraGrid.GridControl, pgvGrid As DevExpress.XtraGrid.Views.Grid.GridView) Implements DAL.IManutencaoObrigacoes.Grid
        Try
            objManutencaoObrigacoes.Grid(penuGrid, infoManutencaoObrigacoes, pdgGrid, pgvGrid)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Grid(ByRef pstrQuery() As String, pdgGrid As DevExpress.XtraGrid.GridControl, pgvGrid As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridEmpresa As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridFuncionario As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridDetalheFuncionario As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridInforme As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridDetalheInforme As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridIcmsst As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridDetalheIcmsst As DevExpress.XtraGrid.Views.Grid.GridView, picStatusImageColection As DevExpress.Utils.ImageCollection, picTipoEnvioImageColection As DevExpress.Utils.ImageCollection, picVisualizacaoImageColection As DevExpress.Utils.ImageCollection) Implements DAL.IManutencaoObrigacoes.Grid
        Try
            objManutencaoObrigacoes.Grid(pstrQuery, pdgGrid, pgvGrid, pgvGridEmpresa, pgvGridFuncionario, pgvGridDetalheFuncionario, pgvGridInforme, pgvGridDetalheInforme, pgvGridIcmsst, pgvGridDetalheIcmsst, picStatusImageColection, picTipoEnvioImageColection, picVisualizacaoImageColection)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub IUDManutencaoObrigacoes(ByRef pstrOperacao As String, ByRef infoManutencaoObrigacoes As Modelo.manutencaoobrigacoesInfo) Implements DAL.IManutencaoObrigacoes.IUDManutencaoObrigacoes
      Try
         If String.IsNullOrEmpty(infoManutencaoObrigacoes.empresa) Then Throw New Exception("A empresa deve ser preenchida")
         If String.IsNullOrEmpty(infoManutencaoObrigacoes.obrigacao) Then Throw New Exception("A obrigação deve ser preenchida")
         If Not infoManutencaoObrigacoes.datavencimento.HasValue Then Throw New Exception("A data de vencimento deve ser preenchida")
         If Not String.IsNullOrEmpty(infoManutencaoObrigacoes.usuariogeracao) Then
            If Not infoManutencaoObrigacoes.datahorageracao.HasValue Then Throw New Exception("A data/hora de geração deve ser preenchida")
         End If
         If Not String.IsNullOrEmpty(portalservidorInfo.cnpjcpf) Then
            If infoManutencaoObrigacoes.tipoenvio = "S" Then
               If infoManutencaoObrigacoes.portalarquivos.Count > 0 Then
                  If String.IsNullOrEmpty(infoManutencaoObrigacoes.portalarquivos(0).usuarioenvio) Then Throw New Exception("É obrigatório o envio da obrigação pelo portal quando o método de entrega for site")
               ElseIf infoManutencaoObrigacoes.portalguias.Count > 0 Then
                  If String.IsNullOrEmpty(infoManutencaoObrigacoes.portalguias(0).usuarioenvio) Then Throw New Exception("É obrigatório o envio da obrigação pelo portal quando o método de entrega for site")
               End If
            End If
         End If
         objManutencaoObrigacoes.IUDManutencaoObrigacoes(pstrOperacao, infoManutencaoObrigacoes)
      Catch ex As Exception
         Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub IUDPortalGuias(ByRef pstrOperacao As String, ByRef infoManutencaoObrigacoes As Modelo.manutencaoobrigacoesInfo) Implements DAL.IManutencaoObrigacoes.IUDPortalGuias
        Try
            If String.IsNullOrEmpty(infoManutencaoObrigacoes.empresa) Then Throw New Exception("A empresa deve ser preenchida")
            If String.IsNullOrEmpty(infoManutencaoObrigacoes.obrigacao) Then Throw New Exception("A obrigação deve ser preenchida")
            objManutencaoObrigacoes.IUDPortalGuias(pstrOperacao, infoManutencaoObrigacoes)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function BuscaDados(ByRef pstrEmpresa As String, ByRef pstrCompetencia As String, ByRef pintExercicio As Integer, ByRef pstrObrigacao As String, ByRef pintSequenciaExtra As Integer, ByRef pintObrigacaoExtra As Integer, ByRef pstrFuncionario As String, ByRef pintParcela As Integer, ByRef pintTipoPessoaInforme As Integer, ByRef pintInforme As Integer) As Modelo.manutencaoobrigacoesInfo Implements DAL.IManutencaoObrigacoes.BuscaDados
        Try
            Return objManutencaoObrigacoes.BuscaDados(pstrEmpresa, pstrCompetencia, pintExercicio, pstrObrigacao, pintSequenciaExtra, pintObrigacaoExtra, pstrFuncionario, pintParcela, pintTipoPessoaInforme, pintInforme)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function UploadGuias(ByRef pstrDados As String, ByRef infoManutencaoObrigacoes As Modelo.manutencaoobrigacoesInfo) As Boolean Implements DAL.IManutencaoObrigacoes.UploadGuias
        Try
            If String.IsNullOrEmpty(infoManutencaoObrigacoes.portalguias(0).mensagem) Then Throw New Exception("É obrigatório informar uma mensagem antes do envio ao portal.")
            Return objManutencaoObrigacoes.UploadGuias(pstrDados, infoManutencaoObrigacoes)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Sub IUDPortalArquivos(ByRef pstrOperacao As String, ByRef infoManutencaoObrigacoes As Modelo.manutencaoobrigacoesInfo) Implements DAL.IManutencaoObrigacoes.IUDPortalArquivos
        Try
            If String.IsNullOrEmpty(infoManutencaoObrigacoes.empresa) Then Throw New Exception("A empresa deve ser preenchida")
            If String.IsNullOrEmpty(infoManutencaoObrigacoes.obrigacao) Then Throw New Exception("A obrigação deve ser preenchida")
            objManutencaoObrigacoes.IUDPortalArquivos(pstrOperacao, infoManutencaoObrigacoes)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function UploadArquivos(ByRef pbArquivos() As Byte, ByRef infoManutencaoObrigacoes As Modelo.manutencaoobrigacoesInfo) As Boolean Implements DAL.IManutencaoObrigacoes.UploadArquivos
        Try
            If String.IsNullOrEmpty(infoManutencaoObrigacoes.portalarquivos(0).arquivo) Then Throw New Exception("É obrigatório ter um arquivo antes do envio ao portal.")
            If String.IsNullOrEmpty(infoManutencaoObrigacoes.portalarquivos(0).mensagem) Then Throw New Exception("É obrigatório informar uma mensagem antes do envio ao portal.")
            Return objManutencaoObrigacoes.UploadArquivos(pbArquivos, infoManutencaoObrigacoes)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function DownloadArquivos(ByRef pstrCaminhoDownload As String, ByRef infoManutencaoObrigacoes As Modelo.manutencaoobrigacoesInfo) As String Implements DAL.IManutencaoObrigacoes.DownloadArquivos
        Try
            Return objManutencaoObrigacoes.DownloadArquivos(pstrCaminhoDownload, infoManutencaoObrigacoes)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Sub LogArquivos(ByRef infoManutencaoObrigacoes As Modelo.manutencaoobrigacoesInfo) Implements DAL.IManutencaoObrigacoes.LogArquivos
        Try
            objManutencaoObrigacoes.LogArquivos(infoManutencaoObrigacoes)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub LogGuias(ByRef infoManutencaoObrigacoes As Modelo.manutencaoobrigacoesInfo) Implements DAL.IManutencaoObrigacoes.LogGuias
        Try
            objManutencaoObrigacoes.LogGuias(infoManutencaoObrigacoes)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function BuscaAlertas() As manutencaoobrigacoesalerta Implements IManutencaoObrigacoes.BuscaAlertas
        Try
            Return objManutencaoObrigacoes.BuscaAlertas
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
