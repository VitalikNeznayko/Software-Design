# Шаблон "Міст"
### Структура проєкту
1. Абстрактний клас [Shape](./ClassLibrary/Shape.cs):
    - Абстракція фігури.
    - Містить посилання на інтерфейс [IRenderer](./ClassLibrary/IRenderer.cs).
2. Інтерфейс [IRenderer](./ClassLibrary/IRenderer.cs)
    - Визначає метод [Render](./ClassLibrary/IRenderer.cs#L5C9-L5C39) для рендерингу фігури.
3. Реалізації [IRenderer](./ClassLibrary/IRenderer.cs):
    - [RasterRenderer](./ClassLibrary/RasterRenderer.cs): малює фігуру у вигляді пікселів.
    - [VectorRenderer](./ClassLibrary/VectorRenderer.cs): малює фігуру у вигляді ліній.
4. Реалізації [Shape](./ClassLibrary/Shape.cs):
    - Класи [Circle](./ClassLibrary/Circle.cs), [Square](./ClassLibrary/Square.cs), [Triangle](./ClassLibrary/Triangle.cs). Всі ці класи використовують наданий [IRenderer](./ClassLibrary/IRenderer.cs) для відображення себе.
### Як реалізовано шаблон?
1. Абстракція — клас [Shape](./ClassLibrary/Shape.cs):
    - Містить посилання на інтерфейс [IRenderer](./ClassLibrary/IRenderer.cs).
    - Має абстрактний метод [Draw()](./ClassLibrary/Shape.cs#L12), який делегує роботу рендереру.
2. Реалізація — інтерфейс [IRenderer](./ClassLibrary/IRenderer.cs):
    - Визначає загальний контракт рендерингу.
3. Конкретна реалізація — класи [RasterRenderer](./ClassLibrary/RasterRenderer.cs) та [VectorRenderer](./ClassLibrary/VectorRenderer.cs):
    - Кожен реалізує [IRenderer](./ClassLibrary/IRenderer.cs) по-своєму (пікселі або лінії).
4. Розширення абстракції — класи [Circle](./ClassLibrary/Circle.cs), [Square](./ClassLibrary/Square.cs), [Triangle](./ClassLibrary/Triangle.cs):
    - Вони не залежать від способу рендерингу.
    - Можуть працювати з будь-якою реалізацією [IRenderer](./ClassLibrary/IRenderer.cs).
