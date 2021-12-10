// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Purview.Scanning.Models
{
    /// <summary> The AmazonAccountCredentialScanProperties. </summary>
    public partial class AmazonAccountCredentialScanProperties : ExpandingResourceScanProperties
    {
        /// <summary> Initializes a new instance of AmazonAccountCredentialScanProperties. </summary>
        public AmazonAccountCredentialScanProperties()
        {
        }

        /// <summary> Initializes a new instance of AmazonAccountCredentialScanProperties. </summary>
        /// <param name="scanRulesetName"></param>
        /// <param name="scanRulesetType"></param>
        /// <param name="collection"></param>
        /// <param name="workers"></param>
        /// <param name="createdAt"></param>
        /// <param name="lastModifiedAt"></param>
        /// <param name="connectedVia"></param>
        /// <param name="resourceTypes"></param>
        /// <param name="credential"></param>
        internal AmazonAccountCredentialScanProperties(string scanRulesetName, ScanRulesetType? scanRulesetType, ScanPropertiesCollection collection, int? workers, DateTimeOffset? createdAt, DateTimeOffset? lastModifiedAt, ScanPropertiesConnectedVia connectedVia, ExpandingResourceScanPropertiesResourceTypes resourceTypes, ExpandingResourceScanPropertiesCredential credential) : base(scanRulesetName, scanRulesetType, collection, workers, createdAt, lastModifiedAt, connectedVia, resourceTypes, credential)
        {
        }
    }
}
