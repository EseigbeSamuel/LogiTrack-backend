namespace logitrack_api.Modules.Chat;

public interface IChatRepository
{
    Task<ChatMessageDto> SendMessageAsync(string senderId, string receiverId, string message);
    Task<IEnumerable<ChatMessageDto>> GetConversationAsync(string userId1, string userId2);
    Task<bool> MarkAsReadAsync(Guid messageId);
}
