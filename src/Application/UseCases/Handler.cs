namespace Application.UseCases
{
    public abstract class Handler<T> where T : class
    {
        public Handler<T> Sucessor { get; private set; }

        public Handler<T> SetSucessor(Handler<T> sucessor) =>
            this.Sucessor = sucessor;

        public abstract void ProcessRequest(T request);
    }
}
