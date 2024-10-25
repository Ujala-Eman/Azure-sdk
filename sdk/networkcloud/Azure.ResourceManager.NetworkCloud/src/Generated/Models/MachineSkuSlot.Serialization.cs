// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class MachineSkuSlot : IUtf8JsonSerializable, IJsonModel<MachineSkuSlot>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineSkuSlot>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineSkuSlot>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineSkuSlot>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineSkuSlot)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(RackSlot))
            {
                writer.WritePropertyName("rackSlot"u8);
                writer.WriteNumberValue(RackSlot.Value);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(BootstrapProtocol))
            {
                writer.WritePropertyName("bootstrapProtocol"u8);
                writer.WriteStringValue(BootstrapProtocol.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(CpuCores))
            {
                writer.WritePropertyName("cpuCores"u8);
                writer.WriteNumberValue(CpuCores.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CpuSockets))
            {
                writer.WritePropertyName("cpuSockets"u8);
                writer.WriteNumberValue(CpuSockets.Value);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Disks))
            {
                writer.WritePropertyName("disks"u8);
                writer.WriteStartArray();
                foreach (var item in Disks)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(Generation))
            {
                writer.WritePropertyName("generation"u8);
                writer.WriteStringValue(Generation);
            }
            if (options.Format != "W" && Optional.IsDefined(HardwareVersion))
            {
                writer.WritePropertyName("hardwareVersion"u8);
                writer.WriteStringValue(HardwareVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(MemoryCapacityGB))
            {
                writer.WritePropertyName("memoryCapacityGB"u8);
                writer.WriteNumberValue(MemoryCapacityGB.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Model))
            {
                writer.WritePropertyName("model"u8);
                writer.WriteStringValue(Model);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(NetworkInterfaces))
            {
                writer.WritePropertyName("networkInterfaces"u8);
                writer.WriteStartArray();
                foreach (var item in NetworkInterfaces)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(TotalThreads))
            {
                writer.WritePropertyName("totalThreads"u8);
                writer.WriteNumberValue(TotalThreads.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Vendor))
            {
                writer.WritePropertyName("vendor"u8);
                writer.WriteStringValue(Vendor);
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
        }

        MachineSkuSlot IJsonModel<MachineSkuSlot>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineSkuSlot>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineSkuSlot)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineSkuSlot(document.RootElement, options);
        }

        internal static MachineSkuSlot DeserializeMachineSkuSlot(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            long? rackSlot = default;
            BootstrapProtocol? bootstrapProtocol = default;
            long? cpuCores = default;
            long? cpuSockets = default;
            IReadOnlyList<MachineDisk> disks = default;
            string generation = default;
            string hardwareVersion = default;
            long? memoryCapacityGB = default;
            string model = default;
            IReadOnlyList<NetworkCloudNetworkInterface> networkInterfaces = default;
            long? totalThreads = default;
            string vendor = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rackSlot"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rackSlot = property.Value.GetInt64();
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
                        if (property0.NameEquals("bootstrapProtocol"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            bootstrapProtocol = new BootstrapProtocol(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("cpuCores"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            cpuCores = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("cpuSockets"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            cpuSockets = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("disks"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<MachineDisk> array = new List<MachineDisk>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MachineDisk.DeserializeMachineDisk(item, options));
                            }
                            disks = array;
                            continue;
                        }
                        if (property0.NameEquals("generation"u8))
                        {
                            generation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hardwareVersion"u8))
                        {
                            hardwareVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("memoryCapacityGB"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            memoryCapacityGB = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("model"u8))
                        {
                            model = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("networkInterfaces"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<NetworkCloudNetworkInterface> array = new List<NetworkCloudNetworkInterface>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NetworkCloudNetworkInterface.DeserializeNetworkCloudNetworkInterface(item, options));
                            }
                            networkInterfaces = array;
                            continue;
                        }
                        if (property0.NameEquals("totalThreads"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            totalThreads = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("vendor"u8))
                        {
                            vendor = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MachineSkuSlot(
                rackSlot,
                bootstrapProtocol,
                cpuCores,
                cpuSockets,
                disks ?? new ChangeTrackingList<MachineDisk>(),
                generation,
                hardwareVersion,
                memoryCapacityGB,
                model,
                networkInterfaces ?? new ChangeTrackingList<NetworkCloudNetworkInterface>(),
                totalThreads,
                vendor,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MachineSkuSlot>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineSkuSlot>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineSkuSlot)} does not support writing '{options.Format}' format.");
            }
        }

        MachineSkuSlot IPersistableModel<MachineSkuSlot>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineSkuSlot>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineSkuSlot(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineSkuSlot)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineSkuSlot>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
