// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> Defines a list of preconfigured endpoints. </summary>
    internal partial class PreconfiguredEndpointList
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PreconfiguredEndpointList"/>. </summary>
        internal PreconfiguredEndpointList()
        {
            Value = new ChangeTrackingList<PreconfiguredEndpoint>();
        }

        /// <summary> Initializes a new instance of <see cref="PreconfiguredEndpointList"/>. </summary>
        /// <param name="value"> List of PreconfiguredEndpoints supported by NetworkExperiment. </param>
        /// <param name="nextLink"> URL to get the next set of PreconfiguredEndpoints if there are any. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PreconfiguredEndpointList(IReadOnlyList<PreconfiguredEndpoint> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> List of PreconfiguredEndpoints supported by NetworkExperiment. </summary>
        public IReadOnlyList<PreconfiguredEndpoint> Value { get; }
        /// <summary> URL to get the next set of PreconfiguredEndpoints if there are any. </summary>
        public string NextLink { get; }
    }
}
