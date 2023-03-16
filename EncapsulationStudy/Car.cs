using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationStudy
{
    internal class Car
    {
        //Constructor is a special function name same of class
        // there is no return type for constructor
        //when we create object of class, constructor is called by itself
        public Car()
        {
            Console.WriteLine("New Car Launched(Default Constructor created)");
        }

        public Car(string args)
        {
            Console.WriteLine("Parent Class Constructor + " + args);
        }
    }
}
