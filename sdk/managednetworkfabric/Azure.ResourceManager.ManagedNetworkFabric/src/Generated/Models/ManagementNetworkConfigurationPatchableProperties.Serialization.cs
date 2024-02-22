// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class ManagementNetworkConfigurationPatchableProperties : IUtf8JsonSerializable, IJsonModel<ManagementNetworkConfigurationPatchableProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagementNetworkConfigurationPatchableProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagementNetworkConfigurationPatchableProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementNetworkConfigurationPatchableProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagementNetworkConfigurationPatchableProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(InfrastructureVpnConfiguration))
            {
                writer.WritePropertyName("infrastructureVpnConfiguration"u8);
                writer.WriteObjectValue(InfrastructureVpnConfiguration);
            }
            if (Optional.IsDefined(WorkloadVpnConfiguration))
            {
                writer.WritePropertyName("workloadVpnConfiguration"u8);
                writer.WriteObjectValue(WorkloadVpnConfiguration);
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

        ManagementNetworkConfigurationPatchableProperties IJsonModel<ManagementNetworkConfigurationPatchableProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementNetworkConfigurationPatchableProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagementNetworkConfigurationPatchableProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagementNetworkConfigurationPatchableProperties(document.RootElement, options);
        }

        internal static ManagementNetworkConfigurationPatchableProperties DeserializeManagementNetworkConfigurationPatchableProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<VpnConfigurationPatchableProperties> infrastructureVpnConfiguration = default;
            Optional<VpnConfigurationPatchableProperties> workloadVpnConfiguration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("infrastructureVpnConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    infrastructureVpnConfiguration = VpnConfigurationPatchableProperties.DeserializeVpnConfigurationPatchableProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("workloadVpnConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    workloadVpnConfiguration = VpnConfigurationPatchableProperties.DeserializeVpnConfigurationPatchableProperties(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagementNetworkConfigurationPatchableProperties(infrastructureVpnConfiguration.Value, workloadVpnConfiguration.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagementNetworkConfigurationPatchableProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementNetworkConfigurationPatchableProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagementNetworkConfigurationPatchableProperties)} does not support '{options.Format}' format.");
            }
        }

        ManagementNetworkConfigurationPatchableProperties IPersistableModel<ManagementNetworkConfigurationPatchableProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementNetworkConfigurationPatchableProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagementNetworkConfigurationPatchableProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagementNetworkConfigurationPatchableProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagementNetworkConfigurationPatchableProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
