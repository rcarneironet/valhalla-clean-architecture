using Microsoft.Extensions.DependencyInjection;
using Valhalla.Application.Abstractions;
using Valhalla.Application.Repositories;
using Valhalla.Infrastructure.DataAccess.Dapper.Repositories;
using Valhalla.Infrastructure.Services.Notifications;

namespace Valhalla.Infrastructure.IoC
{
    public static class Bootstrapper
    {
        public static void RegisterRepositoryServices(this IServiceCollection services)
        {
            services.AddTransient<INotificationService, NotificationService>();
            services.AddScoped<ICourseReadOnlyRepository, CourseReadOnlyRepository>();
        }
    }
}
