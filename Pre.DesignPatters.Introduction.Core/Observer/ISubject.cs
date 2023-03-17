namespace Pre.DesignPatters.Introduction.Core.Observer;

public interface ISubject
{
    void AddSubscriber(ISubscriber subscriber);
    void RemoveSubscriber(ISubscriber subscriber);
    void Notify();
    void Notify(Episode episode);
}