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

namespace Azure.ResourceManager.ServiceBus
{
    internal class ServiceBusQueueOperationSource : IOperationSource<ServiceBusQueue>
    {
        private readonly ArmClient _client;

        internal ServiceBusQueueOperationSource(ArmClient client)
        {
            _client = client;
        }

        ServiceBusQueue IOperationSource<ServiceBusQueue>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ServiceBusQueueData.DeserializeServiceBusQueueData(document.RootElement);
            return new ServiceBusQueue(_client, data);
        }

        async ValueTask<ServiceBusQueue> IOperationSource<ServiceBusQueue>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ServiceBusQueueData.DeserializeServiceBusQueueData(document.RootElement);
            return new ServiceBusQueue(_client, data);
        }
    }
}
