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

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    public partial class ApplicationInsightsComponentQuotaStatus : IUtf8JsonSerializable, IModelJsonSerializable<ApplicationInsightsComponentQuotaStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ApplicationInsightsComponentQuotaStatus>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ApplicationInsightsComponentQuotaStatus>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
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

        internal static ApplicationInsightsComponentQuotaStatus DeserializeApplicationInsightsComponentQuotaStatus(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> appId = default;
            Optional<bool> shouldBeThrottled = default;
            Optional<string> expirationTime = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("AppId"u8))
                {
                    appId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ShouldBeThrottled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    shouldBeThrottled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("ExpirationTime"u8))
                {
                    expirationTime = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ApplicationInsightsComponentQuotaStatus(appId.Value, Optional.ToNullable(shouldBeThrottled), expirationTime.Value, rawData);
        }

        ApplicationInsightsComponentQuotaStatus IModelJsonSerializable<ApplicationInsightsComponentQuotaStatus>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationInsightsComponentQuotaStatus(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ApplicationInsightsComponentQuotaStatus>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ApplicationInsightsComponentQuotaStatus IModelSerializable<ApplicationInsightsComponentQuotaStatus>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeApplicationInsightsComponentQuotaStatus(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ApplicationInsightsComponentQuotaStatus model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ApplicationInsightsComponentQuotaStatus(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeApplicationInsightsComponentQuotaStatus(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
