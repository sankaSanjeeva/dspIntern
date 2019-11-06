using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace readTextFileOOP_consoleApp
{
    class ReadFile
    {
        string filePath = @"C:\Users\DSP\source\repos\readTextFileOOP_consoleApp\readTextFileOOP_consoleApp\bin\Debug\readTextFileOOP_onsoleApp.txt";

        public string ReadAllText()
        {
            return File.ReadAllText(filePath);
        }

        public string ReadLines(int i)
        {
            string[] lines = File.ReadAllLines(filePath);
            return lines[i - 1];
        }

        public void display()
        {
            int operation = 0;

            Console.WriteLine("********* STUDENT DETAILS *********\n");

            while (operation != 3)
            {
                Console.WriteLine("1) Display text file");
                Console.WriteLine("2) Display row");
                Console.WriteLine("3) Exit");
                Console.Write("Enter Operation : ");
                operation = Convert.ToInt16(Console.ReadLine());

                if (operation == 1)
                {
                    Console.WriteLine("\n" + ReadAllText());
                }
                else if (operation == 2)
                {
                    Console.Write("Enter row number need to display : ");
                    int rowNumber = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("\n" + ReadLines(rowNumber) + "\n");
                }
                else if (operation == 3)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Enter correct operation !");
                }
                Console.WriteLine("");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ReadFile rf = new ReadFile();
            rf.display();
        }
    }
}
