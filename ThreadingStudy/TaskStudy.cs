using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadingStudy
{
    //Task Parallel Library(TPL)
    //Adv is its uses all the cores of our computer
    internal class TaskStudy
    {
        
        public static void ShowMessage()
        {
            Console.WriteLine("Message Here");
            Thread.Sleep(100);
            Console.WriteLine("Next Message");
        }
         
        public static void CreateTaskAndCall()
        {
            Action action = ShowMessage;
            Task t = new Task(action);
            Task t1 = new Task(action);
            t.Start();
            t1.Start();
            t1.Wait(1000);

            
        }


    }
}
