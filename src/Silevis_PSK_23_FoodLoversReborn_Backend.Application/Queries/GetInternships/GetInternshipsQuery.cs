using MediatR;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Application.Queries.GetInternships;

public sealed record GetInternshipsQuery : IRequest<GetInternshipsQueryResponse>
{ }