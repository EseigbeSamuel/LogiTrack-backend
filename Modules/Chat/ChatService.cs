namespace logitrack_api.Modules.Chat;

public class ChatService : IChatService
{
    private readonly IChatRepository _chatRepository;

    public ChatService(IChatRepository chatRepository)
    {
        _chatRepository = chatRepository;
    }

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
