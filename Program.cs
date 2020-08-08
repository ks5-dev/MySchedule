using System;
using MySchedule.Class;
using System.Globalization;
using System.Collections.Generic;
namespace MySchedule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> CommandIntroduction = new List<string> {"0.Quit",
            "1.Add a to do",
            "2.Display current to-do list",
            "3.delte a to do list"};
            foreach(string i in CommandIntroduction){
                Console.WriteLine(i);
            }
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
                        Console.WriteLine("\n");
                        break;
                    case 2:
                        Display.DisplayTodo();
                        Console.WriteLine("\n");
                        break;
                    case 3:
                        Console.WriteLine("Give the string of title or a number as an id");
                        string input = Console.ReadLine();
                        int id;
                        if(int.TryParse(input,out id)){
                            Deletion.deleteTodo(id);
                        }
                        else{
                            Deletion.deleteTodo(input);
                        }
                        Console.WriteLine("\n");
                        break;
                }
            }
            while(command != 0);
        }
    }
}
