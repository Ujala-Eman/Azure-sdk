// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers
{
    internal class DotNetComponentOperationSource : IOperationSource<DotNetComponentResource>
    {
        private readonly ArmClient _client;

        internal DotNetComponentOperationSource(ArmClient client)
        {
            _client = client;
        }

        DotNetComponentResource IOperationSource<DotNetComponentResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = DotNetComponentData.DeserializeDotNetComponentData(document.RootElement);
            return new DotNetComponentResource(_client, data);
        }

        async ValueTask<DotNetComponentResource> IOperationSource<DotNetComponentResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = DotNetComponentData.DeserializeDotNetComponentData(document.RootElement);
            return new DotNetComponentResource(_client, data);
        }
    }
}
