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

namespace ControlExample
{
    // 参考:https://blog.xamarin.com/creating-highly-performant-smooth-scrolling-android-listviews/
    public class MyViewHolder : Java.Lang.Object 
    {
        public ImageView fruitImage  { get; set; }
        public TextView fruitName { get; set; }
    }
}