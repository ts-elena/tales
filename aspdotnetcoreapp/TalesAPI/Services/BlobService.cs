namespace TalesAPI.Services
{
    using System;
    using System.Threading.Tasks;
    using TalesAPI.Services.ServiceInterfaces;
    using Azure.Storage.Blobs;
    using Azure.Storage.Blobs.Models;
    using NLog;

    public class BlobService: IBlobService
    {
        private readonly BlobServiceClient _blobService;
        private readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public BlobService(BlobServiceClient blobServiceClient)
        {
            _blobService = blobServiceClient;
        }

        public async Task<BlobInfo> GetBlobAsync(string containerName, string blobName)
        {
            var containerClient = _blobService.GetBlobContainerClient(containerName);
            var blobClient = containerClient.GetBlobClient(blobName);
            var blobDownloadInfo = default(BlobDownloadInfo);
            try
            {
                blobDownloadInfo = await blobClient.DownloadAsync();
            }
            catch (Exception exception)
            {
                Logger.Error(exception, $"Error when updating characters: {exception.Message}. Inner exception: {exception.InnerException}");
                throw new Exception($"An error occurred when updating the sequence: {exception.Message}");
            }

            return new BlobInfo(blobDownloadInfo.Content, blobDownloadInfo.ContentType);
        }
    }
}
