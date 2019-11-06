using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[13] { 1, 3, 45, 1, 4, 6, 3, 6, 57, 34, 2, 1, 1 };
            int min = numbers[0];
            int max = numbers[0];
            int count = 1;
            int[] countArray = new int[numbers.Length];
            int[] values = new int[numbers.Length];
            Boolean print = false;

            // MIN MAX
            for (int i = 0; i < numbers.Length; i++)
            {
                if (min > numbers[i])
                {
                    min = numbers[i];
                }
            
                if (max < numbers[i])
                {
                    max = numbers[i];
                }
            }

            Console.Write("Minimum number is -: " + min + Environment.NewLine);
            Console.Write("Maximum number is -: " + max + Environment.NewLine);
            Console.Write(Environment.NewLine);

            // OCCURRENCES
            // Count array
            for (int i = 0; i<numbers.Length; i++)
            {
                for(int j=0; j<numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        countArray[i] = count;
                        count++;
                    }
                }
                count = 1;
                values[i] = 0;
            }

            // Value array & print state
            for(int i=0; i<numbers.Length; i++)
            {
                for (int j=0; j<numbers.Length; j++)
                {
                    if (numbers[i] == values[j])
                    {
                        values[i] = numbers[i];
                        print = false;
                        break;
                    }
                    else if (values[j] == 0)
                    {
                        values[i] = numbers[i];
                        print = true;
                        break;
                    }
                    else
                    {
                        print = false;
                    }
                }
                if (print)
                {
                    Console.Write("No of occurrences of " + numbers[i] + " : " + countArray[i] + Environment.NewLine);
                }
                print = false;
            }
            Console.ReadKey();
        }
    }
}