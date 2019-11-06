using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mvcDogExample.model;
using mvcDogExample.view;

namespace mvcDogExample.controller
{
    class DogController
    {
        private DogModel model;
        private DogShow view;

        public DogController(DogModel model, DogShow view)
        {
            this.model = model;
            this.view = view;
        }

        public void setName(string name)
        {
            model.Name = name;
        }

        public string getName()
        {
            return model.Name;
        }

        public void setAge(int age)
        {
            model.Age = age;
        }

        public int getAge()
        {
            return model.Age;
        }

        public void updateView()
        {
            view.printDogInfo(model.Name, model.Age);
        }
    }
}
