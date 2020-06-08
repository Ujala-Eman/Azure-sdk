// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Linked service resource type. </summary>
    public partial class LinkedServiceResource : SubResource
    {
        /// <summary> Initializes a new instance of LinkedServiceResource. </summary>
        /// <param name="properties"> Properties of linked service. </param>
        public LinkedServiceResource(LinkedService properties)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Properties = properties;
        }

        /// <summary> Initializes a new instance of LinkedServiceResource. </summary>
        /// <param name="id"> The resource identifier. </param>
        /// <param name="name"> The resource name. </param>
        /// <param name="type"> The resource type. </param>
        /// <param name="etag"> Etag identifies change in the resource. </param>
        /// <param name="properties"> Properties of linked service. </param>
        internal LinkedServiceResource(string id, string name, string type, string etag, LinkedService properties) : base(id, name, type, etag)
        {
            Properties = properties;
        }

        /// <summary> Properties of linked service. </summary>
        public LinkedService Properties { get; set; }
    }
}
