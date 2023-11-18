using MediatR;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Application.Commands.SetInternshipStatus;

public sealed record SetInternshipStatusCommand(
    Guid InternshipId,
    bool Passed
    ) : IRequest<Domain.Entities.Internship?>
{ }