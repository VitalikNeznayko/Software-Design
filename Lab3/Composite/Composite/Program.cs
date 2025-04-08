using ClassLibrary;
public class Program
{
    public static void Main()
    {
        var div = new LightElementNode("div", DisplayType.Block, TagType.Pair);
        div.AddClass("container");

        var h1 = new LightElementNode("h1", DisplayType.Block, TagType.Pair);
        h1.AddClass("tittle");
        h1.AddChild(new LightTextNode("Назва"));

        var p = new LightElementNode("p", DisplayType.Block, TagType.Pair);
        p.AddChild(new LightTextNode("Текст"));

        div.AddChild(h1);
        div.AddChild(p);

        Console.WriteLine();
        Console.WriteLine(div.OuterHTML);
    }
}
