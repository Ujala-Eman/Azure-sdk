// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Purview.Scanning.Models
{
    /// <summary> The Scan. </summary>
    public partial class Scan : ProxyResource
    {
        /// <summary> Initializes a new instance of Scan. </summary>
        public Scan()
        {
            ScanResults = new ChangeTrackingList<ScanResult>();
            Kind = new ScanAuthorizationType("Scan");
        }

        /// <summary> Initializes a new instance of Scan. </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="kind"></param>
        /// <param name="scanResults"></param>
        internal Scan(string id, string name, ScanAuthorizationType kind, IReadOnlyList<ScanResult> scanResults) : base(id, name)
        {
            Kind = kind;
            ScanResults = scanResults;
        }

        /// <summary> Gets or sets the kind. </summary>
        internal ScanAuthorizationType Kind { get; set; }
        /// <summary> Gets the scan results. </summary>
        public IReadOnlyList<ScanResult> ScanResults { get; }
    }
}
