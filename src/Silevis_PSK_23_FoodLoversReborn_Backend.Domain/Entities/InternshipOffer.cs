using Silevis_PSK_23_FoodLoversReborn_Backend.Domain.Base;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Domain.Entities;

public class InternshipOffer : BaseEntity
{
    public string Title { get; private set; }
    public string Company { get; private set; }
    public string? CompanyAddress { get; private set; }
    public int? CompanyPhone { get; private set; }
    public int TotalSlots { get; private set; }
    public int AvailableSlots { get; private set; }
    public DateTime DateStart { get; private set; }
    public DateTime DateEnd { get; private set; }
    public DateTime Deadline { get; set; }
    public TimeOnly ShiftStart { get; private set; }
    public TimeOnly ShiftEnd { get; private set; }

    public InternshipOffer(
        string title,
        string company,
        string companyAddress,
        int companyPhone,
        int totalSlots,
        int availableSlots,
        DateTime dateStart,
        DateTime dateEnd,
        DateTime deadline,
        TimeOnly shiftStart,
        TimeOnly shiftEnd)
    {
        Title = title;
        Company = company;
        CompanyAddress = companyAddress;
        CompanyPhone = companyPhone;
        DateStart = dateStart;
        DateEnd = dateEnd;
        Deadline = deadline;
        ShiftStart = shiftStart;
        ShiftEnd = shiftEnd;
        TotalSlots = totalSlots;
        AvailableSlots = availableSlots;
    }

    public void SetAvailableSlots(int availableSlots)
    {
        if (AvailableSlots >= 0)
        {
            AvailableSlots = availableSlots;
        }
        
        //Todo: domain event?
    }
}