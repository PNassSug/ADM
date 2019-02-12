Public Class administrativoSplashScreen
    Sub New
        InitializeComponent()
        versaosistemaLabelControl.Text = "Versão: " + My.Application.Info.Version.ToString()
    End Sub

    Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
        MyBase.ProcessCommand(cmd, arg)
    End Sub

    Public Enum SplashScreenCommand
        SomeCommandId
    End Enum
End Class
