namespace ClassLibrary
{
    public class LightTextNode : LightNode
    {
        private string text;

        public LightTextNode(string text)
        {
            this.text = text;
        }

        public override string OuterHTML => text;

        public override string InnerHTML => text;

    }

}
