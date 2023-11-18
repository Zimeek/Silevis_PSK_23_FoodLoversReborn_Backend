using MediatR;
using Microsoft.Extensions.Configuration;
using Silevis_PSK_23_FoodLoversReborn_Backend.Infrastructure.DataAccess;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Application.Commands.StudentDocument.UploadDocument;

public sealed class UploadDocumentCommandHandler : IRequestHandler<UploadDocumentCommand, Domain.Entities.StudentDocument>
{
    private readonly ApplicationDbContext _dbContext;
    private readonly IConfiguration _configuration;

    public UploadDocumentCommandHandler(ApplicationDbContext dbContext, IConfiguration configuration)
    {
        _dbContext = dbContext;
        _configuration = configuration;
    }
    
    public async Task<Domain.Entities.StudentDocument> Handle(UploadDocumentCommand request, CancellationToken cancellationToken)
    {
        var studentDirectory = $@"{_configuration.GetSection("FileUploadsDirectory").Value}\{request.AlbumNumber}";
        var fileDirectory = Path.Combine(Environment.CurrentDirectory, studentDirectory);
        var fileName = $"{Path.GetRandomFileName()}.pdf";
        var fullFilePath = fileDirectory + $@"\{fileName}";

        var memoryStream = new MemoryStream(request.Stream);

        Directory.CreateDirectory(fileDirectory);

        await using var stream = File.Create(fullFilePath);
        memoryStream.Seek(0, SeekOrigin.Begin);
       
        await memoryStream.CopyToAsync(stream, cancellationToken);
       
        var studentDocument = new Domain.Entities.StudentDocument(
            fullFilePath,
            request.StudentId,
            request.DocumentId,
            request.AlbumNumber
        );

        await _dbContext.StudentDocuments
            .AddAsync(studentDocument, cancellationToken);

        await _dbContext.SaveChangesAsync(cancellationToken);

        return studentDocument;
    }
}