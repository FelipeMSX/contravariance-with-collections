using System;

namespace ContravarianceAndCollections.Example_02
{
    public class BaseEventArgs<T>(T data) : IEventArgs<T>
    {
        public T Data { get; } = data;

        public DateTime CreatedAt { get; } = DateTime.Now;
    }
}
