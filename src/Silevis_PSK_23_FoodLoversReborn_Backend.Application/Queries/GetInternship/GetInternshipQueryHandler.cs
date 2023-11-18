using MediatR;
using Microsoft.EntityFrameworkCore;
using Silevis_PSK_23_FoodLoversReborn_Backend.Infrastructure.DataAccess;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Application.Queries;

public sealed class GetInternshipQueryHandler : IRequestHandler<GetInternshipQuery, GetInternshipQueryResponse>
{
    private readonly ApplicationDbContext _dbContext;

    public GetInternshipQueryHandler(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<GetInternshipQueryResponse>? Handle(GetInternshipQuery request, CancellationToken cancellationToken)
    {
        var internship = await _dbContext.Internships
            .FirstOrDefaultAsync(x => x.Id.Equals(request.Id), cancellationToken);

        return internship is not null ? new GetInternshipQueryResponse(internship) : null;
    }
}