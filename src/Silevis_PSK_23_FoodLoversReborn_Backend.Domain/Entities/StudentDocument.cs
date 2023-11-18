using Silevis_PSK_23_FoodLoversReborn_Backend.Domain.Base;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Domain.Entities;

public class StudentDocument : BaseEntity
{
    public StudentDocument(
        string filePath,
        int studentId,
        int documentId,
        int albumNumber
        )
    {
        FilePath = filePath;
        StudentId = studentId;
        DocumentId = documentId;
        AlbumNumber = albumNumber;
    }
    
    public string FilePath { get; private init; }
    public int StudentId { get; private set; }
    public int DocumentId { get; private set; }
    public int AlbumNumber { get; private set; }
}