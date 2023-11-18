using FluentValidation;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Application.Queries;

public class GetDocumentStatusQueryValidator : AbstractValidator<GetDocumentStatusQuery>
{
    public GetDocumentStatusQueryValidator()
    {
        RuleFor(x => x.StudentId)
            .GreaterThan(0)
            .NotEmpty()
            .NotNull();
    }
}