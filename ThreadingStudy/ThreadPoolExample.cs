using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadingStudy
{
    internal class ThreadPoolExample
    {
        public void CreateThreadUsingThreadPool()
        {
            WaitCallback wc =new WaitCallback(DoWork);
            ThreadPool.QueueUserWorkItem(wc);
            Console.ReadLine();
        }

        public void DoWork(Object obj)
        {
            
            Console.WriteLine("Function Called From Thread Pool");
        }
    }
}
