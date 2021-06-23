using Application.Repositories;
using Domain.Entities;

namespace Application.UseCases.UserManager.AddUser.Handlers
{
    public class CreateUserHandler : Handler<AddUserUcRequest>
    {
        private readonly IUserRepository _repository;
        public CreateUserHandler(IUserRepository repository)
        {
            _repository = repository;

        }
        public override void ProcessRequest(AddUserUcRequest request)
        {
            var domain = new User(request.UserName, request.Email, Domain.Enums.EProfile.User);
            var rows = _repository.Add(domain);


            Sucessor?.ProcessRequest(request);
        }
    }
}
