using MediatR;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Application.Commands.Internship;

public sealed record AddInternshipCommand(
    int StudentId,
    string CompanyName,
    string? CompanyAddress,
    string? CompanyPhone,
    DateTime DateStart,
    DateTime DateEnd,
    int Month
    ) : IRequest<AddInternshipCommandResponse>
{ }