namespace Pre.DesignPatters.Introduction.Core.Observer;

public class Person : ISubscriber
{
    
    public string Name { get; set; }

    private void SendMessage(Episode episode)
    {
        Console.WriteLine($"A new episode was added: {episode.Name}");    
    }
    
    public void Update(ISubject subject, Episode episode)
    {
        SendMessage(episode);
    }
}