// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.ResourceHealth.Models
{
    public partial class ServiceImpactingEvent : IUtf8JsonSerializable, IModelJsonSerializable<ServiceImpactingEvent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ServiceImpactingEvent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ServiceImpactingEvent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(EventStartOn))
            {
                writer.WritePropertyName("eventStartTime"u8);
                writer.WriteStringValue(EventStartOn.Value, "O");
            }
            if (Optional.IsDefined(EventStatusLastModifiedOn))
            {
                writer.WritePropertyName("eventStatusLastModifiedTime"u8);
                writer.WriteStringValue(EventStatusLastModifiedOn.Value, "O");
            }
            if (Optional.IsDefined(CorrelationId))
            {
                writer.WritePropertyName("correlationId"u8);
                writer.WriteStringValue(CorrelationId);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                if (Status is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ServiceImpactingEventStatus>)Status).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(IncidentProperties))
            {
                writer.WritePropertyName("incidentProperties"u8);
                if (IncidentProperties is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ServiceImpactingEventIncidentProperties>)IncidentProperties).Serialize(writer, options);
                }
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

        internal static ServiceImpactingEvent DeserializeServiceImpactingEvent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> eventStartTime = default;
            Optional<DateTimeOffset> eventStatusLastModifiedTime = default;
            Optional<string> correlationId = default;
            Optional<ServiceImpactingEventStatus> status = default;
            Optional<ServiceImpactingEventIncidentProperties> incidentProperties = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eventStartTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eventStartTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("eventStatusLastModifiedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eventStatusLastModifiedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("correlationId"u8))
                {
                    correlationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = ServiceImpactingEventStatus.DeserializeServiceImpactingEventStatus(property.Value);
                    continue;
                }
                if (property.NameEquals("incidentProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    incidentProperties = ServiceImpactingEventIncidentProperties.DeserializeServiceImpactingEventIncidentProperties(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ServiceImpactingEvent(Optional.ToNullable(eventStartTime), Optional.ToNullable(eventStatusLastModifiedTime), correlationId.Value, status.Value, incidentProperties.Value, rawData);
        }

        ServiceImpactingEvent IModelJsonSerializable<ServiceImpactingEvent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceImpactingEvent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ServiceImpactingEvent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ServiceImpactingEvent IModelSerializable<ServiceImpactingEvent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeServiceImpactingEvent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ServiceImpactingEvent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ServiceImpactingEvent"/> to convert. </param>
        public static implicit operator RequestContent(ServiceImpactingEvent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ServiceImpactingEvent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ServiceImpactingEvent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeServiceImpactingEvent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
