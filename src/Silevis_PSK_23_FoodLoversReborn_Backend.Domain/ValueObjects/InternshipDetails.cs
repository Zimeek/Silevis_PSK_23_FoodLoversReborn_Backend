using Silevis_PSK_23_FoodLoversReborn_Backend.Domain.Base;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Domain.ValueObjects;

public class InternshipDetails : ValueObject
{
    public string CompanyName { get; private set; }
    public string? CompanyAddress { get; private set; }
    public string? CompanyPhone { get; private set; }
    public DateTime DateStart { get; private set; }
    public DateTime DateEnd { get; private set; }
    public int Month { get; private set;  }

    public InternshipDetails(
        string companyName,
        string? companyAddress,
        string? companyPhone,
        DateTime dateStart,
        DateTime dateEnd,
        int month)
    {
        CompanyName = companyPhone;
        CompanyAddress = companyAddress;
        CompanyPhone = companyPhone;
        DateStart = dateStart;
        DateEnd = dateEnd;
        Month = month;
    }
    protected override IEnumerable<object> GetAtomicValues()
    {
        yield return CompanyName;
        yield return CompanyAddress;
        yield return CompanyPhone;
        yield return Month;
        yield return DateStart;
        yield return DateEnd;
    }
}