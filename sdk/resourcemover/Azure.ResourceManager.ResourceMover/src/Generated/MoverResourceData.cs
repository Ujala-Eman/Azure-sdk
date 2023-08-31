// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.ResourceMover.Models;

namespace Azure.ResourceManager.ResourceMover
{
    /// <summary>
    /// A class representing the MoverResource data model.
    /// Defines the move resource.
    /// </summary>
    public partial class MoverResourceData : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MoverResourceData"/>. </summary>
        public MoverResourceData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MoverResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Defines the move resource properties. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MoverResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, MoverResourceProperties properties, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            _rawData = rawData;
        }

        /// <summary> Defines the move resource properties. </summary>
        public MoverResourceProperties Properties { get; set; }
    }
}
