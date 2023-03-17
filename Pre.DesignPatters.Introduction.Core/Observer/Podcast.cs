namespace Pre.DesignPatters.Introduction.Core.Observer;

public class Podcast : ISubject
{
    public string Title { get; }
    public ICollection<Episode> Episodes { get; }
    private ICollection<ISubscriber> _subscribers;

    public Podcast(string title)
    {
        Title = title;
        Episodes = new List<Episode>();
        _subscribers = new List<ISubscriber>();
    }

    public void AddSubscriber(ISubscriber subscriber)
    {
        _subscribers.Add(subscriber);
    }

    public void RemoveSubscriber(ISubscriber subscriber)
    {
        _subscribers.Remove(subscriber);
    }

    public void Notify()
    {
        Notify(null);
    }

    public void Notify(Episode episode)
    {
        foreach (ISubscriber subscriber in _subscribers)
        {
            subscriber.Update(this, episode);
        }
    }
}