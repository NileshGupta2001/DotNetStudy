using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADOStudy;

namespace UIProjectStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DBContext db = new DBContext();
           var lstrole= db.ReadData();
            foreach (var item in lstrole)
            {
                Console.WriteLine(item.UserID);
            }
          
        }
    }
}
