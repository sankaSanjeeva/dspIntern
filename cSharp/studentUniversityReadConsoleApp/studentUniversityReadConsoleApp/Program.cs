using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace studentUniversityReadConsoleApp
{
    abstract class ReadFile
    {
        string fPath;

        public void setPath(string filePath)
        {
            fPath = filePath;
        }

        public string ReadAllText()
        {
            return File.ReadAllText(fPath);
        }

        public string ReadLines(int i)
        {
            string[] lines = File.ReadAllLines(fPath);
            return lines[i - 1];
        }

        public void displayMenu()
        {
            string operation = "";

            while (operation != "3")
            {
                Console.WriteLine("1) Display text file");
                Console.WriteLine("2) Display row");
                Console.WriteLine("3) Back");
                Console.Write("\nEnter Operation : ");
                operation = Console.ReadLine();

                if (operation == "1")
                {
                    Console.WriteLine("\n" + ReadAllText() + "\n");
                }
                else if (operation == "2")
                {
                    Console.Write("Enter row number need to display : ");
                    int rowNumber = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("\n" + ReadLines(rowNumber) + "\n");
                }
                else if (operation == "3")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Enter correct operation !\n");
                }
            }
            Console.WriteLine("");
        }

        public abstract void display();
    }

    class Student : ReadFile
    {
        string filePath = @"C:\Users\DSP\source\repos\studentUniversityReadConsoleApp\studentUniversityReadConsoleApp\bin\Debug\studentDetails.txt";

        public override void display()
        {
            setPath(filePath);
            Console.WriteLine("\n---- Student Details -----\n");
            displayMenu();
        }
    }

    class Teacher : ReadFile
    {
        string filePath = @"C:\Users\DSP\source\repos\studentUniversityReadConsoleApp\studentUniversityReadConsoleApp\bin\Debug\teacherDetails.txt";

        public override void display()
        {
            setPath(filePath);
            Console.WriteLine("\n---- Teacher Details -----\n");
            displayMenu();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Teacher t1 = new Teacher();
            string operation = "";

            while (operation != "3")
            {
                Console.WriteLine("********* School Details *********\n");
                Console.WriteLine("1) Student Details");
                Console.WriteLine("2) Teachers Details");
                Console.WriteLine("3) Exit");
                Console.Write("\nChoose one : ");

                operation = Console.ReadLine();

                if (operation == "1")
                {
                    s1.display();
                }
                else if (operation == "2")
                {
                    t1.display();
                }
                else if (operation == "3")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("\nEnter correct operation !\n");
                }
            }
        }
    }
}
