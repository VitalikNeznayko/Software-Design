# Шаблон "Фабричний метод"
## Структура проекту
**Абстрактний клас [Subscription](FabricMethod/ClassLibrary/Subscription.cs)**:
- Властивості:
  - `Name` – назва підписки.
  - `MonthlyPay` – місячна плата за підписку.
  - `Channels` – список доступних каналів.
  - `Features` – список додаткових можливостей підписки.
  
**Класи підписок**:

- [DomesticSubscription](FabricMethod/ClassLibrary/DomesticSubscription.cs) – базовий пакет каналів.
- [EducationalSubscription](FabricMethod/ClassLibrary/EducationalSubscription.cs) – навчальні та документальні канали.
- [PremiumSubscription](FabricMethod/ClassLibrary/PremiumSubscription.cs) – максимальний набір HD-каналів.

**Фабрики**:

- [WebSite](FabricMethod/ClassLibrary/WebSite.cs) – створення через вебсайт.
- [MobileApp](FabricMethod/ClassLibrary/MobileApp.cs) – створення через мобільний додаток.
- [ManagerCall](FabricMethod/ClassLibrary/ManagerCall.cs) – оформлення через дзвінок менеджера.

## Як реалізовано "Фабричний метод":
- Клієнтський код не створює об'єкти підписок, а передає цю відповідальність фабрикам([WebSite](FabricMethod/ClassLibrary/WebSite.cs), [MobileApp](FabricMethod/ClassLibrary/MobileApp.cs), [ManagerCall](FabricMethod/ClassLibrary/ManagerCall.cs)).
- Усі фабрики успадковують абстрактний клас [Subscription](FabricMethod/ClassLibrary/Subscription.cs), що забезпечує уніфікований підхід до роботи з підписками, незалежно від їх конкретного типу.
- Додавання нового типу підписки вимагає лише створення нового класу та внесення відповідного кейсу в `switch` кожної фабрики.

## Діаграма
![factoryMethod](https://github.com/VitalikNeznayko/Software-Design/blob/main/Lab2/diagrams/FabricMethod.drawio.png)
