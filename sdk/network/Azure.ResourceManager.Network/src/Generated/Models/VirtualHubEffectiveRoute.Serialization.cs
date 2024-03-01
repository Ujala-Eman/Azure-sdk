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
    public partial class VirtualHubEffectiveRoute : IUtf8JsonSerializable, IJsonModel<VirtualHubEffectiveRoute>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualHubEffectiveRoute>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VirtualHubEffectiveRoute>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualHubEffectiveRoute>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualHubEffectiveRoute)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(AddressPrefixes is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("addressPrefixes"u8);
                writer.WriteStartArray();
                foreach (var item in AddressPrefixes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(NextHops is ChangeTrackingList<string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("nextHops"u8);
                writer.WriteStartArray();
                foreach (var item in NextHops)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (NextHopType != null)
            {
                writer.WritePropertyName("nextHopType"u8);
                writer.WriteStringValue(NextHopType);
            }
            if (AsPath != null)
            {
                writer.WritePropertyName("asPath"u8);
                writer.WriteStringValue(AsPath);
            }
            if (RouteOrigin != null)
            {
                writer.WritePropertyName("routeOrigin"u8);
                writer.WriteStringValue(RouteOrigin);
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

        VirtualHubEffectiveRoute IJsonModel<VirtualHubEffectiveRoute>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualHubEffectiveRoute>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualHubEffectiveRoute)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualHubEffectiveRoute(document.RootElement, options);
        }

        internal static VirtualHubEffectiveRoute DeserializeVirtualHubEffectiveRoute(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<string> addressPrefixes = default;
            IReadOnlyList<string> nextHops = default;
            string nextHopType = default;
            string asPath = default;
            string routeOrigin = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("addressPrefixes"u8))
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
                    addressPrefixes = array;
                    continue;
                }
                if (property.NameEquals("nextHops"u8))
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
                    nextHops = array;
                    continue;
                }
                if (property.NameEquals("nextHopType"u8))
                {
                    nextHopType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("asPath"u8))
                {
                    asPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("routeOrigin"u8))
                {
                    routeOrigin = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VirtualHubEffectiveRoute(
                addressPrefixes ?? new ChangeTrackingList<string>(),
                nextHops ?? new ChangeTrackingList<string>(),
                nextHopType,
                asPath,
                routeOrigin,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VirtualHubEffectiveRoute>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualHubEffectiveRoute>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VirtualHubEffectiveRoute)} does not support '{options.Format}' format.");
            }
        }

        VirtualHubEffectiveRoute IPersistableModel<VirtualHubEffectiveRoute>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualHubEffectiveRoute>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualHubEffectiveRoute(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VirtualHubEffectiveRoute)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualHubEffectiveRoute>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
