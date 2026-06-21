using Microsoft.AspNetCore.Mvc;

namespace logitrack_api.Modules.Scheduler;

[ApiController]
[Route("api/[controller]")]
public class SchedulerController : ControllerBase
{
    private readonly ISchedulerService _schedulerService;

    public SchedulerController(ISchedulerService schedulerService)
    {
        _schedulerService = schedulerService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }
}
