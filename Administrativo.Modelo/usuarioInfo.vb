Public Class usuarioInfo
    Public Shared usuario As String = String.Empty
    Public Shared logado As Boolean = False
    Public Shared grupo As String = String.Empty
    Public Shared master As Boolean = False
    Public Shared nivel As String = String.Empty
    Public Shared obrigacoes As Boolean = False
    Public Shared alertarvencimento As Boolean = False
    Public Shared diasalerta As Int32 = 0
    Public Shared trocausuario As Boolean = False
End Class

Public Class usuariocadastroInfo
    Public Property login() As String
    Public Property nome() As String
    Public Property email() As String
    Public Property departamento() As String
    Public Property grupo() As String
    Public Property senha() As String
    Public Property nivel() As String
    Public Property usuariomaster() As Int32
    Public Property alertarvencimentoobrigacao() As Int32
    Public Property diasantesalerta() As Int32
    Public Property assinatura() As String
End Class

Public Class usuariogruposacessoInfo
    Public Property login() As String
    Public Property grupo() As String
    Public Property opcao As List(Of usuariomenuInfo)
End Class

Public Class usuariomenuInfo
    Public Property opcao() As String
    Public Property operacao() As Int32
End Class
