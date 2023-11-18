using MediatR;
using Microsoft.EntityFrameworkCore;
using Silevis_PSK_23_FoodLoversReborn_Backend.Infrastructure.DataAccess;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Application.Queries.GetInternships;

public sealed class GetInternshipsQueryHandler : IRequestHandler<GetInternshipsQuery, GetInternshipsQueryResponse>
{
    private readonly ApplicationDbContext _dbContext;

    public GetInternshipsQueryHandler(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<GetInternshipsQueryResponse> Handle(GetInternshipsQuery request, CancellationToken cancellationToken)
    {
        var internships = await _dbContext.Internships
            .ToListAsync(cancellationToken);

        return new GetInternshipsQueryResponse(internships);
    }
}