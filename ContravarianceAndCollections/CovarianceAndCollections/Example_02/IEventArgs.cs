using System;

namespace ContravarianceAndCollections.Example_02
{
    public interface IEventArgs<out T> 
    {
        T Data { get; }

        DateTime CreatedAt { get; }
    }
}
