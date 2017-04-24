using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;

namespace TipCalc.Android
{
    [Activity(Label = "TipCalc Android", MainLauncher = true, Icon = "@drawable/icon", ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen(): base(Resource.Layout.SplashScreen)
        {
        }
    }
}
