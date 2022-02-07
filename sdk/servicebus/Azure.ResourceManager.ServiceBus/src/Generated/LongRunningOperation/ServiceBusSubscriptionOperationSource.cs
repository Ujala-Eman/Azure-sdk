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
    internal class ServiceBusSubscriptionOperationSource : IOperationSource<ServiceBusSubscription>
    {
        private readonly ArmClient _client;

        internal ServiceBusSubscriptionOperationSource(ArmClient client)
        {
            _client = client;
        }

        ServiceBusSubscription IOperationSource<ServiceBusSubscription>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ServiceBusSubscriptionData.DeserializeServiceBusSubscriptionData(document.RootElement);
            return new ServiceBusSubscription(_client, data);
        }

        async ValueTask<ServiceBusSubscription> IOperationSource<ServiceBusSubscription>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ServiceBusSubscriptionData.DeserializeServiceBusSubscriptionData(document.RootElement);
            return new ServiceBusSubscription(_client, data);
        }
    }
}
