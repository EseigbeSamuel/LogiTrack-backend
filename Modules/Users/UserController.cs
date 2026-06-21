using Microsoft.AspNetCore.Mvc;

namespace logitrack_api.Modules.Users;

[ApiController]
[Route("api/[controller]")]
public class UserControllerController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }
}
