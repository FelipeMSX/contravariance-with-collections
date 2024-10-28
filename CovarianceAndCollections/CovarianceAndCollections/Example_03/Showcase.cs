using ContravarianceAndCollections.Example_03.Args;

namespace ContravarianceAndCollections.Example_03
{
    public class Showcase
    {
        public void Create()
        {
            IEnumerable<IEventArgs> argsList = new List<IEventArgs>
            {
                new StringArgs("Felipe"),
                new VoidArgs(),
                new ObjectArgs(new SampleObject(){ Name = "Example_03"})
            };

            //Still preserves the compatibility
            IEnumerable<IEventArgs> t1 = new List<IEventArgs<string>>();

            IEventArgs<object> stringArgs = new StringArgs("Felipe");
            IEventArgs<object> voidArgs = new VoidArgs();
            List<IEventArgs<object>> list  = new List<IEventArgs<object>>();

        }
    }
}
