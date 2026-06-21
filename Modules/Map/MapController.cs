using Microsoft.AspNetCore.Mvc;

namespace logitrack_api.Modules.Map;

[ApiController]
[Route("api/[controller]")]
public class MapController : ControllerBase
{
    private readonly IMapService _mapService;

    public MapController(IMapService mapService)
    {
        _mapService = mapService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }
}
