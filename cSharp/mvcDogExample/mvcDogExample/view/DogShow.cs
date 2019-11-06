using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcDogExample.view
{
    class DogShow
    {
        public void printDogInfo(string name, int age)
        {
            Console.WriteLine("\n Dog is {0} \n it is {1} years old\n", name, age);
        }
    }
}
