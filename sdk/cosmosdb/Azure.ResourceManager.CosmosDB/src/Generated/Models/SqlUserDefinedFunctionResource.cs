// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Cosmos DB SQL userDefinedFunction resource object. </summary>
    public partial class SqlUserDefinedFunctionResource
    {
        /// <summary> Initializes a new instance of <see cref="SqlUserDefinedFunctionResource"/>. </summary>
        /// <param name="id"> Name of the Cosmos DB SQL userDefinedFunction. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public SqlUserDefinedFunctionResource(string id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            Id = id;
        }

        /// <summary> Initializes a new instance of <see cref="SqlUserDefinedFunctionResource"/>. </summary>
        /// <param name="id"> Name of the Cosmos DB SQL userDefinedFunction. </param>
        /// <param name="body"> Body of the User Defined Function. </param>
        internal SqlUserDefinedFunctionResource(string id, string body)
        {
            Id = id;
            Body = body;
        }

        /// <summary> Name of the Cosmos DB SQL userDefinedFunction. </summary>
        public string Id { get; set; }
        /// <summary> Body of the User Defined Function. </summary>
        public string Body { get; set; }
    }
}
