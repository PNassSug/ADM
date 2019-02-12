Imports Administrativo.DAL

Public Class ParcelamentoBLL
    Implements IParcelamento

    Dim objParcelamento As New ParcelamentoDAL

    Public Sub Grid(ByRef pstrQuery As String, pdgGrid As DevExpress.XtraGrid.GridControl, pgvGrid As DevExpress.XtraGrid.Views.Grid.GridView, ByRef infoParcelamentoDetalhes As System.Collections.Generic.List(Of Modelo.parcelamentodetalhes), picStatusImageColection As DevExpress.Utils.ImageCollection) Implements DAL.IParcelamento.Grid
        Try
            objParcelamento.Grid(pstrQuery, pdgGrid, pgvGrid, infoParcelamentoDetalhes, picStatusImageColection)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Grid(ByRef pstrQuery() As String, ByRef pstrTituloGrid() As String, pdgGrid As DevExpress.XtraGrid.GridControl, pgvGrid As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridObrigacao As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridParcelamento As DevExpress.XtraGrid.Views.Grid.GridView, picStatusImageColection As DevExpress.Utils.ImageCollection) Implements DAL.IParcelamento.Grid
        Try
            objParcelamento.Grid(pstrQuery, pstrTituloGrid, pdgGrid, pgvGrid, pgvGridObrigacao, pgvGridParcelamento, picStatusImageColection)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub IUDParcelamento(ByRef pstrOperacao As String, ByRef infoParcelamento As Modelo.parcelamentoInfo, ByRef originalinfoinfoParcelamentoDetalhes As System.Collections.Generic.List(Of Modelo.parcelamentodetalhes)) Implements DAL.IParcelamento.IUDParcelamento
        Try
            If String.IsNullOrEmpty(infoParcelamento.empresa) Then Throw New Exception("A empresa deve ser preenchida")
            If String.IsNullOrEmpty(infoParcelamento.obrigacao) Then Throw New Exception("A obrigação deve ser preenchida")
            If infoParcelamento.detalhes.Count = 0 Then Throw New Exception("Deve incluir pelo menos um parcelamento")
            Dim strCompetencia As String = infoParcelamento.detalhes(infoParcelamento.detalhes.Count - 1).competencia.ToString

            Dim objDataBase As New DataBaseBLL
            If pstrOperacao = "alteracao" Then
                Dim intCount As Int32 = objDataBase.QuerySimples("select count(*) " +
                                                                   "from admcontroleadministrativo aca " +
                                                                  "where aca.empresa = '" + infoParcelamento.empresa + "' " +
                                                                    "and aca.obrigacao = '" + infoParcelamento.obrigacao + "' " +
                                                                    "and aca.sequenciaextra = " + infoParcelamento.sequenciaextra.ToString + " " +
                                                                    "and coalesce(aca.usuariogeracao,'') <> '' " +
                                                                    "and not aca.datahorageracao is null " +
                                                                    "and coalesce(aca.obrigacaoextra,0) = -1 " +
                                                                    "and invertecompetencia(aca.competencia) >= invertecompetencia('" + strCompetencia + "')")

                If intCount > 0 Then
                    Throw New Exception("Não será possivel alterar a competência final porque existem parcelas geradas")
                End If
            End If
            objParcelamento.IUDParcelamento(pstrOperacao, infoParcelamento, originalinfoinfoParcelamentoDetalhes)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function BuscaVencimento(ByRef pstrEstado As String, ByRef pstrMunicipio As String, ByRef pstrCompetencia As String, ByRef pstrPeriodicidade As String, ByRef pintDiaVencimento As Integer, ByRef pstrTipoDia As String, ByRef pintSabDomUtil As Integer, ByRef pintAntecipaUtil As Integer, ByRef pintSubsequente As Integer, ByRef pstrTipoSubsequente As String) As Date Implements DAL.IParcelamento.BuscaVencimento
        Try
            Return objParcelamento.BuscaVencimento(pstrEstado, pstrMunicipio, pstrCompetencia, pstrPeriodicidade, pintDiaVencimento, pstrTipoDia, pintSabDomUtil, pintAntecipaUtil, pintSubsequente, pstrTipoSubsequente)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
