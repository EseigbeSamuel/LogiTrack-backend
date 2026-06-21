namespace logitrack_api.Modules.Chat;

public class ChatRepository : IChatRepository
{
    public Task<ChatMessageDto> SendMessageAsync(string senderId, string receiverId, string message)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ChatMessageDto>> GetConversationAsync(string userId1, string userId2)
    {
        throw new NotImplementedException();
    }

    public Task<bool> MarkAsReadAsync(Guid messageId)
    {
        throw new NotImplementedException();
    }
}
