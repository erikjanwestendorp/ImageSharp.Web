// Copyright (c) Six Labors.
// Licensed under the Six Labors Split License.

using SixLabors.ImageSharp.Web;
using SixLabors.ImageSharp.Web.Resolvers;

namespace ImageSharp.Web.Providers.GCP;

/// <summary>
/// Provides means to manage image buffers within the GCP Storage file system.
/// </summary>
public class GCPStorageCacheResolver : IImageResolver
{
    public Task<ImageMetadata> GetMetaDataAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Stream> OpenReadAsync()
    {
        throw new NotImplementedException();
    }
}
