namespace Build.Infrastructure;

/// <summary>
/// IStorage interface.
/// </summary>
public interface IStorage
{
    Task<Uri> GetFileSharedAccessSignatureURI (string filePath);
    Task<bool> CheckFileExistsAsync (string filePath);
    Task<bool> ListFiles (List<int> fileList);
    Task<bool> UploadFileFromStreamAsync (string filePath, Stream inputStream);
    Task<Stream> DownloadFileToStreamAsync (string filePath);
    Task<bool> MoveFileAsync (string filePath);
    Task<bool> DeleteFileAsync (string filePath);
}
