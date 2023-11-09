// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseIntegrationRuntimeDataFlowProperties : IUtf8JsonSerializable, IJsonModel<SynapseIntegrationRuntimeDataFlowProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseIntegrationRuntimeDataFlowProperties>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<SynapseIntegrationRuntimeDataFlowProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ComputeType))
            {
                writer.WritePropertyName("computeType"u8);
                writer.WriteStringValue(ComputeType.Value.ToString());
            }
            if (Optional.IsDefined(CoreCount))
            {
                writer.WritePropertyName("coreCount"u8);
                writer.WriteNumberValue(CoreCount.Value);
            }
            if (Optional.IsDefined(TimeToLive))
            {
                writer.WritePropertyName("timeToLive"u8);
                writer.WriteNumberValue(TimeToLive.Value);
            }
            if (Optional.IsDefined(Cleanup))
            {
                writer.WritePropertyName("cleanup"u8);
                writer.WriteBooleanValue(Cleanup.Value);
            }
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        SynapseIntegrationRuntimeDataFlowProperties IJsonModel<SynapseIntegrationRuntimeDataFlowProperties>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeDataFlowProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseIntegrationRuntimeDataFlowProperties(document.RootElement, options);
        }

        internal static SynapseIntegrationRuntimeDataFlowProperties DeserializeSynapseIntegrationRuntimeDataFlowProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SynapseDataFlowComputeType> computeType = default;
            Optional<int> coreCount = default;
            Optional<int> timeToLive = default;
            Optional<bool> cleanup = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("computeType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    computeType = new SynapseDataFlowComputeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("coreCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    coreCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("timeToLive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeToLive = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("cleanup"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cleanup = property.Value.GetBoolean();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SynapseIntegrationRuntimeDataFlowProperties(Optional.ToNullable(computeType), Optional.ToNullable(coreCount), Optional.ToNullable(timeToLive), Optional.ToNullable(cleanup), additionalProperties);
        }

        BinaryData IModel<SynapseIntegrationRuntimeDataFlowProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeDataFlowProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SynapseIntegrationRuntimeDataFlowProperties IModel<SynapseIntegrationRuntimeDataFlowProperties>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeDataFlowProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSynapseIntegrationRuntimeDataFlowProperties(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<SynapseIntegrationRuntimeDataFlowProperties>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
