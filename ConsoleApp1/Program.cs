using System.Net.Security;

const double PI = 3.14;

while (true)
{
    Console.Clear();
    Console.WriteLine("Tryk 1 for at udregne omkreds eller tryk 2 for at lukke");
    ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();

    Console.WriteLine();
    Console.Write("Indtast radius");
    Console.WriteLine();
    double Radius = double.Parse(Console.ReadLine());
    

    if (consoleKeyInfo.KeyChar == 49) // '1'
    {
        Console.WriteLine("omkreds = " + (2 * Radius * PI));
    }
    else if(consoleKeyInfo.KeyChar == 50) // ''
    {
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("areal = " + (Radius * Radius * PI));
    }
    Console.WriteLine("Tryk en tast for at fortsætte...");
    Console.ReadKey();

    
}
