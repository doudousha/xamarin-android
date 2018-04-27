using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using ControlExample;
using Android.Support.V7.Widget;
using Android.Support.V7.App;
using Android.Content;

namespace ControlRecyclerView
{
   
    [Activity(Label = "ControlRecyclerView", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var btn1 = FindViewById<Button>(Resource.Id.button1);
            var btn2 = FindViewById<Button>(Resource.Id.button2);

            // 聊天消息
            btn1.Click += (sender, eArgs) => {
                Intent intent = new Intent(this,typeof(MsgActivity));
                StartActivity(intent);
            };
                
            // 苹果列表
            btn2.Click += (sender, eArgs) => {
                Intent intent = new Intent(this, typeof(FruitActivity));
                StartActivity(intent);
            };
          
        }

    }
}

