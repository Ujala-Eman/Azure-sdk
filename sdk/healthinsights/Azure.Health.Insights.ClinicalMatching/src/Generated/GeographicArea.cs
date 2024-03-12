// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Health.Insights.ClinicalMatching
{
    /// <summary> A geographic area, expressed as a `Circle` geometry represented using a `GeoJSON Feature` (see [GeoJSON spec](https://tools.ietf.org/html/rfc7946)). </summary>
    public partial class GeographicArea
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

        /// <summary> Initializes a new instance of <see cref="GeographicArea"/>. </summary>
        /// <param name="type"> `GeoJSON` type. </param>
        /// <param name="geometry"> `GeoJSON` geometry, representing the area circle's center. </param>
        /// <param name="properties"> `GeoJSON` object properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="geometry"/> or <paramref name="properties"/> is null. </exception>
        public GeographicArea(GeoJsonType type, AreaGeometry geometry, AreaProperties properties)
        {
            Argument.AssertNotNull(geometry, nameof(geometry));
            Argument.AssertNotNull(properties, nameof(properties));

            Type = type;
            Geometry = geometry;
            Properties = properties;
        }

        /// <summary> Initializes a new instance of <see cref="GeographicArea"/>. </summary>
        /// <param name="type"> `GeoJSON` type. </param>
        /// <param name="geometry"> `GeoJSON` geometry, representing the area circle's center. </param>
        /// <param name="properties"> `GeoJSON` object properties. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GeographicArea(GeoJsonType type, AreaGeometry geometry, AreaProperties properties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Type = type;
            Geometry = geometry;
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="GeographicArea"/> for deserialization. </summary>
        internal GeographicArea()
        {
        }

        /// <summary> `GeoJSON` type. </summary>
        public GeoJsonType Type { get; }
        /// <summary> `GeoJSON` geometry, representing the area circle's center. </summary>
        public AreaGeometry Geometry { get; }
        /// <summary> `GeoJSON` object properties. </summary>
        public AreaProperties Properties { get; }
    }
}
