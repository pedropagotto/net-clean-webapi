using Application.Repositories;
using FluentValidation.Results;
using System.Collections.Generic;
using System.Linq;
using Domain = Domain.Commons;

namespace Api.Modules.Notifications
{
    public class NotificationContext : INotifications
    {
        public NotificationContext()
        {
            Notifications = new List<Domain::Notification>();
        }

        public List<Domain::Notification> Notifications { get; set; }

        public bool HasNotifications => Notifications.Any();

        public void AddNotification(string key, string message)
            => Notifications.Add(new Domain::Notification(key, message));

        public void AddNotifications(ValidationResult validationResult)
            => validationResult.Errors.ToList().ForEach(error => AddNotification(error.ErrorCode, error.ErrorMessage));
    }
}
