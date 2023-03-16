// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a = 10;
int b = 0;
try
{
    int c = a / b;
    Console.WriteLine(c);
}
catch(Exception)
{
    Console.WriteLine("Exception Handled");
}

//finally
finally
{
    Console.WriteLine("Program Finished");
}