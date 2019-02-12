Imports Administrativo.Modelo
Imports Administrativo.DAL

Public Class UsuarioBLL
    Implements IUsuario

    Dim objUsuario As New UsuarioDAL

    Public Function LoginValido(pstrUsuario As String, pstrSenha As String) As Boolean Implements DAL.IUsuario.LoginValido
        If String.IsNullOrEmpty(pstrUsuario) Then Throw New Exception("O usuário deve ser informado")
        If String.IsNullOrEmpty(pstrSenha) Then Throw New Exception("A senha deve ser informada")
        Return objUsuario.LoginValido(pstrUsuario, pstrSenha)
    End Function

    Public Sub Grid(ByRef pstrQuery As String, pdgGrid As DevExpress.XtraGrid.GridControl, pgvGrid As DevExpress.XtraGrid.Views.Grid.GridView) Implements DAL.IUsuario.Grid
        Try
            objUsuario.Grid(pstrQuery, pdgGrid, pgvGrid)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub IUDUsuarios(ByRef pstrOperacao As String, ByRef infoUsuarios As Modelo.usuariocadastroInfo) Implements DAL.IUsuario.IUDUsuarios
        Try
            If pstrOperacao = "inclusao" Or pstrOperacao = "alteracao" Then
                If String.IsNullOrEmpty(infoUsuarios.login) Then Throw New Exception("O login deve ser informado")
                If String.IsNullOrEmpty(infoUsuarios.nome) Then Throw New Exception("O nome deve ser informado")
                If String.IsNullOrEmpty(infoUsuarios.grupo) Then Throw New Exception("O grupo deve ser informado")
                If String.IsNullOrEmpty(infoUsuarios.nivel) Then Throw New Exception("O ní­vel deve ser informado")
                If pstrOperacao = "inclusao" Then
                    If String.IsNullOrEmpty(infoUsuarios.senha) Then Throw New Exception("A senha deve ser informada")
                    Dim objDataBase As New DataBaseBLL
                    Dim intCount As Int32 = objDataBase.QuerySimples("select count(*) " +
                                                                       "from usuarios u " +
                                                                       "join usernivel n on n.login = u.login and n.sistema = 'Administrativo' " +
                                                                       "where u.login = '" + infoUsuarios.login + "'")
                    If (intCount > 0) Then Throw New Exception("Login já existente")
                End If
                If (usuarioInfo.usuario = infoUsuarios.login And usuarioInfo.grupo <> infoUsuarios.grupo) Then Throw New Exception("Não é permitido alterar o Grupo para o usuário que está logado")
            Else
                If (usuarioInfo.usuario = infoUsuarios.login) Then Throw New Exception("Não é permitido excluir o usuário que está logado")
            End If

            objUsuario.IUDUsuarios(pstrOperacao, infoUsuarios)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub VisualizaGrupoAcesso(ByRef pstrQuery As String, ByRef pstrCampoPai As String, ByRef pstrCampoFilho As String, ptlGrupoAcesso As DevExpress.XtraTreeList.TreeList) Implements DAL.IUsuario.VisualizaGrupoAcesso
        Try
            objUsuario.VisualizaGrupoAcesso(pstrQuery, pstrCampoPai, pstrCampoFilho, ptlGrupoAcesso)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function RetornaGrupoAcessoUsuario() As Modelo.usuariogruposacessoInfo Implements DAL.IUsuario.RetornaGrupoAcessoUsuario
        Try
            Return objUsuario.RetornaGrupoAcessoUsuario()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function RetornaGrupoAcessoUsuario(pstrOpcao As String) As Modelo.usuariogruposacessoInfo Implements DAL.IUsuario.RetornaGrupoAcessoUsuario
        Try
            Return objUsuario.RetornaGrupoAcessoUsuario(pstrOpcao)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function UsuarioTemAcesso(pInfogrupoacesso As Modelo.usuariogruposacessoInfo, pstrOpcao As String) As Boolean Implements DAL.IUsuario.UsuarioTemAcesso
        Try
            Return objUsuario.UsuarioTemAcesso(pInfogrupoacesso, pstrOpcao)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function BuscaUsuario(ByRef pstrUsuario As String, infoUsuarios As Modelo.usuariocadastroInfo) As Boolean Implements DAL.IUsuario.BuscaUsuario
        Try
            Return objUsuario.BuscaUsuario(pstrUsuario, infoUsuarios)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class