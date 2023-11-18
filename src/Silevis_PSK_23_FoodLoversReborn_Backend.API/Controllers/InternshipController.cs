using MediatR;
using Microsoft.AspNetCore.Mvc;
using Silevis_PSK_23_FoodLoversReborn_Backend.Application.Commands.Internship;
using Silevis_PSK_23_FoodLoversReborn_Backend.Application.Commands.SetInternshipStatus;
using Silevis_PSK_23_FoodLoversReborn_Backend.Application.Queries;
using Silevis_PSK_23_FoodLoversReborn_Backend.Application.Queries.GetInternships;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class InternshipController : ControllerBase
{
    private readonly IConfiguration _configuration;
    private readonly IMediator _mediator;
    
    public InternshipController(
        IConfiguration configuration, 
        IMediator mediator)
    {
        _configuration = configuration;
        _mediator = mediator;
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _mediator.Send(new GetInternshipsQuery()));
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById([FromQuery] Guid id)
    {
        var internship = await _mediator.Send(new GetInternshipQuery(id));

        return internship is not null ? Ok(internship) : NotFound();
    }
    
    [HttpGet("GetByStudentId")]
    public async Task<IActionResult> GetByStudentId([FromQuery] int id)
    {
        var internship = await _mediator.Send(new GetInternshipByStudentIdQuery(id));

        return internship is not null ? Ok(internship) : NotFound();
    }
    
    [HttpPost("Add")]
    public async Task<Guid> Add([FromBody] AddInternshipCommand request)
    {
        return await _mediator.Send(request);
    }
    
    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete([FromBody] DeleteInternshipCommand request)
    {
        await _mediator.Send(request);
        return Ok();
    }

    [HttpPut("SetStatus")]
    public async Task<IActionResult> SetStatus([FromBody] SetInternshipStatusCommand request)
    {
        var internship = await _mediator.Send(request);
        return internship is null ? NotFound() : Ok(internship);
    }
    
    
    
    
    
    
}