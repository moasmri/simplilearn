using System;

namespace Teacher_Records_System
{
    class Program
    {
        static void Main(string[] args)
        {
            welcome();
            Console.ReadKey();
        }

        static void welcome() // first show welcome message
        {
            Console.ForegroundColor = ConsoleColor.Green;
          
            Console.WriteLine(@"Welcome to my little project It is an example of a system for storing teachers' data Sponsored by Simpliearn");
            
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        static void Teacher_Records()
        {

            bool system_status = true;
            string txtPath = @"C:\Users\moasmri\Desktop\ConsoleAppTeacher\ConsoleAppTeacher\moasmrit.txt";// txt file path and name
        }
    }
}
