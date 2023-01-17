using Microsoft.AspNetCore.Mvc;

namespace video_yt.Controllers;

[ApiController]
[Route("[controller]")]
public class VideoSearchController : ControllerBase
{
    private readonly ILogger<VideoSearchController> _logger;

    public VideoSearchController(ILogger<VideoSearchController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "Get")]
    public string Get()
    {
        return "ok";
    }
}
