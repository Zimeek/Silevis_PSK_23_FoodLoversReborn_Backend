using MediatR;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Application.Commands.DelayRequest;

public record HandleDelayRequestCommand : IRequest
{
    public Guid Id { get; init; }
    public bool Approved { get; init; }
}