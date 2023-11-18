namespace Silevis_PSK_23_FoodLoversReborn_Backend.Application.Commands.Internship;

public class AddInternshipCommandResponse
{
    public AddInternshipCommandResponse(
        Guid internshipId)
    {
        InternshipId = internshipId;
    }
    
    public Guid InternshipId { get; init; }
}