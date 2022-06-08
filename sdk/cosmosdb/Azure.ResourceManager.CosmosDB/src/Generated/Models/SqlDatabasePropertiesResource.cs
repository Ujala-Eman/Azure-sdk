// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The SqlDatabasePropertiesResource. </summary>
    public partial class SqlDatabasePropertiesResource : SqlDatabaseResource
    {
        /// <summary> Initializes a new instance of <see cref="SqlDatabasePropertiesResource"/>. </summary>
        /// <param name="id"> Name of the Cosmos DB SQL database. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public SqlDatabasePropertiesResource(string id) : base(id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
        }

        /// <summary> Initializes a new instance of <see cref="SqlDatabasePropertiesResource"/>. </summary>
        /// <param name="id"> Name of the Cosmos DB SQL database. </param>
        /// <param name="colls"> A system generated property that specified the addressable path of the collections resource. </param>
        /// <param name="users"> A system generated property that specifies the addressable path of the users resource. </param>
        /// <param name="rid"> A system generated property. A unique identifier. </param>
        /// <param name="ts"> A system generated property that denotes the last updated timestamp of the resource. </param>
        /// <param name="etag"> A system generated property representing the resource etag required for optimistic concurrency control. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        internal SqlDatabasePropertiesResource(string id, string colls, string users, string rid, float? ts, string etag) : base(id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            Colls = colls;
            Users = users;
            Rid = rid;
            Ts = ts;
            Etag = etag;
        }

        /// <summary> A system generated property that specified the addressable path of the collections resource. </summary>
        public string Colls { get; set; }
        /// <summary> A system generated property that specifies the addressable path of the users resource. </summary>
        public string Users { get; set; }
        /// <summary> A system generated property. A unique identifier. </summary>
        public string Rid { get; }
        /// <summary> A system generated property that denotes the last updated timestamp of the resource. </summary>
        public float? Ts { get; }
        /// <summary> A system generated property representing the resource etag required for optimistic concurrency control. </summary>
        public string Etag { get; }
    }
}
