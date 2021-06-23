using Application.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Api.Modules.Filters
{
    public class NotificationFilter : IAsyncResultFilter
    {
        private readonly INotifications _notifications;

        public NotificationFilter(INotifications notifications) =>
            _notifications = notifications;

        public async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            if (_notifications.HasNotifications)
            {
                context.HttpContext.Response.ContentType = "application/json";
                var obj = JsonConvert.SerializeObject(_notifications.Notifications);
                await context.HttpContext.Response.WriteAsync(obj);

                return;
            }

            await next();
        }
    }
}
