namespace Pre.DesignPatters.Introduction.Core.Singleton;

public class Counter
{
    public static Counter Instance { get; } = new Counter();

    private Counter()
    {
        
    }

    private int _value = 0;

    public int Value
    {
        get
        {
            _value++;
            return _value;
        }
    }
}