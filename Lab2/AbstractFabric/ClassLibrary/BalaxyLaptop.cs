using InterfaceLibrary;

namespace ClassLibrary
{
    public class BalaxyLaptop : ILaptop
    {
        public void DisplayInfo()
        {
            Console.WriteLine($"Balaxy Laptop створено.");
        }
    }
}
