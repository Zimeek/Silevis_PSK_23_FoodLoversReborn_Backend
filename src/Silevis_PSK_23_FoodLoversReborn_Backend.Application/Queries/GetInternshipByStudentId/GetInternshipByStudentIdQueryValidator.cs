using FluentValidation;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Application.Queries;

public class GetInternshipByStudentIdQueryValidator : AbstractValidator<GetInternshipByStudentIdQuery>
{
    public GetInternshipByStudentIdQueryValidator()
    {
        RuleFor(x => x.Id)
            .GreaterThan(0)
            .NotEmpty()
            .NotNull();
    }
}