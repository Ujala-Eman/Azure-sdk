// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.NetApp;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class NetAppVolumeGroupMetadata : IUtf8JsonSerializable, IJsonModel<NetAppVolumeGroupMetadata>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetAppVolumeGroupMetadata>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetAppVolumeGroupMetadata>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppVolumeGroupMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetAppVolumeGroupMetadata)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (GroupDescription != null)
            {
                writer.WritePropertyName("groupDescription"u8);
                writer.WriteStringValue(GroupDescription);
            }
            if (ApplicationType.HasValue)
            {
                writer.WritePropertyName("applicationType"u8);
                writer.WriteStringValue(ApplicationType.Value.ToString());
            }
            if (ApplicationIdentifier != null)
            {
                writer.WritePropertyName("applicationIdentifier"u8);
                writer.WriteStringValue(ApplicationIdentifier);
            }
            if (!(GlobalPlacementRules is ChangeTrackingList<NetAppVolumePlacementRule> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("globalPlacementRules"u8);
                writer.WriteStartArray();
                foreach (var item in GlobalPlacementRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && VolumesCount.HasValue)
            {
                writer.WritePropertyName("volumesCount"u8);
                writer.WriteNumberValue(VolumesCount.Value);
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

        NetAppVolumeGroupMetadata IJsonModel<NetAppVolumeGroupMetadata>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppVolumeGroupMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetAppVolumeGroupMetadata)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetAppVolumeGroupMetadata(document.RootElement, options);
        }

        internal static NetAppVolumeGroupMetadata DeserializeNetAppVolumeGroupMetadata(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string groupDescription = default;
            NetAppApplicationType? applicationType = default;
            string applicationIdentifier = default;
            IList<NetAppVolumePlacementRule> globalPlacementRules = default;
            long? volumesCount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("groupDescription"u8))
                {
                    groupDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("applicationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    applicationType = new NetAppApplicationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("applicationIdentifier"u8))
                {
                    applicationIdentifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("globalPlacementRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NetAppVolumePlacementRule> array = new List<NetAppVolumePlacementRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NetAppVolumePlacementRule.DeserializeNetAppVolumePlacementRule(item, options));
                    }
                    globalPlacementRules = array;
                    continue;
                }
                if (property.NameEquals("volumesCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    volumesCount = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetAppVolumeGroupMetadata(
                groupDescription,
                applicationType,
                applicationIdentifier,
                globalPlacementRules ?? new ChangeTrackingList<NetAppVolumePlacementRule>(),
                volumesCount,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetAppVolumeGroupMetadata>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppVolumeGroupMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetAppVolumeGroupMetadata)} does not support '{options.Format}' format.");
            }
        }

        NetAppVolumeGroupMetadata IPersistableModel<NetAppVolumeGroupMetadata>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppVolumeGroupMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetAppVolumeGroupMetadata(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetAppVolumeGroupMetadata)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetAppVolumeGroupMetadata>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
