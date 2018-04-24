using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using ControlExample;
using Android.Support.V7.Widget;
using Android.Support.V7.App;

namespace ControlRecyclerView
{
    //  参考:https://blog.xamarin.com/recyclerview-highly-optimized-collections-for-android-apps/
    [Activity(Label = "ControlRecyclerView", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //  准备数据adapter
            List<Fruit> fruits = new List<Fruit>() {
                    new Fruit("apple","http://upload.wikimedia.org/wikipedia/commons/thumb/9/96/Portrait_Of_A_Baboon.jpg/314px-Portrait_Of_A_Baboon.jpg"),
                    new Fruit("banana","http://i.imgur.com/DvpvklR.png"),
                    new Fruit("orange","https://i2.wp.com/vanillicon.com/adfce267bd92bc3c23296082a49f7917_200.png?ssl=1")
            };
            var recyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView1);
            FruitAdapter adapter = new FruitAdapter(this, recyclerView, fruits);
            // 设置receclerview layout 
           
            var layoutManager = new LinearLayoutManager(this, LinearLayoutManager.Vertical, false);
            recyclerView.SetLayoutManager(layoutManager);
            //  设置recyclerView 的adapter
            recyclerView.SetAdapter(adapter);
        }
    }
}

