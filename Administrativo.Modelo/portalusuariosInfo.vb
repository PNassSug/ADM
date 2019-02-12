Public Class portalusuariosInfo
    Public Property empresa() As String
    Public Property email() As String
    Public Property nome() As String
    Public Property ddd() As String
    Public Property telefone() As String
    Public Property sistemas As List(Of portalusuariossistemas)
End Class

Public Class portalusuariossistemas
    Private _sistema As String

    Public Sub New(ByVal sistema As String)
        Me.sistema = sistema
    End Sub

    Public Property sistema() As String
        Get
            Return _sistema
        End Get
        Set(ByVal Valor As String)
            _sistema = Valor
        End Set
    End Property
End Class
