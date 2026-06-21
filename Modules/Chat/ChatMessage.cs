namespace logitrack_api.Modules.Chat;

public class ChatMessage
{
    public Guid Id { get; set; }
    public string? SenderId { get; set; }
    public string? ReceiverId { get; set; }
    public string? Message { get; set; }
    public bool IsRead { get; set; }
    public DateTime? CreatedAt { get; set; }
}
