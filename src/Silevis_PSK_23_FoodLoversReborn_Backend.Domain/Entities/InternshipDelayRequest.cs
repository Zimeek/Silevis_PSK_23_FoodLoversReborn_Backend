using Silevis_PSK_23_FoodLoversReborn_Backend.Domain.Base;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Domain.Entities;

public class InternshipDelayRequest
{
    public Guid Id { get; init; }
    public int StudentId { get; init; }
    public DateTime RequestedDateStart { get; init; }
    public DateTime RequestedDateEnd { get; init; }
    public bool? Approved { get; set; }

    public InternshipDelayRequest(
        Guid id,
        int studentId,
        DateTime requestedDateStart,
        DateTime requestedDateEnd)
    {
        Id = id;
        StudentId = studentId;
        RequestedDateStart = requestedDateStart;
        RequestedDateEnd = requestedDateEnd;
    }

    public void SetApproved(bool approved)
    {
        Approved = approved;
    }
    
}