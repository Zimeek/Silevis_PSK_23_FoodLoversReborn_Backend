using MediatR;
using Microsoft.EntityFrameworkCore;
using Silevis_PSK_23_FoodLoversReborn_Backend.Domain.Entities;
using Silevis_PSK_23_FoodLoversReborn_Backend.Infrastructure.DataAccess;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Application.Queries;

public sealed class GetInternshipByStudentIdQueryHandler : IRequestHandler<GetInternshipByStudentIdQuery, Internship>
{
    private readonly ApplicationDbContext _dbContext;

    public GetInternshipByStudentIdQueryHandler(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<Internship?> Handle(GetInternshipByStudentIdQuery request, CancellationToken cancellationToken)
    {
        var internship = await _dbContext.Internships
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id.Equals(request.Id), cancellationToken);

        return internship;
    }
}