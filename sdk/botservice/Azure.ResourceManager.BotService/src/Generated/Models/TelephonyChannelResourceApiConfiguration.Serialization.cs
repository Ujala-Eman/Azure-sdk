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

namespace Azure.ResourceManager.BotService.Models
{
    public partial class TelephonyChannelResourceApiConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<TelephonyChannelResourceApiConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TelephonyChannelResourceApiConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TelephonyChannelResourceApiConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(ProviderName))
            {
                if (ProviderName != null)
                {
                    writer.WritePropertyName("providerName"u8);
                    writer.WriteStringValue(ProviderName);
                }
                else
                {
                    writer.WriteNull("providerName");
                }
            }
            if (Optional.IsDefined(CognitiveServiceSubscriptionKey))
            {
                if (CognitiveServiceSubscriptionKey != null)
                {
                    writer.WritePropertyName("cognitiveServiceSubscriptionKey"u8);
                    writer.WriteStringValue(CognitiveServiceSubscriptionKey);
                }
                else
                {
                    writer.WriteNull("cognitiveServiceSubscriptionKey");
                }
            }
            if (Optional.IsDefined(CognitiveServiceRegion))
            {
                if (CognitiveServiceRegion != null)
                {
                    writer.WritePropertyName("cognitiveServiceRegion"u8);
                    writer.WriteStringValue(CognitiveServiceRegion);
                }
                else
                {
                    writer.WriteNull("cognitiveServiceRegion");
                }
            }
            if (Optional.IsDefined(CognitiveServiceResourceId))
            {
                if (CognitiveServiceResourceId != null)
                {
                    writer.WritePropertyName("cognitiveServiceResourceId"u8);
                    writer.WriteStringValue(CognitiveServiceResourceId);
                }
                else
                {
                    writer.WriteNull("cognitiveServiceResourceId");
                }
            }
            if (Optional.IsDefined(DefaultLocale))
            {
                if (DefaultLocale != null)
                {
                    writer.WritePropertyName("defaultLocale"u8);
                    writer.WriteStringValue(DefaultLocale);
                }
                else
                {
                    writer.WriteNull("defaultLocale");
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

        internal static TelephonyChannelResourceApiConfiguration DeserializeTelephonyChannelResourceApiConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<string> providerName = default;
            Optional<string> cognitiveServiceSubscriptionKey = default;
            Optional<string> cognitiveServiceRegion = default;
            Optional<ResourceIdentifier> cognitiveServiceResourceId = default;
            Optional<string> defaultLocale = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("providerName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        providerName = null;
                        continue;
                    }
                    providerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cognitiveServiceSubscriptionKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        cognitiveServiceSubscriptionKey = null;
                        continue;
                    }
                    cognitiveServiceSubscriptionKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cognitiveServiceRegion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        cognitiveServiceRegion = null;
                        continue;
                    }
                    cognitiveServiceRegion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cognitiveServiceResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        cognitiveServiceResourceId = null;
                        continue;
                    }
                    cognitiveServiceResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("defaultLocale"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        defaultLocale = null;
                        continue;
                    }
                    defaultLocale = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new TelephonyChannelResourceApiConfiguration(id.Value, providerName.Value, cognitiveServiceSubscriptionKey.Value, cognitiveServiceRegion.Value, cognitiveServiceResourceId.Value, defaultLocale.Value, rawData);
        }

        TelephonyChannelResourceApiConfiguration IModelJsonSerializable<TelephonyChannelResourceApiConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTelephonyChannelResourceApiConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TelephonyChannelResourceApiConfiguration>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TelephonyChannelResourceApiConfiguration IModelSerializable<TelephonyChannelResourceApiConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTelephonyChannelResourceApiConfiguration(doc.RootElement, options);
        }

        public static implicit operator RequestContent(TelephonyChannelResourceApiConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator TelephonyChannelResourceApiConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTelephonyChannelResourceApiConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
