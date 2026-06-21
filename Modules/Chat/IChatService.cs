namespace logitrack_api.Modules.Chat;

public interface IChatService
{
    Task<ChatMessageDto> SendMessageAsync(string senderId, string receiverId, string message);
    Task<IEnumerable<ChatMessageDto>> GetConversationAsync(string userId1, string userId2);
    Task<bool> MarkAsReadAsync(Guid messageId);
}
