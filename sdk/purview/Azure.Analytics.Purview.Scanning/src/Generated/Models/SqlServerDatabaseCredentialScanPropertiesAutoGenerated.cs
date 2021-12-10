// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Purview.Scanning.Models
{
    /// <summary> The SqlServerDatabaseCredentialScanPropertiesAutoGenerated. </summary>
    public partial class SqlServerDatabaseCredentialScanPropertiesAutoGenerated : SqlServerDatabaseCredentialScanProperties
    {
        /// <summary> Initializes a new instance of SqlServerDatabaseCredentialScanPropertiesAutoGenerated. </summary>
        public SqlServerDatabaseCredentialScanPropertiesAutoGenerated()
        {
        }

        /// <summary> Initializes a new instance of SqlServerDatabaseCredentialScanPropertiesAutoGenerated. </summary>
        /// <param name="scanRulesetName"></param>
        /// <param name="scanRulesetType"></param>
        /// <param name="collection"></param>
        /// <param name="workers"></param>
        /// <param name="createdAt"></param>
        /// <param name="lastModifiedAt"></param>
        /// <param name="connectedVia"></param>
        /// <param name="serverEndpoint"></param>
        /// <param name="databaseName"></param>
        /// <param name="credential"></param>
        internal SqlServerDatabaseCredentialScanPropertiesAutoGenerated(string scanRulesetName, ScanRulesetType? scanRulesetType, ScanPropertiesCollection collection, int? workers, DateTimeOffset? createdAt, DateTimeOffset? lastModifiedAt, ScanPropertiesConnectedVia connectedVia, string serverEndpoint, string databaseName, AzureSqlCredentialScanPropertiesCredential credential) : base(scanRulesetName, scanRulesetType, collection, workers, createdAt, lastModifiedAt, connectedVia, serverEndpoint, databaseName, credential)
        {
        }
    }
}
