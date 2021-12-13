// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Purview.Scanning.Models
{
    /// <summary> The AmazonPostgreSqlScanRuleset. </summary>
    public partial class AmazonPostgreSqlScanRuleset : ScanRuleset
    {
        /// <summary> Initializes a new instance of AmazonPostgreSqlScanRuleset. </summary>
        public AmazonPostgreSqlScanRuleset()
        {
            Kind = DataSourceType.AmazonPostgreSql;
        }

        /// <summary> Initializes a new instance of AmazonPostgreSqlScanRuleset. </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="scanRulesetType"></param>
        /// <param name="status"></param>
        /// <param name="version"></param>
        /// <param name="kind"></param>
        /// <param name="properties"></param>
        internal AmazonPostgreSqlScanRuleset(string id, string name, ScanRulesetType? scanRulesetType, ScanRulesetStatus? status, int? version, DataSourceType kind, AmazonPostgreSqlScanRulesetPropertiesAutoGenerated properties) : base(id, name, scanRulesetType, status, version, kind)
        {
            Properties = properties;
            Kind = kind;
        }

        /// <summary> Gets or sets the properties. </summary>
        public AmazonPostgreSqlScanRulesetPropertiesAutoGenerated Properties { get; set; }
    }
}
