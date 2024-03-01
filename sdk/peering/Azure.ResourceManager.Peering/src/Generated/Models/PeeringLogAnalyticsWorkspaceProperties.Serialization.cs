// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Peering;

namespace Azure.ResourceManager.Peering.Models
{
    public partial class PeeringLogAnalyticsWorkspaceProperties : IUtf8JsonSerializable, IJsonModel<PeeringLogAnalyticsWorkspaceProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PeeringLogAnalyticsWorkspaceProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PeeringLogAnalyticsWorkspaceProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PeeringLogAnalyticsWorkspaceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PeeringLogAnalyticsWorkspaceProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && WorkspaceId != null)
            {
                writer.WritePropertyName("workspaceID"u8);
                writer.WriteStringValue(WorkspaceId);
            }
            if (options.Format != "W" && Key != null)
            {
                writer.WritePropertyName("key"u8);
                writer.WriteStringValue(Key);
            }
            if (options.Format != "W" && !(ConnectedAgents is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("connectedAgents"u8);
                writer.WriteStartArray();
                foreach (var item in ConnectedAgents)
                {
                    writer.WriteStringValue(item);
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

        PeeringLogAnalyticsWorkspaceProperties IJsonModel<PeeringLogAnalyticsWorkspaceProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PeeringLogAnalyticsWorkspaceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PeeringLogAnalyticsWorkspaceProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePeeringLogAnalyticsWorkspaceProperties(document.RootElement, options);
        }

        internal static PeeringLogAnalyticsWorkspaceProperties DeserializePeeringLogAnalyticsWorkspaceProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string workspaceId = default;
            string key = default;
            IReadOnlyList<string> connectedAgents = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("workspaceID"u8))
                {
                    workspaceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("key"u8))
                {
                    key = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectedAgents"u8))
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
                    connectedAgents = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PeeringLogAnalyticsWorkspaceProperties(workspaceId, key, connectedAgents ?? new ChangeTrackingList<string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PeeringLogAnalyticsWorkspaceProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PeeringLogAnalyticsWorkspaceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PeeringLogAnalyticsWorkspaceProperties)} does not support '{options.Format}' format.");
            }
        }

        PeeringLogAnalyticsWorkspaceProperties IPersistableModel<PeeringLogAnalyticsWorkspaceProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PeeringLogAnalyticsWorkspaceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePeeringLogAnalyticsWorkspaceProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PeeringLogAnalyticsWorkspaceProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PeeringLogAnalyticsWorkspaceProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
