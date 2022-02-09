// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The List operation response, that contains the SQL database events and their properties. </summary>
    internal partial class RestorableSqlDatabasesList
    {
        /// <summary> Initializes a new instance of RestorableSqlDatabasesList. </summary>
        internal RestorableSqlDatabasesList()
        {
            Value = new ChangeTrackingList<RestorableSqlDatabase>();
        }

        /// <summary> Initializes a new instance of RestorableSqlDatabasesList. </summary>
        /// <param name="value"> List of SQL database events and their properties. </param>
        internal RestorableSqlDatabasesList(IReadOnlyList<RestorableSqlDatabase> value)
        {
            Value = value;
        }

        /// <summary> List of SQL database events and their properties. </summary>
        public IReadOnlyList<RestorableSqlDatabase> Value { get; }
    }
}
