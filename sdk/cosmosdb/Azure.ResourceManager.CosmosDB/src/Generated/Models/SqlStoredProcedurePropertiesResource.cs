// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The SqlStoredProcedurePropertiesResource. </summary>
    public partial class SqlStoredProcedurePropertiesResource : SqlStoredProcedureResource
    {
        /// <summary> Initializes a new instance of <see cref="SqlStoredProcedurePropertiesResource"/>. </summary>
        /// <param name="id"> Name of the Cosmos DB SQL storedProcedure. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public SqlStoredProcedurePropertiesResource(string id) : base(id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
        }

        /// <summary> Initializes a new instance of <see cref="SqlStoredProcedurePropertiesResource"/>. </summary>
        /// <param name="id"> Name of the Cosmos DB SQL storedProcedure. </param>
        /// <param name="body"> Body of the Stored Procedure. </param>
        /// <param name="rid"> A system generated property. A unique identifier. </param>
        /// <param name="ts"> A system generated property that denotes the last updated timestamp of the resource. </param>
        /// <param name="etag"> A system generated property representing the resource etag required for optimistic concurrency control. </param>
        internal SqlStoredProcedurePropertiesResource(string id, string body, string rid, float? ts, string etag) : base(id, body)
        {
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
