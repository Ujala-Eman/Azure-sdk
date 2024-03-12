// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.CostManagement;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> The definition of a query. </summary>
    public partial class QueryDefinition
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="QueryDefinition"/>. </summary>
        /// <param name="exportType"> The type of the query. </param>
        /// <param name="timeframe"> The time frame for pulling data for the query. If custom, then a specific time period must be provided. </param>
        /// <param name="dataset"> Has definition for data in this query. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataset"/> is null. </exception>
        public QueryDefinition(ExportType exportType, TimeframeType timeframe, QueryDataset dataset)
        {
            Argument.AssertNotNull(dataset, nameof(dataset));

            ExportType = exportType;
            Timeframe = timeframe;
            Dataset = dataset;
        }

        /// <summary> Initializes a new instance of <see cref="QueryDefinition"/>. </summary>
        /// <param name="exportType"> The type of the query. </param>
        /// <param name="timeframe"> The time frame for pulling data for the query. If custom, then a specific time period must be provided. </param>
        /// <param name="timePeriod"> Has time period for pulling data for the query. </param>
        /// <param name="dataset"> Has definition for data in this query. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal QueryDefinition(ExportType exportType, TimeframeType timeframe, QueryTimePeriod timePeriod, QueryDataset dataset, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ExportType = exportType;
            Timeframe = timeframe;
            TimePeriod = timePeriod;
            Dataset = dataset;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="QueryDefinition"/> for deserialization. </summary>
        internal QueryDefinition()
        {
        }

        /// <summary> The type of the query. </summary>
        public ExportType ExportType { get; }
        /// <summary> The time frame for pulling data for the query. If custom, then a specific time period must be provided. </summary>
        public TimeframeType Timeframe { get; }
        /// <summary> Has time period for pulling data for the query. </summary>
        public QueryTimePeriod TimePeriod { get; set; }
        /// <summary> Has definition for data in this query. </summary>
        public QueryDataset Dataset { get; }
    }
}
