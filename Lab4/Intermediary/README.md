# Патерн "Посередник"

## Структура проєкту

- **[Aircraft](/Lab4/Intermediary/ClassLibrary/Aircraft.cs)**
  - Представляє літак.
  - Має ім’я та прапор `IsTakingOff`.
  - Через посередника ([IMediator](/Lab4/Intermediary/ClassLibrary/IMediator.cs)) надсилає запити на посадку або зліт.

- **[Runway](/Lab4/Intermediary/ClassLibrary/Runway.cs)**
  - Представляє злітно-посадкову смугу.
  - Має унікальний ідентифікатор (`Guid`) та прапор `IsBusy`.
  - Методи `HighLightRed` і `HighLightGreen` сигналізують про статус смуги.

- **[CommandCentre](/Lab4/Intermediary/ClassLibrary/CommandCentre.cs)**
  - Посередник між літаками та злітно-посадковими смугами.
  - Реєструє літаки та смуги.
  - Обробляє запити на посадку та зліт, призначаючи смуги або повідомляючи про зайнятість.

- **[IMediator](/Lab4/Intermediary/ClassLibrary/IMediator.cs)**
  - Інтерфейс посередника.
  - Визначає методи для запитів на посадку/зліт і реєстрацію літаків/смуг.

## Реалізація патерну
1. Посередник (CommandCentre) відповідає за координацію дій між літаками ([Aircraft](/Lab4/Intermediary/ClassLibrary/Aircraft.cs)) і смугами ([Runway](/Lab4/Intermediary/ClassLibrary/Runway.cs)).
2. Літаки не взаємодіють зі смугами напряму — вони звертаються до посередника, який вирішує, яка смуга вільна.
