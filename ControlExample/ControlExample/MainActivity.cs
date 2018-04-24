using Android.App;
using Android.Content;
using Android.Widget;
using Android.OS;
using Android.Views;
using Android.Support.V7.App;

namespace ControlExample
{
    [Activity(Label = "ControlExample", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
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

