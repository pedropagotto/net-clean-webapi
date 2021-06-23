using Application.Boundaries;
using Application.Repositories;
using System;
using System.Linq;

namespace Application.UseCases.UserManager.GetUsers
{
    public class GetUsersUseCase : IGetUsersUseCase
    {
        private readonly IOutputPort<GetUsersUcResponse> outputPort;
        private readonly INotifications notifications;

        public GetUsersUseCase(IOutputPort<GetUsersUcResponse> outputPort, INotifications notifications)
        {
            this.outputPort = outputPort;
            this.notifications = notifications;
        }
        public void Execute(GetUsersUcRequest request)
        {
            try
            {
                //Write your logic and implement your handlers
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

        private void BuildOutput(GetUsersUcRequest request)
        {
            if (notifications.HasNotifications)
                outputPort.Error(notifications.Notifications.Select(x => x.Message).ToList());
            else
                outputPort.Standard(request.Response);
        }
    }
}
