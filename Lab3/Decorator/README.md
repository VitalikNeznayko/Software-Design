# Шаблон "Декоратор"

### Структура проєкту
1. Інтерфейс [IHero](./ClassLibrary/IHero.cs):
    - Описує базові методи для героїв: `GetDescription()` та `GetPower()`.
2. Клас [Mage](./ClassLibrary/Mage.cs):
    - Клас, що реалізує інтерфейс [IHero](./ClassLibrary/IHero.cs) для створення героя мага.
3. Клас [Palladin](./ClassLibrary/Palladin.cs):
    - Клас, що реалізує інтерфейс [IHero](./ClassLibrary/IHero.cs) для створення героя паладина.
4. Клас [Warrior](./ClassLibrary/Warrior.cs):
    - Клас, що реалізує інтерфейс [IHero](./ClassLibrary/IHero.cs) для створення героя воїна.
5. Абстрактний клас [HeroDecorator](./ClassLibrary/Decorators/HeroDecorator.cs):
   - Абстрактний клас, що реалізує інтерфейс [IHero](./ClassLibrary/IHero.cs) і має посилання на об'єкт [IHero](./ClassLibrary/IHero.cs).
   - Використовується для додавання нової функціональності до об'єктів героїв. Всі конкретні декоратори наслідують цей клас.
6. Декоратор [ArmorDecorator](./ClassLibrary/Decorators/ArmorDecorator.cs):
    - Додає броню до героя, збільшуючи силу.
7. Декоратор [ArtifactDecorator](./ClassLibrary/Decorators/ArtifactDecorator.cs):
    - Додає магічний артефакт до героя, збільшуючи силу.
8. Декоратор [WeaponDecorator](./ClassLibrary/Decorators/WeaponDecorator.cs):
    - Додає зброю до героя, збільшуючи силу.
### Як реалізовано шаблон?
1. Компонування через декоратори:
    - Кожен декоратор (наприклад, [ArmorDecorator](./ClassLibrary/Decorators/ArmorDecorator.cs), [WeaponDecorator](./ClassLibrary/Decorators/WeaponDecorator.cs), [ArtifactDecorator](./ClassLibrary/Decorators/ArtifactDecorator.cs)) має конструктор, що приймає об'єкт [IHero](./ClassLibrary/IHero.cs) і "декорує" його, додаючи нову властивість або змінюючи поведінку.
2. Збереження єдиного інтерфейсу:
    - Завдяки тому, що всі декоратори наслідують абстрактний клас [HeroDecorator](./ClassLibrary/Decorators/HeroDecorator.cs), клієнт може працювати з героями та їх декораторами однаково.
    - Це дозволяє дода́вати нові можливості герою (броню, зброю, артефакти) без необхідності змінювати основні класи героїв.
3. Покрокове додавання властивостей:
    - Герой створюється за допомогою одного з класів-героїв.
    - Потім до героя по черзі додаються різні декоратори (наприклад, спочатку броня, потім зброя, і на завершення магічний артефакт). Кожен декоратор змінює опис і силу героя, додаючи нові властивості.
