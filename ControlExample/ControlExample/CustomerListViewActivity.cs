using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace ControlExample
{
    [Activity(Label = "CustomerListViewActivity")]
    public class CustomerListViewActivity :AppCompatActivity
    {
        private List<Fruit> fruitList = new List<Fruit>();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.CustomerListView);
            var toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
            SupportActionBar.Title = "Hello from Toolbar";
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            SupportActionBar.SetHomeButtonEnabled(true);

            initFruits();// 初始化水果数据
            FruitAdapter adapter = new FruitAdapter(this, Resource.Layout.Fruit_item, fruitList);
            ListView listview = FindViewById<ListView>(Resource.Id.listView_fruit);
            listview.Adapter = adapter;

            listview.ItemClick += Listview_ItemClick;
            listview.ItemLongClick += Listview_ItemLongClick;
        }

        private void Listview_ItemLongClick(object sender, AdapterView.ItemLongClickEventArgs e)
        {
            Log.Info("listview", "long click");
            Fruit fruit = fruitList[e.Position];
            Toast.MakeText(this, fruit.Name, ToastLength.Short).Show();
        }

        private void Listview_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Log.Info("listview", "long click");
            Fruit fruit = fruitList[e.Position];
            Toast.MakeText(this, fruit.Name, ToastLength.Short).Show();
        }

        private void initFruits()
        {
            for (int i = 0; i < 2; i++)
            {
                Fruit apple = new Fruit("apple", Resource.Drawable.apple);
                Fruit banana = new Fruit("banana", Resource.Drawable.banana);
                Fruit orange = new Fruit("orange", Resource.Drawable.orange);

                fruitList.Add(apple);
                fruitList.Add(banana);
                fruitList.Add(orange);
            }
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            // 返回首页
            if (item.ItemId == Android.Resource.Id.Home)
                Finish();
            return base.OnOptionsItemSelected(item);
        }

    }
}