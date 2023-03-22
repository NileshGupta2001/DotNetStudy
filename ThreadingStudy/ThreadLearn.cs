using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadingStudy
{
    internal class ThreadLearn
    {
        //Parallel Execution of Functions -> Threading
        public int Counter=0;
        object obj1 = new object(); 

        public void DoWorkOne()
        {
            
            //Thread.Sleep(100); //in milliseconds
            Increment();
            Console.WriteLine("Do Work One Called"+Counter);
        }

        public void DoWorkTwo()
        {
            Increment();
            //Thread.Sleep(100);
            Console.WriteLine("DoWOrkTwoCalled"+Counter);
        }

        public void DoWorkThree()
        {
           // Thread.Sleep(100);
            Increment();
            
            Console.WriteLine("DoWorkThree Called"+Counter);
        }

        public void Increment()
        {
            lock (obj1) // Only one thread will be executed inside lock at a time
            {
                Thread.Sleep(1000);
                Counter = Counter + 1;
            }
        }

        public void DisplayMessage()
        {
           lock (obj1)
           { 
                
                Console.Write("[Welcome to the ");
                Thread.Sleep(1000);
                Console.WriteLine("world of dotnet!]");
           }
        }

        //ForeGround Thread -> Handles UI processes
        //BackGround Thread -> Handles Background processes
    }
}
