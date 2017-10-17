using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSVirtualAcademyEnumerationsSwitch

    //let's work with a to-do list
    //enumerations are basically itemized, set possibilites
    //you can do switch statements that will do a thing
    //when the enumerated condition is met
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            List<Todo> todos = new List<Todo>()
            {
                new Todo{Desc = "Task 1", EstHours = 6, Status = Status.Completed},
                new Todo{Desc = "Task 2", EstHours = 2, Status = Status.InProgress},
                new Todo{Desc = "Task 3", EstHours = 8, Status = Status.NotStarted},
                new Todo{Desc = "Task 4", EstHours = 12, Status = Status.Deleted},
                new Todo{Desc = "Task 5", EstHours = 6, Status = Status.InProgress},
                new Todo{Desc = "Task 6", EstHours = 2, Status = Status.OnHold},
                new Todo{Desc = "Task 7", EstHours = 14, Status = Status.Completed},
                new Todo{Desc = "Task 8", EstHours = 8, Status = Status.NotStarted}
            };

            PrintAssessment(todos);
            Console.ReadLine();
        }

        //here's a method:
        private static void PrintAssessment(List<Todo> todos)
        {
            foreach (var todo in todos)
            {
                switch (todo.EstHours)
                {
                    case 2:
                        Console.WriteLine("It's short!");
                        break;
                    case 6:
                        Console.WriteLine("Do half today.");
                        break;
                    case 14:
                        Console.WriteLine("It's long. Just get started.");
                        break;

                        //etc...

                }

                switch (todo.Status)
                {
                    case Status.NotStarted:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case Status.Completed:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Good job. Completed!");
                        Console.WriteLine(Status.Completed);
                        break;

                        //etc...

                }
            }
        }
    }

    //here's a class:
    class Todo
    {
        public string Desc { get; set; }
        public int EstHours { get; set; }

        //note how this property is defined below, as an emunerated list
        //it can only be one of the things in that list
        public Status Status { get; set; }
    }

    //here's an enumerated list
    //it's the list of exactly 5 states of the item on the list
    enum Status
    {
        NotStarted,
        InProgress,
        OnHold,
        Completed,
        Deleted
    }

}
