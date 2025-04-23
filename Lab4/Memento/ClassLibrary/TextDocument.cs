namespace ClassLibrary
{
    public class TextDocument
    {
        private string _content = "";
        public void Edit(string text)
        {
            _content += text;
        }

        public void Delete()
        {
            if (_content.Length > 0)
            {
                _content = _content.Substring(0, _content.Length - 1);
            }
        }

        public string GetContent()
        {
            return _content;
        }

        public TextDocumentMemento Save()
        {
            return new TextDocumentMemento(_content);
        }

        public void Undo(TextDocumentMemento memento)
        {
            _content = memento._state;
        }
    }
}
