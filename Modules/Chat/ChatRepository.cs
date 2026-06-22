namespace logitrack_api.Modules.Chat;

public class ChatRepository : IChatRepository
{
    public Task<ChatMessage> SendMessageAsync(ChatMessage message)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ChatMessage>> GetConversationAsync(Guid userId1, Guid userId2)
    {
        throw new NotImplementedException();
    }

    public Task<bool> MarkAsReadAsync(Guid messageId)
    {
        throw new NotImplementedException();
    }
}
