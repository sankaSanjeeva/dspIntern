using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minMaxPointsOfCurve
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] points = new double[18, 2] { { -10, -2.2 }, { -9, -3 }, { -7, -1 }, { -6, 0 }, { -5, -1 }, { -4, -3.5 }, { -3, -5 }, { -2, -2}, { -1.5, 0 }, { -1, 1 }, { 0, 2 }, { 2, 1 }, { 3, -2 }, { 4, -3 }, { 5, -1.5 }, { 5.5, 0 }, { 6.5, 1 }, { 7.5, 0 } };
            bool[] aMaxPoint = new bool[(points.Length / 2) - 2];
            bool[] aMinPoint = new bool[(points.Length / 2) - 2];

            // CHECH MAXIMUM & MINIMUM POINTS
            for (int i = 1; i < (points.Length / 2) - 1; i++)
            {
                if (points[i - 1, 1] < points[i, 1] && points[i, 1] > points[i + 1, 1])
                {
                    aMaxPoint[i - 1] = true;
                }
                else if (points[i - 1, 1] > points[i, 1] && points[i, 1] < points[i + 1, 1])
                {
                    aMinPoint[i - 1] = true;
                }
            }

            // MAXIMUM POINTS PRINT
            Console.Write("Maximum points : ");
            for (int i=0; i<(points.Length/2)-2; i++)
            {
                if(aMaxPoint[i])
                {
                    Console.Write("[{0}, {1}] ", points[i+1, 0], points[i+1, 1]);
                }
            }
            Console.WriteLine("");

            // MINIMUM POINTS PRINT
            Console.Write("Minimus points : ");
            for (int i = 0; i < (points.Length / 2) - 2; i++)
            {
                if (aMinPoint[i])
                {
                    Console.Write("[{0}, {1}] ", points[i + 1, 0], points[i + 1, 1]);
                }
            }
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
