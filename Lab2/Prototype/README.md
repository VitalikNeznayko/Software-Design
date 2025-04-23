# Шаблон "Прототип"

## Структура проекту

### Основні компоненти
**Клас [Virus](Prototype/Prototype/Program.cs#L4-L49)**  
- Реалізує інтерфейс `ICloneable` для підтримки клонування.
- Властивості:
  - `Name` — ім’я вірусу.
  - `Species` — вид.
  - `Age` — вік.
  - `Weight` — вага.
  - `Children` — список дочірніх вірусів.
- Методи:
  - [Конструктор](Prototype/Prototype/Program.cs#L12-L19) для ініціалізації властивостей.
  - [AddChild(Virus child)](Prototype/Prototype/Program.cs#L32-L35) — додає дочірній вірус до списку `Childs`.
  - [DisplayInfo(int generation)](Prototype/Prototype/Program.cs#L37-L48) — виводить інформацію про вірус та його дітей.
  - [Clone()](Prototype/Prototype/Program.cs#L21-L30) — реалізує клонування об’єкта.

## Як реалізовано "Прототип"
- Клас `Virus` реалізує інтерфейс [ICloneable](Prototype/Prototype/Program.cs#L4), що дозволяє створювати копії об'єктів цього класу.
- Реалізація методу [Clone()](Prototype/Prototype/Program.cs#L21-L30) створює поверхневу копію об'єкта за допомогою методу [MemberwiseClone()](Prototype/Prototype/Program.cs#L23), а також здійснює глибоке копіювання для колекції `Children`, щоб клони не мали спільних посилань на дітей.
- У методі [AddChild(Virus child)](Prototype/Prototype/Program.cs#L32-L35)  додаються діти до списку `Children`, який є колекцією вірусів, що є частиною ієрархії.
