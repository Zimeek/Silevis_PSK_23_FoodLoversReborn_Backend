using FluentValidation;
using Silevis_PSK_23_FoodLoversReborn_Backend.Application.Commands.DelayRequest;
using Silevis_PSK_23_FoodLoversReborn_Backend.Application.Commands.Internship;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Application.Queries;

public class HandleDelayRequestCommandValidator : AbstractValidator<HandleDelayRequestCommand>
{
    public HandleDelayRequestCommandValidator()
    {
        RuleFor(x => x.Id)
            .NotNull()
            .NotEmpty();

        RuleFor(x => x.Approved)
            .NotNull();
    }
}