Public Class maladiretaInfo
    Public Property maladireta() As Int32
    Public Property descricao() As String
    Public Property mensagem() As String
    Public Property obrigacoes As List(Of maladiretaobrigacoesInfo)
End Class

Public Class maladiretaobrigacoesInfo
    Private _obrigacao As String
    Private _descricao As String

    Public Sub New(ByVal obrigacao As String, ByVal descricao As String)
        Me.descricao = descricao
        Me.obrigacao = obrigacao
    End Sub

    Public Property obrigacao() As String
        Get
            Return _obrigacao
        End Get
        Set(ByVal Valor As String)
            _obrigacao = Valor
        End Set
    End Property

    Public Property descricao() As String
        Get
            Return _descricao
        End Get
        Set(ByVal value As String)
            _descricao = value
        End Set
    End Property
End Class