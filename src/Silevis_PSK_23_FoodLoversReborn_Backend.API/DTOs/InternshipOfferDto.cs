using Silevis_PSK_23_FoodLoversReborn_Backend.Application.DataEnums;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.API.DTOs;

public record InternshipOfferDto
{
    public Guid Id { get; init; }
    public ProgrammeTypeEnum ProgrammeTypeEnum { get; init; }
    public string CompanyName { get; init; }
    public string Address { get; init; }
    public string Title { get; init; }
    public DateTime CreationDate { get; init;}
    public DateTime DateStart { get; init;}
    public DateTime DateEnd { get; init;}
    public TimeOnly ShiftStart { get; init;}
    public TimeOnly ShiftEnd { get; init;}
    public int AvailableSlots { get; init;}
    public int TotalSlots { get; init; }
    public bool HasSlots => (AvailableSlots > TotalSlots);
}


