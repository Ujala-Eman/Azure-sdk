// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Purview.Scanning.Models
{
    /// <summary> The AzureSqlDatabaseManagedInstanceScanRulesetProperties. </summary>
    public partial class AzureSqlDatabaseManagedInstanceScanRulesetProperties : ScanRulesetProperties
    {
        /// <summary> Initializes a new instance of AzureSqlDatabaseManagedInstanceScanRulesetProperties. </summary>
        public AzureSqlDatabaseManagedInstanceScanRulesetProperties()
        {
        }

        /// <summary> Initializes a new instance of AzureSqlDatabaseManagedInstanceScanRulesetProperties. </summary>
        /// <param name="createdAt"></param>
        /// <param name="description"></param>
        /// <param name="excludedSystemClassifications"></param>
        /// <param name="includedCustomClassificationRuleNames"></param>
        /// <param name="lastModifiedAt"></param>
        internal AzureSqlDatabaseManagedInstanceScanRulesetProperties(DateTimeOffset? createdAt, string description, IList<string> excludedSystemClassifications, IList<string> includedCustomClassificationRuleNames, DateTimeOffset? lastModifiedAt) : base(createdAt, description, excludedSystemClassifications, includedCustomClassificationRuleNames, lastModifiedAt)
        {
        }
    }
}
