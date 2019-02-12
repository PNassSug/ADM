Public Class aguardeWaitForm
    Sub New
        InitializeComponent()
        Me.textoprogressPanel.AutoHeight = True
    End Sub

    Public Overrides Sub SetCaption(ByVal caption As String)
        MyBase.SetCaption(caption)
        Me.textoprogressPanel.Caption = caption
    End Sub
    
    Public Overrides Sub SetDescription(ByVal description As String)
        MyBase.SetDescription(description)
        Me.textoprogressPanel.Description = description
    End Sub    

    Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
        MyBase.ProcessCommand(cmd, arg)
    End Sub

    Public Enum WaitFormCommand
        SomeCommandId
    End Enum
End Class
