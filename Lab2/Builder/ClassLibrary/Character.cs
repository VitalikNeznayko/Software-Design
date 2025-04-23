using ClassLibrary;

namespace ClassLibrary
{
    public class Character
    {
        public string Name { get; set; }
        public string Status { get; set; }
        public string Height { get; set; }
        public string Build { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string Armor { get; set; }
        public string Inventory { get; set; }
        public string Weapon { get; set; }
        public string Alignment { get; set; }
        public List<string> GoodDeeds { get; set; } = new List<string>();
        public List<string> EvilDeeds { get; set; } = new List<string>();

        public void DisplayInfo()
        {
            Console.WriteLine($"Ім'я: {Name}");
            Console.WriteLine($"Статус: {Status}");
            Console.WriteLine($"Зріст: {Height}");
            Console.WriteLine($"Статура тіла: {Build}");
            Console.WriteLine($"Колір волосся: {HairColor}");
            Console.WriteLine($"Колір очей: {EyeColor}");
            Console.WriteLine($"Обладунки: {Armor}");
            Console.WriteLine($"Інвентар: {Inventory}");
            Console.WriteLine($"Зброя: {Weapon}");
            Console.WriteLine($"Зло чи добро: {Alignment}");

            if (GoodDeeds.Any())
            {
                Console.WriteLine("Хороші Вчинки:");
                foreach (var deed in GoodDeeds)
                {
                    Console.WriteLine($"- {deed}");
                }
            }
            if (EvilDeeds.Any())
            {
                Console.WriteLine("Злі вчинки:");
                foreach (var deed in EvilDeeds)
                {
                    Console.WriteLine($"- {deed}");
                }
            }
        }
    }

}

