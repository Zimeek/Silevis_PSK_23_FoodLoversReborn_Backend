using Silevis_PSK_23_FoodLoversReborn_Backend.Domain.Base;
using Silevis_PSK_23_FoodLoversReborn_Backend.Domain.ValueObjects;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Domain.Entities;

public class Internship : BaseEntity
{
    public required Guid StudentId { get; init; }
    public bool? Passed { get; private set; }
    public InternshipDetails InternshipDetails { get; private set; }

    public Internship(
        Guid studentId)
    {
        StudentId = studentId;
    }

    public void SetPassed(bool passed)
    {
        Passed = passed;
    }
    
}