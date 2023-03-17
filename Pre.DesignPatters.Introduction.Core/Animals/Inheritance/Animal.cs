namespace Pre.DesignPatters.Introduction.Core.Animals.Inheritance;

public class Animal
{
    public string Color { get; set; }

    public void Eat()
    {
        Console.WriteLine("processing food");
    }
}