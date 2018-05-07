using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using SQLite;

namespace SqlLiteExample.Resources.DataHelper
{
    public class Database
    {
        private string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

        public bool createDatabase()
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "Persons.db")))
                {
                    connection.DropTable<Person>();
                    connection.CreateTable<Person>();
                    return true;
                }
            }
            catch (Exception ex) {
                Log.Error("SqlliteEx", ex.Message);
            }
            return false;
        }

        public bool InsertIntoTablePerson(Person person) {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "Persons.db")))
                {
                    connection.Insert(person);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Log.Error("SqlliteEx", ex.Message);
            }
            return false;
        }

        public List<Person> selectTablePerson()
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "Persons.db")))
                {
                    return connection.Table<Person>().ToList();
                }
            }
            catch (Exception ex)
            {
                Log.Error("SqlliteEx", ex.Message);
            }
            return null;
        }

        public bool updateTablePerson(Person person)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "Persons.db")))
                {
                    connection.Query<Person>("update person set name=?,age=?,email=? where id=?"
                        ,person.Name ,person.Age,person.Email,person.Id);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Log.Error("SqlliteEx", ex.Message);
            }
            return false;
        }

        public bool deleteTablePerson(Person person)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "Persons.db")))
                {
                    int count =connection.Delete(person);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Log.Error("SqlliteEx", ex.Message);
            }
            return false;
        }


        public bool clearTablePerson() {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "Persons.db")))
                {
                    connection.Query<Person>("delete from person");
                    return true;
                }
            }
            catch (Exception ex)
            {
                Log.Error("SqlliteEx", ex.Message);
            }
            return false;
        }

    }
}