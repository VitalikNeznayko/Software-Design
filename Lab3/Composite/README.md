# Шаблон "Компонувальник"

### Структура проєкту
1. Клас [LightNode](./ClassLibrary/LightNode.cs):
    - Базовий компонент для всіх вузлів (елементів і тексту)
    - Має абстрактні властивості `OuterHTML` і `InnerHTML`.

2. Лист [LightTextNode](./ClassLibrary/LightTextNode.cs):
    - Представляє текстовий вузол у HTML
    - Конструктор [LightTextNode(string text)](./ClassLibrary/LightTextNode.cs#L7-L10) – задає текст

3. Композит [LightElementNode](./ClassLibrary/LightElementNode.cs):
    - Представляє HTML-елемент, який може містити інші вузли
    - Метод `AddClass` додає CSS-клас до елемента
    - Метод `AddChild` додає дочірній вузол

4. Перелічення [DisplayType](./ClassLibrary//ClassLibrary/LightElementNode.cs#L5-L9)
    - `Block` – елемент займає весь рядок
    - `Inline` – елемент розміщується в рядку
  
5. Перелічення [TagType](./ClassLibrary//ClassLibrary/LightElementNode.cs#L11-L15):
    - `Single` – самозакритий тег
    - `Pair` – парний тег

### Як реалізовано шаблон?
1. Клієнт працює з усіма об'єктами однаково:
    - Викликає однакові властивості (`OuterHTML`, `InnerHTML`) незалежно від типу вузла.
    - Це дозволяє клієнту взаємодіяти з елементами, не знаючи їх внутрішньої структури.
2. Не зважає на тип об'єкта:
    - Клієнт не розрізняє, чи це простий текстовий вузол ([LightTextNode](./ClassLibrary/LightTextNode.cs)), чи складний контейнер ([LightElementNode](./ClassLibrary/LightElementNode.cs)).
    - Усі вузли обробляються однаково, як об'єкти типу [LightNode](./ClassLibrary/LightNode.cs):.
3. Обидва типи вузлів наслідують спільну базу – [LightNode](./ClassLibrary/LightNode.cs):
    - Як [LightTextNode](./ClassLibrary/LightTextNode.cs), так і [LightElementNode](./ClassLibrary/LightElementNode.cs) реалізують спільні властивості та методи, визначені в абстрактному класі [LightNode](./ClassLibrary/LightNode.cs).
    - Це дозволяє обробляти їх однаково, незважаючи на відмінності в функціональності.
