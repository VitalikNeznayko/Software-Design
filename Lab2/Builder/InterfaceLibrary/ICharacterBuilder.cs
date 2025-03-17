namespace InterfaceLibrary
{
    public interface ICharacterBuilder
    {
        ICharacterBuilder SetHeight(string height);
        ICharacterBuilder SetBuild(string build);
        ICharacterBuilder SetHairColor(string hairColor);
        ICharacterBuilder SetEyeColor(string eyeColor);
        ICharacterBuilder SetClothing(string clothing);
        ICharacterBuilder SetInventory(string inventory);
        ICharacterBuilder SetAlignment(string alignment); // Для EnemyBuilder: добро або зло
        ICharacterBuilder AddGoodDeed(string goodDeed); // Додатковий метод для добрих вчинків
        ICharacterBuilder AddEvilDeed(string evilDeed); // Додатковий метод для злих вчинків
        Character Build();
    }
}
