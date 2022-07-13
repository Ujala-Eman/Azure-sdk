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

namespace Azure.ResourceManager.Communication
{
    internal class CommunicationServiceResourceOperationSource : IOperationSource<CommunicationServiceResource>
    {
        private readonly ArmClient _client;

        internal CommunicationServiceResourceOperationSource(ArmClient client)
        {
            _client = client;
        }

        CommunicationServiceResource IOperationSource<CommunicationServiceResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = CommunicationServiceResourceData.DeserializeCommunicationServiceResourceData(document.RootElement);
            return new CommunicationServiceResource(_client, data);
        }

        async ValueTask<CommunicationServiceResource> IOperationSource<CommunicationServiceResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = CommunicationServiceResourceData.DeserializeCommunicationServiceResourceData(document.RootElement);
            return new CommunicationServiceResource(_client, data);
        }
    }
}
