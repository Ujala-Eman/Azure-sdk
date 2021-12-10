// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Purview.Scanning.Models
{
    /// <summary> The AdlsGen1ScanRuleset. </summary>
    public partial class AdlsGen1ScanRuleset : ScanRuleset
    {
        /// <summary> Initializes a new instance of AdlsGen1ScanRuleset. </summary>
        public AdlsGen1ScanRuleset()
        {
            Kind = DataSourceType.AdlsGen1;
        }

        /// <summary> Initializes a new instance of AdlsGen1ScanRuleset. </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="scanRulesetType"></param>
        /// <param name="status"></param>
        /// <param name="version"></param>
        /// <param name="kind"></param>
        /// <param name="properties"></param>
        internal AdlsGen1ScanRuleset(string id, string name, ScanRulesetType? scanRulesetType, ScanRulesetStatus? status, int? version, DataSourceType kind, AdlsGen1ScanRulesetPropertiesAutoGenerated properties) : base(id, name, scanRulesetType, status, version, kind)
        {
            Properties = properties;
            Kind = kind;
        }

        /// <summary> Gets or sets the properties. </summary>
        public AdlsGen1ScanRulesetPropertiesAutoGenerated Properties { get; set; }
    }
}
