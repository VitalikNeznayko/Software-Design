namespace ClassLibrary
{
    public class TextEditor
    {
        private TextDocument _document = new TextDocument();
        private Queue<TextDocumentMemento> _history = new();
        private const int _maxLength = 20;

        public void Start()
        {
            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);

                if (keyInfo.Key == ConsoleKey.Z && keyInfo.Modifiers.HasFlag(ConsoleModifiers.Control))
                {
                    Undo();
                }
                else if (keyInfo.Key == ConsoleKey.Backspace)
                {
                    if (_document.GetContent().Length > 0)
                    {
                        Delete();
                        Show();
                    }
                }
                else if (keyInfo.Key == ConsoleKey.Enter)
                {
                    Type("\n");
                    Show();
                }
                else
                {

                    Type(keyInfo.KeyChar.ToString());
                    Show();
                }
            }
        }
        private void Type(string text)
        {
            if (_history.Count >= _maxLength)
            {
                _history.Dequeue();
            }
            _history.Enqueue(_document.Save());
            _document.Edit(text);
        }

        private void Delete()
        {
            if (_history.Count >= _maxLength)
            {
                _history.Dequeue();
            }
            _history.Enqueue(_document.Save());
            _document.Delete();
        }

        private void Undo()
        {
            if (_history.Count > 0)
            {
                var last = _history.Last();
                _history = new Queue<TextDocumentMemento>(_history.Take(_history.Count - 1));
                _document.Undo(last);
                Show();
            }
        }

        private void Show()
        {
            Console.Clear();

            string content = _document.GetContent();
            Console.Write(content);

            int lines = content.Count(c => c == '\n');
            int lastLineLength = content.Split('\n').LastOrDefault()?.Length ?? 0;

            Console.SetCursorPosition(lastLineLength, lines);
        }
    }
}
