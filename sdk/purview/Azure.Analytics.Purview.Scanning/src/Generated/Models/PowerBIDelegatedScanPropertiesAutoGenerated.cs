// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Purview.Scanning.Models
{
    /// <summary> The PowerBIDelegatedScanPropertiesAutoGenerated. </summary>
    public partial class PowerBIDelegatedScanPropertiesAutoGenerated : PowerBIDelegatedScanProperties
    {
        /// <summary> Initializes a new instance of PowerBIDelegatedScanPropertiesAutoGenerated. </summary>
        public PowerBIDelegatedScanPropertiesAutoGenerated()
        {
        }

        /// <summary> Initializes a new instance of PowerBIDelegatedScanPropertiesAutoGenerated. </summary>
        /// <param name="scanRulesetName"></param>
        /// <param name="scanRulesetType"></param>
        /// <param name="collection"></param>
        /// <param name="workers"></param>
        /// <param name="createdAt"></param>
        /// <param name="lastModifiedAt"></param>
        /// <param name="connectedVia"></param>
        /// <param name="tenant"></param>
        /// <param name="authenticationType"></param>
        /// <param name="clientId"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="includePersonalWorkspaces"></param>
        internal PowerBIDelegatedScanPropertiesAutoGenerated(string scanRulesetName, ScanRulesetType? scanRulesetType, ScanPropertiesCollection collection, int? workers, DateTimeOffset? createdAt, DateTimeOffset? lastModifiedAt, ScanPropertiesConnectedVia connectedVia, string tenant, string authenticationType, string clientId, string userName, string password, bool? includePersonalWorkspaces) : base(scanRulesetName, scanRulesetType, collection, workers, createdAt, lastModifiedAt, connectedVia, tenant, authenticationType, clientId, userName, password, includePersonalWorkspaces)
        {
        }
    }
}
