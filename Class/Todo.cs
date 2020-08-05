using System;
using System.Data.SQLite;
using System.IO;
namespace MySchedule.Class
{
    public class Todo 
    {
        private string title;
        private string description;
        private DateTime due_date;
        public string db_location = String.Format(@"URI=file:{0}/storage.db",Directory.GetCurrentDirectory());
        public Todo(string title, string description,DateTime due_date){
            this.title = title;
            this.description = description;
            this.due_date = due_date;
            Console.WriteLine(db_location);
            this.AddToDb();
        }
        public void AddToDb()
        {
            using var connect = new SQLiteConnection(db_location);
            connect.Open();
            using var command = new SQLiteCommand(connect);

            command.CommandText = String.Format(@"INSERT INTO todo (title,description,due_date,ischecked) VALUES ('{0}','{1}','{2}', 0)",this.title, this.description,this.due_date.ToString("dd/mm/yyyy"));
            command.ExecuteNonQuery();
        }
    }
}