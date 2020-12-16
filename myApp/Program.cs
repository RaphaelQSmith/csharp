using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "My first C# program";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello, whats your name?");
            String name = Console.ReadLine();
            Console.WriteLine(name);
            Console.ReadKey();
        }
    }
}
