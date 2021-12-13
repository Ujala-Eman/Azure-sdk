// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Purview.Scanning.Models
{
    /// <summary> The SapS4HanaSapS4HanaCredentialScanProperties. </summary>
    public partial class SapS4HanaSapS4HanaCredentialScanProperties : MitiScanProperties
    {
        /// <summary> Initializes a new instance of SapS4HanaSapS4HanaCredentialScanProperties. </summary>
        public SapS4HanaSapS4HanaCredentialScanProperties()
        {
        }

        /// <summary> Initializes a new instance of SapS4HanaSapS4HanaCredentialScanProperties. </summary>
        /// <param name="scanRulesetName"></param>
        /// <param name="scanRulesetType"></param>
        /// <param name="collection"></param>
        /// <param name="workers"></param>
        /// <param name="createdAt"></param>
        /// <param name="lastModifiedAt"></param>
        /// <param name="connectedVia"></param>
        /// <param name="maximumMemoryAllowedInGb"></param>
        /// <param name="mitiCache"></param>
        /// <param name="clientId"></param>
        /// <param name="credential"></param>
        /// <param name="jCoLibraryPath"></param>
        internal SapS4HanaSapS4HanaCredentialScanProperties(string scanRulesetName, ScanRulesetType? scanRulesetType, ScanPropertiesCollection collection, int? workers, DateTimeOffset? createdAt, DateTimeOffset? lastModifiedAt, ScanPropertiesConnectedVia connectedVia, string maximumMemoryAllowedInGb, string mitiCache, string clientId, SapS4HanaSapS4HanaCredentialScanPropertiesCredential credential, string jCoLibraryPath) : base(scanRulesetName, scanRulesetType, collection, workers, createdAt, lastModifiedAt, connectedVia, maximumMemoryAllowedInGb, mitiCache)
        {
            ClientId = clientId;
            Credential = credential;
            JCoLibraryPath = jCoLibraryPath;
        }

        /// <summary> Gets or sets the client id. </summary>
        public string ClientId { get; set; }
        /// <summary> Gets or sets the credential. </summary>
        public SapS4HanaSapS4HanaCredentialScanPropertiesCredential Credential { get; set; }
        /// <summary> Gets or sets the j co library path. </summary>
        public string JCoLibraryPath { get; set; }
    }
}
