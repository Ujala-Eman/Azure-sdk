// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Purview.Scanning.Models
{
    /// <summary> The OracleOracleUserPassScanProperties. </summary>
    public partial class OracleOracleUserPassScanProperties : OracleUserPassScanProperties
    {
        /// <summary> Initializes a new instance of OracleOracleUserPassScanProperties. </summary>
        public OracleOracleUserPassScanProperties()
        {
        }

        /// <summary> Initializes a new instance of OracleOracleUserPassScanProperties. </summary>
        /// <param name="scanRulesetName"></param>
        /// <param name="scanRulesetType"></param>
        /// <param name="collection"></param>
        /// <param name="workers"></param>
        /// <param name="createdAt"></param>
        /// <param name="lastModifiedAt"></param>
        /// <param name="connectedVia"></param>
        /// <param name="maximumMemoryAllowedInGb"></param>
        /// <param name="mitiCache"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="schema"></param>
        /// <param name="driverLocation"></param>
        internal OracleOracleUserPassScanProperties(string scanRulesetName, ScanRulesetType? scanRulesetType, ScanPropertiesCollection collection, int? workers, DateTimeOffset? createdAt, DateTimeOffset? lastModifiedAt, ScanPropertiesConnectedVia connectedVia, string maximumMemoryAllowedInGb, string mitiCache, string username, string password, string schema, string driverLocation) : base(scanRulesetName, scanRulesetType, collection, workers, createdAt, lastModifiedAt, connectedVia, maximumMemoryAllowedInGb, mitiCache, username, password, schema, driverLocation)
        {
        }
    }
}
