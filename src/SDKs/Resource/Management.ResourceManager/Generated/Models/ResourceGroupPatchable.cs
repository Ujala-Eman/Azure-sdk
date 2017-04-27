// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using System.Linq;

    /// <summary>
    /// Resource group information.
    /// </summary>
    public partial class ResourceGroupPatchable
    {
        /// <summary>
        /// Initializes a new instance of the ResourceGroupPatchable class.
        /// </summary>
        public ResourceGroupPatchable() { }

        /// <summary>
        /// Initializes a new instance of the ResourceGroupPatchable class.
        /// </summary>
        /// <param name="name">The name of the resource group.</param>
        /// <param name="managedBy">The ID of the resource that manages this
        /// resource group.</param>
        /// <param name="tags">The tags attached to the resource group.</param>
        public ResourceGroupPatchable(string name = default(string), ResourceGroupProperties properties = default(ResourceGroupProperties), string managedBy = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>))
        {
            Name = name;
            Properties = properties;
            ManagedBy = managedBy;
            Tags = tags;
        }

        /// <summary>
        /// Gets or sets the name of the resource group.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties")]
        public ResourceGroupProperties Properties { get; set; }

        /// <summary>
        /// Gets or sets the ID of the resource that manages this resource
        /// group.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "managedBy")]
        public string ManagedBy { get; set; }

        /// <summary>
        /// Gets or sets the tags attached to the resource group.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tags")]
        public System.Collections.Generic.IDictionary<string, string> Tags { get; set; }

    }
}
