Public Class gruposacessoInfo
    Public Property sistema() As String
    Public Property grupo() As String
    Public Property opcao As List(Of menuInfo)
End Class

Public Class menuInfo
    Public Property opcao() As String
    Public Property operacao() As Int32
    Public Property descricao() As String
End Class
