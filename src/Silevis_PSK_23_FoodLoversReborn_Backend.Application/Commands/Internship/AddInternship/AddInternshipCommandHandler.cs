using MediatR;
using Silevis_PSK_23_FoodLoversReborn_Backend.Infrastructure.DataAccess;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Application.Commands.Internship;

public sealed class AddInternshipCommandHandler : IRequestHandler<AddInternshipCommand, AddInternshipCommandResponse>
{
    private readonly ApplicationDbContext _dbContext;

    public AddInternshipCommandHandler(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<AddInternshipCommandResponse> Handle(AddInternshipCommand request, CancellationToken cancellationToken)
    {
        var internship = new Domain.Entities.Internship(request.StudentId);
        internship.SetDetails(
            request.CompanyName,
            request.CompanyAddress,
            request.CompanyPhone,
            request.DateStart,
            request.DateEnd,
            request.Month
        );
        
        await _dbContext.AddAsync(internship, cancellationToken);
        await _dbContext.SaveChangesAsync(cancellationToken);
        
        return new AddInternshipCommandResponse(internship.Id);
    }
}