using InterfaceLibrary;

namespace ClassLibrary
{
    public class KiaomiSmartphone : ISmartphone
    {
        public void DisplayInfo()
        {
            Console.WriteLine($"Kiaomi Smartphone створено.");
        }
    }
}
