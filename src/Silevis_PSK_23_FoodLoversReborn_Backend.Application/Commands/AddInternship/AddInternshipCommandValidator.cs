using FluentValidation;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Application.Commands.Internship;

public class AddInternshipCommandValidator : AbstractValidator<AddInternshipCommand>
{
    public AddInternshipCommandValidator()
    {
        RuleFor(x => x.StudentId)
            .GreaterThan(0)
            .NotNull();

        RuleFor(x => x.CompanyName)
            .NotNull()
            .NotEmpty();

        RuleFor(x => x.DateStart)
            .GreaterThan(DateTime.UtcNow);

        RuleFor(x => x.DateEnd)
            .GreaterThan(x => x.DateStart);
    }
}