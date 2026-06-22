namespace logitrack_api.Modules.Notification;

public interface INotificationRepository
{
    Task<Notification> SendNotificationAsync(Notification notification);
    Task<IEnumerable<Notification>> GetUserNotificationsAsync(Guid userId);
    Task<bool> MarkAsReadAsync(Guid notificationId);
    Task<bool> MarkAllAsReadAsync(Guid userId);
}
