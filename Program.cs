using System;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Monty Hall Problem");
            Console.Write("Choose a door: 1, 2 or 3:");
            string userValue = Console.ReadLine();
            string message = "";
            if (userValue == "1")
                message = "You won a Car!";
            else if (userValue == "2")
              message = "You won a Lemon!";
            else if (userValue == "3")
             message = "You won a Lemon!";
            else
            {
                message = "You have to Call a Box!";
            }
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
