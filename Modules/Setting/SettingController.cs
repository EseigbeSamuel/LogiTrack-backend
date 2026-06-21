using Microsoft.AspNetCore.Mvc;

namespace logitrack_api.Modules.Setting;

[ApiController]
[Route("api/[controller]")]
public class SettingController : ControllerBase
{
    private readonly ISettingService _settingService;

    public SettingController(ISettingService settingService)
    {
        _settingService = settingService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }
}
