// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The connection strings for the given database account. </summary>
    internal partial class DatabaseAccountListConnectionStringsResult
    {
        /// <summary> Initializes a new instance of <see cref="DatabaseAccountListConnectionStringsResult"/>. </summary>
        internal DatabaseAccountListConnectionStringsResult()
        {
            ConnectionStrings = new ChangeTrackingList<DatabaseAccountConnectionString>();
        }

        /// <summary> Initializes a new instance of <see cref="DatabaseAccountListConnectionStringsResult"/>. </summary>
        /// <param name="connectionStrings"> An array that contains the connection strings for the Cosmos DB account. </param>
        internal DatabaseAccountListConnectionStringsResult(IReadOnlyList<DatabaseAccountConnectionString> connectionStrings)
        {
            ConnectionStrings = connectionStrings;
        }

        /// <summary> An array that contains the connection strings for the Cosmos DB account. </summary>
        public IReadOnlyList<DatabaseAccountConnectionString> ConnectionStrings { get; }
    }
}
