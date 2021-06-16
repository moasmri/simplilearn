using System;

namespace Teacher_Records_System
{
    class Program
    {
        static void Main(string[] args)
        {
            welcome();
        }

        static void welcome()
        {
            Console.ForegroundColor = ConsoleColor.Green;
          
            Console.WriteLine(@"Welcome to my little project It is an example of a system for storing teachers' data Sponsored by Simpliearn");
            
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
    }
}
