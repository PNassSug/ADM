Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Public Interface IComum
    Sub Browse(ByRef pstrQuery As String, ByVal pBindingSource As BindingSource)
    Sub DefineValoresDefault(ByRef pstrTabela As String, ByRef pstrCampoPrincipal As String, ByVal pPrincipalInicial As SearchLookUpEdit, ByVal pPrincipalFinal As SearchLookUpEdit, Optional ByRef pstrWhere As String = "")
    Function RetornaDescricao(ByRef pBindingSource As BindingSource, ByRef pintIndex As Integer, ByRef pstrCampo As String) As String
End Interface
