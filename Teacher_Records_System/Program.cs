using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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

            while (system_status)
            {

                List<string> lines = File.ReadAllLines(txtPath).ToList();
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Select Option 1- Add Teacher 2- Retrieve  Teacher 3- Update Teacher   4- Display Teacher  || 0 TO EXIT . ");
                string User_choice = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                if (User_choice == "1")
                {
                    Console.Write("How many Teachers you want To Add ? :");
                    int TeacherCount = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < TeacherCount; i++)
                    {
                        Console.Write("Enter TeacherID :");
                        int TeacherID = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter TeacherName :");
                        string TeacherName = Console.ReadLine();
                        Console.Write("Enter TeacherClass :");
                        string TeacherClass = Console.ReadLine();
                        Console.Write("Enter TeacherSection :");
                        string TeacherSection = Console.ReadLine();
                        string x = TeacherID.ToString() + '\t' + TeacherName + '\t' + TeacherClass + '\t' + TeacherSection;
                        lines.Add(x);
                        lines.Sort();
                        File.WriteAllLines(txtPath, lines);
                        Console.WriteLine(" Insert data successfully");

                    }
                }
            }
        }
    }
}
