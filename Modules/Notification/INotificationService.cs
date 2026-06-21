namespace logitrack_api.Modules.Notification;

public interface INotificationService
{
    Task<NotificationDto> SendNotificationAsync(string userId, string title, string message, string type);
    Task<IEnumerable<NotificationDto>> GetUserNotificationsAsync(string userId);
    Task<bool> MarkAsReadAsync(Guid notificationId);
    Task<bool> MarkAllAsReadAsync(string userId);
}
