Imports Administrativo.DAL

Public Class GruposAcessoBLL
    Implements IGruposAcesso

    Dim objGrupoAcesso As New GruposAcessoDAL

    Public Sub Grid(ByRef pstrQuery As String, pdgGrid As DevExpress.XtraGrid.GridControl, pgvGrid As DevExpress.XtraGrid.Views.Grid.GridView) Implements DAL.IGruposAcesso.Grid
        Try
            objGrupoAcesso.Grid(pstrQuery, pdgGrid, pgvGrid)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub IUDGruposAcesso(ByRef pstrOperacao As String, ByRef infoGruposAcesso As Modelo.gruposacessoInfo) Implements DAL.IGruposAcesso.IUDGruposAcesso
        Try
            If pstrOperacao = "inclusao" Or pstrOperacao = "alteracao" Then
                If String.IsNullOrEmpty(infoGruposAcesso.grupo) Then Throw New Exception("O grupo deve ser informado")
                If infoGruposAcesso.opcao.Count = 0 Then Throw New Exception("Deve existir ao menos uma opção selecionada")
            End If
            objGrupoAcesso.IUDGruposAcesso(pstrOperacao, infoGruposAcesso)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub

    Public Sub VisualizaGrupoAcesso(ByRef pstrQuery As String, ByRef pstrCampoPai As String, ByRef pstrCampoFilho As String, ptlGrupoAcesso As DevExpress.XtraTreeList.TreeList) Implements DAL.IGruposAcesso.VisualizaGrupoAcesso
        Try
            objGrupoAcesso.VisualizaGrupoAcesso(pstrQuery, pstrCampoPai, pstrCampoFilho, ptlGrupoAcesso)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class
