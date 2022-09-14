// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Search
{
    internal class SharedPrivateLinkResourceOperationSource : IOperationSource<SharedPrivateLinkResource>
    {
        private readonly ArmClient _client;

        internal SharedPrivateLinkResourceOperationSource(ArmClient client)
        {
            _client = client;
        }

        SharedPrivateLinkResource IOperationSource<SharedPrivateLinkResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SharedPrivateLinkResourceData.DeserializeSharedPrivateLinkResourceData(document.RootElement);
            return new SharedPrivateLinkResource(_client, data);
        }

        async ValueTask<SharedPrivateLinkResource> IOperationSource<SharedPrivateLinkResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SharedPrivateLinkResourceData.DeserializeSharedPrivateLinkResourceData(document.RootElement);
            return new SharedPrivateLinkResource(_client, data);
        }
    }
}
