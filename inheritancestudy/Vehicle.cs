using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceStudy
{
    internal class Vehicle
    {
        public string color { get; set; } 
        public string name { get; set; }
        public virtual void Start() 
        {
            Console.WriteLine("Vehicle Started");
        }

        public void Start(string key)
        {
            Console.WriteLine("Vehicle Started With key : " + key);
            
        }
    }

    // What is abstract class? 
    // What is Interface?
    //What is the difference bw abstract class and interface?
    
}
