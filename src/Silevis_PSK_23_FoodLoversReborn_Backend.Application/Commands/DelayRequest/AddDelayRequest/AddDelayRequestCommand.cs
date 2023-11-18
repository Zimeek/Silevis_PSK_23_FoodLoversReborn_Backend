using MediatR;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Application.Commands.DelayRequest;

public record AddDelayRequestCommand : IRequest<AddDelayRequestCommandResponse>
{
    public Guid Id { get; init; }
    public int StudentId { get; init; }
    public DateTime RequestedDateStart { get; init; }
    public DateTime RequestedDateEnd { get; init; }
    public bool? Approved { get; init; }
}