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

namespace Azure.ResourceManager.Synapse
{
    internal class DatabasePrincipalAssignmentOperationSource : IOperationSource<DatabasePrincipalAssignmentResource>
    {
        private readonly ArmClient _client;

        internal DatabasePrincipalAssignmentOperationSource(ArmClient client)
        {
            _client = client;
        }

        DatabasePrincipalAssignmentResource IOperationSource<DatabasePrincipalAssignmentResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = DatabasePrincipalAssignmentData.DeserializeDatabasePrincipalAssignmentData(document.RootElement);
            return new DatabasePrincipalAssignmentResource(_client, data);
        }

        async ValueTask<DatabasePrincipalAssignmentResource> IOperationSource<DatabasePrincipalAssignmentResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = DatabasePrincipalAssignmentData.DeserializeDatabasePrincipalAssignmentData(document.RootElement);
            return new DatabasePrincipalAssignmentResource(_client, data);
        }
    }
}
