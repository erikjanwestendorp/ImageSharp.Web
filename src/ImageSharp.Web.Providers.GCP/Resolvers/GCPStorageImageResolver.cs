// Copyright (c) Six Labors.
// Licensed under the Six Labors Split License.

using SixLabors.ImageSharp.Web;
using SixLabors.ImageSharp.Web.Resolvers;

namespace ImageSharp.Web.Providers.GCP.Resolvers;

/// <summary>
/// Provides means to manage image buffers within the GCP storage file system.
/// </summary>
public class GCPStorageImageResolver : IImageResolver
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
