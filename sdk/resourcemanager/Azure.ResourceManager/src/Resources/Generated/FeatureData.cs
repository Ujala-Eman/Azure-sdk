// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary>
    /// A class representing the Feature data model.
    /// Previewed feature information.
    /// </summary>
    public partial class FeatureData : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="FeatureData"/>. </summary>
        internal FeatureData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FeatureData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Properties of the previewed feature. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal FeatureData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, FeatureProperties properties, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            _rawData = rawData;
        }

        /// <summary> Properties of the previewed feature. </summary>
        internal FeatureProperties Properties { get; }
        /// <summary> The registration state of the feature for the subscription. </summary>
        public string FeatureState
        {
            get => Properties?.State;
        }
    }
}
