using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Blog.Persistence;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using Dapper;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

namespace Blogs.AzureApi
{
    public class Function1
    {
        [FunctionName("UploadToBlobOnTime")]
        public async Task Run([TimerTrigger("0 */1 * * * *")] TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");

            var cs = @"Server=tcp:blog-korneltoth.database.windows.net,1433;Initial Catalog=blog-korneltoth;Persist Security Info=False;User ID=kornel.toth;Password=Almafa123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            using (var conn = new SqlConnection(cs))
            {
                conn.Open();

                var blogs = conn.Query<Blog.Persistence.Blog>("SELECT * FROM [dbo].[Blogs] WHERE BlobUrl is null");

                foreach (var blog in blogs)
                {
                    var uri = await CreateBlobFromBlog(blog);

                    await conn.ExecuteAsync("UPDATE [dbo].[Blogs] SET BlobUrl = @URI WHERE Id = @ID", new { URI = uri, ID = blog.Id });
                }
            }
        }

        private async Task<string> CreateBlobFromBlog(Blog.Persistence.Blog blog)
        {
            var blobServiceClient = new BlobServiceClient("DefaultEndpointsProtocol=https;AccountName=korneltoth;AccountKey=Kp/YIiqapFYN526DS7q+/Tx+xPQ9sQ4wl5vGvLnahHmd+B268C+nqmnj0d/f4PhE0iELDKH9t7EN+ASt+zsyMQ==;EndpointSuffix=core.windows.net");

            var containerClient = blobServiceClient.GetBlobContainerClient("blog");

            using (FileStream fs = System.IO.File.Create(blog.Title + ".txt"))
            {
                var text = new UTF8Encoding(true).GetBytes(blog.BlogText);
                await fs.WriteAsync(text, 0, text.Length);

                BlobClient blobClient = containerClient.GetBlobClient(blog.Title + ".txt");

                fs.Position = 0;
                await blobClient.UploadAsync(fs, true);

                blobClient.SetAccessTier(AccessTier.Cool);
                return blobClient.Uri.AbsoluteUri;
            }
        }
    }
}
