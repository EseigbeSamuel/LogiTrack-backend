namespace logitrack_api.Modules.Chat;

public interface IChatRepository
{
    Task<ChatMessage> SendMessageAsync(ChatMessage message);
    Task<IEnumerable<ChatMessage>> GetConversationAsync(Guid userId1, Guid userId2);
    Task<bool> MarkAsReadAsync(Guid messageId);
}
