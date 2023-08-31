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
    [JsonConverter(typeof(HealthcareFhirResourceUpdatedEventDataConverter))]
    public partial class HealthcareFhirResourceUpdatedEventData : IUtf8JsonSerializable, IModelJsonSerializable<HealthcareFhirResourceUpdatedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HealthcareFhirResourceUpdatedEventData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HealthcareFhirResourceUpdatedEventData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(FhirResourceType))
            {
                writer.WritePropertyName("resourceType"u8);
                writer.WriteStringValue(FhirResourceType.Value.ToString());
            }
            if (Optional.IsDefined(FhirServiceHostName))
            {
                writer.WritePropertyName("resourceFhirAccount"u8);
                writer.WriteStringValue(FhirServiceHostName);
            }
            if (Optional.IsDefined(FhirResourceId))
            {
                writer.WritePropertyName("resourceFhirId"u8);
                writer.WriteStringValue(FhirResourceId);
            }
            if (Optional.IsDefined(FhirResourceVersionId))
            {
                writer.WritePropertyName("resourceVersionId"u8);
                writer.WriteNumberValue(FhirResourceVersionId.Value);
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

        internal static HealthcareFhirResourceUpdatedEventData DeserializeHealthcareFhirResourceUpdatedEventData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<HealthcareFhirResourceType> resourceType = default;
            Optional<string> resourceFhirAccount = default;
            Optional<string> resourceFhirId = default;
            Optional<long> resourceVersionId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceType = new HealthcareFhirResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceFhirAccount"u8))
                {
                    resourceFhirAccount = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceFhirId"u8))
                {
                    resourceFhirId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceVersionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceVersionId = property.Value.GetInt64();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new HealthcareFhirResourceUpdatedEventData(Optional.ToNullable(resourceType), resourceFhirAccount.Value, resourceFhirId.Value, Optional.ToNullable(resourceVersionId), rawData);
        }

        HealthcareFhirResourceUpdatedEventData IModelJsonSerializable<HealthcareFhirResourceUpdatedEventData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHealthcareFhirResourceUpdatedEventData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HealthcareFhirResourceUpdatedEventData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HealthcareFhirResourceUpdatedEventData IModelSerializable<HealthcareFhirResourceUpdatedEventData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHealthcareFhirResourceUpdatedEventData(doc.RootElement, options);
        }

        public static implicit operator RequestContent(HealthcareFhirResourceUpdatedEventData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator HealthcareFhirResourceUpdatedEventData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHealthcareFhirResourceUpdatedEventData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class HealthcareFhirResourceUpdatedEventDataConverter : JsonConverter<HealthcareFhirResourceUpdatedEventData>
        {
            public override void Write(Utf8JsonWriter writer, HealthcareFhirResourceUpdatedEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override HealthcareFhirResourceUpdatedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeHealthcareFhirResourceUpdatedEventData(document.RootElement);
            }
        }
    }
}
