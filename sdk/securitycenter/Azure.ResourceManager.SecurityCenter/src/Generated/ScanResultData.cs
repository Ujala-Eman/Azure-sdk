// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary> A class representing the ScanResult data model. </summary>
    public partial class ScanResultData : ResourceData
    {
        /// <summary> Initializes a new instance of ScanResultData. </summary>
        public ScanResultData()
        {
        }

        /// <summary> Initializes a new instance of ScanResultData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> A vulnerability assessment scan result properties for a single rule. </param>
        internal ScanResultData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ScanResultProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary> A vulnerability assessment scan result properties for a single rule. </summary>
        public ScanResultProperties Properties { get; set; }
    }
}
