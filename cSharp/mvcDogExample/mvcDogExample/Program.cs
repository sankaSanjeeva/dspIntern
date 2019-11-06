using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mvcDogExample.view;
using mvcDogExample.model;
using mvcDogExample.controller;

namespace mvcDogExample
{
    class Program
    {
        static void Main(string[] args)
        {
            DogModel myDog = getInfoFromDB();
            DogShow show = new DogShow();

            DogController ctrl = new DogController(myDog, show);

            ctrl.updateView();

            ctrl.setName("Snowy");
            ctrl.setAge(4);

            ctrl.updateView();

            Console.ReadKey();
        }

        private static DogModel getInfoFromDB()
        {
            DogModel d = new DogModel();
            d.Name = "Blacky";
            d.Age = 3;
            return d;
        }
    }
}
