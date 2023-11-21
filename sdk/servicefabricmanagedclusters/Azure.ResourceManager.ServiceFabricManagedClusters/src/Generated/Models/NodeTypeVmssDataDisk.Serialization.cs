// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class NodeTypeVmssDataDisk : IUtf8JsonSerializable, IJsonModel<NodeTypeVmssDataDisk>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NodeTypeVmssDataDisk>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NodeTypeVmssDataDisk>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NodeTypeVmssDataDisk>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(NodeTypeVmssDataDisk)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("lun"u8);
            writer.WriteNumberValue(Lun);
            writer.WritePropertyName("diskSizeGB"u8);
            writer.WriteNumberValue(DiskSizeInGB);
            writer.WritePropertyName("diskType"u8);
            writer.WriteStringValue(DiskType.ToString());
            writer.WritePropertyName("diskLetter"u8);
            writer.WriteStringValue(DiskLetter);
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

        NodeTypeVmssDataDisk IJsonModel<NodeTypeVmssDataDisk>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NodeTypeVmssDataDisk>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(NodeTypeVmssDataDisk)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNodeTypeVmssDataDisk(document.RootElement, options);
        }

        internal static NodeTypeVmssDataDisk DeserializeNodeTypeVmssDataDisk(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int lun = default;
            int diskSizeGB = default;
            ServiceFabricManagedDataDiskType diskType = default;
            string diskLetter = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lun"u8))
                {
                    lun = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("diskSizeGB"u8))
                {
                    diskSizeGB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("diskType"u8))
                {
                    diskType = new ServiceFabricManagedDataDiskType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("diskLetter"u8))
                {
                    diskLetter = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NodeTypeVmssDataDisk(lun, diskSizeGB, diskType, diskLetter, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NodeTypeVmssDataDisk>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NodeTypeVmssDataDisk>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(NodeTypeVmssDataDisk)} does not support '{options.Format}' format.");
            }
        }

        NodeTypeVmssDataDisk IPersistableModel<NodeTypeVmssDataDisk>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NodeTypeVmssDataDisk>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNodeTypeVmssDataDisk(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(NodeTypeVmssDataDisk)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NodeTypeVmssDataDisk>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
