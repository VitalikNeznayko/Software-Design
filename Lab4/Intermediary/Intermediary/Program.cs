using System;
using System.Collections.Generic;
using ClassLibrary;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        var commandCentre = new CommandCentre();

        var runway1 = new Runway();
        var runway2 = new Runway();
        commandCentre.RegisterRunway(runway1);
        commandCentre.RegisterRunway(runway2);

        var aircraft1 = new Aircraft("Flight 101", commandCentre);
        var aircraft2 = new Aircraft("Flight 202", commandCentre);
        var aircraft3 = new Aircraft("Flight 303", commandCentre);

        Console.WriteLine("Тестування посадки");
        aircraft1.Land();
        aircraft2.Land();
        aircraft3.Land();

        Console.WriteLine("\nТестування зльоту");
        aircraft1.TakeOff();
        aircraft3.Land();
    }
}
