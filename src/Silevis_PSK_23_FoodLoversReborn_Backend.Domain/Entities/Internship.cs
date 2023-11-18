using Silevis_PSK_23_FoodLoversReborn_Backend.Domain.Base;
using Silevis_PSK_23_FoodLoversReborn_Backend.Domain.ValueObjects;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Domain.Entities;

public class Internship : BaseEntity
{
    public Guid StudentId { get; init; }
    public bool? Passed { get; private set; }
    public InternshipDetails? InternshipDetails { get; private set; }

    public Internship(
        Guid studentId)
    {
        StudentId = studentId;
    }

    public void SetPassed(bool passed)
    {
        Passed = passed;
    }

    public void SetDetails(
        string companyName,
        string? companyAddress,
        string? companyPhone,
        DateTime dateStart,
        DateTime dateEnd,
        int month
    )
    {
        InternshipDetails = new InternshipDetails(
            companyName,
            companyAddress,
            companyPhone,
            dateStart,
            dateEnd,
            month
        );
    }
    
}