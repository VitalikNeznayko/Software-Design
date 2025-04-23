using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary
{
    public abstract class Subscription
    {
        public string Name { get; protected set; }
        public decimal MonthlyPay { get; protected set; }
        public List<string> Channels { get; protected set; }
        public List<string> Features { get; protected set; }

        protected Subscription(string name, decimal monthlyPay)
        {
            Name = name;
            MonthlyPay = monthlyPay;
            Channels = new List<string>();
            Features = new List<string>();
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Підписка: {Name}");
            Console.WriteLine($"Місячна плата: {MonthlyPay} USD");
            Console.WriteLine("Канали: " + string.Join(", ", Channels));
            Console.WriteLine("Можливості: " + string.Join(", ", Features));
            Console.WriteLine();
        }
    }
}
