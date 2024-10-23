// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HybridCompute.Models
{
    /// <summary> Describes the hardware of the machine. </summary>
    public partial class HardwareProfile
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

        /// <summary> Initializes a new instance of <see cref="HardwareProfile"/>. </summary>
        internal HardwareProfile()
        {
            Processors = new ChangeTrackingList<Processor>();
        }

        /// <summary> Initializes a new instance of <see cref="HardwareProfile"/>. </summary>
        /// <param name="totalPhysicalMemoryInBytes"> The total physical memory on the machine. </param>
        /// <param name="numberOfCpuSockets"> The total number of CPU sockets available on the machine. </param>
        /// <param name="processors"> The physical processors of the machine. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HardwareProfile(long? totalPhysicalMemoryInBytes, int? numberOfCpuSockets, IReadOnlyList<Processor> processors, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TotalPhysicalMemoryInBytes = totalPhysicalMemoryInBytes;
            NumberOfCpuSockets = numberOfCpuSockets;
            Processors = processors;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The total physical memory on the machine. </summary>
        [WirePath("totalPhysicalMemoryInBytes")]
        public long? TotalPhysicalMemoryInBytes { get; }
        /// <summary> The total number of CPU sockets available on the machine. </summary>
        [WirePath("numberOfCpuSockets")]
        public int? NumberOfCpuSockets { get; }
        /// <summary> The physical processors of the machine. </summary>
        [WirePath("processors")]
        public IReadOnlyList<Processor> Processors { get; }
    }
}
