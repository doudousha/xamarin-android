using Android.App;
using Android.OS;
using Android.Support.V4.Widget;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Support.V4.View;

// 参考:https://blog.xamarin.com/add-beautiful-material-design-with-the-android-support-design-library/
namespace DrawerLayoutExample1
{
    // AppCompatActivity 必需设置Theme 否则报错
    [Activity(Label = "DrawerLayout_Activity", Theme = "@style/MyTheme")]
    public class DrawerLayoutActivity : AppCompatActivity
    {
        private DrawerLayout drawerLayout;
        private NavigationView navView;
        private MyToolbarDrawerToggle mDrawerToggle;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.DrawerLayout1);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
            drawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);

            mDrawerToggle = new MyToolbarDrawerToggle(
                    this,
                    drawerLayout,
                    Resource.String.Open,
                    Resource.String.Closed
                );

            drawerLayout.AddDrawerListener(mDrawerToggle);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);

            // 绑定NavigationView 事件
            NavigationView navView = FindViewById<NavigationView>(Resource.Id.nav_view);
            navView.NavigationItemSelected += (sender, eArgs)=>{
                drawerLayout.CloseDrawers();
            }; 

            if (savedInstanceState != null)
            {
                if (savedInstanceState.GetString("DrawerState") == "Open")
                {
                    SupportActionBar.SetTitle(Resource.String.Open);
                }
                else
                {
                    SupportActionBar.SetTitle(Resource.String.Closed);
                }

            }
            else
            {
                SupportActionBar.SetTitle(Resource.String.Closed);
            }
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            if (item.ItemId == global::Android.Resource.Id.Home)
            {
                mDrawerToggle.OnOptionsItemSelected(item);
                return true;
            }
            return base.OnOptionsItemSelected(item);
        }

        protected override void OnSaveInstanceState(Bundle outState)
        {
            if (drawerLayout.IsDrawerOpen((int)GravityFlags.Left))
            {
                outState.PutString("DrawerState", "Open");
            }
            else
            {
                outState.PutString("DraweState", "Closed");
            }

            base.OnSaveInstanceState(outState);
        }

        protected override void OnPostCreate(Bundle savedInstanceState)
        {
            base.OnPostCreate(savedInstanceState);
            mDrawerToggle.SyncState();
        }
    }
}