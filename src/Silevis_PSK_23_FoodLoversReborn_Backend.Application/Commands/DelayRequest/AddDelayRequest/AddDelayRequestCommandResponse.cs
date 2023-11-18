namespace Silevis_PSK_23_FoodLoversReborn_Backend.Application.Commands.DelayRequest;

public class AddDelayRequestCommandResponse
{
    public AddDelayRequestCommandResponse(
        Guid delayRequestId)
    {
        DelayRequestId = delayRequestId;
    }
    
    public Guid DelayRequestId { get; init; }
}