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
        ICharacterBuilder SetAlignment(string alignment); 
        ICharacterBuilder AddGoodDeed(string goodDeed); 
        ICharacterBuilder AddEvilDeed(string evilDeed); 
        Character Build();
    }
}
