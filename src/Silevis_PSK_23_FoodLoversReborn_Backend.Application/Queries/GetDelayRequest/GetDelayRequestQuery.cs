using MediatR;
using Silevis_PSK_23_FoodLoversReborn_Backend.Domain.Entities;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Application.Queries;

public sealed record GetDelayRequestQuery(
    Guid Id
    ) : IRequest<InternshipDelayRequest>
{ }