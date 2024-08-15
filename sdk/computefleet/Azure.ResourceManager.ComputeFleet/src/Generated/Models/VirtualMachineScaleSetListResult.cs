// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.ComputeFleet.Models
{
    /// <summary> The response of a VirtualMachineScaleSet list operation. </summary>
    internal partial class VirtualMachineScaleSetListResult
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

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetListResult"/>. </summary>
        /// <param name="value"> The VirtualMachineScaleSet items on this page. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal VirtualMachineScaleSetListResult(IEnumerable<ComputeFleetVmssData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetListResult"/>. </summary>
        /// <param name="value"> The VirtualMachineScaleSet items on this page. </param>
        /// <param name="nextLink"> The link to the next page of items. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachineScaleSetListResult(IReadOnlyList<ComputeFleetVmssData> value, Uri nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetListResult"/> for deserialization. </summary>
        internal VirtualMachineScaleSetListResult()
        {
        }

        /// <summary> The VirtualMachineScaleSet items on this page. </summary>
        public IReadOnlyList<ComputeFleetVmssData> Value { get; }
        /// <summary> The link to the next page of items. </summary>
        public Uri NextLink { get; }
    }
}
