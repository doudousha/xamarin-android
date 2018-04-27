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
    [Activity(Label = "MsgActivity")]
    public class MsgActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Msg);

            // 初始化Msg Adapater
            List<Msg> msgs = initMsgs();
            var msgAdapter = new MsgAdapter(this, msgs);
            // 初始化Recycler
            var recyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerViewMsg);
            recyclerView.SetAdapter(msgAdapter);
       
            var layoutManager = new LinearLayoutManager(this, LinearLayoutManager.Vertical, false);
            recyclerView.SetLayoutManager(layoutManager);


            // 绑定发送按钮事件
            var btnSend = FindViewById<Button>(Resource.Id.btnSendMsg);
            btnSend.Click += (sender, eArgs) =>
            {
                // 组装发送消息体
                var sendContent = FindViewById<EditText>(Resource.Id.editTextSendContent);
                var msg = new Msg(Msg.type_send, sendContent.Text);
                // 添加到recyclerView的adapter
                msgAdapter.Msgs.Add(msg);
                // 刷新显示
                msgAdapter.NotifyItemInserted(msgs.Count - 1);
                // 定位到最后一行
                recyclerView.SmoothScrollToPosition(msgs.Count - 1);
                // 清空发送文本框
                btnSend.Text = "";
            };
        }

        private static List<Msg> initMsgs()
        {
            return new List<Msg>() {
                    new Msg(Msg.type_received,"在吗?"),
                       new Msg(Msg.type_received,"在吗............"),
                        new Msg(Msg.type_send,"在的，有什么事儿？"),
            };
        }
    }
}