namespace Pre.DesignPatters.Introduction.Core.Animals.Composition;

public class Animal
{
    public string Color { get; set; }

    public void Eat()
    {
        Console.WriteLine("The animal is eating");
    }
}