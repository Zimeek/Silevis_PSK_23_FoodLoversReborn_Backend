namespace Silevis_PSK_23_FoodLoversReborn_Backend.API.DTOs;

public record InternshipDelayRequestDto
{
    public Guid Id { get; init; }
    public int StudentId { get; init; }
    public Guid InternshipId { get; init; }
    public DateTime RequestedDateStart { get; init; }
    public DateTime RequestedDateEnd { get; init; }
}