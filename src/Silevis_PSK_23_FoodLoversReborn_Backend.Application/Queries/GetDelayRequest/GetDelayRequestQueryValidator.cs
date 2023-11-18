using FluentValidation;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Application.Queries;

public class GetDelayRequestQueryValidator : AbstractValidator<GetDelayRequestQuery>
{
    public GetDelayRequestQueryValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .NotNull();
    }
}