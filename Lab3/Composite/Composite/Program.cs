using ClassLibrary;
public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        var div = new LightElementNode("div", DisplayType.Block, TagType.Pair);
        div.AddClass("container");

        var h1 = new LightElementNode("h1", DisplayType.Block, TagType.Pair);
        h1.AddClass("tittle");
        h1.AddChild(new LightTextNode("Назва"));

        var p = new LightElementNode("p", DisplayType.Block, TagType.Pair);
        p.AddChild(new LightTextNode("Текст"));

        div.AddChild(h1);
        div.AddChild(p);

        Console.WriteLine("Ітератор для обоходу в глибину");
        IIterator iterator = new DepthIterator(div);
        while (iterator.HasNext())
        {
            LightNode node = iterator.Next();
            Console.WriteLine(node.OuterHTML);
        }
        Console.WriteLine("\nІтератор для обоходу в ширину");
        IIterator iterator1 = new BreadthIterator(div);
        while (iterator1.HasNext())
        {
            LightNode node = iterator1.Next();
            Console.WriteLine(node.OuterHTML);
        }
    }
}
