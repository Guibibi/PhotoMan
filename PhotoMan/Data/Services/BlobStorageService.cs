using Azure.Identity;
using Azure.Storage.Blobs;
namespace PhotoMan.Data.Services
{
	public class BlobStorageService
	{
		public readonly BlobServiceClient _blobStorageService;

		public BlobStorageService()
		{
			_blobStorageService = new BlobServiceClient(
			new Uri("https://photobomba.blob.core.windows.net"),
			new DefaultAzureCredential());
		}

		public void SaveBlobs()
		{
			_blobStorageService.GetBlobContainerClient("photos-archive");
		}
	}
}
