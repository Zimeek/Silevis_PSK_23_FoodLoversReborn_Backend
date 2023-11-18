using MediatR;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Application.Commands.Internship;

public record AddInternshipCommand : IRequest<AddInternshipCommandResponse>
{
    public Guid StudentId { get; init; }
    public string CompanyName { get; init; }
    public string? CompanyAddress { get; init; }
    public string? CompanyPhone { get; init; }  
    public DateTime DateStart { get; init;}
    public DateTime DateEnd { get; init;}
    public int Month { get; init; }
}