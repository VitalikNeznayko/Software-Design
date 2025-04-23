using ClassLibrary;

class Program()
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        CharacterDirector director = new CharacterDirector();

        Character hero = director.HeroKratos();
        Console.WriteLine("Герой:");
        hero.DisplayInfo();

        Console.WriteLine();

        Character enemy = director.EnemyBaldr();
        Console.WriteLine("Ворог:");
        enemy.DisplayInfo();

    }
}
