namespace Pre.DesignPatters.Introduction.Core.Equals;

public class Person
{
    public override bool Equals(object? obj)
    {
        return obj is Person other && FirstName == other.FirstName && LastName == other.LastName;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(FirstName, LastName);
    }

    public string FirstName { get; }
    public string LastName { get; }

    public Person(string firstname, string lastname)
    {
        this.FirstName = firstname;
        this.LastName = lastname;
    }
}