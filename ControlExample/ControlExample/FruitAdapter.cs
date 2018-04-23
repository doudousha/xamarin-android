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
            View view = LayoutInflater.From(this.Context)
                .Inflate(this.ResourceId, parent, false);

            ImageView fruitImage = view.FindViewById<ImageView>(Resource.Id.fruit_image);
            TextView fruitName = view.FindViewById<TextView>(Resource.Id.fruit_name);

            fruitImage.SetImageResource(fruit.ImageId);
            fruitName.Text = fruit.Name;
            return view;
        }
    }
}