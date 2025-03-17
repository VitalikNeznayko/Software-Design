using InterfaceLibrary;

namespace ClassLibrary
{
    public class BalaxyTablet : ITablet
    {
        public void DisplayInfo()
        {
            Console.WriteLine($"Balaxy Tablet створено.");
        }
    }
}
