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

namespace Azure.ResourceManager.EventGrid
{
    internal class EventSubscriptionOperationSource : IOperationSource<EventSubscriptionResource>
    {
        private readonly ArmClient _client;

        internal EventSubscriptionOperationSource(ArmClient client)
        {
            _client = client;
        }

        EventSubscriptionResource IOperationSource<EventSubscriptionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = EventSubscriptionData.DeserializeEventSubscriptionData(document.RootElement);
            return new EventSubscriptionResource(_client, data);
        }

        async ValueTask<EventSubscriptionResource> IOperationSource<EventSubscriptionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = EventSubscriptionData.DeserializeEventSubscriptionData(document.RootElement);
            return new EventSubscriptionResource(_client, data);
        }
    }
}
