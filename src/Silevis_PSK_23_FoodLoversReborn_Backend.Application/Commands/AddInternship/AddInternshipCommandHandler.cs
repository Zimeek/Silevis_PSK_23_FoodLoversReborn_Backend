using MediatR;
using Microsoft.EntityFrameworkCore;
using Silevis_PSK_23_FoodLoversReborn_Backend.Infrastructure.DataAccess;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Application.Commands.Internship;

public sealed class AddInternshipCommandHandler : IRequestHandler<AddInternshipCommand, Guid>
{
    private readonly ApplicationDbContext _dbContext;

    public AddInternshipCommandHandler(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<Guid> Handle(AddInternshipCommand request, CancellationToken cancellationToken)
    {
        var internship = await _dbContext.Internships
            .FirstOrDefaultAsync(x => x.StudentId.Equals(request.StudentId), cancellationToken: cancellationToken);

        var alreadyExists = internship is not null;

        if (!alreadyExists)
        {
            internship = new Domain.Entities.Internship(request.StudentId);
        }
        
        internship.SetDetails(
            request.CompanyName,
            request.CompanyAddress,
            request.CompanyPhone,
            request.DateStart,
            request.DateEnd,
            request.Month
        );

        if (!alreadyExists)
        {
            await _dbContext.AddAsync(internship, cancellationToken);
        }
        else
        {
            _dbContext.Update(internship);
        }

        await _dbContext.SaveChangesAsync(cancellationToken);
        
        return internship.Id;
    }
}