using System.Reflection;
//Using reflection we can read the classes and functions in an assembly file
// and execute them 
var MyAssembly = Assembly.Load(@"E:\DotNet Study\FileHandling\bin\Debug\net6.0\FileHandling.dll");
var ClassCollection = MyAssembly.GetTypes();
foreach (var item in ClassCollection)
{
    Console.WriteLine(item.Name);
}