using Android.App;
using Android.Widget;
using Android.OS;
using com.refractored;
using Android.Support.V7.App;

namespace MaterialPageSliding
{
    [Activity(Label = "MaterialPageSliding", MainLauncher = true,Theme ="@style/Theme.AppCompat.Light.NoActionBar")]
    public class MainActivity : AppCompatActivity
    {

        private MyAdapter adapter;
        private PagerSlidingTabStrip tabs;
        private Android.Support.V4.View.ViewPager pager;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            pager = FindViewById<Android.Support.V4.View.ViewPager>(Resource.Id.pager);
            tabs = FindViewById<PagerSlidingTabStrip>(Resource.Id.tabs);

            adapter = new MyAdapter(SupportFragmentManager);
            pager.Adapter = adapter;
            tabs.SetViewPager(pager);
            tabs.SetBackgroundColor(Android.Graphics.Color.Argb(255, 0, 149, 164));


        }
    }
}

