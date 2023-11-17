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
    public partial class NodeTypeSkuCapacity : IUtf8JsonSerializable, IJsonModel<NodeTypeSkuCapacity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NodeTypeSkuCapacity>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NodeTypeSkuCapacity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<NodeTypeSkuCapacity>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<NodeTypeSkuCapacity>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Minimum))
                {
                    writer.WritePropertyName("minimum"u8);
                    writer.WriteNumberValue(Minimum.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Maximum))
                {
                    writer.WritePropertyName("maximum"u8);
                    writer.WriteNumberValue(Maximum.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Default))
                {
                    writer.WritePropertyName("default"u8);
                    writer.WriteNumberValue(Default.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ScaleType))
                {
                    writer.WritePropertyName("scaleType"u8);
                    writer.WriteStringValue(ScaleType.Value.ToString());
                }
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        NodeTypeSkuCapacity IJsonModel<NodeTypeSkuCapacity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NodeTypeSkuCapacity)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNodeTypeSkuCapacity(document.RootElement, options);
        }

        internal static NodeTypeSkuCapacity DeserializeNodeTypeSkuCapacity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> minimum = default;
            Optional<int> maximum = default;
            Optional<int> @default = default;
            Optional<NodeTypeSkuScaleType> scaleType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("minimum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minimum = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maximum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maximum = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("default"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    @default = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("scaleType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scaleType = new NodeTypeSkuScaleType(property.Value.GetString());
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NodeTypeSkuCapacity(Optional.ToNullable(minimum), Optional.ToNullable(maximum), Optional.ToNullable(@default), Optional.ToNullable(scaleType), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NodeTypeSkuCapacity>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NodeTypeSkuCapacity)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        NodeTypeSkuCapacity IPersistableModel<NodeTypeSkuCapacity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NodeTypeSkuCapacity)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeNodeTypeSkuCapacity(document.RootElement, options);
        }

        string IPersistableModel<NodeTypeSkuCapacity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
