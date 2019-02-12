Public Class administrativoInfo
    Public Shared Exercicio As Int32
    Public Shared Competencia As String = String.Empty
    Public Shared Empresa As String = String.Empty
    Public Shared Registro As String = String.Empty
    Public Shared DesconsideraPortal As Boolean = False
    Public Shared FrameWork As List(Of frameworkInfo)
End Class

Public Class frameworkInfo
    Public Property Framework4_5 As Boolean
End Class