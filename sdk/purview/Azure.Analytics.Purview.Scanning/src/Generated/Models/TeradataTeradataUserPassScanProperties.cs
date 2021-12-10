// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Purview.Scanning.Models
{
    /// <summary> The TeradataTeradataUserPassScanProperties. </summary>
    public partial class TeradataTeradataUserPassScanProperties : MitiScanProperties
    {
        /// <summary> Initializes a new instance of TeradataTeradataUserPassScanProperties. </summary>
        public TeradataTeradataUserPassScanProperties()
        {
        }

        /// <summary> Initializes a new instance of TeradataTeradataUserPassScanProperties. </summary>
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
        internal TeradataTeradataUserPassScanProperties(string scanRulesetName, ScanRulesetType? scanRulesetType, ScanPropertiesCollection collection, int? workers, DateTimeOffset? createdAt, DateTimeOffset? lastModifiedAt, ScanPropertiesConnectedVia connectedVia, string maximumMemoryAllowedInGb, string mitiCache, string username, string password, string schema, string driverLocation) : base(scanRulesetName, scanRulesetType, collection, workers, createdAt, lastModifiedAt, connectedVia, maximumMemoryAllowedInGb, mitiCache)
        {
            Username = username;
            Password = password;
            Schema = schema;
            DriverLocation = driverLocation;
        }

        /// <summary> Gets or sets the username. </summary>
        public string Username { get; set; }
        /// <summary> Gets or sets the password. </summary>
        public string Password { get; set; }
        /// <summary> Gets or sets the schema. </summary>
        public string Schema { get; set; }
        /// <summary> Gets or sets the driver location. </summary>
        public string DriverLocation { get; set; }
    }
}
