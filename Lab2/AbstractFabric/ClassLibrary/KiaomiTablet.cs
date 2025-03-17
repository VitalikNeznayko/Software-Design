using InterfaceLibrary;

namespace ClassLibrary
{
    public class KiaomiTablet : ITablet
    {
        public void DisplayInfo()
        {
            Console.WriteLine($"Kiaomi Tablet створено.");
        }
    }
}
