// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ManufacturingPlatform.Models
{
    /// <summary> The properties related to Azure Machine Learning Resource. </summary>
    public partial class AmlProfile
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

        /// <summary> Initializes a new instance of <see cref="AmlProfile"/>. </summary>
        /// <param name="id"> Resource Id of Azure Machine Learning Resource. </param>
        /// <param name="customNerServiceUri"> Custom Ner Service Uri. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="customNerServiceUri"/> is null. </exception>
        public AmlProfile(string id, string customNerServiceUri)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(customNerServiceUri, nameof(customNerServiceUri));

            Id = id;
            CustomNerServiceUri = customNerServiceUri;
        }

        /// <summary> Initializes a new instance of <see cref="AmlProfile"/>. </summary>
        /// <param name="id"> Resource Id of Azure Machine Learning Resource. </param>
        /// <param name="customNerServiceUri"> Custom Ner Service Uri. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AmlProfile(string id, string customNerServiceUri, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            CustomNerServiceUri = customNerServiceUri;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AmlProfile"/> for deserialization. </summary>
        internal AmlProfile()
        {
        }

        /// <summary> Resource Id of Azure Machine Learning Resource. </summary>
        public string Id { get; set; }
        /// <summary> Custom Ner Service Uri. </summary>
        public string CustomNerServiceUri { get; set; }
    }
}
