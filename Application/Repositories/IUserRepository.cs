using Domain.Entities;

namespace Application.Repositories
{
    public interface IUserRepository
    {
        int Add(User domain);
    }
}
