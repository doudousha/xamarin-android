using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Support.Design.Widget;

namespace BottomNavigationViewExample
{
    [Activity(Label = "BottomNavigationViewExample", MainLauncher = true, Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);

            var bottomNavigation = FindViewById<BottomNavigationView>(Resource.Id.bv);
            bottomNavigation.NavigationItemSelected += (sender, eArgs) => {
                switch (eArgs.Item.ItemId) {
                    case Resource.Id.item_add:
                        Toast.MakeText(this, "action add clicked", ToastLength.Short).Show();
                        break;
                    case Resource.Id.item_edit:
                        Toast.MakeText(this, "action edit clicked", ToastLength.Short).Show();
                        break;
                    case Resource.Id.item_delete:
                        Toast.MakeText(this, "action delete clicked",ToastLength.Short).Show();
                        break;
                }
            };
        }
    }
}

