using MediatR;
using Microsoft.AspNetCore.Mvc;
using Silevis_PSK_23_FoodLoversReborn_Backend.Application.Commands.StudentDocument.UploadDocument;

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
    public async Task<IActionResult> Upload([FromBody] UploadDocumentCommand request)
    {
        await _mediator.Send(request);
        
        //return CreatedAtAction(nameof(Upload), new { id = studentDocument.Id },
            //studentDocument);
            return Ok();
    }
    
    [HttpPost("Upload2")]
    public async Task<IActionResult> Upload2(IFormFile formFile)
    {
        //await _mediator.Send(request);
        using (MemoryStream ms = new MemoryStream())
        {
            formFile.OpenReadStream().CopyTo(ms);
            Console.WriteLine(ms.ToArray());
            await _mediator.Send(new UploadDocumentCommand(ms.ToArray(), 11, 11, 11));
        }
        
        
        
        
      
        
        //return CreatedAtAction(nameof(Upload), new { id = studentDocument.Id },
        //studentDocument);
        return Ok();
    }
    
    [HttpGet("GetStatus")]
    public async Task<IActionResult> GetStatus()
    {
        return Ok();
    }
    
}