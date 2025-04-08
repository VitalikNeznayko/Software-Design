using System.Text;

namespace ClassLibrary
{
    public class LightElementNode : LightNode
    {
        public string TagName { get; }
        public DisplayType Display { get; }
        public TagType TagType { get; }
        public List<string> CssClasses { get; }
        public List<LightNode> Children { get; }

        public HtmlElementFlyweight Flyweight { get; }

        public LightElementNode(HtmlElementFlyweight flyweight)
        {
            Flyweight = flyweight;
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
                if (Flyweight.TagType == TagType.Single)
                    return $"<{Flyweight.TagName}{classAttr}/>";
                return $"<{Flyweight.TagName}{classAttr}>{InnerHTML}</{Flyweight.TagName}>\n";
            }
        }
    }
}
