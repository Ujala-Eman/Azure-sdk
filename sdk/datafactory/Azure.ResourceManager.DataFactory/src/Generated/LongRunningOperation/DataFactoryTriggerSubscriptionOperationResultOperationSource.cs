// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.DataFactory.Models;

namespace Azure.ResourceManager.DataFactory
{
    internal class DataFactoryTriggerSubscriptionOperationResultOperationSource : IOperationSource<DataFactoryTriggerSubscriptionOperationResult>
    {
        DataFactoryTriggerSubscriptionOperationResult IOperationSource<DataFactoryTriggerSubscriptionOperationResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return DataFactoryTriggerSubscriptionOperationResult.DeserializeDataFactoryTriggerSubscriptionOperationResult(document.RootElement);
        }

        async ValueTask<DataFactoryTriggerSubscriptionOperationResult> IOperationSource<DataFactoryTriggerSubscriptionOperationResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return DataFactoryTriggerSubscriptionOperationResult.DeserializeDataFactoryTriggerSubscriptionOperationResult(document.RootElement);
        }
    }
}
