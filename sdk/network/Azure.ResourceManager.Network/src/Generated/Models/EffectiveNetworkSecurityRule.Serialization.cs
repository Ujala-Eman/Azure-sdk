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
    public partial class EffectiveNetworkSecurityRule : IUtf8JsonSerializable, IJsonModel<EffectiveNetworkSecurityRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EffectiveNetworkSecurityRule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EffectiveNetworkSecurityRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EffectiveNetworkSecurityRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EffectiveNetworkSecurityRule)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Protocol.HasValue)
            {
                writer.WritePropertyName("protocol"u8);
                writer.WriteStringValue(Protocol.Value.ToString());
            }
            if (SourcePortRange != null)
            {
                writer.WritePropertyName("sourcePortRange"u8);
                writer.WriteStringValue(SourcePortRange);
            }
            if (DestinationPortRange != null)
            {
                writer.WritePropertyName("destinationPortRange"u8);
                writer.WriteStringValue(DestinationPortRange);
            }
            if (!(SourcePortRanges is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("sourcePortRanges"u8);
                writer.WriteStartArray();
                foreach (var item in SourcePortRanges)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(DestinationPortRanges is ChangeTrackingList<string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("destinationPortRanges"u8);
                writer.WriteStartArray();
                foreach (var item in DestinationPortRanges)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (SourceAddressPrefix != null)
            {
                writer.WritePropertyName("sourceAddressPrefix"u8);
                writer.WriteStringValue(SourceAddressPrefix);
            }
            if (DestinationAddressPrefix != null)
            {
                writer.WritePropertyName("destinationAddressPrefix"u8);
                writer.WriteStringValue(DestinationAddressPrefix);
            }
            if (!(SourceAddressPrefixes is ChangeTrackingList<string> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("sourceAddressPrefixes"u8);
                writer.WriteStartArray();
                foreach (var item in SourceAddressPrefixes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(DestinationAddressPrefixes is ChangeTrackingList<string> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("destinationAddressPrefixes"u8);
                writer.WriteStartArray();
                foreach (var item in DestinationAddressPrefixes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(ExpandedSourceAddressPrefix is ChangeTrackingList<string> collection3 && collection3.IsUndefined))
            {
                writer.WritePropertyName("expandedSourceAddressPrefix"u8);
                writer.WriteStartArray();
                foreach (var item in ExpandedSourceAddressPrefix)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(ExpandedDestinationAddressPrefix is ChangeTrackingList<string> collection4 && collection4.IsUndefined))
            {
                writer.WritePropertyName("expandedDestinationAddressPrefix"u8);
                writer.WriteStartArray();
                foreach (var item in ExpandedDestinationAddressPrefix)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Access.HasValue)
            {
                writer.WritePropertyName("access"u8);
                writer.WriteStringValue(Access.Value.ToString());
            }
            if (Priority.HasValue)
            {
                writer.WritePropertyName("priority"u8);
                writer.WriteNumberValue(Priority.Value);
            }
            if (Direction.HasValue)
            {
                writer.WritePropertyName("direction"u8);
                writer.WriteStringValue(Direction.Value.ToString());
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

        EffectiveNetworkSecurityRule IJsonModel<EffectiveNetworkSecurityRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EffectiveNetworkSecurityRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EffectiveNetworkSecurityRule)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEffectiveNetworkSecurityRule(document.RootElement, options);
        }

        internal static EffectiveNetworkSecurityRule DeserializeEffectiveNetworkSecurityRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            EffectiveSecurityRuleProtocol? protocol = default;
            string sourcePortRange = default;
            string destinationPortRange = default;
            IReadOnlyList<string> sourcePortRanges = default;
            IReadOnlyList<string> destinationPortRanges = default;
            string sourceAddressPrefix = default;
            string destinationAddressPrefix = default;
            IReadOnlyList<string> sourceAddressPrefixes = default;
            IReadOnlyList<string> destinationAddressPrefixes = default;
            IReadOnlyList<string> expandedSourceAddressPrefix = default;
            IReadOnlyList<string> expandedDestinationAddressPrefix = default;
            SecurityRuleAccess? access = default;
            int? priority = default;
            SecurityRuleDirection? direction = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protocol"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protocol = new EffectiveSecurityRuleProtocol(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourcePortRange"u8))
                {
                    sourcePortRange = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("destinationPortRange"u8))
                {
                    destinationPortRange = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourcePortRanges"u8))
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
                    sourcePortRanges = array;
                    continue;
                }
                if (property.NameEquals("destinationPortRanges"u8))
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
                    destinationPortRanges = array;
                    continue;
                }
                if (property.NameEquals("sourceAddressPrefix"u8))
                {
                    sourceAddressPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("destinationAddressPrefix"u8))
                {
                    destinationAddressPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceAddressPrefixes"u8))
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
                    sourceAddressPrefixes = array;
                    continue;
                }
                if (property.NameEquals("destinationAddressPrefixes"u8))
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
                    destinationAddressPrefixes = array;
                    continue;
                }
                if (property.NameEquals("expandedSourceAddressPrefix"u8))
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
                    expandedSourceAddressPrefix = array;
                    continue;
                }
                if (property.NameEquals("expandedDestinationAddressPrefix"u8))
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
                    expandedDestinationAddressPrefix = array;
                    continue;
                }
                if (property.NameEquals("access"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    access = new SecurityRuleAccess(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("priority"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    priority = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("direction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    direction = new SecurityRuleDirection(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EffectiveNetworkSecurityRule(
                name,
                protocol,
                sourcePortRange,
                destinationPortRange,
                sourcePortRanges ?? new ChangeTrackingList<string>(),
                destinationPortRanges ?? new ChangeTrackingList<string>(),
                sourceAddressPrefix,
                destinationAddressPrefix,
                sourceAddressPrefixes ?? new ChangeTrackingList<string>(),
                destinationAddressPrefixes ?? new ChangeTrackingList<string>(),
                expandedSourceAddressPrefix ?? new ChangeTrackingList<string>(),
                expandedDestinationAddressPrefix ?? new ChangeTrackingList<string>(),
                access,
                priority,
                direction,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EffectiveNetworkSecurityRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EffectiveNetworkSecurityRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EffectiveNetworkSecurityRule)} does not support '{options.Format}' format.");
            }
        }

        EffectiveNetworkSecurityRule IPersistableModel<EffectiveNetworkSecurityRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EffectiveNetworkSecurityRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEffectiveNetworkSecurityRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EffectiveNetworkSecurityRule)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EffectiveNetworkSecurityRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
