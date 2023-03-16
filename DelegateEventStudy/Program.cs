// See https://aka.ms/new-console-template for more information
using DelegateEventStudy;

Console.WriteLine("Hello, World!");
DelegateExample da = new DelegateExample();
/*
da.ShowData("nilesh");
da.objMyDelegate("gupta");

BuiltInDelegate b = new BuiltInDelegate();
b.myActionDelegate("nilesh");
string res = b.MyFuncDelegate(12, 13);
Console.WriteLine(res);
bool a = b.MyPredicate("nilesh");
Console.WriteLine(a);
*/

da.greet("hello");

#region Event 

Counter cn = new Counter();
cn.ThresholdReached += MyWorkToDo;
cn.Add(10);
cn.Add(5);
cn.Add(10);
static void MyWorkToDo(object sender, EventArgs e)
{
    Console.WriteLine(((MyEventArgs)e).TotalValue);
    Console.WriteLine("ThresholdReached");
}

#endregion