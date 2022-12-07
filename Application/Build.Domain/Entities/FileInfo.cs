namespace Build.Domain.Entities;

using Build.Shared.Utils;

public class FileInfo : BaseEntity<int>
{
    /// <summary>
    /// Gets or sets name
    /// </summary>
    public string Name { get; set; }

    public string Description { get; set; }

    public string Path { get; set; }

    public string AssignedTo { get; set; }

    public int UploaderId { get; set; }

    public string Extension { get; set; }

    public string Type { get; set; }

    public string ThumbPath { get; set; }

    /// <summary>
    /// Gets or sets file size.
    /// </summary>
    public long Size { get; set; }

    public bool IsDeleted { get; set; }

    /// <summary>
    /// Gets or sets the Created date for the enitiy.
    /// </summary>
    public DateTimeOffset CreatedDate { get; set; }

    public bool IsPicture()
    {
        return true;
    }

    public string GetContentType()
    {
        return Path.GetFileContentType();
    }
}
