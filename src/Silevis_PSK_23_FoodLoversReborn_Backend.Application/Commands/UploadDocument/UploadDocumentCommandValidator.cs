using FluentValidation;
using Silevis_PSK_23_FoodLoversReborn_Backend.Application.Commands.StudentDocument.UploadDocument;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Application.Commands;

public class UploadDocumentCommandValidator : AbstractValidator<UploadDocumentCommand>
{
    public UploadDocumentCommandValidator()
    {
        RuleFor(x => x.Stream)
            .NotNull()
            .NotEmpty();

        RuleFor(x => x.StudentId)
            .NotNull()
            .GreaterThan(0);
        
        RuleFor(x => x.AlbumNumber)
            .NotNull()
            .GreaterThan(0);
        
        RuleFor(x => x.DocumentId)
            .NotNull()
            .GreaterThan(0);
    }
}