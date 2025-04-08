using ClassLibrary;
using ClassLibrary.Decorators;

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        IHero hero = new Warrior();
        Console.WriteLine($"{hero.GetDescription()} \nСила: {hero.GetPower()}\n");

        hero = new ArmorDecorator(hero);
        hero = new WeaponDecorator(hero);
        hero = new ArtifactDecorator(hero);

        Console.WriteLine($"{hero.GetDescription()} \nСила: {hero.GetPower()}\n");

        IHero mage = new Mage();
        mage = new ArmorDecorator(mage);
        mage = new ArtifactDecorator(mage);
        Console.WriteLine($"{mage.GetDescription()} \nСила: {mage.GetPower()}\n");
    }
}