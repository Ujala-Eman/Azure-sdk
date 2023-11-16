// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The cluster definition. </summary>
    public partial class HDInsightClusterDefinition
    {
        /// <summary> Initializes a new instance of HDInsightClusterDefinition. </summary>
        public HDInsightClusterDefinition()
        {
            ComponentVersion = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of HDInsightClusterDefinition. </summary>
        /// <param name="blueprint"> The link to the blueprint. </param>
        /// <param name="kind"> The type of cluster. </param>
        /// <param name="componentVersion"> The versions of different services in the cluster. </param>
        /// <param name="configurations"> The cluster configurations. </param>
        internal HDInsightClusterDefinition(string blueprint, string kind, IDictionary<string, string> componentVersion, BinaryData configurations)
        {
            Blueprint = blueprint;
            Kind = kind;
            ComponentVersion = componentVersion;
            Configurations = configurations;
        }

        /// <summary> The link to the blueprint. </summary>
        public string Blueprint { get; set; }
        /// <summary> The type of cluster. </summary>
        public string Kind { get; set; }
        /// <summary> The versions of different services in the cluster. </summary>
        public IDictionary<string, string> ComponentVersion { get; }
        /// <summary>
        /// The cluster configurations.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public BinaryData Configurations { get; set; }
    }
}
