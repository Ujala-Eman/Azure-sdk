// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Purview.Scanning.Models
{
    /// <summary> The AzureSqlDataWarehouseScanRulesetProperties. </summary>
    public partial class AzureSqlDataWarehouseScanRulesetProperties : ScanRulesetProperties
    {
        /// <summary> Initializes a new instance of AzureSqlDataWarehouseScanRulesetProperties. </summary>
        public AzureSqlDataWarehouseScanRulesetProperties()
        {
        }

        /// <summary> Initializes a new instance of AzureSqlDataWarehouseScanRulesetProperties. </summary>
        /// <param name="createdAt"></param>
        /// <param name="description"></param>
        /// <param name="excludedSystemClassifications"></param>
        /// <param name="includedCustomClassificationRuleNames"></param>
        /// <param name="lastModifiedAt"></param>
        internal AzureSqlDataWarehouseScanRulesetProperties(DateTimeOffset? createdAt, string description, IList<string> excludedSystemClassifications, IList<string> includedCustomClassificationRuleNames, DateTimeOffset? lastModifiedAt) : base(createdAt, description, excludedSystemClassifications, includedCustomClassificationRuleNames, lastModifiedAt)
        {
        }
    }
}
