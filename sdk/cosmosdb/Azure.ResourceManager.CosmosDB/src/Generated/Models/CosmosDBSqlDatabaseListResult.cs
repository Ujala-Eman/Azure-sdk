// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CosmosDB;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The List operation response, that contains the SQL databases and their properties. </summary>
    internal partial class CosmosDBSqlDatabaseListResult
    {
        /// <summary> Initializes a new instance of CosmosDBSqlDatabaseListResult. </summary>
        internal CosmosDBSqlDatabaseListResult()
        {
            Value = new ChangeTrackingList<CosmosDBSqlDatabaseData>();
        }

        /// <summary> Initializes a new instance of CosmosDBSqlDatabaseListResult. </summary>
        /// <param name="value"> List of SQL databases and their properties. </param>
        internal CosmosDBSqlDatabaseListResult(IReadOnlyList<CosmosDBSqlDatabaseData> value)
        {
            Value = value;
        }

        /// <summary> List of SQL databases and their properties. </summary>
        public IReadOnlyList<CosmosDBSqlDatabaseData> Value { get; }
    }
}
