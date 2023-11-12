using EasyLiTwo.Database.Domain.Notifications;
using EasyLiTwo.Database.Domain.Validations.Interfaces;
using System.Collections.Generic;

namespace EasyLiTwo.Interfaces
{
    public interface IAuditable : IValidate
    {
        IReadOnlyCollection<Notification> Notifications { get; }
        void PullNotification(Notification notification);
    }
}
