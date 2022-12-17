Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports DevExpress.Mvvm.DataAnnotations
Imports System
Imports System.Threading

Namespace DXSampleSplashScreenService.ViewModel

    <POCOViewModel>
    Public Class MainViewModel

        Public Overridable Property Delay As Integer

        Protected ReadOnly Property SplashScreenService As ISplashScreenService
            Get
                Return GetService(Of ISplashScreenService)()
            End Get
        End Property

        Public Sub New()
            Delay = 10
        End Sub

        Public Sub Calculate()
            SplashScreenService.ShowSplashScreen()
            SplashScreenService.SetSplashScreenState("Calculating...")
            Thread.Sleep(TimeSpan.FromSeconds(Delay))
            SplashScreenService.SetSplashScreenState("Finished.")
            Thread.Sleep(TimeSpan.FromSeconds(2))
            SplashScreenService.HideSplashScreen()
        End Sub
    End Class
End Namespace
