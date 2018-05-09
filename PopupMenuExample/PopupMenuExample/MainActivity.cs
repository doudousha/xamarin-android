using Android.App;
using Android.Widget;
using Android.OS;

namespace PopupMenuExample
{
    [Activity(Label = "PopupMenuExample", MainLauncher = true)]
    public class MainActivity : Activity
    {

        private Button btnShow;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

             btnShow = FindViewById<Button>(Resource.Id.button1);
            btnShow.Click += BtnShow_Click;
        }

        private void BtnShow_Click(object sender, System.EventArgs e)
        {
            PopupMenu menu = new PopupMenu(this, btnShow);
            // 加载菜单布局文件
            menu.Inflate(Resource.Menu.popup_menu);

            menu.MenuItemClick += (sd, eArgs) => {
                Toast.MakeText(this, string.Format("menu {0} clicked", eArgs.Item.TitleFormatted), ToastLength.Short).Show();
            };

            // 菜单从屏幕消失事件
            menu.DismissEvent += (sd, eArgs) => {
                Toast.MakeText(this, string.Format("menu dissmissed"), ToastLength.Short).Show();
            };

            menu.Show();
        }
    }
}

