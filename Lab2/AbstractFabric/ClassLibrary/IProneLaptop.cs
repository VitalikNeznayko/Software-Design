using InterfaceLibrary;

namespace ClassLibrary
{
    public class IProneLaptop : ILaptop
    {
        public void DisplayInfo()
        {
            Console.WriteLine($"IProne Laptop створено.");
        }
    }
}
