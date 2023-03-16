using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfDotNet
{
    internal class Country
    {
        public string Capital;
        public string Currency;
        private int PopulationSize;

        public void ShowData()
        {
            Console.WriteLine(Capital);
            Console.WriteLine(Currency);
        }

        public void ShowPopulation()
        {
            Console.WriteLine("Current Population is: ");
            Console.Write(PopulationSize);
        }
    }
}
