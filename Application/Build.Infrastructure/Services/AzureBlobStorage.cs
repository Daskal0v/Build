namespace Build.Infrastructure.Services;

using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;

internal sealed class AzureBlobStorage : IStorage
{
    CloudBlobContainer cloudBlobContainer;
    private string ContainerName;
    private string ConnectionString;
    public AzureBlobStorage (string containerName, string connectionString)
    {
        ContainerName = containerName;
        ConnectionString = connectionString;
        cloudBlobContainer = GetContainerReference();
    }

    public Task<bool> CheckFileExistsAsync (string filePath)
    {
        CloudBlockBlob blockBlob = cloudBlobContainer.GetBlockBlobReference(filePath);

        return blockBlob.ExistsAsync();
    }

    public Task<bool> DeleteFileAsync (string filePath)
    {
        CloudBlockBlob blockBlob = cloudBlobContainer.GetBlockBlobReference(filePath);
        return blockBlob.DeleteIfExistsAsync();
    }

    public Task<Stream> DownloadFileToStreamAsync (string filePath)
    {
        throw new NotImplementedException();
    }

    public Task<Uri> GetFileSharedAccessSignatureURI (string filePath)
    {
        throw new NotImplementedException();
    }

    public Task<bool> ListFiles (List<int> fileList)
    {
        throw new NotImplementedException();
    }

    public Task<bool> MoveFileAsync (string filePath)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UploadFileFromStreamAsync (string filePath, Stream inputStream)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Provides the ability to connect to the Azure storage account and get a reference to the storage container
    /// </summary>
    private CloudBlobContainer GetContainerReference (string containerName = null)
    {
        CloudBlobContainer blobContainer;
        CloudStorageAccount storageAccount;
        CloudBlobClient blobClient;

        if (string.IsNullOrEmpty(containerName))
        {
            containerName = ContainerName;
        }

        // Connect to the cloud storage account
        if (CloudStorageAccount.TryParse(ConnectionString,
                                         out storageAccount))
        {
            // Get a reference to the files blob container
            blobClient = storageAccount.CreateCloudBlobClient();
            blobContainer = blobClient.GetContainerReference(containerName);

            if (!blobContainer.ExistsAsync().Result)
            {
                throw new Exception("Azure storage files container [" + containerName + "] was not found");
            }
        }
        else
        {
            throw new Exception("Could not parse Azure storage account connection string");
        }

        return blobContainer;
    }
}