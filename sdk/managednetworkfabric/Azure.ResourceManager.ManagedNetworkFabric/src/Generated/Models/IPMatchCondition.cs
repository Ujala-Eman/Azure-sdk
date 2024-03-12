// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.ManagedNetworkFabric;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Defines the condition that can be filtered using the selected IPs. </summary>
    public partial class IPMatchCondition
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

        /// <summary> Initializes a new instance of <see cref="IPMatchCondition"/>. </summary>
        public IPMatchCondition()
        {
            IPPrefixValues = new ChangeTrackingList<string>();
            IPGroupNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="IPMatchCondition"/>. </summary>
        /// <param name="sourceDestinationType"> IP Address type that needs to be matched. </param>
        /// <param name="prefixType"> IP Prefix Type that needs to be matched. </param>
        /// <param name="ipPrefixValues"> The list of IP Prefixes that need to be matched. </param>
        /// <param name="ipGroupNames"> The List of IP Group Names that need to be matched. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IPMatchCondition(SourceDestinationType? sourceDestinationType, IPMatchConditionPrefixType? prefixType, IList<string> ipPrefixValues, IList<string> ipGroupNames, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SourceDestinationType = sourceDestinationType;
            PrefixType = prefixType;
            IPPrefixValues = ipPrefixValues;
            IPGroupNames = ipGroupNames;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> IP Address type that needs to be matched. </summary>
        public SourceDestinationType? SourceDestinationType { get; set; }
        /// <summary> IP Prefix Type that needs to be matched. </summary>
        public IPMatchConditionPrefixType? PrefixType { get; set; }
        /// <summary> The list of IP Prefixes that need to be matched. </summary>
        public IList<string> IPPrefixValues { get; }
        /// <summary> The List of IP Group Names that need to be matched. </summary>
        public IList<string> IPGroupNames { get; }
    }
}
