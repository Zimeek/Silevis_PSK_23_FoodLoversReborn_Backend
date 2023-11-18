using MediatR;
using Silevis_PSK_23_FoodLoversReborn_Backend.Infrastructure.DataAccess;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Application.Commands.DelayRequest;

public sealed class AddDelayRequestCommandHandler : IRequestHandler<AddDelayRequestCommand, AddDelayRequestCommandResponse>
{
    private readonly ApplicationDbContext _dbContext;

    public AddDelayRequestCommandHandler(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<AddDelayRequestCommandResponse> Handle(AddDelayRequestCommand request, CancellationToken cancellationToken)
    {
        var delayRequest = new Domain.Entities.InternshipDelayRequest(request.Id, request.StudentId,
            request.RequestedDateStart, request.RequestedDateEnd);

        await _dbContext.AddAsync(delayRequest, cancellationToken);
        await _dbContext.SaveChangesAsync(cancellationToken);

        return new AddDelayRequestCommandResponse(delayRequest.Id);


    }
}