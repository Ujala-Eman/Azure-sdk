// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class StorageAccountNetworkRuleSet : IUtf8JsonSerializable, IJsonModel<StorageAccountNetworkRuleSet>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageAccountNetworkRuleSet>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StorageAccountNetworkRuleSet>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountNetworkRuleSet>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageAccountNetworkRuleSet)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Bypass))
            {
                writer.WritePropertyName("bypass"u8);
                writer.WriteStringValue(Bypass.Value.ToString());
            }
            if (Optional.IsCollectionDefined(ResourceAccessRules))
            {
                writer.WritePropertyName("resourceAccessRules"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceAccessRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VirtualNetworkRules))
            {
                writer.WritePropertyName("virtualNetworkRules"u8);
                writer.WriteStartArray();
                foreach (var item in VirtualNetworkRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(IPRules))
            {
                writer.WritePropertyName("ipRules"u8);
                writer.WriteStartArray();
                foreach (var item in IPRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("defaultAction"u8);
            writer.WriteStringValue(DefaultAction.ToSerialString());
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

        StorageAccountNetworkRuleSet IJsonModel<StorageAccountNetworkRuleSet>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountNetworkRuleSet>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageAccountNetworkRuleSet)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageAccountNetworkRuleSet(document.RootElement, options);
        }

        internal static StorageAccountNetworkRuleSet DeserializeStorageAccountNetworkRuleSet(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<StorageNetworkBypass> bypass = default;
            Optional<IList<StorageAccountResourceAccessRule>> resourceAccessRules = default;
            Optional<IList<StorageAccountVirtualNetworkRule>> virtualNetworkRules = default;
            Optional<IList<StorageAccountIPRule>> ipRules = default;
            StorageNetworkDefaultAction defaultAction = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("bypass"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bypass = new StorageNetworkBypass(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceAccessRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StorageAccountResourceAccessRule> array = new List<StorageAccountResourceAccessRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StorageAccountResourceAccessRule.DeserializeStorageAccountResourceAccessRule(item, options));
                    }
                    resourceAccessRules = array;
                    continue;
                }
                if (property.NameEquals("virtualNetworkRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StorageAccountVirtualNetworkRule> array = new List<StorageAccountVirtualNetworkRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StorageAccountVirtualNetworkRule.DeserializeStorageAccountVirtualNetworkRule(item, options));
                    }
                    virtualNetworkRules = array;
                    continue;
                }
                if (property.NameEquals("ipRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StorageAccountIPRule> array = new List<StorageAccountIPRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StorageAccountIPRule.DeserializeStorageAccountIPRule(item, options));
                    }
                    ipRules = array;
                    continue;
                }
                if (property.NameEquals("defaultAction"u8))
                {
                    defaultAction = property.Value.GetString().ToStorageNetworkDefaultAction();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StorageAccountNetworkRuleSet(Optional.ToNullable(bypass), Optional.ToList(resourceAccessRules), Optional.ToList(virtualNetworkRules), Optional.ToList(ipRules), defaultAction, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StorageAccountNetworkRuleSet>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountNetworkRuleSet>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StorageAccountNetworkRuleSet)} does not support '{options.Format}' format.");
            }
        }

        StorageAccountNetworkRuleSet IPersistableModel<StorageAccountNetworkRuleSet>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountNetworkRuleSet>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStorageAccountNetworkRuleSet(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StorageAccountNetworkRuleSet)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StorageAccountNetworkRuleSet>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
