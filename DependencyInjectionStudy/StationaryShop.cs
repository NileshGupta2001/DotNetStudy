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
        public IPrinter printer;

        public StationaryShop(IPrinter objPrinter)
        {
            this.printer= objPrinter;
            
        }

        public void PrintDocument()
        {
            printer.Print();
        }
    }
}
