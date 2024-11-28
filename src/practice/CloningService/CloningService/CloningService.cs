namespace CloningService
{
    public class CloningService : ICloningService
    {
        public T Clone<T>(T source)
        {
            //var type = source.GetType();
            T destination = source;
            return destination;
        }
        // Feel free to add any other methods, classes, etc.
    }
}
