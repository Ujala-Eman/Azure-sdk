// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class ResourcesMoveContent : IUtf8JsonSerializable, IJsonModel<ResourcesMoveContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourcesMoveContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ResourcesMoveContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourcesMoveContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourcesMoveContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Resources is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("resources"u8);
                writer.WriteStartArray();
                foreach (var item in Resources)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (TargetResourceGroupId != null)
            {
                writer.WritePropertyName("targetResourceGroup"u8);
                writer.WriteStringValue(TargetResourceGroupId);
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

        ResourcesMoveContent IJsonModel<ResourcesMoveContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourcesMoveContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourcesMoveContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResourcesMoveContent(document.RootElement, options);
        }

        internal static ResourcesMoveContent DeserializeResourcesMoveContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> resources = default;
            ResourceIdentifier targetResourceGroup = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resources"u8))
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
                    resources = array;
                    continue;
                }
                if (property.NameEquals("targetResourceGroup"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetResourceGroup = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ResourcesMoveContent(resources ?? new ChangeTrackingList<string>(), targetResourceGroup, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ResourcesMoveContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourcesMoveContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ResourcesMoveContent)} does not support '{options.Format}' format.");
            }
        }

        ResourcesMoveContent IPersistableModel<ResourcesMoveContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourcesMoveContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeResourcesMoveContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ResourcesMoveContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ResourcesMoveContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
