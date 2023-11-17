using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DelayRequestController : ControllerBase
{
    private readonly IConfiguration _configuration;
    private readonly IMediator _mediator;
    
    public DelayRequestController(IConfiguration configuration, IMediator mediator)
    {
        _configuration = configuration;
        _mediator = mediator;
    }
    
    [HttpPost("Add")]
    public async Task<bool> Add([FromQuery(Name = "id")] Guid id)
    {
        return true;
    }
    
    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        return null;
    }
    [HttpGet("GetById")]
    public async Task<IActionResult> GetById([FromQuery(Name = "id")] Guid id)
    {
        return null;
    }
    
    [HttpPost("Handle")]
    public async Task<IActionResult> Add([FromQuery(Name = "id")] Guid id, [FromQuery(Name = "approved")] bool approved)
    {
        return null;
    }
    
    
}