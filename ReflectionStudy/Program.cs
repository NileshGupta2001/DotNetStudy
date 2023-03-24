using System.Reflection;
//Using reflection we can read the classes and functions in an assembly file
// and execute them 
string path = @"E:\DotNet Study\inheritancestudy\bin\Debug\net6.0\InheritanceStudy.dll";
var MyAssembly = Assembly.LoadFile(path);
var ClassCollection = MyAssembly.GetTypes(); //To get class names
foreach (var item in ClassCollection)
{
    Console.WriteLine(item.Name);
    if(item.Name=="Vehicle")
    {
        var methods=item.GetMethods();
        var prop = item.GetProperties();

        var method = item.GetMethod("Start", new Type[] { typeof(string) });
        method.Invoke(MyAssembly,new object[] { "Rajeev"});
    }

}
