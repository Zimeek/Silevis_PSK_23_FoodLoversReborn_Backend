using MediatR;
using Microsoft.EntityFrameworkCore;
using Silevis_PSK_23_FoodLoversReborn_Backend.Domain.Entities;
using Silevis_PSK_23_FoodLoversReborn_Backend.Infrastructure.DataAccess;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Application.Queries;

public sealed class GetDocumentStatusQueryHandler: IRequestHandler<GetDocumentStatusQuery, ICollection<int>>
{
    private readonly ApplicationDbContext _dbContext;

    public GetDocumentStatusQueryHandler(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<ICollection<int>> Handle(GetDocumentStatusQuery request, CancellationToken cancellationToken)
    {
        var documentIndexes = await _dbContext.StudentDocuments
            .Where(doc => doc.StudentId == request.StudentId)
            .Select(doc => doc.DocumentId)
            .ToListAsync(cancellationToken);

        return documentIndexes;
    }
    
}