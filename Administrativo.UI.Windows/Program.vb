Imports DevExpress.LookAndFeel

Namespace Administrativo
    Friend NotInheritable Class Program
        <STAThread()>
        Shared Sub Main()
            'Portugues - Brasil
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("pt-BR")
            System.Threading.Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo("pt-BR")

            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

            Application.Run(New principalRibbonForm())
        End Sub
    End Class
End Namespace