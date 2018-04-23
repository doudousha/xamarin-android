using Android.App;
using Android.Content;
using Android.Widget;
using Android.OS;
using Android.Views;

namespace MenuExample1
{
    [Activity(Label = "MenuExample1", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.main);

            var btn1 = FindViewById<Button>(Resource.Id.button1);
            var btn2 = FindViewById<Button>(Resource.Id.button2);
            var btn3 = FindViewById<Button>(Resource.Id.button3);

            btn1.Click += delegate
            {
                Intent intent = new Intent(this, typeof(MenuExample1));
                StartActivity(intent);
            };

            btn2.Click += delegate
            {
                Intent intent = new Intent(this, typeof(MenuExample2));
                StartActivity(intent);
            };

            btn3.Click += delegate
            {
                Intent intent = new Intent(this, typeof(MenuExample3));
                StartActivity(intent);
            };
        }

        
    }


}

