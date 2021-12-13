// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Purview.Scanning.Models
{
    /// <summary> The SapEccCredentialScan. </summary>
    public partial class SapEccCredentialScan : Scan
    {
        /// <summary> Initializes a new instance of SapEccCredentialScan. </summary>
        public SapEccCredentialScan()
        {
            Kind = ScanAuthorizationType.SapEccSapEccCredential;
        }

        /// <summary> Initializes a new instance of SapEccCredentialScan. </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="kind"></param>
        /// <param name="scanResults"></param>
        /// <param name="properties"></param>
        internal SapEccCredentialScan(string id, string name, ScanAuthorizationType kind, IReadOnlyList<ScanResult> scanResults, SapEccSapEccCredentialScanProperties properties) : base(id, name, kind, scanResults)
        {
            Properties = properties;
            Kind = kind;
        }

        /// <summary> Gets or sets the properties. </summary>
        public SapEccSapEccCredentialScanProperties Properties { get; set; }
    }
}
