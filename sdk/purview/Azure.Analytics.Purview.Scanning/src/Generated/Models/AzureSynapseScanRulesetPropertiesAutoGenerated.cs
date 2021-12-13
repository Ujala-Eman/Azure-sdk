// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Purview.Scanning.Models
{
    /// <summary> The AzureSynapseScanRulesetPropertiesAutoGenerated. </summary>
    public partial class AzureSynapseScanRulesetPropertiesAutoGenerated : AzureSynapseScanRulesetProperties
    {
        /// <summary> Initializes a new instance of AzureSynapseScanRulesetPropertiesAutoGenerated. </summary>
        public AzureSynapseScanRulesetPropertiesAutoGenerated()
        {
        }

        /// <summary> Initializes a new instance of AzureSynapseScanRulesetPropertiesAutoGenerated. </summary>
        /// <param name="createdAt"></param>
        /// <param name="description"></param>
        /// <param name="excludedSystemClassifications"></param>
        /// <param name="includedCustomClassificationRuleNames"></param>
        /// <param name="lastModifiedAt"></param>
        internal AzureSynapseScanRulesetPropertiesAutoGenerated(DateTimeOffset? createdAt, string description, IList<string> excludedSystemClassifications, IList<string> includedCustomClassificationRuleNames, DateTimeOffset? lastModifiedAt) : base(createdAt, description, excludedSystemClassifications, includedCustomClassificationRuleNames, lastModifiedAt)
        {
        }
    }
}
