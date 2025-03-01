# Принципи програмування в проєкті

## DRY (Don't Repeat Yourself)
+ В класі [Warehouse](./Warehouse/ClassLibrary/Warehouse.cs) було використано метод [GetProducts()](./Warehouse/ClassLibrary/Warehouse.cs#L17-L20), , який дозволяє отримати список продуктів і таким чином уникнути повторення коду в інших частинах програми. Наприклад, в класі [Reporting](./Warehouse/ClassLibrary/Reporting.cs) методи [GenerateInventoryReport](./Warehouse/ClassLibrary/Reporting.cs#L17-L24), [GenerateCategoryReport](./Warehouse/ClassLibrary/Reporting.cs#L26-L42) та [GenerateTotalValueReport](./Warehouse/ClassLibrary/Reporting.cs#L44-L56) використовують GetProducts().
+ В класі [Money](./Warehouse/ClassLibrary/Money.cs) метод [ConvertTo()](./Warehouse/ClassLibrary/Money.cs#L48-L56) дозволяє уникнути дублювання логіки конвертації в різних місцях коду.

## KISS (Keep It Simple, Stupid)
+ В коді кожен клас виконує окрему відповідальність.
+ Конвертація валют реалізована через [Dictionary<CurrencyType, decimal>](./Warehouse/ClassLibrary/Money.cs#L22-L27), що зменшує кількість умов у коді.
  
## SOLID
### S — Single Responsibility Principle (SRP)
+ Кожен клас виконує чітку функцію: [Warehouse](./Warehouse/ClassLibrary/Warehouse.cs) відповідає за зберігання та управління продуктами, [Reporting](./Warehouse/ClassLibrary/Reporting.cs) генерує звіти, [Product](./Warehouse/ClassLibrary/Product.cs) представляє продукт і його дані, а [Money](./Warehouse/ClassLibrary/Money.cs) керує фінансами та конвертацією.
### O — Open/Closed Principle (OCP)
+ Категорії реалізовані через enum, тому додавання нових товарів не вимагає зміни логіки класу [Product](./Warehouse/ClassLibrary/Product.cs) або [Warehouse](./Warehouse/ClassLibrary/Warehouse.cs).
+ Валюти також реалізовані через enum, тому клас [Money](./Warehouse/ClassLibrary/Money.cs) підтримує їх розширення без змін у своєму коді.
### D — Dependency Inversion Principle (DIP)
+ Клас [Reporting](./Warehouse/ClassLibrary/Reporting.cs) залежить від [Warehouse](./Warehouse/ClassLibrary/Warehouse.cs), але передається через конструктор, що дозволяє легко замінити реалізацію класу Warehouse.

## YAGNI (You Ain’t Gonna Need It)
+ Принцип YAGNI полягає в тому, щоб не додавати функціональність до того, як вона стане потрібною. Код не містить зайвих методів або полів, які не використовуються.

## Composition Over Inheritance
+ [Warehouse](./Warehouse/ClassLibrary/Warehouse.cs) містить список [Product](./Warehouse/ClassLibrary/Warehouse.cs#L11) замість того, щоб наслідувати Product від Warehouse.
+ [Reporting](./Warehouse/ClassLibrary/Reporting.cs) використовує [Warehouse](./Warehouse/ClassLibrary/Reporting.cs#L11) через композицію, а не через наслідування.
  
## Fail Fast
+ В [GenerateCategoryReport](./Warehouse/ClassLibrary/Reporting.cs#L26-L42), якщо category неправильна, метод одразу виводить "Неправильна категорія!" і припиняє виконання.
+ В [Money.operator -](./Warehouse/ClassLibrary/Money.cs#L58-L68) перевіряється, чи валюти однакові, інакше кидається InvalidOperationException.
