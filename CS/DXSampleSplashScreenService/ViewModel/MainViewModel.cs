using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataAnnotations;
using System;
using System.Threading;

namespace DXSampleSplashScreenService.ViewModel {
    [POCOViewModel]
    public class MainViewModel {
        public virtual int Delay { get; set; }
        protected ISplashScreenService SplashScreenService { get { return this.GetService<ISplashScreenService>(); } }
        
        public MainViewModel() {
            Delay = 10;
        }

        public void Calculate() {
            SplashScreenService.ShowSplashScreen();
            SplashScreenService.SetSplashScreenState("Calculating...");
            Thread.Sleep(TimeSpan.FromSeconds(Delay));
            SplashScreenService.SetSplashScreenState("Finished.");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            SplashScreenService.HideSplashScreen();
        }
    }
}
