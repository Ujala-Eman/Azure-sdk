// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Cosmos DB SQL trigger resource object. </summary>
    public partial class CosmosDBSqlTriggerResourceInfo
    {
        /// <summary> Initializes a new instance of CosmosDBSqlTriggerResourceInfo. </summary>
        /// <param name="id"> Name of the Cosmos DB SQL trigger. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public CosmosDBSqlTriggerResourceInfo(string id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            Id = id;
        }

        /// <summary> Initializes a new instance of CosmosDBSqlTriggerResourceInfo. </summary>
        /// <param name="id"> Name of the Cosmos DB SQL trigger. </param>
        /// <param name="body"> Body of the Trigger. </param>
        /// <param name="triggerType"> Type of the Trigger. </param>
        /// <param name="triggerOperation"> The operation the trigger is associated with. </param>
        internal CosmosDBSqlTriggerResourceInfo(string id, string body, CosmosDBSqlTriggerType? triggerType, CosmosDBSqlTriggerOperation? triggerOperation)
        {
            Id = id;
            Body = body;
            TriggerType = triggerType;
            TriggerOperation = triggerOperation;
        }

        /// <summary> Name of the Cosmos DB SQL trigger. </summary>
        public string Id { get; set; }
        /// <summary> Body of the Trigger. </summary>
        public string Body { get; set; }
        /// <summary> Type of the Trigger. </summary>
        public CosmosDBSqlTriggerType? TriggerType { get; set; }
        /// <summary> The operation the trigger is associated with. </summary>
        public CosmosDBSqlTriggerOperation? TriggerOperation { get; set; }
    }
}
