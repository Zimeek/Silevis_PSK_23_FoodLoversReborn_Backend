using Silevis_PSK_23_FoodLoversReborn_Backend.Domain.Entities;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Application.Queries.GetInternships;

public sealed record GetInternshipsQueryResponse(
    ICollection<Internship> Internships
    )
{ }