using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionStudy
{
    public class StationaryShop
    {
        public string ShopOwner;
        public InkjetPrinter laserPrinter;

        public StationaryShop()
        {
            laserPrinter = new InkjetPrinter();
            
        }

        public void PrintDocument()
        {
            laserPrinter.Print();
        }
    }
}
