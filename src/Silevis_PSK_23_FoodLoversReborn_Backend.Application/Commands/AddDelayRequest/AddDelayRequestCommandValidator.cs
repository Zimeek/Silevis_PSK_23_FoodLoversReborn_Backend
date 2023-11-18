using FluentValidation;
using Silevis_PSK_23_FoodLoversReborn_Backend.Application.Commands.DelayRequest;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Application.Queries;

public class AddDelayRequestCommandValidator : AbstractValidator<AddDelayRequestCommand>
{
    public AddDelayRequestCommandValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .NotNull();

        RuleFor(x => x.StudentId)
            .GreaterThan(0)
            .NotNull();

        RuleFor(x => x.RequestedDateStart)
            .GreaterThan(DateTime.UtcNow);

        RuleFor(x => x.RequestedDateEnd)
            .GreaterThan(x => x.RequestedDateStart);
    }
}