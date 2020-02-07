using System.Threading.Tasks;
using Valhalla.Application.Notifications;

namespace Valhalla.Application.Abstractions
{
    public interface INotificationService
    {
        Task SendAsync(Message message);
    }
}
