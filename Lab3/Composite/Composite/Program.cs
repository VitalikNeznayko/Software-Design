using ClassLibrary;

public class Program
{
    public static void Main()
    {
        try
        {
            var fileImage = new LightImageNode(
                "C:\\Image\\img.png",
                new FileSystemImageLoadingStrategy()
            );
            fileImage.AddClass("thumbnail");
            Console.WriteLine(fileImage.OuterHTML);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading file image: {ex.Message}");
        }

        Console.WriteLine();

        try
        {
            var imageNetwork1 = new LightImageNode( 
                "https://image.com/image.png",
                new NetworkImageLoadingStrategy()
            );
            imageNetwork1.AddClass("responsive");
            Console.WriteLine(imageNetwork1.OuterHTML);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading network image: {ex.Message}");
        }

        Console.WriteLine();

        var div = new LightElementNode("div", DisplayType.Block, TagType.Pair);
        div.AddClass("container");

        var imageNetwork2 = new LightImageNode( 
            "https://image.com/image.png",
            new NetworkImageLoadingStrategy()
        );
        imageNetwork2.AddClass("responsive");

        var textNode = new LightTextNode("Some text");

        div.AddChild(imageNetwork2);
        div.AddChild(textNode);

        Console.WriteLine(div.OuterHTML);
    }
}