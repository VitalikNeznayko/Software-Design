using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class EducationalSubscription : Subscription
    {
        public EducationalSubscription() : base("Навчальна", 10)
        {
            Channels.AddRange(new List<string> { "Наука", "Освіта", "Документальні" });
            Features.AddRange(new List<string> { "Full HD", "Можливість переглянути запис лекцій" });
        }
    }
}
