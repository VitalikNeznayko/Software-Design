
namespace ClassLibrary
{
    public class LightElementFlyweightFactory
    {
        private readonly Dictionary<string, HtmlElementFlyweight> _flyweights = new();

        public HtmlElementFlyweight GetFlyweight(string tagName, DisplayType displayType, TagType tagType)
        {
            string key = $"{tagName}_{displayType}_{tagType}";

            if (_flyweights.ContainsKey(key))
                return _flyweights[key];

            var newFlyweight = new HtmlElementFlyweight(tagName, displayType, tagType);
            _flyweights[key] = newFlyweight;
            return newFlyweight;
        }

        public int Count => _flyweights.Count;
    }
}
