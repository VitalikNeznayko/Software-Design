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
        private Dictionary<string, List<Action>> eventListeners;

        public LightElementNode(string tagName, DisplayType display, TagType tagType)
        {
            TagName = tagName;
            Display = display;
            TagType = tagType;
            CssClasses = new List<string>();
            Children = new List<LightNode>();
            eventListeners = new Dictionary<string, List<Action>>();
        }

        public void AddChild(LightNode node)
        {
            Children.Add(node);
        }

        public void AddClass(string className)
        {
            CssClasses.Add(className);
        }

        public void AddEventListener(string eventType, Action handler)
        {
            if (!eventListeners.ContainsKey(eventType))
            {
                eventListeners[eventType] = new List<Action>();
            }
            eventListeners[eventType].Add(handler);
        }

        public void TriggerEvent(string eventType)
        {
            if (eventListeners.ContainsKey(eventType))
            {
                Console.WriteLine($"Triggering '{eventType}' event on <{TagName}>");
                foreach (var handler in eventListeners[eventType])
                {
                    handler();
                }
            }
            else
            {
                Console.WriteLine($"No listeners for '{eventType}' event on <{TagName}>");
            }
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
