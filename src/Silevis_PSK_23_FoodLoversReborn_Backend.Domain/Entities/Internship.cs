using Silevis_PSK_23_FoodLoversReborn_Backend.Domain.Base;
using Silevis_PSK_23_FoodLoversReborn_Backend.Domain.ValueObjects;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Domain.Entities;

public class Internship : BaseEntity
{
    public int StudentId { get; init; }
    public int? Passed { get; private set; } = 0;
    public InternshipDetails? InternshipDetails { get; private set; }

    public Internship(
        int studentId)
    {
        StudentId = studentId;
    }

    public void SetPassed(bool passed)
    {
        Passed = passed ? 1 : 2;
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