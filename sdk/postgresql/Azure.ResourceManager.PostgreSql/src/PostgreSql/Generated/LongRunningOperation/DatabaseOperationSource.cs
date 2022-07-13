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

namespace Azure.ResourceManager.PostgreSql
{
    internal class DatabaseOperationSource : IOperationSource<DatabaseResource>
    {
        private readonly ArmClient _client;

        internal DatabaseOperationSource(ArmClient client)
        {
            _client = client;
        }

        DatabaseResource IOperationSource<DatabaseResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = DatabaseData.DeserializeDatabaseData(document.RootElement);
            return new DatabaseResource(_client, data);
        }

        async ValueTask<DatabaseResource> IOperationSource<DatabaseResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = DatabaseData.DeserializeDatabaseData(document.RootElement);
            return new DatabaseResource(_client, data);
        }
    }
}
