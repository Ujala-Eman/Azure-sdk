// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Trino user telemetry definition. </summary>
    public partial class TrinoTelemetryConfig
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="TrinoTelemetryConfig"/>. </summary>
        public TrinoTelemetryConfig()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TrinoTelemetryConfig"/>. </summary>
        /// <param name="hivecatalogName"> Hive Catalog name used to mount external tables on the logs written by trino, if not specified there tables are not created. </param>
        /// <param name="hivecatalogSchema"> Schema of the above catalog to use, to mount query logs as external tables, if not specified tables will be mounted under schema trinologs. </param>
        /// <param name="partitionRetentionInDays"> Retention period for query log table partitions, this doesn't have any affect on actual data. </param>
        /// <param name="path"> Azure storage location of the blobs. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal TrinoTelemetryConfig(string hivecatalogName, string hivecatalogSchema, int? partitionRetentionInDays, string path, Dictionary<string, BinaryData> rawData)
        {
            HivecatalogName = hivecatalogName;
            HivecatalogSchema = hivecatalogSchema;
            PartitionRetentionInDays = partitionRetentionInDays;
            Path = path;
            _rawData = rawData;
        }

        /// <summary> Hive Catalog name used to mount external tables on the logs written by trino, if not specified there tables are not created. </summary>
        public string HivecatalogName { get; set; }
        /// <summary> Schema of the above catalog to use, to mount query logs as external tables, if not specified tables will be mounted under schema trinologs. </summary>
        public string HivecatalogSchema { get; set; }
        /// <summary> Retention period for query log table partitions, this doesn't have any affect on actual data. </summary>
        public int? PartitionRetentionInDays { get; set; }
        /// <summary> Azure storage location of the blobs. </summary>
        public string Path { get; set; }
    }
}
