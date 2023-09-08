// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> A list of server configurations to update. </summary>
    public partial class MySqlFlexibleServerConfigurationListForBatchUpdate
    {
        /// <summary> Initializes a new instance of MySqlFlexibleServerConfigurationListForBatchUpdate. </summary>
        public MySqlFlexibleServerConfigurationListForBatchUpdate()
        {
            Values = new ChangeTrackingList<MySqlFlexibleServerConfigurationForBatchUpdate>();
        }

        /// <summary> The list of server configurations. </summary>
        public IList<MySqlFlexibleServerConfigurationForBatchUpdate> Values { get; }
        /// <summary> Whether to reset all server parameters to default. </summary>
        public MySqlFlexibleServerConfigurationResetAllToDefault? ResetAllToDefault { get; set; }
    }
}
