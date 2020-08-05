using System.Data.SQLite;
using System;
using System.IO;
namespace MySchedule{
    public static class createDB{
        static string cs = String.Format(@"URI=file:{0}/storage.db",Directory.GetCurrentDirectory());
        public static void CreateDB(){
            using var con = new SQLiteConnection(cs);
            con.Open();
            using var statement = new SQLiteCommand(con);
            statement.CommandText = "CREATE TABLE todo(id INTEGER PRIMARY KEY,title TEXT UNIQUE, description TEXT, due_date TEXT,ischecked INT)";
            statement.ExecuteNonQuery();

        }
    }
}