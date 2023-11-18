using MediatR;
using Silevis_PSK_23_FoodLoversReborn_Backend.Domain.Entities;
using Silevis_PSK_23_FoodLoversReborn_Backend.Infrastructure.DataAccess;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Application.Commands.DelayRequest;

public class HandleDelayRequestCommandHandler : IRequestHandler<HandleDelayRequestCommand>
{
    private readonly ApplicationDbContext _dbContext;

    public HandleDelayRequestCommandHandler(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task Handle(HandleDelayRequestCommand request, CancellationToken cancellationToken)
    {
        InternshipDelayRequest? delayRequest = await _dbContext.InternshipDelayRequests.FindAsync(request.Id);
        if(delayRequest is null) //Add error handling
            return;
        delayRequest.Approved = request.Approved;
        
        await _dbContext.SaveChangesAsync(cancellationToken);

        return;


    }
}