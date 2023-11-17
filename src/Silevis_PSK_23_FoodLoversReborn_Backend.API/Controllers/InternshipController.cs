﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using Silevis_PSK_23_FoodLoversReborn_Backend.API.HttpRequests;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class InternshipController : ControllerBase
{
    private readonly IConfiguration _configuration;
    private readonly IMediator _mediator;
    
    public InternshipController(IConfiguration configuration, IMediator mediator)
    {
        _configuration = configuration;
        _mediator = mediator;
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        return null;
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById([FromQuery(Name = "id")] Guid id)
    {
        Console.WriteLine(id);
        return Ok();
    }
    
    [HttpPost("Add")]
    public async Task<IActionResult> Add([FromBody] InternshipAddHttpRequest request)
    {
        return null;
    }
    
    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete([FromQuery(Name = "id")] Guid id)
    {
        return null;
    }
    
    
    
    
    
    
}