using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace readTextFileConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\DSP\source\repos\readTextFileConsoleApp\readTextFileConsoleApp\bin\Debug\readTextFileConsoleApp.txt";
            string allText = File.ReadAllText(filePath);
            string[] lines = File.ReadAllLines(filePath);
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
                    Console.WriteLine("\n" + allText);
                }
                else if (operation == 2)
                {
                    Console.Write("Enter row number need to display : ");
                    int rowNumber = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("\n" + lines[rowNumber - 1] + "\n");
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
            Console.ReadKey();
        }
    }
}
