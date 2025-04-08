using ClassLibrary;

class Program
{
    static void Main()
    {
        var factory = new LightElementFlyweightFactory();

        var lines = File.ReadAllLines("book.txt");

        // З Flyweight
        var bodyFlyweight = factory.GetFlyweight("body", DisplayType.Block, TagType.Pair);
        var root = new LightElementNode(bodyFlyweight);

        for (int i = 0; i < lines.Length; i++)
        {
            var line = lines[i];
            HtmlElementFlyweight flyweight;

            if (i == 0)
                flyweight = factory.GetFlyweight("h1", DisplayType.Block, TagType.Pair);
            else if (line.Length < 20)
                flyweight = factory.GetFlyweight("h2", DisplayType.Block, TagType.Pair);
            else if (line.StartsWith(" "))
                flyweight = factory.GetFlyweight("blockquote", DisplayType.Block, TagType.Pair);
            else
                flyweight = factory.GetFlyweight("p", DisplayType.Block, TagType.Pair);

            var element = new LightElementNode(flyweight);
            element.AddChild(new LightTextNode(line.Trim()));
            root.AddChild(element);
        }

        Console.WriteLine("With flyweight");
        Console.WriteLine(root.OuterHTML);

        long memoryUsed = GC.GetTotalMemory(true);
        Console.WriteLine($"\nMemory used: {memoryUsed / 1024.0:F2} KB");
        Console.WriteLine($"Flyweight elements reused: {factory.Count}");

        // Без Flyweight
        //var rootWithoutFlyweight = new LightElementNode(new HtmlElementFlyweight("body", DisplayType.Block, TagType.Pair));

        //for (int i = 0; i < lines.Length; i++)
        //{
        //    var line = lines[i];
        //    HtmlElementFlyweight flyweightWithoutFlyweight;

        //    if (i == 0)
        //        flyweightWithoutFlyweight = new HtmlElementFlyweight("h1", DisplayType.Block, TagType.Pair);
        //    else if (line.Length < 20)
        //        flyweightWithoutFlyweight = new HtmlElementFlyweight("h2", DisplayType.Block, TagType.Pair);
        //    else if (line.StartsWith(" "))
        //        flyweightWithoutFlyweight = new HtmlElementFlyweight("blockquote", DisplayType.Block, TagType.Pair);
        //    else
        //        flyweightWithoutFlyweight = new HtmlElementFlyweight("p", DisplayType.Block, TagType.Pair);

        //    var element = new LightElementNode(flyweightWithoutFlyweight);
        //    element.AddChild(new LightTextNode(line.Trim()));
        //    rootWithoutFlyweight.AddChild(element);
        //}

        //Console.WriteLine("\nWithout flyweight");
        //Console.WriteLine(rootWithoutFlyweight.OuterHTML);

        //long memoryUsedWithoutFlyweight = GC.GetTotalMemory(true);
        //Console.WriteLine($"\nMemory used without flyweight: {memoryUsedWithoutFlyweight / 1024.0:F2} KB");
    }
}
