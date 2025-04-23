# Патерн "Мементо"

## Структура проєкту

- [TextDocument](/Lab4/Memento/ClassLibrary/TextDocument.cs) 
  - Редагує та зберігає текст документа.
  - Підтримує операції додавання тексту, видалення та відновлення стану.  

- [TextDocumentMemento](/Lab4/Memento/ClassLibrary/TextDocumentMemento.cs) 
  - Зберігає стан тексту для можливості скасування змін.  


- [TextEditor](/Lab4/Memento/ClassLibrary/TextEditor.cs)
  - Забезпечує введення тексту через консоль.
  - Підтримує скасування змін, видалення та введення тексту.  

## Реалізація патерну

1. **[TextDocument](/Lab4/Memento/ClassLibrary/TextDocument.cs)** зберігає свій стан у класі **[TextDocumentMemento](/Lab4/Memento/ClassLibrary/TextDocumentMemento.cs)**.
2. Кожного разу при зміні тексту (додаванні чи видаленні) створюється нове memento, яке містить поточний стан тексту.
3. Можна відновити попередній стан документа, використовуючи метод **`Undo()`** в класі **[TextEditor](/Lab4/Memento/ClassLibrary/TextEditor.cs)**.
4. Історія змін зберігається у черзі, і скасування змін відбувається шляхом відновлення останнього memento.
