// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    public partial class PacketCaptureData : IUtf8JsonSerializable, IJsonModel<PacketCaptureData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PacketCaptureData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PacketCaptureData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PacketCaptureData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(PacketCaptureData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Target))
            {
                writer.WritePropertyName("target"u8);
                writer.WriteStringValue(Target);
            }
            if (Optional.IsDefined(Scope))
            {
                writer.WritePropertyName("scope"u8);
                writer.WriteObjectValue(Scope);
            }
            if (Optional.IsDefined(TargetType))
            {
                writer.WritePropertyName("targetType"u8);
                writer.WriteStringValue(TargetType.Value.ToSerialString());
            }
            if (Optional.IsDefined(BytesToCapturePerPacket))
            {
                writer.WritePropertyName("bytesToCapturePerPacket"u8);
                writer.WriteNumberValue(BytesToCapturePerPacket.Value);
            }
            if (Optional.IsDefined(TotalBytesPerSession))
            {
                writer.WritePropertyName("totalBytesPerSession"u8);
                writer.WriteNumberValue(TotalBytesPerSession.Value);
            }
            if (Optional.IsDefined(TimeLimitInSeconds))
            {
                writer.WritePropertyName("timeLimitInSeconds"u8);
                writer.WriteNumberValue(TimeLimitInSeconds.Value);
            }
            if (Optional.IsDefined(StorageLocation))
            {
                writer.WritePropertyName("storageLocation"u8);
                writer.WriteObjectValue(StorageLocation);
            }
            if (Optional.IsCollectionDefined(Filters))
            {
                writer.WritePropertyName("filters"u8);
                writer.WriteStartArray();
                foreach (var item in Filters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
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

        PacketCaptureData IJsonModel<PacketCaptureData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PacketCaptureData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(PacketCaptureData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePacketCaptureData(document.RootElement, options);
        }

        internal static PacketCaptureData DeserializePacketCaptureData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> target = default;
            Optional<PacketCaptureMachineScope> scope = default;
            Optional<PacketCaptureTargetType> targetType = default;
            Optional<long> bytesToCapturePerPacket = default;
            Optional<long> totalBytesPerSession = default;
            Optional<int> timeLimitInSeconds = default;
            Optional<PacketCaptureStorageLocation> storageLocation = default;
            Optional<IReadOnlyList<PacketCaptureFilter>> filters = default;
            Optional<NetworkProvisioningState> provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
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
                            scope = PacketCaptureMachineScope.DeserializePacketCaptureMachineScope(property0.Value);
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
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageLocation = PacketCaptureStorageLocation.DeserializePacketCaptureStorageLocation(property0.Value);
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
                                array.Add(PacketCaptureFilter.DeserializePacketCaptureFilter(item));
                            }
                            filters = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
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
            return new PacketCaptureData(id, name, type, systemData.Value, Optional.ToNullable(etag), target.Value, scope.Value, Optional.ToNullable(targetType), Optional.ToNullable(bytesToCapturePerPacket), Optional.ToNullable(totalBytesPerSession), Optional.ToNullable(timeLimitInSeconds), storageLocation.Value, Optional.ToList(filters), Optional.ToNullable(provisioningState), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PacketCaptureData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PacketCaptureData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(PacketCaptureData)} does not support '{options.Format}' format.");
            }
        }

        PacketCaptureData IPersistableModel<PacketCaptureData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PacketCaptureData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePacketCaptureData(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(PacketCaptureData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PacketCaptureData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
