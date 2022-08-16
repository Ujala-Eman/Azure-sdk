// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.TrafficManager.Models
{
    /// <summary> Class representing a Traffic Manager HeatMap query experience properties. </summary>
    public partial class QueryExperience
    {
        /// <summary> Initializes a new instance of QueryExperience. </summary>
        /// <param name="endpointId"> The id of the endpoint from the &apos;endpoints&apos; array which these queries were routed to. </param>
        /// <param name="queryCount"> The number of queries originating from this location. </param>
        public QueryExperience(int endpointId, int queryCount)
        {
            EndpointId = endpointId;
            QueryCount = queryCount;
        }

        /// <summary> Initializes a new instance of QueryExperience. </summary>
        /// <param name="endpointId"> The id of the endpoint from the &apos;endpoints&apos; array which these queries were routed to. </param>
        /// <param name="queryCount"> The number of queries originating from this location. </param>
        /// <param name="latency"> The latency experienced by queries originating from this location. </param>
        internal QueryExperience(int endpointId, int queryCount, double? latency)
        {
            EndpointId = endpointId;
            QueryCount = queryCount;
            Latency = latency;
        }

        /// <summary> The id of the endpoint from the &apos;endpoints&apos; array which these queries were routed to. </summary>
        public int EndpointId { get; set; }
        /// <summary> The number of queries originating from this location. </summary>
        public int QueryCount { get; set; }
        /// <summary> The latency experienced by queries originating from this location. </summary>
        public double? Latency { get; set; }
    }
}
