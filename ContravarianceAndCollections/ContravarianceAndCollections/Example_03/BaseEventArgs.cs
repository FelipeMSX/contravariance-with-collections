namespace ContravarianceAndCollections.Example_03
{
    public abstract class BaseEventArgs<T>(T data) : IEventArgs<T> where T : class
    {
        public T Data { get; } = data;
        object IEventArgs.Data => Data;
        public DateTime CreatedAt { get; } = DateTime.Now;
    }
}
