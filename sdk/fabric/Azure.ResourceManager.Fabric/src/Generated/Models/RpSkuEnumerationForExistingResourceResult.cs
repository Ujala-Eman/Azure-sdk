// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Fabric.Models
{
    /// <summary> An object that represents enumerating SKUs for existing resources. </summary>
    internal partial class RpSkuEnumerationForExistingResourceResult
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

        /// <summary> Initializes a new instance of <see cref="RpSkuEnumerationForExistingResourceResult"/>. </summary>
        /// <param name="value"> The SKU details. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal RpSkuEnumerationForExistingResourceResult(IEnumerable<FabricSkuDetailsForExistingCapacity> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="RpSkuEnumerationForExistingResourceResult"/>. </summary>
        /// <param name="value"> The SKU details. </param>
        /// <param name="nextLink"> Url for the next page.  Null if no more pages available. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RpSkuEnumerationForExistingResourceResult(IReadOnlyList<FabricSkuDetailsForExistingCapacity> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RpSkuEnumerationForExistingResourceResult"/> for deserialization. </summary>
        internal RpSkuEnumerationForExistingResourceResult()
        {
        }

        /// <summary> The SKU details. </summary>
        public IReadOnlyList<FabricSkuDetailsForExistingCapacity> Value { get; }
        /// <summary> Url for the next page.  Null if no more pages available. </summary>
        public string NextLink { get; }
    }
}
