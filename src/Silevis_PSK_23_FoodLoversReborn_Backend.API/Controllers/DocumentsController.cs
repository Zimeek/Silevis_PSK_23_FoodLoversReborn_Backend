using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DocumentsController : ControllerBase
{
    private readonly IConfiguration _configuration;
    private readonly IMediator _mediator;
    
    public DocumentsController(IConfiguration configuration, IMediator mediator)
    {
        _configuration = configuration;
        _mediator = mediator;
    }
    
    [HttpPost("Upload")]
    public async Task<IActionResult> Upload()
    {
        return Ok();
    }
    
    [HttpGet("GetStatus")]
    public async Task<IActionResult> GetStatus()
    {
        return Ok();
    }
    
}