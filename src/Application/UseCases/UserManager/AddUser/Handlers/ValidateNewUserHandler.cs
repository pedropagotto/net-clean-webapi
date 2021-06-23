using Microsoft.Extensions.Logging;

namespace Application.UseCases.UserManager.AddUser.Handlers
{
    public class ValidateNewUserHandler : Handler<AddUserUcRequest>
    {
        private readonly ILogger<ValidateNewUserHandler> _log;
        public ValidateNewUserHandler(ILogger<ValidateNewUserHandler> log)
        {
            _log = log;
        }
        public override void ProcessRequest(AddUserUcRequest request)
        {
            _log.LogWarning("Call ValidateNewUserHandler ");
            Sucessor?.ProcessRequest(request);
        }
    }
}
