Imports Administrativo.Modelo
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraTreeList

Public Interface IUsuario
    Function LoginValido(pstrUsuario As String, pstrSenha As String) As Boolean
    Function RetornaGrupoAcessoUsuario() As usuariogruposacessoInfo
    Function RetornaGrupoAcessoUsuario(pstrOpcao As String) As usuariogruposacessoInfo
    Function UsuarioTemAcesso(pInfogrupoacesso As usuariogruposacessoInfo, pstrOpcao As String) As Boolean
    Function BuscaUsuario(ByRef pstrUsuario As String, ByVal infoUsuarios As usuariocadastroInfo) As Boolean
    Sub IUDUsuarios(ByRef pstrOperacao As String, ByRef infoUsuarios As usuariocadastroInfo)
    Sub Grid(ByRef pstrQuery As String, ByVal pdgGrid As GridControl, ByVal pgvGrid As GridView)
    Sub VisualizaGrupoAcesso(ByRef pstrQuery As String, ByRef pstrCampoPai As String, ByRef pstrCampoFilho As String, ByVal ptlGrupoAcesso As TreeList)
End Interface