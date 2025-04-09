using System.Text;

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

        public LightElementNode(string tagName, DisplayType display, TagType tagType)
        {
            TagName = tagName;
            Display = display;
            TagType = tagType;
            CssClasses = new List<string>();
            Children = new List<LightNode>();
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
    }
}
