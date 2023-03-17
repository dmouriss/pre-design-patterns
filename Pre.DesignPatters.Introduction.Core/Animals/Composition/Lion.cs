namespace Pre.DesignPatters.Introduction.Core.Animals.Composition;

public class Lion
{
    private readonly Animal _animal = new Animal();
    public string JungleName { get; set; }

    public string Color
    {
        get => _animal.Color;

        set => _animal.Color = value;
    }

    public void Eat()
    {
        _animal.Eat();
        Console.WriteLine("The lion ate");
    }

    public void Roar()
    {
        Console.WriteLine("Roar!");
    }
}