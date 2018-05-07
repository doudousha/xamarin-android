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
using Java.Lang;
using SqlLiteExample.Resources.DataHelper;

namespace SqlLiteExample.Resources
{

    public class ViewHolder
    {
        public TextView TxtName { get; set; }
        public TextView TxtAge { get; set; }
        public TextView TxtEmail { get; set; }
    }
    public class ListViewAdapter : ArrayAdapter<Person>
    {

        public int ResourceId { get; set; }

        public ListViewAdapter(Context context, int textViewResourceId, List<Person> objects) : base(context, textViewResourceId, objects)
        {
            this.ResourceId = textViewResourceId;
        }

        

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            // TODO Inflate 第三个参数说明
            var view = convertView ?? LayoutInflater.From(this.Context).Inflate(ResourceId, parent,false);

            var txtName = view.FindViewById<TextView>(Resource.Id.txt_name);
            var txtAge = view.FindViewById<TextView>(Resource.Id.txt_age);
            var txtEmail = view.FindViewById<TextView>(Resource.Id.txt_email);

            var person = GetItem(position);
            txtName.Text = person.Name;
            txtAge.Text = person.Age.ToString();
            txtEmail.Text = person.Email;
            return view;
        }
    }
}