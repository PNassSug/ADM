Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB

Public Class ComumDAL
    Implements IComum

    Public Sub Browse(ByRef pstrQuery As String, pBindingSource As System.Windows.Forms.BindingSource) Implements IComum.Browse
        Try
            Dim objDataBase As New DataBaseDAL
            pBindingSource.DataSource = objDataBase.QueryDataView(pstrQuery)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub DefineValoresDefault(ByRef pstrTabela As String, ByRef pstrCampoPrincipal As String, pPrincipalInicial As DevExpress.XtraEditors.SearchLookUpEdit, pPrincipalFinal As DevExpress.XtraEditors.SearchLookUpEdit, Optional ByRef pstrWhere As String = "") Implements IComum.DefineValoresDefault
        Try
            Dim objDataBase As New DataBaseDAL
            Dim strQuery As String = "select min(" + pstrCampoPrincipal + ") as inicial, max(" + pstrCampoPrincipal + ") as final " +
                                       "from " + pstrTabela + " "
            If Not String.IsNullOrEmpty(pstrWhere) Then
                strQuery += "where " + pstrWhere
            End If
            Dim sdData As SelectedData = objDataBase.QueryFull(strQuery)

            For Each row As SelectStatementResultRow In sdData.ResultSet(1).Rows
                pPrincipalInicial.EditValue = row.Values(0)
                pPrincipalFinal.EditValue = row.Values(1)
            Next row
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function RetornaDescricao(ByRef pBindingSource As System.Windows.Forms.BindingSource, ByRef pintIndex As Integer, ByRef pstrCampo As String) As String Implements IComum.RetornaDescricao
        Try
            Dim dvtable As XPDataView = CType(pBindingSource.DataSource, XPDataView)
            Dim strRetornaDescricao As String = String.Empty
            If Not dvtable(pintIndex).Item(pstrCampo) Is Nothing Then
                strRetornaDescricao = dvtable(pintIndex).Item(pstrCampo).ToString
            End If
            Return strRetornaDescricao
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
