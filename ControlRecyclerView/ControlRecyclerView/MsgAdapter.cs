using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace ControlRecyclerView
{
    public class MsgAdapter : RecyclerView.Adapter
    {
        private Activity activity;
        public List<Msg> Msgs { get; set; }

        public MsgAdapter(Activity activity , List<Msg> msgs)
        {
            this.activity = activity;
            this.Msgs = msgs;
        }

        public override int ItemCount =>Msgs.Count;

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            // 绑定数据
            Msg msg = this.Msgs[position];

            var viewHolder = holder as ViewHoder;
            // 如果是收到消息，则显示左边的消息布局，将右边的消息布局隐藏
            if (msg.Type == Msg.type_received)
            {
                viewHolder.RightLayout.Visibility = ViewStates.Gone;
                viewHolder.LeftLayout.Visibility = ViewStates.Visible;
                viewHolder.LeftMsg.Text = msg.Content;
            }
            else if (msg.Type == Msg.type_send)
            {
                // 如果是发送消息，则显示右边消息布局，将左边的消息布局隐藏
                viewHolder.RightLayout.Visibility = ViewStates.Visible;
                viewHolder.LeftLayout.Visibility = ViewStates.Gone;
                viewHolder.RightMsg.Text = msg.Content;
            }
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            var view = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.MsgItem,parent,false);
            return new ViewHoder(view);
        }

        class ViewHoder :RecyclerView.ViewHolder
        {
            public LinearLayout LeftLayout { get; set; }
            public LinearLayout RightLayout { get; set; }

            public TextView LeftMsg { get; set; }
            public TextView RightMsg { get; set; }
            public ViewHoder(View view):base(view)
            {
                LeftLayout = view.FindViewById<LinearLayout>(Resource.Id.linearLeft);
                RightLayout = view.FindViewById<LinearLayout>(Resource.Id.linearRight);

                LeftMsg = view.FindViewById<TextView>(Resource.Id.linearMsgLeftText);
                RightMsg = view.FindViewById<TextView>(Resource.Id.linearMsgRightText);
            }
        }
    }

   
}