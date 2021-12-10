// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Purview.Scanning.Models
{
    /// <summary> The AzureSynapseWorkspaceMsiScan. </summary>
    public partial class AzureSynapseWorkspaceMsiScan : Scan
    {
        /// <summary> Initializes a new instance of AzureSynapseWorkspaceMsiScan. </summary>
        public AzureSynapseWorkspaceMsiScan()
        {
            Kind = ScanAuthorizationType.AzureSynapseWorkspaceMsi;
        }

        /// <summary> Initializes a new instance of AzureSynapseWorkspaceMsiScan. </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="kind"></param>
        /// <param name="scanResults"></param>
        /// <param name="properties"></param>
        internal AzureSynapseWorkspaceMsiScan(string id, string name, ScanAuthorizationType kind, IReadOnlyList<ScanResult> scanResults, AzureSynapseWorkspaceMsiScanPropertiesAutoGenerated properties) : base(id, name, kind, scanResults)
        {
            Properties = properties;
            Kind = kind;
        }

        /// <summary> Gets or sets the properties. </summary>
        public AzureSynapseWorkspaceMsiScanPropertiesAutoGenerated Properties { get; set; }
    }
}
