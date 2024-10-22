namespace ContravarianceAndCollections.Example_03
{
    public interface IEventArgs<out T> : IEventArgs
    {
        new T Data { get; }
        DateTime CreatedAt { get; }
    }


    public interface IEventArgs
    {
        object Data { get; }
    }
}
