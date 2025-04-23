using ClassLibrary;
using System.IO;

public class Program
{
    public static void Main()
    {
        string allowedFile = "test.txt";
        string deniedFile = "secret.txt";

        File.WriteAllText(allowedFile, "Hello\nWorld!");
        File.WriteAllText(deniedFile, "Secret content");

        ITextReader reader = new SmartTextReader();

        ITextReader logger = new SmartTextChecker(reader);

        ITextReader locker = new SmartTextReaderLocker(logger, "secret");

        Console.WriteLine("Reading allowed file:");
        locker.ReadText(allowedFile);

        Console.WriteLine("\nReading denied file:");
        locker.ReadText(deniedFile);

        
    }
}
