Imports Administrativo.DAL

Public Class PortalUsuariosBLL
    Implements IPortalUsuarios

    Dim objPortalUsuarios As New PortalUsuariosDAL

    Public Sub Grid(ByRef pstrQuery As String, pdgGrid As DevExpress.XtraGrid.GridControl, pgvGrid As DevExpress.XtraGrid.Views.Grid.GridView, ByRef infoSistemas As System.Collections.Generic.List(Of Modelo.portalusuariossistemas)) Implements DAL.IPortalUsuarios.Grid
        Try
            objPortalUsuarios.Grid(pstrQuery, pdgGrid, pgvGrid, infoSistemas)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Grid(ByRef pstrQuery() As String, ByRef pstrTituloGrid() As String, pdgGrid As DevExpress.XtraGrid.GridControl, pgvGrid As DevExpress.XtraGrid.Views.Grid.GridView, pgvGridSistema As DevExpress.XtraGrid.Views.Grid.GridView) Implements DAL.IPortalUsuarios.Grid
        Try
            objPortalUsuarios.Grid(pstrQuery, pstrTituloGrid, pdgGrid, pgvGrid, pgvGridSistema)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub IUDPortalUsuarios(ByRef pstrOperacao As String, ByRef pstrFiltroEmail As String, ByRef infoPortalUsuarios As Modelo.portalusuariosInfo, ByRef originalinfoSistemas As System.Collections.Generic.List(Of Modelo.portalusuariossistemas)) Implements DAL.IPortalUsuarios.IUDPortalUsuarios
        Try
            If String.IsNullOrEmpty(infoPortalUsuarios.empresa) Then Throw New Exception("A empresa deve ser preenchida")
            If String.IsNullOrEmpty(infoPortalUsuarios.email) Then Throw New Exception("O email deve ser preenchido")
            If String.IsNullOrEmpty(infoPortalUsuarios.nome) Then Throw New Exception("O nome deve ser preenchido")
            If infoPortalUsuarios.sistemas.Count = 0 Then Throw New Exception("Deve incluir pelo menos um sistema")
            Dim objDataBase As New DataBaseBLL
            If pstrOperacao = "inclusao" Then
                Dim intCount As Int32 = objDataBase.QuerySimples("select count(*) " +
                                                                   "from admusuariosempresassistemasportal aou " +
                                                                  "where aou.empresa = '" + infoPortalUsuarios.empresa + "' " +
                                                                    "and aou.email = '" + infoPortalUsuarios.email + "'")
                If (intCount > 0) Then Throw New Exception("Já existem sistemas configurados para essa empresa/email")
            ElseIf pstrOperacao = "alteracao" Then
                If pstrFiltroEmail <> infoPortalUsuarios.email Then
                    Dim intCount As Int32 = objDataBase.QuerySimples("select count(*) " +
                                                       "from admusuariosempresassistemasportal aou " +
                                                      "where aou.empresa = '" + infoPortalUsuarios.empresa + "' " +
                                                        "and aou.email = '" + infoPortalUsuarios.email + "'")

                    If intCount > 0 Then
                        infoPortalUsuarios.email = pstrFiltroEmail
                        Throw New Exception("Já existem sistemas configurados para essa empresa/email")
                    End If
                End If
            End If
            objPortalUsuarios.IUDPortalUsuarios(pstrOperacao, pstrFiltroEmail, infoPortalUsuarios, originalinfoSistemas)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub SincronizarPortalUsuarios(ByRef pstrOperacao As String, ByRef infoPortalUsuarios As Modelo.portalusuariosInfo) Implements DAL.IPortalUsuarios.SincronizarPortalUsuarios
        Try
            objPortalUsuarios.SincronizarPortalUsuarios(pstrOperacao, infoPortalUsuarios)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class
