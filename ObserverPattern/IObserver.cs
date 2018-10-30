using System;

namespace ObserverPattern
{
    public interface IObserver
    {
        void Update(IObservable obs, Object arg);
    }
}
