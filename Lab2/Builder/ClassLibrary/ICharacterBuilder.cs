namespace ClassLibrary
{
    public interface ICharacterBuilder
    {
        ICharacterBuilder SetName(string name);
        ICharacterBuilder SetStatus(string status);
        ICharacterBuilder SetHeight(string height);
        ICharacterBuilder SetBuild(string build);
        ICharacterBuilder SetHairColor(string hairColor);
        ICharacterBuilder SetEyeColor(string eyeColor);
        ICharacterBuilder SetArmor(string armor);
        ICharacterBuilder SetInventory(string inventory);
        ICharacterBuilder SetWeapon(string weapon);
        ICharacterBuilder SetAlignment(string alignment); 
        ICharacterBuilder AddGoodDeed(string goodDeed);
        ICharacterBuilder AddEvilDeed(string evilDeed);
        Character Build();
    }
}
