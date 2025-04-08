using ClassLibrary;

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        string logFilePath = "log.txt";
        FileLoggerAdapter fileLogger = new FileLoggerAdapter(logFilePath);

        fileLogger.Log("Логування");
        fileLogger.Error("Помилка");
        fileLogger.Warn("Попередження");

        Console.WriteLine($"\nЛоги були записані у файл '{logFilePath}'");
    }
}