using System;
using ClassLibrary;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        var system = new SupportSystem();
        system.StartMenu();
    }
}
