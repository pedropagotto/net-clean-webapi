namespace Application.UseCases
{
    public abstract class Decorator<T> where T : class
    {
        public T Operation(T request) => request;
    }
}
