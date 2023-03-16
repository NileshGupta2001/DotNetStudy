// See https://aka.ms/new-console-template for more information
using BoxingUnboxing;

Console.WriteLine("Hello, World!");
//using Switch;

//Cycle obj = new Cycle();
//Object obj2 = new Cycle(); //will work
object obj3 = new object();
int i = 10;
//boxing (can only be done with object class)
obj3 = i;
Console.WriteLine(obj3);
//unboxing
int j = (int)obj3;
Console.WriteLine(j);
Cycle obj = new Cycle();
Cycle.Count = 1;
Cycle.show();