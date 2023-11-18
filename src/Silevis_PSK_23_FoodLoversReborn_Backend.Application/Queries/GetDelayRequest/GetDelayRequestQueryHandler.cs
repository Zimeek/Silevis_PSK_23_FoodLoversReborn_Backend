using MediatR;
using Microsoft.EntityFrameworkCore;
using Silevis_PSK_23_FoodLoversReborn_Backend.Domain.Entities;
using Silevis_PSK_23_FoodLoversReborn_Backend.Infrastructure.DataAccess;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Application.Queries;

public sealed class GetDelayRequestQueryHandler : IRequestHandler<GetDelayRequestQuery, InternshipDelayRequest?>
{
    private readonly ApplicationDbContext _dbContext;

    public GetDelayRequestQueryHandler(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<InternshipDelayRequest?> Handle(GetDelayRequestQuery request, CancellationToken cancellationToken)
    {
        var delay = await _dbContext.InternshipDelayRequests
            .FirstOrDefaultAsync(x => x.Id.Equals(request.Id), cancellationToken);

        return delay;
    }
}