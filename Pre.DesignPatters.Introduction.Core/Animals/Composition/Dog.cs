namespace Pre.DesignPatters.Introduction.Core.Animals.Composition;

public class Dog
{
    private readonly Animal _animal = new Animal();
    public string Owner { get; set; }

    public string Color
    {
        get => _animal.Color;
        set => _animal.Color = value;
    }

    public void Eat()
    {
        _animal.Eat();
        Console.WriteLine("The dog ate");
    }

    public void Bark()
    {
        Console.WriteLine("Bark!");
    }

    
}