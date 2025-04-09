# Шаблон "Легковаговик"

### Структура проєкту
1. Клас [HtmlElementFlyweight](./ClassLibrary/HtmlElementFlyweight.cs):
    - Це клас, що представляє загальні характеристики HTML елемента.
    - `TagName`: Назва HTML тега.
    - `Display`: Тип відображення елемента.
    - `TagType`: Тип тега.
2. Фабрика [LightElementFlyweightFactory](./ClassLibrary/LightElementFlyweightFactory.cs):
    - Має словник `_flyweights`, що зберігає вже створені екземпляри [HtmlElementFlyweight](./ClassLibrary/HtmlElementFlyweight.cs), щоб повторно використовувати їх замість створення нових об'єктів для кожного елемента.
    - Метод `GetFlyweight` перевіряє, чи вже існує необхідний об'єкт `Flyweight`, і якщо так — повертає його, інакше створює новий.
3. Клас [LightElementNode](./ClassLibrary/LightElementNode.cs):
    - Наслідується від [LightNode](./ClassLibrary/LightNode.cs) (базовий клас для всіх вузлів, що містять HTML контент).
    - Включає в себе властивості, що відповідають за тег (`TagName`, `Display`, `TagType`), список дочірніх елементів, CSS класи тощо.
    - Використовує об'єкт `Flyweight` ([HtmlElementFlyweight](./ClassLibrary/HtmlElementFlyweight.cs)) для отримання спільних характеристик HTML елемента.
    - Має методи для додавання дочірніх елементів (`AddChild`) і класів (`AddClass`), а також перевизначення властивостей `InnerHTML` та `OuterHTML` для формування результату в HTML.
4. Клас [LightTextNode](./ClassLibrary/LightTextNode.cs):
    - Текстовий вузол, що містить текст і надає реалізацію властивостей `InnerHTML` та `OuterHTML` для відображення тексту.
5. Перерахування [DisplayType](./ClassLibrary/Type.cs#L5-L9) та [TagType](./ClassLibrary/Type.cs#L11-L15) :
    - `DisplayType` містить типи відображення елементів (`Block` або `Inline`).
    - `TagType` визначає, чи є тег одиничним (`Single`) чи парним (`Pair`).

### Як реалізовано шаблон?

1. Перевірка наявності об'єкта в кеші
    - При кожному виклику `factory.GetFlyweight` за певними параметрами фабрика перевіряє, чи вже існує такий `Flyweight` у словнику.

2. Повернення існуючого об'єкта для економії пам'яті
    - Якщо `Flyweight` існує — повертається вже створений об'єкт, що економить пам'ять, оскільки однакові елементи не створюються повторно.

3. Оптимізація використання пам'яті та зменшення кількості створених об'єктів
    - Таким чином, пам'ять використовується ефективніше, і зменшується кількість об'єктів, що потрібно створювати.
