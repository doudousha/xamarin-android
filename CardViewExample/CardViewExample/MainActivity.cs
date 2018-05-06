using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;

namespace CardViewExample
{
    [Activity(Label = "CardViewExample", MainLauncher = true, Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}

