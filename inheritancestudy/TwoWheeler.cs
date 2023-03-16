using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceStudy
{
    internal class TwoWheeler : Vehicle
    { //Polymorphism -> 
        /*
         1) Design Time/ Compile Time Polymorphism Ex: Method Overloading
        2) Run Time Polymorphism ex. Method Overriding
         */
        public override void Start()
        {
            Console.WriteLine("Two-Wheeler Started");
        }
    }
}
