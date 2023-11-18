using MediatR;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Application.Commands.StudentDocument.UploadDocument;

public sealed record UploadDocumentCommand(
    byte[] Stream,
    int StudentId,
    int AlbumNumber,
    int DocumentId
    ) : IRequest<Domain.Entities.StudentDocument>
{ }