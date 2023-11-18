using MediatR;
using Microsoft.EntityFrameworkCore;
using Silevis_PSK_23_FoodLoversReborn_Backend.Infrastructure.DataAccess;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Application.Commands.SetInternshipStatus;

public class SetInternshipStatusCommandHandler : IRequestHandler<SetInternshipStatusCommand, Domain.Entities.Internship?>
{
    private readonly ApplicationDbContext _dbContext;

    public SetInternshipStatusCommandHandler(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<Domain.Entities.Internship?> Handle(SetInternshipStatusCommand request, CancellationToken cancellationToken)
    {
        var internship = await _dbContext.Internships
            .FirstOrDefaultAsync(x => x.Id.Equals(request.InternshipId), cancellationToken: cancellationToken);

        if (internship is null)
        {
            return null;
        }
        
        internship.SetPassed(request.Passed);

        await _dbContext.SaveChangesAsync(cancellationToken);

        return internship;
    }
}