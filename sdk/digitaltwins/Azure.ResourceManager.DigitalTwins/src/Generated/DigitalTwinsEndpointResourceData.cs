// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DigitalTwins.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DigitalTwins
{
    /// <summary>
    /// A class representing the DigitalTwinsEndpointResource data model.
    /// DigitalTwinsInstance endpoint resource.
    /// </summary>
    public partial class DigitalTwinsEndpointResourceData : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DigitalTwinsEndpointResourceData"/>. </summary>
        /// <param name="properties">
        /// DigitalTwinsInstance endpoint resource properties.
        /// Please note <see cref="DigitalTwinsEndpointResourceProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DigitalTwinsEventGridProperties"/>, <see cref="DigitalTwinsEventHubProperties"/> and <see cref="DigitalTwinsServiceBusProperties"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public DigitalTwinsEndpointResourceData(DigitalTwinsEndpointResourceProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> Initializes a new instance of <see cref="DigitalTwinsEndpointResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties">
        /// DigitalTwinsInstance endpoint resource properties.
        /// Please note <see cref="DigitalTwinsEndpointResourceProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DigitalTwinsEventGridProperties"/>, <see cref="DigitalTwinsEventHubProperties"/> and <see cref="DigitalTwinsServiceBusProperties"/>.
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DigitalTwinsEndpointResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DigitalTwinsEndpointResourceProperties properties, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="DigitalTwinsEndpointResourceData"/> for deserialization. </summary>
        internal DigitalTwinsEndpointResourceData()
        {
        }

        /// <summary>
        /// DigitalTwinsInstance endpoint resource properties.
        /// Please note <see cref="DigitalTwinsEndpointResourceProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DigitalTwinsEventGridProperties"/>, <see cref="DigitalTwinsEventHubProperties"/> and <see cref="DigitalTwinsServiceBusProperties"/>.
        /// </summary>
        public DigitalTwinsEndpointResourceProperties Properties { get; set; }
    }
}
