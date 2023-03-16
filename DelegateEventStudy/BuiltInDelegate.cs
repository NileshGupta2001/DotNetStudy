using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEventStudy
{
    //In-built delegates
    //Action 
    //Func
    //Predicate

    //1)Action Delegate is used to
    //  point to a function with return type void

    //2) Func delegate point to a function with return type
    //3)

    //What is anonymous method? 
    //-> As the name suggests, an anonymous method is a method
        //without a name. Anonymous methods in C# can be defined
        //using the delegate keyword and can be assigned to a
        //variable of delegate type.
    //What is lambda expression

    internal class BuiltInDelegate
    {
        public Predicate<string> MyPredicate;
        public Func<int, int, string> MyFuncDelegate;
        public Action<string> myActionDelegate;
        public void ShowData(string str)
        {
            Console.WriteLine("Data is Shown Here"+str);
        }

        public BuiltInDelegate()
        {
            myActionDelegate = ShowData;
            MyFuncDelegate = Add;
            MyPredicate = CheckValue;
        }

        public string Add(int num1, int num2)
        {
           string num3 = (num1 + num2).ToString();
            return num3;
        }

        public bool CheckValue(string value)
        {
            return true;
        }



    }
}
