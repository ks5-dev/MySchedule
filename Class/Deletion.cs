using System.Data.SQLite;
using System;
using System.IO;
namespace MySchedule.Class
{
    public class Deletion
    {
        static public string db_location = String.Format(@"URI=file:{0}/storage.db",Directory.GetCurrentDirectory());

        static public void deleteTodo(string name){
            using var connect = new SQLiteConnection(db_location);
            connect.Open();
            using var command = new SQLiteCommand(connect);

            command.CommandText = @"DELETE FROM todo WHERE title='" +name +"'";
            command.ExecuteNonQuery();
            
        }
        static public void deleteTodo(int id){
            using var connect = new SQLiteConnection(db_location);
            connect.Open();
            using var command = new SQLiteCommand(connect);

            command.CommandText = @"DELETE FROM todo WHERE id="+ Convert.ToString(id);
            command.ExecuteNonQuery();
        }
    }
}