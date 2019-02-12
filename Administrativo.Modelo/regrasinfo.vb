Public Class regrasinfo
    Public Property regra() As Int32
    Public Property descricao() As String
    Public Property empresas As List(Of regrasempresasinfo)
    Public Property obrigacoes As List(Of regrasobrigacoesinfo)
End Class

Public Class regrasempresasinfo
    Private _empresa As String
    Private _razaosocial As String

    Public Sub New(ByVal empresa As String, ByVal razaosocial As String)
        Me.razaosocial = razaosocial
        Me.empresa = empresa
    End Sub

    Public Property empresa() As String
        Get
            Return _empresa
        End Get
        Set(ByVal Valor As String)
            _empresa = Valor
        End Set
    End Property

    Public Property razaosocial() As String
        Get
            Return _razaosocial
        End Get
        Set(ByVal value As String)
            _razaosocial = value
        End Set
    End Property

End Class

Public Class regrasobrigacoesinfo
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

Public Class regrasrelatorioInfo
    Public Property ordem() As Int32
    Public Property regra() As Int32
    Public Property descricao() As String
    Public Property tipo() As String
    Public Property codigo_emp_obr() As String
    Public Property descricao_emp_obr() As String
End Class