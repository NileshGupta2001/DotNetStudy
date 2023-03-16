using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing
{
    internal static class Cycle //STATIC CLASSES CAN NOT BE INHERITED
    {
        public static int Count { get; set; }

        public static void show()
        {

        }

        static Cycle()
        {

        }
    }
}
