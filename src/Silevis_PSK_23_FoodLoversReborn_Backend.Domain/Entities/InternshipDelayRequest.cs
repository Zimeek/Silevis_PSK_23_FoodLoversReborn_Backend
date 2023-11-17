using Silevis_PSK_23_FoodLoversReborn_Backend.Domain.Base;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Domain.Entities;

public class InternshipDelayRequest : BaseEntity
{
    public required Guid InternshipOfferId { get; init; }
    public required Guid StudentId { get; init; }
    public required DateTime RequestedDateStart { get; init; }
    public required DateTime RequestedDateEnd { get; init; }
    public bool? Approved { get; private set; }

    public InternshipDelayRequest(
        Guid internshipOfferId,
        Guid studentId,
        DateTime requestedDateStart,
        DateTime requestedDateEnd)
    {
        InternshipOfferId = internshipOfferId;
        StudentId = studentId;
        RequestedDateStart = requestedDateStart;
        RequestedDateEnd = requestedDateEnd;
    }

    public void SetApproved(bool approved)
    {
        Approved = approved;
    }
    
}