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
            ByeMessage();
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
                Console.WriteLine(@"Select Option 1- Add Teacher
                                    2- Search in Teachers
                                    3- Update Teacher
                                    4- Display Teacher
                                    || 0 TO EXIT . ");
                string User_choice = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;

                if (User_choice == "1")//Option 1- Add showing message ask user how many Teachers To Add
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
                else if (User_choice == "2")// Option 2 - Search showing message ask user Enter Teacher ID to Search
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Enter TeacherID To Search :");
                    string SearchID = Console.ReadLine();
                    foreach (var line in lines)
                    {
                        string[] DataArray = line.Split('	');
                        if (DataArray[0] == SearchID)
                        {
                            Console.WriteLine("TeacherID :" + DataArray[0] + "\t TeacherName " + DataArray[1] + "\t TeacherClass " + DataArray[2] + "\t TeacherSection " + DataArray[3] + "\t");
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                    }
                }
                else if (User_choice == "3") // Option 3 - Update showing message ask user Enter Teacher ID to update Teacher info
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Enter TeacherID for Data UPDET  :");
                    string SearchID = Console.ReadLine();

                    foreach (var line in lines)
                    {
                        string[] DataArray = line.Split('	');
                        if (DataArray[0] == SearchID)
                        {
                            lines.Remove(DataArray[0] + '\t' + DataArray[1] + '\t' + DataArray[2] + '\t' + DataArray[3]);
                            Console.Write("Enter Name :");
                            string TeacherName = Console.ReadLine();
                            Console.Write("Enter Class :");
                            string TeacherClass = Console.ReadLine();
                            Console.Write("Enter Section :");
                            string TeacherSection = Console.ReadLine();
                            DataArray[1] = TeacherName;
                            DataArray[2] = TeacherClass;
                            DataArray[3] = TeacherSection;
                            string newdta = SearchID + '\t' + DataArray[1] + '\t' + DataArray[2] + '\t' + DataArray[3];
                            lines.Add(newdta);
                            lines.Sort();
                            File.WriteAllLines(txtPath, lines);
                            Console.WriteLine(DataArray[1] +" successful updated");
                            Console.WriteLine("TeacherID :" + DataArray[0] + "\t TeacherName " + DataArray[1] + "\t TeacherClass " + DataArray[2] + "\t TeacherSection " + DataArray[3]);
                            break;

                        }

                    }
                }
                else if (User_choice == "4")//Option 4 - show all Teacher stored in txt file
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(" ID" + "  \t TeacherName" + "    \tTeacherClass " + "\tTeacherSection");
                    Console.ForegroundColor = ConsoleColor.Red;

                    foreach (string line in lines)
                    {
                        string[] DataArray = line.Split('	');


                        Console.WriteLine("  " + DataArray[0] + "   \t " + DataArray[1] + "    \t" + DataArray[2] + "    \t   " + DataArray[3]);

                    }
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else  // stop while loop to exit from program
                {
                    system_status = false;
                }
            }
        }

        static void ByeMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Thank you for trying my little app. I hope to make bigger projects than this and keep learning .NET with simplilearn ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" See you on another project ");
            Console.ReadKey();
        }
    }
}
