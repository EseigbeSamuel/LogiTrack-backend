using Microsoft.AspNetCore.Mvc;

namespace logitrack_api.Modules.Notification;

[ApiController]
[Route("api/[controller]")]
public class NotificationController : ControllerBase
{
    private readonly INotificationService _notificationService;

    public NotificationController(INotificationService notificationService)
    {
        _notificationService = notificationService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }
}
