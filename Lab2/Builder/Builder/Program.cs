using ClassLibrary;

class Program()
{
    static void Main(string[] args)
    {

        Console.OutputEncoding = System.Text.Encoding.UTF8;
        ICharacterBuilder heroBuilder = new HeroBuilder();
        Character hero = heroBuilder
            .SetName("Кратос")
            .SetStatus("Бог війни")
            .SetHeight("200 см")
            .SetBuild("Мускулистий")
            .SetHairColor("Лисий")
            .SetArmor("Бойові обладунки")
            .SetEyeColor("Бордовий")
            .SetInventory("Леза Хаосу, Сокира Левіафан, Щит Опору, Пояс з осколками Йотунів")
            .SetWeapon("Сокира Левіафан")
            .SetAlignment("Добро")
            .AddGoodDeed("Захистив людей від богів Асгарду")
            .AddGoodDeed("Переміг тиранічних богів Олімпу")
            .AddGoodDeed("Допоміг Фреї врятувати її народ")
            .AddEvilDeed("Вчинив геноцид Олімпу")
            .AddEvilDeed("Зруйнував Світ смертних, засліплений помстою")
            .Build();

        ICharacterBuilder enemyBuilder = new EnemyBuilder();
        Character enemy = enemyBuilder
            .SetName("Бальдр")
            .SetStatus("Бог світла")
            .SetHeight("180 см")
            .SetBuild("Атлетичний")
            .SetHairColor("Рудий")
            .SetArmor("Прості руниці з ведмежої шкіри")
            .SetEyeColor("Крижано-блакитні")
            .SetInventory("Руни, печатки Одіна, браслети з чарівним захистом")
            .SetWeapon("Приховане лезо")
            .SetAlignment("Зло")
            .AddEvilDeed("Завдав смертельного болю матері Фреї")
            .AddEvilDeed("Нехтував власною смертю та нищив усе на шляху")
            .Build();

        Console.WriteLine("Інформація про героя: ");
        hero.DisplayInfo();

        Console.WriteLine("\nІнформація про ворога: ");
        enemy.DisplayInfo();
    }
}
