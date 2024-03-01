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
    public partial class PacketCaptureCreateOrUpdateContent : IUtf8JsonSerializable, IJsonModel<PacketCaptureCreateOrUpdateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PacketCaptureCreateOrUpdateContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PacketCaptureCreateOrUpdateContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PacketCaptureCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PacketCaptureCreateOrUpdateContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("target"u8);
            writer.WriteStringValue(Target);
            if (Scope != null)
            {
                writer.WritePropertyName("scope"u8);
                writer.WriteObjectValue(Scope);
            }
            if (TargetType.HasValue)
            {
                writer.WritePropertyName("targetType"u8);
                writer.WriteStringValue(TargetType.Value.ToSerialString());
            }
            if (BytesToCapturePerPacket.HasValue)
            {
                writer.WritePropertyName("bytesToCapturePerPacket"u8);
                writer.WriteNumberValue(BytesToCapturePerPacket.Value);
            }
            if (TotalBytesPerSession.HasValue)
            {
                writer.WritePropertyName("totalBytesPerSession"u8);
                writer.WriteNumberValue(TotalBytesPerSession.Value);
            }
            if (TimeLimitInSeconds.HasValue)
            {
                writer.WritePropertyName("timeLimitInSeconds"u8);
                writer.WriteNumberValue(TimeLimitInSeconds.Value);
            }
            writer.WritePropertyName("storageLocation"u8);
            writer.WriteObjectValue(StorageLocation);
            if (!(Filters is ChangeTrackingList<PacketCaptureFilter> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("filters"u8);
                writer.WriteStartArray();
                foreach (var item in Filters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
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

        PacketCaptureCreateOrUpdateContent IJsonModel<PacketCaptureCreateOrUpdateContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PacketCaptureCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PacketCaptureCreateOrUpdateContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePacketCaptureCreateOrUpdateContent(document.RootElement, options);
        }

        internal static PacketCaptureCreateOrUpdateContent DeserializePacketCaptureCreateOrUpdateContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string target = default;
            PacketCaptureMachineScope scope = default;
            PacketCaptureTargetType? targetType = default;
            long? bytesToCapturePerPacket = default;
            long? totalBytesPerSession = default;
            int? timeLimitInSeconds = default;
            PacketCaptureStorageLocation storageLocation = default;
            IList<PacketCaptureFilter> filters = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("target"u8))
                        {
                            target = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("scope"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            scope = PacketCaptureMachineScope.DeserializePacketCaptureMachineScope(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("targetType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetType = property0.Value.GetString().ToPacketCaptureTargetType();
                            continue;
                        }
                        if (property0.NameEquals("bytesToCapturePerPacket"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            bytesToCapturePerPacket = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("totalBytesPerSession"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            totalBytesPerSession = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("timeLimitInSeconds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            timeLimitInSeconds = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("storageLocation"u8))
                        {
                            storageLocation = PacketCaptureStorageLocation.DeserializePacketCaptureStorageLocation(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("filters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<PacketCaptureFilter> array = new List<PacketCaptureFilter>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PacketCaptureFilter.DeserializePacketCaptureFilter(item, options));
                            }
                            filters = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PacketCaptureCreateOrUpdateContent(
                target,
                scope,
                targetType,
                bytesToCapturePerPacket,
                totalBytesPerSession,
                timeLimitInSeconds,
                storageLocation,
                filters ?? new ChangeTrackingList<PacketCaptureFilter>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PacketCaptureCreateOrUpdateContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PacketCaptureCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PacketCaptureCreateOrUpdateContent)} does not support '{options.Format}' format.");
            }
        }

        PacketCaptureCreateOrUpdateContent IPersistableModel<PacketCaptureCreateOrUpdateContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PacketCaptureCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePacketCaptureCreateOrUpdateContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PacketCaptureCreateOrUpdateContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PacketCaptureCreateOrUpdateContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
