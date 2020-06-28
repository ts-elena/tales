using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TalesAPI.Services.ServiceInterfaces;

namespace TalesAPI.Controllers
{
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
