namespace Pre.DesignPatters.Introduction.Core.Singleton;

public class SystemLogger
{
    public static SystemLogger Instance { get; } = new SystemLogger();
    private SystemLogger()
    {
    }
    
    public void Log(string title, string message)
    {
        Console.WriteLine($"Write the following to file: {title} {message}");
    }
}