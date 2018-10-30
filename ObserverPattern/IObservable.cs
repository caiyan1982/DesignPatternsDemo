namespace ObserverPattern
{
    public interface IObservable
    {
        void RegisterObserver(IObserver o);

        void RemoveObserver(IObserver o);

        void NotifyObserver();

        void NotifyObserver(object arg);
    }
}
