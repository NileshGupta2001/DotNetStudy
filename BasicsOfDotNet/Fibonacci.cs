using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfDotNet
{
    internal class Fibonacci
    {
        public void PrintFibbonaciSeries(int i)
        {
            int a = 0;
            Console.WriteLine(a);
            int b = 1;
            Console.WriteLine(b);
            int count = 2;
            while (a <= b)
                {
                    if (count <= i)
                    {
                        int c = a + b;
                        a = b;
                        b = c;
                        Console.WriteLine(c);
                        count++;
                    }
                

                }
            }
        }


    }



