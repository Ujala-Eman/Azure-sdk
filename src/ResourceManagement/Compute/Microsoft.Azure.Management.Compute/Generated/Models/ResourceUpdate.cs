// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using Azure;
    using Management;
    using Compute;
    using Rest;
    using Rest.Azure;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The Resource model definition.
    /// </summary>
    public partial class ResourceUpdate : IResource
    {
        /// <summary>
        /// Initializes a new instance of the ResourceUpdate class.
        /// </summary>
        public ResourceUpdate() { }

        /// <summary>
        /// Initializes a new instance of the ResourceUpdate class.
        /// </summary>
        /// <param name="tags">Resource tags</param>
        public ResourceUpdate(IDictionary<string, string> tags = default(IDictionary<string, string>), DiskSku sku = default(DiskSku))
        {
            Tags = tags;
            Sku = sku;
        }

        /// <summary>
        /// Gets or sets resource tags
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public DiskSku Sku { get; set; }

    }
}

