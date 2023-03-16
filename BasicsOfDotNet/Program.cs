// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using BasicsOfDotNet;

/*
Fibonacci objClass1 = new Fibonacci();
objClass1.PrintFibbonaciSeries(5);
*/


/*
RecursiveFibonacci objClass1 = new RecursiveFibonacci();
string s = Console.ReadLine();
int n = Convert.ToInt32(s);

for (int i = 0; i <= n; i++)
{
    Console.WriteLine(objClass1.RecurseFibo(i));
}
*/

/*
Palindrome objclass2 = new Palindrome();
string s = Console.ReadLine();

string s1 = objclass2.CreatePalindrome(s);
Console.WriteLine(s1);
objclass2.CheckPalindrome(s, s1);
*/

Flightless objclass3 = new Flightless();
objclass3.name = "penguin";
objclass3.weight = 22;
objclass3.CommonRegion = "South-East Asia";
objclass3.DisplayBird();
objclass3.DetermineType();
objclass3.Display();

Flight objclass4 = new Flight();
objclass4.name = "Crow";
objclass4.weight = 45;
objclass4.CommonRegion = "South-East Asia";
objclass4.DisplayBird();
objclass4.DetermineType();
objclass4.Display();
