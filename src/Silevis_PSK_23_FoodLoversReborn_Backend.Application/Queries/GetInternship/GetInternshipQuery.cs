using MediatR;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Application.Queries;

public sealed record GetInternshipQuery(
    Guid Id
    ) : IRequest<GetInternshipQueryResponse>
{ }