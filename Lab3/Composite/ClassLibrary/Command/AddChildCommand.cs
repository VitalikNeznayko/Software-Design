namespace ClassLibrary.Command
{
    public class AddChildCommand : ICommand
    {
        private LightElementNode _parent;
        private LightNode _child;

        public AddChildCommand(LightElementNode parent, LightNode child)
        {
            _parent = parent;
            _child = child;
        }

        public void Execute()
        {
            _parent.AddChild(_child);
        }

        public void Undo()
        {
            _parent.Children.Remove(_child);
        }
    }
}
