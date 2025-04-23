using ClassLibrary;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        var editor = new TextEditor();
        editor.Start();

    }
}
