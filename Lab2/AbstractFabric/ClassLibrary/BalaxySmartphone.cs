using InterfaceLibrary;

namespace ClassLibrary
{
    public class BalaxySmartphone : ISmartphone
    {
        public void DisplayInfo()
        {
            Console.WriteLine($"Balaxy Smartphone створено.");
        }
    }
}
