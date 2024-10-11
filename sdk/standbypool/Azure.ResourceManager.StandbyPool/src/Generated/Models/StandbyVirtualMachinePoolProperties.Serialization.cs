// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StandbyPool.Models
{
    public partial class StandbyVirtualMachinePoolProperties : IUtf8JsonSerializable, IJsonModel<StandbyVirtualMachinePoolProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StandbyVirtualMachinePoolProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<StandbyVirtualMachinePoolProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StandbyVirtualMachinePoolProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StandbyVirtualMachinePoolProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ElasticityProfile))
            {
                writer.WritePropertyName("elasticityProfile"u8);
                writer.WriteObjectValue(ElasticityProfile, options);
            }
            writer.WritePropertyName("virtualMachineState"u8);
            writer.WriteStringValue(VirtualMachineState.ToString());
            if (Optional.IsDefined(AttachedVirtualMachineScaleSetId))
            {
                writer.WritePropertyName("attachedVirtualMachineScaleSetId"u8);
                writer.WriteStringValue(AttachedVirtualMachineScaleSetId);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
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
        }

        StandbyVirtualMachinePoolProperties IJsonModel<StandbyVirtualMachinePoolProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StandbyVirtualMachinePoolProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StandbyVirtualMachinePoolProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStandbyVirtualMachinePoolProperties(document.RootElement, options);
        }

        internal static StandbyVirtualMachinePoolProperties DeserializeStandbyVirtualMachinePoolProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            StandbyVirtualMachinePoolElasticityProfile elasticityProfile = default;
            StandbyVirtualMachineState virtualMachineState = default;
            ResourceIdentifier attachedVirtualMachineScaleSetId = default;
            StandbyProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("elasticityProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    elasticityProfile = StandbyVirtualMachinePoolElasticityProfile.DeserializeStandbyVirtualMachinePoolElasticityProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("virtualMachineState"u8))
                {
                    virtualMachineState = new StandbyVirtualMachineState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("attachedVirtualMachineScaleSetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    attachedVirtualMachineScaleSetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new StandbyProvisioningState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new StandbyVirtualMachinePoolProperties(elasticityProfile, virtualMachineState, attachedVirtualMachineScaleSetId, provisioningState, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StandbyVirtualMachinePoolProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StandbyVirtualMachinePoolProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StandbyVirtualMachinePoolProperties)} does not support writing '{options.Format}' format.");
            }
        }

        StandbyVirtualMachinePoolProperties IPersistableModel<StandbyVirtualMachinePoolProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StandbyVirtualMachinePoolProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStandbyVirtualMachinePoolProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StandbyVirtualMachinePoolProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StandbyVirtualMachinePoolProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
