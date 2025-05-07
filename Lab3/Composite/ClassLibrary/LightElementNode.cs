using ClassLibrary.State;
using System.Text;
using ClassLibrary.Visitor;

namespace ClassLibrary
{
    public enum DisplayType
    {
        Block,
        Inline
    }

    public enum TagType
    {
        Single,
        Pair
    }
    public class LightElementNode : LightNode
    {
        public string TagName { get; }
        public DisplayType Display { get; }
        public TagType TagType { get; }
        public List<string> CssClasses { get; }
        public List<LightNode> Children { get; }

        private IState _state;
        public LightElementNode(string tagName, DisplayType display, TagType tagType)
        {
            TagName = tagName;
            Display = display;
            TagType = tagType;
            CssClasses = new List<string>();
            Children = new List<LightNode>();
            _state = new VisibleState();
        }
        public void SetState(IState state)
        {
            _state = state;
        }

        public void Render()
        {
            _state.Render(this);
        }

        public void AddChild(LightNode node)
        {
            Children.Add(node);
        }

        public void AddClass(string className)
        {
            CssClasses.Add(className);
        }

        public override string InnerHTML => string.Join("", Children.Select(c => c.OuterHTML));

        public override string OuterHTML
        {
            get
            {
                var classAttr = CssClasses.Count > 0 ? $" class=\"{string.Join(" ", CssClasses)}\"" : "";
                if (TagType == TagType.Single)
                    return $"<{TagName}{classAttr}/>";
                return $"<{TagName}{classAttr}>{InnerHTML}</{TagName}>";
            }
        }

        public override void Accept(ILightNodeVisitor visitor)
        {
            visitor.VisitElementNode(this);
        }
    }
}
