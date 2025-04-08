using System.Text;

namespace ClassLibrary
{
    public class HtmlElementFlyweight
    {
        public string TagName { get; }
        public DisplayType Display { get; }
        public TagType TagType { get; }

        public HtmlElementFlyweight(string tagName, DisplayType display, TagType tagType)
        {
            TagName = tagName;
            Display = display;
            TagType = tagType;
        }
    }


}
