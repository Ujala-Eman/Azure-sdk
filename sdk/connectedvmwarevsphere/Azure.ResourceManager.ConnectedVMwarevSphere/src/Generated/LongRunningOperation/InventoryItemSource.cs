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

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    internal class InventoryItemSource : IOperationSource<InventoryItem>
    {
        private readonly ArmClient _client;

        internal InventoryItemSource(ArmClient client)
        {
            _client = client;
        }

        InventoryItem IOperationSource<InventoryItem>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = InventoryItemData.DeserializeInventoryItemData(document.RootElement);
            return new InventoryItem(_client, data);
        }

        async ValueTask<InventoryItem> IOperationSource<InventoryItem>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = InventoryItemData.DeserializeInventoryItemData(document.RootElement);
            return new InventoryItem(_client, data);
        }
    }
}
