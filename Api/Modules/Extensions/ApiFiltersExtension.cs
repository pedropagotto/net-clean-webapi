using Api.Modules.Notifications;
using Application.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Api.Modules.Extensions
{
    public static class ApiFiltersExtension
    {
        public static void ConfigureApiFilters(this IServiceCollection services)
        {
            services.AddScoped<INotifications, NotificationContext>();
        }
    }
}
