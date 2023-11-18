using FluentValidation;
using Silevis_PSK_23_FoodLoversReborn_Backend.Application.Commands.Internship;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Application.Queries;

public class DeleteInternshipCommandValidator : AbstractValidator<DeleteInternshipCommand>
{
    public DeleteInternshipCommandValidator()
    {
        RuleFor(x => x.StudentId)
            .NotNull()
            .NotEmpty();
    }
}