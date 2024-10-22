using System;

namespace ContravarianceAndCollections.Example_01
{
    public interface IEventArgs<T>
    {
        T Data { get; }
        DateTime CreatedAt { get; }
    }
}
