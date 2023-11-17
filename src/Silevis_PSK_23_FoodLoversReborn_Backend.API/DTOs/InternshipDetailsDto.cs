namespace Silevis_PSK_23_FoodLoversReborn_Backend.API.DTOs;

public record InternshipDetailsDto
{
    public Guid Id { get; init; }
    public string CompanyName { get; init; }
    public string? CompanyAddress { get; init; }
    public int? CompanyPhone { get; init; }  
    public DateTime DateStart { get; init;}
    public DateTime DateEnd { get; init;}
    public int Month { get; init; }
}