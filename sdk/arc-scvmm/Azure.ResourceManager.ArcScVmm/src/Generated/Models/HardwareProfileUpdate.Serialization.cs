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

namespace Azure.ResourceManager.ArcScVmm.Models
{
    public partial class HardwareProfileUpdate : IUtf8JsonSerializable, IJsonModel<HardwareProfileUpdate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HardwareProfileUpdate>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HardwareProfileUpdate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HardwareProfileUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(HardwareProfileUpdate)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(MemoryMB))
            {
                writer.WritePropertyName("memoryMB"u8);
                writer.WriteNumberValue(MemoryMB.Value);
            }
            if (Optional.IsDefined(CpuCount))
            {
                writer.WritePropertyName("cpuCount"u8);
                writer.WriteNumberValue(CpuCount.Value);
            }
            if (Optional.IsDefined(LimitCpuForMigration))
            {
                writer.WritePropertyName("limitCpuForMigration"u8);
                writer.WriteStringValue(LimitCpuForMigration.Value.ToString());
            }
            if (Optional.IsDefined(DynamicMemoryEnabled))
            {
                writer.WritePropertyName("dynamicMemoryEnabled"u8);
                writer.WriteStringValue(DynamicMemoryEnabled.Value.ToString());
            }
            if (Optional.IsDefined(DynamicMemoryMaxMB))
            {
                writer.WritePropertyName("dynamicMemoryMaxMB"u8);
                writer.WriteNumberValue(DynamicMemoryMaxMB.Value);
            }
            if (Optional.IsDefined(DynamicMemoryMinMB))
            {
                writer.WritePropertyName("dynamicMemoryMinMB"u8);
                writer.WriteNumberValue(DynamicMemoryMinMB.Value);
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

        HardwareProfileUpdate IJsonModel<HardwareProfileUpdate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HardwareProfileUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(HardwareProfileUpdate)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHardwareProfileUpdate(document.RootElement, options);
        }

        internal static HardwareProfileUpdate DeserializeHardwareProfileUpdate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> memoryMB = default;
            Optional<int> cpuCount = default;
            Optional<LimitCpuForMigration> limitCpuForMigration = default;
            Optional<DynamicMemoryEnabled> dynamicMemoryEnabled = default;
            Optional<int> dynamicMemoryMaxMB = default;
            Optional<int> dynamicMemoryMinMB = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("memoryMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    memoryMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("cpuCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cpuCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("limitCpuForMigration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    limitCpuForMigration = new LimitCpuForMigration(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dynamicMemoryEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dynamicMemoryEnabled = new DynamicMemoryEnabled(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dynamicMemoryMaxMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dynamicMemoryMaxMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("dynamicMemoryMinMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dynamicMemoryMinMB = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HardwareProfileUpdate(Optional.ToNullable(memoryMB), Optional.ToNullable(cpuCount), Optional.ToNullable(limitCpuForMigration), Optional.ToNullable(dynamicMemoryEnabled), Optional.ToNullable(dynamicMemoryMaxMB), Optional.ToNullable(dynamicMemoryMinMB), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HardwareProfileUpdate>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HardwareProfileUpdate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(HardwareProfileUpdate)} does not support '{options.Format}' format.");
            }
        }

        HardwareProfileUpdate IPersistableModel<HardwareProfileUpdate>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HardwareProfileUpdate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHardwareProfileUpdate(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(HardwareProfileUpdate)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HardwareProfileUpdate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
