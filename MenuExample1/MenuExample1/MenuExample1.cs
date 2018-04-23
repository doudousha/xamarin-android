using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MenuExample1
{
    [Activity(Label = "MenuExample1")]
    public class MenuExample1 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.MenuExample1);
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.main, menu);
            return base.OnPrepareOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.add_item:
                    Toast.MakeText(this, "You clicked add", ToastLength.Short).Show();
                    break;
                case Resource.Id.remove_item:
                    Toast.MakeText(this, "You clicked remove", ToastLength.Short).Show();
                    break;
            }

            return true;
        }
    }
}