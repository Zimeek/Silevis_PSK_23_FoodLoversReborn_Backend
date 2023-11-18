using MediatR;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Application.Commands.DelayRequest;

public sealed record HandleDelayRequestCommand(
    Guid Id,
    bool Approved
    ) : IRequest
{ }