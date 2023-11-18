using MediatR;
using Silevis_PSK_23_FoodLoversReborn_Backend.Infrastructure.DataAccess;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Application.Commands.Internship;

public class DeleteInternshipCommandHandler : IRequestHandler<DeleteInternshipCommand>
{
    private readonly ApplicationDbContext _dbContext;

    public DeleteInternshipCommandHandler(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task Handle(DeleteInternshipCommand request, CancellationToken cancellationToken)
    {
        Domain.Entities.Internship? internship =  await _dbContext.Internships.FindAsync(request.StudentId);
        if (internship is null)
            return; // Add error handling 
        _dbContext.Internships.Remove(internship);
        await _dbContext.SaveChangesAsync(cancellationToken);
        return;
    }
}