// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Purview.Scanning.Models
{
    /// <summary> The AmazonS3ScanRulesetPropertiesAutoGenerated. </summary>
    public partial class AmazonS3ScanRulesetPropertiesAutoGenerated : AmazonS3ScanRulesetProperties
    {
        /// <summary> Initializes a new instance of AmazonS3ScanRulesetPropertiesAutoGenerated. </summary>
        public AmazonS3ScanRulesetPropertiesAutoGenerated()
        {
        }

        /// <summary> Initializes a new instance of AmazonS3ScanRulesetPropertiesAutoGenerated. </summary>
        /// <param name="createdAt"></param>
        /// <param name="description"></param>
        /// <param name="excludedSystemClassifications"></param>
        /// <param name="includedCustomClassificationRuleNames"></param>
        /// <param name="lastModifiedAt"></param>
        /// <param name="scanningRule"></param>
        internal AmazonS3ScanRulesetPropertiesAutoGenerated(DateTimeOffset? createdAt, string description, IList<string> excludedSystemClassifications, IList<string> includedCustomClassificationRuleNames, DateTimeOffset? lastModifiedAt, ScanningRuleScanRulesetPropertiesScanningRule scanningRule) : base(createdAt, description, excludedSystemClassifications, includedCustomClassificationRuleNames, lastModifiedAt, scanningRule)
        {
        }
    }
}
