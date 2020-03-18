// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Storage.Models
{
    /// <summary> The resource model definition for a ARM tracked top level resource. </summary>
    public partial class TrackedResource : Resource
    {
        /// <summary> Initializes a new instance of TrackedResource. </summary>
        public TrackedResource()
        {
        }

        /// <summary> Initializes a new instance of TrackedResource. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <param name="id"> Fully qualified resource Id for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. </param>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="type"> The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts. </param>
        internal TrackedResource(IDictionary<string, string> tags, string location, string id, string name, string type) : base(id, name, type)
        {
            Tags = tags;
            Location = location;
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; set; }
        /// <summary> The geo-location where the resource lives. </summary>
        public string Location { get; set; }
    }
}
