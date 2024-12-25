using SixLabors.ImageSharp.Web;
using SixLabors.ImageSharp.Web.Caching;
using SixLabors.ImageSharp.Web.Resolvers;

namespace ImageSharp.Web.Providers.GCP;

/// <summary>
/// Implements an GCP Storage based cache.
/// </summary>
public class GCPStorageCache : IImageCache
{
    public Task<IImageCacheResolver?> GetAsync(string key)
    {
        throw new NotImplementedException();
    }

    public Task SetAsync(string key, Stream stream, ImageCacheMetadata metadata)
    {
        throw new NotImplementedException();
    }
}
