using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Money price1 = new Money(25.50m, CurrencyType.UAH);
            Money price2 = new Money(28.60m, CurrencyType.UAH);
            Money price3 = new Money(99.99m, CurrencyType.UAH);
            Money price4 = new Money(12.75m, CurrencyType.UAH);

            Product apple = new Product("Яблуко", price1, 20, Category.Food);
            Product pear = new Product("Груша", price2, 20, Category.Food);
            Product jeans = new Product("Джинси", price3, 30, Category.Clothing);
            Product mouse = new Product("Миша", price4, 40, Category.Electonics);

            pear.DecreasePrice(5.00m);

            Warehouse warehouse = new Warehouse();
            warehouse.AddProduct(apple);
            warehouse.AddProduct(pear);
            warehouse.AddProduct(jeans);
            warehouse.AddProduct(mouse);


            Reporting report = new Reporting(warehouse);

            report.GenerateInventoryReport();

            report.GenerateCategoryReport("Food");

            Console.WriteLine("\n=== Загальна вартість товарів ===");
            report.GenerateTotalValueReport();
        }
    }
}

