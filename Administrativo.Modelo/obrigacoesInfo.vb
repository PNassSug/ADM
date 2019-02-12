Public Class obrigacoesInfo
   Public Property obrigacao() As String
   Public Property descricao() As String
   Public Property parcelamento() As Int32
   Public Property envioautomatico() As Int32
   Public Property usuarioenvio() As String
   Public Property sistema() As String
   Public Property cpr() As Boolean
   Public Property iss() As Boolean
   Public Property eiss() As Boolean
   Public Property ie() As Boolean
   Public Property cnpj() As Boolean
   Public Property layout() As Int32
   Public Property variacao As List(Of obrigacoesvariacao)
End Class

Public Class obrigacoesvariacao
    Private Property _variacao As String
    Private Property _nomevariacao As String
    Private Property _periodicidade As String
    Private Property _tipodia As String
    Private Property _vencimento As Int32
    Private Property _tributo As String
    Private Property _competenciaobsoleta As String
    Private Property _subsequente As Int32
    Private Property _tiposubsequente As String
    Private Property _sabdomutil As Int32
    Private Property _antecipautil As Int32

    Public Sub New(ByVal variacao As String, ByVal nomevariacao As String, ByVal periodicidade As String, ByVal tipodia As String, ByVal vencimento As Int32, ByVal tributo As String,
                   ByVal competenciaobsoleta As String, ByVal subsequente As Int32, ByVal tiposubsequente As String, ByVal sabdomutil As Int32, ByVal antecipautil As Int32)
        Me.variacao = variacao
        Me.nomevariacao = nomevariacao
        Me.periodicidade = periodicidade
        Me.tipodia = tipodia
        Me.vencimento = vencimento
        Me.tributo = tributo
        Me.competenciaobsoleta = competenciaobsoleta
        Me.subsequente = subsequente
        Me.tiposubsequente = tiposubsequente
        Me.sabdomutil = sabdomutil
        Me.antecipautil = antecipautil
    End Sub

    Public Property variacao() As String
        Get
            Return _variacao
        End Get
        Set(ByVal Valor As String)
            _variacao = Valor
        End Set
    End Property

    Public Property nomevariacao() As String
        Get
            Return _nomevariacao
        End Get
        Set(ByVal Valor As String)
            _nomevariacao = Valor
        End Set
    End Property

    Public Property periodicidade() As String
        Get
            Return _periodicidade
        End Get
        Set(ByVal Valor As String)
            _periodicidade = Valor
        End Set
    End Property

    Public Property tipodia() As String
        Get
            Return _tipodia
        End Get
        Set(ByVal Valor As String)
            _tipodia = Valor
        End Set
    End Property

    Public Property vencimento() As Int32
        Get
            Return _vencimento
        End Get
        Set(ByVal Valor As Int32)
            _vencimento = Valor
        End Set
    End Property

    Public Property tributo() As String
        Get
            Return _tributo
        End Get
        Set(ByVal Valor As String)
            _tributo = Valor
        End Set
    End Property

    Public Property competenciaobsoleta() As String
        Get
            Return _competenciaobsoleta
        End Get
        Set(ByVal Valor As String)
            _competenciaobsoleta = Valor
        End Set
    End Property

    Public Property subsequente() As Int32
        Get
            Return _subsequente
        End Get
        Set(ByVal Valor As Int32)
            _subsequente = Valor
        End Set
    End Property

    Public Property tiposubsequente() As String
        Get
            Return _tiposubsequente
        End Get
        Set(ByVal Valor As String)
            _tiposubsequente = Valor
        End Set
    End Property

    Public Property sabdomutil() As Int32
        Get
            Return _sabdomutil
        End Get
        Set(ByVal Valor As Int32)
            _sabdomutil = Valor
        End Set
    End Property

    Public Property antecipautil() As Int32
        Get
            Return _antecipautil
        End Get
        Set(ByVal Valor As Int32)
            _antecipautil = Valor
        End Set
    End Property
End Class

Public Class obrigacoesrelatorioInfo
    Public Property obrigacao() As String
    Public Property descricao() As String
    Public Property parcelamento() As Int32
    Public Property sistema() As String
    Public Property periodicidade() As String
    Public Property vencimento() As Int32
    Public Property tipodia() As String
    Public Property tributo() As String
    Public Property competenciaobsoleta() As String
    Public Property subsequente() As Int32
    Public Property tiposubsequente() As String
    Public Property sabdomutil() As Int32
    Public Property antecipautil() As Int32
    Public Property tipo() As String
    Public Property varcod() As String
    Public Property vardet() As String
End Class

Public Class obrigacoesusuariosInfo
    Public Property usuario() As String
    Public Property obrigacoes As List(Of obrigacoesusuarios)
End Class

Public Class obrigacoesusuarios
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

