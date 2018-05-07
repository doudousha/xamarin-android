

using SQLite;

namespace SqlLiteExample.Resources.DataHelper
{
    public class Person : Java.Lang.Object
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }
}