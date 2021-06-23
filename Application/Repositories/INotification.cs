using FluentValidation.Results;
using System.Collections.Generic;
using Domain = Domain.Commons;

namespace Application.Repositories
{
    public interface INotifications
    {
        List<Domain::Notification> Notifications { get; set; }

        bool HasNotifications { get; }

        void AddNotification(string key, string message);

        void AddNotifications(ValidationResult validationResult);
    }
}
