using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadingStudy
{
    internal class AsyncAwaitExample
    {
        public Task<int> MyBackgroundFunction()
        {
            Console.WriteLine("BackGround Work Started");
            Thread.Sleep(1000);
            Console.WriteLine("Background Work End");
            return Task.FromResult(6);
        }

        public async void MyCallerFunction()
        {
            Console.WriteLine("Execute Some Page Of Code");
            var t = await MyBackgroundFunction(); //runs function on different thread
            Thread.Sleep(1000);
            Console.WriteLine("Value Returned = "+ t);  
        }


    }
}
