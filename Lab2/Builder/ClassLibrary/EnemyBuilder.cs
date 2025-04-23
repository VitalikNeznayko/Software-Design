using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class EnemyBuilder : ICharacterBuilder
    {
        private Character character = new Character();
        public ICharacterBuilder SetName(string name)
        {
            character.Name = name;
            return this;
        }
        public ICharacterBuilder SetStatus(string status)
        {
            character.Status = status;
            return this;
        }
        public ICharacterBuilder SetHeight(string height)
        {
            character.Height = height;
            return this;
        }

        public ICharacterBuilder SetBuild(string build)
        {
            character.Build = build;
            return this;
        }

        public ICharacterBuilder SetHairColor(string hairColor)
        {
            character.HairColor = hairColor;
            return this;
        }

        public ICharacterBuilder SetEyeColor(string eyeColor)
        {
            character.EyeColor = eyeColor;
            return this;
        }

        public ICharacterBuilder SetArmor(string armor)
        {
            character.Armor = armor;
            return this;
        }

        public ICharacterBuilder SetInventory(string inventory)
        {
            character.Inventory = inventory;
            return this;
        }

        public ICharacterBuilder SetWeapon(string weapon)
        {
            character.Weapon = weapon;
            return this;
        }

        public ICharacterBuilder SetAlignment(string alignment = "Зло")
        {
            character.Alignment = alignment;
            return this;
        }

        public ICharacterBuilder AddGoodDeed(string goodDeed)
        {
            return this;
        }

        public ICharacterBuilder AddEvilDeed(string evilDeed)
        {
            character.EvilDeeds.Add(evilDeed);
            return this;
        }
        public Character Build()
        {
            return character;
        }
    }
}
