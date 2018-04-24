using Android.Content;
using Android.Text.Style;
using Android.Views;
using Android.Widget;
using System.Collections.Generic;

namespace ControlExample
{
    public class FruitAdapter  :ArrayAdapter<Fruit>
    {

        public int ResourceId { get; set; }

        public FruitAdapter(Context context, int textViewResourceId,List<Fruit> objects) : base(context, textViewResourceId, objects)
        {
            this.ResourceId = textViewResourceId;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            Fruit fruit = GetItem(position);
            View view;
            MyViewHolder viewHolder;
            if (convertView == null)
            {
                view = LayoutInflater.From(this.Context).Inflate(this.ResourceId, parent, false);
                viewHolder = new MyViewHolder();
                viewHolder.fruitImage = view.FindViewById<ImageView>(Resource.Id.fruit_image);
                viewHolder.fruitName = view.FindViewById<TextView>(Resource.Id.fruit_name);
                view.Tag = viewHolder; // 缓存到tag 中
            }
            else {
                view = convertView;
                viewHolder = view.Tag as MyViewHolder;
            }

            viewHolder.fruitImage.SetImageResource(fruit.ImageId);
            viewHolder.fruitName.Text = fruit.Name;
            return view;
        }
    }
}