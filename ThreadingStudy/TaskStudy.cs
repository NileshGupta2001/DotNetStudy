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
        }
         
        public static void CreateTaskAndCall()
        {
            Action action = ShowMessage;
            Task t = new Task(action);
            t.Start();
        }
    }
}
