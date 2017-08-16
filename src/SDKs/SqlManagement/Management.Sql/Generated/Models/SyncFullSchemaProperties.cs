// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Sql;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Properties of the database full schema.
    /// </summary>
    public partial class SyncFullSchemaProperties
    {
        /// <summary>
        /// Initializes a new instance of the SyncFullSchemaProperties class.
        /// </summary>
        public SyncFullSchemaProperties()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SyncFullSchemaProperties class.
        /// </summary>
        /// <param name="tables">List of tables in the database full
        /// schema.</param>
        /// <param name="lastUpdateTime">Last update time of the database
        /// schema.</param>
        public SyncFullSchemaProperties(IList<SyncFullSchemaTable> tables = default(IList<SyncFullSchemaTable>), System.DateTime? lastUpdateTime = default(System.DateTime?))
        {
            Tables = tables;
            LastUpdateTime = lastUpdateTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets list of tables in the database full schema.
        /// </summary>
        [JsonProperty(PropertyName = "tables")]
        public IList<SyncFullSchemaTable> Tables { get; private set; }

        /// <summary>
        /// Gets last update time of the database schema.
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdateTime")]
        public System.DateTime? LastUpdateTime { get; private set; }

    }
}
