namespace logitrack_api.Modules.Notification;

public class NotificationService : INotificationService
{
    private readonly INotificationRepository _notificationRepository;

    public NotificationService(INotificationRepository notificationRepository)
    {
        _notificationRepository = notificationRepository;
    }

    public Task<NotificationDto> SendNotificationAsync(string userId, string title, string message, string type)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<NotificationDto>> GetUserNotificationsAsync(string userId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> MarkAsReadAsync(Guid notificationId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> MarkAllAsReadAsync(string userId)
    {
        throw new NotImplementedException();
    }
}
