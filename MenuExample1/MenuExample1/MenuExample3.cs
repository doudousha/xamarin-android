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
    public class MenuExample3 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.MenuExample3);
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            menu.Add(1, 1, 0, "杜兰特");
            menu.Add(1, 2, 0, "库里");
            menu.Add(1, 3, 0, "汤普森");
            menu.Add(2, 1, 4, "科比");
            menu.Add(2, 1, 0, "张木木");

            return base.OnCreateOptionsMenu(menu);
        }
    }
}