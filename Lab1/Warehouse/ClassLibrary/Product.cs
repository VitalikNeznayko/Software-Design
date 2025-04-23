using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public enum Category
    {
        Food,
        Clothing,
        Electonics,
        Other
    }
    public class Product
    {
        public string Name { get; protected set; }
        public Money Price { get; protected set; }
        public int Quantity { get; protected set; }
        public Category ProductCategory { get; protected set; }

        public Product(string name, Money price, int quantity, Category category)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            ProductCategory = category;
        }

        public void Display()
        {
            Console.WriteLine($"===== Продукт '{Name}' =====");
            Console.WriteLine($"Назва продукту: {Name}");
            Console.WriteLine($"Категорія: {ProductCategory}");
            Console.WriteLine($"Кількість: {Quantity}");
            Console.Write($"Ціна: ");
            Price.Display();
            Console.WriteLine("===========================\n");
        }

        public void DecreasePrice(decimal price)
        {
            Money money = new Money(price, Price.Currency);
            Price -= money;
        }
    }
}
