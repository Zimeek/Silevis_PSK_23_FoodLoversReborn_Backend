namespace Silevis_PSK_23_FoodLoversReborn_Backend.API.DTOs;

public record InternshipDto
{
    public Guid Id { get; init; }
    public int StudentId { get; init; }
    public Guid InternshipOfferId { get; init; }
    public bool? Passed { get; init; }
}