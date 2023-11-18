using MediatR;
using Microsoft.EntityFrameworkCore;
using Silevis_PSK_23_FoodLoversReborn_Backend.Domain.Entities;
using Silevis_PSK_23_FoodLoversReborn_Backend.Infrastructure.DataAccess;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Application.Queries;

public sealed class GetDelayRequestsQueryHandler : IRequestHandler<GetDelayRequestsQuery, ICollection<InternshipDelayRequest>?>
{
    private readonly ApplicationDbContext _dbContext;

    public GetDelayRequestsQueryHandler(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<ICollection<InternshipDelayRequest>?> Handle(GetDelayRequestsQuery request, CancellationToken cancellationToken)
    {
        var delays = await _dbContext.InternshipDelayRequests
            .ToListAsync(cancellationToken);

        return delays;
    }
}