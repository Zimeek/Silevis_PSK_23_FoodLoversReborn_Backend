using MediatR;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Application.Commands.Internship;

public record DeleteInternshipCommand : IRequest
{
    public Guid StudentId { get; init; }
}