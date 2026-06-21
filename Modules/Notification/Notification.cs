namespace logitrack_api.Modules.Notification;

public class Notification
{
    public Guid Id { get; set; }
    public string? UserId { get; set; }
    public string? Title { get; set; }
    public string? Message { get; set; }
    public string? Type { get; set; }
    public bool IsRead { get; set; }
    public DateTime? CreatedAt { get; set; }
}
