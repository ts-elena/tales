namespace TalesAPI.Controllers
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using TalesAPI.Services.ServiceInterfaces;

    [Route("api/[controller]")]
    [ApiController]
    public class BlobExplorerController : ControllerBase
    {
        private readonly IBlobService _blobService;

        public BlobExplorerController(IBlobService blobService)
        {
            _blobService = blobService;
        }

        // GET: api/BlobExplorer
        [HttpGet("{containerName}/{blobName}")]
        public async Task<IActionResult> Get(string containerName, string blobName)
        {
            var data = await _blobService.GetBlobAsync(containerName, blobName);
            return File(data.Content, data.ContentType);
        }
    }
}
