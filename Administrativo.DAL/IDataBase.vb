Imports DevExpress.XtraEditors
Imports DevExpress.Xpo

Public Interface IDataBase
    Sub RefreshDataBase(pDataBaseComboBoxEdit As ComboBoxEdit, pstrServer As String, pstrUsuario As String, pstrSenha As String, pstrPorta As String)
    Sub RefreshDataBase(pDataBaseComboBoxEdit As ComboBoxEdit, pstrServer As String, pstrUsuario As String, pstrSenha As String)
    Sub BuscaConfiguracaoBancoDados(pstrNomeProduto As String)
    Sub NonQuery(pstrQuery)
    Sub CriaTemporaria(pstrTabela As String, pstrQuery As String)
    Sub ApagarTemporaria(pstrTabela As String)
    Function ConectarDataBase() As Boolean
    Function QuerySimples(pstrQuery As String) As Object
    Function QueryFull(pstrQuery As String) As Object
    Function QueryDataView(pstrQuery As String) As XPDataView
End Interface
