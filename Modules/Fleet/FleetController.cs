using Microsoft.AspNetCore.Mvc;

namespace logitrack_api.Modules.Fleet;

[ApiController]
[Route("api/[controller]")]
public class FleetController : ControllerBase
{
    private readonly IFleetService _fleetService;

    public FleetController(IFleetService fleetService)
    {
        _fleetService = fleetService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }
}
