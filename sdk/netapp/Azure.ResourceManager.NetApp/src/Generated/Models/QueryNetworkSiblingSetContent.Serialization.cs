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

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class QueryNetworkSiblingSetContent : IUtf8JsonSerializable, IJsonModel<QueryNetworkSiblingSetContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<QueryNetworkSiblingSetContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<QueryNetworkSiblingSetContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueryNetworkSiblingSetContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(QueryNetworkSiblingSetContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("networkSiblingSetId"u8);
            writer.WriteStringValue(NetworkSiblingSetId);
            writer.WritePropertyName("subnetId"u8);
            writer.WriteStringValue(SubnetId);
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

        QueryNetworkSiblingSetContent IJsonModel<QueryNetworkSiblingSetContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueryNetworkSiblingSetContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(QueryNetworkSiblingSetContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeQueryNetworkSiblingSetContent(document.RootElement, options);
        }

        internal static QueryNetworkSiblingSetContent DeserializeQueryNetworkSiblingSetContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string networkSiblingSetId = default;
            ResourceIdentifier subnetId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkSiblingSetId"u8))
                {
                    networkSiblingSetId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subnetId"u8))
                {
                    subnetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new QueryNetworkSiblingSetContent(networkSiblingSetId, subnetId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<QueryNetworkSiblingSetContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueryNetworkSiblingSetContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(QueryNetworkSiblingSetContent)} does not support '{options.Format}' format.");
            }
        }

        QueryNetworkSiblingSetContent IPersistableModel<QueryNetworkSiblingSetContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueryNetworkSiblingSetContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeQueryNetworkSiblingSetContent(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(QueryNetworkSiblingSetContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<QueryNetworkSiblingSetContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
