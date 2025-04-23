# Шаблон "Будівельник"

## Структура проекту
### Основні компоненти
**Клас [Character](Builder/ClassLibrary/Character.cs)**  
- Властивості:
 - `Name`, `Status`, `Height`, `Build`, `HairColor`, `EyeColor`, `Armor`, `Inventory`, `Weapon`, `Alignment`  — базові характеристики.
 - `GoodDeeds` — список добрих вчинків.
 - `EvilDeeds` — список поганих вчинків.
- Методи `DisplayInfo()`, який виводить інформацію про персонажа.

**Інтерфейс [ICharacterBuilder](Builder/ClassLibrary/ICharacterBuilder.cs)**  
- Визначає методи для покрокового створення персонажа з текучим інтерфейсом:
 - `SetName()`, `SetStatus()`, `SetHeight()`, `SetBuild()`, `SetHairColor()`, `SetEyeColor()`, `SetArmor()`, `SetInventory()`, `SetWeapon()`, `SetAlignment()`.
 - `AddGoodDeed()`, `AddEvilDeed()` — для додавання елементів до списків.
 - `Build()` — повертає готовий об’єкт `Character`.

**Будівельники**:
- [HeroBuilder](Builder/ClassLibrary/HeroBuilder.cs), який створює героїв.
- [EnemyBuilder](Builder/ClassLibrary/EnemyBuilder.cs), який створює ворогів.
- Обидва методи повертають `this` в усіх методах, окрім `Build()`, що забезпечує можливість ланцюгових викликів.

**Клас [CharacterDirector](Builder/ClassLibrary/CharacterDirector.cs)**  
- Керує процесом створення персонажів.
- Методи:
  - `HeroKratos()` — створює героя під іменем Кратос.
  - `EnemyBaldr()` — створює ворога під іменем Бальдр.

## Як реалізовано "Будівельник"
- Будівельники [HeroBuilder](Builder/ClassLibrary/HeroBuilder.cs), [EnemyBuilder](Builder/ClassLibrary/EnemyBuilder.cs) дозволяють поступово задавати атрибути персонажа через ланцюжок методів.
- Кожен метод повертає [ICharacterBuilder](Builder/ClassLibrary/ICharacterBuilder.cs) ([Приклад методу](Builder/ClassLibrary/EnemyBuilder.cs#L12-L16)), що дозволяє викликати методи в ланцюжку.

## Діаграма
![Builder](https://github.com/VitalikNeznayko/Software-Design/blob/main/Lab2/diagrams/Builder.drawio.png)
