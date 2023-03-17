namespace Pre.DesignPatters.Introduction.Core.Animals.Inheritance;

public class Lion : Animal
{
    public string JungleName { get; set; }

    public void Eat()
    {
        base.Eat();
        Console.WriteLine("The Lion ate");
    }

    public void Roar()
    {
        Console.WriteLine("Roar");
    }
}