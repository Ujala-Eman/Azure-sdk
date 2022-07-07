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

namespace Azure.ResourceManager.ApiManagement
{
    internal class NamedValueContractOperationSource : IOperationSource<NamedValueContractResource>
    {
        private readonly ArmClient _client;

        internal NamedValueContractOperationSource(ArmClient client)
        {
            _client = client;
        }

        NamedValueContractResource IOperationSource<NamedValueContractResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = NamedValueContractData.DeserializeNamedValueContractData(document.RootElement);
            return new NamedValueContractResource(_client, data);
        }

        async ValueTask<NamedValueContractResource> IOperationSource<NamedValueContractResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = NamedValueContractData.DeserializeNamedValueContractData(document.RootElement);
            return new NamedValueContractResource(_client, data);
        }
    }
}
