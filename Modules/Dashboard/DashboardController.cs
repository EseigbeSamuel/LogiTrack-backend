using Microsoft.AspNetCore.Mvc;

namespace logitrack_api.Modules.Dashboard;

[ApiController]
[Route("api/[controller]")]
public class DashboardController : ControllerBase
{
    private readonly IDashboardService _dashboardService;

    public DashboardController(IDashboardService dashboardService)
    {
        _dashboardService = dashboardService;
    }

    [HttpGet("summary")]
    public IActionResult GetSummary()
    {
        return Ok();
    }
}
