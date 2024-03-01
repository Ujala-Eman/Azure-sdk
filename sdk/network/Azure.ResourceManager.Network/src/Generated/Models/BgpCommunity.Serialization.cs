// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    public partial class BgpCommunity : IUtf8JsonSerializable, IJsonModel<BgpCommunity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BgpCommunity>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BgpCommunity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BgpCommunity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BgpCommunity)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ServiceSupportedRegion != null)
            {
                writer.WritePropertyName("serviceSupportedRegion"u8);
                writer.WriteStringValue(ServiceSupportedRegion);
            }
            if (CommunityName != null)
            {
                writer.WritePropertyName("communityName"u8);
                writer.WriteStringValue(CommunityName);
            }
            if (CommunityValue != null)
            {
                writer.WritePropertyName("communityValue"u8);
                writer.WriteStringValue(CommunityValue);
            }
            if (!(CommunityPrefixes is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("communityPrefixes"u8);
                writer.WriteStartArray();
                foreach (var item in CommunityPrefixes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (IsAuthorizedToUse.HasValue)
            {
                writer.WritePropertyName("isAuthorizedToUse"u8);
                writer.WriteBooleanValue(IsAuthorizedToUse.Value);
            }
            if (ServiceGroup != null)
            {
                writer.WritePropertyName("serviceGroup"u8);
                writer.WriteStringValue(ServiceGroup);
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
            writer.WriteEndObject();
        }

        BgpCommunity IJsonModel<BgpCommunity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BgpCommunity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BgpCommunity)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBgpCommunity(document.RootElement, options);
        }

        internal static BgpCommunity DeserializeBgpCommunity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string serviceSupportedRegion = default;
            string communityName = default;
            string communityValue = default;
            IList<string> communityPrefixes = default;
            bool? isAuthorizedToUse = default;
            string serviceGroup = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serviceSupportedRegion"u8))
                {
                    serviceSupportedRegion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("communityName"u8))
                {
                    communityName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("communityValue"u8))
                {
                    communityValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("communityPrefixes"u8))
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
                    communityPrefixes = array;
                    continue;
                }
                if (property.NameEquals("isAuthorizedToUse"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAuthorizedToUse = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("serviceGroup"u8))
                {
                    serviceGroup = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BgpCommunity(
                serviceSupportedRegion,
                communityName,
                communityValue,
                communityPrefixes ?? new ChangeTrackingList<string>(),
                isAuthorizedToUse,
                serviceGroup,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BgpCommunity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BgpCommunity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BgpCommunity)} does not support '{options.Format}' format.");
            }
        }

        BgpCommunity IPersistableModel<BgpCommunity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BgpCommunity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBgpCommunity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BgpCommunity)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BgpCommunity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
