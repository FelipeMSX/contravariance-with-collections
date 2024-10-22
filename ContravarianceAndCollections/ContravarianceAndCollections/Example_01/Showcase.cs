using ContravarianceAndCollections.Example_01.Args;

namespace ContravarianceAndCollections.Example_01
{
    public class Showcase
    {
        public void Create()
        {
            IEnumerable<IEventArgs<object>> argsList = new List<IEventArgs<object>>
            {
                (IEventArgs<object>)new StringArgs("Felipe"),
                (IEventArgs<object>)new VoidArgs(),
                new ObjectArgs(new SampleObject(){ Name = "Example_01"})
            };
        }
    }
}
