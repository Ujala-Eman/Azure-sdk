// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Purview.Scanning.Models
{
    /// <summary> The AzureSqlDatabaseManagedInstanceScanRuleset. </summary>
    public partial class AzureSqlDatabaseManagedInstanceScanRuleset : ScanRuleset
    {
        /// <summary> Initializes a new instance of AzureSqlDatabaseManagedInstanceScanRuleset. </summary>
        public AzureSqlDatabaseManagedInstanceScanRuleset()
        {
            Kind = DataSourceType.AzureSqlDatabaseManagedInstance;
        }

        /// <summary> Initializes a new instance of AzureSqlDatabaseManagedInstanceScanRuleset. </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="scanRulesetType"></param>
        /// <param name="status"></param>
        /// <param name="version"></param>
        /// <param name="kind"></param>
        /// <param name="properties"></param>
        internal AzureSqlDatabaseManagedInstanceScanRuleset(string id, string name, ScanRulesetType? scanRulesetType, ScanRulesetStatus? status, int? version, DataSourceType kind, AzureSqlDatabaseManagedInstanceScanRulesetPropertiesAutoGenerated properties) : base(id, name, scanRulesetType, status, version, kind)
        {
            Properties = properties;
            Kind = kind;
        }

        /// <summary> Gets or sets the properties. </summary>
        public AzureSqlDatabaseManagedInstanceScanRulesetPropertiesAutoGenerated Properties { get; set; }
    }
}
