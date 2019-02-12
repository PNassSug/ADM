Imports Administrativo.DAL

Public Class ComumBLL
    Implements IComum

    Dim objComum As New ComumDAL

    Public Sub Browse(ByRef pstrQuery As String, pBindingSource As System.Windows.Forms.BindingSource) Implements DAL.IComum.Browse
        Try
            objComum.Browse(pstrQuery, pBindingSource)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub DefineValoresDefault(ByRef pstrTabela As String, ByRef pstrCampoPrincipal As String, pPrincipalInicial As DevExpress.XtraEditors.SearchLookUpEdit, pPrincipalFinal As DevExpress.XtraEditors.SearchLookUpEdit, Optional ByRef pstrWhere As String = "") Implements DAL.IComum.DefineValoresDefault
        Try
            objComum.DefineValoresDefault(pstrTabela, pstrCampoPrincipal, pPrincipalInicial, pPrincipalFinal, pstrWhere)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function RetornaDescricao(ByRef pBindingSource As System.Windows.Forms.BindingSource, ByRef pintIndex As Integer, ByRef pstrCampo As String) As String Implements DAL.IComum.RetornaDescricao
        Try
            Return objComum.RetornaDescricao(pBindingSource, pintIndex, pstrCampo)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
