Public Class feriadosInfo
    Public Property data() As String
    Public Property descricao() As String
    Public Property tipoferiado() As String
    Public Property tipodata() As String
    Public Property filtro As List(Of feriadosfiltro)
End Class

Public Class feriadosfiltro
    Private _filtro As String
    Private _nome As String

    Public Sub New(ByVal filtro As String, ByVal nome As String)
        Me.filtro = filtro
        Me.nome = nome
    End Sub

    Public Property filtro() As String
        Get
            Return _filtro
        End Get
        Set(ByVal Valor As String)
            _filtro = Valor
        End Set
    End Property

    Public Property nome() As String
        Get
            Return _nome
        End Get
        Set(ByVal Valor As String)
            _nome = Valor
        End Set
    End Property
End Class
