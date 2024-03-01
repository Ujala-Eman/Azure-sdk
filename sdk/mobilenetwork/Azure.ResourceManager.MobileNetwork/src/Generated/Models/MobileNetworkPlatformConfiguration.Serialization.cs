// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.MobileNetwork;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    public partial class MobileNetworkPlatformConfiguration : IUtf8JsonSerializable, IJsonModel<MobileNetworkPlatformConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MobileNetworkPlatformConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MobileNetworkPlatformConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkPlatformConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MobileNetworkPlatformConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(PlatformType.ToString());
            if (AzureStackEdgeDevice != null)
            {
                writer.WritePropertyName("azureStackEdgeDevice"u8);
                JsonSerializer.Serialize(writer, AzureStackEdgeDevice);
            }
            if (options.Format != "W" && !(AzureStackEdgeDevices is ChangeTrackingList<WritableSubResource> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("azureStackEdgeDevices"u8);
                writer.WriteStartArray();
                foreach (var item in AzureStackEdgeDevices)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (AzureStackHciCluster != null)
            {
                writer.WritePropertyName("azureStackHciCluster"u8);
                JsonSerializer.Serialize(writer, AzureStackHciCluster);
            }
            if (ConnectedCluster != null)
            {
                writer.WritePropertyName("connectedCluster"u8);
                JsonSerializer.Serialize(writer, ConnectedCluster);
            }
            if (CustomLocation != null)
            {
                writer.WritePropertyName("customLocation"u8);
                JsonSerializer.Serialize(writer, CustomLocation);
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

        MobileNetworkPlatformConfiguration IJsonModel<MobileNetworkPlatformConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkPlatformConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MobileNetworkPlatformConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMobileNetworkPlatformConfiguration(document.RootElement, options);
        }

        internal static MobileNetworkPlatformConfiguration DeserializeMobileNetworkPlatformConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MobileNetworkPlatformType type = default;
            WritableSubResource azureStackEdgeDevice = default;
            IReadOnlyList<WritableSubResource> azureStackEdgeDevices = default;
            WritableSubResource azureStackHciCluster = default;
            WritableSubResource connectedCluster = default;
            WritableSubResource customLocation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new MobileNetworkPlatformType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("azureStackEdgeDevice"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureStackEdgeDevice = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("azureStackEdgeDevices"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WritableSubResource> array = new List<WritableSubResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                    }
                    azureStackEdgeDevices = array;
                    continue;
                }
                if (property.NameEquals("azureStackHciCluster"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureStackHciCluster = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("connectedCluster"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectedCluster = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("customLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    customLocation = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MobileNetworkPlatformConfiguration(
                type,
                azureStackEdgeDevice,
                azureStackEdgeDevices ?? new ChangeTrackingList<WritableSubResource>(),
                azureStackHciCluster,
                connectedCluster,
                customLocation,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MobileNetworkPlatformConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkPlatformConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MobileNetworkPlatformConfiguration)} does not support '{options.Format}' format.");
            }
        }

        MobileNetworkPlatformConfiguration IPersistableModel<MobileNetworkPlatformConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkPlatformConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMobileNetworkPlatformConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MobileNetworkPlatformConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MobileNetworkPlatformConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
