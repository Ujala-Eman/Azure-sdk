// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataLakeStore.Models
{
    /// <summary> The parameters used to create a new trusted identity provider. </summary>
    public partial class DataLakeStoreTrustedIdProviderCreateOrUpdateContent
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

        /// <summary> Initializes a new instance of <see cref="DataLakeStoreTrustedIdProviderCreateOrUpdateContent"/>. </summary>
        /// <param name="idProvider"> The URL of this trusted identity provider. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="idProvider"/> is null. </exception>
        public DataLakeStoreTrustedIdProviderCreateOrUpdateContent(Uri idProvider)
        {
            if (idProvider == null)
            {
                throw new ArgumentNullException(nameof(idProvider));
            }

            IdProvider = idProvider;
        }

        /// <summary> Initializes a new instance of <see cref="DataLakeStoreTrustedIdProviderCreateOrUpdateContent"/>. </summary>
        /// <param name="idProvider"> The URL of this trusted identity provider. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataLakeStoreTrustedIdProviderCreateOrUpdateContent(Uri idProvider, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IdProvider = idProvider;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataLakeStoreTrustedIdProviderCreateOrUpdateContent"/> for deserialization. </summary>
        internal DataLakeStoreTrustedIdProviderCreateOrUpdateContent()
        {
        }

        /// <summary> The URL of this trusted identity provider. </summary>
        public Uri IdProvider { get; }
    }
}
