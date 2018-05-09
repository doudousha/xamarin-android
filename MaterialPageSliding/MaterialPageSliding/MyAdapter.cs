using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;
using Java.Lang;

namespace MaterialPageSliding
{
    public class MyAdapter : FragmentPagerAdapter
    {
        private int tabCount = 3;
        public MyAdapter(Android.Support.V4.App.FragmentManager fragmentManager):base(fragmentManager)
        {
        }

        public override int Count => tabCount;

        public override ICharSequence GetPageTitleFormatted(int position)
        {
            ICharSequence cs;

            if (position == 0)
            {
                cs = new Java.Lang.String("Android");
            }
            else if (position == 1)
            {
                cs = new Java.Lang.String("IOS");
            }
            else {
                cs = new Java.Lang.String("UWP");
            }
            return cs;
        }

        public override Android.Support.V4.App.Fragment GetItem(int position)
        {
            return ContentFragment.NewInstance(position);
        }
    }
}