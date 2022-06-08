// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The SqlDatabasePropertiesOptions. </summary>
    public partial class SqlDatabasePropertiesOptions : OptionsResource
    {
        /// <summary> Initializes a new instance of <see cref="SqlDatabasePropertiesOptions"/>. </summary>
        public SqlDatabasePropertiesOptions()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SqlDatabasePropertiesOptions"/>. </summary>
        /// <param name="throughput"> Value of the Cosmos DB resource throughput or autoscaleSettings. Use the ThroughputSetting resource when retrieving offer details. </param>
        /// <param name="autoscaleSettings"> Specifies the Autoscale settings. </param>
        internal SqlDatabasePropertiesOptions(int? throughput, AutoscaleSettings autoscaleSettings) : base(throughput, autoscaleSettings)
        {
        }
    }
}
