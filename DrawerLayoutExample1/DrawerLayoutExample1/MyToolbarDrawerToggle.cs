using Android.Views;
using Android.Widget;
using SupportActionBarDrawerToggle = Android.Support.V7.App.ActionBarDrawerToggle;
using Android.Support.V7.App;
using Android.Support.V4.Widget;

namespace DrawerLayoutExample1
{
    class MyToolbarDrawerToggle : SupportActionBarDrawerToggle
    {
        private AppCompatActivity mActivity;
        private int mOpenedResource;
        private int mClosedResource;

        public MyToolbarDrawerToggle(AppCompatActivity parent, DrawerLayout drawerLayout, int openedResource, int closedResource)
            : base(parent, drawerLayout, openedResource, closedResource)
        {
            mActivity = parent;
            mOpenedResource = openedResource;
            mClosedResource = closedResource;
        }

        public override void OnDrawerOpened(View drawerView)
        {
            base.OnDrawerOpened(drawerView);
            mActivity.SupportActionBar.SetTitle(mOpenedResource);
        }

        public override void OnDrawerClosed(View drawerView)
        {
            base.OnDrawerClosed(drawerView);
            mActivity.SupportActionBar.SetTitle(mClosedResource);
        }

        public override void OnDrawerSlide(View drawerView, float slideOffset)
        {
            base.OnDrawerSlide(drawerView, slideOffset);
        }
    }
}