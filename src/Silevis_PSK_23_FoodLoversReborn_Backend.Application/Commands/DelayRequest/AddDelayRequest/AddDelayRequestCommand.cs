using MediatR;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Application.Commands.DelayRequest;

public sealed record AddDelayRequestCommand(
    Guid Id,
    int StudentId,
    DateTime RequestedDateStart,
    DateTime RequestedDateEnd
    ) : IRequest<AddDelayRequestCommandResponse>
{ }