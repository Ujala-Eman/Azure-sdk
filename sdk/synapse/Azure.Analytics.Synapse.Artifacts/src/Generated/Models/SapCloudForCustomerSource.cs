// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A copy activity source for SAP Cloud for Customer source. </summary>
    public partial class SapCloudForCustomerSource : TabularSource
    {
        /// <summary> Initializes a new instance of SapCloudForCustomerSource. </summary>
        public SapCloudForCustomerSource()
        {
            Type = "SapCloudForCustomerSource";
        }

        /// <summary> Initializes a new instance of SapCloudForCustomerSource. </summary>
        /// <param name="type"> Copy source type. </param>
        /// <param name="sourceRetryCount"> Source retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sourceRetryWait"> Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="additionalProperties"> . </param>
        /// <param name="queryTimeout"> Query timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="query"> SAP Cloud for Customer OData query. For example, &quot;$top=1&quot;. Type: string (or Expression with resultType string). </param>
        internal SapCloudForCustomerSource(string type, object sourceRetryCount, object sourceRetryWait, object maxConcurrentConnections, IDictionary<string, object> additionalProperties, object queryTimeout, object query) : base(type, sourceRetryCount, sourceRetryWait, maxConcurrentConnections, additionalProperties, queryTimeout)
        {
            Query = query;
            Type = type ?? "SapCloudForCustomerSource";
        }

        /// <summary> SAP Cloud for Customer OData query. For example, &quot;$top=1&quot;. Type: string (or Expression with resultType string). </summary>
        public object Query { get; set; }
    }
}
