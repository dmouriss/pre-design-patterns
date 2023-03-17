namespace Pre.DesignPatters.Introduction.Core.Nullable;

public class App
{
    private int number;
    private int? number2;

    public void ReadNumbers()
    {
        Console.WriteLine(number == 0);
        Console.WriteLine(number2 == null);
    }

    public void WriteContent(Info? info)
    {
        Console.WriteLine(info.Content);
    }

    public void NullableTypes()
    {
        Info? a = null;
        Info? b = new Info();
        Info? c = new Info("test");
        
        WriteContent(a);
    }
    
    
}