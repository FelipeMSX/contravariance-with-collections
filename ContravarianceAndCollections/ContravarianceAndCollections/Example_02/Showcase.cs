using ContravarianceAndCollections.Example_02.Args;

namespace ContravarianceAndCollections.Example_02
{
    public class Showcase
    {
        public void Create()
        {
            IEnumerable<IEventArgs<object>> argsList = new List<IEventArgs<object>>
            {
                new StringArgs("Felipe"),
                new VoidArgs(),
                new ObjectArgs(new SampleObject(){ Name = "Example_02"})
            };

            //Impossible without covariance
            IEnumerable<IEventArgs<object>> t1 = new List<IEventArgs<string>>();
        }
    }
}
