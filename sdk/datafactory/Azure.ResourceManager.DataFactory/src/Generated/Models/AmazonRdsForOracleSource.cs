// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> A copy activity AmazonRdsForOracle source. </summary>
    public partial class AmazonRdsForOracleSource : CopySource
    {
        /// <summary> Initializes a new instance of AmazonRdsForOracleSource. </summary>
        public AmazonRdsForOracleSource()
        {
            CopySourceType = "AmazonRdsForOracleSource";
        }

        /// <summary> Initializes a new instance of AmazonRdsForOracleSource. </summary>
        /// <param name="copySourceType"> Copy source type. </param>
        /// <param name="sourceRetryCount"> Source retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sourceRetryWait"> Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="disableMetricsCollection"> If true, disable data store metrics collection. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="oracleReaderQuery"> AmazonRdsForOracle reader query. Type: string (or Expression with resultType string). </param>
        /// <param name="queryTimeout"> Query timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="partitionOption"> The partition mechanism that will be used for AmazonRdsForOracle read in parallel. Type: string (or Expression with resultType string). </param>
        /// <param name="partitionSettings"> The settings that will be leveraged for AmazonRdsForOracle source partitioning. </param>
        /// <param name="additionalColumns"> Specifies the additional columns to be added to source data. Type: array of objects(AdditionalColumns) (or Expression with resultType array of objects). </param>
        internal AmazonRdsForOracleSource(string copySourceType, BinaryData sourceRetryCount, BinaryData sourceRetryWait, BinaryData maxConcurrentConnections, BinaryData disableMetricsCollection, IDictionary<string, BinaryData> additionalProperties, BinaryData oracleReaderQuery, BinaryData queryTimeout, BinaryData partitionOption, AmazonRdsForOraclePartitionSettings partitionSettings, BinaryData additionalColumns) : base(copySourceType, sourceRetryCount, sourceRetryWait, maxConcurrentConnections, disableMetricsCollection, additionalProperties)
        {
            OracleReaderQuery = oracleReaderQuery;
            QueryTimeout = queryTimeout;
            PartitionOption = partitionOption;
            PartitionSettings = partitionSettings;
            AdditionalColumns = additionalColumns;
            CopySourceType = copySourceType ?? "AmazonRdsForOracleSource";
        }

        /// <summary> AmazonRdsForOracle reader query. Type: string (or Expression with resultType string). </summary>
        public BinaryData OracleReaderQuery { get; set; }
        /// <summary> Query timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </summary>
        public BinaryData QueryTimeout { get; set; }
        /// <summary> The partition mechanism that will be used for AmazonRdsForOracle read in parallel. Type: string (or Expression with resultType string). </summary>
        public BinaryData PartitionOption { get; set; }
        /// <summary> The settings that will be leveraged for AmazonRdsForOracle source partitioning. </summary>
        public AmazonRdsForOraclePartitionSettings PartitionSettings { get; set; }
        /// <summary> Specifies the additional columns to be added to source data. Type: array of objects(AdditionalColumns) (or Expression with resultType array of objects). </summary>
        public BinaryData AdditionalColumns { get; set; }
    }
}
