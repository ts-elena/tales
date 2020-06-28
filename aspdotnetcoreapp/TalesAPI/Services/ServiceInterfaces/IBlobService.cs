using TalesApp.Domain.Services.Communication;

namespace TalesAPI.Services.ServiceInterfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public interface IBlobService
    {
        public Task<BlobInfo> GetBlobAsync(string containerName, string blobName);
    }
}
