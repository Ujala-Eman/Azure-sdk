// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(MapsGeofenceExitedEventDataConverter))]
    public partial class MapsGeofenceExitedEventData : IUtf8JsonSerializable, IModelJsonSerializable<MapsGeofenceExitedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MapsGeofenceExitedEventData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MapsGeofenceExitedEventData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MapsGeofenceExitedEventData>(this, options.Format);

            writer.WriteStartObject();
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
            if (Optional.IsCollectionDefined(Geometries))
            {
                writer.WritePropertyName("geometries"u8);
                writer.WriteStartArray();
                foreach (var item in Geometries)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
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
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static MapsGeofenceExitedEventData DeserializeMapsGeofenceExitedEventData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<string>> expiredGeofenceGeometryId = default;
            Optional<IReadOnlyList<MapsGeofenceGeometry>> geometries = default;
            Optional<IReadOnlyList<string>> invalidPeriodGeofenceGeometryId = default;
            Optional<bool> isEventPublished = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MapsGeofenceGeometry> array = new List<MapsGeofenceGeometry>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MapsGeofenceGeometry.DeserializeMapsGeofenceGeometry(item));
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
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MapsGeofenceExitedEventData(Optional.ToList(expiredGeofenceGeometryId), Optional.ToList(geometries), Optional.ToList(invalidPeriodGeofenceGeometryId), Optional.ToNullable(isEventPublished), rawData);
        }

        MapsGeofenceExitedEventData IModelJsonSerializable<MapsGeofenceExitedEventData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MapsGeofenceExitedEventData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMapsGeofenceExitedEventData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MapsGeofenceExitedEventData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MapsGeofenceExitedEventData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MapsGeofenceExitedEventData IModelSerializable<MapsGeofenceExitedEventData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MapsGeofenceExitedEventData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMapsGeofenceExitedEventData(doc.RootElement, options);
        }

        public static implicit operator RequestContent(MapsGeofenceExitedEventData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator MapsGeofenceExitedEventData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMapsGeofenceExitedEventData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class MapsGeofenceExitedEventDataConverter : JsonConverter<MapsGeofenceExitedEventData>
        {
            public override void Write(Utf8JsonWriter writer, MapsGeofenceExitedEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override MapsGeofenceExitedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeMapsGeofenceExitedEventData(document.RootElement);
            }
        }
    }
}
