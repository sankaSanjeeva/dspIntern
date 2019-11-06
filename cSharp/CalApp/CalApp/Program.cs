using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalApp
{
    class Program
    {
        public double CalD(double a, double b, double c)
        {
            return b * b - 4 * a * c;
        }

        public double calRoot1(double a, double b, double c)
        {
            double root1;
            root1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            return root1;
        }

        public double calRoot2(double a, double b, double c)
        {
            double root2;
            root2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            return root2;
        }
        static void Main(string[] args)
        {
            string aa, bb, cc;
            Program p1 = new Program();

            Console.Write("Enter a : ");
            aa = Console.ReadLine();
            double a = Convert.ToDouble(aa);

            Console.Write("Enter b : ");
            bb = Console.ReadLine();
            double b = Convert.ToDouble(bb);

            Console.Write("Enter c : ");
            cc = Console.ReadLine();
            double c = Convert.ToDouble(cc);

            if(a == 0)
            {
                Console.Write("Root is -:" + (-c)/b);
                Console.ReadKey();
            }else
            {
                if(p1.CalD(a, b, c) >= 0)
                {
                    Console.Write("Root 1 -: " + p1.calRoot1(a, b, c) + ", Root 2 -: " + p1.calRoot2(a, b, c));
                    Console.ReadKey();
                }
                else
                {
                    Console.Write("Roots are imaginary roots");
                    Console.ReadKey();
                }
            }
        }
    }
}
