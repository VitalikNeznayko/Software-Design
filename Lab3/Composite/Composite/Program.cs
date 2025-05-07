using ClassLibrary;
using ClassLibrary.Iterator;
using ClassLibrary.Command;
using ClassLibrary.State;
public class Program
{
    public static void Iterator(LightElementNode div, IIterator iterator)
    {   
        while (iterator.HasNext())
        {
            LightNode node = iterator.Next();
            Console.WriteLine(node.OuterHTML);
        }
    }
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        var div = new LightElementNode("div", DisplayType.Block, TagType.Pair);
        var h1 = new LightElementNode("h1", DisplayType.Block, TagType.Pair);
        var p = new LightElementNode("p", DisplayType.Block, TagType.Pair);
        
        CommandInvoker invoker = new CommandInvoker();

        var addChildCommand = new AddChildCommand(div, h1);
        var addChildCommand1 = new AddChildCommand(div, p);
        var addTextCommand = new AddChildCommand(p, new LightTextNode("Текст"));
        var addTextCommand1 = new AddChildCommand(h1, new LightTextNode("Назва"));
        var addClassCommand = new AddClassCommand(div, "container");

        invoker.ExecuteCommand(addChildCommand);
        invoker.ExecuteCommand(addChildCommand1);
        invoker.ExecuteCommand(addTextCommand);
        invoker.ExecuteCommand(addTextCommand1);
        invoker.ExecuteCommand(addClassCommand);

        Console.WriteLine(div.OuterHTML);

        Console.WriteLine();
        div.Render();
        div.SetState(new HiddenState());
        div.Render();
        div.SetState(new DisabledState());
        div.Render();

        invoker.UndoLastCommand();
        Console.WriteLine("\nВидалимо останню команду:");
        Console.WriteLine(div.OuterHTML);

        Console.WriteLine("\nІтератор для обоходу в глибину");
        Iterator(div, new DepthIterator(div));
        Console.WriteLine("\nІтератор для обоходу в ширину");
        Iterator(div, new BreadthIterator(div));


    }
}
