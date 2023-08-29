// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HealthcareApis.Models
{
    /// <summary> The description of the service. </summary>
    public partial class HealthcareApisServicePatch
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="HealthcareApisServicePatch"/>. </summary>
        public HealthcareApisServicePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="HealthcareApisServicePatch"/>. </summary>
        /// <param name="tags"> Instance tags. </param>
        /// <param name="publicNetworkAccess"> Control permission for data plane traffic coming from public networks while private endpoint is enabled. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal HealthcareApisServicePatch(IDictionary<string, string> tags, HealthcareApisPublicNetworkAccess? publicNetworkAccess, Dictionary<string, BinaryData> rawData)
        {
            Tags = tags;
            PublicNetworkAccess = publicNetworkAccess;
            _rawData = rawData;
        }

        /// <summary> Instance tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Control permission for data plane traffic coming from public networks while private endpoint is enabled. </summary>
        public HealthcareApisPublicNetworkAccess? PublicNetworkAccess { get; set; }
    }
}
