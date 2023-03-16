// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");
//c# strings are immutable
string str = "Hello";
str = str + " Nilesh";

// Makes a new object called str and wastes memory

StringBuilder sb = new StringBuilder();
sb.Append("Hello");
sb.Append(" Nilesh");
Console.Write(sb);

//Doesnt create a new object each time as it is a class