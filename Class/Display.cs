using MySchedule;
using System.Data.SQLite;
using System;
using System.IO;
namespace MySchedule.Class
{
    public static class Display
    {
        static string db_locate = String.Format(@"URI=file:{0}/storage.db",Directory.GetCurrentDirectory());
        public static void DisplayTodo(){
            using var connect = new SQLiteConnection(db_locate);
            connect.Open();
            string display = "SELECT * FROM todo ORDER BY due_date";
            using var command = new SQLiteCommand(display,connect);
            using SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine($"{reader.GetInt32(0)} {reader.GetString(1)} {reader.GetString(2)} {reader.GetString(3)} {reader.GetInt32(4)}");
            }
        }
    }
}