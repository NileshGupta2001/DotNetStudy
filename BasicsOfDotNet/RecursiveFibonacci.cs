using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfDotNet
{
    internal class RecursiveFibonacci
    {
        public int RecurseFibo(int n)
        {
            int a = 0;
            if(n==0 || n==1)
            {
                return(n);
            }    
            else 
            {
                int b = n - 1;
                int c = n - 2;

                return (RecurseFibo(b) + RecurseFibo(c));   
            }

        }
    }
}
