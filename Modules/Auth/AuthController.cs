using Microsoft.AspNetCore.Mvc;

namespace logitrack_api.Modules.Auth;

[ApiController]
[Route("api/[controller]")]
public class AuthControllerController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }
}
