using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace ControlExample
{
    [Activity(Label = "ListViewActivity")]
    public class ListViewActivity : Activity
    {
        private List<String> data;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Listview);
            data = new List<string>
            {
                "xiao ming",
                "xiao li",
                "wang ma zi",
                "li si",
                "xiao zhang ",
                "zheng kui ",
                "li da pang",
                "zhang xiao fei ",
                "mei guo ",
                "ying guo ",
                "xiang gang "
            };

            // 系统内置的textview 布局文件
            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this,Android.Resource.Layout.SimpleExpandableListItem1,data);
            // 查找 listView 
            ListView listview = FindViewById<ListView>(Resource.Id.listView1);
            listview.Adapter = adapter;
        }
    }
}