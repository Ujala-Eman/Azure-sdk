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

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class PartnerNamespaceChannelPatch : IUtf8JsonSerializable, IModelJsonSerializable<PartnerNamespaceChannelPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PartnerNamespaceChannelPatch>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PartnerNamespaceChannelPatch>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ExpireOnIfNotActivated))
            {
                writer.WritePropertyName("expirationTimeIfNotActivatedUtc"u8);
                writer.WriteStringValue(ExpireOnIfNotActivated.Value, "O");
            }
            if (Optional.IsDefined(PartnerDestinationInfo))
            {
                writer.WritePropertyName("partnerDestinationInfo"u8);
                writer.WriteObjectValue(PartnerDestinationInfo);
            }
            if (Optional.IsDefined(PartnerTopicInfo))
            {
                writer.WritePropertyName("partnerTopicInfo"u8);
                writer.WriteObjectValue(PartnerTopicInfo);
            }
            writer.WriteEndObject();
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

        internal static PartnerNamespaceChannelPatch DeserializePartnerNamespaceChannelPatch(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> expirationTimeIfNotActivatedUtc = default;
            Optional<PartnerUpdateDestinationInfo> partnerDestinationInfo = default;
            Optional<PartnerUpdateTopicInfo> partnerTopicInfo = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("expirationTimeIfNotActivatedUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expirationTimeIfNotActivatedUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("partnerDestinationInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            partnerDestinationInfo = PartnerUpdateDestinationInfo.DeserializePartnerUpdateDestinationInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("partnerTopicInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            partnerTopicInfo = PartnerUpdateTopicInfo.DeserializePartnerUpdateTopicInfo(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PartnerNamespaceChannelPatch(Optional.ToNullable(expirationTimeIfNotActivatedUtc), partnerDestinationInfo.Value, partnerTopicInfo.Value, rawData);
        }

        PartnerNamespaceChannelPatch IModelJsonSerializable<PartnerNamespaceChannelPatch>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePartnerNamespaceChannelPatch(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PartnerNamespaceChannelPatch>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PartnerNamespaceChannelPatch IModelSerializable<PartnerNamespaceChannelPatch>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePartnerNamespaceChannelPatch(doc.RootElement, options);
        }

        public static implicit operator RequestContent(PartnerNamespaceChannelPatch model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator PartnerNamespaceChannelPatch(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePartnerNamespaceChannelPatch(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
