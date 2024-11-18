// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class MapsGeofenceEventProperties : IUtf8JsonSerializable, IJsonModel<MapsGeofenceEventProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MapsGeofenceEventProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MapsGeofenceEventProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MapsGeofenceEventProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MapsGeofenceEventProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(ExpiredGeofenceGeometryId))
            {
                writer.WritePropertyName("expiredGeofenceGeometryId"u8);
                writer.WriteStartArray();
                foreach (var item in ExpiredGeofenceGeometryId)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("geometries"u8);
            writer.WriteStartArray();
            foreach (var item in Geometries)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(InvalidPeriodGeofenceGeometryId))
            {
                writer.WritePropertyName("invalidPeriodGeofenceGeometryId"u8);
                writer.WriteStartArray();
                foreach (var item in InvalidPeriodGeofenceGeometryId)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsEventPublished))
            {
                writer.WritePropertyName("isEventPublished"u8);
                writer.WriteBooleanValue(IsEventPublished.Value);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        MapsGeofenceEventProperties IJsonModel<MapsGeofenceEventProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MapsGeofenceEventProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MapsGeofenceEventProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMapsGeofenceEventProperties(document.RootElement, options);
        }

        internal static MapsGeofenceEventProperties DeserializeMapsGeofenceEventProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<string> expiredGeofenceGeometryId = default;
            IReadOnlyList<MapsGeofenceGeometry> geometries = default;
            IReadOnlyList<string> invalidPeriodGeofenceGeometryId = default;
            bool? isEventPublished = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("expiredGeofenceGeometryId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    expiredGeofenceGeometryId = array;
                    continue;
                }
                if (property.NameEquals("geometries"u8))
                {
                    List<MapsGeofenceGeometry> array = new List<MapsGeofenceGeometry>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MapsGeofenceGeometry.DeserializeMapsGeofenceGeometry(item, options));
                    }
                    geometries = array;
                    continue;
                }
                if (property.NameEquals("invalidPeriodGeofenceGeometryId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    invalidPeriodGeofenceGeometryId = array;
                    continue;
                }
                if (property.NameEquals("isEventPublished"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isEventPublished = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MapsGeofenceEventProperties(expiredGeofenceGeometryId ?? new ChangeTrackingList<string>(), geometries, invalidPeriodGeofenceGeometryId ?? new ChangeTrackingList<string>(), isEventPublished, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MapsGeofenceEventProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MapsGeofenceEventProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MapsGeofenceEventProperties)} does not support writing '{options.Format}' format.");
            }
        }

        MapsGeofenceEventProperties IPersistableModel<MapsGeofenceEventProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MapsGeofenceEventProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMapsGeofenceEventProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MapsGeofenceEventProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MapsGeofenceEventProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static MapsGeofenceEventProperties FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeMapsGeofenceEventProperties(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
