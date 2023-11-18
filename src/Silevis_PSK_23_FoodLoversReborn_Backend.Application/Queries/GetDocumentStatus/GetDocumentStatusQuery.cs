using MediatR;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Application.Queries;

public sealed record GetDocumentStatusQuery (int StudentId): IRequest<ICollection<int>>
{
}