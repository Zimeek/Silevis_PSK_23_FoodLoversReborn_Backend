using MediatR;
using Microsoft.AspNetCore.Mvc;
using Silevis_PSK_23_FoodLoversReborn_Backend.Application.Commands.DelayRequest;
using Silevis_PSK_23_FoodLoversReborn_Backend.Application.Queries;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DelayRequestController : ControllerBase
{
    private readonly IMediator _mediator;
    
    public DelayRequestController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpPost("Add")]
    public async Task<AddDelayRequestCommandResponse> Add([FromBody] AddDelayRequestCommand request)
    {
        return await _mediator.Send(request);
    }
    
    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _mediator.Send(new GetDelayRequestsQuery()));
    }
    
    [HttpGet("GetById")]
    public async Task<IActionResult> GetById([FromQuery] Guid id)
    {
        var delayRequest = await _mediator.Send(new GetDelayRequestQuery(id));

        return delayRequest is not null ? Ok(delayRequest) : NotFound();
    }
    
    [HttpPost("Handle")]
    public async Task<IActionResult> Add([FromBody] HandleDelayRequestCommand request)
    {
        await _mediator.Send(request);
        return Ok();
    }
    
    
}