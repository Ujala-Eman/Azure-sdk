// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Monitor.Query.Models
{
    /// <summary> The related metadata items for the category. </summary>
    internal partial class MetadataCategoryRelated
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

        /// <summary> Initializes a new instance of <see cref="MetadataCategoryRelated"/>. </summary>
        internal MetadataCategoryRelated()
        {
            Tables = new ChangeTrackingList<string>();
            Functions = new ChangeTrackingList<string>();
            ResourceTypes = new ChangeTrackingList<string>();
            Queries = new ChangeTrackingList<string>();
            Solutions = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="MetadataCategoryRelated"/>. </summary>
        /// <param name="tables"> The tables related to the category. </param>
        /// <param name="functions"> The functions related to the category. </param>
        /// <param name="resourceTypes"> The resource types related to the category. </param>
        /// <param name="queries"> The saved queries related to the category. </param>
        /// <param name="solutions"> The Log Analytics solutions related to the category. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MetadataCategoryRelated(IReadOnlyList<string> tables, IReadOnlyList<string> functions, IReadOnlyList<string> resourceTypes, IReadOnlyList<string> queries, IReadOnlyList<string> solutions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Tables = tables;
            Functions = functions;
            ResourceTypes = resourceTypes;
            Queries = queries;
            Solutions = solutions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The tables related to the category. </summary>
        public IReadOnlyList<string> Tables { get; }
        /// <summary> The functions related to the category. </summary>
        public IReadOnlyList<string> Functions { get; }
        /// <summary> The resource types related to the category. </summary>
        public IReadOnlyList<string> ResourceTypes { get; }
        /// <summary> The saved queries related to the category. </summary>
        public IReadOnlyList<string> Queries { get; }
        /// <summary> The Log Analytics solutions related to the category. </summary>
        public IReadOnlyList<string> Solutions { get; }
    }
}
