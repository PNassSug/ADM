Public Class parcelamentoInfo
    Public Property empresa() As String
    Public Property obrigacao() As String
    Public Property sequenciaextra() As Int32
    Public Property detalhes As List(Of parcelamentodetalhes)
End Class

Public Class parcelamentodetalhes
    Private _parcela As Int32
    Private _competencia As String
    Private _datavencimento As Nullable(Of Date)
    Private _status As Int32

    Public Sub New(ByVal parcela As Int32, ByVal competencia As String, ByVal datavencimento As Nullable(Of Date), ByVal status As Int32)
        Me.parcela = parcela
        Me.competencia = competencia
        Me.datavencimento = datavencimento
        Me.status = status
    End Sub

    Public Property parcela() As Int32
        Get
            Return _parcela
        End Get
        Set(ByVal Valor As Int32)
            _parcela = Valor
        End Set
    End Property

    Public Property competencia() As String
        Get
            Return _competencia
        End Get
        Set(ByVal Valor As String)
            _competencia = Valor
        End Set
    End Property

    Public Property datavencimento() As Nullable(Of Date)
        Get
            Return _datavencimento
        End Get
        Set(ByVal Valor As Nullable(Of Date))
            _datavencimento = Valor
        End Set
    End Property

    Public Property status() As Int32
        Get
            Return _status
        End Get
        Set(ByVal Valor As Int32)
            _status = Valor
        End Set
    End Property
End Class
