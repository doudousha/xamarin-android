using Android.App;
using Android.OS;
using Android.Util;
using Android.Widget;
using SqlLiteExample.Resources;
using SqlLiteExample.Resources.DataHelper;
using System.Collections.Generic;

namespace SqlLiteExample
{
    [Activity(Label = "SqlLiteExample", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private ListView lstView;
        private List<Person> lstSource = new List<Person>();
        private Database database;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            database = new Database();
            database.createDatabase();
            database.clearTablePerson();

            Log.Info("DB PATH",  System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal));

            lstView = FindViewById<ListView>(Resource.Id.listView1);

            var editAge = FindViewById<EditText>(Resource.Id.edit_age);
            var editName = FindViewById<EditText>(Resource.Id.edit_name);
            var editEmail = FindViewById<EditText>(Resource.Id.edit_email);

            var btnAdd = FindViewById<Button>(Resource.Id.btn_add);
            var btnEdit = FindViewById<Button>(Resource.Id.btn_edit);
            var btnDelete = FindViewById<Button>(Resource.Id.btn_delete);


            btnAdd.Click += (sender, eArgs) =>
            {
                var person = new Person()
                {
                    Age = int.Parse(editAge.Text),
                    Name = editName.Text,
                    Email = editEmail.Text
                };
                database.InsertIntoTablePerson(person);
                LoadData();
            };

            btnEdit.Click += (sender, eArgs) =>
            {
                var person = new Person()
                {
                    Id = int.Parse(editName.Tag.ToString()),
                    Age = int.Parse(editAge.Text),
                    Name = editName.Text,
                    Email = editEmail.Text
                };
                database.updateTablePerson(person);
                LoadData();
            };

            btnDelete.Click += (sender, eArgs) =>
            {
                var person = new Person()
                {
                    Id = int.Parse(editName.Tag.ToString()),
                    Age = int.Parse(editAge.Text),
                    Name = editName.Text,
                    Email = editEmail.Text
                };
                database.deleteTablePerson(person);
                LoadData();
            };

            lstView.ItemClick += (sender, eArgs) =>
            {
                //for (int i = 0; i < lstView.Count; i++)
                //{
                //    if (eArgs.Position == i)
                //    {
                //        lstView.GetChildAt(i).SetBackgroundColor(Android.Graphics.Color.DarkGray);
                //    }
                //    else
                //    {
                //        lstView.GetChildAt(i).SetBackgroundColor(Android.Graphics.Color.Transparent);
                //    }
                //}

                // binding
                var txtName = eArgs.View.FindViewById<TextView>(Resource.Id.txt_name);
                var txtAge = eArgs.View.FindViewById<TextView>(Resource.Id.txt_age);
                var txtEmail = eArgs.View.FindViewById<TextView>(Resource.Id.txt_email);

                var person = lstSource[eArgs.Position];
                editEmail.Text = txtEmail.Text;
                editAge.Text = txtAge.Text;
                editName.Text = txtName.Text;
                editName.Tag = person.Id;
            };

            LoadData();
        }


        private void LoadData()
        {
            lstSource = database.selectTablePerson();
          
            var adapter = new ListViewAdapter(this,Resource.Layout.ls_view_dateTemplate, lstSource);
            lstView.Adapter = adapter;
        }
    }
}

