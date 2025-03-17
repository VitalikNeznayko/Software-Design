using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class CharacterDirector
    {
        public Character HeroKratos()
        {
            return new HeroBuilder()
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
        }
        public Character EnemyBaldr()
        {
            return new EnemyBuilder()
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
        }
    }
}
