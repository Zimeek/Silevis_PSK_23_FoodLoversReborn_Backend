using FluentValidation;
using Silevis_PSK_23_FoodLoversReborn_Backend.Application.Commands.DelayRequest;
using Silevis_PSK_23_FoodLoversReborn_Backend.Application.Commands.Internship;
using Silevis_PSK_23_FoodLoversReborn_Backend.Application.Commands.SetInternshipStatus;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Application.Queries;

public class SetInternshipStatusCommandValidator : AbstractValidator<SetInternshipStatusCommand>
{
    public SetInternshipStatusCommandValidator()
    {
        RuleFor(x => x.InternshipId)
            .NotNull()
            .NotEmpty();

        RuleFor(x => x.Passed)
            .NotNull();
    }
}