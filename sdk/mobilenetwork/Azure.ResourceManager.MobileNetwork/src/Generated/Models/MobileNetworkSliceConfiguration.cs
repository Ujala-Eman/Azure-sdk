// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary> Per-slice settings. </summary>
    public partial class MobileNetworkSliceConfiguration
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

        /// <summary> Initializes a new instance of <see cref="MobileNetworkSliceConfiguration"/>. </summary>
        /// <param name="slice"> A reference to the slice that these settings apply to. The slice must be in the same location as the SIM policy. </param>
        /// <param name="defaultDataNetwork"> The default data network to use if the UE does not explicitly specify it. Configuration for this object must exist in the `dataNetworkConfigurations` map. The data network must be in the same location as the SIM policy. </param>
        /// <param name="dataNetworkConfigurations"> The allowed data networks and the settings to use for them. The list must not contain duplicate items and must contain at least one item. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="slice"/>, <paramref name="defaultDataNetwork"/> or <paramref name="dataNetworkConfigurations"/> is null. </exception>
        public MobileNetworkSliceConfiguration(WritableSubResource slice, WritableSubResource defaultDataNetwork, IEnumerable<DataNetworkConfiguration> dataNetworkConfigurations)
        {
            if (slice == null)
            {
                throw new ArgumentNullException(nameof(slice));
            }
            if (defaultDataNetwork == null)
            {
                throw new ArgumentNullException(nameof(defaultDataNetwork));
            }
            if (dataNetworkConfigurations == null)
            {
                throw new ArgumentNullException(nameof(dataNetworkConfigurations));
            }

            Slice = slice;
            DefaultDataNetwork = defaultDataNetwork;
            DataNetworkConfigurations = dataNetworkConfigurations.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="MobileNetworkSliceConfiguration"/>. </summary>
        /// <param name="slice"> A reference to the slice that these settings apply to. The slice must be in the same location as the SIM policy. </param>
        /// <param name="defaultDataNetwork"> The default data network to use if the UE does not explicitly specify it. Configuration for this object must exist in the `dataNetworkConfigurations` map. The data network must be in the same location as the SIM policy. </param>
        /// <param name="dataNetworkConfigurations"> The allowed data networks and the settings to use for them. The list must not contain duplicate items and must contain at least one item. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MobileNetworkSliceConfiguration(WritableSubResource slice, WritableSubResource defaultDataNetwork, IList<DataNetworkConfiguration> dataNetworkConfigurations, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Slice = slice;
            DefaultDataNetwork = defaultDataNetwork;
            DataNetworkConfigurations = dataNetworkConfigurations;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MobileNetworkSliceConfiguration"/> for deserialization. </summary>
        internal MobileNetworkSliceConfiguration()
        {
        }

        /// <summary> A reference to the slice that these settings apply to. The slice must be in the same location as the SIM policy. </summary>
        internal WritableSubResource Slice { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier SliceId
        {
            get => Slice is null ? default : Slice.Id;
            set
            {
                if (Slice is null)
                    Slice = new WritableSubResource();
                Slice.Id = value;
            }
        }

        /// <summary> The default data network to use if the UE does not explicitly specify it. Configuration for this object must exist in the `dataNetworkConfigurations` map. The data network must be in the same location as the SIM policy. </summary>
        internal WritableSubResource DefaultDataNetwork { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier DefaultDataNetworkId
        {
            get => DefaultDataNetwork is null ? default : DefaultDataNetwork.Id;
            set
            {
                if (DefaultDataNetwork is null)
                    DefaultDataNetwork = new WritableSubResource();
                DefaultDataNetwork.Id = value;
            }
        }

        /// <summary> The allowed data networks and the settings to use for them. The list must not contain duplicate items and must contain at least one item. </summary>
        public IList<DataNetworkConfiguration> DataNetworkConfigurations { get; }
    }
}
