Imports Microsoft.Win32

Public Class RegistroDAL
    Public Function LocalizaChaveRegistro(pNomeRegistro As String, pNomeChave As String, pNome As String) As String
        Try
            Dim strValor As String = String.Empty
            Dim pRegKey As RegistryKey = Registry.LocalMachine.OpenSubKey(pNomeRegistro, True)
            pRegKey = pRegKey.OpenSubKey(pNomeChave)
            If Not pRegKey Is Nothing Then
                If Not pRegKey.GetValue(pNome) Is Nothing Then
                    strValor = pRegKey.GetValue(pNome).ToString
                End If
            End If
            Return strValor
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Sub GravaChaveRegistro(pNomeRegistro As String, pNomeChave As String, pNome As String, pValor As String)
        Try
            ' Cria uma nova chave sob  HKEY_LOCAL_MACHINE\Software
            Dim pRegKey As RegistryKey = Registry.LocalMachine.OpenSubKey(pNomeRegistro, True)
            ' Inclui mais uma sub chave
            Dim pnewkey As RegistryKey = pRegKey.CreateSubKey(pNomeChave)
            ' Atirbui o valor para a sub chave
            pnewkey.SetValue(pNome, pValor)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class
