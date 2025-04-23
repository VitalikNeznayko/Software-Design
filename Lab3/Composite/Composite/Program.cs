using ClassLibrary;
public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        var div = new LightElementNode("div", DisplayType.Block, TagType.Pair);
        div.AddClass("container");

        var p = new LightElementNode("p", DisplayType.Block, TagType.Pair);
        p.AddChild(new LightTextNode("Hello, World!"));
        div.AddChild(p);

        var button = new LightElementNode("button", DisplayType.Inline, TagType.Pair);
        button.AddChild(new LightTextNode("Click me"));
        div.AddChild(button);

        button.AddEventListener("click", () =>
            Console.WriteLine("<button> was clicked!")
        );
        button.AddEventListener("click", () =>
            Console.WriteLine("Another click handler triggered!")
        );
        button.AddEventListener("mouseover", () =>
            Console.WriteLine("Mouse hovered over the button!")
        );

        p.AddEventListener("click", () =>
            Console.WriteLine("<p> was clicked!")
        );

        Console.WriteLine(div.OuterHTML);
        Console.WriteLine();

        button.TriggerEvent("click");
        Console.WriteLine();

        button.TriggerEvent("mouseover");
        Console.WriteLine();

        p.TriggerEvent("click");
        Console.WriteLine();
        p.TriggerEvent("mouseover");
    }
}
