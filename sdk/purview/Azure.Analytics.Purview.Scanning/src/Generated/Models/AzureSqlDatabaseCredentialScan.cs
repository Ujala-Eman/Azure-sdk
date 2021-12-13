// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Purview.Scanning.Models
{
    /// <summary> The AzureSqlDatabaseCredentialScan. </summary>
    public partial class AzureSqlDatabaseCredentialScan : Scan
    {
        /// <summary> Initializes a new instance of AzureSqlDatabaseCredentialScan. </summary>
        public AzureSqlDatabaseCredentialScan()
        {
            Kind = ScanAuthorizationType.AzureSqlDatabaseCredential;
        }

        /// <summary> Initializes a new instance of AzureSqlDatabaseCredentialScan. </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="kind"></param>
        /// <param name="scanResults"></param>
        /// <param name="properties"></param>
        internal AzureSqlDatabaseCredentialScan(string id, string name, ScanAuthorizationType kind, IReadOnlyList<ScanResult> scanResults, AzureSqlDatabaseCredentialScanPropertiesAutoGenerated properties) : base(id, name, kind, scanResults)
        {
            Properties = properties;
            Kind = kind;
        }

        /// <summary> Gets or sets the properties. </summary>
        public AzureSqlDatabaseCredentialScanPropertiesAutoGenerated Properties { get; set; }
    }
}
