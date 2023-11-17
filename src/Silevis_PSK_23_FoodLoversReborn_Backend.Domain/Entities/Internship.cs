using Silevis_PSK_23_FoodLoversReborn_Backend.Domain.Base;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Domain.Entities;

public class Internship : BaseEntity
{
    public required Guid StudentId { get; init; }
    public required Guid InternshipOfferId { get; init; }
    public bool? Passed { get; private set; }

    public Internship(
        Guid studentId, 
        Guid internshipOfferId)
    {
        StudentId = studentId;
        InternshipOfferId = internshipOfferId;
    }

    public void SetPassed(bool passed)
    {
        Passed = passed;
    }
    
}