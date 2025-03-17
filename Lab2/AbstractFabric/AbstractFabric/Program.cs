using InterfaceLibrary;
using ClassLibrary;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        IBrandFactory[] factories = { new IProneFactory(), new KiaomiFactory(), new BalaxyFactory() };

        foreach (var factory in factories)
        {
            var laptop = factory.CreateLaptop();
            var tablet = factory.CreateTablet();
            var smartphone = factory.CreateSmartphone();

            laptop.ShowInfo();
            tablet.ShowInfo();
            smartphone.ShowInfo();

            Console.WriteLine();
        }
    }
}