namespace DesignPatterns.Observer
{
    public interface IObservable
    {
        void AddObserver(IObserver observer);
        void DeleteObserver(IObserver observer);
        void NotifyObservers();

    }
}
