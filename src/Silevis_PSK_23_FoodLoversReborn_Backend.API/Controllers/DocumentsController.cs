using MediatR;
using Microsoft.AspNetCore.Mvc;
using Silevis_PSK_23_FoodLoversReborn_Backend.Application.Commands.StudentDocument.UploadDocument;
using Silevis_PSK_23_FoodLoversReborn_Backend.Application.Queries;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DocumentsController : ControllerBase
{
    private readonly IMediator _mediator;
    
    public DocumentsController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpPost("Upload")]
    public async Task<IActionResult> Upload([FromBody] UploadDocumentCommand request)
    {
        var studentDocument = await _mediator.Send(request);
        
        return CreatedAtAction(nameof(Upload), new { id = studentDocument.Id },
            studentDocument);
    }
    
    [HttpGet("GetStatus")]
    public async Task<ICollection<int>> GetStatus([FromQuery] int studentId)
    {
        return await _mediator.Send(new GetDocumentStatusQuery(studentId));
    }
    
}