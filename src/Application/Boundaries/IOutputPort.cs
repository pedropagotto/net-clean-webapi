using System.Collections.Generic;

namespace Application.Boundaries
{
    public interface IOutputPort<T>
    {
        void Standard(T result);

        void Error(string message);

        void Error(List<string> messages);
    }
}
