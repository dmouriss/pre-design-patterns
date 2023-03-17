using System.Data;

namespace Pre.DesignPatters.Introduction.Core.Observer;

public interface ISubscriber
{
    void Update(ISubject subject, Episode episode);
}