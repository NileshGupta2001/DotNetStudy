// See https://aka.ms/new-console-template for more information
using DependencyInjectionStudy;
Console.WriteLine("Hello, World!");
InkjetPrinter inkjetPrinter = new InkjetPrinter();
LaserPrinter laserPrinter = new LaserPrinter();
StationaryShop sp = new StationaryShop(laserPrinter);
sp.PrintDocument();
