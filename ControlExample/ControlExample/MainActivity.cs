using Android.App;
using Android.Content;
using Android.Widget;
using Android.OS;

namespace ControlExample
{
    [Activity(Label = "ControlExample", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var btnListView = FindViewById<Button>(Resource.Id.btn_listview);
            var btnCustomerListView = FindViewById<Button>(Resource.Id.customer_listview);
            btnListView.Click += delegate
            {
                var intent = new Intent(this, typeof(ListViewActivity));
                StartActivity(intent);
            };
            btnCustomerListView.Click += delegate
            {
                var intent = new Intent(this, typeof(CustomerListViewActivity));
                StartActivity(intent);
            };
        }
    }
}

