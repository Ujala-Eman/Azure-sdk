// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppRevisionTrafficWeight : IUtf8JsonSerializable, IJsonModel<ContainerAppRevisionTrafficWeight>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppRevisionTrafficWeight>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerAppRevisionTrafficWeight>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppRevisionTrafficWeight>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppRevisionTrafficWeight)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (RevisionName != null)
            {
                writer.WritePropertyName("revisionName"u8);
                writer.WriteStringValue(RevisionName);
            }
            if (Weight.HasValue)
            {
                writer.WritePropertyName("weight"u8);
                writer.WriteNumberValue(Weight.Value);
            }
            if (IsLatestRevision.HasValue)
            {
                writer.WritePropertyName("latestRevision"u8);
                writer.WriteBooleanValue(IsLatestRevision.Value);
            }
            if (Label != null)
            {
                writer.WritePropertyName("label"u8);
                writer.WriteStringValue(Label);
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

        ContainerAppRevisionTrafficWeight IJsonModel<ContainerAppRevisionTrafficWeight>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppRevisionTrafficWeight>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppRevisionTrafficWeight)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppRevisionTrafficWeight(document.RootElement, options);
        }

        internal static ContainerAppRevisionTrafficWeight DeserializeContainerAppRevisionTrafficWeight(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string revisionName = default;
            int? weight = default;
            bool? latestRevision = default;
            string label = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("revisionName"u8))
                {
                    revisionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("weight"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    weight = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("latestRevision"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    latestRevision = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("label"u8))
                {
                    label = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerAppRevisionTrafficWeight(revisionName, weight, latestRevision, label, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerAppRevisionTrafficWeight>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppRevisionTrafficWeight>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppRevisionTrafficWeight)} does not support '{options.Format}' format.");
            }
        }

        ContainerAppRevisionTrafficWeight IPersistableModel<ContainerAppRevisionTrafficWeight>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppRevisionTrafficWeight>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppRevisionTrafficWeight(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerAppRevisionTrafficWeight)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppRevisionTrafficWeight>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
