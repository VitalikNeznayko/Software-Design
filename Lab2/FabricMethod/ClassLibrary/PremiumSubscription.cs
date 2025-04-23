using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class PremiumSubscription : Subscription
    {
        public PremiumSubscription() : base("Преміум", 10)
        {
            Channels.AddRange(new List<string> { "Спорт HD", "Кіно", "Екслюзивні шоу", "Мультфільми", "Освіта", "Документальні"});
            Features.AddRange(new List<string> { "4K якість", "Без реклами"});
        }
    }
}
