using System.Threading.Tasks;
using Valhalla.Application.Abstractions;
using Valhalla.Application.Notifications;

namespace Valhalla.Infrastructure.Services.Notifications
{
    public class NotificationService : INotificationService
    {
        public Task SendAsync(Message message)
        {
            //to-do: Implement send message here
            return Task.CompletedTask;
        }
    }
}
