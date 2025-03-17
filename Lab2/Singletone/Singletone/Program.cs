using System;

public sealed class Authenticator
{
    private static Authenticator _instance;
    private static readonly object _lock = new object();
    private Authenticator() { }

    public static Authenticator GetInstance()
    {
        if (_instance == null)
        {
            lock (_lock)
            {
                _instance ??= new Authenticator();
            }
        }
        return _instance;
    }

    public void Authenticate(string username)
    {
        Console.WriteLine($"Аутентифікація користувача: {username} (Thread ID: {Thread.CurrentThread.ManagedThreadId})");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        var task1 = System.Threading.Tasks.Task.Run(() =>
        {
            var auth1 = Authenticator.GetInstance();
            auth1.Authenticate("Tinko");
        });

        var task2 = System.Threading.Tasks.Task.Run(() =>
        {
            var auth2 = Authenticator.GetInstance();
            auth2.Authenticate("Marimo");
        });

        System.Threading.Tasks.Task.WhenAll(task1, task2).Wait();

        var auth3 = Authenticator.GetInstance();
        auth3.Authenticate("Just_Scorp");
    }
}
