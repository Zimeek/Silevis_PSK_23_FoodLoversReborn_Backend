using FluentValidation;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Application.Queries;

public class GetInternshipQueryValidator : AbstractValidator<GetInternshipQuery>
{
    public GetInternshipQueryValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .NotNull();
    }
}