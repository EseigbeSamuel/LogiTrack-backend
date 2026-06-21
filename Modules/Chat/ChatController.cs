using Microsoft.AspNetCore.Mvc;

namespace logitrack_api.Modules.Chat;

[ApiController]
[Route("api/[controller]")]
public class ChatController : ControllerBase
{
    private readonly IChatService _chatService;

    public ChatController(IChatService chatService)
    {
        _chatService = chatService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }
}
