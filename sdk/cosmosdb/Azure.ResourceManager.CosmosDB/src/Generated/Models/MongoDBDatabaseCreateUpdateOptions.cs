// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Parameters to create and update Cosmos DB MongoDB database. </summary>
    public partial class MongoDBDatabaseCreateUpdateOptions : TrackedResource
    {
        /// <summary> Initializes a new instance of MongoDBDatabaseCreateUpdateOptions. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="resource"> The standard JSON format of a MongoDB database. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resource"/> is null. </exception>
        public MongoDBDatabaseCreateUpdateOptions(AzureLocation location, MongoDBDatabaseResource resource) : base(location)
        {
            if (resource == null)
            {
                throw new ArgumentNullException(nameof(resource));
            }

            Resource = resource;
        }

        /// <summary> Initializes a new instance of MongoDBDatabaseCreateUpdateOptions. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="resource"> The standard JSON format of a MongoDB database. </param>
        /// <param name="options"> A key-value pair of options to be applied for the request. This corresponds to the headers sent with the request. </param>
        internal MongoDBDatabaseCreateUpdateOptions(ResourceIdentifier id, string name, ResourceType type, IDictionary<string, string> tags, AzureLocation location, MongoDBDatabaseResource resource, CreateUpdateOptions options) : base(id, name, type, tags, location)
        {
            Resource = resource;
            Options = options;
        }

        /// <summary> The standard JSON format of a MongoDB database. </summary>
        public MongoDBDatabaseResource Resource { get; set; }
        /// <summary> A key-value pair of options to be applied for the request. This corresponds to the headers sent with the request. </summary>
        public CreateUpdateOptions Options { get; set; }
    }
}
