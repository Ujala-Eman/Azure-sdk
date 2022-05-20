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

namespace Azure.ResourceManager.MachineLearning
{
    internal class BatchEndpointDataOperationSource : IOperationSource<BatchEndpointDataResource>
    {
        private readonly ArmClient _client;

        internal BatchEndpointDataOperationSource(ArmClient client)
        {
            _client = client;
        }

        BatchEndpointDataResource IOperationSource<BatchEndpointDataResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = BatchEndpointDataData.DeserializeBatchEndpointDataData(document.RootElement);
            return new BatchEndpointDataResource(_client, data);
        }

        async ValueTask<BatchEndpointDataResource> IOperationSource<BatchEndpointDataResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = BatchEndpointDataData.DeserializeBatchEndpointDataData(document.RootElement);
            return new BatchEndpointDataResource(_client, data);
        }
    }
}
