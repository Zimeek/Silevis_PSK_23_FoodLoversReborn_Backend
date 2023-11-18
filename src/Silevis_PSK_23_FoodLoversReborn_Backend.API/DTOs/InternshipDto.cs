namespace Silevis_PSK_23_FoodLoversReborn_Backend.API.DTOs;

public record InternshipDto
{
    public Guid Id { get; init; }
    public Guid StudentId { get; init; }
    public bool? Passed { get; init; }
}