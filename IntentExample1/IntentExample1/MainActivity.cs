using Android.App;
using Android.Content;
using Android.Net;
using Android.Widget;
using Android.OS;

namespace IntentExample1
{
    [Activity(Label = "IntentExample1", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var openSina = FindViewById<Button>(Resource.Id.button1);
            var openTel = FindViewById<Button>(Resource.Id.button2);

            openSina.Click += delegate
            {
                var intent = new Intent(Intent.ActionView);
                intent.SetData(Uri.Parse("http://www.sina.com.cn/"));
                StartActivity(intent);
            };

            openTel.Click += delegate
            {
                var intent = new Intent(Intent.ActionDial);
                intent.SetData(Uri.Parse("tel:10086"));
                StartActivity(intent);
            };
        }
    }
}

