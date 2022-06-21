using Microsoft.AspNetCore.Mvc;

namespace AppRender.Controllers;

[ApiController]
[Route("[controller]")]
public class RenderFileController : ControllerBase
{
    public IActionResult Get() {
        var content = System.IO.File.ReadAllText("/assets/html/app.html");
        return Content(content);
    }
}
