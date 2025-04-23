using InterfaceLibrary;

namespace ClassLibrary
{
    public class KiaomiLaptop : ILaptop
    {
        public void DisplayInfo()
        {
            Console.WriteLine($"Kiaomi Laptop створено.");
        }
    }
}
