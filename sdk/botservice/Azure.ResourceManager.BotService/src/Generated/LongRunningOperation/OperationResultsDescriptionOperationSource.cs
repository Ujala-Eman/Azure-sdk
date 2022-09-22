// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.BotService.Models;

namespace Azure.ResourceManager.BotService
{
    internal class OperationResultsDescriptionOperationSource : IOperationSource<OperationResultsDescription>
    {
        OperationResultsDescription IOperationSource<OperationResultsDescription>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return OperationResultsDescription.DeserializeOperationResultsDescription(document.RootElement);
        }

        async ValueTask<OperationResultsDescription> IOperationSource<OperationResultsDescription>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return OperationResultsDescription.DeserializeOperationResultsDescription(document.RootElement);
        }
    }
}
