Imports System.Windows
Imports DevExpress.Xpf.Core

Namespace T439912

    ''' <summary>
    ''' Interaction logic for App.xaml
    ''' </summary>
    Public Partial Class App
        Inherits Application

        Protected Overrides Sub OnStartup(ByVal e As StartupEventArgs)
            MyBase.OnStartup(e)
            ApplicationThemeHelper.ApplicationThemeName = Theme.Office2013LightGrayName
        End Sub
    End Class
End Namespace
