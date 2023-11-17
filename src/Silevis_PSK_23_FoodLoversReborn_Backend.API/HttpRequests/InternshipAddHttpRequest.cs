using System.ComponentModel.DataAnnotations;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.API.HttpRequests;

public record InternshipAddHttpRequest
{
    [Required]
    public string CompanyName { get; init; }
    public string? CompanyAddress { get; init; }
    public int? CompanyPhone { get; init; }  
    [Required]
    public DateTime DateStart { get; init;}
    [Required]
    public DateTime DateEnd { get; init;}
    [Required]
    public int Month { get; init; }
}