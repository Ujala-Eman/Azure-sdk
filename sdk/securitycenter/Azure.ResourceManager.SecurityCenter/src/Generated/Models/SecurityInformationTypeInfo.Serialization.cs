// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class SecurityInformationTypeInfo : IUtf8JsonSerializable, IJsonModel<SecurityInformationTypeInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityInformationTypeInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityInformationTypeInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInformationTypeInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInformationTypeInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (DisplayName != null)
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Order.HasValue)
            {
                writer.WritePropertyName("order"u8);
                writer.WriteNumberValue(Order.Value);
            }
            if (RecommendedLabelId.HasValue)
            {
                writer.WritePropertyName("recommendedLabelId"u8);
                writer.WriteStringValue(RecommendedLabelId.Value);
            }
            if (IsEnabled.HasValue)
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Custom.HasValue)
            {
                writer.WritePropertyName("custom"u8);
                writer.WriteBooleanValue(Custom.Value);
            }
            if (!(Keywords is ChangeTrackingList<InformationProtectionKeyword> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("keywords"u8);
                writer.WriteStartArray();
                foreach (var item in Keywords)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        SecurityInformationTypeInfo IJsonModel<SecurityInformationTypeInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInformationTypeInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInformationTypeInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityInformationTypeInfo(document.RootElement, options);
        }

        internal static SecurityInformationTypeInfo DeserializeSecurityInformationTypeInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> displayName = default;
            Optional<string> description = default;
            Optional<int> order = default;
            Optional<Guid> recommendedLabelId = default;
            Optional<bool> enabled = default;
            Optional<bool> custom = default;
            Optional<IList<InformationProtectionKeyword>> keywords = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("order"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    order = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("recommendedLabelId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recommendedLabelId = property.Value.GetGuid();
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
                if (property.NameEquals("custom"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    custom = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("keywords"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<InformationProtectionKeyword> array = new List<InformationProtectionKeyword>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InformationProtectionKeyword.DeserializeInformationProtectionKeyword(item, options));
                    }
                    keywords = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SecurityInformationTypeInfo(displayName.Value, description.Value, Optional.ToNullable(order), Optional.ToNullable(recommendedLabelId), Optional.ToNullable(enabled), Optional.ToNullable(custom), Optional.ToList(keywords), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SecurityInformationTypeInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInformationTypeInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SecurityInformationTypeInfo)} does not support '{options.Format}' format.");
            }
        }

        SecurityInformationTypeInfo IPersistableModel<SecurityInformationTypeInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInformationTypeInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityInformationTypeInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityInformationTypeInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityInformationTypeInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
