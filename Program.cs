using System;
using MySchedule.Class;
using System.Globalization;
namespace MySchedule
{
    class Program
    {
        static void Main(string[] args)
        {
            int command;
            do{
                command = Convert.ToInt32((Console.ReadLine()));
                switch(command){
                    case 0:
                        Console.WriteLine("Goodbye");
                        break;
                    case 1:
                        Console.WriteLine("Give the title");
                        string title = Console.ReadLine();
                        Console.WriteLine("Give the description");
                        string description = Console.ReadLine();
                        Console.WriteLine("Give the due date in dd/mm/yyyy");
                        DateTime due_date = DateTime.ParseExact(Console.ReadLine(),"dd/mm/yyyy",CultureInfo.InvariantCulture);
                        Todo new_event = new Todo(title,description,due_date);
                        break;
                    case 2:
                        Display.DisplayTodo();
                        break;
                }
            }
            while(command != 0);
        }
    }
}
