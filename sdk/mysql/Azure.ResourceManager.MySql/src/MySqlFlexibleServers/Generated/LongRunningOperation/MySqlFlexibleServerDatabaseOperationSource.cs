// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.MySql.FlexibleServers
{
    internal class MySqlFlexibleServerDatabaseOperationSource : IOperationSource<MySqlFlexibleServerDatabaseResource>
    {
        private readonly ArmClient _client;

        internal MySqlFlexibleServerDatabaseOperationSource(ArmClient client)
        {
            _client = client;
        }

        MySqlFlexibleServerDatabaseResource IOperationSource<MySqlFlexibleServerDatabaseResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = MySqlFlexibleServerDatabaseData.DeserializeMySqlFlexibleServerDatabaseData(document.RootElement);
            return new MySqlFlexibleServerDatabaseResource(_client, data);
        }

        async ValueTask<MySqlFlexibleServerDatabaseResource> IOperationSource<MySqlFlexibleServerDatabaseResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = MySqlFlexibleServerDatabaseData.DeserializeMySqlFlexibleServerDatabaseData(document.RootElement);
            return new MySqlFlexibleServerDatabaseResource(_client, data);
        }
    }
}
