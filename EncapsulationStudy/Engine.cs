using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationStudy
{
    internal class Engine : Car
    {
        public Engine(string abc) : base(abc)
        {
            Console.WriteLine("Parameterized Constructor called + "+ abc);
        }
    }
}
