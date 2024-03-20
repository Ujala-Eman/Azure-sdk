// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary>
    /// Definition of which syslog data will be collected and how it will be collected.
    /// Only collected from Linux machines.
    /// </summary>
    public partial class SyslogDataSource
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

        /// <summary> Initializes a new instance of <see cref="SyslogDataSource"/>. </summary>
        public SyslogDataSource()
        {
            Streams = new ChangeTrackingList<SyslogDataSourceStream>();
            FacilityNames = new ChangeTrackingList<SyslogDataSourceFacilityName>();
            LogLevels = new ChangeTrackingList<SyslogDataSourceLogLevel>();
        }

        /// <summary> Initializes a new instance of <see cref="SyslogDataSource"/>. </summary>
        /// <param name="streams">
        /// List of streams that this data source will be sent to.
        /// A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.
        /// </param>
        /// <param name="facilityNames"> The list of facility names. </param>
        /// <param name="logLevels"> The log levels to collect. </param>
        /// <param name="name">
        /// A friendly name for the data source.
        /// This name should be unique across all data sources (regardless of type) within the data collection rule.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SyslogDataSource(IList<SyslogDataSourceStream> streams, IList<SyslogDataSourceFacilityName> facilityNames, IList<SyslogDataSourceLogLevel> logLevels, string name, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Streams = streams;
            FacilityNames = facilityNames;
            LogLevels = logLevels;
            Name = name;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// List of streams that this data source will be sent to.
        /// A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.
        /// </summary>
        public IList<SyslogDataSourceStream> Streams { get; }
        /// <summary> The list of facility names. </summary>
        public IList<SyslogDataSourceFacilityName> FacilityNames { get; }
        /// <summary> The log levels to collect. </summary>
        public IList<SyslogDataSourceLogLevel> LogLevels { get; }
        /// <summary>
        /// A friendly name for the data source.
        /// This name should be unique across all data sources (regardless of type) within the data collection rule.
        /// </summary>
        public string Name { get; set; }
    }
}
