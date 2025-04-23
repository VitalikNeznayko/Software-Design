namespace ClassLibrary
{
    public class LightImageNode : LightElementNode
    {
        private readonly string _href;
        private readonly IImageLoadingStrategy _loadingStrategy;

        public LightImageNode(string href, IImageLoadingStrategy loadingStrategy)
            : base("img", DisplayType.Inline, TagType.Single)
        {
            _href = href;
            _loadingStrategy = loadingStrategy;
        }

        public override string OuterHTML
        {
            get
            {
                var classAttr = CssClasses.Count > 0 ? $" class=\"{string.Join(" ", CssClasses)}\"" : "";
                var src = _loadingStrategy.LoadImage(_href);
                return $"<{TagName}{classAttr} src=\"{src}\"/>";
            }
        }

        public override string InnerHTML => "";
    }

}
