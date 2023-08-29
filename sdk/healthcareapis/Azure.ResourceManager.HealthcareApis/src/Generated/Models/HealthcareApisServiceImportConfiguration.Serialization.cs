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

namespace Azure.ResourceManager.HealthcareApis.Models
{
    public partial class HealthcareApisServiceImportConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<HealthcareApisServiceImportConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HealthcareApisServiceImportConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HealthcareApisServiceImportConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(IntegrationDataStore))
            {
                writer.WritePropertyName("integrationDataStore"u8);
                writer.WriteStringValue(IntegrationDataStore);
            }
            if (Optional.IsDefined(IsInitialImportMode))
            {
                writer.WritePropertyName("initialImportMode"u8);
                writer.WriteBooleanValue(IsInitialImportMode.Value);
            }
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
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

        internal static HealthcareApisServiceImportConfiguration DeserializeHealthcareApisServiceImportConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> integrationDataStore = default;
            Optional<bool> initialImportMode = default;
            Optional<bool> enabled = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("integrationDataStore"u8))
                {
                    integrationDataStore = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("initialImportMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    initialImportMode = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new HealthcareApisServiceImportConfiguration(integrationDataStore.Value, Optional.ToNullable(initialImportMode), Optional.ToNullable(enabled), rawData);
        }

        HealthcareApisServiceImportConfiguration IModelJsonSerializable<HealthcareApisServiceImportConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHealthcareApisServiceImportConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HealthcareApisServiceImportConfiguration>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HealthcareApisServiceImportConfiguration IModelSerializable<HealthcareApisServiceImportConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHealthcareApisServiceImportConfiguration(doc.RootElement, options);
        }

        public static implicit operator RequestContent(HealthcareApisServiceImportConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator HealthcareApisServiceImportConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHealthcareApisServiceImportConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
