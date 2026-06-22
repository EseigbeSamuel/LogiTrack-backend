namespace logitrack_api.Modules.Notification;

public class NotificationRepository : INotificationRepository
{
    public Task<Notification> SendNotificationAsync(Notification notification)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Notification>> GetUserNotificationsAsync(Guid userId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> MarkAsReadAsync(Guid notificationId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> MarkAllAsReadAsync(Guid userId)
    {
        throw new NotImplementedException();
    }
}
