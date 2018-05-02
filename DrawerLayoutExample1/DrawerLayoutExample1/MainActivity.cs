using Android.App;
using Android.OS;
using Android.Support.V4.Widget;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Support.V4.View;
using Android.Widget;
using Android.Content;

namespace DrawerLayoutExample1
{
    [Activity(Label = "DrawerLayout", MainLauncher = true,Theme ="@style/MyTheme")]
    public class MainActivity : AppCompatActivity
    {
     
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            var btn_openDrawLayout = FindViewById<Button>(Resource.Id.btn_openDrawLayout);

            btn_openDrawLayout.Click += Btn_openDrawLayout_Click;

        }

        private void Btn_openDrawLayout_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(DrawerLayoutActivity));
            StartActivity(intent);
        }
    }
}

