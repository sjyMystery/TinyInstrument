using Android.App;
using Android.Widget;
using Android.OS;

namespace TinyInstrument
{
    [Activity(Label = "TinyInstrument", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            //test for git
            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
        }
    }
}

