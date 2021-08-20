using System;

namespace BasicConsoleIO
{
    class Program
    {
        static void Main(string[] args)
        {

            //Set console title
            Console.Title = "Get user information";

            //Get name and age
            Console.Write("Introduce your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Introduce your age: ");
            string userAge = Console.ReadLine();

            //Set console text color
            Console.ForegroundColor = ConsoleColor.Blue;

            //3 methods of displaying the text
            Console.WriteLine("Hello " + userName + "! You are " + userAge +  " years old.");
            Console.WriteLine($"Hello {userName}! You are {userAge} years old.");
            Console.WriteLine("Hello {0}! You are {1} years old.", userName, userAge);

            //Reset to default console color for all the text after this code
            Console.ResetColor();
            
        }
    }
}
