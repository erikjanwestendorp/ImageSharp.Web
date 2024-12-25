// Copyright (c) Six Labors.
// Licensed under the Six Labors Split License.

using Microsoft.AspNetCore.Http;
using SixLabors.ImageSharp.Web.Providers;
using SixLabors.ImageSharp.Web.Resolvers;

namespace ImageSharp.Web.Providers.GCP;

/// <summary>
/// Returns images stored in GCP Storage.
/// </summary>
internal class GCPStorageImageProvider : IImageProvider
{
    public ProcessingBehavior ProcessingBehavior { get; }
    public Func<HttpContext, bool> Match { get; set; }

    public bool IsValidRequest(HttpContext context)
    {
        throw new NotImplementedException();
    }

    public Task<IImageResolver?> GetAsync(HttpContext context)
    {
        throw new NotImplementedException();
    }
}
