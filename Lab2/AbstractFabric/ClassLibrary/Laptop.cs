using InterfaceLibrary;

namespace ClassLibrary
{
    public class Laptop : IDevice
    {
        private readonly string _brand;
        public Laptop(string brand)
        {
            _brand = brand;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"{_brand} Laptop створено.");
        }
    }
}
