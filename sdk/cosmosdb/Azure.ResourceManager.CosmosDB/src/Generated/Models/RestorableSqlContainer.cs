// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> An Azure Cosmos DB SQL container event. </summary>
    public partial class RestorableSqlContainer : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="RestorableSqlContainer"/>. </summary>
        internal RestorableSqlContainer()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RestorableSqlContainer"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="resource"> The resource of an Azure Cosmos DB SQL container event. </param>
        internal RestorableSqlContainer(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, RestorableSqlContainerPropertiesResource resource) : base(id, name, resourceType, systemData)
        {
            Resource = resource;
        }

        /// <summary> The resource of an Azure Cosmos DB SQL container event. </summary>
        public RestorableSqlContainerPropertiesResource Resource { get; }
    }
}
