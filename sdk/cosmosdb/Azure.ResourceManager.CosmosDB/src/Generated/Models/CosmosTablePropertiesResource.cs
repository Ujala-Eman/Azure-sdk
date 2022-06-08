// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The CosmosTablePropertiesResource. </summary>
    public partial class CosmosTablePropertiesResource : TableResource
    {
        /// <summary> Initializes a new instance of <see cref="CosmosTablePropertiesResource"/>. </summary>
        /// <param name="id"> Name of the Cosmos DB table. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public CosmosTablePropertiesResource(string id) : base(id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
        }

        /// <summary> Initializes a new instance of <see cref="CosmosTablePropertiesResource"/>. </summary>
        /// <param name="id"> Name of the Cosmos DB table. </param>
        /// <param name="rid"> A system generated property. A unique identifier. </param>
        /// <param name="ts"> A system generated property that denotes the last updated timestamp of the resource. </param>
        /// <param name="etag"> A system generated property representing the resource etag required for optimistic concurrency control. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        internal CosmosTablePropertiesResource(string id, string rid, float? ts, string etag) : base(id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            Rid = rid;
            Ts = ts;
            Etag = etag;
        }

        /// <summary> A system generated property. A unique identifier. </summary>
        public string Rid { get; }
        /// <summary> A system generated property that denotes the last updated timestamp of the resource. </summary>
        public float? Ts { get; }
        /// <summary> A system generated property representing the resource etag required for optimistic concurrency control. </summary>
        public string Etag { get; }
    }
}
