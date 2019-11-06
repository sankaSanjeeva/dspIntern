using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcDogExample.model
{
    class DogModel
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public void bark()
        {
            Console.WriteLine("Woof Woof");
        }
    }
}
