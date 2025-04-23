# Патерн "Ланцюжок відповідальності"

## Структура

- **[SupportHandler](/Lab4/Chain%20of%20Responsibility/ClassLibrary/SupportHandler.cs)** – базовий клас для всіх обробників, реалізує логіку передачі запиту далі, якщо поточний обробник не може його обробити.
- **[DeviceSupportHandler](/Lab4/Chain%20of%20Responsibility/ClassLibrary/DeviceSupportHandler.cs)** – обробляє технічні проблеми, пов’язані з пристроями.
- **[NetworkSupportHandler](/Lab4/Chain%20of%20Responsibility/ClassLibrary/NetworkSupportHandler.cs)** – обробляє технічні проблеми, пов’язані з мережею.
- **[PaymentSupportHandler](/Lab4/Chain%20of%20Responsibility/ClassLibrary/PaymentSupportHandler.cs)** – обробляє фінансові проблеми, пов’язані з платежами.
- **[RefundSupportHandler](/Lab4/Chain%20of%20Responsibility/ClassLibrary/RefundSupportHandler.cs)** – обробляє запити на повернення коштів.
- **[UserRequest](/Lab4/Chain%20of%20Responsibility/ClassLibrary/UserRequest.cs)** – клас, що представляє запит користувача. Містить інформацію про тип і підтип проблеми, а також стан обробки запиту.
- **[SupportSystem](/Lab4/Chain%20of%20Responsibility/ClassLibrary/SupportSystem.cs)** – створює ланцюг обробників та надає інтерфейс для взаємодії з користувачем через консольне меню.

## Реалізація патерну

1. **[SupportHandler](/Lab4/Chain%20of%20Responsibility/ClassLibrary/SupportHandler.cs)** – базовий абстрактний клас, що містить метод `HandleRequest`. У цьому методі, якщо обробник не може вирішити проблему, запит передається наступному в ланцюгу.
2. **Конкретні обробники ([DeviceSupportHandler](/Lab4/Chain%20of%20Responsibility/ClassLibrary/DeviceSupportHandler.cs), [NetworkSupportHandler](/Lab4/Chain%20of%20Responsibility/ClassLibrary/NetworkSupportHandler.cs), [PaymentSupportHandler](/Lab4/Chain%20of%20Responsibility/ClassLibrary/PaymentSupportHandler.cs), [RefundSupportHandler](/Lab4/Chain%20of%20Responsibility/ClassLibrary/RefundSupportHandler.cs))** – кожен з них перевіряє тип і підтип запиту, і якщо відповідний обробник знаходить відповідне рішення, воно виводиться, і запит позначається як оброблений.
3. **[SupportSystem](/Lab4/Chain%20of%20Responsibility/ClassLibrary/SupportSystem.cs)** – ініціалізує ланцюг обробників, встановлює їх взаємозв’язки та надає інтерфейс для взаємодії з користувачем через консоль.
4. **[UserRequest](/Lab4/Chain%20of%20Responsibility/ClassLibrary/UserRequest.cs)** – представляє запит користувача, має властивості для типу запиту та його підтипу, а також логіку для перезапуску запиту, якщо він не був оброблений.
