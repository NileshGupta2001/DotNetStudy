using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEventStudy
{
    /*
     Delegates allow methods to be passed as parameters. 
     Delegates can be used to define callback methods.
     Delegates can be chained together; 
     for example, multiple methods can be called on a single event
     */
    /*
     * The same parameters define in functions
     * must be given to delegate
     */


    //[modifier] delegate [returntype] [delegate_name] ([parameter_list]); 
    public delegate void myDelegate(string str); 
    internal class DelegateExample
    {
        public myDelegate objMyDelegate;
        public void ShowData(string str)
        {
            {
                Console.WriteLine("Show Data Function Called"+str);
            }
        }
        
        public DelegateExample()
        { 
            //MultiCastDelegate
            objMyDelegate = ShowData;
            objMyDelegate += ShowColor;
        }

        public void ShowColor(string id)
        {
            Console.WriteLine("Show Color Called"+id);
        }

        public Action<string> greet = name =>
        {
            //$ = string interpolation
            string greeting =  $"Hello {name}!";
            Console.WriteLine(greeting);
        };
    }
}
