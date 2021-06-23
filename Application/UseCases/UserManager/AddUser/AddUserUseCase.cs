using Application.Boundaries;
using Application.Repositories;
using Application.UseCases.UserManager.AddUser.Handlers;
using System;
using System.Linq;

namespace Application.UseCases.UserManager.AddUser
{
    public class AddUserUseCase : IAddUserUseCase
    {
        private readonly IOutputPort<AddUserUcResponse> outputPort;
        private readonly INotifications notifications;
        private ValidateNewUserHandler _validateNewUserHandler;
        private CreateUserHandler _createUserHandler;
        private VerifyProfileHandler _verifyProfileHandler;

        public AddUserUseCase(IOutputPort<AddUserUcResponse> outputPort,
                              INotifications notifications,
                              ValidateNewUserHandler validateNewUserHandler,
                              CreateUserHandler createUserHandler,
                              VerifyProfileHandler verifyProfileHandler)
        {
            this.outputPort = outputPort;
            this.notifications = notifications;
            _validateNewUserHandler = validateNewUserHandler;
            _createUserHandler = createUserHandler;
            _verifyProfileHandler = verifyProfileHandler;


            validateNewUserHandler
                .SetSucessor(verifyProfileHandler)
                .SetSucessor(createUserHandler);
        }
        public void Execute(AddUserUcRequest request)
        {
            try
            {
                _validateNewUserHandler.ProcessRequest(request);
            }
            catch (Exception ex)
            {
                var message = $"Occurring an error to get segments exempt list. Error: {ex.InnerException?.Message ?? ex.Message}, stacktrace: {ex.StackTrace}";
                notifications.AddNotification(ex.Message, ex.StackTrace);
            }
            finally
            {
                BuildOutput(request);
            }
        }

        private void BuildOutput(AddUserUcRequest request)
        {
            if (notifications.HasNotifications)
                outputPort.Error(notifications.Notifications.Select(x => x.Message).ToList());
            else
                outputPort.Standard(request.Response);
        }
    }
}
