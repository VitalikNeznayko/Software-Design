using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Reporting
    {
        private Warehouse _warehouse;
        public Reporting(Warehouse warehouse)
        {
            _warehouse = warehouse;
        }

        public void GenerateInventoryReport()
        {
            Console.WriteLine("===== Інвентаризаційний звіт =====\n");
            foreach (var product in _warehouse.GetProducts())
            {
                product.Display();
            }
        }

        public void GenerateCategoryReport(string category)
        {
            if (!Enum.TryParse(category, out Category categoryEnum))
            {
                Console.WriteLine("Неправильна категорія!");
                return;
            }

            Console.WriteLine($"===== Звіт по категорії '{categoryEnum}' =====");
            foreach (var product in _warehouse.GetProducts())
            {
                if (product.ProductCategory == categoryEnum) 
                {
                    product.Display();
                }
            }
        }

        public void GenerateTotalValueReport()
        {
            CurrencyType targetCurrency = CurrencyType.UAH;
            decimal totalAmount = 0;

            foreach (var product in _warehouse.GetProducts())
            {
                Money convertedPrice = product.Price.ConvertTo(targetCurrency);
                totalAmount += convertedPrice.Whole + convertedPrice.Cents / 100m;
            }

            Console.WriteLine($"Загальна вартість товарів на складі: {totalAmount:F2} {targetCurrency}");
        }
    }
}
