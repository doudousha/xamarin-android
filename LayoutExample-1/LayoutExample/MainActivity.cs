using Android.App;
using Android.Content;
using Android.Widget;
using Android.OS;

namespace LayoutExample
{
    [Activity(Label = "LayoutExample", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var linearBtn = FindViewById<Button>(Resource.Id.linearBtn);
            var relativeBtn = FindViewById<Button>(Resource.Id.relativeBtn);

            linearBtn.Click += LinearBtn_Click;
            relativeBtn.Click += delegate
            {
                var linearLayout = new Intent(this, typeof(RelativeLayoutExample));
                linearLayout.PutExtra("MyData", "Data from Activity1");
                StartActivity(linearLayout);
            };
        }

        private void LinearBtn_Click(object sender, System.EventArgs e)
        {
            var linearLayout = new Intent(this, typeof(LineearLayout));
            linearLayout.PutExtra("MyData", "Data from Activity1");
            StartActivity(linearLayout);
        }
    }
}

