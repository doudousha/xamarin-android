
using Android.App;
using Android.Content;
using Android.Support.V7.Widget;
using Android.Text.Style;
using Android.Util;
using Android.Views;
using Android.Widget;
using ControlRecyclerView;
using Square.Picasso;
using System.Collections.Generic;

namespace ControlExample
{
    public class FruitAdapter  : RecyclerView.Adapter
    {
        private RecyclerView recyler;

        public Activity activity { get; set; }
        public List<Fruit>  fruits  { get; set; }

        public override int ItemCount =>fruits.Count;

        public FruitAdapter(Activity activity, RecyclerView recyler, List<Fruit> fruits)
        {
            this.activity = activity;
            this.fruits = fruits;
            this.recyler = recyler;
        }

        // 将数据绑定到view
        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            var item = this.fruits[position];

            var viewHolder = holder as FruitHoder;
            viewHolder.fruitName.Text = item.Name;
            Picasso.With(activity).Load(item.ImageLink).Into(viewHolder.fruitImage);
            // 绑定事件 
            holder.ItemView.Click += ItemView_Click;
           
        }

        private void ItemView_Click(object sender, System.EventArgs e)
        {
           int position = this.recyler.GetChildAdapterPosition((View)sender);
            Toast.MakeText(this.activity, fruits[position].Name,ToastLength.Short).Show();
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            var itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.FruitItem, parent, false);
            return new FruitHoder(itemView);
        }
    }

    public class FruitHoder : RecyclerView.ViewHolder
    {
        public FruitHoder(View itemView):base(itemView)
        {
            this.fruitImage = itemView.FindViewById<ImageView>(Resource.Id.fruit_image);
            this.fruitName = itemView.FindViewById<TextView>(Resource.Id.fruit_name);
        }

        public ImageView fruitImage { get; set; }
        public TextView fruitName { get; set; }


    }
}