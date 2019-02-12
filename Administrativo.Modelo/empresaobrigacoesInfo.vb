Public Class empresaobrigacoesInfo
    Public Property empresa() As String
    Public Property cnpjcpf() As String
    Public Property razaosocial() As String
    Public Property obrigacoes As List(Of empresaobrigacoes)
End Class

Public Class empresaobrigacoes
    Private _obrigacao As String
    Private _descricao As String
    Private _competenciaobsoleta As String

    Public Sub New(ByVal obrigacao As String, ByVal descricao As String, ByVal competenciaobsoleta As String)
        Me.descricao = descricao
        Me.obrigacao = obrigacao
        Me.competenciaobsoleta = competenciaobsoleta
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

    Public Property competenciaobsoleta() As String
        Get
            Return _competenciaobsoleta
        End Get
        Set(ByVal value As String)
            _competenciaobsoleta = value
        End Set
    End Property
End Class

Public Class sugereobrigacoeInfo
    Public Property empresa() As String
    Public Property tipoempresaescrita() As String
    Public Property tipolucro() As String
    Public Property tipoicms() As String
    Public Property tipoipi() As String
    Public Property temfolha() As Int32
    Public Property temcontabil() As Int32
    Public Property temescrita() As Int32
    Public Property temlalur() As Int32
    Public Property cnaesecao As List(Of cnaesecao)
End Class

Public Class cnaesecao
    Private _secao As String

    Public Sub New(ByVal secao As String)
        Me.secao = secao
    End Sub

    Public Property secao() As String
        Get
            Return _secao
        End Get
        Set(ByVal Valor As String)
            _secao = Valor
        End Set
    End Property
End Class

Public Class empresaobrigacoesrelatorioInfo
    Public Property empresa() As String
    Public Property obrigacao() As String
    Public Property competenciaobsoleta() As String
    Public Property descricao() As String
    Public Property razaosocial() As String
    Public Property tipolucro() As String
    Public Property tipolucrodesc() As String
    Public Property tipoempresa() As String
    Public Property tipoempresadesc() As String
End Class


