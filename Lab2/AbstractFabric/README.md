# Шаблон "Абстрактна фабрика"

## Структура проекту
**Інтерфейси продуктів**  
   - [ILaptop](AbstractFabric/InterfaceLibrary/ILaptop.cs) — інтерфейс для ноутбуків.
   - [ITablet](AbstractFabric/InterfaceLibrary/ITablet.cs) — інтерфейс для нетбуків.
   - [ISmartphone](AbstractFabric/InterfaceLibrary/ISmartphone.cs) — інтерфейс для смартфонів.
   - Кожен інтерфейс містить метод `DisplayInfo()` для виведення інформації про пристрій.

**Продукти**:  
- Для кожного бренду (`IProne`, `Kiaomi`, `Balaxy`) реалізовано по три класи продуктів:
  - [IProneLaptop](AbstractFabric/ClassLibrary/IProneLaptop.cs), [IProneTablet](AbstractFabric/ClassLibrary/IProneTablet.cs), [IProneSmartphone](AbstractFabric/ClassLibrary/IProneSmartphone.cs).
  - [KiaomiLaptop](AbstractFabric/ClassLibrary/KiaomiLaptop.cs), [KiaomiTablet](AbstractFabric/ClassLibrary/KiaomiTablet.cs), [KiaomiSmartphone](AbstractFabric/ClassLibrary/KiaomiSmartphone.cs).
  - [BalaxyLaptop](AbstractFabric/ClassLibrary/BalaxyLaptop.cs), [BalaxyTablet](AbstractFabric/ClassLibrary/BalaxyTablet.cs), [BalaxySmartphone](AbstractFabric/ClassLibrary/BalaxySmartphone.cs).
- Кожен клас:
  - Реалізує відповідний інтерфейс.
  - Реалізує `DisplayInfo()` для виведення інформації про створення.

**Інтерфейс [IDeviceFactory](AbstractFabric/InterfaceLibrary/IDeviceFactory.cs)**  
- Визначає методи для створення кожного типу пристрою:
  - `CreateLaptop()`
  - `CreateTablet()`
  - `CreateSmartphone()`

**Фабрики**:  
- [IProneFactory](AbstractFabric/ClassLibrary/IProneFactory.cs) — створює пристрої бренду `IProne`.
- [KiaomiFactory](AbstractFabric/ClassLibrary/KiaomiFactory.cs) — створює пристрої бренду `Kiaomi`.
- [BalaxyFactory](AbstractFabric/ClassLibrary/BalaxyFactory.cs) — створює пристрої бренду `Balaxy`.
- Кожна фабрика реалізує [IDeviceFactory](AbstractFabric/InterfaceLibrary/IDeviceFactory.cs).
     
## Як реалізовано "Абстрактну фабрику"
- Кожна фабрика [IProneFactory](AbstractFabric/ClassLibrary/IProneFactory.cs), [KiaomiFactory](AbstractFabric/ClassLibrary/KiaomiFactory.cs), [BalaxyFactory](AbstractFabric/ClassLibrary/BalaxyFactory.cs) створює повний набір пристроїв одного бренду, забезпечуючи їхню сумісність і консистентність.
- Клієнтський код взаємодіє з інтерфейсом [IDeviceFactory](AbstractFabric/InterfaceLibrary/IDeviceFactory.cs), а не з конкретними класами пристроїв, що дозволяє легко змінювати бренд без внесення змін у логіку використання.
- Усі продукти повертаються через інтерфейси([ILaptop](AbstractFabric/InterfaceLibrary/ILaptop.cs), [ITablet](AbstractFabric/InterfaceLibrary/ITablet.cs), [ISmartphone](AbstractFabric/InterfaceLibrary/ISmartphone.cs) ),що дозволяє працювати з ними узагальнено, незалежно від бренду.
## Діаграма
![abstract factory](https://github.com/VitalikNeznayko/Software-Design/blob/main/Lab2/diagrams/AbstractFabric.drawio.png)
