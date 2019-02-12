Imports System.Drawing
Imports System.Windows.Forms
Imports Microsoft.Win32
Imports Administrativo.Modelo

Public Class AdministrativoDAL
    Implements IAdministrativo

    Dim lstFrameWork As New List(Of frameworkInfo)
    Dim framework As New frameworkInfo

    Public Sub CentralizaForm(pForm As System.Windows.Forms.Control) Implements IAdministrativo.CentralizaForm
        Dim intScreenX As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim intScreenY As Integer = Screen.PrimaryScreen.WorkingArea.Height
        Dim intFormX As Integer = pForm.Size.Width
        Dim intFormY As Integer = pForm.Size.Height
        pForm.Location = New Point((intScreenX / 2) - (intFormX / 2), (intScreenY / 2) - (intFormY / 2))
    End Sub

    Public Sub VerificaVersao() Implements IAdministrativo.VerificaVersao
        Using ndpKey As RegistryKey = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, "").OpenSubKey("SOFTWARE\Microsoft\NET Framework Setup\NDP\")
            For Each versionKeyName As String In ndpKey.GetSubKeyNames()
                If versionKeyName.StartsWith("v") Then
                    Dim rkVersionKey As RegistryKey = ndpKey.OpenSubKey(versionKeyName)
                    Dim strName As String = DirectCast(rkVersionKey.GetValue("Version", ""), String)
                    Dim strSp As String = rkVersionKey.GetValue("SP", "").ToString()
                    Dim strInstall As String = rkVersionKey.GetValue("Install", "").ToString()
                    If strInstall = "" Then
                        ValidaChave(strName)
                    Else
                        If strSp <> "" AndAlso strInstall = "1" Then
                            ValidaChave(strName)
                        End If
                    End If
                    If strName <> "" Then
                        Continue For
                    End If
                    For Each subKeyName As String In rkVersionKey.GetSubKeyNames()
                        Dim subKey As RegistryKey = rkVersionKey.OpenSubKey(subKeyName)
                        strName = DirectCast(subKey.GetValue("Version", ""), String)
                        If strName <> "" Then
                            strSp = subKey.GetValue("SP", "").ToString()
                        End If
                        strInstall = subKey.GetValue("Install", "").ToString()
                        If Not String.IsNullOrEmpty(strInstall) Then
                            If strSp <> "" AndAlso strInstall = "1" Then
                                ValidaChave(strSp)
                            ElseIf strInstall = "1" Then
                                ValidaChave(strName)
                            End If
                        End If
                    Next
                End If
            Next
        End Using
        lstFrameWork.Add(framework)
        administrativoInfo.FrameWork = lstFrameWork
    End Sub

    Private Sub ValidaChave(pstrChave As String)
        Dim intTamanho As Int32 = 5
        If pstrChave.Length < 5 Then
            intTamanho = pstrChave.Length
        End If
        If pstrChave.Substring(0, intTamanho) >= "4.5" Then
            framework.Framework4_5 = True
        End If
    End Sub
End Class
