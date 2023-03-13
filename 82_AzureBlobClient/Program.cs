using Azure.Storage.Blobs;

namespace _82_AzureBlobClient;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Azure Blob Storage exercise\n");

        ProcessAsync().GetAwaiter().GetResult();
    }

    static async Task ProcessAsync()
    {
        // Copy the connection string from the portal in the variable below.
        string storageConnectionString = "CONNECTION STRING";

        // Create a client that can authenticate with a connection string
        BlobServiceClient blobServiceClient = new BlobServiceClient(storageConnectionString);

        // COPY EXAMPLE CODE BELOW HERE
    }
}
