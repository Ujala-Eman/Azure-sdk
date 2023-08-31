// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Target resource. </summary>
    public partial class TargetResource
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="TargetResource"/>. </summary>
        internal TargetResource()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TargetResource"/>. </summary>
        /// <param name="id"> The ID of the resource. </param>
        /// <param name="resourceName"> The name of the resource. </param>
        /// <param name="resourceType"> The type of the resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal TargetResource(string id, string resourceName, ResourceType? resourceType, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            ResourceName = resourceName;
            ResourceType = resourceType;
            _rawData = rawData;
        }

        /// <summary> The ID of the resource. </summary>
        public string Id { get; }
        /// <summary> The name of the resource. </summary>
        public string ResourceName { get; }
        /// <summary> The type of the resource. </summary>
        public ResourceType? ResourceType { get; }
    }
}
