namespace Pre.DesignPatters.Introduction.Core.Animals.Inheritance;

public class Dog : Animal
{
    public string Owner { get; set; }

    public void Eat()
    {
        base.Eat();
        Console.WriteLine("The dog ate");
    }

    public void Bark()
    {
        Console.WriteLine("Bark");
    }
}